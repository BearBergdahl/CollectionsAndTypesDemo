using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class SimpleTypes
    {
        public static void DemoSimpleType()
        {
            bool isNumber= false;
            string demoString = new(String.Empty);
            int result = default;
            bool isCopied = new();
            string copyString = default;
            int copyResult= new();  
            do
            {
                Console.WriteLine("Please enter integer value");
                var inputRaw = Console.ReadLine();
                Console.WriteLine($"Now what type is the input? {inputRaw.GetType()}");
                isNumber = int.TryParse(inputRaw, out result);
                if (isNumber)
                { 
                    Console.WriteLine($"Int result parsed: {result}, of type: {result.GetType()}"); 
                }
                Console.WriteLine("Lets play around with these");
                demoString = inputRaw.ToString();

            } while (!isNumber);

            isCopied = isNumber;
            Console.WriteLine(isCopied);
            Console.WriteLine("If we change isCopied, does isNumber change?");
            Console.ReadKey();
            isCopied = !isCopied;
            Console.WriteLine($"Lets try isNumber: {isNumber} and isCopied after change of isCopied to !isCopied: {isCopied}");
            Console.ReadKey();

            Console.WriteLine($"Can we access method from a value type? Yes: {result.ToString()}");
            Console.WriteLine($"Can we access method from a raw value? Well, yes we can: {13.ToString()} What's the type of twelve? and 12? and 12.0? ");
            Console.WriteLine($"Twelve is a: {"twelve".GetType()} it can be uppercased {"twelve".ToUpper()}");
            Console.WriteLine($"12 is a: {12.GetType()} it can be compared to another int like our manual input {12.CompareTo(result)} and we get the difference to 12");
        }
    }
}
