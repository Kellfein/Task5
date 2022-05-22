using System;
using System.IO;
using System.Text;

namespace Task5
{
    internal class Program
    {
        static void ReadFile()
        {
            string lines = null;
            if (File.Exists(@"D:\StaffList.txt"))
            {
                lines = File.ReadAllText(@"D:\StaffList.txt");
                Console.WriteLine(lines.Replace('#', ' '));
            }
            else
                Console.WriteLine("Файл не существует, перезапустите программу и выберите 2 или создайте файл вручную");
        }

        static void WriteFile()
        {
            using (StreamWriter sw = new StreamWriter(@"D:\StaffList.txt", true, Encoding.Unicode))
            {
                char key2 = 'д';

                while (Char.ToLower(key2) == 'д')
                {
                    string note = string.Empty;
                    Console.WriteLine($"\nВведите ID сотрудника");
                    note += $"{Console.ReadLine()}\t" + "#";

                    string now = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();// Для записи времени без учета секунд, согласно заданию
                    note += $"{now}\t" + "#";

                    Console.WriteLine("Введите ФИО сотрудника");
                    note += $"{Console.ReadLine()}\t" + "#";

                    Console.WriteLine("Введите возраст сотрудника"); // по идее можно считать автоматически
                    note += $"{Console.ReadLine()}\t" + "#";

                    Console.WriteLine("Введите рост сотрудника");
                    note += $"{Console.ReadLine()}\t" + "#";

                    Console.WriteLine("Введите дату рождения сотрудника");
                    note += $"{Console.ReadLine()}\t" + "#";

                    Console.WriteLine("Введите место рождения сотрудника");
                    note += $"{Console.ReadLine()}\t";

                    sw.WriteLine(note);
                    Console.Write("Добавить ещё одного сотрудника? н/д");
                    key2 = Console.ReadKey(true).KeyChar;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую! Для просмотра списка нажмите 1, для добавления нового сотрудника нажмите 2");
            char key = Console.ReadKey(true).KeyChar;

            if (key == '1')
            {
                ReadFile();
                Console.ReadKey();
            }
            else if (key == '2')
            {
                WriteFile();
            }
        }
    }
}

