using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOfSortedDictionary20Jan
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> st = new SortedDictionary<int, string>();

            //Add 
            st.Add(30, "India");
            st.Add(10, "China");
            st.Add(20, "Nepal");
            st.Add(40, "Bhutan");
            st.Add(50, "Sri Lanka");
            st.Add(80, "Malaysia");
            st.Add(60, "Singapore");
            st.Add(70, "Thailand");
            Console.WriteLine("Sorted Dictionary");
            foreach (KeyValuePair<int, string> pair in st)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }

            //Count
            Console.WriteLine("\nTotal number of entries " + "present in list : {0}", st.Count);

            //Remove
            st.Remove(10);
            Console.WriteLine("\nAfter using Remove method");
            foreach (KeyValuePair<int, string> pair in st)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }

            //Contains
            Console.WriteLine("\nIf the key 20 is present? " + st.Contains(new KeyValuePair<int, string>(20, "Nepal")));

            //ContainsKey
            Console.WriteLine("\nIf the key 60 is present? " + st.ContainsKey(60));

            //ContainsValue
            Console.WriteLine("\nIf the value Bhutan is present? "+ st.ContainsValue("Bhutan"));

            //CopyTo
            Console.WriteLine("\nUsing CopyTo method");
            var myArr = new KeyValuePair<int, string>[st.Count];
            st.CopyTo(myArr, 0);
            IDictionaryEnumerator copy = st.GetEnumerator();
            while (copy.MoveNext())
            {
                Console.WriteLine(copy.Key + " " + copy.Value);
            }

            //GetEnumerator
            Console.WriteLine("\nBefore using Clear method");
            IDictionaryEnumerator ide = st.GetEnumerator();
            while (ide.MoveNext())
            {
                Console.WriteLine(ide.Key + " " + ide.Value);
            }

            //Clear
            Console.WriteLine("\nAfter using Clear method");
            st.Clear();
            foreach (KeyValuePair<int, string> p in st)
            {
                Console.WriteLine("{0} = {1}",
                    p.Key,
                    p.Value);
            }

            Console.ReadLine();
        }
    }
}

