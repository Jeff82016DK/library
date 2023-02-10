using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1104_上課討論
{
    internal class Program
    {
        static void GetNumber_List()
        {
            List<int> flower = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                flower.Add(i); // 0 1 2 3 4... 9
            }

            // 亂數取得四個數字
            Random r = new Random();
            int[] ans = new int[4];
            for (int i = 0; i < 4; i++)
            {
                //// 這一段在騙人
                //ans[i] = flower[    r.Next(0, flower.Count)    ];
                //flower.RemoveAt(  r.Next(0, flower.Count)  );
                //// 這一段在騙人
                ans[i] = flower[r.Next(0, flower.Count)];
                flower.Remove(ans[i]);

            }
            Console.WriteLine(string.Join(",", flower));
            Console.WriteLine(string.Join(",", ans));
        }
        static void Main(string[] args)
        {

            /////// 比較中
            //                  資料型態    數量|長度
            // 1.         []:     固定        固定
            // 2.       List:     固定       不固定
            // 3.  ArrayList:    不固定      不固定
            //----------------------------------------
            // 4. Dictionary:     固定        不固定
            // 5.  Hashtable:    不固定       不固定
            //
            /////// 比較中
            ///

            // 30. Hashtable
            Hashtable egg = new Hashtable();
            egg.Add("杯子", "果汁");
            egg.Add(1, "卡比獸");
            egg.Add(200, 500);
            foreach (var item in egg)
            {
                Console.WriteLine(item);  //System.Collections.DictionaryEntry
            }
            foreach (DictionaryEntry item in egg)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            //// 25. Dictionary
            //Dictionary<string, string> dog = new Dictionary<string, string>();
            //dog.Add("pikachu", "皮卡丘");
            //dog.Add("cat", "貓咪大戰爭");

            //// before: 用var 自己去決定型態
            //foreach (var item in dog)
            //{
            //    Console.WriteLine(item); //顯示  [pikachu, 皮卡丘]
            //}
            //// after: 用
            //foreach (KeyValuePair<string, string> item in dog)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}"); //顯示  pikachu - 皮卡丘
            //}

            //foreach (var item in dog.Values)
            //{
            //    Console.WriteLine(item); // 顯示字典裡values的東西
            //}
            //Console.WriteLine(dog.Count); //2
            //Console.WriteLine(dog.ContainsKey("pikachu")); // true
            //Console.WriteLine(dog.ContainsValue("貓咪大戰爭")); // true





            // 23. ArrayList 陣列清單
            //ArrayList cat = new ArrayList();
            //cat.Add("皮卡丘");
            //cat.Add(500);
            //cat.Add(true);

            //Console.WriteLine(cat[0]); // 皮卡丘
            //Console.WriteLine(cat.Count); // 3
            ////Console.WriteLine(String.Join(",",cat)); // err

            //foreach (var item in cat)
            //{
            //    Console.WriteLine(item);
            //}



            // 20. List<t> => 清單 =>
            //     List<資料型別> 變數名稱 = new List<資料型別>()

            //          <t>
            //  HTML    t標籤
            //  C#      泛型 => 廣泛的型別

            // List:可以動態改變陣列內容|陣列長度    陣列:是固定內容
            //List<int> apple = new List<int>();
            //apple.Add(99);
            //apple.Add(80);
            //apple.Add(70);
            //Console.WriteLine(apple.Count); //3   Count:總數量
            //Console.WriteLine(apple[0]);// 99
            //apple[0] = 100;
            //Console.WriteLine(apple[0]);// 100
            //apple[5] = 500;
            //Console.WriteLine(apple[5]);// err 索引超出範圍，因為還沒誕生這個空間


            //int a = apple.IndexOf(80);
            //Console.WriteLine(a); // 尋找指定的資料在哪個位置
            //bool flag = apple.Remove(80); // 刪除指定的資料
            //Console.WriteLine(flag); //true : 刪除成功 /false :刪除失敗

            //apple.RemoveAt(0); // 根據"index" 刪除List項目
            //Console.WriteLine(String.Join(",", apple));

            // 10. Console.Read()  vs  Console.ReadLine()
            //         Console.Read()：從標準輸入資料流讀取下一"個"字元。
            //     Console.ReadLine()：從標準輸入資料流讀取下一"行"字元。

            //Console.Write("測試中：");
            //int a = Console.Read(); // 皮  30382 接收使用者的輸入+回傳電腦看得懂的數字
            //Console.WriteLine(a);

            //string b = Console.ReadLine(); // 接收使用者的輸入+回傳使用者看得懂的文字
            //Console.WriteLine(b);
        }
    }
}
