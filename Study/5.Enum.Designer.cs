namespace Study
{
    partial class fm_Enum
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
            this.tbox_Name = new System.Windows.Forms.TextBox();
            this.lbox_Day = new System.Windows.Forms.ListBox();
            this.lbox_Time = new System.Windows.Forms.ListBox();
            this.btn_Result = new System.Windows.Forms.Button();
            this.btn_ResultStringFormat = new System.Windows.Forms.Button();
            this.tbox_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbox_Name
            // 
            this.tbox_Name.Location = new System.Drawing.Point(12, 12);
            this.tbox_Name.Name = "tbox_Name";
            this.tbox_Name.Size = new System.Drawing.Size(100, 21);
            this.tbox_Name.TabIndex = 0;
            // 
            // lbox_Day
            // 
            this.lbox_Day.FormattingEnabled = true;
            this.lbox_Day.ItemHeight = 12;
            this.lbox_Day.Location = new System.Drawing.Point(12, 39);
            this.lbox_Day.Name = "lbox_Day";
            this.lbox_Day.Size = new System.Drawing.Size(196, 184);
            this.lbox_Day.TabIndex = 1;
            // 
            // lbox_Time
            // 
            this.lbox_Time.FormattingEnabled = true;
            this.lbox_Time.ItemHeight = 12;
            this.lbox_Time.Location = new System.Drawing.Point(214, 39);
            this.lbox_Time.Name = "lbox_Time";
            this.lbox_Time.Size = new System.Drawing.Size(196, 184);
            this.lbox_Time.TabIndex = 1;
            // 
            // btn_Result
            // 
            this.btn_Result.Location = new System.Drawing.Point(13, 230);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(75, 23);
            this.btn_Result.TabIndex = 2;
            this.btn_Result.Text = "결과보기";
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // btn_ResultStringFormat
            // 
            this.btn_ResultStringFormat.Location = new System.Drawing.Point(94, 230);
            this.btn_ResultStringFormat.Name = "btn_ResultStringFormat";
            this.btn_ResultStringFormat.Size = new System.Drawing.Size(150, 23);
            this.btn_ResultStringFormat.TabIndex = 2;
            this.btn_ResultStringFormat.Text = "String Format Test";
            this.btn_ResultStringFormat.UseVisualStyleBackColor = true;
            this.btn_ResultStringFormat.Click += new System.EventHandler(this.btn_ResultStringFormat_Click);
            // 
            // tbox_Result
            // 
            this.tbox_Result.Enabled = false;
            this.tbox_Result.Location = new System.Drawing.Point(13, 260);
            this.tbox_Result.Multiline = true;
            this.tbox_Result.Name = "tbox_Result";
            this.tbox_Result.Size = new System.Drawing.Size(397, 72);
            this.tbox_Result.TabIndex = 3;
            // 
            // fm_Enum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 344);
            this.Controls.Add(this.tbox_Result);
            this.Controls.Add(this.btn_ResultStringFormat);
            this.Controls.Add(this.btn_Result);
            this.Controls.Add(this.lbox_Time);
            this.Controls.Add(this.lbox_Day);
            this.Controls.Add(this.tbox_Name);
            this.Name = "fm_Enum";
            this.Text = "5.Enum";
            this.Load += new System.EventHandler(this.fm_Enum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_Name;
        private System.Windows.Forms.ListBox lbox_Day;
        private System.Windows.Forms.ListBox lbox_Time;
        private System.Windows.Forms.Button btn_Result;
        private System.Windows.Forms.Button btn_ResultStringFormat;
        private System.Windows.Forms.TextBox tbox_Result;
    }
}