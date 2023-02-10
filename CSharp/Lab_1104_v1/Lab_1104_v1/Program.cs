using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1104_v1
{
    internal class Program
    {
        //=========AB猜數字，老師版=========
        static string GuessNumber()
        {
            //4857 => 不會重複 + 可以從零開始
            // -------- -
            //4857 => 4A 0B => 答對
            //7123 => 0A 1B => 數字對位置不對 | 有數字沒位置
            //4123 => 1A 0B => 猜對位置也對
            //0123 => 0A 0B
            //-------- -

            // 1. (答案)要有四個0 - 9不重複的數字
            //      1 - 1 產生一個字串 "0123456789"
            string temp = "0123456789";
            //      1 - 2 產生一個亂數 為了去擷取 1 - 1 中 字串的某個 位置
            Random r = new Random();
            int apple;
            string ans = "";
            for (int i = 0; i < 4; i++)
            {
                //       延伸: 亂數要限定範圍 => 範圍跟位置有關 => 推敲位置的話..0 - 9
                //      r.Next(包含最小, 不包含最大);
                //      r.Next(0, 10); => 會獲得 0-9
                //      temp.Length => 每一次取得亂數的範圍要根據字串決定
                //      temp.Length => (桶子裡面有幾個球，就還能再抽幾次)
                apple = r.Next(0, temp.Length);
                //       1 - 3 要找一個地方把擷取到的字串存放起來

                ans += temp.Substring(apple, 1);
                //      1 - 4 1 - 1 的字串必須要少一個
                //      延伸: 為什麼要少一個 => 如果沒有少掉的話那就會有重複的數那就會有重複的數字
                //      延伸: 少哪一個 => 1 - 3 被帶走的那一個
                temp = temp.Replace(temp.Substring(apple, 1), "");
            }
            Console.WriteLine($"隨機產生的亂數為{ans}");
            Console.WriteLine("======分隔線======");

            // 2.要讓使用者輸入 幾次? 不知道 while ()
            bool flag = true; //用flag 去判斷是否繼續遊戲
            int cnt = 0;
            while (flag == true)
            {
                Console.Write("請輸入答數");
                string userInput = Console.ReadLine();
                int a = 0, b = 0;
                cnt++;
                bool check = true;
                // 加入使用者輸入重複的判斷 例如:0012
                for (int p = 0; p < userInput.Length; p++)
                {
                    //取得要判斷的文字 12
                    string cat = userInput.Substring(p, 1);
                    //重複 => 出現多次 => 多次 => 多個位置 => 從左邊算跟從右邊算不同
                    if (userInput.IndexOf(cat) != userInput.LastIndexOf(cat))
                    {
                        check = false;
                        break;
                    }

                }
                if (check == false || userInput.Length != 4)
                {
                    Console.WriteLine("不能有重複的數字，字串長度有誤");
                    break;
                }
                //      2 - 1(答案)跟使用者的輸入相同 => 答對
                if (ans == userInput)
                {
                    Console.WriteLine("恭喜答對了");
                    break;
                }
                else
                {
                    //      2 - 2(答案)跟使用者的輸入不相同 => ? A ? B
                    //      假設答案 : 0123
                    //      假設輸入: 4529
                    string[] userInputArray = new string[4];
                    for (int i = 0; i < userInput.Length; i++)
                    {
                        // 2 - 2 - 1 如何判斷 A
                        //      如果答案的2跟輸入的2 數字一樣 位置一樣 的時候
                        //      => (indexof)0123裡面有沒有2
                        //      2 - 3 需要分解使用者輸入的字串變成陣列
                        //      延伸: 為什麼要分解使用者輸入的字串 ? => 因為使用者輸入的字串要一個一個跟答案比較
                        if (ans.IndexOf(userInput[i]) == i)
                        {
                            a++;
                        }
                        else if (ans.IndexOf(userInput[i]) > -1)
                        {
                            b++;
                        }


                    }
                    Console.WriteLine($"{a}A {b}B\n");
                }
                //超過輸入次數就不給玩
                if (cnt == 5 && flag == true)

                {
                    Console.WriteLine("輸入太多次，你輸囉");
                    break;
                }
            }
            Console.Write("要不要再玩一次? (Y/N)");
            return Console.ReadLine();

        }
        static void Main(string[] args)
        {
            string again;
            //版本二
            do
            {
                again = GuessNumber();

            } while (again.ToUpper() == "Y");

            //版本一
            //GuessNumber();
            //string userInput = "";
            //while (userInput != "N" && userInput != "n")
            //{
            //    Console.Write("要不要再玩一次? (Y/N)");
            //    userInput = Console.ReadLine();

            //    if (userInput == "Y" || userInput == "y")
            //    {
            //        GuessNumber();
            //    }
            //}

        }
    }
}
