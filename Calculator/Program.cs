using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int num1;
            int num2;
            string answer;
            int result;

            // First number request
            Console.WriteLine("Ciao, benvenuto nel programma della Calcolatrice!");

            // Casting, because ReadLine return string
            Console.WriteLine("Inserisci il primo numero.");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Second number request
            Console.WriteLine("Inserisci il secondo numero.");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Operation request
            Console.WriteLine("Quale operazione desideri effettuare?");
            Console.WriteLine("Perfavore, inserisci a per l'addizione, s per la sottrazione, m per la moltiplicazione o qualsiai altro tasto per la divisione.");

            answer = Console.ReadLine();

            if(answer == "a")
            {
                result = num1 + num2;
            } else if(answer == "s") 
            {
                result = num1 - num2;
            } else if(answer == "m")
            {
                result = num1 * num2;
            } else
            {
                result = num1 / num2;
            }

            Console.WriteLine("Il risultato è " + result);
            Console.WriteLine("Grazie per aver usato la Calcolatrice!");



            Console.ReadKey();

        }
    }
}
