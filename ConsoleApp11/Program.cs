using System;

namespace JogoAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                char LetraOuNum;

                Console.Write("Informe uma caracter: ");
                while (!char.TryParse(Console.ReadLine(), out LetraOuNum) || !char.IsLetterOrDigit(LetraOuNum))
                {
                    Console.Write("Caracter inválida. Informe um caracter válido: ");
                }

                Console.Clear();

                if (char.IsLetter(LetraOuNum))
                {
                    Console.WriteLine("Caracter informado é uma LETRA: {0}", LetraOuNum);
                }
                else
                {
                    Console.WriteLine("Caracter informado é um NÚMERO: {0}", LetraOuNum);
                }

                Console.Write("Caso queira verficar novamente digite ENTER: ");
                Console.ReadLine();
            }
        }
    }
}

