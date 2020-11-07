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
    // 주석
    // 코드의 가독성을 높임
    // 이전 코드를 남겨 놓음으로 변경 사유나 위치를 확인 가능
    // 임시로 코드를 막음으로 프로그램의 진행 상황 등을 파악
    // /// 세개를 사용하면 메소드에 대한 설명을 넣을 수 있다.
    public partial class fmComment : Form
    {
        public fmComment()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 이 함수가 뭐하는건지 설명 해놓으면 나중에 이 함수 위에 마우스 오버시 설명이 나옴.
        /// </summary>
        /// <param name="strName">인자에 대한 설명</param>
        /// <param name="strDay">인자에 대한 설명</param>
        /// <param name="strTime">인자에 대한 설명</param>
        /// <returns></returns>
        private string TextLoad(string strName, string strDay, string strTime)
        {
            string strText = String.Format("{0}(이)와 {1}(요일) {2}에 보기로 했습니다.", strName, strDay, strTime);
            return strText;
        }
    }
}
