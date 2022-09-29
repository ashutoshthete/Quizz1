using System;
using System.Collections.Generic;
using System.Text;

namespace Quizz1
{
    class Mcqtest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter UserName : ");
            username = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("MCQ test on \n\n1. C\n2. JAVA\n3. C#");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    Csharp.Questions();
                    break;
            }
        }
        static string username;
    }
    public class Csharp
    {
        public static void Questions()
        {
            string[] csharparr = new string[10];
            csharparr[0] = "Q.1] Which of the following keyword is used to change data and behavior of a base class by replacing a member of the base class with a new derived member\n1. Overloads\n2. Overrides\n3. new\n4. base";
            csharparr[1] = "Q.2] C# is a programming language, developed by\n1. Oracle\n2. Microsoft\n3. GNU project\n4. Google";
            csharparr[2] = "Q.3] C# programming language is used to develop\n1. Web apps\n2. Desktop apps\n3. Mobiles apps\n4. All of the above";
            csharparr[3] = "Q.4] What is the extension of a C# language file\n1. .cs\n2. .c\n3. cpp\n4. .java";
            csharparr[4] = "Q.5] Who is the founder of C# programming language?\n1. Anders Hejlsberg\n2. Douglas Crockford\n3. Rasmus Lerdorf\n4. Brendan Eich";
            csharparr[5] = "Q.6] Which of the following converts a type to a string in C#?\n1. ToInt64\n2. ToSbyte\n3. ToSingle\n4. ToString";
            csharparr[6] = "Q.7]The default scope for the members of an interface is\n1. private\n2. public\n3. protected\n4. internal";
            csharparr[7] = "Q.8]The data members of a class by default are?\n1. protected\n2. public\n3. public protected\n4. private";
            csharparr[8] = "Q.9]Abstract class contains\n1. Abstract methods\n2. Non Abstract methods\n3. Both\n4. None";
            csharparr[9] = "Q.10]Reference is a\n1. Copy of class which leads to memory allocation\n2. Copy of class that is not initialized.\n3. Pre-defined data type.\n4. Copy of class creating by an existing instance.";


            int[] csharpans = new int[10];
            csharpans[0] = 3;
            csharpans[1] = 2;
            csharpans[2] = 4;
            csharpans[3] = 1;
            csharpans[4] = 1;
            csharpans[5] = 4;
            csharpans[6] = 2;
            csharpans[7] = 4;
            csharpans[8] = 3;
            csharpans[9] = 4;

            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(csharparr[i]);
                Console.WriteLine("Choose the Correct Option");
                int answer = int.Parse(Console.ReadLine());
                if (answer == csharpans[i])
                {
                    Console.WriteLine("Correct Answer");
                    count++;
                }
                else
                {
                    Console.WriteLine("Wrong Answer");

                    Console.WriteLine();
                }

            }
            Console.WriteLine($"Marks Scored is {count}/10");
            if (count >= 6)
            {
                Console.WriteLine("You have Passed the test");
            }
            else
            {
                Console.WriteLine("You have Failed");
            }

        }
    }
    public class Java
    {

    }
    public class C
    {

    }
}
