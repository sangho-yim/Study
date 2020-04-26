namespace Study
{
    partial class fm_Operator
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
            this.tb_Result = new System.Windows.Forms.TextBox();
            this.tb_ResultAfter = new System.Windows.Forms.TextBox();
            this.tb_ResultBit = new System.Windows.Forms.TextBox();
            this.tb_Number = new System.Windows.Forms.TextBox();
            this.tb_AndOr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Result
            // 
            this.tb_Result.Location = new System.Drawing.Point(12, 12);
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.Size = new System.Drawing.Size(100, 21);
            this.tb_Result.TabIndex = 0;
            this.tb_Result.Text = "0";
            this.tb_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Result.TextChanged += new System.EventHandler(this.tb_Result_TextChanged);
            // 
            // tb_ResultAfter
            // 
            this.tb_ResultAfter.Location = new System.Drawing.Point(118, 12);
            this.tb_ResultAfter.Name = "tb_ResultAfter";
            this.tb_ResultAfter.Size = new System.Drawing.Size(100, 21);
            this.tb_ResultAfter.TabIndex = 0;
            this.tb_ResultAfter.Text = "0";
            this.tb_ResultAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_ResultBit
            // 
            this.tb_ResultBit.Enabled = false;
            this.tb_ResultBit.Location = new System.Drawing.Point(12, 39);
            this.tb_ResultBit.Name = "tb_ResultBit";
            this.tb_ResultBit.Size = new System.Drawing.Size(100, 21);
            this.tb_ResultBit.TabIndex = 0;
            this.tb_ResultBit.Text = "0";
            this.tb_ResultBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_Number
            // 
            this.tb_Number.Location = new System.Drawing.Point(12, 79);
            this.tb_Number.Name = "tb_Number";
            this.tb_Number.Size = new System.Drawing.Size(100, 21);
            this.tb_Number.TabIndex = 0;
            this.tb_Number.Text = "0";
            this.tb_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_AndOr
            // 
            this.tb_AndOr.Enabled = false;
            this.tb_AndOr.Location = new System.Drawing.Point(119, 79);
            this.tb_AndOr.Name = "tb_AndOr";
            this.tb_AndOr.Size = new System.Drawing.Size(100, 21);
            this.tb_AndOr.TabIndex = 0;
            this.tb_AndOr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(119, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "+=";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(172, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 40);
            this.button4.TabIndex = 1;
            this.button4.Text = "-=";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 152);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 40);
            this.button5.TabIndex = 1;
            this.button5.Text = "++a";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(65, 152);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 40);
            this.button6.TabIndex = 1;
            this.button6.Text = "a++";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(119, 152);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(47, 40);
            this.button7.TabIndex = 1;
            this.button7.Text = "&&";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(172, 152);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(47, 40);
            this.button8.TabIndex = 1;
            this.button8.Text = "||";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // fm_Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 203);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_AndOr);
            this.Controls.Add(this.tb_Number);
            this.Controls.Add(this.tb_ResultBit);
            this.Controls.Add(this.tb_ResultAfter);
            this.Controls.Add(this.tb_Result);
            this.Name = "fm_Operator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Result;
        private System.Windows.Forms.TextBox tb_ResultAfter;
        private System.Windows.Forms.TextBox tb_ResultBit;
        private System.Windows.Forms.TextBox tb_Number;
        private System.Windows.Forms.TextBox tb_AndOr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}