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
using BusinessLogic;
using DatabaseLayer;

namespace EmployeeInformation
{
    public partial class OverView : Form
    {
        DbConnection db;
        EmployeeLogic _employeeLogic;
        DataTable _dt;
        public OverView()
        {
            InitializeComponent();
            _employeeLogic = new EmployeeLogic();
            db = new DbConnection();
            _dt = new DataTable();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            _dt = _employeeLogic.GetEmployeeRecord();
            var dt = db.GetRecordUsingProc("GetEmployeeDetails");
            dgDetails.DataSource = dt;

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee emp = new Employee();
            emp.Show();
        }
    }
}
