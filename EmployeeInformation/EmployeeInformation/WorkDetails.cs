using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntity;
using BusinessLogic;
using DatabaseLayer;
using System.Data.SqlClient;

namespace EmployeeInformation
{
    public partial class WorkDetails : Form
    {
        DbConnection db;
        EmpWork empwork;
        EmployeeLogic emp;
        
        
        public WorkDetails()
        {
            InitializeComponent();
            db = new DbConnection();
            empwork = new EmpWork();
            emp = new EmployeeLogic();
            }
          

        private void WorkDetails_Load(object sender, EventArgs e)
        {
            var dt1 = db.CommonMethodSelection("select DeptName from DepartmentDetails");
            cmbDeptName.ValueMember = "DepartmentDetails";
            foreach (DataRow dr in dt1.Rows)
            {
                cmbDeptName.Items.Add(dr["DeptName"].ToString());
            }

            var dt2 = db.CommonMethodSelection("select Emp_Id from Emp_Personal");
            cmbEmpId.ValueMember = "Emp_Personal";

            foreach (DataRow dr in dt2.Rows)
            {
                cmbEmpId.Items.Add(dr["Emp_Id"].ToString());
            }
            var dt = db.CommonMethodSelection("select*from EmpWork");
            dgWorkDetails.DataSource = dt;
        }

        private void CmbEmpId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectEmployeeName(cmbEmpId.Text);
            //SqlConnection connection = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = EmployeeInfo; Integrated Security = True");
            //SqlDataAdapter da = new SqlDataAdapter("select Emp_Name from Emp_Personal where Emp_Id='" + cmbEmpId.Text + "'", connection);
            //DataTable data = new DataTable();
            //da.Fill(data);

            //foreach (DataRow item in data.Rows)
            //{
            //    string empname = (string)item["Emp_Name"].ToString();
            //    txtEmpName.Text = empname;
            //}
        }

        private void CmbDeptName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = EmployeeInfo; Integrated Security = True");
            SqlDataAdapter da = new SqlDataAdapter("select DeptId from DepartmentDetails where DeptName='" + cmbDeptName.Text + "'", connection);
            DataTable data = new DataTable();
            da.Fill(data);

            foreach (DataRow item in data.Rows)
            {
                string deptid = (string)item["DeptId"].ToString();
                txtDeptId.Text = deptid;
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            int empid = Convert.ToInt32(cmbEmpId.Text);
            string empname = txtEmpName.Text;
            string deptname = cmbDeptName.Text;
            int deptid = Convert.ToInt32(txtDeptId.Text);
            string desig = txtDesig.Text;
            int salary = Convert.ToInt32(txtSalary.Text);
            string manager = txtManager.Text;
            string exp = txtExp.Text;
            string attend = txtAttd.Text;
            empwork.empid = empid;
            empwork.empname = empname;
            empwork.deptid = deptid;
            empwork.deptname = deptname;
            empwork.designation = desig;
            empwork.salary = salary;
            empwork.manager = manager;
            empwork.experience = exp;
            empwork.attendance = attend;
            int i = emp.InsertWorkDetails(empwork);
            if(i>0)
            {
                MessageBox.Show("Details Inserted!");
            }
            txtAttd.Clear();
            txtDeptId.Clear();
            txtDesig.Clear();
            txtEmpName.Clear();
            txtExp.Clear();
            txtManager.Clear();
            txtSalary.Clear();
            cmbDeptName.Text = "";
            cmbEmpId.Text = "";
            var dt = db.CommonMethodSelection("select*from EmpWork");
            dgWorkDetails.DataSource = dt;
        }

        DataTable dt = new DataTable();
        int rowIndex = 0;
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            empwork.empid = Convert.ToInt32(cmbEmpId.Text);
            empwork.empname = txtEmpName.Text;
            empwork.deptid = Convert.ToInt32(txtDeptId.Text);
            empwork.deptname = cmbDeptName.Text;
            empwork.designation = txtDesig.Text;
            empwork.manager = txtManager.Text;
            empwork.salary = Convert.ToInt32(txtSalary.Text);
            empwork.experience = txtExp.Text;
            empwork.attendance = txtAttd.Text;
            int i = emp.UpdateWorkDetails(empwork);
            if (i > 0)
            {
                MessageBox.Show("Details Updated!");
            }

            var dt = db.CommonMethodSelection("select*from EmpWork");
            dgWorkDetails.DataSource = dt;
            DataGridViewRow row = dgWorkDetails.Rows[rowIndex];
            row.Cells[0].Value = Convert.ToInt32(cmbEmpId.Text);
            row.Cells[1].Value = Convert.ToInt32(txtDeptId.Text);
            row.Cells[2].Value = txtDesig.Text;
            row.Cells[3].Value = txtManager.Text;
            row.Cells[4].Value = txtAttd.Text;
            row.Cells[5].Value = txtSalary.Text;
            row.Cells[6].Value = txtExp.Text;

            txtAttd.Clear();
            txtDeptId.Clear();
            txtDesig.Clear();
            txtEmpName.Clear();
            txtExp.Clear();
            txtManager.Clear();
            txtSalary.Clear();
            cmbDeptName.Text = "";
            cmbEmpId.Text = "";

        }

        private void DgWorkDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            rowIndex = e.RowIndex;
            if (rowIndex !=-1)
            {
                DataGridViewRow row = dgWorkDetails.Rows[rowIndex];
                cmbEmpId.Text = row.Cells[0].Value.ToString();
                SelectEmployeeName(cmbEmpId.Text);
                txtDeptId.Text = row.Cells[1].Value.ToString();
                txtDesig.Text = row.Cells[2].Value.ToString();
                txtManager.Text = row.Cells[3].Value.ToString();
                txtAttd.Text = row.Cells[4].Value.ToString();
                txtSalary.Text = row.Cells[5].Value.ToString();
                txtExp.Text = row.Cells[6].Value.ToString();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int empid = Convert.ToInt32(cmbEmpId.Text);
            empwork.empid = empid;
            int i = emp.DeleteWorkDetails(empwork);
            MessageBox.Show("Deleted Successfully");

            var dt = db.CommonMethodSelection("select*from EmpWork");
            dgWorkDetails.DataSource = dt;
        }

        private void SelectEmployeeName(string empId)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = EmployeeInfo; Integrated Security = True");
            SqlDataAdapter da = new SqlDataAdapter("select Emp_Name from Emp_Personal where Emp_Id='" + cmbEmpId.Text + "'", connection);
            DataTable data = new DataTable();
            da.Fill(data);

            foreach (DataRow item in data.Rows)
            {
                string empname = (string)item["Emp_Name"].ToString();
                txtEmpName.Text = empname;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee emp = new Employee();
            emp.Show();
        }
    }
}
