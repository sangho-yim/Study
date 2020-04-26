namespace Study
{
    partial class fm_Method
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
            this.tb_Num1 = new System.Windows.Forms.TextBox();
            this.tb_Num2 = new System.Windows.Forms.TextBox();
            this.bt_Plus = new System.Windows.Forms.Button();
            this.bt_Minus = new System.Windows.Forms.Button();
            this.bt_Multi = new System.Windows.Forms.Button();
            this.bt_Division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Result
            // 
            this.tb_Result.Enabled = false;
            this.tb_Result.Location = new System.Drawing.Point(12, 12);
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.Size = new System.Drawing.Size(318, 21);
            this.tb_Result.TabIndex = 0;
            this.tb_Result.Text = "0";
            // 
            // tb_Num1
            // 
            this.tb_Num1.Location = new System.Drawing.Point(12, 39);
            this.tb_Num1.Name = "tb_Num1";
            this.tb_Num1.Size = new System.Drawing.Size(156, 21);
            this.tb_Num1.TabIndex = 0;
            this.tb_Num1.Text = "0";
            // 
            // tb_Num2
            // 
            this.tb_Num2.Location = new System.Drawing.Point(174, 39);
            this.tb_Num2.Name = "tb_Num2";
            this.tb_Num2.Size = new System.Drawing.Size(156, 21);
            this.tb_Num2.TabIndex = 0;
            this.tb_Num2.Text = "0";
            // 
            // bt_Plus
            // 
            this.bt_Plus.Location = new System.Drawing.Point(12, 66);
            this.bt_Plus.Name = "bt_Plus";
            this.bt_Plus.Size = new System.Drawing.Size(75, 60);
            this.bt_Plus.TabIndex = 1;
            this.bt_Plus.Text = "+";
            this.bt_Plus.UseVisualStyleBackColor = true;
            this.bt_Plus.Click += new System.EventHandler(this.bt_Plus_Click);
            // 
            // bt_Minus
            // 
            this.bt_Minus.Location = new System.Drawing.Point(93, 66);
            this.bt_Minus.Name = "bt_Minus";
            this.bt_Minus.Size = new System.Drawing.Size(75, 60);
            this.bt_Minus.TabIndex = 1;
            this.bt_Minus.Text = "-";
            this.bt_Minus.UseVisualStyleBackColor = true;
            this.bt_Minus.Click += new System.EventHandler(this.bt_Minus_Click);
            // 
            // bt_Multi
            // 
            this.bt_Multi.Location = new System.Drawing.Point(174, 66);
            this.bt_Multi.Name = "bt_Multi";
            this.bt_Multi.Size = new System.Drawing.Size(75, 60);
            this.bt_Multi.TabIndex = 1;
            this.bt_Multi.Text = "*";
            this.bt_Multi.UseVisualStyleBackColor = true;
            this.bt_Multi.Click += new System.EventHandler(this.bt_Multi_Click);
            // 
            // bt_Division
            // 
            this.bt_Division.Location = new System.Drawing.Point(255, 66);
            this.bt_Division.Name = "bt_Division";
            this.bt_Division.Size = new System.Drawing.Size(75, 60);
            this.bt_Division.TabIndex = 1;
            this.bt_Division.Text = "/";
            this.bt_Division.UseVisualStyleBackColor = true;
            this.bt_Division.Click += new System.EventHandler(this.bt_Division_Click);
            // 
            // fm_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 136);
            this.Controls.Add(this.bt_Division);
            this.Controls.Add(this.bt_Multi);
            this.Controls.Add(this.bt_Minus);
            this.Controls.Add(this.bt_Plus);
            this.Controls.Add(this.tb_Num2);
            this.Controls.Add(this.tb_Num1);
            this.Controls.Add(this.tb_Result);
            this.Name = "fm_Method";
            this.Text = "3.Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Result;
        private System.Windows.Forms.TextBox tb_Num1;
        private System.Windows.Forms.TextBox tb_Num2;
        private System.Windows.Forms.Button bt_Plus;
        private System.Windows.Forms.Button bt_Minus;
        private System.Windows.Forms.Button bt_Multi;
        private System.Windows.Forms.Button bt_Division;
    }
}