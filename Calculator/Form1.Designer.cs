namespace Calculator
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
            this.plus = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.OutBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(503, 149);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(46, 50);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.b_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(503, 205);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(46, 50);
            this.equals.TabIndex = 1;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.b_Click);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(67, 149);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(46, 50);
            this.B1.TabIndex = 2;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.b_Click);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(153, 149);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(46, 50);
            this.B2.TabIndex = 3;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.b_Click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(235, 149);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(46, 50);
            this.B3.TabIndex = 4;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.b_Click);
            // 
            // B6
            // 
            this.B6.Location = new System.Drawing.Point(235, 220);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(46, 50);
            this.B6.TabIndex = 7;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.b_Click);
            // 
            // B5
            // 
            this.B5.Location = new System.Drawing.Point(153, 220);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(46, 50);
            this.B5.TabIndex = 6;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Click += new System.EventHandler(this.b_Click);
            // 
            // B4
            // 
            this.B4.Location = new System.Drawing.Point(67, 220);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(46, 50);
            this.B4.TabIndex = 5;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.b_Click);
            // 
            // B9
            // 
            this.B9.Location = new System.Drawing.Point(235, 290);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(46, 50);
            this.B9.TabIndex = 10;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Click += new System.EventHandler(this.b_Click);
            // 
            // B8
            // 
            this.B8.Location = new System.Drawing.Point(153, 290);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(46, 50);
            this.B8.TabIndex = 9;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Click += new System.EventHandler(this.b_Click);
            // 
            // B7
            // 
            this.B7.Location = new System.Drawing.Point(67, 290);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(46, 50);
            this.B7.TabIndex = 8;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Click += new System.EventHandler(this.b_Click);
            // 
            // B0
            // 
            this.B0.Location = new System.Drawing.Point(153, 357);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(46, 50);
            this.B0.TabIndex = 11;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = true;
            this.B0.Click += new System.EventHandler(this.b_Click);
            // 
            // OutBox
            // 
            this.OutBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutBox.Location = new System.Drawing.Point(67, 70);
            this.OutBox.Name = "OutBox";
            this.OutBox.Size = new System.Drawing.Size(482, 20);
            this.OutBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.OutBox);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.plus);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.b_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button plus;
        private Button equals;
        private Button B1;
        private Button B2;
        private Button B3;
        private Button B6;
        private Button B5;
        private Button B4;
        private Button B9;
        private Button B8;
        private Button B7;
        private Button B0;
        private TextBox OutBox;
    }
}