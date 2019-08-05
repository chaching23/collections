using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {

            // int[] numArray = {1,2,3,4,6,10,15,25};
            string[] myBoys = new string[] {"Tim", "Martin", "Nikki",  "Sara"};
            // bool[] tf =  {true, false, true, false, true, false, true, false, true, false,};


            List<string> ice = new List<string>();
            ice.Add("honda");
            ice.Add("toyota");
            ice.Add("BMW");
            ice.Add("Harley Davidson");
            ice.Add("Suzuki");


            // Console.WriteLine($"We currently have {ice.Count} flavors!");
            // ice.RemoveAt(2); 
            // Console.WriteLine($"Now we have {ice.Count} flavors!");



            Dictionary<string,string> profile = new Dictionary<string,string>();

            Random rand = new Random();
            for(int val = 0; val < myBoys.Length; val++)

            profile.Add(myBoys[val], ice[rand.Next(0,5)] );


            foreach (KeyValuePair<string,string> entry in profile)
            {
            Console.WriteLine(entry.Key + " - " + entry.Value);
            }






        }
    }
}
