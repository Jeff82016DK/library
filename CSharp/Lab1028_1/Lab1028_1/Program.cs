
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab1028_1
{
    internal class Program
    {

        // C#: 1.確認在class裡面 2.(回傳)資料型態 名稱(){}

        // 1. 練習使用 Visual C# 6.0之後的字串插補 $""
        static void p1() {
            // 1. 練習使用 Visual C# 6.0之後的字串插補 $""
            //     * 新增字串變數存放 春節、清明節、勞動節、端午節、中秋節、國慶日
            //     * 在字串中顯示字串變數
            string holiday = "春節、清明節、勞動節、端午節、中秋節、國慶日";
            Console.WriteLine($"國定假日有{holiday}");
        }
        // 2.透過格式化的輸出，設定成績只需要輸出至小數第一位
        static void p2() {
           // 2.透過格式化的輸出，設定成績只需要輸出至小數第一位
            //    輸出結果 === > 國文成績：80.6、數學成績：76.5
            //    格式化：https://docs.microsoft.com/zh-tw/dotnet/csharp/language-reference/keywords/formatting-numeric-results-table
            // 	
            double chinese = 80.56;
            double math = 76.54;

            Console.WriteLine($"國文成績：{chinese:F1}、數學成績:{math:F1} ");
            Console.WriteLine(string.Format("國文成績：{0:F1}、數學成績：{1:F1}", chinese, math));
            // 2-1 試著用Visual C# 6.0之前的 string.format
            // 2-2 試著用Visual C# 6.0之後的 $""
        }

        // 3. 將輸入的數值從台斤轉換為公斤
        static void p3() {
            // 3. 將輸入的數值從台斤轉換為公斤
            //    * 一台斤等於0.6公斤

            Console.Write("請輸入數值(台斤):");
            string temp = Console.ReadLine();
            Console.WriteLine($"{temp}台斤等於"+Convert.ToInt32(temp) * 0.6 + "公斤");

        }

        static void Main(string[] args)
        {

            //p3();
            //double a = 123.12;
            // Console.WriteLine(a.GetType());
            // p1();
            // p2();


            // 45. 格式化
            //double result = 12346.488;
            //Console.WriteLine($" C格式化 {result:C} "); //NT$12,346.49 開頭增加NT$(根據地區),他的預設是小數點第二位數,每三位數會給一個逗號
            //Console.WriteLine($" C格式化 {result:C0} "); // C0 => 小數點第0位  NT$12,346
            //Console.WriteLine($" C格式化 {result:C1} "); // C0 => 小數點第1位  NT$12,346.5
            //Console.WriteLine($" C格式化 {result:C2} "); // C0 => 小數點第2位  NT$12,346.49

            //Console.WriteLine($" F格式化 {result:F} "); // 12346.49 
            //Console.WriteLine($" F格式化 {result:F0} "); // 12346
            //Console.WriteLine($" F格式化 {result:F1} "); // 12346.5
            //Console.WriteLine($" F格式化 {result:F2} "); // 12346.49
            //Console.WriteLine($" F格式化 {result:F3} "); // 12346.488




            // 40. 小數點 + 運算後的小數點

            //int apple = 1 / 3;
            //Console.WriteLine(apple); // 0

            //double bee = 1 / 3;
            //Console.WriteLine(bee); // 0

            //double cat = 1.0 / 3.0;
            //Console.WriteLine(cat); // 0.333333333333333

            // 35. 數字最大
            //int min = int.MinValue;
            //int max = int.MaxValue;
            //Console.WriteLine(min.ToString()); // -2147483648
            //Console.WriteLine(max.ToString()); //2147483647
            //Console.WriteLine($"int可以處理的範圍{min}到{max}");

            //Console.WriteLine(max + 1); // -2147483648
            //Console.WriteLine(max + 2); // -2147483647
            //Console.WriteLine(max + 3); // -2147483646
            //Console.WriteLine(max + 4); // -2147483645




            // 30. 四則運算
            //int a = 10;
            //int b = 11;
            //int c = 4;
            //int d = (a + b) / c; //
            //int e = (a + b) % c; //
            //Console.WriteLine(d); // 5 int 是整數 四則運算只會顯示整數不會有小數點
            //Console.WriteLine(e); // 1


            // 28. 關於 宣告數字
            //int n1 = 123;
            //short n2 = 123;
            //long n3 = 111;
            //Console.WriteLine(n1.GetType()); // System Int32
            //Console.WriteLine(n2.GetType()); // System Int16
            //Console.WriteLine(n3.GetType()); // System Int64

            // 25. 關於 宣告字串
            //string strX = "apple";
            //String strY = "apple";
            //System.String strZ = "apple";

            //Console.WriteLine(strX.GetType());
            //Console.WriteLine(strY.GetType());
            //Console.WriteLine(strZ.GetType());

            //// 20. 關於字串
            //string apple = "皮卡丘";
            //string bee = "胖丁";
            //Console.WriteLine("哈囉" + apple + "你好"); // 哈囉 皮卡丘 你好
            //Console.WriteLine(   string.Format("你好{0},你好{1}", apple , bee)  );
            //Console.WriteLine("你好{0},你好{0}", apple , bee);
            //Console.WriteLine($"你好{bee},你好{bee}");

            //// 10.關於console
            //Console.WriteLine("ok");
            //Console.BackgroundColor = ConsoleColor.Gray;
            //Console.ForegroundColor = ConsoleColor.Red;
            ////重置系統的顏色
            //Console.ResetColor();
            ////單純清除內容
            //Console.Clear();
        }
    }
}
