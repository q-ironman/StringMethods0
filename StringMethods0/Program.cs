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
            string word;
            

            /*word = Console.ReadLine();
            oldstr = Console.ReadLine();
            newstr = Console.ReadLine();*/
            //word = Console.ReadLine();


            /* word = Console.ReadLine();
             Console.WriteLine(MyTrim(word));
            Console.WriteLine("Program bitti");*/
            /*word = Console.ReadLine();
            trmchr = Console.ReadLine();
            Console.WriteLine(MyTrimchr(word,trmchr));*/
            /*word = Console.ReadLine();
            trmchr = Console.ReadLine();
            Console.WriteLine(MyTrimStart(word, trmchr));*/
            /*word = Console.ReadLine();
            trmchr = Console.ReadLine();
            Console.WriteLine(MyTrimEnd(word, trmchr));*/
            /*word = Console.ReadLine();
            Console.WriteLine(MyClone(word));*/
            /*char oldchr; char newchr;
            word = Console.ReadLine();
            Console.WriteLine("Değiştirmek istediğiniz karakteri giriniz:");
            oldchr = Console.ReadKey().KeyChar;
            Console.WriteLine("\nYerleştirmek istediğiniz karakteri giriniz:");
            newchr = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine(MyReplaceChr(word, oldchr, newchr));*/
            
            Console.ReadLine();

        }
        static string MyReplaceStr(string word,string oldstr,string newstr)
        {
            
            
            
            
            return null;
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
        static string MyTrim(string word)
        {
            string a;
            int c = 0;
            a = word[0].ToString();
            int i = 0;
            if ( a == " ")
            {
                for(i=0;i<word.Length;i++)
                {
                    string b;
                    b = word[i].ToString();
                    if (b == " ")
                    {
                        
                        c += 1;
                        Console.WriteLine(c);
                    }
                    else
                    {
                        break;
                    }
                }
                word = word.Remove(0, c);
                return word;

            }

            else
            {
                return word;
            }

        }
        static string MyTrimchr(string word,string chr)
        {
            string firstchr;string lastchr;
            int c = 0;
            int c1 = 0;
            int length = word.Length;
            firstchr = word[0].ToString();
            lastchr = word[word.Length - 1].ToString();
            if(firstchr == chr)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    string b;
                    b = word[i].ToString();
                    if (b == chr)
                    {

                        c += 1;
                        
                    }
                    else
                    {
                        break;
                    }
                    
                }
                word = word.Remove(0, c);
                
            }
            if(lastchr==chr)
            {
                word = ReverseStr(word);
                
                for (int i = 0; i < word.Length; i++)
                {
                    string b;
                    b = word[i].ToString();
                    if (b == chr)
                    {

                        c1 += 1;
                        
                    }
                    else
                    {
                        break;
                    }

                }
                word = word.Remove(0, c1);
                word = ReverseStr(word);

            }
            
            else
            {
                return word;
            }



            return word;
        }
        static string ReverseStr(string word)
        {
            string  reversedStr ="";
            for(int i = word.Length-1;i>=0;i--)
            {
                reversedStr += word[i];
            }
            return reversedStr;
        }
        static string MyTrimStart(string word,string chr)
        {
            string a;
            int c = 0;
            a = word[0].ToString();
            int i = 0;
            if (a == chr)
            {
                for (i = 0; i < word.Length; i++)
                {
                    string b;
                    b = word[i].ToString();
                    if (b == chr)
                    {

                        c += 1;
                        Console.WriteLine(c);
                    }
                    else
                    {
                        break;
                    }
                }
                word = word.Remove(0, c);
                return word;

            }

            else
            {
                return word;
            }




            
        }
        static string MyTrimEnd(string word,string chr)
        {
            word = ReverseStr(word);
            word = MyTrimStart(word,chr);
            word = ReverseStr(word);
            return word;
        }
        static string MyClone(string word)
        {
            return word;
        }
    }
}
