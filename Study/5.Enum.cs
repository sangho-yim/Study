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
    // Enum
    // 미리 정해놓은 값들 중 하나의 값만 가질 수 있는 변수를 선언
    // 프로그램 개발에서 실수를 줄이고 가독성을 높임
    // 0부터 순차적으로 값이 부여되나 명시적으로 설정 가능

    public partial class fm_Enum : Form
    {
        public fm_Enum()
        {
            InitializeComponent();
        }
        private enum enumDay
        {
            Monday,     // 0
            Tuesday,    // 1
            Wednesday,  // 2
            Thursday,   // 3
            Friday,     // 4
            Saturday,   // 5
            Sunday,     // 6
        }

        private enum enumTime
        {
            Morning,
            afternoon,
            Evening,
        }

        private void fm_Enum_Load(object sender, EventArgs e)
        {
            lbox_Day.Items.Add(enumDay.Monday.ToString());
            lbox_Day.Items.Add(enumDay.Tuesday);
            lbox_Day.Items.Add(enumDay.Wednesday);
            lbox_Day.Items.Add(enumDay.Thursday);
            lbox_Day.Items.Add(enumDay.Friday);
            lbox_Day.Items.Add(enumDay.Saturday);
            lbox_Day.Items.Add(enumDay.Sunday);

            lbox_Time.Items.Add(enumTime.Morning);
            lbox_Time.Items.Add(enumTime.afternoon);
            lbox_Time.Items.Add(enumTime.Evening);
        }

        private void btn_Result_Click(object sender, EventArgs e)
        {
            // 안좋은 방법: 그냥 더하기로 나열
            string strResult = tbox_Name.Text + "(이)와 " + lbox_Day.SelectedItem.ToString() + "(요일) " + lbox_Time.SelectedItem.ToString() + "에 보기로 했습니다";
            tbox_Result.Text = strResult;
        }

        private void btn_ResultStringFormat_Click(object sender, EventArgs e)
        {
            // 좋은 방법: 스트링포맷 활용
            string strResult = String.Format("{0}(이)와 {1}(요일) {2}에 보기로 했습니다.", tbox_Name.Text, lbox_Day.SelectedItem.ToString(), lbox_Time.SelectedItem.ToString());
            tbox_Result.Text = strResult;
        }
    }
}
