using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace SysLogin
{
    public partial class TetraLogin : KryptonForm
    {
        public string user;
        public string password;
       
        public TetraLogin()
        {
            InitializeComponent();
            user = "ENG-CJ";
            password = "123";
            
        }
     

      
        // signIn Method
        private void SignIn(object sender, EventArgs e)
        {
            if (Validations.IsBlank(userInput.Text, PassInput.Text))
            {
                MessageBox.Show("Input Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userInput.Focus();
              
              
            }
            // from Local Users
            else if (Validations.IsValidUser(userInput.Text.ToUpper(), user, PassInput.Text,password.ToUpper()))
            {

                Dashboard dashboard = new Dashboard();
                dashboard.UserDisplay = userInput.Text.ToUpper();
                MessageBox.Show($"Login Sucessfully", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dashboard.Show();
                this.Hide();

            }
            // from signUp Page
            else if (Validations.IsValidUser(userInput.Text, SignupForm.UserSignUp, PassInput.Text, SignupForm.PasswordSignUp))
            {
                Dashboard dashboard=new Dashboard();
                dashboard.UserDisplay = userInput.Text;
                MessageBox.Show($"Login Sucessfully", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dashboard.Show();
                this.Hide();

            }


            else
                MessageBox.Show("Invalid Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TetraLogin_Load(object sender, EventArgs e)
        {
            ShowPasscodeImage.BringToFront();
            MaximizeBox = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpPage(object sender, EventArgs e)
        {
            SignupForm form = new SignupForm(); 
            form.Show();
            this.Hide();
            
        }




        private void HidePass(object sender, EventArgs e)
        {
            if (PassInput.PasswordChar == '\0')
            {
                PassInput.PasswordChar = '*';
                ShowPasscodeImage.BringToFront();    
            }
               
        }
        private void ShowPass(object sender, EventArgs e)
        {
            if (PassInput.PasswordChar == '*')
            {
                PassInput.PasswordChar = '\0';
                HidePasscodeImage.BringToFront();
            }
              
        }

       
    }
}
