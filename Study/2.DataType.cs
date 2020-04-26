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

    public partial class fm_DataType : Form
    {
        public fm_DataType()
        {
            InitializeComponent();
        }

        private void bt_Short_Click(object sender, EventArgs e)
        {
            try
            {
                short sNumber = short.Parse(tb_Number.Text);
                lb_Short.Text = sNumber.ToString();
                lb_Exception.Text = "...";
            }
            catch(Exception ex)
            {
                lb_Short.Text = "Error";
                lb_Exception.Text = ex.ToString();
            }
        }

        private void bt_Int_Click(object sender, EventArgs e)
        {
            try
            {
                int sNumber = int.Parse(tb_Number.Text);
                lb_Int.Text = sNumber.ToString();
                lb_Exception.Text = "...";
            }
            catch (Exception ex)
            {
                lb_Int.Text = "Error";
                lb_Exception.Text = ex.ToString();
            }
        }

        private void bt_Double_Click(object sender, EventArgs e)
        {
            try
            {
                Double sNumber = Double.Parse(tb_Number.Text);
                lb_Double.Text = sNumber.ToString();
                lb_Exception.Text = "...";
            }
            catch (Exception ex)
            {
                lb_Double.Text = "Error";
                lb_Exception.Text = ex.ToString();
            }
        }

        private void bt_AutoChange_Click(object sender, EventArgs e)
        {
            short sNumber = 0;
            int iNumber = 0;
            double dNumber = 0;
            lb_Exception.Text = "...";

            if (short.TryParse(tb_Number.Text,out sNumber))
            {
                lb_Short.Text = sNumber.ToString();
                lb_Int.Text = "0";
                lb_Double.Text = "0";
            }
            else if (int.TryParse(tb_Number.Text, out iNumber))
            {
                lb_Short.Text = "0";
                lb_Int.Text = iNumber.ToString();
                lb_Double.Text = "0";
            }
            else if (double.TryParse(tb_Number.Text, out dNumber))
            {
                lb_Short.Text = "0";
                lb_Int.Text = "0";
                lb_Double.Text = dNumber.ToString();
            }
            else
            {
                lb_Exception.Text = "변환할 수 없음";
            }
        }
    }
}
