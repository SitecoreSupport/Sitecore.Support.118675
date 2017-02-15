using Sitecore.Configuration;
using Sitecore.Diagnostics;
using Sitecore.IO;
using System;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Support.Collections;
using Sitecore.Support.Diagnostics.PerformanceCounters;

namespace Sitecore.Support.Tasks
{
    public class CounterDumpAgent
    {
        private string m_dumpFile;

        public CounterDumpAgent()
        {
            this.DumpFile = Settings.DataFolder + "/diagnostics/counters.txt";
        }

        private Sitecore.Diagnostics.PerformanceCounters.AmountPerSecondCounter[] GetCounters()
        {
            Sitecore.Diagnostics.PerformanceCounters.AmountPerSecondCounter[] array = this.GetAmountPerSecondCounters().ToArray();
            Array.Sort(array, new PerformanceCounterComparer());
            return array;
        }

        private PerformanceCounterCollection GetAmountPerSecondCounters()
        {
            PerformanceCounterCollection counters = new PerformanceCounterCollection();
            Type ancestorType = typeof(Sitecore.Diagnostics.PerformanceCounters.AmountPerSecondCounter);
            foreach (Type type2 in Assembly.GetExecutingAssembly().GetExportedTypes())
            {
                if (type2.Name.EndsWith("Count", StringComparison.InvariantCulture))
                {
                    foreach (PropertyInfo info in type2.GetProperties(BindingFlags.Public | BindingFlags.Static))
                    {
                        if (MainUtil.IsType(info.PropertyType, ancestorType))
                        {
                            counters.Add(info.GetValue(null, null) as Sitecore.Diagnostics.PerformanceCounters.AmountPerSecondCounter);
                        }
                    }
                }
            }
            return counters;
        }

        private string GetReport(Sitecore.Diagnostics.PerformanceCounters.AmountPerSecondCounter[] counters)
        {
            string category = "";
            bool flag = false;
            StringBuilder builder = new StringBuilder(counters.Length * 100);
            builder.AppendFormat("<report date='{0}'>\r\n", DateUtil.IsoNow);
            for (int i = 0; i < counters.Length; i++)
            {
                Sitecore.Diagnostics.PerformanceCounters.AmountPerSecondCounter counter = counters[i];
                if (counter.Category != category)
                {
                    if (flag)
                    {
                        builder.Append("  </category>\r\n");
                    }
                    builder.AppendFormat("  <category name='{0}'>\r\n", counter.Category);
                    flag = true;
                    category = counter.Category;
                }
                builder.AppendFormat("    <counter name='{0}' value='{1}' category='{2}'/>\r\n", counter.Name, counter.Value, counter.Category);
            }
            if (flag)
            {
                builder.Append("  </category>\r\n");
            }
            builder.Append("</report>\r\n");
            return builder.ToString();
        }

        public void Run()
        {
            Sitecore.Diagnostics.PerformanceCounters.AmountPerSecondCounter[] counters = this.GetCounters();
            string report = this.GetReport(counters);
            this.WriteReport(report);
        }

        private void WriteReport(string report)
        {
            string filePath = this.m_dumpFile.Replace("{datetime}", DateUtil.IsoNow).Replace("{date}", DateUtil.IsoNowDate).Replace("{time}", DateUtil.IsoNowTime);
            FileUtil.EnsureFileFolder(filePath);
            FileUtil.WriteToFile(filePath, report, true);
        }

        public string DumpFile
        {
            get
            {
                return this.m_dumpFile;
            }
            set
            {
                Assert.ArgumentNotNullOrEmpty(value, "value");
                string path = value.Replace("{processid}", MainUtil.GetProcessID().ToString()).Replace("$(dataFolder)", Settings.DataFolder);
                this.m_dumpFile = FileUtil.MapPath(path);
            }
        }
    }
}
