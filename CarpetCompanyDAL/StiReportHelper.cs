using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Stimulsoft.Report;

namespace CarpetCompanyDAL
{
    public class StiReportHelper
    {
        public static StiReport GetReport()
        {
            StiReport rpt = new StiReport();
            string path = Path.Combine(Application.StartupPath, "Report", "ListHesabs.mrt");
            string stiDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Stimulsoft");
            string stiDir_license = Path.Combine(stiDir, "license.key");
            if (!File.Exists(stiDir_license))
            {
                string license = Path.Combine(Application.StartupPath, "Report", "license.key");
                File.Copy(license, stiDir_license);
            }
            rpt.Load(path);
            return rpt;
        }
    }
}
