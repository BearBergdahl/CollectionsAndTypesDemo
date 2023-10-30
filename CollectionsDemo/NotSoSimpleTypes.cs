using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public static class NotSoSimpleTypes
    {
        public static void StructExample()
        {
            CharacterLocationInGrid jonsLocation = new CharacterLocationInGrid { X = 1, Y = 2 };
            Console.WriteLine($"Where is Jon? {CharacterLocationInGrid.GetPlace(jonsLocation)}");
            CharacterLocationInGrid aryasLocation = new CharacterLocationInGrid {  Y = 1, X = 2 };
            Console.WriteLine($"Where is Arya? {CharacterLocationInGrid.GetPlace(aryasLocation)}");
            jonsLocation = aryasLocation;
            aryasLocation.X = 1;
            aryasLocation.Y = 23;
            Console.WriteLine($"Where is Jon? {CharacterLocationInGrid.GetPlace(jonsLocation)}");
            Console.WriteLine($"Where is Arya? {CharacterLocationInGrid.GetPlace(aryasLocation)}");
            Console.ReadKey();
        }
        public static void LetsEnum()
        {
            NiceLanguages myFavorite = NiceLanguages.CSharp;
            NiceLanguages all = new NiceLanguages();
            Console.WriteLine($"My favorite: {myFavorite}");
            Console.WriteLine($"I also like: {Enum.GetName(all.GetType(), 4)}");
            TestLanguages(myFavorite);
            TryWeekdays(new DayOfWeek());
        }

        private static void TestLanguages(NiceLanguages favorite)
        {
            Console.WriteLine(favorite +":"+ (int)favorite);
            Console.WriteLine("Is Equals to:");
            Console.WriteLine(NiceLanguages.CSharp + ":" + (int)NiceLanguages.CSharp);
            // Warning not all enums are int based, it's a default but needs to checked to be sure.
        }

        private static void TryWeekdays(System.Enum e)
        {
            Array days = Enum.GetValues(e.GetType());
            foreach (var day in days)
            {
                Console.WriteLine(day.ToString());
            }
        }
    }
    public enum NiceLanguages
    {
        CSharp,
        JavaScript,
        Java,
        Python,
        Powershell,
        Bash
    }

    public struct CharacterLocationInGrid
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static string GetPlace(CharacterLocationInGrid character)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Your character are in grid ");
            sb.Append(character.X);
            sb.Append(",");
            sb.Append(character.Y);
            return sb.ToString();
        }
    }
}
