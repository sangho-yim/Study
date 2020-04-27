using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study
{
    // https://cwkcw.tistory.com/category/C%23/C%23%20%EA%B0%95%EC%A2%8C%20Winform
    // https://www.youtube.com/watch?v=boUIc2Y4cZo&list=PLoFFz2j8yxxxH_3ustbHATXtMsHZ-Saei

    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new fm_String());
            //Application.Run(new fm_DataType());
            //Application.Run(new fm_Method());
            //Application.Run(new fm_Operator());
            Application.Run(new fm_Enum());
        }
    }
}
