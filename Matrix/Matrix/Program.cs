using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Введите размерность матрицы: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Введите диагональ ( 0,+1,-1): ");//вож значения шага, изменение от основной диагонали
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n {new string('*', 30)} \n");

            string[,] a = new string[c, c];
            string[,] a1 = new string[c, c];//копия матрици
            string[,] a2 = new string[c, c];//копия матрици

            //*******************************************  заполнение матрицы данными и вывод *****************

            for (int i = 0; i < a.GetLength(0); i++)

            {

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Random rand = new Random();
                    a[i, j] = Convert.ToString(rand.Next(0, 100));
                    
                    Console.Write($" {a[i, j]} ");
                }

                Console.WriteLine();
            }
            
                string[,] aClon = (string[,])a.Clone();   
            



            //копируем резервную матрицу


            //*******************************************  вывод данных по диогонали  *****************
            Console.WriteLine($"\n {new string('*', 30)} \n");
            for (int i = 0; i < a.GetLength(0); i++)
            {

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i + d != j) a[i, j] = " ";

                    Console.Write($"  {a[i, j]}");
                }
                Console.WriteLine();

            }

            //******************************************* обратная диагональ ********************
            Console.WriteLine($"\n {new string('*', 30)} \n");
            for (int i = 0; i < aClon.GetLength(0); i++)
            {
                for (int j = 0; j < aClon.GetLength(1); j++)
                {

                    if (i != aClon.GetLength(1) - j) aClon[i, j] = " ";
                    Console.Write($" {aClon[i, j]}");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
