namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TASK8();
        }


        static void TASK2()
        {
            Console.WriteLine("Proqrama xosh gelmisiniz");
        l2:

            int a = ReadInt32("a: ");

            if (a >= 100 && a < 1000)
            {
                a = a * 1000 + a;
                Console.WriteLine(a);

            }
            else
            {
                Console.WriteLine("eded duzgun araliqda deyil");
                goto l2;
            }



        }

        static void TASK3()
        {
            Console.WriteLine("Ededi daxil edin");
        l2:

            double a = ReadInt32("a: ");

            if (a >= 10000 && a < 100000)
            {
                a = a * 18 / 100;
                a = a * 3 / 100;
                Console.WriteLine(a);

            }
            else
            {
                Console.WriteLine("eded duzgun araliqda deyil");
                goto l2;
            }



        }

        static void TASK4()
        {
            Console.WriteLine("Ededi daxil edin");
        l2:

            double a = ReadInt32("a: ");

            if (a >= 100 && a < 1000)
            {
                a = a * 10 + 7;
                a = a * 7 / 100;

                Console.WriteLine(a);

            }
            else
            {
                Console.WriteLine("eded duzgun araliqda deyil");
                goto l2;
            }



        }

        static void TASK5()
        {
            Console.WriteLine("Ededi daxil edin");
        l2:

            double a = ReadInt32("a: ");

            if (a >= 1000 && a < 10000)
            {
                a = (40000 + a) * 100 + 44;
                a = a * 44 / 100;

                Console.WriteLine(a);

            }
            else
            {
                Console.WriteLine("eded duzgun araliqda deyil");
                goto l2;
            }


        }

        static void TASK6()
        {
            Console.WriteLine("Ededi daxil edin");
        l2:

            double a = ReadInt32("a: ");

            if (a >= 1000 && a < 10000)
            {

                a = a * 20 / 100;
                a = a * 10 / 100;
                a = a * a;

                Console.WriteLine(a);

            }
            else
            {
                Console.WriteLine("eded duzgun araliqda deyil");
                goto l2;
            }


        }

        static void TASK7()
        {
            Console.WriteLine("Ededleri daxil edin");
        l2:

            double a = ReadInt32("a: ");
            double b = ReadInt32("b: ");
            double c;


            if (a >= 10000 && a < 100000 && b >= 10000 && b < 100000)
            {
                if (a + b >= 10000 && a + b < 100000)
                {

                    c = (500000 + a + b) * 10 + 5;
                    c = c * 5 / 100;
                }
                else
                {
                    c = (5000000 + a + b) * 10 + 5;
                    c = c * 5 / 100;
                }


                Console.WriteLine(c);

            }
            else
            {
                Console.WriteLine("duzgun araliqda ededler daxil edin");
                goto l2;
            }


        }

        static void TASK8()
        {
            Console.WriteLine("Ededleri daxil edin");
        l2:

            double a = ReadInt32("a: ");
            double b = ReadInt32("b: ");
            double c;


            if (a >= 1000 && a < 10000 && b >= 1000000 && b < 10000000)
            {
                a = a * 4 / 100;
                b = b * 9 / 100;
                c = (a + b) * 10 / 100;

                Console.WriteLine(c);

            }
            else
            {
                Console.WriteLine("duzgun araliqda ededler daxil edin");
                goto l2;
            }
        }






        static int ReadInt32(string caption)
        {
            int a;
        l1: Console.Write(caption);
            if (int.TryParse(Console.ReadLine(), out a) == false)
            {
                Console.WriteLine("eded daxil edin");
                goto l1;
            }
            return a;

        }
    }


}


