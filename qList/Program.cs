using System;
using System.Collections.Generic;


namespace qList
{
    class Program
    {
        static void Main(string[] args)
        {
           

            List<char> CharCollection = new List<char>();
            CharCollection.Add('R');
            CharCollection.Add('D');
            CharCollection.Add('V');

            CharCollection.RemoveAt(0);
            CharCollection.Remove('V');
            CharCollection[1] = 'Y';

            Console.WriteLine(CharCollection[1]);




        }
    }
}
