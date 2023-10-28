using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mstaheri__
{
    public class StiReportHelper
    {
        public static StiReport GetReport(string reportName)
        {
            StiReport rpt = new StiReport();
            string path = Path.Combine(Application.StartupPath, "Report", reportName);
            string stiDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Stimulsoft");
            string stiDir_license = Path.Combine(stiDir, "license.key");
            if (!File.Exists(stiDir_license))
            {
                string license = Path.Combine(Application.StartupPath, "Report", "license.key");
                File.Copy(license, stiDir_license);
            }
            string stiDir_account = Path.Combine(stiDir, "account.dat");
            if (!File.Exists(stiDir_account))
            {
                string account = Path.Combine(Application.StartupPath, "Report", "account.dat");
                File.Copy(account, stiDir_account);
            }
            rpt.Load(path);
            return rpt;
        }
    }
}
