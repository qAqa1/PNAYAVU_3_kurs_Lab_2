using System;

namespace MyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString str = new MyString("длинна");

            
            MyString str2 = str.Reverse(str.Length - 5, str.Length - 2);
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }

            MyString str1 = new MyString("длинна");
            Console.WriteLine(str.Equals(str1));
            Console.WriteLine(str == str1);
            MyString str3 = new MyString('a');

            Console.WriteLine(str3.Length);
            MyString str4 = new MyString("13");
            int x = (int)str4;
            MyString str5 = x;
            Console.WriteLine("-------------------");
            for (int i = 0; i < str5.Length; i++)
            {
                Console.Write(str5[i]);
            }
            Console.WriteLine("-------------------");
            string st = str1;
            Console.WriteLine(st);
            str1 = "adad";
            str1 = str1.Remove(3);
            Console.WriteLine("-------------------");
            for (int i = 0; i < str1.Length; i++)
            {
                Console.Write(str1[i]);
            }
            Console.WriteLine("\n-------------------");
            Console.WriteLine(str1.Length);
            MyString str6 = new MyString("adad");
            Console.WriteLine(str6.Equals(str1));
            MyString str7 = 'q';
            for (int i = 0; i < str7.Length; i++)
            {
                Console.Write(str7[i]);
            }
            MyString str8 = new MyString("аабя");
            MyString str9 = new MyString("аб");
            Console.WriteLine("\n-------------------");
            Console.WriteLine(str8.MoreThen(str9));
            Console.WriteLine(str8 > str9);
            Console.WriteLine(str8 < str9);
            Console.ReadKey();
        }
    }
}