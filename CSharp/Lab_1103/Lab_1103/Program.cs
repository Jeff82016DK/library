using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1103
{
    internal class Program
    {
        // 27.宣告一個陣列，使用迴圈放入數值1-10，再使陣列內容反轉印出 
        static void p27()
        {
            // 27.宣告一個陣列，使用迴圈放入數值1-10，再使陣列內容反轉印出 
            //    (不使用Array.Reverse())
            int[] numer = new int[10];

            //=======陣列======
            for (int i = 0; i < numer.Length; i++)
            {
                numer[i] = i + 1;
                Console.WriteLine($"陣列內容:{i} ={numer[i]}");
            }

            //======反轉======
            for (int k = numer.Length - 1; k >= 0; k--)
            {
                Console.WriteLine(numer[k]);
            }

        }
        // 28.設計陣列：前兩項為 1、1，之後的每一項為前兩項之和
        static void p28()
        {
            // 28.設計陣列：前兩項為 1、1，之後的每一項為前兩項之和
            //    * 有人稱呼這樣的陣列為 費式數列
            //    * Ans: 前10項為：1、1、2、3、5、8、13、21、34、55 
            //    (輸出請參考圖片 90_費式數列.png)
            //    * 找出剛剛討論的規則，部分使用for，部分無法
            Console.Write("請輸入陣列的數量:");
            int cnt = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[cnt];

            //找出剛剛討論的規則
            //部分無法=>陣列的前兩項
            ar[0] = 1;
            ar[1] = 1;

            for (int i = 2; i < ar.Length; i++)
            {
                ar[i] = ar[i - 1] + ar[i - 2];
                //ar[3] = ar[2] + ar[1];
                //ar[4] = ar[3] + ar[2];
                Console.WriteLine($"ar[{i}] = ar[{i - 1}] + ar[{i - 2}]=={ar[i]}");

            }
        }
        // 29. 猜數字
        static void p29()
        {
            // 1.有一個4位數亂數，數字裡面不會重複
            // 2.要讓使用者輸入 幾次? 不知道 while()
            // 3.使用者輸入之後要判斷
            //  a. (答案)跟使用者的輸入相同
            //  b. 數字一樣 => A字串裡有沒有B字串 => indexof
            //  c. 位置一樣 => 陣列
            //  d. 做了4*4次比較的動作 => for

            Random random = new Random();
            int ans = random.Next(1000, 10000);
            //Console.WriteLine(ans);
            int a = ans / 1000; // 千位數字
            //Console.WriteLine(a);
            int b = (ans / 100) % 10; // 百位數字
            //Console.WriteLine(b);
            int c = (ans / 10) % 10; // 十位數字
            //Console.WriteLine(c);
            int d = ans % 10; // 個位數字
                              //Console.WriteLine(d);

            while (a == b || a == c || a == d || b == c || b == d || c == d)
            {

                ans = random.Next(1000, 10000);
                a = ans / 1000; // 千位數字
                b = (ans / 100) % 10; // 百位數字
                c = (ans / 10) % 10; // 十位數字
                d = ans % 10; // 個位數字
                //Console.WriteLine("ok");

            }

            Console.WriteLine($"遊戲答案{ans}");
            int x = 0;

            string[] arr = new string[4];
            arr[0] = $"{a}";
            arr[1] = $"{b}";
            arr[2] = $"{c}";
            arr[3] = $"{d}";
            //Console.WriteLine($"{String.Join("", arr)}");
            Console.Write("遊戲開始，請輸入0~9的數字");

            int na = 0;
            int nb = 0;
            while (x != ans)
            {
                x = Convert.ToInt32(Console.ReadLine());
                int xa = x / 1000; // 千位數字
                int xb = (x / 100) % 10; // 百位數字
                int xc = (x / 10) % 10; // 十位數字
                int xd = x % 10; // 個位數字

                string[] xrr = new string[4];
                xrr[0] = $"{xa}";
                xrr[1] = $"{xb}";
                xrr[2] = $"{xc}";
                xrr[3] = $"{xd}";
                //Console.WriteLine(xrr[0]);
                //Console.WriteLine(arr[0]);
                //Console.WriteLine(xrr[2]);
                //Console.WriteLine(xrr[3]);

                //Console.WriteLine($"{String.Join("", xrr)}");
                //Console.WriteLine($"{String.Join("", arr)}");

                if (string.Join("", xrr) == string.Join("", arr))
                {
                    Console.WriteLine("恭喜答對");

                }
                else if (xa == xb || xa == xc || xa == xd || xb == xc || xb == xd || xc == xd)
                {
                    Console.WriteLine("輸入錯誤，遊戲結束");
                    break;
                }
                else
                {

                    for (int i = 0; i < 4; i++)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (arr[i] == xrr[k] && i == k)
                            {
                                na++;
                            }
                            else if (arr[i] == xrr[k] && i != k)
                            {
                                nb++;
                            }

                        }
                    }
                    Console.WriteLine($"{na}A, {nb}B");
                    Console.Write("遊戲開始，請輸入0~9的數字");
                    na = nb = 0;
                }




            }



            // 2.猜中數字，數字位置是正確位置為A，猜中數字，數字位置是錯的為B
            // 3.需要使用while 、 if(判斷位置)
            // 4.要抓取每個位置的數字
        }
        static void p30()
        {

        }
        static void Main(string[] args)
        {
            p29();
            // 30. 不規則的陣列
            //  ex. 18樓有五間教室,每一間教室有N學生..  想要存姓名
            //string[][] student = new string[5][];
            //student[0] = new string[24]; // 假設1801 座位數24人
            //student[1] = new string[30]; // 假設1082 座位數30人

            ////1801 教室裡面第三個座位想要排皮卡丘
            //student[0][2] = "皮卡丘";
            //Console.WriteLine(student[0][2]);

            //// 28. N維陣列
            //int[,,] dog = new int[2, 5, 9];
            //Console.WriteLine(dog.Length); // 10 => 項目"總"數
            //Console.WriteLine(dog.GetLength(0)); // 2 =>指定維度 之 項目數目 看列數
            //Console.WriteLine(dog.GetLength(1)); // 5 =>指定維度 之 項目數目 看欄數
            //Console.WriteLine(dog.Rank); // 2 => 陣列維度數目

            // 25. 二維陣列

            //int[,] bee = { { 11, 22, 33, 44, 55 }, { 66, 77, 88, 99, 100 } };
            //Console.WriteLine(bee[0, 4]); // 55 => 單純的討論取直怎麼取
            //Console.WriteLine(bee.Length); // 10 => 項目"總"數
            //Console.WriteLine(bee.GetLength(0)); // 2 =>指定維度 之 項目數目 看列數
            //Console.WriteLine(bee.GetLength(1)); // 5 =>指定維度 之 項目數目 看欄數
            //Console.WriteLine(bee.Rank); // 2 => 陣列維度數目


            // 20. 二維陣列 => 棋盤 => [列,欄]
            //int[,] apple = new int[2, 5];
            //apple[0, 0] = 90;
            //apple[0, 1] = 20;
            //apple[1, 0] = 55;

            //// GetLength() 計算維度的起始點使用，裡面是以0為第一個維度

            //for (int row = 0; row < apple.GetLength(0); row++)
            //{
            //    for (int col = 0; col < apple.GetLength(1); col++)
            //    {
            //        Console.WriteLine(apple[row,col]);
            //    }
            //}

            //foreach (int item in apple)
            //{
            //    //沒資料給了0, 一列讀完之後再讀下一列
            //    Console.WriteLine(item);
            //}


            //// 15. "數字"陣列的方法
            ////      最大  最小  排序
            //int[] apple = {3,65,7,10,55,22 };
            //int min = apple.Min(); //
            //int max = apple.Max(); //
            //Console.WriteLine($"{min},{max}");

            ////----- 排序不再變數身上
            ////    int a = apple.sort(); (x) 此路不通。 => Array.sort()
            //// string b = apple.join(); (x) 此路不通。 => String.join()

            //Console.WriteLine($"排序前:{String.Join(",",apple)}");
            //Array.Sort(apple); // 小到大
            //Console.WriteLine($"排序後:{String.Join(",", apple)}");
            //Array.Reverse(apple); // 反轉(不等於) 大到小
            //Console.WriteLine($"反轉後:{String.Join(",", apple)}");


            // 12.   foreach      vs        for         vs      while      vs       do while
            //     (每一個都看)       (可以指定範圍)       (執行次數未知)         (先做才判斷)
            //string[] temp = {"a","b","c","d" };
            //Console.WriteLine(temp); // System.String[]
            //Console.WriteLine(string.Join(",",temp)); // System.String[]

            //for (int i = 0; i < temp.Length; i++)
            //{
            //    Console.WriteLine(temp[i]);

            //}

            // C# 之var 可變動: 集合是甚麼類型，拿出來就是甚麼類型
            //foreach (var item in temp)
            //{
            //    Console.WriteLine(item);
            //}

            //// 10. 陣列的宣告 + 給值
            //string[] apple = { "皮卡丘","胖丁" };
            //string[] bee = new string[] { "蘋果","鳳梨"};
            //string[] cat = new string[3];
            //cat[0] = "狗狗";

            //Console.WriteLine(cat);
            //Console.WriteLine(cat[0]);
        }
    }
}
