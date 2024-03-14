using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordCracker
{
   

    public class Password
    {
        string Whichhash = "";
        int hashLocation = 0;

        private string _raw;
        private string _hash;
        private static int Count;

        public Password(string raw, string hash)
        {
            _raw = raw;
            _hash = hash;
        }

        //getters

        public string GetRaw() => _raw;
        public string GetHash() => _hash;

        //crack password
        public void CrackPassword(string hash)
        {
             hash = "";
           
            for (int lcv = 0; lcv < Password.Count; ++lcv)
            {
                if(hash == _raw)
                {
                    Whichhash = hash;
                    hashLocation = lcv;
                    
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
