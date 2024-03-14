using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkScanner
{
    public partial class frmIPAddress : Form
    {
        List<Computer> computer = new List<Computer>();

        int IPLocation = 0;

        public frmIPAddress()
        {
            InitializeComponent();


        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            string ipAddress = "";
            string IPStr = txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(IPStr))
            {
                ShowErrorMessage("You Must Enter a valid Hash", "Invalid Hash");
                return;
            }


            computer[IPLocation].ScanIpAddress(ipAddress);
            ShowComputer();
        }

       

        private void ShowComputer()
        {
            lblResult.Text = "";
            int local = IPLocation;

            string outputStr = "";

            outputStr += "Your Password Is:" + computer[local].GetName();

            lblResult.Text = outputStr;

            string outputServiceStr = "";

            outputServiceStr += "SERVICES:" + computer[local].GetServices();

            lblResult2.Text = outputServiceStr;
        }

        private void frmIPAddress_Load(object sender, EventArgs e)
        {
            computer.Add(new Computer("My-Desktop", "127.0.0.1", "20, 21, 23, 25, 53, 80, 123, 389, 443"));
            computer.Add(new Computer("google-public-dns-a", "8.8.8.8", "53"));
            computer.Add(new Computer("ranken.edu", "47.44.246.80", "25, 80, 443"));
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
