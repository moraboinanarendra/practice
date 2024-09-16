namespace EmployeeManagementSystem
{
    partial class DashBord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.homebtn = new System.Windows.Forms.Button();
            this.empListbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "\tWelcome Admin Panel\t\t\t\t";
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.homebtn.Location = new System.Drawing.Point(12, 12);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(211, 45);
            this.homebtn.TabIndex = 1;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            // 
            // empListbtn
            // 
            this.empListbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.empListbtn.Location = new System.Drawing.Point(441, 12);
            this.empListbtn.Name = "empListbtn";
            this.empListbtn.Size = new System.Drawing.Size(222, 45);
            this.empListbtn.TabIndex = 2;
            this.empListbtn.Text = "Employee List";
            this.empListbtn.UseVisualStyleBackColor = false;
            this.empListbtn.Click += new System.EventHandler(this.empListbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logoutbtn.Location = new System.Drawing.Point(869, 12);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(232, 45);
            this.logoutbtn.TabIndex = 3;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // DashBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1113, 720);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.empListbtn);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("High Tower Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "DashBord";
            this.Text = "DashBord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button empListbtn;
        private System.Windows.Forms.Button logoutbtn;
    }
}