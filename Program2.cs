using System;
namespace PAPKA
{
    class Program2
    {
        static void Main()
        {
            // Введите ляляля

            Console.Write("Введите число с запятой: "); // Чтобы программа работала корректно, введи запятую, а не точку!!!

            // Переменные
 
            float result;
            string var = "Переменная: ";
            string dot = ".";
            float user_input = float.Parse(Console.ReadLine()); // Наиболее выгодное решение, если нужен именно тип данных float.
            int a = 5, b = 6;
            int res = a + b; 
            // Математические действия

            result = user_input + 10f;
            result = user_input - 10f;
            result = user_input * 2f;
            result = user_input / 5f;
            result = user_input % 2f;
            result += 5f; // += аналогично "переменная" + "число"f. Также и с другими математическими действиями. Всё будет обрабатыватся корректно.

            // user_input = Convert.ToDouble(Console.ReadLine()); - лёгкий способ, но занимает в 2 раза больше памяти, если использовать вместо float тип данных double.
            
        
            
            // Выводы информаций

            Console.WriteLine(var + result + dot);
            Console.WriteLine(res);
        }
    }
}
