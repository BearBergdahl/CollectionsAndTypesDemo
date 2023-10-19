using System;

namespace CollectionsDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int selected = 0;
            bool letsGo = new();
            do
            {
                Console.WriteLine("1. Demo Value Types");
                Console.WriteLine("2. Demo Structs");
                Console.WriteLine("3. Demo Enum");
                Console.WriteLine("4. Exit");
                string selection = Console.ReadKey().KeyChar.ToString();
                letsGo = int.TryParse(selection, out selected);               
                
                switch (selected)
                {
                    case 1:
                        SimpleTypes.DemoSimpleType();
                        break;
                    case 2:
                        NotSoSimpleTypes.StructExample();
                        break;
                    case 3:
                        NotSoSimpleTypes.LetsEnum();
                        break;
                    default:
                        break;
                }
            } while (letsGo && selected != 4);                               
        }
    }
}