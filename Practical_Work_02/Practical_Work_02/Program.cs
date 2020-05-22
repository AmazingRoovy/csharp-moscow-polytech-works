/*
 * Абахтимов Алексей Александрович. Группа 191-311 (Управление в технических системах, 1 курс).
 * Московский Политехнический университет.
 * Ссылка на GitHub: https://github.com/AmazingRoovy
 * Дата и время последнего редактирования: 17:04 22.05.2020.
 */

using System;
using System.Collections;
using System.Collections.Generic;

namespace Practical_Work_02
{

    // Компаратор для сравнения двух строк IComparer (for string field of 'elem' class instance).
    public class ElemNameComparer : IComparer <elem>
    {
        public int Compare(elem el1, elem el2)
        {
            string[] el1_splitted_array = el1.name.Trim().Split(new Char[] { '#' });
            string[] el2_splitted_array = el2.name.Trim().Split(new Char[] { '#' });

            if (!String.Equals(el1_splitted_array[0], el2_splitted_array[0]))
            {
                var result1 = string.Compare(el1_splitted_array[0], el2_splitted_array[0], StringComparison.OrdinalIgnoreCase);
                if (result1 < 0) 
                    return -1;
                else
                    return 1;
            }
            else
            {
                if (!String.Equals(el1_splitted_array[1], el2_splitted_array[1]))
                {
                    var result2 = string.Compare(el1_splitted_array[1], el2_splitted_array[1], StringComparison.OrdinalIgnoreCase);
                    if (result2 < 0)
                        return -1;
                    else
                        return 1;
                }
                else
                    return 0;
            }
        }
    }
    // Конец компаратора.

    public struct elem
    {
       
        public long isn;    // Код записи.
        public string type; // Тип издания.
        public string name; // Наименование.

        public override string ToString()
        {
            return this.isn.ToString() + " " + this.type + " " + this.name;
        }

        public elem(long isn_, string type_, string name_)
        {
            this.isn = isn_;
            this.type = type_;
            this.name = name_;
        }
        
    };

    class Program
    {
        // Алгоритм сортировки для массива фиксированной длины.
        public static elem[] Sort_BookRecords(elem[] source_array)  
        {
            // elem[] new_array = new elem[source_array.Length];
            for (int i = 0; i < source_array.Length - 1; ++i)
            {
                for (int j = i; j < source_array.Length; ++j)
                {
                    if (source_array[i].isn > source_array[j].isn)
                    {
                        elem tmp = source_array[i];
                        source_array[i] = source_array[j];
                        source_array[j] = tmp;
                    }
                }
            }
            return source_array;
        }

        public static void PrintListElements (IEnumerable myList)
        {
            foreach (elem el in myList)
                Console.WriteLine($"{el.isn}, {el.type}, {el.name}");
            Console.WriteLine();
        }

        public static void ShowArrayElements(elem[] array_of_elements)
        {
            foreach (var element in array_of_elements)
            {
                Console.WriteLine(element.isn.ToString() + " " + element.type + " " + element.name);
            }
        }


        static void Main()
        {
            // Алгоритм ввода списка книжных карточек. Содержит информацию о коде, типи издания и наименовании.
            Console.Write("Введите количество новых книжных карточек: ");
            int bookRecordsNumber = int.Parse(Console.ReadLine());
            elem[] elemArray = new elem[bookRecordsNumber];

            for (int i = 0; i < elemArray.Length; ++i)
            {
                Console.WriteLine($"Обработка книжной карты номер {i + 1}");
                Console.WriteLine("Введите код записи: ");
                while (!long.TryParse(Console.ReadLine(), out elemArray[i].isn))
                    //elemArray[i].isn = long.Parse(Console.ReadLine());
                    Console.WriteLine("Введите код записи повторно: ");

                Console.WriteLine("Введите тип издания: ");
                string typeElem = Console.ReadLine().Trim();
                while (typeElem == "")
                {
                    Console.WriteLine("Введите тип издания повторно: ");
                    typeElem = Console.ReadLine().Trim();
                    
                }
                elemArray[i].type = typeElem;

                // Предусмотрение двусоставного строения наименования - фамилия автора и название книги через '#'.
                Console.WriteLine("Введите наименование: ");
                string nameElem = Console.ReadLine().Trim();
                string[] splitted_nameElem = nameElem.Split(new Char[] { '#' });
                while (nameElem == "" || splitted_nameElem.Length != 2 || splitted_nameElem[0] == "" || splitted_nameElem[1] == "")
                {
                    Console.WriteLine("Введите наименование повторно: ");
                    nameElem = Console.ReadLine().Trim();
                    splitted_nameElem = nameElem.Split(new Char[] { '#' });
                }
                elemArray[i].name = nameElem;
            }

            // Применение алгоритма сортировки для массива фиксированной длины.
            Sort_BookRecords(elemArray);

            Console.WriteLine();
            Console.WriteLine("Сортируем по КОДУ ISN:\n");
            ShowArrayElements(elemArray);
            Console.WriteLine();

            Console.WriteLine("Переносим данные в списочный массив типа ArrayList...\nСортируем по НАИМЕНОВАНИЮ:\n");
            List <elem> myAL = new List<elem>();

            // Алгоритм ввода набора записей и непрерывной сортировки по алфавиту (сортируется после каждого ввода)
            // по названию книги с использованием списочного массива List <elem> myAL.
            for (int i = 0; i < elemArray.Length; ++i)
            {
                myAL.Add(new elem(elemArray[i].isn, elemArray[i].type, elemArray[i].name));
                myAL.Sort(new ElemNameComparer());

                Console.WriteLine($"Этап добавления (по одному элементу): {i}");
                PrintListElements(myAL);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
