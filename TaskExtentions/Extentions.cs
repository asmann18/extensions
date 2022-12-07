using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExtentions
{
    internal static class Extentions
    {
        internal static bool customContains(this string sentence,string searchSentence )
        {
            sentence = sentence.ToLower();
            searchSentence = searchSentence.ToLower();
            string sentence1;
            string sentence2;
            string sentence3;
            sentence1 = sentence;
            sentence2 = sentence;
            sentence3 = sentence;
            //    for (int i = 0; i < sentence1.Length; i++)
            //    {
            //    string test = sentence1.Substring(i);
            //    if(searchSentence == test)
            //    {
            //        Console.WriteLine("True");
            //        break;
            //    }
            //    }

            //for (int i = 0; i < sentence2.Length; sentence2=sentence2.Remove(sentence2.Length-1 , 1)) 
            //{
            //    string test = sentence2.Substring(i);
            //    if (searchSentence == test)
            //    {
            //        Console.WriteLine("True");
            //        break;
            //    }

            //}

            for(int i = 0; i < sentence3.Length; i++)
            {
                string sentencetest = sentence3;
                for(int u=i;u<sentencetest.Length; sentencetest = sentencetest.Remove(sentencetest.Length - 1, 1))
                {
                    string test = sentencetest.Substring(u);
                    if (test == searchSentence)
                    {
                        return true;
                    }
                }
            }




            return false;












        }
    }
}
