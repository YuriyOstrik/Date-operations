using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Date_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования Parse для целого числа
            string intString = "123"; int parsedInt = int.Parse(intString); 
            Console.WriteLine($"Parsed целое число: {parsedInt}"); 
            // Пример использования TryParse для целого числа
            string invalidIntString = "123abc"; 
            if (int.TryParse(invalidIntString, out int tryParsedInt)) 
            { 
                Console.WriteLine($"TryParsed целое число: {tryParsedInt}"); 
            } 
            else 
            { 
                Console.WriteLine($"Failed to parse '{invalidIntString}' как целое число.");
            } 
            // Пример использования ParseExact для даты
            string dateString = "25-11-2024"; 
            DateTime parsedDate = DateTime.ParseExact(dateString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine($"Parsed дата: {parsedDate.ToString("d")}");
            // Пример использования TryParseExact для даты
            string invalidDateString = "25/11/2024"; 
            if (DateTime.TryParseExact(invalidDateString, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime tryParsedDate))
            { 
                Console.WriteLine($"TryParsed дата: {tryParsedDate.ToString("d")}"); 
            } 
            else 
            { 
                Console.WriteLine($"Failed to parse '{invalidDateString}' как дата в формате 'dd-MM-yyyy'.");
            }
            // Пример использования Parse для числа с плавающей запятой
            string floatString = "123.45"; 
            float parsedFloat = float.Parse(floatString, CultureInfo.InvariantCulture);
            Console.WriteLine($"Parsed число с плавающей запятой: {parsedFloat}"); 
            // Пример использования TryParse для числа с плавающей запятой
            string invalidFloatString = "123.45abc"; 
            if (float.TryParse(invalidFloatString, NumberStyles.Float, CultureInfo.InvariantCulture, out float tryParsedFloat)) 
            {
                Console.WriteLine($"TryParsed число с плавающей запятой: {tryParsedFloat}"); 
            }
            else 
            { 
                Console.WriteLine($"Failed to parse '{invalidFloatString}' как число с плавающей запятой.");
            }
        }
    }
}
