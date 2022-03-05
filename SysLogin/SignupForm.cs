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
    public partial class SignupForm : KryptonForm
    {

        public static  string userSignUp;
        public static string passwordSignUp;    
        public SignupForm()
        {
            InitializeComponent();
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
      

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public static string UserSignUp { get { return userSignUp; } }
        public static string PasswordSignUp { get { return passwordSignUp; } }  

        private void SignupForm_Load(object sender, EventArgs e)
        {
            Username.Focus();
        }

        private void SignUp(object sender, EventArgs e)
        {
            if (Validations.IsBlank(Username.Text,Email.Text,Passcode.Text,confirmPasccode.Text))
                MessageBox.Show("ALL FIELDS ARE REQUIRED","Error | Blank",MessageBoxButtons.OK,MessageBoxIcon.Error);
           
            else if (Validations.IsValidEmail(Email.Text))
                    MessageBox.Show("Invalid Email plz Provide Valid Email", "Error | Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
            
            else if (Validations.IsConfirmed(confirmPasccode.Text,Passcode.Text))
            {
                MessageBox.Show($"Confirm Pasword Must Match The Prev Password", "Error | Matching Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (Validations.MaxLength(Passcode.Text))
                MessageBox.Show("Password MaxLength and MinLength is 7Charcts", "Error | Password Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                userSignUp = Username.Text;
                passwordSignUp = Passcode.Text;
                MessageBox.Show($"User [{Username.Text}] Created Successfully\nBack To Login Page And Login With Your Name", "Admin | User Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TetraLogin loginPage = new TetraLogin();
                loginPage.Show();
                this.Hide();

            }
        }

        private void BackToLogin(object sender, EventArgs e)
        {
            TetraLogin tetraLogi = new TetraLogin();
            tetraLogi.Show();
            this.Hide();
        }
    }
}
