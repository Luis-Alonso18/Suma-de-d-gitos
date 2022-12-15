using System;

namespace Suma_de_digitos
{
    class Program
    {
        static void Main(string[] args)
        {
            a:
            Console.WriteLine("Suma de dígitos");
            Console.Write("Ingrese un número para sumar sus dígitos: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Suma: " + digitsSum(num));
            Console.ReadKey();
            Console.Clear();
            goto a;
        }

        public static int digitsSum(int inputInt)
        {
            int result = 0;
            while (inputInt != 0)
            {
                // El número se divide entre 10 para recorrer los digitos y el restante se va sumando
                result = result + (inputInt % 10);
                inputInt = inputInt / 10;   // Se divide para recorrer cada dígito del número
            }
            return result; // Devuelve la suma de todos los dígitos
        }
    }
}
