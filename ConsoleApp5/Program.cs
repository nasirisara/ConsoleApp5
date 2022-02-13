using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i<int.MaxValue )
            { 
             
                Console.WriteLine("please insert num1");
                    string strnum1 = Console.ReadLine();

                    Console.WriteLine("please insert +, -, *,/ as operators!");
                   string opera = Console.ReadLine();

                    Console.WriteLine("please insert num2");
                    string strnum2 = Console.ReadLine();

            
                
                
                
                double num1, num2;
                num1 = double.Parse(strnum1);
                num2 = double.Parse(strnum2);

                  



                    switch (opera)
                    {
                        case "+":
                            Console.WriteLine(num1 + num2);
                            break;

                        case "-":
                            Console.WriteLine(num1 - num2);
                            break;

                        case "/":
                        { if (num2 == 0)
                                Console.WriteLine("invalid number");
                        else
                            Console.WriteLine(num1 / num2);
                            break;
                        }
                        
                       

                        case "*":
                            Console.WriteLine(num1 * num2);
                            break;

                    }
                    i++;
                        }


                Console.ReadKey();
                }

            }
        }    
            

    
