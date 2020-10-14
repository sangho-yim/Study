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
    // 배열
    // 동일한 Type의 변수를 모아 놓은 집합
    // 배열의 가장 기본적인 형을 알아봅시다
    // 다차원 배열이란?

    // Array: Atest
    // Atest.Length: 배열의 크기를 확인합니다.
    // Arry.Clear(Atest, 0, 2): 배열의 해당 위치 값을 초기화 시킵니다.
    // Array.Resize(ref Atest, 10): 배열의 크기를 변경 합니다.
    // Array.Indexof(Atest, 30): 배열에서 처음 찾은 해당 갑스이 위치를 가져 옵니다.

    // 배열 안쓰면 
    // int iDay1 = 10;
    // int iDay2 = 25;
    // int iDay3 = 3;
    // int iDay4 = 5;
    // int iDay5 = 7;
    // int iDay6 = 15;
    // int iDay7 = 17;

    // 배열 쓰면
    // int[] iDay1 = {10, 25, 3, 5, 7, 15, 17}


    public partial class FmArray : Form
    {
        public FmArray()
        {
            InitializeComponent();
            ArrayTest();
            ArrayClassTest();
        }

        private void ArrayTest()
        {
            /*
            하나씩 선언하고 사용하는 방법..... (배열 미사용)
            int iDay1, iDay2, iDay3;
            iDay1 = 10;
            iDay2 = 20;
            iDay3 = 25;
            */

            //string strT1 = "가,나,다,라";
            //string[] strTest = strT1.Split(',');
            //string[] stringTestArray = { "가", "나", "다", "라" };

            // 일차원 배열
            int[] iArrayTest1 = { 1, 2, 3, 4, 5 };

            // 프로그램은 정의하고, 초기화하고, 값을 넣는다
            // 정의 = 초기화 {값}
            int[] iArrayTest2 = new int[5] { 1, 2, 3, 4, 5 };
            int[] iArrayTest3 = new int[5];
            iArrayTest3[2] = 3;
            iArrayTest3[4] = 5;

            // 다차원 배열
            int[,] ArrayTest4 = new int[2, 4] { { 1, 2, 3, 4 }, { 10, 20, 30, 40 } };
        }
        private void ArrayClassTest()
        {
            int[] itest = { 10, 20, 30, 40, 50 };

            int i = itest.Length;
            // 배열에서 일부분 삭제 2번째부터 2개
            Array.Clear(itest, 2, 2);

            // 배열의 크기를 변경
            Array.Resize(ref itest, 10);

            // 배열에서 해당 값이 몇번째에 있는지 찾는 것
            int iSearch50 = Array.IndexOf(itest, 50);
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            int[] iTest = { 10, 5, 30, 4, 15, 22, 18 };
            lbArrayCount.Text = string.Format("전체 자료 수 : {0}", iTest.Length.ToString());

            dgvDay["colDay1", 0].Value = iTest[0];
            dgvDay["colDay2", 0].Value = iTest[1];
            dgvDay["colDay3", 0].Value = iTest[2];
            dgvDay["colDay4", 0].Value = iTest[3];
            dgvDay["colDay5", 0].Value = iTest[4];
            dgvDay["colDay6", 0].Value = iTest[5];
            dgvDay["colDay7", 0].Value = iTest[6];
        }

        private void btn_2Week_Click(object sender, EventArgs e)
        {
            dgvDay.Rows.Clear();

            int[,] iTest = { { 10, 5, 30, 4, 15, 22, 18 }, { 11, 15, 25, 14, 7, 5, 25 } };

            dgvDay.Rows.Add();

            dgvDay["colDay1", 0].Value = iTest[0, 0];
            dgvDay["colDay2", 0].Value = iTest[0, 1];
            dgvDay["colDay3", 0].Value = iTest[0, 2];
            dgvDay["colDay4", 0].Value = iTest[0, 3];
            dgvDay["colDay5", 0].Value = iTest[0, 4];
            dgvDay["colDay6", 0].Value = iTest[0, 5];
            dgvDay["colDay7", 0].Value = iTest[0, 6];

            dgvDay["colDay1", 1].Value = iTest[1, 0];
            dgvDay["colDay2", 1].Value = iTest[1, 1];
            dgvDay["colDay3", 1].Value = iTest[1, 2];
            dgvDay["colDay4", 1].Value = iTest[1, 3];
            dgvDay["colDay5", 1].Value = iTest[1, 4];
            dgvDay["colDay6", 1].Value = iTest[1, 5];
            dgvDay["colDay7", 1].Value = iTest[1, 6];
        }
    }
}
