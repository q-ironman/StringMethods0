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
            Console.WriteLine(NewTrimStart("***aaaaabcbbbba",'a','*'));
            Console.WriteLine(NewTrimStart("    kjfjsdknsj    1"));
            Console.WriteLine(NewTrimEnd("aaabbkmsfdklmaaabbbb",'a','b'));
            Console.WriteLine(NewTrimEnd("          cdknfskdnfskn      "));
            Console.WriteLine(NewTrim("aabbbhfjdfaabbjfddbbbbaa",'a','b'));
            Console.WriteLine(NewTrim("    dsfnsjfsfn    "));
            
            string word=("arbacarar");
            Console.WriteLine(MyReplace(word, "ar", "bana"));
            Console.ReadLine();
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
            
            
            
            /*for(int i = 0; i < length_word; i++)
            {
                int k = i;
                for (int j =0;j<length_oldstr;j++)
                {
                    if(word[k]==oldstr[j])
                    {
                        k += 1;
                        match_counter += 1;
                        if (match_counter == length_oldstr)
                        {
                            Console.WriteLine("we have a match");
                            oldstr_start = k - length_oldstr;
                            for(int l = 0; l <= oldstr_start; l++)
                            {
                                sb.Append(word[l]);
                                
                            }
                            Console.WriteLine(sb.ToString());
                            for(int m =0; m < length_newstr; m++)
                            {
                                sb.Append(newstr[m]);
                            }
                            Console.WriteLine(sb.ToString());
                            int after_newstr=oldstr_start+length_newstr;
                            //int new_word_length = length_word + length_newstr - length_oldstr;
                            for (int n  = after_newstr;n<length_word ;n++) 
                            {
                                sb.Append(word[n]);
                            }
                            Console.WriteLine(sb.ToString());

                        }
                    }
                }
            }*/
            /*int length_word = word.Length;
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
                
            }*/






            return sb.ToString() ;
        }
        static string MyReplace(string word,char oldchr,char newchr)
        {
            int a;

            a=word.Length;
            
            //char[] word1 = new char[a];
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
        static string NewTrimStart(string word, params char[] charToRemove)
        {


            int length_word = word.Length;
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

                new_str.Append(word[i + counter]);
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

    }
}
