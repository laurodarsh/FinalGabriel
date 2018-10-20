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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            tbxPassword.PasswordChar = '*';
            tbxPassword.MaxLength = 10;
        }
        string name;
        string password;
        string role;

        List<Function> functions = new List<Function>();
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try{
                GetData();
                Function f = new Function(name, password, role);
                functions.Add(f);
                HomeForm h = new HomeForm(f);
                h.Show();
               
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ClearData();
            }

        }
       
        void GetData()
        {
            name = tbxName.Text;
            password = tbxPassword.Text;
            if (name == "Gabriel Cards" && password == "C4rds")
            {
                role = "Employeer";
            }
            else
            {
                role = "Employee";
            }

        }
        void ClearData()
        {
            tbxName.Text = "";
            tbxPassword.Text = "";
        }

        private void btnMiss_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm fp = new ForgetPasswordForm();
            fp.Show();
        }

    }
}
