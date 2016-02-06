using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.IO;
using System.Data.SQLite;

namespace GoogleChromeHistory
{
    public partial class frmMain : Form
    {
        ArrayList history;
        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            //exports all of the history to a text file
        }

        private Boolean getHistory()
        {
            this.closeChrome();
            try
            {
                history = new ArrayList();
                string chromeHistoryFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                chromeHistoryFile += @"\Google\Chrome\User Data\Default\History";
                if (File.Exists(chromeHistoryFile))
                {
                    SQLiteConnection connection = new SQLiteConnection("Data Source=" + chromeHistoryFile + ";Version=3;New=False;Compress=True;");
                    connection.Open();
                    DataSet dataset = new DataSet();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from urls order by last_visit_time desc", connection);
                    adapter.Fill(dataset);
                    if (dataset != null && dataset.Tables.Count > 0 & dataset.Tables[0] != null)
                    {
                        DataTable dt = dataset.Tables[0];
                        foreach (DataRow historyRow in dt.Rows)
                        {

                            HistoryItem historyItem = new HistoryItem(historyRow["url"].ToString());
                            if(chTime.Checked)
                            {
                                long utcMicroSeconds = Convert.ToInt64(historyRow["last_visit_time"]);
                                DateTime gmtTime = DateTime.FromFileTimeUtc(10 * utcMicroSeconds);
                                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(gmtTime, TimeZoneInfo.Local);
                                historyItem.visitedTime = localTime;
                            }
                            if (chTitle.Checked)
                                historyItem.title = historyRow["title"].ToString();

                            history.Add(historyItem);
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private Boolean closeChrome()
        {
            //closes google chrome so that this program can open the history sql file
            try
            {
                Process[] processNames = Process.GetProcessesByName("chrome");

                foreach (Process item in processNames)
                {
                    item.Kill();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
    public class HistoryItem
    {
        public string url;
        public string title;
        public DateTime visitedTime;
        public string domain;
        public HistoryItem(String URLNew)
        {
            url = URLNew;
            
        }
        public string toStringDisplay()
        {
            return url + "  " + title + "  " + visitedTime.ToString() + " " +  domain;
        }

    }
}
