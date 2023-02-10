using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1102_v2
{
    internal class Program
    {
        static void p1()
        {
            //1.亂數 => C#
            Random random = new Random();
            int ans = random.Next(1, 100);
            int left = 1;
            int right = 100;
            Console.WriteLine("============ 教學版 ===========");
            Console.WriteLine($"答案為 : {ans}");
            Console.WriteLine($"開始遊戲，請輸入{left} ~ {right} 之間的數字");
            Console.WriteLine("-----------------------------------");

            // a. 反覆地讓使用者輸入 數字 => 迴圈 => while
            //      輸入(??)的不是答案(ans)的時候
            // b. 再輸入之後要判斷使用者輸入的數字
            // c. 判斷如果 (輸入的值 小於 密碼) 的時候 左邊界要改變
            // d. 判斷如果 (輸入的值 大於 密碼) 的時候 右邊界要改變
            // e. 判斷如果使用者輸入跟密碼一樣就猜對了

            Console.Write("請輸入數值");
            int x = 0;
            int i = 0;
            while (x != ans)
            {
                x = Convert.ToInt32(Console.ReadLine());
                
                if (x == ans)
                {
                    Console.WriteLine("恭喜答對了");
                    i++;
                    Console.WriteLine($"你猜了{i}次");

                }
                else if (x < left || x > right)
                {
                    Console.WriteLine("超出數值囉，請重新輸入數值");
                    Console.Write("請輸入數值");

                }
                else if (x < ans)
                {

                    left = x;
                    Console.WriteLine($"密碼介於{left} ~ {right} 之間的數字");
                    Console.Write("請輸入數值");

                }
                else if (x > ans)
                {
                    right = x;
                    Console.WriteLine($"密碼介於{left} ~ {right} 之間的數字");
                    Console.Write("請輸入數值");

                }
                i++;
          
            }





            //2.輸入 read
            //3.迴圈 => while
            //4. if *4
            //5.變數 * ? (紀錄有幾次)
        }
        static void Main(string[] args)
        {
            p1();
        }
    }
}
