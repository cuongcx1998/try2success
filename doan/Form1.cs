using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Text.RegularExpressions;



namespace doan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabctrl.SelectedIndex == 0)
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2",
                                                                  "SELECT * FROM Win32_BIOS");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    richtxtShow.Text = Convert.ToString("Name:" + queryObj["Name"] + "\n" + "SerialNumBer :" + queryObj["SerialNumber"] + "\n" + "Version: " + queryObj["Version"]
                        + "\n" + "Caption: " + queryObj["Caption"] + "\n" + "CurrentLanguage: " + queryObj["CurrentLanguage"]
                        + "\n" + "Description: " + queryObj["Description"] + "\n" + "EmbeddedControllerMajorVersion: " + queryObj["EmbeddedControllerMajorVersion"]
                        + "\n" + "ReleaseDate: " + queryObj["ReleaseDate"]);
                }
                panel1.BackgroundImage = Properties.Resources.bios;

            }
            if (tabctrl.SelectedIndex == 1)
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2",
                                                     "SELECT * FROM Win32_NetworkAdapterConfiguration");


                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if (queryObj["IPAddress"] == null)
                        richtxtShow.Text = Convert.ToString("IPAddress: " + queryObj["IPAddress"] + "\n" + "DNSHostName: " + queryObj["DNSHostName"]
                                + "\n" + "IPConnectionMetric: " + queryObj["IPConnectionMetric"] + "\n" + "DefaultTTL: " + queryObj["DefaultTTL"]
                                + "\n" + "Description: " + queryObj["Description"] + "\n" + "SettingID: " + queryObj["SettingID"] + "\n" +
                                "MACAddress: " + queryObj["MACAddress"] + "\n" + "Caption: " + queryObj["Caption"] + "\n" + "DatabasePath: " + queryObj["DatabasePath"]);
                    else
                    {
                        String[] arrIPAddress = (String[])(queryObj["IPAddress"]);
                        foreach (String arrValue in arrIPAddress)
                        {
                            richtxtShow.Text = Convert.ToString("IPAddress: " + arrValue + "\n" + "DNSHostName: " + queryObj["DNSHostName"]
                                + "\n" + "IPConnectionMetric: " + queryObj["IPConnectionMetric"] + "\n" + "DefaultTTL: " + queryObj["DefaultTTL"]
                                + "\n" + "Description: " + queryObj["Description"] + "\n" + "SettingID: " + queryObj["SettingID"] + "\n" +
                                "MACAddress: " + queryObj["MACAddress"] + "\n" + "Caption: " + queryObj["Caption"] + "\n" + "DatabasePath: " + queryObj["DatabasePath"]);
                        }
                    }
                }
                panel1.BackgroundImage = Properties.Resources.network;
            }

            if (tabctrl.SelectedIndex == 2)
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2",
                                                                     "SELECT * FROM Win32_Processor");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    richtxtShow.Text = Convert.ToString("Name:" + queryObj["Name"] + "\n"
                        + "Number of core: " + queryObj["NumberOfCores"] + "\n" + "Number Of LogicalProcessors: " + queryObj["NumberOfLogicalProcessors"]
                        + "\n" + "ThreadCount: " + queryObj["ThreadCount"] + "\n" + "Caption: " + queryObj["Caption"] + "\n" +
                        "AddressWidth: " + queryObj["AddressWidth"] + "\n" + "ProcessorId: " + queryObj["ProcessorId"] + "\n"
                        + "Role: " + queryObj["Role"] + "\n" + "SocketDesignation: " + queryObj["SocketDesignation"] + "\n" +
                        "SystemCreationClassName: " + queryObj["SystemCreationClassName"]);
                }
                panel1.BackgroundImage = Properties.Resources.processor;
            }

            if (tabctrl.SelectedIndex == 3)
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2",
                                                                   "SELECT * FROM Win32_BaseBoard");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    richtxtShow.Text = Convert.ToString("SerialNumber: " + queryObj["SerialNumber"] + "\n" + "Product: " + queryObj["Product"]
                        + "\n" + "CreationClassName: " + queryObj["CreationClassName"] + "\n" + "Version: " + queryObj["Version"]);
                }
                panel1.BackgroundImage = Properties.Resources.mainboard;
            }

            if (tabctrl.SelectedIndex == 4)
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2",
                                                                            "SELECT * FROM Win32_Battery");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    richtxtShow.Text = Convert.ToString("Name: " + queryObj["Name"] + "\n" + "Caption: " + queryObj["Caption"] + "\n" +
                                   "Status: " + queryObj["Status"] + "\n" + "Availability: " + queryObj["Availability"] + "\n" + "Chemistry: " + queryObj["Chemistry"]
                                   + "\n" + "CreationClassName: " + queryObj["CreationClassName"] + "\n" + "EstimatedRunTime(ms): " + queryObj["EstimatedRunTime"]);
                }
                panel1.BackgroundImage = Properties.Resources.battery;
            }

            if (tabctrl.SelectedIndex == 5)
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_VideoController");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    richtxtShow.Text = Convert.ToString("AdapterCompatibility: " + queryObj["AdapterCompatibility"] + "\n" +
                        "AdapterRAM: " + queryObj["AdapterRAM"] + "\n" + "CurrentBitsPerPixel: " + queryObj["CurrentBitsPerPixel"]
                        + "\n" + "CurrentRefreshRate: " + queryObj["CurrentRefreshRate"] + "\n" +
                        "CurrentNumberOfColors: " + queryObj["CurrentNumberOfColors"] + "\n" + "Name: " + queryObj["Name"] + "\n" +
                        "VideoModeDescription: " + queryObj["VideoModeDescription"]);
                }
                panel1.BackgroundImage = Properties.Resources.graphic;
            }

            if (tabctrl.SelectedIndex == 6)
            {
                ManagementObjectSearcher searcher =
                   new ManagementObjectSearcher("root\\CIMV2",
                   "SELECT * FROM Win32_Registry");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    richtxtShow.Text = Convert.ToString("Caption: " + queryObj["Caption"] + "\n" +
                        "CurrentSize: " + queryObj["CurrentSize"] + "\n" + "Description: " + queryObj["Description"]
                        + "\n" + "InstallDate: " + queryObj["InstallDate"] + "\n" + "MaximumSize: " + queryObj["MaximumSize"]
                        + "\n" + "Name: " + queryObj["Name"] + "\n" + "ProposedSize: " + queryObj["ProposedSize"]
                        + "\n" + "Status: " + queryObj["Status"]);
                }
                panel1.BackgroundImage = Properties.Resources.registry;
            }

            if (tabctrl.SelectedIndex == 7)
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_PhysicalMemory");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    richtxtShow.Text = Convert.ToString("Capacity: " + queryObj["Capacity"] + "\n" + "DataWidth: " + queryObj["DataWidth"]
                        + "\n" + "MemoryType: " + queryObj["MemoryType"] + "\n" + "SMBIOSMemoryType: " + queryObj["SMBIOSMemoryType"]
                        + "\n" + "TotalWidth: " + queryObj["TotalWidth"] + "\n" + "TypeDetail: " + queryObj["TypeDetail"]);
                }
                panel1.BackgroundImage = Properties.Resources.memory;
            }

        }

        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.FormSize = this.Size;
                Properties.Settings.Default.Save();
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.FormSize.Width != 0 && Properties.Settings.Default.FormSize.Height != 0)
            {
                this.Size = Properties.Settings.Default.FormSize;
            }
            
            
        }

        public void btnShow_Click(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(sender, e);

        }

        public void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string pattern = "(?<resolution>[0-9]{3,4}.{0,1}[x].{0,1}[0-9]{3,4}).[x].(?<NumbersOfColor>[0-9]+.[a-z]+)";
            Regex reg1 = new Regex(pattern);
            MatchCollection matcol = reg1.Matches(richtxtShow.Text);
            foreach (Match match in matcol)
            {
                richtxtShow.Text = Convert.ToString(@"Độ phân giải: " + match.Groups["resolution"].Value + "\n"+ 
                                                     @"Số điểm màu: " + match.Groups["NumbersOfColor"].Value);
            }
        }
    }
}
