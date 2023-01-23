//task1

//using System;
//using System.Security;
//namespace MyNamespace
//{
//    public class program
//    {
//        static void Main()
//        {
//            int n = Convert.ToInt32(Console.ReadLine());
//            Number(n );
//        }

//        static void Number(int n)
//        {
//            int count = 0;
//            int count1 = 0;
//            if (n % 7 == 0)
//            {
//                Console.WriteLine(n);
//            }
//            else 
//            {
//                int m = n;
//                for (int i = n; i < n + 7; i++)
//                {
//                    if (n % 7 == 0)
//                    {
//                        break;
//                    }
//                    n++;
//                    count++;
//                }
//                for (int j = m; j > m - 7; j--)
//                {
//                    if (m % 7 == 0)
//                    {
//                        break;
//                    }   
//                        count1++;
//                    m--;
//                }
//                    if (count > count1)
//                    {
//                        Console.WriteLine(m);
//                    }
//                    else
//                    {
//                        Console.WriteLine(n);   
//                    }
//            }
//        }
//    }
//}


//task2

//using System;
//using System.Security;

//namespace test
//{

//    public class Program
//    {
//        static void Main()
//        {
//            int n = Convert.ToInt32(Console.ReadLine());
//            Number(n);

//        }
//        static void Number(int n)
//        {
//            int sum = 0;
//            for (int i = 0; i <= n; i++)
//            {
//                sum = sum + i;
//            }


//            Console.WriteLine(sum);
//        }


//    }
//}



//task3

using System;
using System.Security;

namespace test
{

    public class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string word2 = Console.ReadLine();
            Lenghtofstring(word);
            Lenghtofstring2(word2);
            if (word.Length == word2.Length)
            {
                Console.WriteLine("beraberdir");
            }


            else if (word.Length > word2.Length)
            {
                Console.WriteLine(word);
            }
            else
            {
                Console.WriteLine(word2);
            }


        }
        static void Lenghtofstring(string word)
        {

        }
        static void Lenghtofstring2(string word2)
        {

        }

    }
}
