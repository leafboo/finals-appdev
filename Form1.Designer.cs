
namespace _046_Pattaguan_Caranguian
{
    partial class Form1
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
            this.btnDept = new System.Windows.Forms.Button();
            this.btnEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDept
            // 
            this.btnDept.Location = new System.Drawing.Point(167, 163);
            this.btnDept.Name = "btnDept";
            this.btnDept.Size = new System.Drawing.Size(178, 97);
            this.btnDept.TabIndex = 0;
            this.btnDept.Text = "Department ";
            this.btnDept.UseVisualStyleBackColor = true;
            this.btnDept.Click += new System.EventHandler(this.btnDept_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.Location = new System.Drawing.Point(451, 163);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(178, 97);
            this.btnEmp.TabIndex = 1;
            this.btnEmp.Text = "Employee";
            this.btnEmp.UseVisualStyleBackColor = true;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmp);
            this.Controls.Add(this.btnDept);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDept;
        private System.Windows.Forms.Button btnEmp;
    }
}

