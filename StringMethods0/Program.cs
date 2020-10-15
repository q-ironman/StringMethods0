using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string word;string oldstr;string newstr;  

            
            string array_size;int array_size_int;
            Console.WriteLine("Kaç karakter silmek istiyorsunuz");
            array_size = Console.ReadLine();
            array_size_int = Convert.ToInt32(array_size);
            char[] char2remove = new char[array_size_int];
            Console.WriteLine("silmek istediğiniz karakterleri giriniz");
            for(int i = 0; i < array_size_int; i++)
            {
                char2remove[i] = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            word = Console.ReadLine();
            Console.WriteLine(NewTrimStart(word, char2remove));*/
            /*Console.WriteLine(NewTrimStart("***aaaaabcbbbba",'a','*'));
            Console.WriteLine(NewTrimStart("    kjfjsdknsj    1"));
            Console.WriteLine(NewTrimEnd("aaabbkmsfdklmaaabbbb",'a','b'));
            Console.WriteLine(NewTrimEnd("          cdknfskdnfskn      "));
            Console.WriteLine(NewTrim("aabbbhfjdfaabbjfddbbbbaa",'a','b'));
            Console.WriteLine(NewTrim("    dsfnsjfsfn    "));*/

            string word =("Babam bana araba aldı hem de sarı renkli araba");
            Console.WriteLine(NewReplace(word, "araba", "tır"));
            //Console.WriteLine(NewTrimStart("aaaaaaandfvndaaddkaaaaa",'a'));
            
            
            Console.ReadLine();
        }

        static string NewTrimStart(string word, params char[] charToRemove)
        {
            bool exists;
            int i = 0;
            for (; i < word.Length; i++)
            {
                exists = false;
                for (int j = 0; j < charToRemove.Length; j++)
                {
                    if (word[i] == charToRemove[j])
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    break;
                }
            }

            StringBuilder new_str = new StringBuilder();
            for (int k = i; k < word.Length; k++)
            {
                new_str.Append(word[k]);
            }
            return new_str.ToString();

        }
        static string MyReplace(string word,string oldstr,string newstr)
        {
            StringBuilder sb = new StringBuilder();
            int length_word = word.Length;
            int length_oldstr = oldstr.Length;
            int length_newstr = newstr.Length;
            int match_counter = 0;
            int oldstr_start = 0;
            int oldstr_pos_number;
            int oldstr_pos_Length=0;
            ArrayList oldstr_pos = new ArrayList();
            for (int i = 0;i < length_word; i++)
            {
                int k = i;
                for (int j = 0;j<length_oldstr;j++)
                {
                    if (word[k] == oldstr[j])
                    {
                        k += 1;
                        match_counter += 1;
                        if (match_counter == length_oldstr)
                        {
                            Console.WriteLine("We have a match");
                            oldstr_pos_number=k-length_oldstr;
                            oldstr_pos.Add(oldstr_pos_number);
                           
                        }
                        
                    }
                }
                match_counter = 0;
            }
            oldstr_pos_Length = oldstr_pos.Count;
            int w_counter = 0;
            int[] myArr = (int[])(oldstr_pos.ToArray(typeof(int)));
            for (int l = 0;l<oldstr_pos_Length;l++)
            {
                
                
                
                
                while (!(w_counter==myArr[l]))
                {
                    sb.Append(word[w_counter]);
                    w_counter++;
                }
                sb.Append(newstr);
                w_counter += length_oldstr;
                

            }
            if (w_counter < length_word)
            {
                for(int z = w_counter;z<length_word;z++)
                {
                    sb.Append(word[z]);
                }
            }
            
            
            
            return sb.ToString() ;
        }
        static string NewReplace(string word,string oldstr,string newstr)
        {
            StringBuilder new_str = new StringBuilder();
            int word_length = word.Length;
            int oldstr_length = oldstr.Length;
            int k = 0;
            int i = 0;
            bool match=false;
            for(; i < word_length; i++)
            {
                k = i;
                for(int j = 0; j < oldstr_length; j++)
                {
                    if (word[k] == oldstr[j])
                    {
                        match = true;
                        k += 1;
                    }
                    else
                    {
                        match = false;                        
                        break;
                    }
                }
                if (match)
                {
                    new_str.Append(newstr);
                    i += oldstr_length - 1;
                }
                else 
                {
                    new_str.Append(word[i]);
                }

            }
            
            
            
            
            
            return new_str.ToString();
        }
        static string MyReplace(string word,char oldchr,char newchr)
        {
            int a;
            a=word.Length;            
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < a; i++)
            {
                
                if (word[i] == oldchr)
                {

                    sb.Append(newchr) ;
                }
                else
                { sb.Append(word[i]); 
                }
                
            }
            return sb.ToString() ;
        }
        static string ReverseStr(string word)
        {
           
            StringBuilder sb = new StringBuilder();
            for(int i = word.Length-1;i>=0;i--)
            {
                sb.Append(word[i]);
                
            }
            return sb.ToString();
        }
        static string MyClone(string word)
        {
            return word;
        }
        static string NewTrimStart(string word)
        {
            return NewTrimStart(word, ' ');
        }
        static string NewTrimEnd(string word, params char[] charToRemove)
        {
            return ReverseStr(NewTrimStart(ReverseStr(word), charToRemove));
        }
        static string NewTrimEnd(string word)
        {
            return NewTrimEnd(word, ' ');
        }
        static string NewTrim(string word, params char[] charToRemove)
        {
            return NewTrimEnd(NewTrimStart(word, charToRemove), charToRemove);
        }
        static string NewTrim(string word)
        {
            return NewTrim(word, ' ');
        }
        

    }
}
