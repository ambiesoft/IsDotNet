using System;
using System.Windows.Forms;
using System.Text;

using Ambiesoft;

namespace IsDotNet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StringBuilder sbMessage = new StringBuilder();
            sbMessage.AppendFormat("IsNet45OrNewer = {0}", AmbLib.IsNet45OrNewer());
            sbMessage.AppendLine();
            sbMessage.AppendFormat("IsNet46OrNewer = {0}", AmbLib.IsNet46OrNewer());
            sbMessage.AppendLine();
            sbMessage.AppendFormat("IsNet461OrNewer = {0}", AmbLib.IsNet461OrNewer());
            sbMessage.AppendLine();
            sbMessage.AppendFormat("IsNet462OrNewer = {0}", AmbLib.IsNet462OrNewer());
            sbMessage.AppendLine();
            sbMessage.AppendFormat("IsNet47OrNewer = {0}", AmbLib.IsNet47OrNewer());
            sbMessage.AppendLine();
            sbMessage.AppendFormat("IsNet48OrNewer = {0}", AmbLib.IsNet48OrNewer());
            sbMessage.AppendLine();

            MessageBox.Show(sbMessage.ToString(),
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
