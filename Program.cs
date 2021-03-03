using System;
using System.Collections.Generic;

namespace dictinory_odev
    {
    class Program
        {
        static void Main(string[] args)
            {
            List<string> sehirler = new List<string>();
            sehirler.Add("Tohat");


            myList<string> sehirler2 = new myList<string>();
            sehirler2.Add("Diyarbakır");
            }
            class myList<T>
            {
            T[] _array;
            T[] _tempArray;
                
            public void Add(T item)
                {
                _tempArray = _array;
                _array  = new  T[_array.Length + 1];
                }

            }
                
            }
        }
    
