using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1101
{
    internal class Program
    {

        // 9.依照員工的年資計算獎金 if用法
        static void p9()
        {
            // 【使用 if 寫一次 和 使用 switch 寫一次 】
            // 9.依照員工的年資計算獎金        
            //    條件達一年未滿三年，獎金一個月、達三年未滿六年，獎金三個月，超過六年，發放獎金五個月
            //     (輸出請參考圖片 10_獎金試算.png) 

            Console.Write("請輸入員工在職年數:");
            int con = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入月薪:");
            int pay = Convert.ToInt32(Console.ReadLine());

            if (con < 3)
            {
                Console.WriteLine($"此員工在職有{con}年,獎金{pay}");
            }
            else if (con >= 3 && con < 6)
            {
                Console.WriteLine($"此員工在職有{con}年,獎金{3 * pay}");
            }
            else if (con >= 6)
            {
                Console.WriteLine($"此員工在職有{con}年,獎金{5 * pay}");
            }
        }
        // 9.依照員工的年資計算獎金 switch用法
        static void p9_1()
        {
            Console.Write("請輸入員工在職年資:");
            int con = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入月薪:");
            int pay = Convert.ToInt32(Console.ReadLine());


            switch (con)
            {
                case int n when (n < 3):
                    Console.WriteLine($"此員工在職有{con}年,獎金{pay}");
                    break;
                case int n when (n >= 3 && n < 6):
                    Console.WriteLine($"此員工在職有{con}年,獎金{3 * pay}");
                    break;
                default:
                    Console.WriteLine($"此員工在職有{con}年,獎金{5 * pay}");
                    break;


            }
        }
        // 21.計算出 1 + 3 + 5.. + 99 的總和 (輸出請參考圖片 20_加總_1_to_N.png)
        static void p21()
        {
            // 21.計算出 1 + 3 + 5.. + 99 的總和 (輸出請參考圖片 20_加總_1_to_N.png)
            int total = 0;
            string result = "";
            for (int i = 1; i <= 99; i = i + 2)
            {
                total = total + i;
                result += i + " + ";
                //Console.Write(i + "+");

            }
            //Console.WriteLine(result.TrimEnd('+') + "=" + total);
            //Console.WriteLine(result.Substring(0, result.Length-3) + "=" + total);
            //Console.WriteLine(result.Remove(result.Length - 2) + "=" + total);
            //Console.WriteLine(result + result.LastIndexOf(' ',' ') + "=" + total);

        }
        static void p21_if()
        {
            int total = 0;
            for (int i = 1; i <= 99; i += 2)
            {
                // 計算總金額
                total = total + i;

                // a. 如果i是99的話，不要串接+
                // b. 如果i是99的話，要輸出i就好了

                // 如果i不是99的話，就可以串接+
                if (i == 99)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i + " + ");
                }
            }
            // 最後顯示總total
            Console.Write(" = " + total);
        }
        // 22.計算出 1 * 2 * ... * n  的總和 (輸出請參考圖片 30_N階.png)        
        static void p22()
        {
            Console.Write("請輸入一個數字:");
            int var = Convert.ToInt32(Console.ReadLine());
            string result = "";
            int totle = 1;
            for (int i = 1; i <= var; i++)
            {
                totle = totle * i;
                result += i + "*";
                //Console.Write(result);
            }
            Console.WriteLine(result.Remove(result.Length - 1) + "=" + totle);
        }
        // 23.輸出九九乘法表                 (輸出請參考圖片 40_九九乘法表.png)  
        static void p23()
        {
            // Y方向 
            for (int i = 1; i < 10; i++)
            {
                // X方向的  ->
                for (int j = 2; j < 10; j++)
                {
                    string pos = Convert.ToString(i * j).PadLeft(2, ' ');
                    Console.Write($"{j}*{i}={pos}" + "\t");
                }
                Console.Write("\n");
            }
        }
        // 23_1.聖誕樹
        static void p23_1()
        {
            //列: 使用者輸入有幾列就幾列
            //欄: 使用者輸入的列 * 2 - 1
            //小樹的中間: 使用者輸入 - 1
            //ａ．中間值的正負 ３－？　　３＋？
            //ｂ．最大列－該列 ４－０　＝　４　（Ｘ）
            //--
            //什麼時候畫＃，什麼時候畫＊
            //第０列的時候 ０－２＃　４－６＃　＝＞　３－０　３＋０
            //第１列的時候 ０－１＃　５－６＃　＝＞　３－１　３＋１
            //第２列的時候 ０＃　　　　　６＃　＝＞　３－２　３＋２
            //--
            //輸入2的時候有3欄
            //輸入3的時候有5欄
            //輸入4的時候有7欄
            //輸入5的時候有9欄

            //會先執行列再執行欄

            //列: 使用者輸入有幾列就幾列
            Console.Write("請輸入一個數字:");
            int row = Convert.ToInt32(Console.ReadLine());

            //欄: 使用者輸入的列 * 2 - 1
            int col = row * 2 - 1;

            //小樹的中間: 使用者輸入 - 1
            int center = row - 1;


            for (int i = 0; i < row; i++)
            {

                for (int j = 0; j < col; j++)
                {
                    //中間值的正負 => 中間值+-列
                    //pos 小於 中間值+-列 && pos 大於 中間值+-列
                    //pos 小於 中間值+-列 || pos 大於 中間值+-列
                    if (j < center - i || center + i < j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");

            }
        }
        // 23_2.求質數
        static void p23_2()
        {
            //質數:  
            //1.只能被自己整除
            
            Console.Write("輸入最大範圍");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] ar =new int[1000000];
            int y = 0;
            for (int i = 2; i <= x; i++)
            {
                for (int k = 2; k <= i; k+=3)
                {
                    //先排除 i != k
                    if (i != k && i % k == 0)
                    {
                        break;
                    }
                    if (i % k == 0 && i == k)
                    {
                        ar[i]=k;
                        Console.WriteLine(ar[i]);
                    }
                    
                }
            }
        }
        static void p24()
        {
            //Console.WriteLine("===【先觀看底下迴圈的結果，在實際執行查看】===");
            //int a = 10, b = 20, c;

            //do
            //{
            //    c = a + b;
            //    a -= 1;
            //} while (b < 0);
            //Console.WriteLine($"A，do while() 迴圈後，c 的值為：{c}、a 的值為：{a}");

            int a = 10, b = 20, c;
            do
            {
                for (c = 1; c <= 5; c++)
                {
                    a += c;
                }
                b -= 1;
            } while (b <= 0);
            Console.WriteLine($"B，do while() 迴圈後，a 的值為：{a}、b 的值為：{b}、c 的值為{c}");

            //int a = 10, b = 10, c = 10;
            //while (c >= 0)
            //{
            //    a = a + b;
            //    c = c - 1;
            //}

            //Console.WriteLine($"C，while() 迴圈後，a 的值為：{a}、c 的值為：{c}");
        }

        // 【使用 while + 四則運算】
        static void p25()
        {
            // 【使用 while + 四則運算】
            // 25.讓使用者輸入一個數字，使用算出這個數字有幾位數。
            Console.Write("請輸入一個數字:");
            int x = Convert.ToInt32(Console.ReadLine());

            //    for           while
            // (指定範圍)   (一條件為主)

            int y = 10;
            int i = 0;

            while (x != 0)
            {
                //Console.WriteLine(x);
                x = x / y;
                i++;
            }
            Console.WriteLine($"此數字為{i}位數");

        }
        // 26. 判斷100 - 999之間，有那些數字符合底下公式
        static void p26()
        {
            // 【使用 while】
            // 26. 判斷100 - 999之間，有那些數字符合底下公式
            //    若三位數字abc，abc = (a * a * a) + (b * b * b) + (c * c * c)
            //    * 有人稱呼這樣的數字為 水仙花數
            //    * Ans: 153、370、371、407
            int x = 101;

            while (x < 1000)
            {
                int a = x / 100; //Console.WriteLine(x%10);// 12.3 取個位數
                int b = (x / 10) % 10; //Console.WriteLine((x/10)%10);// 1.2 取十位數
                int c = x % 10; //Console.WriteLine(x/100);// 1.2 取百位數

                double z = Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3);
                if (z == x)
                {
                    Console.WriteLine(x);

                };
                x++;

            }


        }
        static void Main(string[] args)
        {
            p23_2();
            //// for(;; 遞增||遞減)
            //for (int cat = 10; cat > 0; cat = cat - 2)
            //{
            //    Console.Write(cat + "\t");
            //    //Console.Write(cat + "\n");
            //}

            // 30. for(宣告; 條件 ; 每一次都會跑進來執行){}   |
            //for (int apple = 0; apple < 10; apple++)
            //{
            //    // break ; 離開
            //    // return ; 離開 (X) (建議跟function搭配使用)
            //    // continue ; 跳過這一次不做
            //    if (apple % 2 == 0)
            //    {
            //        continue;
            //    }
            //    if (apple == 7)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(apple);
            //}


            //            join                 $                             @
            // CSS        (x)                 a[href$=".asp"]              @media
            // JS     array.join              "${}"                         (X)
            // SQL    left right inner        (?)                           變數
            // C#     string.join(?)          $""                         解決反斜線

            // 20. if(bool) vs switch(變數本人)

            //int apple = 1;
            //switch (apple)
            //{
            //    case 1 :
            //        Console.WriteLine("ok");
            //        break;
            //    default:
            //        break;
            //}

            //if (false)
            //    Console.WriteLine("皮卡丘");

            //    if (true)
            //     {
            //    Console.WriteLine("胖丁");
            //     }


            // 18. 字串 vs 數字
            //int x = 1;
            //int y = 2;
            //string z = "3";
            //string w = "4";
            //Console.WriteLine(x + y); // 3
            //Console.WriteLine(x + w); // "14" (O)  ||  5 (X)
            //Console.WriteLine(z + y); // "32" (O)  ||  5 (X)
            //Console.WriteLine(z + w); // "34" (O)  ||  err (X)


            // 15. 空字串 (null 就..怪怪的)
            //string a = "";
            //string b = null;
            //string c = string.Empty;

            //Console.WriteLine(a == b); // False
            //Console.WriteLine(a == c); // True
            //Console.WriteLine(b == c); // False


            // 12. 字串: 特殊符號 (反斜線 跳脫|逃逸)
            //string pikachu = "皮卡丘";

            //string path = "C:\temp";
            //string path_v1 = "C:\\temp";
            //string path_v2 = @"C:\temp";
            //string path_v3 = $@"C:\temp {pikachu}";
            //Console.WriteLine(path_v3);



            //// 10. 字串:方法
            //string temp = "  apple  bee  ";
            //Console.WriteLine(temp.ToLower()); //全部轉成小寫
            //Console.WriteLine(temp.ToUpper()); //全部轉成大寫
            //// Bootstrap 5(start end)   vs 4(left right)
            //Console.WriteLine(temp.PadLeft(20, '#')); //往左邊補指定符號
            //Console.WriteLine(temp.IndexOf("e")); //從左邊算6
            //Console.WriteLine(temp.LastIndexOf("a")); //從右邊算11
            //Console.WriteLine(temp.Substring(0, 5)); //擷取字串
        }
    }
}
