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
            string[] user5 = new string[] { "Lisa", "Delhi", "25", "Female" };
            string[] user6= new string[] { "John","Mumbai","34","Male" };
            string[] user7 = new string[] { "Leah", "Jaipur", "20", "Female" };
            string[] user8 = new string[] { "Liz", "Delhi", "29", "Female" };
            string[] user9= new string[] { "Shane","Bangalore","30","Male" };
            string[] user10= new string[] { "Allen","Bangalore","35","Male" };

            Dictionary<int, string[]> dict = new Dictionary<int, string[]>();

            dict.Add(1, user1);
            dict.Add(2, user2);
            dict.Add(3, user3);
            dict.Add(4, user4);
            dict.Add(5, user5);
            dict.Add(6, user6);
            dict.Add(7, user7);
            dict.Add(8, user8);
            dict.Add(9, user9);
            dict.Add(10, user10);
        }
    }
}
