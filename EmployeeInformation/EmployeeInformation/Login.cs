using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DatabaseLayer;

namespace EmployeeInformation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            DbConnection db = new DbConnection();
            
            dataTable=db.CommonMethodSelection("select username,password from Emp_Login where username='"+txtbox_Uname.Text+"'and password='"+txtbox_Pwd.Text+"' ");
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Login succeed");
                Main m = new Main();
                m.Show();
                this.Hide();

                

            }
            else
            {
                MessageBox.Show("Invalid credential!");
            }


        }

        private void Txtbox_Uname_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtbox_Uname.Text))
            {
                e.Cancel = true;
                txtbox_Uname.Focus();
                errorProvider1.SetError(txtbox_Uname, "Enter username!!");

            }
        }

        private void Txtbox_Pwd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_Pwd.Text))
            {
                e.Cancel = true;
                txtbox_Pwd.Focus();
                errorProvider2.SetError(txtbox_Pwd, "Enter password!!");
            }
            
        }

        
    }
}
