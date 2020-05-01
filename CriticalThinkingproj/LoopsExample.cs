using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingproj
{
    class LoopsExample
    {
        int i;

        public void ShowWordsInWord(string word)
        {
            for (int i = 0; i < word.Length; i++)

            {
                
                
                if (i % 3 == 0) 

                {
                  
                   Console.WriteLine(word[i]);
                  
                 }       

                
            }
        }

    }

}