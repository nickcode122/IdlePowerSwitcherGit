using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace IdlePowerSwitcher
{

    public partial class Main : Form
    {
        //List variables
        string highpoweroption;
        string lowpoweroption;
        uint lastInputuint;
        string lastInputstring;
        bool MinimizedSetting;
        TimeSpan time;
        TimeSpan currentIdleTime;
        RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        [DllImport("user32.dll")]
        static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);
        internal struct LASTINPUTINFO
        {
            public uint cbSize;

            public uint dwTime;
        }
        #region PowerSettingEnumeration
        [DllImport("PowrProf.dll")]
        public static extern UInt32 PowerEnumerate(IntPtr RootPowerKey, IntPtr SchemeGuid, IntPtr SubGroupOfPowerSettingGuid, UInt32 AcessFlags, UInt32 Index, ref Guid Buffer, ref UInt32 BufferSize);

        [DllImport("PowrProf.dll")]
        public static extern UInt32 PowerReadFriendlyName(IntPtr RootPowerKey, ref Guid SchemeGuid, IntPtr SubGroupOfPowerSettingGuid, IntPtr PowerSettingGuid, IntPtr Buffer, ref UInt32 BufferSize);

        [DllImport("powrProf.dll")]
        public static extern uint PowerGetActiveScheme(IntPtr UserRootPowerKey, ref IntPtr ActivePolicyGuid);

        [DllImport("PowrProf.dll")]
        public static extern uint PowerSetActiveScheme(IntPtr UserRootPowerKey, ref Guid SchemeGuid);

        List<String> lsFriendly = new List<string>();
        List<Guid> lsGuid = new List<Guid>();
        public enum AccessFlags : uint
        {
            ACCESS_SCHEME = 16,
            ACCESS_SUBGROUP = 17,
            ACCESS_INDIVIDUAL_SETTING = 18
        }

        private static string ReadFriendlyName(Guid schemeGuid)
        {
            uint sizeName = 1024;
            IntPtr pSizeName = Marshal.AllocHGlobal((int)sizeName);

            string friendlyName;

            try
            {
                PowerReadFriendlyName(IntPtr.Zero, ref schemeGuid, IntPtr.Zero, IntPtr.Zero, pSizeName, ref sizeName);
                friendlyName = Marshal.PtrToStringUni(pSizeName);
            }
            finally
            {
                Marshal.FreeHGlobal(pSizeName);
            }

            return friendlyName;
        }

        public static IEnumerable<Guid> GetAll()
        {
            var schemeGuid = Guid.Empty;

            uint sizeSchemeGuid = (uint)Marshal.SizeOf(typeof(Guid));
            uint schemeIndex = 0;

            while (PowerEnumerate(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, (uint)AccessFlags.ACCESS_SCHEME, schemeIndex, ref schemeGuid, ref sizeSchemeGuid) == 0)
            {
                yield return schemeGuid;
                schemeIndex++;
            }

        }
        public void SetActive(Guid powerSchemeId)
        {
            var schemeGuid = powerSchemeId;

            Main.PowerSetActiveScheme(IntPtr.Zero, ref schemeGuid);
        }

        public Guid GetActive()
        {
            IntPtr pCurrentSchemeGuid = IntPtr.Zero;

            Main.PowerGetActiveScheme(IntPtr.Zero, ref pCurrentSchemeGuid);

            var currentSchemeGuid = (Guid)Marshal.PtrToStructure(pCurrentSchemeGuid, typeof(Guid));

            return currentSchemeGuid;
        }
        #endregion

        public static bool ScrLockActive()
        {
            return Control.IsKeyLocked(Keys.Scroll);
        }

        public Main()
        {
            InitializeComponent();
            LoadSettings();
            isStartupChecked();
            populatePlans();

        }

        private void populatePlans()
        {
            //Get all current power plans
            var guidPlans = GetAll();

            foreach (Guid guidPlan in guidPlans)
            {
                //Add guid and friendly name into corresponding lists
                lsGuid.Add(guidPlan);
                lsFriendly.Add(ReadFriendlyName(guidPlan));

                //Populate ComboBoxes
                cbLowOption.Items.Add(ReadFriendlyName(guidPlan));
                cbHighOption.Items.Add(ReadFriendlyName(guidPlan));
            }
            lblTest.Text = ReadFriendlyName(GetActive());
        }
        private void isStartupChecked()
        {
            //Check to see if program is set to run on startup
            if (rk.GetValue("IdlePowerSwitcher") == null)
            {
                //Not set to run on start
                chkStartup.Checked = false;
            }
            else
            {
                //Is set to run on start
                chkStartup.Checked = true;
            }
        }
        private void LoadSettings()
        {
            highpoweroption = Properties.Settings.Default.HighPowerOption;
            lowpoweroption = Properties.Settings.Default.LowPowerOption;
            sliderIdle.Value = Properties.Settings.Default.IdleTimeWait;
            //Format label text for time.
            time = TimeSpan.FromSeconds(sliderIdle.Value);
            lblSelectedIdleTime.Text = time.ToString(@"mm\:ss");

            cbHighOption.Text = highpoweroption;
            cbLowOption.Text = lowpoweroption;
            MinimizedSetting = Properties.Settings.Default.MinimizeOnStart;
            //Load minimized setting... minimize on startup if box is checked.
            if (MinimizedSetting) { chkMinimize.Checked = true; WindowState = FormWindowState.Minimized; ShowInTaskbar = false; }
           
        }

        static uint GetLastInputTime()
        {
            uint idleTime = 0;
            LASTINPUTINFO lastInputInfo = new LASTINPUTINFO();
            lastInputInfo.cbSize = (uint)Marshal.SizeOf(lastInputInfo);
            lastInputInfo.dwTime = 0;

            uint envTicks = (uint)Environment.TickCount;

            if (GetLastInputInfo(ref lastInputInfo))
            {
                uint lastInputTick = lastInputInfo.dwTime;

                idleTime = envTicks - lastInputTick;
            }
            return ((idleTime > 0) ? (idleTime / 1000) : 0);
        }

        private void sliderIdle_Scroll(object sender, EventArgs e)
        {
            time = TimeSpan.FromSeconds(sliderIdle.Value);
            lblSelectedIdleTime.Text = time.ToString(@"mm\:ss");
            btnApply.Enabled = true;
        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            //Set settings
            Properties.Settings.Default.HighPowerOption = cbHighOption.Text;
            Properties.Settings.Default.LowPowerOption = cbLowOption.Text;
            Properties.Settings.Default.IdleTimeWait = sliderIdle.Value;
            Properties.Settings.Default.MinimizeOnStart = chkMinimize.Checked;
            Properties.Settings.Default.Save();

            CheckRunOnStart();
            btnApply.Enabled = false;
        }

        private void CheckRunOnStart()
        {


            if (chkStartup.Checked)
                rk.SetValue("IdlePowerSwitcher", Application.ExecutablePath.ToString());
            else
                rk.DeleteValue("IdlePowerSwitcher", false);

        }

        private void SetHighPowerOption()
        {
            highpoweroption = cbHighOption.Text;
            int a = lsFriendly.IndexOf(highpoweroption);
            Guid guida = lsGuid[a];
            //Set PowerOption
            SetActive(guida);
            //Update Text

            lblTest.Text = ReadFriendlyName(GetActive());
        }
        private void SetLowPowerOption()
        {
            lowpoweroption = cbLowOption.Text;
            int a = lsFriendly.IndexOf(lowpoweroption);
            Guid guida = lsGuid[a];

            //Set PowerOption
            SetActive(guida);
            //Update Text
            lblTest.Text = ReadFriendlyName(GetActive());
        }
        
        private void timeScrollLock_Tick(object sender, EventArgs e)
        {
            

            if (ScrLockActive())
            {
                //Stop auto switch while scroll lock is enabled.
                timerIdleTime.Enabled = false;
                //Switch to high power automatically
                SetHighPowerOption();
            }
            else
            {
                timerIdleTime.Enabled = true;
                
            }
        }
        private void timerIdleTime_Tick(object sender, EventArgs e)
        {
            lastInputuint = GetLastInputTime();
            lastInputstring = lastInputuint.ToString();


            if (lastInputuint == 0)
            {
                try
                {
                    SetHighPowerOption();
                }
                catch (Exception)
                { }
            }
            else if (lastInputuint >= (sliderIdle.Value))
            {
                try
                {
                    SetLowPowerOption();
                }
                catch (Exception)
                { }

            }
            currentIdleTime = TimeSpan.FromSeconds(lastInputuint);
            lblLastInput.Text = currentIdleTime.ToString(@"mm\:ss");

        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(200);
                Hide();
            }
            else if (FormWindowState.Normal == WindowState)
            {
                notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            openFromTaskbar();
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            openFromTaskbar();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFromTaskbar();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void openFromTaskbar()
        {
            WindowState = FormWindowState.Minimized;
            Show();
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

        private void cbHighandLowOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void chkStartup_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void chkMinimize_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void llblChangePower_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("powercfg.cpl");
        }

        private void minimizeToSystemTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox1 = new AboutBox();
            aboutBox1.Show();
        }
    }
}
