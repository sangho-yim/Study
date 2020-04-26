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
    // 수식: +, -, *, /, %
    // 증감: ++, --
    // 할당: =, +=, -=, *=, /=, %=
    // 논리: &&, ||, ! (and, or, not)
    // 관계: <, >, ==, !=, >=, <=
    // 비트: &, |, ^
    // 시프트: >>, <<

    public partial class fm_Operator : Form
    {
        public fm_Operator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iResult = 0;
            int iTemp = int.Parse(tb_Result.Text);
            int iNumber = int.Parse(tb_Number.Text);

            iResult = iTemp << iNumber; // bit 연산자

            tb_Result.Text = iResult.ToString();
        }

        private void tb_Result_TextChanged(object sender, EventArgs e)
        {
            tb_ResultBit.Text = Convert.ToString(int.Parse(tb_Result.Text), 2); // 2진수로 바꾸는 방법
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iResult = 0;
            int iTemp = int.Parse(tb_Result.Text);
            int iNumber = int.Parse(tb_Number.Text);

            iResult = iTemp >> iNumber; // bit 연산자

            tb_Result.Text = iResult.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int iTemp = int.Parse(tb_Result.Text);
            int iNumber = int.Parse(tb_Number.Text);

            // iTemp = iTemp + iNumber;
            iTemp += iNumber;

            tb_Result.Text = iTemp.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int iTemp = int.Parse(tb_Result.Text);
            int iNumber = int.Parse(tb_Number.Text);

            // iTemp = iTemp + iNumber;
            iTemp -= iNumber;

            tb_Result.Text = iTemp.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int iTemp = int.Parse(tb_Result.Text);

            tb_Result.Text = (++iTemp).ToString();
            tb_ResultAfter.Text = iTemp.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int iTemp = int.Parse(tb_Result.Text);

            //iTemp = iTemp + 1;
            tb_Result.Text = (iTemp++).ToString();
            tb_ResultAfter.Text = iTemp.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int iTemp1 = int.Parse(tb_Result.Text);
            int iTemp2 = int.Parse(tb_ResultAfter.Text);
            int iNumber = int.Parse(tb_Number.Text);
            // 두 수가 iNumber보다 크면 참 아니면 거짓
            bool bResult = (iTemp1 > iNumber && iTemp2 > iNumber);

            tb_AndOr.Text = bResult.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int iTemp1 = int.Parse(tb_Result.Text);
            int iTemp2 = int.Parse(tb_ResultAfter.Text);
            int iNumber = int.Parse(tb_Number.Text);
            // 둘중에 하나라도 iNumber보다 크면 참 아니면 거짓
            bool bResult = (iTemp1 > iNumber || iTemp2 > iNumber);

            tb_AndOr.Text = bResult.ToString();
        }
    }
}
