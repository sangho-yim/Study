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
    // DataType(bit): Range
    // bool(1): True, False
    // sbyte(8): -128 ~ 127
    // byte(8): 0 ~ 255
    // short(16): -32,768 ~ 32,767
    // ushort(16): 0 ~ 65,536
    // int(32): -2,147,483,648 ~ 2,147,483,647
    // uint(32): 0 ~ 4,294,967,296
    // long(64): -9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807
    // ulong(64): 0 ~ 18,446,744,073,709,551,615
    // float(32): ±1.5e-45 ~ ±3.4e38
    // bouble(64): ±5.0e-324 ~ ±1.7e308
    // decimal(128): (-7.9x1028-7.9x1028) / (100-28)
    // char(16): 0 ~ 65536
    // Overflow: 메모리 용량을 넘어선 값이 들어가 생기는 오류

    public partial class fmDataType : Form
    {
        public fmDataType()
        {
            InitializeComponent();
        }

        private void btShort_Click(object sender, EventArgs e)
        {
            try
            {
                short sNumber = short.Parse(tbNumber.Text);
                lbShort.Text = sNumber.ToString();
                lbException.Text = "...";
            }
            catch(Exception ex)
            {
                lbShort.Text = "Error";
                lbException.Text = ex.ToString();
            }
        }

        private void btInt_Click(object sender, EventArgs e)
        {
            try
            {
                int sNumber = int.Parse(tbNumber.Text);
                lbInt.Text = sNumber.ToString();
                lbException.Text = "...";
            }
            catch (Exception ex)
            {
                lbInt.Text = "Error";
                lbException.Text = ex.ToString();
            }
        }

        private void btDouble_Click(object sender, EventArgs e)
        {
            try
            {
                Double sNumber = Double.Parse(tbNumber.Text);
                lbDouble.Text = sNumber.ToString();
                lbException.Text = "...";
            }
            catch (Exception ex)
            {
                lbDouble.Text = "Error";
                lbException.Text = ex.ToString();
            }
        }

        private void btAutoChange_Click(object sender, EventArgs e)
        {
            short sNumber = 0;
            int iNumber = 0;
            double dNumber = 0;
            lbException.Text = "...";

            if (short.TryParse(tbNumber.Text,out sNumber))
            {
                lbShort.Text = sNumber.ToString();
                lbInt.Text = "0";
                lbDouble.Text = "0";
            }
            else if (int.TryParse(tbNumber.Text, out iNumber))
            {
                lbShort.Text = "0";
                lbInt.Text = iNumber.ToString();
                lbDouble.Text = "0";
            }
            else if (double.TryParse(tbNumber.Text, out dNumber))
            {
                lbShort.Text = "0";
                lbInt.Text = "0";
                lbDouble.Text = dNumber.ToString();
            }
            else
            {
                lbException.Text = "변환할 수 없음";
            }
        }
    }
}
