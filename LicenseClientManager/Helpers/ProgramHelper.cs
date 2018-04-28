using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LicenseClientManager.Helpers
{
    enum ExitCode : int
    {
        Success = 0,
        NoParameters = 1,
        InvalidParameters = 2,
        SuccessExit = 3,
        UnknownError = 10
    }

    public static class ProgramHelper
    {

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        /// A boolean value indicates the function succeeded or not.
        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RevertToSelf();

        public static MainForm mainform;

        public static MainForm GetMainForm(out bool isNew)
        {
            if (mainform == null)
            {
                mainform = new MainForm();
                isNew = true;
            }
            else
            {
                isNew = false;
            }
            return mainform;
        }

        public static void SetProcessAsForegroundWindow(int processId)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName("PdfStudio");
                if (processes.Length > 0)
                    SetForegroundWindow(processes[processId].MainWindowHandle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"{Application.ProductName} - Error occurred (AsForground)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static string CurrentVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        public static string GetProgramPath()
        {
            var executingAssembly = Assembly.GetExecutingAssembly().Location;
            return Path.GetDirectoryName(executingAssembly);
        }

        public static string GetFullProgramPath()
        {
            return Assembly.GetExecutingAssembly().Location;
        }

        public static IEnumerable<FileInfo> AllFilesIn(string path, bool recursively = false)
        {
            return new DirectoryInfo(path)
                        .EnumerateFiles("*.*", recursively ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
        }
        public static IEnumerable<FileInfo> AllFilesInApplicationFolder()
        {
            var uri = new Uri(Assembly.GetExecutingAssembly().CodeBase);
            return AllFilesIn(Path.GetDirectoryName(uri.LocalPath));
        }

        public static Dictionary<string, string> GetArguments(string commandLine)
        {
            //if (commandLine.Contains(" open "))
            //    commandLine = commandLine.Replace(" open ", " /open ");
 
            List<string> arguments = commandLine.Split('/').ToList();
            Dictionary<string, string> argumentPair = GetArgumentPair(arguments);

            arguments = null;

            return argumentPair;
        }

        public static Dictionary<string, string> GetArgumentPair(List<string> arguments)
        {
            Dictionary<string, string> argumentPair = new Dictionary<string, string>();

            string key = "";
            string value = "";
            foreach (var argument in arguments)
            {
                if (argument.IndexOf('/') == 0)
                {
                    key = argument.Substring(1);
                }
                else
                {
                    //key = argument.Substring(0, argument.IndexOf(' '));
                    value = argument; //.Substring(argument.IndexOf(' ') + 1);
                    value = value.Trim();
                    value = value.Trim(new char[] { '\r', '\n' });
                    value = value.Trim(new char[] { '\"', '\"' });
                    if (key.Length > 0)
                    {
                        argumentPair.Add(key, value);
                    }
                }
            }

            return argumentPair;
        }

        public static int GetMainFormCount()
        {
            return Application.OpenForms.OfType<MainForm>().Count();
        }

        public static bool IsNumeric(string text)
        {
            try
            {
                int value = Convert.ToInt16(text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
