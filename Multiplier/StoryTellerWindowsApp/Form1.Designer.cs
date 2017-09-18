namespace StoryTellerWindowsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameOfChild = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numAgeOfChild = new System.Windows.Forms.NumericUpDown();
            this.checkBoxScary = new System.Windows.Forms.CheckBox();
            this.btnTellStory = new System.Windows.Forms.Button();
            this.textStory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAgeOfChild)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Child";
            // 
            // txtNameOfChild
            // 
            this.txtNameOfChild.Location = new System.Drawing.Point(38, 71);
            this.txtNameOfChild.Name = "txtNameOfChild";
            this.txtNameOfChild.Size = new System.Drawing.Size(209, 31);
            this.txtNameOfChild.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age of Child";
            // 
            // numAgeOfChild
            // 
            this.numAgeOfChild.Location = new System.Drawing.Point(38, 177);
            this.numAgeOfChild.Name = "numAgeOfChild";
            this.numAgeOfChild.Size = new System.Drawing.Size(120, 31);
            this.numAgeOfChild.TabIndex = 3;
            // 
            // checkBoxScary
            // 
            this.checkBoxScary.AutoSize = true;
            this.checkBoxScary.Location = new System.Drawing.Point(38, 247);
            this.checkBoxScary.Name = "checkBoxScary";
            this.checkBoxScary.Size = new System.Drawing.Size(199, 29);
            this.checkBoxScary.TabIndex = 4;
            this.checkBoxScary.Text = "Should be scary";
            this.checkBoxScary.UseVisualStyleBackColor = true;
            // 
            // btnTellStory
            // 
            this.btnTellStory.Location = new System.Drawing.Point(38, 337);
            this.btnTellStory.Name = "btnTellStory";
            this.btnTellStory.Size = new System.Drawing.Size(120, 50);
            this.btnTellStory.TabIndex = 5;
            this.btnTellStory.Text = "Tell story";
            this.btnTellStory.UseVisualStyleBackColor = true;
            this.btnTellStory.Click += new System.EventHandler(this.btnTellStory_Click);
            // 
            // textStory
            // 
            this.textStory.Location = new System.Drawing.Point(38, 450);
            this.textStory.Multiline = true;
            this.textStory.Name = "textStory";
            this.textStory.Size = new System.Drawing.Size(830, 213);
            this.textStory.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 927);
            this.Controls.Add(this.textStory);
            this.Controls.Add(this.btnTellStory);
            this.Controls.Add(this.checkBoxScary);
            this.Controls.Add(this.numAgeOfChild);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameOfChild);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Storyteller";
            ((System.ComponentModel.ISupportInitialize)(this.numAgeOfChild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameOfChild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numAgeOfChild;
        private System.Windows.Forms.CheckBox checkBoxScary;
        private System.Windows.Forms.Button btnTellStory;
        private System.Windows.Forms.TextBox textStory;
    }
}

