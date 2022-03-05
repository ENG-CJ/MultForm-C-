using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysLogin
{
    public partial class Dashboard : Form
    {
        public static string userDisplay;
        public Dashboard()
        {
            InitializeComponent();
            
        }


        public string UserDisplay { get { return userDisplay; } set { userDisplay = value; } }  
        private void Dashboard_Load(object sender, EventArgs e)
        {
            DisplayUser.Text = UserDisplay;
        }

        private void CloseBtn(object sender, EventArgs e)
        {
           DialogResult message=MessageBox.Show("Are You Sure To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if (message.HasFlag(DialogResult.No))
            {
                return;
            }
           else if (message.HasFlag(DialogResult.Yes))
            {
                TetraLogin tetraLogin = new TetraLogin();
                tetraLogin.Show();
                this.Hide();
              
            }
            
        }

        private void DashLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HidePannel(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Are you Sure To Hide The Dev pannel?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message.HasFlag(DialogResult.No))
            {
                return;
            }
                
            else if (message.HasFlag(DialogResult.Yes))
            {
                DevPannel.Visible = false;
            }
        }

        private void ShowDevPannel(object sender, EventArgs e)
        {
            if (DisplayUser.Text=="ENG-CJ")
                DevPannel.Visible = true;
            else
                MessageBox.Show("This User Is Not Support\nThe Dev Pannel","User Support Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void devLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
