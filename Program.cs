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
            // The lambda expression is a shorter way of representing anonymous method using some special syntax. 
            ///we got the lambda expression: s => s.Age > 12 && s.Age < 20 where : //
            /// s is a parameter, => is the lambda operator and s.Age > 12 && s.Age < 20 is the body expression:
            //Lambda Expression with Multiple Parameters-> 
            //(s, youngAge) => s.Age >= younage
            // Lambda Expression without Parameter
            // It is not necessary to have atleast one parameter in a lambda expression. 
            //The lambda expression can be specify without any parameter also.
            // () => Console.WriteLine("Parameter less lambda expression")
            // pets.Sort();
            var result = pets
                .OrderBy(y => y.Length)//short name , namelss function making some validations/
                .ThenBy( y => y);

            foreach (var element in result) //take all elements in colection pets , ordered by length of the word
            {
                Console.WriteLine(element);
            }

            //Lambda expression can also be assigned to built-in delegates such as Func, Action and Predicate.
        }

        class Student 
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }


        }
    }
}
