using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkScanner
{
    public class Computer
    {
        string WhichIP = "";
        int IPLocation = 0;

        private string _name;
        private string _ipAddress;
        private string _services;
        private static int Count;

        public Computer(string name, string ipAddress, string services)
        {
            _name = name;
            _ipAddress = ipAddress;
            _services = services;
        }

        //getters

        public string GetName() => _name;
        public string GetipAddress() => _ipAddress;
        public string GetServices() => _services;


        public void ScanIpAddress(string ipAddress)
        {
            ipAddress = "";

            for (int lcv = 0; lcv < Computer.Count; ++lcv)
            {
                if (ipAddress == _services || ipAddress == _name)
                {
                    WhichIP = ipAddress;
                    IPLocation = lcv;

                }
                else
                {
                    ShowErrorMessage("Hash Code Doesnt Match", "INVALID INPUT");

                }

            }
        }



        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }



    }
}
