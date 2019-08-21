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
using BusinessEntity;

namespace EmployeeInformation
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void LinkLabel_EmpPersonal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonalInfo info = new PersonalInfo();
            info.Show();
            this.Hide();
        }



        private void LinkLabel_WorkDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WorkDetails wd = new WorkDetails();
            wd.Show();
            this.Hide();

        }

        private void LinkLabel_BankDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BankDetails bank = new BankDetails();
            bank.Show();
            this.Hide();

        }

        private void LinkLabel_EmpInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OverView ov = new OverView();
            ov.Show();
            this.Hide();

        }
    }
}
