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
    public partial class UserDetailsForm : Form
    {
        public UserDetailsForm()
        {
            InitializeComponent();
            cbxProfile.Items.Add("Administrador");
            cbxProfile.Items.Add("Gerente");
            cbxProfile.Items.Add("Funcionário");
            cbxProfile.SelectedIndex = 0;
            tbxPassword.PasswordChar = '*';
            tbxRepeatPassword.PasswordChar = '*';
            tbxPassword.MaxLength = 10;
            tbxRepeatPassword.MaxLength = 10;

        }

        string name;
        string email;
        string password;
        string repeatPassword;
        string profile;


        private void pbxBack_Click(object sender, EventArgs e)
        {
           
          
            this.Close();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            GetData();
            MessageBox.Show("Registrado com Sucesso");
            ClearData();
        }


        void GetData()
        {
            name = tbxName.Text;
            password = tbxPassword.Text;
            repeatPassword = tbxRepeatPassword.Text;
            email = tbxEmail.Text;
            profile = cbxProfile.Text;

        }
        void ClearData()
        {
            tbxName.Text = "";
            tbxPassword.Text = "";
            tbxRepeatPassword.Text = "";
            tbxEmail.Text = "";
            cbxProfile.SelectedIndex = 0;
        }

    }
}
