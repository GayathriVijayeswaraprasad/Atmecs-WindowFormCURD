namespace EmployeeInformation
{
    partial class BankDetails
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
            this.lblDeptname = new System.Windows.Forms.Label();
            this.cmbDeptName = new System.Windows.Forms.ComboBox();
            this.lblDeptId = new System.Windows.Forms.Label();
            this.txtDeptId = new System.Windows.Forms.TextBox();
            this.cmbEmpId = new System.Windows.Forms.ComboBox();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.lblAcNo = new System.Windows.Forms.Label();
            this.txtAcNo = new System.Windows.Forms.TextBox();
            this.txtNetpay = new System.Windows.Forms.TextBox();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.lblPFNo = new System.Windows.Forms.Label();
            this.lblPfAmount = new System.Windows.Forms.Label();
            this.txtPFno = new System.Windows.Forms.TextBox();
            this.txtPFamt = new System.Windows.Forms.TextBox();
            this.dgBankDetails = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBankDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeptname
            // 
            this.lblDeptname.BackColor = System.Drawing.Color.Linen;
            this.lblDeptname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeptname.Location = new System.Drawing.Point(72, 41);
            this.lblDeptname.Name = "lblDeptname";
            this.lblDeptname.Size = new System.Drawing.Size(152, 22);
            this.lblDeptname.TabIndex = 0;
            this.lblDeptname.Text = "DEPARTMENT NAME";
            // 
            // cmbDeptName
            // 
            this.cmbDeptName.FormattingEnabled = true;
            this.cmbDeptName.Location = new System.Drawing.Point(256, 42);
            this.cmbDeptName.Name = "cmbDeptName";
            this.cmbDeptName.Size = new System.Drawing.Size(121, 21);
            this.cmbDeptName.TabIndex = 1;
            this.cmbDeptName.SelectedIndexChanged += new System.EventHandler(this.CmbDeptName_SelectedIndexChanged);
            // 
            // lblDeptId
            // 
            this.lblDeptId.BackColor = System.Drawing.Color.Linen;
            this.lblDeptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeptId.Location = new System.Drawing.Point(72, 88);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(152, 19);
            this.lblDeptId.TabIndex = 2;
            this.lblDeptId.Text = "DEPARTMENT ID";
            // 
            // txtDeptId
            // 
            this.txtDeptId.Location = new System.Drawing.Point(256, 88);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.Size = new System.Drawing.Size(121, 20);
            this.txtDeptId.TabIndex = 3;
            // 
            // cmbEmpId
            // 
            this.cmbEmpId.FormattingEnabled = true;
            this.cmbEmpId.Location = new System.Drawing.Point(256, 137);
            this.cmbEmpId.Name = "cmbEmpId";
            this.cmbEmpId.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpId.TabIndex = 4;
            this.cmbEmpId.SelectedIndexChanged += new System.EventHandler(this.CmbEmpId_SelectedIndexChanged);
            // 
            // lblEmpId
            // 
            this.lblEmpId.BackColor = System.Drawing.Color.Linen;
            this.lblEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmpId.Location = new System.Drawing.Point(72, 135);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(152, 23);
            this.lblEmpId.TabIndex = 5;
            this.lblEmpId.Text = "EMPLOYEE ID";
            // 
            // lblEmpName
            // 
            this.lblEmpName.BackColor = System.Drawing.Color.Linen;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmpName.Location = new System.Drawing.Point(72, 180);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(152, 23);
            this.lblEmpName.TabIndex = 6;
            this.lblEmpName.Text = "EMPLOYEE NAME";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(256, 183);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(121, 20);
            this.txtEmpName.TabIndex = 7;
            // 
            // lblBank
            // 
            this.lblBank.BackColor = System.Drawing.Color.Linen;
            this.lblBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBank.Location = new System.Drawing.Point(72, 226);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(152, 20);
            this.lblBank.TabIndex = 8;
            this.lblBank.Text = "BANK NAME";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(256, 226);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(121, 20);
            this.txtBankName.TabIndex = 9;
            // 
            // lblAcNo
            // 
            this.lblAcNo.BackColor = System.Drawing.Color.Linen;
            this.lblAcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAcNo.Location = new System.Drawing.Point(72, 267);
            this.lblAcNo.Name = "lblAcNo";
            this.lblAcNo.Size = new System.Drawing.Size(152, 23);
            this.lblAcNo.TabIndex = 10;
            this.lblAcNo.Text = "ACCOUNT NO";
            // 
            // txtAcNo
            // 
            this.txtAcNo.Location = new System.Drawing.Point(256, 270);
            this.txtAcNo.Name = "txtAcNo";
            this.txtAcNo.Size = new System.Drawing.Size(121, 20);
            this.txtAcNo.TabIndex = 11;
            // 
            // txtNetpay
            // 
            this.txtNetpay.Location = new System.Drawing.Point(256, 317);
            this.txtNetpay.Name = "txtNetpay";
            this.txtNetpay.Size = new System.Drawing.Size(121, 20);
            this.txtNetpay.TabIndex = 12;
            // 
            // lblNetPay
            // 
            this.lblNetPay.BackColor = System.Drawing.Color.Linen;
            this.lblNetPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNetPay.Location = new System.Drawing.Point(72, 314);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(151, 23);
            this.lblNetPay.TabIndex = 13;
            this.lblNetPay.Text = "NETPAY";
            // 
            // lblPFNo
            // 
            this.lblPFNo.BackColor = System.Drawing.Color.Linen;
            this.lblPFNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPFNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPFNo.Location = new System.Drawing.Point(72, 357);
            this.lblPFNo.Name = "lblPFNo";
            this.lblPFNo.Size = new System.Drawing.Size(151, 23);
            this.lblPFNo.TabIndex = 14;
            this.lblPFNo.Text = "PF NUMBER";
            // 
            // lblPfAmount
            // 
            this.lblPfAmount.BackColor = System.Drawing.Color.Linen;
            this.lblPfAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPfAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPfAmount.Location = new System.Drawing.Point(72, 399);
            this.lblPfAmount.Name = "lblPfAmount";
            this.lblPfAmount.Size = new System.Drawing.Size(152, 19);
            this.lblPfAmount.TabIndex = 15;
            this.lblPfAmount.Text = "PF AMOUNT";
            // 
            // txtPFno
            // 
            this.txtPFno.Location = new System.Drawing.Point(256, 360);
            this.txtPFno.Name = "txtPFno";
            this.txtPFno.Size = new System.Drawing.Size(121, 20);
            this.txtPFno.TabIndex = 16;
            // 
            // txtPFamt
            // 
            this.txtPFamt.Location = new System.Drawing.Point(256, 399);
            this.txtPFamt.Name = "txtPFamt";
            this.txtPFamt.Size = new System.Drawing.Size(121, 20);
            this.txtPFamt.TabIndex = 17;
            // 
            // dgBankDetails
            // 
            this.dgBankDetails.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgBankDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBankDetails.Location = new System.Drawing.Point(402, 42);
            this.dgBankDetails.Name = "dgBankDetails";
            this.dgBankDetails.Size = new System.Drawing.Size(518, 248);
            this.dgBankDetails.TabIndex = 18;
            this.dgBankDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgBankDetails_CellClick);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(75, 466);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(83, 23);
            this.btnInsert.TabIndex = 19;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(217, 466);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 23);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(371, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(510, 466);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 23);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BankDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(926, 622);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgBankDetails);
            this.Controls.Add(this.txtPFamt);
            this.Controls.Add(this.txtPFno);
            this.Controls.Add(this.lblPfAmount);
            this.Controls.Add(this.lblPFNo);
            this.Controls.Add(this.lblNetPay);
            this.Controls.Add(this.txtNetpay);
            this.Controls.Add(this.txtAcNo);
            this.Controls.Add(this.lblAcNo);
            this.Controls.Add(this.txtBankName);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lblEmpId);
            this.Controls.Add(this.cmbEmpId);
            this.Controls.Add(this.txtDeptId);
            this.Controls.Add(this.lblDeptId);
            this.Controls.Add(this.cmbDeptName);
            this.Controls.Add(this.lblDeptname);
            this.DoubleBuffered = true;
            this.Name = "BankDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankDetails";
            this.Load += new System.EventHandler(this.BankDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBankDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeptname;
        private System.Windows.Forms.ComboBox cmbDeptName;
        private System.Windows.Forms.Label lblDeptId;
        private System.Windows.Forms.TextBox txtDeptId;
        private System.Windows.Forms.ComboBox cmbEmpId;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label lblAcNo;
        private System.Windows.Forms.TextBox txtAcNo;
        private System.Windows.Forms.TextBox txtNetpay;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Label lblPFNo;
        private System.Windows.Forms.Label lblPfAmount;
        private System.Windows.Forms.TextBox txtPFno;
        private System.Windows.Forms.TextBox txtPFamt;
        private System.Windows.Forms.DataGridView dgBankDetails;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
    }
}