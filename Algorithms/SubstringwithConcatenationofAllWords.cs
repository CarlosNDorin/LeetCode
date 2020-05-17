using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class SubstringwithConcatenationofAllWords
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            if (words.Length == 0)  // Si la cantidad de palabras es vacio,
                return new List<int>(); //devuelve una lista vacia.

            var ret = new List<int>(); // crea una nueva lista de enteros 
            var dic = new Dictionary<string, int>();
            foreach (string str in words)
            {
                if (dic.ContainsKey(str)) // agrega al diccionario, si ya aparece,
                    dic[str]++;           // en el valor suma 1.
                else
                    dic.Add(str, 1);
            }

            int i = 0;

            int totalLen = words.Length * words[0].Length;//La cantidad de strings por el lenght.

            while (i < s.Length - totalLen + 1) // i es menor al lenght del texto menos la cantidad
            {                                   // de words*length del las words.
                if (Compare(s, i, i + totalLen, words, dic))
                    ret.Add(i);
                //envia el text, desde , hasta, las words y el diccionario
                //si aparecen en el texto lo agrega a la list "ret"
                i++;
            }

            return ret;
        }

        private bool Compare(string s, int start, int end, string[] words, Dictionary<string, int> dic)
        {

            var tmpDic = new Dictionary<string, int>(dic);//nuevo diccionario 
            int len = words[0].Length; // la cantidad de letras por cada word
            for (int i = start; i < end; i += len)
            {
                string tmpStr = s.Substring(i, len);//Agarra los strings

                if (!tmpDic.ContainsKey(tmpStr)) //Si este substring no esta en el diccionario
                    return false;
                else
                {
                    tmpDic[tmpStr]--; // si esta lo saca del diccionario
                    if (tmpDic[tmpStr] == 0)
                        tmpDic.Remove(tmpStr);
                }
            }
            return true;
        }
    }
}
