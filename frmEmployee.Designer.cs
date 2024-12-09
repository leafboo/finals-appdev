
namespace _046_Pattaguan_Caranguian
{
    partial class frmEmployee
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cboCRUD = new System.Windows.Forms.ComboBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpAge = new System.Windows.Forms.TextBox();
            this.txtEmpSex = new System.Windows.Forms.TextBox();
            this.txtMarStat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboDeptID = new System.Windows.Forms.ComboBox();
            this.dtgMain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Choose operation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Emp ID";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Location = new System.Drawing.Point(55, 84);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(121, 20);
            this.txtEmpID.TabIndex = 9;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(302, 121);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cboCRUD
            // 
            this.cboCRUD.FormattingEnabled = true;
            this.cboCRUD.Items.AddRange(new object[] {
            "Create",
            "Select",
            "Update",
            "Delete"});
            this.cboCRUD.Location = new System.Drawing.Point(302, 84);
            this.cboCRUD.Name = "cboCRUD";
            this.cboCRUD.Size = new System.Drawing.Size(121, 21);
            this.cboCRUD.TabIndex = 7;
            this.cboCRUD.SelectedIndexChanged += new System.EventHandler(this.cboCRUD_SelectedIndexChanged);
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(55, 137);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(121, 20);
            this.txtEmpName.TabIndex = 12;
            // 
            // txtEmpAge
            // 
            this.txtEmpAge.Location = new System.Drawing.Point(55, 194);
            this.txtEmpAge.Name = "txtEmpAge";
            this.txtEmpAge.Size = new System.Drawing.Size(121, 20);
            this.txtEmpAge.TabIndex = 13;
            // 
            // txtEmpSex
            // 
            this.txtEmpSex.Location = new System.Drawing.Point(55, 246);
            this.txtEmpSex.Name = "txtEmpSex";
            this.txtEmpSex.Size = new System.Drawing.Size(121, 20);
            this.txtEmpSex.TabIndex = 14;
            // 
            // txtMarStat
            // 
            this.txtMarStat.Location = new System.Drawing.Point(55, 300);
            this.txtMarStat.Name = "txtMarStat";
            this.txtMarStat.Size = new System.Drawing.Size(121, 20);
            this.txtMarStat.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "EmpName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "EmpAge";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "EmpSex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Marital Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "DeptID";
            // 
            // cboDeptID
            // 
            this.cboDeptID.FormattingEnabled = true;
            this.cboDeptID.Location = new System.Drawing.Point(55, 351);
            this.cboDeptID.Name = "cboDeptID";
            this.cboDeptID.Size = new System.Drawing.Size(121, 21);
            this.cboDeptID.TabIndex = 22;
            // 
            // dtgMain
            // 
            this.dtgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMain.Location = new System.Drawing.Point(230, 150);
            this.dtgMain.Name = "dtgMain";
            this.dtgMain.Size = new System.Drawing.Size(558, 288);
            this.dtgMain.TabIndex = 23;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgMain);
            this.Controls.Add(this.cboDeptID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarStat);
            this.Controls.Add(this.txtEmpSex);
            this.Controls.Add(this.txtEmpAge);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cboCRUD);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cboCRUD;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpAge;
        private System.Windows.Forms.TextBox txtEmpSex;
        private System.Windows.Forms.TextBox txtMarStat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboDeptID;
        private System.Windows.Forms.DataGridView dtgMain;
    }
}