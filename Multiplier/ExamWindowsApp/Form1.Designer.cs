namespace ExamWindowsApp
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
            this.groupStudentInfo = new System.Windows.Forms.GroupBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.textStudentName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBetyg = new System.Windows.Forms.Button();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.comboBoxStudentList = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblVg = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblIg = new System.Windows.Forms.Label();
            this.groupStudentInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupStudentInfo
            // 
            this.groupStudentInfo.Controls.Add(this.btnAssign);
            this.groupStudentInfo.Controls.Add(this.textStudentName);
            this.groupStudentInfo.Location = new System.Drawing.Point(27, 35);
            this.groupStudentInfo.Name = "groupStudentInfo";
            this.groupStudentInfo.Size = new System.Drawing.Size(1303, 158);
            this.groupStudentInfo.TabIndex = 0;
            this.groupStudentInfo.TabStop = false;
            this.groupStudentInfo.Text = "Student Information";
            // 
            // btnAssign
            // 
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.Location = new System.Drawing.Point(1056, 47);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(135, 47);
            this.btnAssign.TabIndex = 1;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // textStudentName
            // 
            this.textStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStudentName.Location = new System.Drawing.Point(21, 51);
            this.textStudentName.Name = "textStudentName";
            this.textStudentName.Size = new System.Drawing.Size(988, 40);
            this.textStudentName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBetyg);
            this.groupBox1.Controls.Add(this.comboBoxGrade);
            this.groupBox1.Controls.Add(this.comboBoxStudentList);
            this.groupBox1.Location = new System.Drawing.Point(27, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1303, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grade";
            // 
            // btnBetyg
            // 
            this.btnBetyg.Location = new System.Drawing.Point(427, 138);
            this.btnBetyg.Name = "btnBetyg";
            this.btnBetyg.Size = new System.Drawing.Size(142, 54);
            this.btnBetyg.TabIndex = 2;
            this.btnBetyg.Text = "Grade";
            this.btnBetyg.UseVisualStyleBackColor = true;
            this.btnBetyg.Click += new System.EventHandler(this.btnBetyg_Click);
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Items.AddRange(new object[] {
            "IG",
            "VG",
            "G"});
            this.comboBoxGrade.Location = new System.Drawing.Point(21, 143);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(362, 41);
            this.comboBoxGrade.TabIndex = 1;
            // 
            // comboBoxStudentList
            // 
            this.comboBoxStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStudentList.FormattingEnabled = true;
            this.comboBoxStudentList.Location = new System.Drawing.Point(21, 64);
            this.comboBoxStudentList.Name = "comboBoxStudentList";
            this.comboBoxStudentList.Size = new System.Drawing.Size(988, 41);
            this.comboBoxStudentList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.lblVg);
            this.groupBox2.Controls.Add(this.lblG);
            this.groupBox2.Controls.Add(this.lblIg);
            this.groupBox2.Location = new System.Drawing.Point(27, 512);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1303, 363);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistics";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(901, 157);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(290, 108);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate Student";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblVg
            // 
            this.lblVg.AutoSize = true;
            this.lblVg.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVg.Location = new System.Drawing.Point(442, 254);
            this.lblVg.Name = "lblVg";
            this.lblVg.Size = new System.Drawing.Size(146, 55);
            this.lblVg.TabIndex = 2;
            this.lblVg.Text = "VG: 0";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.Location = new System.Drawing.Point(442, 175);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(114, 55);
            this.lblG.TabIndex = 1;
            this.lblG.Text = "G: 0";
            // 
            // lblIg
            // 
            this.lblIg.AutoSize = true;
            this.lblIg.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIg.Location = new System.Drawing.Point(442, 92);
            this.lblIg.Name = "lblIg";
            this.lblIg.Size = new System.Drawing.Size(127, 55);
            this.lblIg.TabIndex = 0;
            this.lblIg.Text = "IG: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 915);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupStudentInfo);
            this.Name = "Form1";
            this.Text = "Student Statistic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupStudentInfo.ResumeLayout(false);
            this.groupStudentInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupStudentInfo;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.TextBox textStudentName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBetyg;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.ComboBox comboBoxStudentList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblVg;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblIg;
    }
}

