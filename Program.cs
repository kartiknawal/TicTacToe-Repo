using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Networking_Diagram
{
    class Dataset
    {
        public static void GenericCollections()
        {
            string[] user1 = new string[] { "Bob", "Delhi", "25", "Male" };
            string[] user2= new string[] { "Mike","Mumbai","23","Male" };
            string[] user3 = new string[] { "Jill", "Jaipur", "20", "Female" };
            string[] user4 = new string[] { "Emma", "Bangalore", "27", "Female" };

            Dictionary<int, string[]> dict = new Dictionary<int, string[]>();

            dict.Add(1, user1);
            dict.Add(2, user2);
            dict.Add(3, user3);
            dict.Add(4, user4);

        }
    }
}
