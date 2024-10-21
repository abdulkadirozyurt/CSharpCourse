using System;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Intro
            // string variables are actually char arrays.
            string city = "Ankara";
            string city2 = "İstanbul";

            // strings addition
            string result = city + city2;
            //Console.WriteLine(String.Format("{0} {1}", city, city2));
            #endregion

            string sentence = "My name is abdulkadir.";

            var result2 = sentence.Length;
            var result3 = sentence.Clone();

            bool result4 = sentence.EndsWith("e");
            bool result5 = sentence.StartsWith("My name");

            var result6 = sentence.IndexOf("name");
            var result7 = sentence.IndexOf(" ");


            var result8 = sentence.LastIndexOf(" ");
            var result9 = sentence.Insert(0, "Hello");

            var result10 = sentence.Substring(3);
            var result11 = sentence.Substring(3,4);

            var result12=sentence.ToLower();    
            var result13=sentence.ToUpper();    

            var result14=sentence.Replace(" ","-");

            var result15=sentence.Remove(2);


        }
    }
}
