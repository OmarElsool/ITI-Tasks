namespace CodeFirst
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteDept = new System.Windows.Forms.Button();
            this.UpdateDept = new System.Windows.Forms.Button();
            this.InsertDept = new System.Windows.Forms.Button();
            this.DepartmentNameBox = new System.Windows.Forms.TextBox();
            this.DepartmentIdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteEmp = new System.Windows.Forms.Button();
            this.UpdateEmp = new System.Windows.Forms.Button();
            this.InsertEmp = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeIdBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteDept);
            this.groupBox1.Controls.Add(this.UpdateDept);
            this.groupBox1.Controls.Add(this.InsertDept);
            this.groupBox1.Controls.Add(this.DepartmentNameBox);
            this.groupBox1.Controls.Add(this.DepartmentIdBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(120, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department";
            // 
            // DeleteDept
            // 
            this.DeleteDept.Location = new System.Drawing.Point(364, 117);
            this.DeleteDept.Name = "DeleteDept";
            this.DeleteDept.Size = new System.Drawing.Size(142, 23);
            this.DeleteDept.TabIndex = 7;
            this.DeleteDept.Text = "Delete Department";
            this.DeleteDept.UseVisualStyleBackColor = true;
            this.DeleteDept.Click += new System.EventHandler(this.DeleteDept_Click);
            // 
            // UpdateDept
            // 
            this.UpdateDept.Location = new System.Drawing.Point(364, 69);
            this.UpdateDept.Name = "UpdateDept";
            this.UpdateDept.Size = new System.Drawing.Size(142, 23);
            this.UpdateDept.TabIndex = 6;
            this.UpdateDept.Text = "Update Department";
            this.UpdateDept.UseVisualStyleBackColor = true;
            this.UpdateDept.Click += new System.EventHandler(this.UpdateDept_Click);
            // 
            // InsertDept
            // 
            this.InsertDept.Location = new System.Drawing.Point(364, 22);
            this.InsertDept.Name = "InsertDept";
            this.InsertDept.Size = new System.Drawing.Size(142, 23);
            this.InsertDept.TabIndex = 5;
            this.InsertDept.Text = "Insert Department";
            this.InsertDept.UseVisualStyleBackColor = true;
            this.InsertDept.Click += new System.EventHandler(this.InsertDept_Click);
            // 
            // DepartmentNameBox
            // 
            this.DepartmentNameBox.Location = new System.Drawing.Point(160, 118);
            this.DepartmentNameBox.Name = "DepartmentNameBox";
            this.DepartmentNameBox.Size = new System.Drawing.Size(158, 22);
            this.DepartmentNameBox.TabIndex = 4;
            // 
            // DepartmentIdBox
            // 
            this.DepartmentIdBox.Enabled = false;
            this.DepartmentIdBox.Location = new System.Drawing.Point(160, 70);
            this.DepartmentIdBox.Name = "DepartmentIdBox";
            this.DepartmentIdBox.Size = new System.Drawing.Size(158, 22);
            this.DepartmentIdBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department Id";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteEmp);
            this.groupBox2.Controls.Add(this.UpdateEmp);
            this.groupBox2.Controls.Add(this.InsertEmp);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.EmployeeNameBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.EmployeeIdBox);
            this.groupBox2.Location = new System.Drawing.Point(120, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee";
            // 
            // DeleteEmp
            // 
            this.DeleteEmp.Location = new System.Drawing.Point(364, 136);
            this.DeleteEmp.Name = "DeleteEmp";
            this.DeleteEmp.Size = new System.Drawing.Size(142, 23);
            this.DeleteEmp.TabIndex = 10;
            this.DeleteEmp.Text = "Delete Employee";
            this.DeleteEmp.UseVisualStyleBackColor = true;
            this.DeleteEmp.Click += new System.EventHandler(this.DeleteEmp_Click);
            // 
            // UpdateEmp
            // 
            this.UpdateEmp.Location = new System.Drawing.Point(364, 88);
            this.UpdateEmp.Name = "UpdateEmp";
            this.UpdateEmp.Size = new System.Drawing.Size(142, 23);
            this.UpdateEmp.TabIndex = 9;
            this.UpdateEmp.Text = "Update Employee";
            this.UpdateEmp.UseVisualStyleBackColor = true;
            this.UpdateEmp.Click += new System.EventHandler(this.UpdateEmp_Click);
            // 
            // InsertEmp
            // 
            this.InsertEmp.Location = new System.Drawing.Point(364, 41);
            this.InsertEmp.Name = "InsertEmp";
            this.InsertEmp.Size = new System.Drawing.Size(142, 23);
            this.InsertEmp.TabIndex = 8;
            this.InsertEmp.Text = "Insert Employee";
            this.InsertEmp.UseVisualStyleBackColor = true;
            this.InsertEmp.Click += new System.EventHandler(this.InsertEmp_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(152, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employee Name";
            // 
            // EmployeeNameBox
            // 
            this.EmployeeNameBox.Location = new System.Drawing.Point(152, 139);
            this.EmployeeNameBox.Name = "EmployeeNameBox";
            this.EmployeeNameBox.Size = new System.Drawing.Size(158, 22);
            this.EmployeeNameBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Employee Id";
            // 
            // EmployeeIdBox
            // 
            this.EmployeeIdBox.Enabled = false;
            this.EmployeeIdBox.Location = new System.Drawing.Point(152, 89);
            this.EmployeeIdBox.Name = "EmployeeIdBox";
            this.EmployeeIdBox.Size = new System.Drawing.Size(158, 22);
            this.EmployeeIdBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DepartmentNameBox;
        private System.Windows.Forms.TextBox DepartmentIdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmployeeNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmployeeIdBox;
        private System.Windows.Forms.Button DeleteDept;
        private System.Windows.Forms.Button UpdateDept;
        private System.Windows.Forms.Button InsertDept;
        private System.Windows.Forms.Button DeleteEmp;
        private System.Windows.Forms.Button UpdateEmp;
        private System.Windows.Forms.Button InsertEmp;
    }
}

