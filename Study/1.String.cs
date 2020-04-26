using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study
{
    // Contain: 문자열 안에 해당하는 문자열이 있는지 확인
    // Equals: 문자열이 해당 문자열과 동일한지 확인
    // Length: 개체의 문자 수를 반환
    // Replace: 지정된 문자열을 다른 문자열로 모두 변환
    // Split: 문자열에서 조건에 맞는 문자를 기준으로 분할
    // Substring: 문자열 내의 조건 위치의 부분 문자열을 검색
    // ToLower: 문자열을 소문자로 변환
    // ToUpper: 문자열을 대문자로 변환
    // Trim: 문자열 전, 후의 공백을 제거
    public partial class fm_String : Form
    {
        public fm_String()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Sample, Test, Text
            string strText = lb_Text.Text;
            
            lb_Contain.Text = strText.Contains("Text").ToString();
            lb_Equals.Text = strText.Equals("Text").ToString();
            lb_Length.Text = strText.Length.ToString();
            lb_Replace.Text = strText.Replace("Test","newTest");
            
            string[] strSplit = strText.Split(',');
            lb_Split1.Text = strSplit[0].ToString();
            lb_Split2.Text = strSplit[1].ToString().Trim();
            lb_Split3.Text = strSplit[2].ToString().Trim();

            lb_Substring.Text = strText.Substring(3, 5).ToString();
            lb_ToLower.Text = strText.ToLower().ToString();
            lb_ToUpper.Text = strText.ToUpper().ToString();
            lb_Trim.Text = strText.Trim().ToString();
        }
    }
}
