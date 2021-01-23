using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary_Class<string, string> dictionary = new Dictionary_Class<string, string> { };
            dictionary.Add("1", "Demir");
            dictionary.Add("2", "Doruk");
            dictionary.Add("3", "Acar");

            for (int i = 0; i < dictionary.keys.Length; i++)
            {
                Console.WriteLine(dictionary.keys[i].ToString() + " : " + dictionary.values[i].ToString());
            }

            Console.ReadLine();
        }
    }
}
