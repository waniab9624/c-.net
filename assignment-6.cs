using System;

namespace inheretance
{
    class student
    {
        public void info()
        {
            String name = "abhay";
            String Class = "SYBCA";
            Console.WriteLine("student name :-" + name);
            Console.WriteLine("Class :-" + Class);
        }
    }
    interface exam
    {
        void mak();

    }
    class result : student, exam
    {
        public void mak()
        {
            String subject = "c#.net";
            int marks = 28;
            Console.WriteLine("subject:-" + subject);
            Console.WriteLine("marks :-" + marks);
        }
        static void Main(string[] args)
        {
            result obj = new result();
            obj.info();
            obj.mak();
            Console.ReadLine();
        }
    }
}


