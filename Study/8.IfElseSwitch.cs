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
    // 조건문 (if else, switch)

    /*
     * - 목적
     *  a. 조건에 따라 프로그램을 분기해서 처리하고 싶을 경우 사용
     *  if (){}
     *  else if (){}
     *  else {}
     *  
     *  switch(항목)
     *  {
     *      case 항목명1:
     *          break;
     *      case 항목명2:
     *          break;
     *      default:
     *          break;
     *  }
    */

    public partial class fmIfElseSwitch : Form
    {
        public fmIfElseSwitch()
        {
            InitializeComponent();
            ifTest();
            switchTest();
        }
        private void ifTest()
        {
            int ia = 30;
            int ib = 20;

            string strResult = string.Empty;
            // 조건이 한줄이면 중괄호가 필요 없다.
            if (ia > ib) strResult = "ia가 크다";
            else if (ia < ib) strResult = "ib가 크다";
            else strResult = "같다";

            strResult = (ia > ib) ? "ia가 크다" : "ia가 크지 않다";

            if (ia > 5 && ib > 5) strResult = "둘 다 5보다 크다";
            if (ia > 5 || ib > 5) strResult = "둘 중에 하나 이상은 5보다 크다";
        }
        private void switchTest()
        {
            int iRet = 3;
            string strResult = string.Empty;

            switch(iRet)
            {
                case 2: case 3:
                    {
                        strResult = "2 or 3";
                    }
                    break;
                case 4:
                    {
                        strResult = "4";
                    }
                    break;
                default:
                    {
                        strResult = "?";

                    }
                    break;
            }
        }

        private void btnifResult_Click(object sender, EventArgs e)
        {
            int iNumber1 = (int)nNumber1.Value;
            int iNumber2 = (int)nNumber2.Value;

            if (iNumber1 > iNumber2)
            {
                lblifResult.Text = string.Format("- Number1이 Number2보다 {0} 더 큽니다.", iNumber1 - iNumber2);
            }
            else if (iNumber1 < iNumber2)
            {
                lblifResult.Text = string.Format("- Number2가 Number1보다 {0} 더 큽니다.", iNumber2 - iNumber1);
            }
            else
            {
                lblifResult.Text = string.Format("- 두 숫자는 같습니다..", iNumber1);
            }
        }

        private void btnswitchResult_Click(object sender, EventArgs e)
        {
            string strSelect = cboxDay.Text;
            switch (strSelect)
            {
                case "월":
                    lblswitchResult.Text = "- 선택 날짜는 월요일 입니다.";
                    break;
                case "화":
                    lblswitchResult.Text = "- 선택 날짜는 화요일 입니다.";
                    break;
                case "수":
                    lblswitchResult.Text = "- 선택 날짜는 수요일 입니다.";
                    break;
                case "목":
                    lblswitchResult.Text = "- 선택 날짜는 목요일 입니다.";
                    break;
                case "금":
                    lblswitchResult.Text = "- 선택 날짜는 금요일 입니다.";
                    break;
                case "토":
                case "일":
                    lblswitchResult.Text = "- 선택 날짜는 토요일 또는 일요일 입니다.";
                    break;
                default:
                    break;
            }

        }
    }
}
