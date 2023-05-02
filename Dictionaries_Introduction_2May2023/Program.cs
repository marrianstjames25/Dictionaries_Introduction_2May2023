using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Security.Cryptography;
using System.Linq.Expressions;

namespace Dictionaries_Introduction_2May2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionaries in c#

           
            Dictionary <int,string> d_ = new Dictionary<int,string>();
            //adding elements 
            d_.Add(1, "Programming");
            d_.Add(2, "Programming");
            d_.Add(3, "Programming");
            d_.Add(4, "Programming");
            d_.Add(5, "Programming");
            d_.Add(6, "Programming");


            //Print the dictionary 
            foreach (KeyValuePair<int,string> item in d_)
            {
                Console.WriteLine($"{item.Key},{item.Value}");


            }

            Dictionary<int, Person> d_2 = new Dictionary<int, Person>();
            //adding elements 
            Person p1 = new Person("Jack");
            d_2[1] = p1;
         

            // d_.Clear();
            d_.Remove(1);
            
            //Update the dictionary value with a class
            d_2[1].name = "John";

            //Without a class
            d_[1] = "New Update";
        }

        class Person
        {
            public string name { get; set; }

            public Person(string name)
            {
                this.name = name;
            }   
        }
    }
}
