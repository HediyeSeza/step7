using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Please enter number to divide 100:");
            //try
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    int result = 100 / num;
            //    Console.WriteLine("100/{0}={1}", num, result);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Connot divide by zero.plaese try again");
            //}
            //Console.ReadKey();

            ///////////////////////////////////////////////////////////////////////////

            Console.Write("Please enter number to divide 100:");
            try
            {
                int num = int.Parse(Console.ReadLine());
                int result = 100 / num;
                Console.WriteLine("100/{0}={1}", num, result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Connot divide by zero.plaese try again");
            }
            catch (InvalidOperationException ex)
            {
                Console.Write("Invalid operation. Please try again.");
            }
            catch (FormatException ex)
            {
                Console.Write("Not a valid format. Please try again.");
            }
            catch (Exception ex)
            {
                Console.Write("Error occurred! Please try again.");
            }
                Console.ReadKey();


        }
    }
}
