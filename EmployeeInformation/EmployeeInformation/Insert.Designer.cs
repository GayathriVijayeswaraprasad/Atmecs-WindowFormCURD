namespace EmployeeInformation
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.linkLabel_EmpPersonal = new System.Windows.Forms.LinkLabel();
            this.linkLabel_WorkDetails = new System.Windows.Forms.LinkLabel();
            this.linkLabel_BankDetails = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel_EmpInfo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabel_EmpPersonal
            // 
            this.linkLabel_EmpPersonal.AutoSize = true;
            this.linkLabel_EmpPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_EmpPersonal.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel_EmpPersonal.Location = new System.Drawing.Point(53, 111);
            this.linkLabel_EmpPersonal.Name = "linkLabel_EmpPersonal";
            this.linkLabel_EmpPersonal.Size = new System.Drawing.Size(195, 16);
            this.linkLabel_EmpPersonal.TabIndex = 0;
            this.linkLabel_EmpPersonal.TabStop = true;
            this.linkLabel_EmpPersonal.Text = "Employee Personal Information";
            this.linkLabel_EmpPersonal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_EmpPersonal_LinkClicked);
            // 
            // linkLabel_WorkDetails
            // 
            this.linkLabel_WorkDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_WorkDetails.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel_WorkDetails.Location = new System.Drawing.Point(53, 171);
            this.linkLabel_WorkDetails.Name = "linkLabel_WorkDetails";
            this.linkLabel_WorkDetails.Size = new System.Drawing.Size(185, 20);
            this.linkLabel_WorkDetails.TabIndex = 1;
            this.linkLabel_WorkDetails.TabStop = true;
            this.linkLabel_WorkDetails.Text = "Employee Official Information";
            this.linkLabel_WorkDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_WorkDetails_LinkClicked);
            // 
            // linkLabel_BankDetails
            // 
            this.linkLabel_BankDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_BankDetails.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel_BankDetails.Location = new System.Drawing.Point(54, 233);
            this.linkLabel_BankDetails.Name = "linkLabel_BankDetails";
            this.linkLabel_BankDetails.Size = new System.Drawing.Size(194, 25);
            this.linkLabel_BankDetails.TabIndex = 2;
            this.linkLabel_BankDetails.TabStop = true;
            this.linkLabel_BankDetails.Text = "Employee Bank Information";
            this.linkLabel_BankDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_BankDetails_LinkClicked);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "EMPLOYEE INFORMATION";
            // 
            // linkLabel_EmpInfo
            // 
            this.linkLabel_EmpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_EmpInfo.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel_EmpInfo.Location = new System.Drawing.Point(53, 299);
            this.linkLabel_EmpInfo.Name = "linkLabel_EmpInfo";
            this.linkLabel_EmpInfo.Size = new System.Drawing.Size(195, 18);
            this.linkLabel_EmpInfo.TabIndex = 5;
            this.linkLabel_EmpInfo.TabStop = true;
            this.linkLabel_EmpInfo.Text = "View Employee Details";
            this.linkLabel_EmpInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_EmpInfo_LinkClicked);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(910, 416);
            this.Controls.Add(this.linkLabel_EmpInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel_BankDetails);
            this.Controls.Add(this.linkLabel_WorkDetails);
            this.Controls.Add(this.linkLabel_EmpPersonal);
            this.DoubleBuffered = true;
            this.Name = "Employee";
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel_EmpPersonal;
        private System.Windows.Forms.LinkLabel linkLabel_WorkDetails;
        private System.Windows.Forms.LinkLabel linkLabel_BankDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel_EmpInfo;
    }
}