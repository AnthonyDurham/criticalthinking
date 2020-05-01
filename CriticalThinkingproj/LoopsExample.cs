using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingproj
{
    class LoopsExample
    {

       
        public void ShowWordsInWord(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
               
            }


        }
    }
}
