using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int operacion;
            string caracter;
            Console.WriteLine("Primer numero");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo numero");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Que operacion deseas relizar");
            caracter = Convert.ToString(Console.ReadLine());
            switch (caracter)
            {
                case "+":
                    operacion = x + y;
                    Console.WriteLine("El resultado de la sume es " + operacion);
                    break;
                case "-":
                    operacion = x - y;
                    Console.WriteLine("El resultado de la resta es " + operacion);
                    break;
                case "*":
                    operacion = x * y;
                    Console.WriteLine("El resultado de la multiplicacion es " + operacion);
                    break;
                case "/":
                    operacion = x / y;
                    Console.WriteLine("El resultado de la division es " + operacion);
                    break;
            }
            Console.ReadKey();
        }
    }
}