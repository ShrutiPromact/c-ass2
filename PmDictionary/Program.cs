using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Atal Bihari vajpayee", 1998);
            dict.Add("Narendra Modi", 2014);
            dict.Add("Manmohan Singh", 2004);
       
            foreach (KeyValuePair<string, int> pair in dict)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
            Console.WriteLine();

            //findValue
            var values = dict.Where(pair => pair.Key.Contains(2004))
                   .Select(pair => pair.Value);
            
            Console.WriteLine("The  Prime Minister of 2004 is:" + values);
            //var pmfind = dict.Find(x => x.key == 2004);
            Console.WriteLine();


            dict.Add(" Modi",2015);
           
            var items = from pair in dict
                        orderby pair.Value ascending
                        select pair;

            foreach (KeyValuePair<string, int> pair in items)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }

            Console.ReadKey();
        }
    }
}
