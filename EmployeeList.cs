using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using static Microsoft.VisualBasic.Interaction;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace EmployeeManagementSystem
{
    public partial class EmployeeList : Form
    {
        public EmployeeList()
        {
            InitializeComponent();
        }
        DataSet ds;
        SqlDataAdapter da;
        int RowIndex = 0;



        private void EmployeeList_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select Id, Name,Email,Mobile,Designation,Gender,Course,Createdate From Employee Order By Id",
"Data Source=DESKTOP-QDUVD0V;User Id=Sa;Password=B@n1452001;Database=LoginDB");
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            ds = new DataSet();
            da.Fill(ds, "Employee");




            DataClasses1DataContext db=new DataClasses1DataContext();
            Table<Employee> emp = db.Employees;
            dataGridView1.DataSource = emp; 
            // TODO: This line of code loads data into the 'loginDBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.loginDBDataSet.Employee);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            EmployeeForm emp=new EmployeeForm();
            emp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditForm db = new EditForm();
            db.Show();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
