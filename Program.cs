using System;

namespace Ex2_Laborator4_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 2
            //Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m
            //k.Lungimile celor doua dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.
            // Scrieti o functie care va calcula suma elementelor unei astfel de matrici, apelati-o si afisati-i
            //rezultatul.
            // Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i
            //rezultatul.


            Console.WriteLine("Introduceti numarul de matrici din matricea 3d: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de linii: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de coloane: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti " + n * m * k + " numere:");
            int[,,] matrice = new int[n, m, k];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int q = 0; q < k; q++)
                    {
                        matrice[i, j, q] = int.Parse(Console.ReadLine());
                    }
                }
            }

            int suma = SumaElemente(matrice);
            Console.WriteLine("Suma elementelor introduse este: " + suma);

            int maxim = NumarulMaxim(matrice);
            Console.WriteLine("Cel mai mare numar este: " + maxim);
        }
        static int SumaElemente(int[,,] matrice)
        {
            int suma = 0;
            foreach (int numar in matrice)
            {
                suma += numar;
            }
            return suma;
        }
        static int NumarulMaxim(int[,,] matrice)
        {
            int maxim = -9999;
            foreach (int numar in matrice)
            {
                if (numar > maxim)
                {
                    maxim = numar;
                }
            }

            return maxim;
        }
    }
}
