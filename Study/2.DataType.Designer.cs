namespace Study
{
    partial class fm_DataType
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
            this.tb_Number = new System.Windows.Forms.TextBox();
            this.bt_AutoChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Short = new System.Windows.Forms.Label();
            this.lb_Int = new System.Windows.Forms.Label();
            this.lb_Double = new System.Windows.Forms.Label();
            this.lb_Exception = new System.Windows.Forms.Label();
            this.bt_Short = new System.Windows.Forms.Button();
            this.bt_Int = new System.Windows.Forms.Button();
            this.bt_Double = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Number
            // 
            this.tb_Number.Location = new System.Drawing.Point(24, 21);
            this.tb_Number.Name = "tb_Number";
            this.tb_Number.Size = new System.Drawing.Size(529, 21);
            this.tb_Number.TabIndex = 0;
            // 
            // bt_AutoChange
            // 
            this.bt_AutoChange.Location = new System.Drawing.Point(581, 21);
            this.bt_AutoChange.Name = "bt_AutoChange";
            this.bt_AutoChange.Size = new System.Drawing.Size(98, 23);
            this.bt_AutoChange.TabIndex = 1;
            this.bt_AutoChange.Text = "알아서 변환";
            this.bt_AutoChange.UseVisualStyleBackColor = true;
            this.bt_AutoChange.Click += new System.EventHandler(this.bt_AutoChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Short";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Int";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Double";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Exception";
            // 
            // lb_Short
            // 
            this.lb_Short.AutoSize = true;
            this.lb_Short.Location = new System.Drawing.Point(165, 96);
            this.lb_Short.Name = "lb_Short";
            this.lb_Short.Size = new System.Drawing.Size(11, 12);
            this.lb_Short.TabIndex = 5;
            this.lb_Short.Text = "0";
            // 
            // lb_Int
            // 
            this.lb_Int.AutoSize = true;
            this.lb_Int.Location = new System.Drawing.Point(165, 137);
            this.lb_Int.Name = "lb_Int";
            this.lb_Int.Size = new System.Drawing.Size(11, 12);
            this.lb_Int.TabIndex = 5;
            this.lb_Int.Text = "0";
            // 
            // lb_Double
            // 
            this.lb_Double.AutoSize = true;
            this.lb_Double.Location = new System.Drawing.Point(165, 179);
            this.lb_Double.Name = "lb_Double";
            this.lb_Double.Size = new System.Drawing.Size(11, 12);
            this.lb_Double.TabIndex = 5;
            this.lb_Double.Text = "0";
            // 
            // lb_Exception
            // 
            this.lb_Exception.AutoSize = true;
            this.lb_Exception.Location = new System.Drawing.Point(165, 216);
            this.lb_Exception.Name = "lb_Exception";
            this.lb_Exception.Size = new System.Drawing.Size(17, 12);
            this.lb_Exception.TabIndex = 5;
            this.lb_Exception.Text = "...";
            // 
            // bt_Short
            // 
            this.bt_Short.Location = new System.Drawing.Point(286, 91);
            this.bt_Short.Name = "bt_Short";
            this.bt_Short.Size = new System.Drawing.Size(92, 23);
            this.bt_Short.TabIndex = 1;
            this.bt_Short.Text = "Short 변환";
            this.bt_Short.UseVisualStyleBackColor = true;
            this.bt_Short.Click += new System.EventHandler(this.bt_Short_Click);
            // 
            // bt_Int
            // 
            this.bt_Int.Location = new System.Drawing.Point(286, 132);
            this.bt_Int.Name = "bt_Int";
            this.bt_Int.Size = new System.Drawing.Size(92, 23);
            this.bt_Int.TabIndex = 1;
            this.bt_Int.Text = "Int 변환";
            this.bt_Int.UseVisualStyleBackColor = true;
            this.bt_Int.Click += new System.EventHandler(this.bt_Int_Click);
            // 
            // bt_Double
            // 
            this.bt_Double.Location = new System.Drawing.Point(286, 174);
            this.bt_Double.Name = "bt_Double";
            this.bt_Double.Size = new System.Drawing.Size(92, 23);
            this.bt_Double.TabIndex = 1;
            this.bt_Double.Text = "Double 변환";
            this.bt_Double.UseVisualStyleBackColor = true;
            this.bt_Double.Click += new System.EventHandler(this.bt_Double_Click);
            // 
            // fm_DataType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 326);
            this.Controls.Add(this.lb_Exception);
            this.Controls.Add(this.lb_Double);
            this.Controls.Add(this.lb_Int);
            this.Controls.Add(this.lb_Short);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Double);
            this.Controls.Add(this.bt_Int);
            this.Controls.Add(this.bt_Short);
            this.Controls.Add(this.bt_AutoChange);
            this.Controls.Add(this.tb_Number);
            this.Name = "fm_DataType";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Number;
        private System.Windows.Forms.Button bt_AutoChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Short;
        private System.Windows.Forms.Label lb_Int;
        private System.Windows.Forms.Label lb_Double;
        private System.Windows.Forms.Label lb_Exception;
        private System.Windows.Forms.Button bt_Short;
        private System.Windows.Forms.Button bt_Int;
        private System.Windows.Forms.Button bt_Double;
    }
}