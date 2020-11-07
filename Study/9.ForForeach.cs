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
    // 반복문 (for, Foreach)
    /* 목적
     * a. 횟수나 배열의 크기만큼 반복을 수행 하려고 할 때 사용
     * b. for문: 반복에 필요한 변수의 선언 및 초기화, 조건식, 변수의 증감 등의 조건으로 반복을 수행
     * c. foreach문: 배열의 크기에서 값을 하나씩 가져오면서 반복을 수행
     * 
     * for)
     * 초기화 된 값부터 시작해서 횟수에 따라 증감조건에 따라 값을 증감하며
     * 결과값이 조건을 만족하지 않으면 종료
     * for (변수선언 및 초기화; 반복조건; 증감조건)
     * for (int i = 0; i<10; i++)
     * {
     *  반복 시 수행 할 내용
     * }
     * 
     * foreach)
     * 배열에서 값을 하나씩 가져와서 반복을 수행 (배열의 크기만큼 반복)
     * foreach (배열에서 가져온 값 in 배열)
     * foreach (var item in collection)
     * {
     *  반복 시 수행 할 내용
     * }
     */
    public partial class fmForForeach : Form
    {
        public fmForForeach()
        {
            InitializeComponent();
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            tbResult.Text = string.Empty;

            StringBuilder sb = new StringBuilder();

            int iResult = 0;

            // 포문
            //for (int i = 1; i < 11; i++)
            //{
            //    iResult = iResult + i;
            //    sb.Append(string.Format("1에서 {0}까지 더하면 {1} 입니다. \r\n", i, iResult));
            //}

            // 이중포문
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    sb.Append(string.Format("{0}회차 {1}스테이지 진행 중.... \r\n", i, j));
                }
            }
            tbResult.Text = sb.ToString();
        }
        private void btnforeach_Click(object sender, EventArgs e)
        {
            tbResult.Text = string.Empty;
            StringBuilder sb = new StringBuilder();

            string[] strArray = { "나연", "정연", "모모", "사나", "지효", "미나", "다현", "쯔위", "채영" };

            int i = 1;

            foreach (var item in strArray)
            {
                sb.Append(string.Format("{0} 선생님은 {1}반 입니다. \r\n", item, i++));
            }
            tbResult.Text = sb.ToString();
        }
    }
}
