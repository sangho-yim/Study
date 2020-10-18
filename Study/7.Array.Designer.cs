namespace Study
{
    partial class fmArray
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
            this.dgvDay = new System.Windows.Forms.DataGridView();
            this.btn_Week = new System.Windows.Forms.Button();
            this.btn_2Week = new System.Windows.Forms.Button();
            this.lbArrayCount = new System.Windows.Forms.Label();
            this.colDay1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "매장 방문 수";
            // 
            // dgvDay
            // 
            this.dgvDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDay1,
            this.colDay2,
            this.colDay3,
            this.colDay4,
            this.colDay5,
            this.colDay6,
            this.colDay7});
            this.dgvDay.Location = new System.Drawing.Point(12, 24);
            this.dgvDay.Name = "dgvDay";
            this.dgvDay.RowTemplate.Height = 23;
            this.dgvDay.Size = new System.Drawing.Size(748, 110);
            this.dgvDay.TabIndex = 1;
            // 
            // btn_Week
            // 
            this.btn_Week.Location = new System.Drawing.Point(14, 140);
            this.btn_Week.Name = "btn_Week";
            this.btn_Week.Size = new System.Drawing.Size(75, 23);
            this.btn_Week.TabIndex = 2;
            this.btn_Week.Text = "일주일간";
            this.btn_Week.UseVisualStyleBackColor = true;
            this.btn_Week.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // btn_2Week
            // 
            this.btn_2Week.Location = new System.Drawing.Point(95, 140);
            this.btn_2Week.Name = "btn_2Week";
            this.btn_2Week.Size = new System.Drawing.Size(75, 23);
            this.btn_2Week.TabIndex = 2;
            this.btn_2Week.Text = "이주일간";
            this.btn_2Week.UseVisualStyleBackColor = true;
            this.btn_2Week.Click += new System.EventHandler(this.btn_2Week_Click);
            // 
            // lbArrayCount
            // 
            this.lbArrayCount.AutoSize = true;
            this.lbArrayCount.Location = new System.Drawing.Point(176, 145);
            this.lbArrayCount.Name = "lbArrayCount";
            this.lbArrayCount.Size = new System.Drawing.Size(87, 12);
            this.lbArrayCount.TabIndex = 3;
            this.lbArrayCount.Text = "전체 자료 수: 0";
            // 
            // colDay1
            // 
            this.colDay1.HeaderText = "월";
            this.colDay1.Name = "colDay1";
            // 
            // colDay2
            // 
            this.colDay2.HeaderText = "화";
            this.colDay2.Name = "colDay2";
            // 
            // colDay3
            // 
            this.colDay3.HeaderText = "수";
            this.colDay3.Name = "colDay3";
            // 
            // colDay4
            // 
            this.colDay4.HeaderText = "목";
            this.colDay4.Name = "colDay4";
            // 
            // colDay5
            // 
            this.colDay5.HeaderText = "금";
            this.colDay5.Name = "colDay5";
            // 
            // colDay6
            // 
            this.colDay6.HeaderText = "토";
            this.colDay6.Name = "colDay6";
            // 
            // colDay7
            // 
            this.colDay7.HeaderText = "일";
            this.colDay7.Name = "colDay7";
            // 
            // FmArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 226);
            this.Controls.Add(this.lbArrayCount);
            this.Controls.Add(this.btn_2Week);
            this.Controls.Add(this.btn_Week);
            this.Controls.Add(this.dgvDay);
            this.Controls.Add(this.label1);
            this.Name = "FmArray";
            this.Text = "7.Array";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDay;
        private System.Windows.Forms.Button btn_Week;
        private System.Windows.Forms.Button btn_2Week;
        private System.Windows.Forms.Label lbArrayCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay7;
    }
}