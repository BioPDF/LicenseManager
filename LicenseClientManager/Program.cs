using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseClientManager.Helpers;
using Microsoft.VisualBasic.ApplicationServices;

namespace LicenseClientManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new MainForm());
                SingleInstanceController controller = new SingleInstanceController();
                controller.Run(args);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + Environment.NewLine +
                                "Arguments: " + Environment.CommandLine, $"{Application.ProductName} - Startup error occurred", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public class SingleInstanceController : WindowsFormsApplicationBase
        {
            public SingleInstanceController()
            {
                IsSingleInstance = true;
                StartupNextInstance += this_StartupNextInstance;
            }

            void this_StartupNextInstance(object sender, StartupNextInstanceEventArgs e)
            {
                ProgramHelper.RevertToSelf();
                MainForm form = MainForm as MainForm;
                form.ProcessArguments(e.CommandLine.ToArray(), false);
            }
            protected override void OnCreateMainForm()
            {
                //ValidateSystemSettings();
                MainForm = new MainForm();
            }
        }

    }
}
