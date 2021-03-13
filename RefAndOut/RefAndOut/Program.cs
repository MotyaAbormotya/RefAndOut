using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 0;
            string[] FIO = new string[width];
            string[] job = new string[width];
            string menu;
            bool exit = false;

            FiO(ref width, ref FIO, ref job);
            while (exit == false)
            {
                Console.Write("Команда: ");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "Search":
                        string searchName = Console.ReadLine();
                        Search(searchName, FIO, job);
                        break;
                    case "Del":
                        int FIOJ = int.Parse(Console.ReadLine());
                        Del(FIOJ, ref FIO, ref job);
                        break;
                    case "Exit":
                        Exit(out exit);
                        break;
                    case "FIO":
                        FiO(ref width, ref FIO, ref job);
                        break;
                    case "Display":
                        Display(ref FIO, ref job);
                        break;
                }
            }
        }
        public static void Del(int FIOJ, ref string[] FIO, ref string[] job)
        {
            FIO[FIOJ - 1] = null;
            job[FIOJ - 1] = null;
        }
        public static void Display(ref string[] FIO, ref string[] job)
        {
            for (int i = 0; i < FIO.Length; i++)
            {
                Console.WriteLine($"{i + 1}){FIO[i]}-{job[i]}, ");
            }
        }
        public static void Exit(out bool exit)
        {
            exit = true;
        }
        public static void Search(string searchName, string[] FIO, string[] job)
        {
            for (int i = 0; i < FIO.Length; i++)
            {
                if (searchName == FIO[i])
                {
                    Console.WriteLine(FIO[i] + "-" + job[i]);
                    Console.WriteLine();
                }
            }
        }
        public static void FiO(ref int width, ref string[] FIO, ref string[] job)
        {
            string[] tempFIO = new string[width];
            string[] tempJob = new string[width];
            for (int j = 0; j < FIO.Length; j++)
            {
                tempFIO[j] = FIO[j];
                tempJob[j] = job[j];
            }
            width++;
            FIO = new string[width];
            job = new string[width];
            for (int z = 0; z < tempFIO.Length; z++)
            {
                FIO[z] = tempFIO[z];
                job[z] = tempJob[z];
            }
            Console.Write("Фамилия: ");
            FIO[FIO.Length - 1] = Console.ReadLine();
            Console.Write("Должность: ");
            job[job.Length - 1] = Console.ReadLine();
            for (int i = 0; i < job.Length; i++)
            {
                Console.WriteLine(FIO[i] + "-" + job[i]);
                Console.WriteLine();
            }
        }
    }
}
