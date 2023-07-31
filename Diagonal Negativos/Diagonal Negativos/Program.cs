using System;

namespace Programa {
    class Program {
        static void Main(string[] args) {

            int N, i, j, negativos;

            Console.Write("Qual a ordem da matriz ? ");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (i = 0; i < N; i++) {
                for (j = 0; j < N; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (i = 0; i < N; i++) {
                Console.Write(mat[i, i] + "  ");
            }

            negativos = 0;
            for (i = 0; i < N; i++) {
                for (j = 0; j < N; j++) {
                    if (mat[i, j] < 0) {
                        negativos++;
                    }
                }
            }

            Console.WriteLine("\nQUANTIDADE DE NEGATIVOS = " + negativos);
        }
    }
}





        
    

