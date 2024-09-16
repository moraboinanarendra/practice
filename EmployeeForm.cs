using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        DataSet ds;
        SqlDataAdapter da;
        int RowIndex = 0;

        private void ShowData()
        {
            if (ds.Tables["Employee"].Rows[RowIndex].RowState != DataRowState.Deleted)
            {
                textBox4.Text = ds.Tables["Employee"].Rows[RowIndex]["ID"].ToString();
                textBox1.Text = ds.Tables["Employee"].Rows[RowIndex]["Name"].ToString();
                textBox2.Text = ds.Tables["Employee"].Rows[RowIndex]["Email"].ToString();
                listBox1.Text = ds.Tables["Employee"].Rows[RowIndex]["Mobile"].ToString();
                textBox4.Text = ds.Tables["Employee"].Rows[RowIndex]["Designation"].ToString();
                textBox4.Text = ds.Tables["Employee"].Rows[RowIndex]["Gender"].ToString();
                comboBox1.Text = ds.Tables["Employee"].Rows[RowIndex]["Course"].ToString();
                dateTimePicker1.Text = ds.Tables["Employee"].Rows[RowIndex]["Createdate"].ToString();




            }
            else
            {
                MessageBox.Show("Current row is deleted and can't be accessed anymore.", "Information",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
            private void button1_Click(object sender, EventArgs e)
            {
                DataRow dr = ds.Tables["Employee"].NewRow();
                dr["Id"] = textBox4.Text;

                dr["Name"] = textBox1.Text;
                dr["Email"] = textBox2.Text;
                dr["Mobile"] = textBox3.Text;
                dr["Designation"] = string.Empty;

                dr["Gender"] = string.Empty;
                dr["Course"] = string.Empty;
                dr["CreateDate"] = dateTimePicker1.Text;


                ds.Tables["Employee"].Rows.Add(dr);
                //Setting the RowIndex to the index of new row
                RowIndex = ds.Tables["Employee"].Rows.Count - 1;
                button1.Enabled = false;
                MessageBox.Show("DataRow added to DataTable of DataSet.", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            }

            private void EmployeeForm_Load(object sender, EventArgs e)
            {
                da = new SqlDataAdapter("Select Id, Name,Email,Mobile,Designation,Gender,Course,Createdate From Employee Order By Id",
    "Data Source=DESKTOP-QDUVD0V;User Id=Sa;Password=B@n1452001;Database=LoginDB");
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                ds = new DataSet();
                da.Fill(ds, "Employee");
            ShowData();

            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


    }


    

