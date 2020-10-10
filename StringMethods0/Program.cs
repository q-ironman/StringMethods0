using System;
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
            Console.WriteLine(NewTrimStart("***aaaaabcbbbba",'a','*'));
            Console.WriteLine(NewTrimStart("    kjfjsdknsj    1"));
            Console.WriteLine(NewTrimEnd("aaabbkmsfdklmaaabbbb",'a','b'));
            Console.WriteLine(NewTrimEnd("          cdknfskdnfskn      "));
            Console.WriteLine(NewTrim("aabbbhfjdfaabbjfddbbbbaa",'a','b'));
            Console.WriteLine(NewTrim("    dsfnsjfsfn    "));
            Console.ReadLine();

        }
        static string NewTrimStart(string word, params char[] charToRemove)
        {
            
            
            int length_word=word.Length;
            int char2remove_length = charToRemove.Length;
            int counter = 0;
            int counter1 = 0;
            
            for (int i = 0; i < length_word; i++)
            {
                for (int j = 0; j < char2remove_length; j++)
                {
                    if (word[i] == charToRemove[j])
                    {
                        counter += 1;
                        counter1 += 1;
                    }
                    

                }
                if (counter1 == 0)
                {
                    break;
                }
                counter1 = 0;
            }
            //Console.WriteLine(counter);
            
            StringBuilder new_str = new StringBuilder();
            for (int i = 0; i < length_word - counter; i++)
            {

                new_str.Append(word[i+counter]);
            }
            return new_str.ToString();
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

        static string MyReplaceStr(string word,string oldstr,string newstr)
        {
            int length_word = word.Length;
            int length_oldstr=oldstr.Length;
            string tmp;
            int a = 0;int d = 0; int z = 0;int y =0 ;
            for(int i = 0; i < length_word; i++)
            {
                int k = i;
                for(int j = 0;j<length_oldstr;j++)
                {
                    if(word[k]==oldstr[j])
                    {
                        a += 1;
                        k += 1;
                        y += 1;
                        if (a == length_oldstr)
                        {
                            Console.WriteLine("we have a match");
                            d += 1;
                            //Console.WriteLine(d);

                        }
                        
                    }
                    

                    
                }

                int pos = y - length_oldstr;
                if (pos == 0)
                {
                    tmp = newstr + word.Substring(pos+length_word-length_oldstr);
                    Console.WriteLine(tmp);
                    z += 1;
                }
                
            }
           



            return null ;
        }
        static char[] MyReplaceChr(string word,char oldchr,char newchr)
        {
            int a;
           
            a=word.Length;
            
            char[] word1 = new char[a];

            for (int i = 0; i < a; i++)
            {
                
                if (word[i] == oldchr)
                {
                    
                    word1[i] = newchr;
                }
                else
                { word1[i] = word[i]; 
                }
                
            }
            return word1;
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
        
    }
}
