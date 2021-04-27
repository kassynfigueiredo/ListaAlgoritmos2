using System;

namespace ListaAlgoritmos2
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        public static void SomaDosNaturais()
        {           
            int soma = 0;
            for(int i = 0; i <= 100; i++)
            {
                soma += i;
            }
            Console.WriteLine($"A soma dos 100 primeiro algarismos naturais é {soma}.");
        }

        public static void MultiplosDeSete()
        {
            for(int i = 0; i <= 200; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static void NumerosDivisiveisPorQuatro()
        {
            for (int i = 0; i <= 100; i++)
            {
                if(i % 4 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static void NumeroDeDivisores()
        {
            try
            {
                Console.Write("Digite um número: ");
                string num = Console.ReadLine();

                int numero = int.Parse(num);

                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato inválido ou nenhum número inserido");
            }
            
        }

        public static void Fatorial()
        {
            try
            {
                Console.Write("Digite um número: ");
                string num = Console.ReadLine();

                int numero = int.Parse(num);

                int i = 1;
                int nFat = 1;

                while (i <= numero)
                {
                    nFat = nFat * i;
                    Console.WriteLine(nFat);
                    i++;
                    Console.WriteLine(i);
                }
                Console.WriteLine($"O fatorial de {numero} é {nFat}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor inválido ou número não inserido.");
            }
            
        }

        public static void Media()
        {

            int soma = 0;
            int numeros = 0;
            for (int i = 13; i <= 73; i++)
            {
                if (i % 2 == 0)
                {
                    soma += i;
                    numeros++;
                }
            }
            int media = soma / numeros;
            Console.WriteLine($"Existem {numeros} numeros entre 13 e 73.");
            Console.WriteLine($"A média aritmética entre 13 e 73 é {media}");
        }

        public static void IntervaloValores()
        {
            try
            {
                int dentroDoIntervalo = 0;
                int foraDoIntervalo = 0;
                int[] array = new int[10];
                for (int i = 0; i <= array.Length - 1; i++)
                {
                    Console.Write("Digite um valor: ");
                    string valor = Console.ReadLine();
                    array[i] = int.Parse(valor);
                }
                foreach(int numero in array)
                {
                    Console.Write(numero + " ");
                    if (numero >= 10 && numero <= 50)
                        dentroDoIntervalo++;
                    else
                        foraDoIntervalo++;
                }
                Console.WriteLine();
                Console.WriteLine($"Existem {dentroDoIntervalo} números dentro de 10 e 50  e {foraDoIntervalo} números fora.");
            }
            catch(Exception)
            {
                IntervaloValores();
            }           
        }

        public static void NumeroPrimo()
        {
            try
            {
                Console.Write("Digite um valor: ");
                string num = Console.ReadLine();

                int valor = int.Parse(num);
                int total = 0;
                for (int i = 1; i <= valor; i++)
                {
                    if (valor % i == 0)
                    {
                        total++;
                    }
                }
                if (total == 2)
                {
                    Console.WriteLine($"O número {valor} é primo.");
                }
                else
                {
                    Console.WriteLine($"O número {valor} não é primo.");
                }
            }
            catch(Exception)
            {
                NumeroPrimo();
            }
        }

    }
}
