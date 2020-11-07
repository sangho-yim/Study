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
    public partial class fmMethod : Form
    {
        public fmMethod()
        {
            InitializeComponent();
        }

        private void bt_Plus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tb_Num1.Text);
            int iNumB = int.Parse(tb_Num2.Text);
            //int iResult = iNumA + iNumB;
            //tb_Result.Text = iResult.ToString();
            tb_Result.Text = ft_Plus(iNumA, iNumB).ToString();
        }

        private void bt_Minus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tb_Num1.Text);
            int iNumB = int.Parse(tb_Num2.Text);
            //int iResult = iNumA - iNumB;
            //tb_Result.Text = iResult.ToString();
            tb_Result.Text = ft_Minus(iNumA, iNumB).ToString();
        }

        private void bt_Multi_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tb_Num1.Text);
            int iNumB = int.Parse(tb_Num2.Text);
            //int iResult = iNumA * iNumB;
            //tb_Result.Text = iResult.ToString();
            tb_Result.Text = ft_Multiple(iNumA, iNumB).ToString();
        }

        private void bt_Division_Click(object sender, EventArgs e)
        {
            float iNumA = float.Parse(tb_Num1.Text);
            float iNumB = float.Parse(tb_Num2.Text);
            //float iResultA = iNumA / iNumB;      // 몫
            //float iResultB = iNumA % iNumB;      // 나머지
            //tb_Result.Text = iResultA.ToString();
            tb_Result.Text = ft_Division(iNumA, iNumB).ToString();
        }
        // 메소드 및 프로그래밍 형태를 파악하기 위한 간단한 계산기 만들기
        // 산술 연산자의 경우 추후 강의에 추가

        // 프로그램의 기본 형태 (선언 > 초기화 > 사용)

        // 메소드(Method): 클래스 내에서 일련의 코드 블록을 실행시키는 함수
        // 메소드의 형태: 접근제어자 반환형 이름(인자 선언) {}

        // 접근제어자: private, public 반환형: void(반환자가 없다) 인자
        // 기본 함수 form
        private int ft_Exe(int iA)
        {
            return 0;
        }

        private int ft_Plus(int iA, int iB)
        {
            int iResult = 0;
            iResult = iA + iB;
            return iResult;
        }
        private int ft_Minus(int iA, int iB)
        {
            int iResult = 0;
            iResult = iA - iB;
            return iResult;
        }
        private int ft_Multiple(int iA, int iB)
        {
            int iResult = 0;
            iResult = iA * iB;
            return iResult;
        }
        private float ft_Division(float iA, float iB)
        {
            float iResult = 0;
            iResult = iA / iB;
            return iResult;
        }
    }
}
