using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1107_v3
{
    //JS
    //學生.學生學號
    //學生.學生姓名
    //學生.學生電話
    //學生.給號機

    //C#
    //真。學生.學生學號
    //真。學生.學生姓名
    //真。學生.學生電話
    //學生.給號機
    //static 不需要 new
    //(因為在class 宣告的當下就佔有一塊記憶體空間。)

    //static 欄位|屬性|方法
    //(類別名稱.靜態欄位)
    //(類別名稱.靜態屬性)
    //(類別名稱.靜態方法)

    //非 static 欄位|屬性|方法
    //(需要 new 才可以用)
    class Student
    {
        public int StudentID;
        public string StudentName;
        public string StudentPhone;

        //----
        private static int apple = 0;

        //建構子
        public Student()

        {
            apple += 1;
            StudentID = apple;
            StudentName = "皮卡丘";
        }
        struct Student_III
        {
            public int StudentID;
            public string StudentName;
            public string StudentPhone;
            // ---
            private static int apple = 0;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Student s3 = new Student();
                s3.StudentName = "蘋果";
                Student s4 = new Student();
                s4 = s3;
                s3.StudentName = "香蕉";
                Console.WriteLine(s3.StudentName);
                Console.WriteLine(s4.StudentName);
                // --- class   value   reference
                //              (X)       (O)

                Student_III s5 = new Student_III();
                s5.StudentName = "狗";
                Student_III s6 = new Student_III();
                s6 = s5;
                s6.StudentName = "貓";
                Console.WriteLine($"s5:{s5.StudentName}");
                Console.WriteLine($"s6:{s6.StudentName}");
                //--- struct   value   reference
                //              (O)       (X)

                //Student s1 = new Student();
                //Console.WriteLine(s1.StudentID);    // 1
                //Console.WriteLine(s1.StudentName);  // 皮卡丘 
                //Console.WriteLine(s1.StudentPhone); // 空字串

                //Student s2 = new Student(); // 2 皮卡丘
                //s2.StudentName = "胖丁";
                //s2.StudentPhone = "0911222333";
                //Console.WriteLine(s2.StudentID);    // 2
                //Console.WriteLine(s2.StudentName);  // 胖丁 
                //Console.WriteLine(s2.StudentPhone); // 0911222333
            }
        }
    }
}
