using System;

    internal class qno4
{ 
    static class StaticClassEx
    {
        static string college;
        static StaticClassEx()
        {
            college = "College Name is= Ratna RajyaLaxmi Campus";
        }

        public static void display()
        {
            Console.WriteLine(college);
        }
    }
    internal class staticex
    {
        public static void Main(string[] args)
        {
            StaticClassEx.display();
            Console.ReadKey();
        }
        
    }
}
