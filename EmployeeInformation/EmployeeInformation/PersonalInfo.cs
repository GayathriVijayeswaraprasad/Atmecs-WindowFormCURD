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
using DatabaseLayer;
using BusinessLogic;

namespace EmployeeInformation
{
    public partial class PersonalInfo : Form
    {
        EmpPersonal emp;
        EmployeeLogic employee;
        DbConnection db;
        
        public PersonalInfo()
        {
            InitializeComponent();
            emp = new EmpPersonal();
            employee = new EmployeeLogic();
            db = new DbConnection();
        }

        

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            string name = txtBox_EmpName.Text;
            string dob = txtBox_Dob.Text;
            DateTime date = Convert.ToDateTime(dob);
            string email = txtBox_Email.Text;
            string phno = txtBox_Phno.Text;
            string address = txtBox_Address.Text;
            string gender = txtBox_Gender.Text;
            emp.EmpName = name;
            emp.Dob = date;
            emp.EmailId = email;
            emp.PhNo = phno;
            emp.Address = address;
            emp.gender = gender;
            int i = employee.InsertEmppersonal(emp);
            if(i>0)
            {
                MessageBox.Show("Records inserted");
            }
            txtBox_Address.Clear();
            txtBox_Dob.Clear();
            txtBox_Email.Clear();
            txtbox_Empid.Clear();
            txtBox_EmpName.Clear();
            txtBox_Gender.Clear();
            txtBox_Phno.Clear();

        }

        private void Dg_PersonalInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void PersonalInfo_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True");
            SqlDataAdapter ad = new SqlDataAdapter("select * from Emp_Personal", con);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dg_PersonalInfo.DataSource = ds.Tables[0];
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee emp = new Employee();
            emp.Show();

        }

        DataTable table = new DataTable();
        int rowindex;


        private void Btn_Update_Click(object sender, EventArgs e)
        {
            int empid = Convert.ToInt32(txtbox_Empid.Text);
            string name = txtBox_EmpName.Text;
            string dob = txtBox_Dob.Text;
            DateTime date = Convert.ToDateTime(dob);
            string email = txtBox_Email.Text;
            string phno = txtBox_Phno.Text;
            string address = txtBox_Address.Text;
            string gender = txtBox_Gender.Text;
            emp.EmpId = empid;
            emp.EmpName = name;
            emp.Dob = date;
            emp.EmailId = email;
            emp.PhNo = phno;
            emp.Address = address;
            emp.gender = gender;
            int i = employee.UpdateEmppersonal(emp);
            if(i>0)
            {
                MessageBox.Show("Values Updated");
            }
            txtBox_Address.Clear();
            txtBox_Dob.Clear();
            txtBox_Email.Clear();
            txtbox_Empid.Clear();
            txtBox_EmpName.Clear();
            txtBox_Gender.Clear();
            txtBox_Phno.Clear();

            DataGridViewRow row =dg_PersonalInfo.Rows[rowindex];
            row.Cells[0].Value = empid;
            row.Cells[1].Value = name;
            row.Cells[2].Value = date;
            row.Cells[3].Value = email; 
            row.Cells[4].Value = phno;
            row.Cells[5].Value = address;
            row.Cells[6].Value = gender;
          
        }

        private void Dg_PersonalInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            DataGridViewRow row = dg_PersonalInfo.Rows[rowindex];
            txtbox_Empid.Text= row.Cells[0].Value.ToString();
            txtBox_EmpName.Text= row.Cells[1].Value.ToString();
            txtBox_Dob.Text= row.Cells[2].Value.ToString();
            txtBox_Email.Text= row.Cells[3].Value.ToString();
            txtBox_Phno.Text= row.Cells[4].Value.ToString();
            txtBox_Address.Text= row.Cells[5].Value.ToString();
            txtBox_Gender.Text= row.Cells[6].Value.ToString();

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int empid = Convert.ToInt32(txtbox_Empid.Text);
            emp.EmpId = empid;
            int i = employee.DeleteEmppersonal(emp);
            MessageBox.Show("Deleted Successfully");

            var dt=db.CommonMethodSelection("select*from Emp_Personal");
            dg_PersonalInfo.DataSource = dt;

           


        }
    }
}
