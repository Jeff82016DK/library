using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1107
{
    internal class Program
    {

        static ArrayList egg()
        {
            ArrayList ar = new ArrayList();
            ar.Add(true);
            ar.Add(999);
            return ar;
        }
        //函式覺得 透過out 設計出來的 就是等一下 函式要去設定給值的地方
        //差異:
        //        out 不能直接使用            ref 可以直接使用
        //    (會假裝沒看見使用者有傳)      (拿使用者給的地址使用)
        static bool MyAdd(int x, int y, out int z)
        {
            z = x + y;
            x = 0;
            y = 0;
            return true;
        }
        static void Main(string[] args)
        {

            // 30. ref / out
            // ref 要有回傳址
            // 
            int num1 = 1;
            int num2 = 2;
            int num3;
            bool temp = MyAdd(num1, num2, out num3); // int 原本是 by value...

            Console.WriteLine(num1); // 1
            Console.WriteLine(num2); // 2
            Console.WriteLine(num3); // 3 回傳z = x + y 的值
            Console.WriteLine(temp); // true retdrun 回來的值

            //// 28. 該如何設計一個函式同時回傳兩份資料
            ////  Ans . 集合是其中一種解決方式

            //ArrayList temp = egg();
            //Console.WriteLine(temp[0]);
            //Console.WriteLine(temp[1]);

            // 25. 字串 轉 整數

            //string apple = "10.1";
            //int bee;
            //bool cat = int.TryParse(apple,out bee);
            //Console.WriteLine(bee);
            //Console.WriteLine(cat); //可以用布林值來判斷是否轉型成功


            //// 20. 浮點數 轉 數字
            //double x = 1234.7;
            //int a = (int)x;              // 明確轉型 | 強制轉型
            //int b = Convert.ToInt32(x);  // 使用協助程式類別轉換

            //Console.WriteLine(a); // 1234
            //Console.WriteLine(b); // 1235

            // 10. object.ReferenceEquals() vs object.Rquals()
            //   String.Join(符號,集合)       Array.Sort(集合)
            //         傳址(reference)   傳值(value)
            //  int                          O
            // string

            //string a = "apple";
            //string b = a; // string 看起來像是by value ，實際上他是by reference
            ////b = "bee";
            //bool cat = Object.ReferenceEquals(a, b);
            //bool dog = Object.Equals(a, b);

            //Console.WriteLine(cat); // 址: true |false
            //Console.WriteLine(dog); // 值: false
            //
            //int a = 5;
            //int b = a; // a身上有個5、b身上有個5，各自擁有

            //bool cat = Object.ReferenceEquals(a, b);
            //bool dog = Object.Equals(a, b);

            //Console.WriteLine(cat); // 址: false
            //Console.WriteLine(dog); // 值: true
        }
    }
}
