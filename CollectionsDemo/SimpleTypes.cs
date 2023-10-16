using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class SimpleTypes
    {
        public static void DemoValueType()
        {
            bool isNumber= false;
            string demoString;
            int result;
            bool isCopied;
            string copyString;
            int copyResult;
            do
            {
                Console.WriteLine("Please enter integer value");
                var inputRaw = Console.ReadLine();
                Console.WriteLine($"Now what type is the input? {inputRaw.GetType}");
                isNumber = int.TryParse(inputRaw, out result);
                if (isNumber)
                { 
                    Console.WriteLine($"Int result parsed: {result}, of type: {result.GetType}"); 
                }
                Console.WriteLine("Lets play around with these");
                demoString = inputRaw.ToString();

            } while (!isNumber); 
            
        }
    }
}
