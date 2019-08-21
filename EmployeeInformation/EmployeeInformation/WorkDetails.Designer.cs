namespace EmployeeInformation
{
    partial class WorkDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkDetails));
            this.lblEmpId = new System.Windows.Forms.Label();
            this.cmbEmpId = new System.Windows.Forms.ComboBox();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.cmbDeptName = new System.Windows.Forms.ComboBox();
            this.lblDesg = new System.Windows.Forms.Label();
            this.txtDeptId = new System.Windows.Forms.TextBox();
            this.lblMgr = new System.Windows.Forms.Label();
            this.lblAtd = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblDeptId = new System.Windows.Forms.Label();
            this.txtDesig = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.txtAttd = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgWorkDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpId
            // 
            this.lblEmpId.BackColor = System.Drawing.Color.Black;
            this.lblEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmpId.Location = new System.Drawing.Point(43, 40);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(142, 21);
            this.lblEmpId.TabIndex = 0;
            this.lblEmpId.Text = "EMPLOYEE ID";
            this.lblEmpId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbEmpId
            // 
            this.cmbEmpId.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmbEmpId.FormattingEnabled = true;
            this.cmbEmpId.Location = new System.Drawing.Point(232, 40);
            this.cmbEmpId.Name = "cmbEmpId";
            this.cmbEmpId.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpId.TabIndex = 1;
            this.cmbEmpId.SelectedIndexChanged += new System.EventHandler(this.CmbEmpId_SelectedIndexChanged);
            // 
            // lblDeptName
            // 
            this.lblDeptName.BackColor = System.Drawing.Color.Black;
            this.lblDeptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDeptName.Location = new System.Drawing.Point(43, 140);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(142, 24);
            this.lblDeptName.TabIndex = 2;
            this.lblDeptName.Text = "DEPARTMENT NAME";
            this.lblDeptName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDeptName
            // 
            this.cmbDeptName.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmbDeptName.FormattingEnabled = true;
            this.cmbDeptName.Location = new System.Drawing.Point(232, 143);
            this.cmbDeptName.Name = "cmbDeptName";
            this.cmbDeptName.Size = new System.Drawing.Size(121, 21);
            this.cmbDeptName.TabIndex = 3;
            this.cmbDeptName.SelectedIndexChanged += new System.EventHandler(this.CmbDeptName_SelectedIndexChanged);
            // 
            // lblDesg
            // 
            this.lblDesg.BackColor = System.Drawing.Color.Black;
            this.lblDesg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDesg.Location = new System.Drawing.Point(43, 243);
            this.lblDesg.Name = "lblDesg";
            this.lblDesg.Size = new System.Drawing.Size(142, 23);
            this.lblDesg.TabIndex = 4;
            this.lblDesg.Text = "DESIGNATION";
            this.lblDesg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDeptId
            // 
            this.txtDeptId.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtDeptId.Location = new System.Drawing.Point(232, 194);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.Size = new System.Drawing.Size(121, 20);
            this.txtDeptId.TabIndex = 5;
            // 
            // lblMgr
            // 
            this.lblMgr.BackColor = System.Drawing.Color.Black;
            this.lblMgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMgr.Location = new System.Drawing.Point(43, 297);
            this.lblMgr.Name = "lblMgr";
            this.lblMgr.Size = new System.Drawing.Size(142, 20);
            this.lblMgr.TabIndex = 6;
            this.lblMgr.Text = "MANAGER";
            this.lblMgr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAtd
            // 
            this.lblAtd.BackColor = System.Drawing.Color.Black;
            this.lblAtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAtd.Location = new System.Drawing.Point(43, 338);
            this.lblAtd.Name = "lblAtd";
            this.lblAtd.Size = new System.Drawing.Size(142, 20);
            this.lblAtd.TabIndex = 7;
            this.lblAtd.Text = "ATTENDANCE";
            this.lblAtd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSal
            // 
            this.lblSal.BackColor = System.Drawing.Color.Black;
            this.lblSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSal.Location = new System.Drawing.Point(43, 379);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(142, 18);
            this.lblSal.TabIndex = 8;
            this.lblSal.Text = "SALARY";
            this.lblSal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExp
            // 
            this.lblExp.BackColor = System.Drawing.Color.Black;
            this.lblExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblExp.Location = new System.Drawing.Point(43, 421);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(142, 17);
            this.lblExp.TabIndex = 9;
            this.lblExp.Text = "EXPERIENCE";
            this.lblExp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeptId
            // 
            this.lblDeptId.BackColor = System.Drawing.Color.Black;
            this.lblDeptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDeptId.Location = new System.Drawing.Point(43, 192);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(142, 23);
            this.lblDeptId.TabIndex = 10;
            this.lblDeptId.Text = "DEPARTMENT ID";
            this.lblDeptId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDesig
            // 
            this.txtDesig.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtDesig.Location = new System.Drawing.Point(232, 243);
            this.txtDesig.Name = "txtDesig";
            this.txtDesig.Size = new System.Drawing.Size(121, 20);
            this.txtDesig.TabIndex = 11;
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtSalary.Location = new System.Drawing.Point(232, 379);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(121, 20);
            this.txtSalary.TabIndex = 12;
            // 
            // txtManager
            // 
            this.txtManager.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtManager.Location = new System.Drawing.Point(232, 297);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(121, 20);
            this.txtManager.TabIndex = 13;
            // 
            // txtExp
            // 
            this.txtExp.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtExp.Location = new System.Drawing.Point(232, 421);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(121, 20);
            this.txtExp.TabIndex = 14;
            // 
            // txtAttd
            // 
            this.txtAttd.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtAttd.Location = new System.Drawing.Point(232, 338);
            this.txtAttd.Name = "txtAttd";
            this.txtAttd.Size = new System.Drawing.Size(121, 20);
            this.txtAttd.TabIndex = 15;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(687, 318);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(89, 23);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(804, 318);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(687, 374);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(804, 374);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 23);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // dgWorkDetails
            // 
            this.dgWorkDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgWorkDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgWorkDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWorkDetails.Location = new System.Drawing.Point(12, 466);
            this.dgWorkDetails.Name = "dgWorkDetails";
            this.dgWorkDetails.Size = new System.Drawing.Size(904, 174);
            this.dgWorkDetails.TabIndex = 20;
            this.dgWorkDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgWorkDetails_CellClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(43, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "EMPLOYEE NAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtEmpName
            // 
            this.txtEmpName.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtEmpName.Location = new System.Drawing.Point(232, 97);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(121, 20);
            this.txtEmpName.TabIndex = 22;
            // 
            // WorkDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(928, 652);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgWorkDetails);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtAttd);
            this.Controls.Add(this.txtExp);
            this.Controls.Add(this.txtManager);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtDesig);
            this.Controls.Add(this.lblDeptId);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblAtd);
            this.Controls.Add(this.lblMgr);
            this.Controls.Add(this.txtDeptId);
            this.Controls.Add(this.lblDesg);
            this.Controls.Add(this.cmbDeptName);
            this.Controls.Add(this.lblDeptName);
            this.Controls.Add(this.cmbEmpId);
            this.Controls.Add(this.lblEmpId);
            this.DoubleBuffered = true;
            this.Name = "WorkDetails";
            this.Text = "WorkDetails";
            this.Load += new System.EventHandler(this.WorkDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.ComboBox cmbEmpId;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.ComboBox cmbDeptName;
        private System.Windows.Forms.Label lblDesg;
        private System.Windows.Forms.TextBox txtDeptId;
        private System.Windows.Forms.Label lblMgr;
        private System.Windows.Forms.Label lblAtd;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblDeptId;
        private System.Windows.Forms.TextBox txtDesig;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.TextBox txtAttd;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgWorkDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpName;
    }
}