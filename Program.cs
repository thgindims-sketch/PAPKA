using System; // Импорт библиотеки "System".

namespace PAPKA // Создание именного пространства с названием папки, в которой находится на проект.
{
    class Program // Импортируем класс с названием нашего .cs проекта.
    {
        static void Main() // Не знаю что это.
        {
            int number = 33000;
            Console.WriteLine(number); // Int - от -2 миллиардов примерно до 2 миллиардов примерно. Uint - ТОЛЬКО положительные числа. Byte - от 0 до 255. Short - от -32 тысяч до 32 тысяч. Long - от -3 - -4 триллиона до 3 - 4 триллиона.

            float num = -10004.62734f; // float - используется для чисел с точкой. Чтобы завершить чило нужно добавить перед ";" знак "f", чтобы работало корректно.
            double num_2 = 5.40094580582384023843029d; // double - используется для невероятных значений. Также как и с float, нужно добавить перед ";" знак "d", чтобы работало корректно.
            
            string word = "Переменная: ";          // }
            //                                        } String используется для создание переменной-строки. Можно включить туда предложения, символы и т.д.
            string word_2 = "Вторая переменная: "; // }

            string character = "Символ: ";
            string dot = ".";
            string happy = "Счастлив: ";

            char symbol = 'H'; // Char Используется для одного символа. (Оптимизирует программу). Записывается в одинарных кавычках, нежели чем "string".
            Console.WriteLine(character + symbol + dot);

            bool isHappy = false; // Bool используется для условий "if ... else ... else if". Имеет два выражения: true (истина), false (ложь). Выводится в консоль ввиде строки.
            Console.WriteLine(happy + isHappy + dot);

            Console.WriteLine(word + num + ".");
            Console.WriteLine(word_2 + num_2 + ".");

            Console.WriteLine("HMYR 1"); // }
            Console.WriteLine("HMYR 2"); // } Вывод информации в консоль.
            Console.WriteLine("HMYR 3"); // }
            Console.Read(); // Консоль ожидает какой-нибудь ввод информации пользователя для завершения работы кода. aka получение данных.

            // ПРАКТИКА! :3
            string first = "Первое число: ";
            string second = "Второе число: ";
         // string dot = "."

            int number1 = 0, number2 = 0;

            number1 = Convert.ToInt32(Console.ReadLine()); // Convert - конвертирование функции в другой тип данных и тому подобное.
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(first + number1 + dot);
            Console.WriteLine(second + number2 + dot);
        }
    }
}
