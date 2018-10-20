using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalGabriel
{
    public partial class HomeForm : Form
    {

        List<Function> functions = new List<Function>();
        public HomeForm(Function f)
        {
         
            InitializeComponent();
          
            MessageBox.Show(f.Role);
            if(f.Role == "Employee")
            {
                pbCategory.Enabled = false;
                pbLog.Enabled = false;
                pbCategory.BackColor = Color.Gray;
                pbLog.BackColor = Color.Gray;
            }
        }
        string name;
        string password;
        string role;



        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbCategory_Click(object sender, EventArgs e)
        {
            CategoryDetailsForm cdf = new CategoryDetailsForm();
            cdf.Show();
            this.Close();
        }

        private void pbUser_Click(object sender, EventArgs e)
        {
            UserDetailsForm udf = new UserDetailsForm();
            udf.Show();
            this.Close();
        }

        private void pbProduct_Click(object sender, EventArgs e)
        {

        }

        private void pbxProduct_MouseEnter(object sender, EventArgs e)
        {
            pbProduct.BackColor = Color.LightGray;
        }
        private void pbxCategory_MouseEnter(object sender, EventArgs e)
        {
            pbCategory.BackColor = Color.LightGray;
        }
        private void pbxUser_MouseEnter(object sender, EventArgs e)
        {
            pbUser.BackColor = Color.LightGray;
        }
        private void pbxProfile_MouseEnter(object sender, EventArgs e)
        {
            pbProfile.BackColor = Color.LightGray;
        }
        private void pbxLog_MouseEnter(object sender, EventArgs e)
        {
            pbLog.BackColor = Color.LightGray;
        }
        private void pbxProduct_MouseLeave(object sender, EventArgs e)
        {
            pbProduct.BackColor = Color.Transparent;
        }
        private void pbxCategory_MouseLeave(object sender, EventArgs e)
        {
            pbCategory.BackColor = Color.Transparent;
        }
        private void pbxUser_MouseLeave(object sender, EventArgs e)
        {
            pbUser.BackColor = Color.Transparent;
        }
        private void pbxProfile_MouseLeave(object sender, EventArgs e)
        {
            pbProfile.BackColor = Color.Transparent;
        }
        private void pbxLog_MouseLeave(object sender, EventArgs e)
        {
            pbLog.BackColor = Color.Transparent;

        }
    }
    
}
