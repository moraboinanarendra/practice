﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class DashBord : Form
    {
        public DashBord()
        {
            InitializeComponent();
        }

        private void empListbtn_Click(object sender, EventArgs e)
        {
            EmployeeList emp=new EmployeeList();
            emp.Show();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
