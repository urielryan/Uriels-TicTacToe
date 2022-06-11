namespace Real_TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.upperbttn1 = new System.Windows.Forms.Button();
            this.upperbttn2 = new System.Windows.Forms.Button();
            this.upperbttn3 = new System.Windows.Forms.Button();
            this.midbttn1 = new System.Windows.Forms.Button();
            this.midbttn2 = new System.Windows.Forms.Button();
            this.midbttn3 = new System.Windows.Forms.Button();
            this.lowerbttn1 = new System.Windows.Forms.Button();
            this.lowerbttn2 = new System.Windows.Forms.Button();
            this.lowerbttn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // upperbttn1
            // 
            this.upperbttn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.upperbttn1.Location = new System.Drawing.Point(50, 63);
            this.upperbttn1.Name = "upperbttn1";
            this.upperbttn1.Size = new System.Drawing.Size(98, 105);
            this.upperbttn1.TabIndex = 0;
            this.upperbttn1.UseVisualStyleBackColor = true;
            this.upperbttn1.Click += new System.EventHandler(this.bttnclick);
            // 
            // upperbttn2
            // 
            this.upperbttn2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.upperbttn2.Location = new System.Drawing.Point(154, 63);
            this.upperbttn2.Name = "upperbttn2";
            this.upperbttn2.Size = new System.Drawing.Size(98, 105);
            this.upperbttn2.TabIndex = 1;
            this.upperbttn2.UseVisualStyleBackColor = true;
            // 
            // upperbttn3
            // 
            this.upperbttn3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.upperbttn3.Location = new System.Drawing.Point(258, 63);
            this.upperbttn3.Name = "upperbttn3";
            this.upperbttn3.Size = new System.Drawing.Size(98, 105);
            this.upperbttn3.TabIndex = 2;
            this.upperbttn3.UseVisualStyleBackColor = true;
            // 
            // midbttn1
            // 
            this.midbttn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.midbttn1.Location = new System.Drawing.Point(50, 174);
            this.midbttn1.Name = "midbttn1";
            this.midbttn1.Size = new System.Drawing.Size(98, 105);
            this.midbttn1.TabIndex = 3;
            this.midbttn1.UseVisualStyleBackColor = true;
            // 
            // midbttn2
            // 
            this.midbttn2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.midbttn2.Location = new System.Drawing.Point(154, 174);
            this.midbttn2.Name = "midbttn2";
            this.midbttn2.Size = new System.Drawing.Size(98, 105);
            this.midbttn2.TabIndex = 4;
            this.midbttn2.UseVisualStyleBackColor = true;
            // 
            // midbttn3
            // 
            this.midbttn3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.midbttn3.Location = new System.Drawing.Point(258, 174);
            this.midbttn3.Name = "midbttn3";
            this.midbttn3.Size = new System.Drawing.Size(98, 105);
            this.midbttn3.TabIndex = 5;
            this.midbttn3.UseVisualStyleBackColor = true;
            // 
            // lowerbttn1
            // 
            this.lowerbttn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lowerbttn1.Location = new System.Drawing.Point(50, 285);
            this.lowerbttn1.Name = "lowerbttn1";
            this.lowerbttn1.Size = new System.Drawing.Size(98, 105);
            this.lowerbttn1.TabIndex = 6;
            this.lowerbttn1.UseVisualStyleBackColor = true;
            // 
            // lowerbttn2
            // 
            this.lowerbttn2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lowerbttn2.Location = new System.Drawing.Point(154, 285);
            this.lowerbttn2.Name = "lowerbttn2";
            this.lowerbttn2.Size = new System.Drawing.Size(98, 105);
            this.lowerbttn2.TabIndex = 7;
            this.lowerbttn2.UseVisualStyleBackColor = true;
            // 
            // lowerbttn3
            // 
            this.lowerbttn3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lowerbttn3.Location = new System.Drawing.Point(258, 285);
            this.lowerbttn3.Name = "lowerbttn3";
            this.lowerbttn3.Size = new System.Drawing.Size(98, 105);
            this.lowerbttn3.TabIndex = 8;
            this.lowerbttn3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.lowerbttn3);
            this.Controls.Add(this.lowerbttn2);
            this.Controls.Add(this.lowerbttn1);
            this.Controls.Add(this.midbttn3);
            this.Controls.Add(this.midbttn2);
            this.Controls.Add(this.midbttn1);
            this.Controls.Add(this.upperbttn3);
            this.Controls.Add(this.upperbttn2);
            this.Controls.Add(this.upperbttn1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TIC TAC TOE Game";
            this.ResumeLayout(false);

        }

        #endregion

        private Button upperbttn1;
        private Button upperbttn2;
        private Button upperbttn3;
        private Button midbttn1;
        private Button midbttn2;
        private Button midbttn3;
        private Button lowerbttn1;
        private Button lowerbttn2;
        private Button lowerbttn3;
    }
}