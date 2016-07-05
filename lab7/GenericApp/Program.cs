using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiDictionary<int, string> dictionary = new MultiDictionary<int, string>();

            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");
            dictionary.Add(1, "ich");
            dictionary.Add(2, "nee");
            dictionary.Add(3, "sun");

            Console.WriteLine("count= " + dictionary.Count+
                               " Keys= " + dictionary.Keys.Count+
                               " Values= " + dictionary.Values.Count);

            dictionary.Add(1, "wahad");
            dictionary.Add(2, "tnein");
            dictionary.Add(3, "talata");
            Console.WriteLine("3 values added");
            Console.WriteLine("count= " + dictionary.Count);

            dictionary.Remove(1, "wahad");
            Console.WriteLine("1 value remove" );
            Console.WriteLine("count= " + dictionary.Count);

            dictionary.Remove(1, "wahad");//try to remove not exist item
            Console.WriteLine("try to remove a value that not exist");
            Console.WriteLine("count= " + dictionary.Count);

            dictionary.Remove(1);
            Console.WriteLine("remove key 1");
            Console.WriteLine("count= " + dictionary.Count);

            Console.WriteLine("Check if dictionary contain 1");
            Console.WriteLine(dictionary.ContainsKey(1));

            Console.WriteLine("Check if dictionary contain 2");
            Console.WriteLine(dictionary.ContainsKey(2));

            Console.WriteLine("Check if dictionary contain (2,two)");
            Console.WriteLine(dictionary.ContainsKey(2,"two"));

            Console.WriteLine("Check if dictionary contain (1,two)");
            Console.WriteLine(dictionary.ContainsKey(1, "two"));

            Console.WriteLine("Check if dictionary contain (2,one)");
            Console.WriteLine(dictionary.ContainsKey(2, "one"));
        }
    }
}
