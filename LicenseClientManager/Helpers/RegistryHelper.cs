using Microsoft.Win32;

namespace LicenseClientManager.Helpers
{
    public static class RegistryHelper
    {
        public static string GetActivationKeyFromRegistryIfPresent()
        {
            RegistryKey pdfPrinterEntry = Registry.CurrentUser.OpenSubKey("Software\\Bullzip\\PDF Printer", false);
            if (pdfPrinterEntry != null)
            {
                var ActivationKey = pdfPrinterEntry.GetValue("ActivationKey");
                pdfPrinterEntry.Close();
                return ActivationKey?.ToString().ToLower();
            }
            else
            {
                return null;
            }
        }
    }
}
