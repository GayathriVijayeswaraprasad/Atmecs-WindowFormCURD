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
using BusinessEntity;
using BusinessLogic;

namespace EmployeeInformation
{
    public partial class BankDetails : Form
    {

        DbConnection db;
        EmpBank empBank;
        EmployeeLogic employee;
        
        public BankDetails()
        {
            InitializeComponent();
            empBank = new EmpBank();
            employee = new EmployeeLogic();
            db = new DbConnection();
            

        } 

        private void BankDetails_Load(object sender, EventArgs e)
        {
            var dt1 = db.CommonMethodSelection("select Deptname from DepartmentDetails");
            cmbDeptName.ValueMember = "DepartmentDetails";
            foreach(DataRow dr in dt1.Rows)
            {
                cmbDeptName.Items.Add(dr["Deptname"].ToString());
            }

            var dt2 = db.CommonMethodSelection("select Emp_Id from Emp_Personal");
            cmbEmpId.ValueMember = "Emp_Personal";

            foreach(DataRow dr in dt2.Rows)
            {
                cmbEmpId.Items.Add(dr["Emp_Id"].ToString());
            }
            var dt = db.CommonMethodSelection("select*from BankDetails");
            dgBankDetails.DataSource = dt;



        }

        private void CmbDeptName_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  var selectedText = ((System.Data.DataRowView)cmbDeptName.SelectedItem).Row.ItemArray[1];

            SqlConnection connection = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = EmployeeInfo; Integrated Security = True");
            SqlDataAdapter da = new SqlDataAdapter("select DeptId from DepartmentDetails where Deptname='" + cmbDeptName.Text + "'", connection);
            DataTable data = new DataTable();
            da.Fill(data);

            foreach(DataRow item in data.Rows)
            {
                string deptid = (string)item["DeptId"].ToString();
                txtDeptId.Text = deptid;
            }
             
      
        }

        private void CmbEmpId_SelectedIndexChanged(object sender, EventArgs e)
        {
           // var selectedText = ((System.Data.DataRowView)cmbEmpId.SelectedItem).Row.ItemArray[1];
            SqlConnection connection = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = EmployeeInfo; Integrated Security = True");
            SqlDataAdapter da = new SqlDataAdapter("select Emp_Name from Emp_Personal where Emp_Id='" + cmbEmpId.Text + "'", connection);
            DataTable data = new DataTable();
            da.Fill(data);

            foreach (DataRow item in data.Rows)
            {
                string empname= (string)item["Emp_Name"].ToString();
                txtEmpName.Text = empname;
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            int deptid = Convert.ToInt32(txtDeptId.Text);
            int empid = Convert.ToInt32(cmbEmpId.Text);
            string bank = txtBankName.Text;
            string acno = txtAcNo.Text;
            string pfno =txtPFno.Text;
            int netpay = Convert.ToInt32(txtNetpay.Text);
            int pfamt = Convert.ToInt32(txtPFamt.Text);
            empBank.deptid = deptid;
            empBank.empid = empid;
            empBank.bank = bank;
            empBank.acno = acno;
            empBank.netpay = netpay;
            empBank.pfno = pfno;
            empBank.pfamt = pfamt;
            int i = employee.InsertBankDetails(empBank);
            if (i > 0)
            {
                MessageBox.Show("Details Inserted");
                txtAcNo.Clear();
                txtBankName.Clear();
                txtDeptId.Clear();
                txtEmpName.Clear();
                txtNetpay.Clear();
                txtPFamt.Clear();
                txtPFno.Clear();
                cmbDeptName.Text = "";
                cmbEmpId.Text = "";

              var dt=  db.CommonMethodSelection("select*from BankDetails");
                dgBankDetails.DataSource = dt;

            }
           
            
        }

        DataTable dt = new DataTable();
        int rowIndex=0;
        private void BtnUpdate_Click(object sender, EventArgs e)

        {
            int deptid = Convert.ToInt32(txtDeptId.Text);
            string deptname = cmbDeptName.Text;
            int empid = Convert.ToInt32(cmbEmpId.Text);
            string bank = txtBankName.Text;
            string acno = txtAcNo.Text;
            string pfno = txtPFno.Text;
            int netpay = Convert.ToInt32(txtNetpay.Text);
            int pfamt = Convert.ToInt32(txtPFamt.Text);
            empBank.deptid = deptid;
            empBank.deptname = deptname;
            empBank.empid = empid;
            empBank.bank = bank;
            empBank.acno = acno;
            empBank.netpay = netpay;
            empBank.pfno = pfno;
            empBank.pfamt = pfamt;
            int i = employee.UpdateBankDetails(empBank);
            if (i > 0)
            {
                MessageBox.Show("Details Updated");
                txtAcNo.Clear();
                txtBankName.Clear();
                txtDeptId.Clear();
                txtEmpName.Clear();
                txtNetpay.Clear();
                txtPFamt.Clear();
                txtPFno.Clear();
                cmbDeptName.Text = "";
                cmbEmpId.Text = "";
            }

                var dt = db.CommonMethodSelection("select*from BankDetails");
                dgBankDetails.DataSource = dt;
            DataGridViewRow row = dgBankDetails.Rows[rowIndex];
            row.Cells[0].Value = cmbEmpId.Text;
            row.Cells[1].Value = txtDeptId.Text;
            row.Cells[2].Value = txtBankName.Text;
            row.Cells[3].Value = txtAcNo.Text;
            row.Cells[4].Value = txtNetpay.Text;
            row.Cells[5].Value = txtPFno.Text;
            row.Cells[6].Value = txtPFamt.Text;


        }

        private void DgBankDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex!=-1)
            {
                DataGridViewRow row = dgBankDetails.Rows[rowIndex];
                cmbEmpId.Text = row.Cells[0].Value.ToString();
                txtDeptId.Text = row.Cells[1].Value.ToString();
                txtBankName.Text = row.Cells[2].Value.ToString();
                txtAcNo.Text = row.Cells[3].Value.ToString();
                txtNetpay.Text = row.Cells[4].Value.ToString();
                txtPFno.Text = row.Cells[5].Value.ToString();
                txtPFamt.Text = row.Cells[6].Value.ToString();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int empid = Convert.ToInt32(cmbEmpId.Text);
            empBank.empid = empid;
            int i = employee.DeleteBankDetails(empBank);
            MessageBox.Show("Deleted Successfully");

           var dt= db.CommonMethodSelection("select*from BankDetails");
            dgBankDetails.DataSource = dt;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee emp = new Employee();
            emp.Show();
        }
    }
}
