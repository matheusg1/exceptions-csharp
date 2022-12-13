using ExercicioExceptions.Exceptions;
using System;
using System.ComponentModel.Design;
using System.IO;

namespace ExercicioExceptions
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a1 = new Account(8021, "Bob Brown", 200d, 300.0);
                a1.Withdraw(250d);
                Console.WriteLine("balance" + a1.Balance.ToString("F2"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally{
                Console.WriteLine("Fim do código");
            }
        }
    }
}