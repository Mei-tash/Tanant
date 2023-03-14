            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace Список_жильцов
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                bool isOpen = true;
                string[] tanant =
                {"Соколова Александра Михайловна", "Поляков Владислав Ильич", "Гуров Денис Кириллович", "Дьяконов Михаил Давидович",
                "Гончаров Егор Вячеславович", "Галкин Вячеслав Максимович", "Смирнова Амина Максимовна", "Ильинская София Эмировна",
                "Левина Вера Михайловна", "Комаров Артемий Дмитриевич"};
                int[] flat = { 7, 11, 5, 2, 21, 3, 15, 4, 8, 17 };
                while (isOpen)
                {
                    Console.WriteLine("1 - вывести список имен в алфавитном порядке. \n\n2 - вывести список квартир. \n\n3 - вывести имена и их квартиры." +
                        "\n\n4 - выйти из программы.\n");
                    Console.Write("Выберете команду: ");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            for (int i = 0; i < tanant.Length; i++)
                            {
                                Console.WriteLine(tanant[i] + ";");
                            }
                            break;

                        case 2:
                            for (int i = 0; i < flat.Length; i++)
                            {
                                Console.WriteLine("Квартира: " + flat[i]);
                            }
                            break;

                        case 3:
                            for (int i = 0; i < tanant.Length; i++)
                            {
                                Console.WriteLine($"\tФИО: {tanant[i]}, квартира: {flat[i]}");
                                Console.WriteLine($"\nВсего осталось {tanant.Length - i - 1}.\n");
                                Console.ReadKey();
                            }
                            break;

                        case 4:
                            isOpen = false;
                            break;


                        default:
                            Console.WriteLine("Введена не верная команда, нажмите любую клавишу, что бы продолжить...");
                            break;
                    }
                    Console.Write("\nНажмите любую клавишу, чтобы продожить...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }

    

