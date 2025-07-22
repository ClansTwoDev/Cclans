using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CClans_v2
{
    public partial class Form1 : Form
    {
        string notDeleted;
        public Form1()
        {
            InitializeComponent();

            WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);
            if (!hasAdministrativeRight)
            {
                // relaunch the application with admin rights
                string fileName = Assembly.GetExecutingAssembly().Location;
                ProcessStartInfo processInfo = new ProcessStartInfo();
                processInfo.Verb = "runas";
                processInfo.FileName = fileName;

                try
                {
                    Process.Start(processInfo);
                }
                catch
                {
                }

                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo temp = new DirectoryInfo("C:\\Windows\\Temp");
            DirectoryInfo prefetch = new DirectoryInfo("C:\\Windows\\Prefetch");
            DirectoryInfo updates = new DirectoryInfo("C:\\Windows\\SoftwareDistribution\\Download");
            DirectoryInfo temp2 = new DirectoryInfo(System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\AppData\\Local\\Temp");
            DirectoryInfo explorerTemp = new DirectoryInfo(System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\AppData\\Local\\Microsoft\\Windows\\Explorer");
            DirectoryInfo delivery = new DirectoryInfo("C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization");
            DirectoryInfo recycle = new DirectoryInfo("C:\\$Recycle.Bin");
            DirectoryInfo ieCache = new DirectoryInfo(System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\AppData\\Local\\Microsoft\\Windows\\INetCache");
            DirectoryInfo errors = new DirectoryInfo("C:\\ProgramData\\Microsoft\\Windows\\WER");

            Process.Start("WSReset.exe");
            delet(temp);
            delet(prefetch);
            delet(temp2);
            delet(updates);
            delet(explorerTemp);
            delet(delivery);
            delet(recycle);
            delet(ieCache);
            delet(errors);
            var feedback = MessageBox.Show("Cleaning successful! \nSome files were not deleted, would you like to show the logs?", "CClans V2", MessageBoxButtons.YesNo);

            if (feedback == DialogResult.Yes)
            {
                MessageBox.Show(notDeleted, "CClans V2 error repoting", 0);
                notDeleted = null;
            }

        }

        void delet(DirectoryInfo dir)
        {
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    file.Delete();
                }
                catch (Exception e) { notDeleted += e; }
            }
            foreach (DirectoryInfo subDirectory in dir.GetDirectories())
            {
                try
                {
                    subDirectory.Delete(true);
                }
                catch (Exception e) { notDeleted += e; }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c powercfg.exe /hibernate off";
            p.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c powercfg.exe /hibernate on";
            p.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c DISM /Online /Cleanup-Image /StartComponentCleanup";
            p.Start();
        }
    }
}
