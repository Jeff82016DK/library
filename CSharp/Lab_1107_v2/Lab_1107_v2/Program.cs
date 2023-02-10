using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1107_v2
{
    //CSS  static  position => 
    //靜止 不動 石頭
    //--
    //C# static  
    //在 class 宣告的當下就佔有一塊記憶體空間。
    class Apple
    {

        // Methods(今天O), properties(屬性)(今天X), fields(欄位)(今天O) , events(今天X), delegates(今天X)
        // and nested classes go here. (今天X)
        public string StudentName = ""; // fields 欄位
        public static void SayBye()
        {
            Console.WriteLine("掰掰");

        }

        public void SayHi()
        {
            Console.WriteLine("哈囉");
        }
        class Student
        {
            private int Stuedent_ID;

            // 建構子
            public Student()
            {
                Stuedent_ID = 987;
                //Console.WriteLine("a");
            }
            // 查詢學號
            public void QueryStudentID()
            {
                Console.WriteLine(Stuedent_ID); // 987
            }

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Student s1 = new Student();
                s1.QueryStudentID();

                Student s2 = new Student();
                s2.QueryStudentID();

                s1.QueryStudentID();

                //// err. 無法以"執行個體參考"進行存取;請改用"類型名稱"
                //Add.SayBye();
                // ok.
                //Apple.SayBye();



                //Apple app = new Apple();
                //app.StudentName = "皮卡丘";
                //app.SayHi();
            }
        }
    }
}
