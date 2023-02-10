using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab1031_1
{
    internal class Program
    {
        // 3. 將輸入的數值從台斤轉換為公斤
        static void p3()
        {
            //3.將輸入的數值從台斤轉換為公斤
            //   * 一台斤等於0.6公斤
            Console.Write("請輸入台斤:");
            string inputStr = Console.ReadLine();
            double temp = Convert.ToInt32(inputStr) * 0.6;
            Console.WriteLine($"輸入{inputStr}台斤,轉換為{temp}公斤");
        }
        // 4. 輸入兩個數值，比較大小，最後將結果顯示在畫面上
        static void p4()
        {
            Console.Write("請輸入第一個數字");
            string num1 = Console.ReadLine();
            double n1 = Convert.ToInt32(num1);
            Console.Write("請輸入第二個數字");
            string num2 = Console.ReadLine();
            double n2 = Convert.ToInt32(num2);

            if (n1 > n2)
            {
                Console.WriteLine($"{n1} >{n2} = True");
            }
            else
            {
                Console.WriteLine($"{n1} <{n2} = Flase");
            }


        }
        // 5. 讓使用者輸入兩個數字，判斷第二個數字是不是第一個數字的倍數
        static void p5()
        {
            Console.Write("請輸入第一個數字");
            string num1 = Console.ReadLine();
            double n1 = Convert.ToInt32(num1);
            Console.Write("請輸入第二個數字");
            string num2 = Console.ReadLine();
            double n2 = Convert.ToInt32(num2);

            if (n1 % n2 == 0)
            {
                Console.WriteLine($"{n1}是{n2}的倍數 = True");
            }
            else
            {
                Console.WriteLine($"{n1}不是{n2}的倍數 = Flase");
            }
        }
        static void p5_1()
        {
            Console.Write("請輸入第一個數字");
            string num1 = Console.ReadLine();
            double n1 = Convert.ToInt32(num1);
            Console.Write("請輸入第二個數字");
            string num2 = Console.ReadLine();
            double n2 = Convert.ToInt32(num2);

            string result = "";
            if (n1 % n2 == 0)
            {
                result = "是倍數";
            }
            else
            {
                result = "不是倍數";
            }
            Console.WriteLine($"{n1}不是{n2}的倍數 = {result}");
        }
        static void p5_2()
        {
            Console.Write("請輸入第一個數字");
            string num1 = Console.ReadLine();
            double n1 = Convert.ToInt32(num1);
            Console.Write("請輸入第二個數字");
            string num2 = Console.ReadLine();
            double n2 = Convert.ToInt32(num2);
            // C#   (布林值) ? 是:否    三元運算子
            string result = (n1 % n2 == 0) ? "是倍數" : "不是倍數";
            Console.WriteLine($"第一個數字為{n1}、第二個數字為{n2} ==> {result}");

        }
        //7.一件衣服399塊錢，如果消費滿1500，可以打79折
        static void p7()
        {
            //7.一件衣服399塊錢，如果消費滿1500，可以打79折
            //   (讓使用者輸入件數，顯示折扣後的金額或者提示消費者，還差多少錢就可以打折(四捨五入到整數))
            Console.Write("請輸入衣服件數:");
            double it = Convert.ToInt32(Console.ReadLine());
            int price = 399;
            int discount = 1500;
            double nt = price * it;

            if (nt >= discount)
            {
                Console.WriteLine($"總金額為{nt:c0}，超過{discount}，折扣後為{nt * 0.79:c0}");
            }
            else if (nt < discount)
            {
                Console.WriteLine($"總金額為{nt:c0}，未達{discount}，還差{1500 - nt:c0}");
            }
        }
        // 8. 輸入三個數值，判斷是否可以成為三角形，若可以，是哪一種三角形 (Math類別庫)
        static void p8()
        {
            // 8. 輸入三個數值，判斷是否可以成為三角形，若可以，是哪一種三角形 (Math類別庫)
            //  正三角：三個邊一樣長
            //    等腰：兩個邊一樣長，且不等於第三個邊
            //    直角：兩個邊的平方等於第三邊(最長邊)的平方 (3,4,5)
            //    鈍角：兩個邊的平方小於第三邊(最長邊)的平方 (3,4,6)
            //    銳角：兩個邊的平方大於第三邊(最長邊)的平方 (10,12,13)
            //    * 等腰直角三角形 的情境，這邊先不考慮
            Console.Write("請輸入三個數字，輸入完畢後按enter:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());
            int s3 = Convert.ToInt32(Console.ReadLine());

            int max = Math.Max(Math.Max(s1, s2), s3);
            int mid = Math.Min(Math.Min(Math.Max(s1, s2), Math.Max(s2, s3)), Math.Max(s1, s3));
            int min = Math.Min(Math.Min(s1, s2), s3);

            int max_v = (int)Math.Pow(max, 2);
            int min_v = (int)Math.Pow(min, 2);
            int mid_v = (int)Math.Pow(mid, 2);
            Console.WriteLine($"最大{max},中間{mid},最小{min}");

            if (s1 > 0 && s2 > 0 && s3 > 0 && s1 + s2 > s3 && s1 + s3 > s2 && s2 + s3 > s1)
            {
                if (s1 == s2 && s2 == s3 && s1 == s3)
                {
                    Console.WriteLine("正三角形");
                }
                else if (s1 == s2 || s1 == s3 || s2 == s3)
                {
                    Console.WriteLine("等腰三角形");
                }
                else if (min_v + mid_v == max_v)
                {
                    Console.WriteLine("直角三角形");
                }
                else if (min_v + mid_v < max_v)
                {
                    Console.WriteLine("鈍角三角形");
                }
                else if (min_v + mid_v > max_v)
                {
                    Console.WriteLine("銳角三角形");
                }
            }

            else
            {
                Console.WriteLine("三角形不成立");
            }


        }
        // 9.依照員工的年資計算獎金 if用法
        static void p9()
        {
            // 【使用 if 寫一次 和 使用 switch 寫一次 】
            // 9.依照員工的年資計算獎金        
            //    條件達一年未滿三年，獎金一個月、達三年未滿六年，獎金三個月，超過六年，發放獎金五個月
            //     (輸出請參考圖片 10_獎金試算.png) 

            Console.Write("請輸入員工在職年數:");
            int con = Convert.ToInt32(Console.ReadLine());

            if (con < 3)
            {
                Console.WriteLine($"此員工在職有{con}年,獎金一個月");
            }
            else if (con >= 3 && con < 6)
            {
                Console.WriteLine($"此員工在職有{con}年,獎金三個月");
            }
            else if (con >= 6)
            {
                Console.WriteLine($"此員工在職有{con}年,獎金五個月");
            }
        }
        // 9.依照員工的年資計算獎金 switch用法
        static void p9_1()
        {
            Console.Write("請輸入員工在職年數:");
            int con = Convert.ToInt32(Console.ReadLine());

            switch (con)
            {
                case int n when (n < 3):
                    Console.WriteLine($"此員工在職有{con}年,獎金一個月");
                    break;
                case int n when (n >= 3 && n < 6):
                    Console.WriteLine($"此員工在職有{con}年,獎金三個月");
                    break;
                default:
                    Console.WriteLine($"此員工在職有{con}年,獎金五個月");
                    break;
            }
        }
        static void Main(string[] args)
        {

            p5();

            //40. string
            //string temp = "  apple  bee  ";
            //Console.WriteLine(temp);
            //Console.WriteLine(temp.Length); // 14
            //Console.WriteLine(temp.Trim()); //Trim() 去掉頭尾的空格
            //Console.WriteLine(temp.Trim().Length); // 10
            //Console.WriteLine(temp.Replace("bee", "cat")); //"  apple  cat  "   Replace("舊的字串","新的字串")
            //Console.WriteLine(temp.Split(' ')); //System.String[] 系統的物件裡有陣列






            // 30. Math 類別庫
            // js Math => 亂數
            // C# Math
            // Math.Max()    Math.Min()   Math.Pow()

            // 20. if else
            // if(條件){true 的時候要做的事情} else{false 的時候要做的情}
            //         而且      或者       等於        不等於         比較          相似
            // JS:      &&        ||         ==           !=           ===            (X)
            // C#:      &&        ||         ==           !=           ===            (X)
            // SQL:     and       or         =          !=  <>         (x)            like
            //int a = 4;
            //int b = 20;
            //if (a > b)
            //{
            //    Console.WriteLine("皮卡丘");
            //}
            //else if (a > 5)
            //{
            //    Console.WriteLine("胖丁");
            //}
            //else
            //{
            //    Console.WriteLine("卡比");
            //}

            //// 11. 網路上面看到的戰爭 XD
            //float f99 = 1.2300f;
            //double d99 = 1.2300;
            //decimal dec98 = 1.23m;
            //decimal dec99 = 1.2300m;

            //Console.WriteLine(f99); // 1.23
            //Console.WriteLine(d99); // 1.23
            //Console.WriteLine(dec98); // 1.23
            //Console.WriteLine(dec99); // 1.2300

            //Console.WriteLine(dec98 == dec99); // true
            //Console.WriteLine(dec98.ToString() == dec99.ToString()); // false


            //// 10. 小數點 (浮點數)
            //double d1 = 1.0;
            //double d2 = 3.0;
            //Console.WriteLine(d1 / d2);  // 0.333333333333333

            //float f1 = 1.0f;
            //float f2 = 3.0f;
            //Console.WriteLine(f1 / f2); // 0.3333333

            //decimal dec1 = 1.0m;
            //decimal dec2 = 3.0m;
            //Console.WriteLine(dec1 / dec2); // 0.3333333333333333333333333333


        }
    }
}
