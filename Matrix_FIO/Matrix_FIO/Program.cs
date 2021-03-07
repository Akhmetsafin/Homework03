using System;

namespace Matrix_FIO
{
    class Program
    {



        static void Main(string[] args)
        {
            Console.Write($"Количество вводимых позиций: ");
            int menCount = Convert.ToInt32(Console.ReadLine());
            string[,] dbFIO = new string[menCount, 3];
            intData(dbFIO);
            Console.Write($"Нажмите любую клавишу для вывода таблицы");
            Console.ReadKey();
            Console.Clear();
            visualDB(dbFIO);
            Console.ReadKey();

        }
        
        //========================================= вывод инфо на консоль и присвоение переменных string ===================
        static (string firstName, string lastName, string patronymic) fio()

        {
            int firstName_L = 12;
            int lastName_L = 10;
            int patronymic_L = 12;

            Console.Write("Введите имя: ");
            string firstName = Console.ReadLine();
            firstName_L = firstName_L - firstName.Length;
            firstName= firstName +(new string(' ', firstName_L));

            Console.Write("Введите фамилию: ");
            string lastName = Console.ReadLine();
            lastName_L = lastName_L - lastName.Length;
            lastName = lastName +(new string(' ', lastName_L));

            Console.Write("Введите отчество: ");
            string patronymic = Console.ReadLine();
            patronymic_L = patronymic_L - patronymic.Length;
            patronymic = patronymic + (new string(' ', patronymic_L));

            return (firstName, lastName, patronymic);
        }
        //=========================================== загрузка данных в матрицу =======================
        public static void intData(string[,] dbFIO)
        {
            

            for (int i = 0; i < dbFIO.GetLength(0); i++)
            {
                (string firstName, string lastName, string patronymic) = fio();
                
                for (int j = 0; j < dbFIO.GetLength(1); j++)
                {
                    if (j == 0) dbFIO[i, j] = firstName;
                    if (j == 1) dbFIO[i, j] = lastName;
                    if (j == 2) dbFIO[i, j] = patronymic;
                }
            }
            Console.WriteLine();
        }
        //========================================= вывод в консоль ==========================
        static void visualDB(string[,] dbFIO)
        {
            Console.WriteLine($"\n\tСписок инженеров MWD\n");

            for (int i = 0; i < dbFIO.GetLength(0); i++)
            {
                for (int j = 0; j < dbFIO.GetLength(1); j++)
                {
                    Console.Write($"\t{dbFIO[i, j]}");
                }
                Console.WriteLine();
            }
        }
        
    }
}

