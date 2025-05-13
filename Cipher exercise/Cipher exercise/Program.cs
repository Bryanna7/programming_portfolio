using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Cipher_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string input = "";
            string Letters = "abcdefghijklmnopqrstuvwxyz";
            string substituteLetters = "opdefghiqrsxyzabcjklmntuvw";


            Console.WriteLine("Enter encoding or decoding?");

            input = Console.ReadLine();

            Console.WriteLine("");


            if (input == "encoding")
            {
                Encoding();


            }
            else if (input == "decoding")
            {
                Decoding();

            }
            else
            {
                Main(args);
            }




            static void Encoding()


            {
                Console.WriteLine("Enter a letter for substitution cipher:");

                string Answer = "";
                Answer = Console.ReadLine();





                if (Answer == "a")
                {
                    Console.WriteLine("o");
                }
                else if (Answer == "b")
                {
                    Console.WriteLine("p");
                }
                else if (Answer == "c")
                {
                    Console.WriteLine("d");
                }
                else if (Answer == "d")
                {
                    Console.WriteLine("e");
                }
                else if (Answer == "e")
                {
                    Console.WriteLine("f");
                }
                else if (Answer == "f")
                {
                    Console.WriteLine("g");
                }
                else if (Answer == "g")
                {
                    Console.WriteLine("h");
                }
                else if (Answer == "h")
                {
                    Console.WriteLine("i");
                }
                else if (Answer == "i")
                {
                    Console.WriteLine("q");
                }
                else if (Answer == "j")
                {
                    Console.WriteLine("r");
                }
                else if (Answer == "k")
                {
                    Console.WriteLine("s");
                }
                else if (Answer == "l")
                {
                    Console.WriteLine("x");
                }
                else if (Answer == "m")
                {
                    Console.WriteLine("y");
                }
                else if (Answer == "n")
                {
                    Console.WriteLine("z");
                }
                else if (Answer == "o")
                {
                    Console.WriteLine("a");
                }
                else if (Answer == "p")
                {
                    Console.WriteLine("b");
                }
                else if (Answer == "q")
                {
                    Console.WriteLine("c");
                }
                else if (Answer == "r")
                {
                    Console.WriteLine("j");
                }
                else if (Answer == "s")
                {
                    Console.WriteLine("k");
                }
                else if (Answer == "t")
                {
                    Console.WriteLine("l");
                }
                else if (Answer == "u")
                {
                    Console.WriteLine("m");
                }
                else if (Answer == "v")
                {
                    Console.WriteLine("n");
                }
                else if (Answer == "w")
                {
                    Console.WriteLine("t");
                }
                else if (Answer == "x")
                {
                    Console.WriteLine("u");
                }
                else if (Answer == "y")
                {
                    Console.WriteLine("v");
                }
                else if (Answer == "z")
                {
                    Console.WriteLine("w");
                }

                Console.ReadKey();
                Console.Clear();
                Encoding();
            }



            static void Decoding()
            {
                Console.WriteLine("Enter a letter for substitution cipher:");



                string input = "";
                input = Console.ReadLine();




                if (input == "o")
                {
                    Console.WriteLine("a");
                }
                else if (input == "p")
                {
                    Console.WriteLine("b");
                }
                else if (input == "d")
                {
                    Console.WriteLine("c");
                }
                else if (input == "e")
                {
                    Console.WriteLine("d");
                }
                else if (input == "f")
                {
                    Console.WriteLine("e");
                }
                else if (input == "g")
                {
                    Console.WriteLine("f");
                }
                else if (input == "h")
                {
                    Console.WriteLine("g");
                }
                else if (input == "i")
                {
                    Console.WriteLine("h");
                }
                else if (input == "q")
                {
                    Console.WriteLine("i");
                }
                else if (input == "r")
                {
                    Console.WriteLine("j");
                }
                else if (input == "s")
                {
                    Console.WriteLine("k");
                }
                else if (input == "x")
                {
                    Console.WriteLine("l");
                }
                else if (input == "y")
                {
                    Console.WriteLine("m");
                }
                else if (input == "z")
                {
                    Console.WriteLine("n");
                }
                else if (input == "a")
                {
                    Console.WriteLine("o");
                }
                else if (input == "b")
                {
                    Console.WriteLine("p");
                }
                else if (input == "c")
                {
                    Console.WriteLine("q");
                }
                else if (input == "j")
                {
                    Console.WriteLine("r");
                }
                else if (input == "k")
                {
                    Console.WriteLine("s");
                }
                else if (input == "l")
                {
                    Console.WriteLine("t");
                }
                else if (input == "m")
                {
                    Console.WriteLine("u");
                }
                else if (input == "n")
                {
                    Console.WriteLine("v");
                }
                else if (input == "t")
                {
                    Console.WriteLine("w");
                }
                else if (input == "u")
                {
                    Console.WriteLine("x");
                }
                else if (input == "v")
                {
                    Console.WriteLine("y");
                }
                else if (input == "w")
                {
                    Console.WriteLine("z");
                }


                Console.ReadKey();
                Console.Clear();
                Decoding();

            }




        }
    }
}
