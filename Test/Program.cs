using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
        AgainCall:
            try
            {

                Console.WriteLine("Enter string Value :");
                string str = Convert.ToString(Console.ReadLine());
                str = str.ToUpper().ToString();
                MyCountChar(str);

            }
            catch (Exception ext) { Console.WriteLine(ext.Message.ToString()); }
            finally { Console.WriteLine(); }
            goto AgainCall;
        }

        internal static void MyCountChar(string str)
        {
            if (str.Length > 0)
            {
                Dictionary<char, int> characterCount = new Dictionary<char, int>();

                foreach (var character in str)
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }
                var maxValue = characterCount.Values.Max();
                var keyOfMaxValue = characterCount.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

                Console.WriteLine("Frequent Character {0}, Count : {1}", keyOfMaxValue, maxValue);

            }
        }

    }
}
