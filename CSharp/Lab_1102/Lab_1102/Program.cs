using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 15. do{打算要反覆做的事情} while{條件 布林值}
            // do while 跟 while 的差異是?
            // Ans: do while 會先做了才判斷
            //         while 先判斷才做

            //// JS
            // i++: 等一下才做(加一)
            // ++i: 現在立刻馬上做(加一)
            int apple = 5;
            do
            {
                Console.WriteLine("ok");
            } while (apple > 10);

            // 10. while(條件){}
            //int cnt = 3;
            //while (cnt > 0)
            //{
            //    Console.WriteLine($"ok-{cnt}");
            //    cnt = cnt - 1;
            //}
        }
    }
}
