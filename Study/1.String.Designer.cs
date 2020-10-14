namespace Study
{
    partial class fm_String
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbContain = new System.Windows.Forms.Label();
            this.lbEquals = new System.Windows.Forms.Label();
            this.lbLength = new System.Windows.Forms.Label();
            this.lbReplace = new System.Windows.Forms.Label();
            this.lbSplit1 = new System.Windows.Forms.Label();
            this.lbSubstring = new System.Windows.Forms.Label();
            this.lbToLower = new System.Windows.Forms.Label();
            this.lbToUpper = new System.Windows.Forms.Label();
            this.lbTrim = new System.Windows.Forms.Label();
            this.lbSplit2 = new System.Windows.Forms.Label();
            this.lbSplit3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Text
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Consolas", 16F);
            this.lbText.Location = new System.Drawing.Point(73, 46);
            this.lbText.Name = "lb_Text";
            this.lbText.Size = new System.Drawing.Size(228, 26);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Sample, Test, Text";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 16F);
            this.button1.Location = new System.Drawing.Point(328, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 16F);
            this.label2.Location = new System.Drawing.Point(75, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 16F);
            this.label3.Location = new System.Drawing.Point(73, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Equals";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 16F);
            this.label4.Location = new System.Drawing.Point(73, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 16F);
            this.label5.Location = new System.Drawing.Point(73, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Replace";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 16F);
            this.label6.Location = new System.Drawing.Point(73, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Split";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 16F);
            this.label7.Location = new System.Drawing.Point(75, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Substring";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 16F);
            this.label8.Location = new System.Drawing.Point(75, 540);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "ToLower";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 16F);
            this.label9.Location = new System.Drawing.Point(75, 593);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 26);
            this.label9.TabIndex = 3;
            this.label9.Text = "ToUpper";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 16F);
            this.label10.Location = new System.Drawing.Point(75, 646);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 26);
            this.label10.TabIndex = 3;
            this.label10.Text = "Trim";
            // 
            // lb_Contain
            // 
            this.lbContain.AutoSize = true;
            this.lbContain.Font = new System.Drawing.Font("Consolas", 16F);
            this.lbContain.Location = new System.Drawing.Point(201, 130);
            this.lbContain.Name = "lb_Contain";
            this.lbContain.Size = new System.Drawing.Size(48, 26);
            this.lbContain.TabIndex = 4;
            this.lbContain.Text = "...";
            // 
            // lb_Equals
            // 
            this.lbEquals.AutoSize = true;
            this.lbEquals.Font = new System.Drawing.Font("Consolas", 16F);
            this.lbEquals.Location = new System.Drawing.Point(201, 183);
            this.lbEquals.Name = "lb_Equals";
            this.lbEquals.Size = new System.Drawing.Size(48, 26);
            this.lbEquals.TabIndex = 4;
            this.lbEquals.Text = "...";
            // 
            // lb_Length
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Font = new System.Drawing.Font("Consolas", 16F);
            this.lbLength.Location = new System.Drawing.Point(201, 236);
            this.lbLength.Name = "lb_Length";
            this.lbLength.Size = new System.Drawing.Size(48, 26);
            this.lbLength.TabIndex = 4;
            this.lbLength.Text = "...";
            // 
            // lb_Replace
            // 
            this.lbReplace.AutoSize = true;
            this.lbReplace.Font = new System.Drawing.Font("Consolas", 16F);
            this.lbReplace.Location = new System.Drawing.Point(201, 289);
            this.lbReplace.Name = "lb_Replace";
            this.lbReplace.Size = new System.Drawing.Size(48, 26);
            this.lbReplace.TabIndex = 4;
            this.lbReplace.Text = "...";
            // 
            // lb_Split1
            // 
            this.lbSplit1.AutoSize = true;
            this.lbSplit1.Font = new System.Drawing.Font("Consolas", 16F);
            this.lbSplit1.Location = new System.Drawing.Point(201, 342);
            this.lbSplit1.Name = "lb_Split1";
            this.lbSplit1.Size = new System.Drawing.Size(48, 26);
            this.lbSplit1.TabIndex = 4;
            this.lbSplit1.Text = "...";
            // 
            // lb_Substring
            // 
            this.lbSubstring.AutoSize = true;
            this.lbSubstring.Font = new System.Drawing.Font("Consolas", 16F);
            this.lbSubstring.Location = new System.Drawing.Point(201, 487);
            this.lbSubstring.Name = "lb_Substring";
            this.lbSubstring.Size = new System.Drawing.Size(48, 26);
            this.lbSubstring.TabIndex = 4;
            this.lbSubstring.Text = "...";
            // 
            // lb_ToLower
            // 
            this.lbToLower.AutoSize = true;
            this.lbToLower.Font = new System.Drawing.Font("Consolas", 16F);
            this.lbToLower.Location = new System.Drawing.Point(201, 540);
            this.lbToLower.Name = "lb_ToLower";
            this.lbToLower.Size = new System.Drawing.Size(48, 26);
            this.lbToLower.TabIndex = 4;
            this.lbToLower.Text = "...";
            // 
            // lb_ToUpper
            // 
            this.lbToUpper.AutoSize = true;
            this.lbToUpper.Font = new System.Drawing.Font("Consolas", 16F);
            this.lbToUpper.Location = new System.Drawing.Point(201, 593);
            this.lbToUpper.Name = "lb_ToUpper";
            this.lbToUpper.Size = new System.Drawing.Size(48, 26);
            this.lbToUpper.TabIndex = 4;
            this.lbToUpper.Text = "...";
            // 
            // lb_Trim
            // 
            this.lbTrim.AutoSize = true;
            this.lbTrim.Font = new System.Drawing.Font("Consolas", 16F);
            this.lbTrim.Location = new System.Drawing.Point(201, 646);
            this.lbTrim.Name = "lb_Trim";
            this.lbTrim.Size = new System.Drawing.Size(48, 26);
            this.lbTrim.TabIndex = 4;
            this.lbTrim.Text = "...";
            // 
            // lb_Split2
            // 
            this.lbSplit2.AutoSize = true;
            this.lbSplit2.Font = new System.Drawing.Font("Consolas", 16F);
            this.lbSplit2.Location = new System.Drawing.Point(201, 387);
            this.lbSplit2.Name = "lb_Split2";
            this.lbSplit2.Size = new System.Drawing.Size(48, 26);
            this.lbSplit2.TabIndex = 4;
            this.lbSplit2.Text = "...";
            // 
            // lb_Split3
            // 
            this.lbSplit3.AutoSize = true;
            this.lbSplit3.Font = new System.Drawing.Font("Consolas", 16F);
            this.lbSplit3.Location = new System.Drawing.Point(201, 431);
            this.lbSplit3.Name = "lb_Split3";
            this.lbSplit3.Size = new System.Drawing.Size(48, 26);
            this.lbSplit3.TabIndex = 4;
            this.lbSplit3.Text = "...";
            // 
            // fm_String
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(609, 731);
            this.Controls.Add(this.lbTrim);
            this.Controls.Add(this.lbToUpper);
            this.Controls.Add(this.lbToLower);
            this.Controls.Add(this.lbSubstring);
            this.Controls.Add(this.lbSplit3);
            this.Controls.Add(this.lbSplit2);
            this.Controls.Add(this.lbSplit1);
            this.Controls.Add(this.lbReplace);
            this.Controls.Add(this.lbLength);
            this.Controls.Add(this.lbEquals);
            this.Controls.Add(this.lbContain);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbText);
            this.Name = "fm_String";
            this.Text = "1.String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbContain;
        private System.Windows.Forms.Label lbEquals;
        private System.Windows.Forms.Label lbLength;
        private System.Windows.Forms.Label lbReplace;
        private System.Windows.Forms.Label lbSplit1;
        private System.Windows.Forms.Label lbSubstring;
        private System.Windows.Forms.Label lbToLower;
        private System.Windows.Forms.Label lbToUpper;
        private System.Windows.Forms.Label lbTrim;
        private System.Windows.Forms.Label lbSplit2;
        private System.Windows.Forms.Label lbSplit3;
    }
}

