using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var pets = new List<string>();

            pets.Add("Gosho");
            pets.Add("Pesho");
            pets.Add("Ivan");
            pets.Add("Balkan");
            pets.Add("Lassie");
            pets.Add("Iggy");
            pets.Add("in");

            // pets.OrderBy(x => x.Length);
            // Use the lambda declaration operator => to separate the lambda's parameter 
            // (input-parameters) => expression
            // Use the lambda declaration operator =>
            // (input-parameters) => { <sequence-of-statements> -> Lambda statemnet inside the curly brackes 

            // pets.Sort();
            var result = pets
                .OrderBy(y => y.Length)//short name , namelss function making some validations/
                .ThenBy( y => y);

            foreach (var element in result) //take all elements in colection pets , ordered by length of the word
            {
                Console.WriteLine(element);
            }

            
        }

        class Student 
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }


        }
    }
}
