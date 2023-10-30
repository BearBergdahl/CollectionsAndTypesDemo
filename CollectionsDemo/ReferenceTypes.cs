using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class ReferenceTypes
    {
        internal static void ObjectDemo()
        {
            Console.WriteLine("Lets try points with object");
            ObjectLocationInGrid john = new ObjectLocationInGrid { X=2, Y=2};
            ObjectLocationInGrid doe = new ObjectLocationInGrid { X=2, Y=3};
            Console.WriteLine(ObjectLocationInGrid.GetPlace(john));
            Console.WriteLine(ObjectLocationInGrid.GetPlace(doe));
            john = doe;
            Console.WriteLine(ObjectLocationInGrid.GetPlace(john));
            Console.WriteLine(ObjectLocationInGrid.GetPlace(doe));
            doe.X = 33 ;
            Console.WriteLine(ObjectLocationInGrid.GetPlace(john));
            Console.WriteLine(ObjectLocationInGrid.GetPlace(doe));

        }
    }
    public class ObjectLocationInGrid
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static string GetPlace(ObjectLocationInGrid character)
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
