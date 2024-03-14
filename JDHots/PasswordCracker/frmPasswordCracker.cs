using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PasswordCracker
{
    public partial class frmPasswordCracker : Form
    {

        List<Password> password = new List<Password>();
        int passwordLocation = 0;
        int hashLocation = 0;

        string whichhash = "";
        public frmPasswordCracker()
        {
            InitializeComponent();

            
          
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            AttemptToCrack();
            
        }

        private void AttemptToCrack()
        {
            
            string hash = "";
            string hashStr = txtHash.Text.Trim();

            if (string.IsNullOrEmpty(hashStr))
            {
                ShowErrorMessage("You Must Enter a valid Hash", "Invalid Hash");
                return;
            }

           
                password[hashLocation].CrackPassword(hash);
                DisplayInfo();

        }

        private void DisplayInfo()
        {
            lblResult.Text = "";
            int local = passwordLocation;

            string outputStr = "";

            outputStr += "Your Password Is:" + password[local].GetRaw();

            lblResult.Text = outputStr;
        }



        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void frmPasswordCracker_Load(object sender, EventArgs e)
        {
            password.Add(new Password("Chicken", "a9514f8884af954749b66932d8a95a76"));
            password.Add(new Password("Burger", "496451f3d45d2f22ba6695e53b3a2e12"));
            password.Add(new Password("Pizza", "c6586b2e09d0ed0ee6431a1bb280657f"));
        }
    }
}
