using System;

namespace HelperMethodsPart1and2Davis
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //A method is a block of code that is given a name so that you can call that 
            //name to execute that block of code. It is a great building block for larger
            //applications

            //There are a number of reasons one would want to split code up into multiple parts
            //It's a good idea to never write the same code twice
            //Methods are great for one one would otherwise have to use the same code twice
            //Writing methods would limit the amount of code one would have to change in case a
            //bug or other issue came up
            //There are a number of methods that there available

            //First method is outside of static void main method, but inside the class method

            //A METHOD IS A VERY IMPORANT BUILDING BLOCK OF CODE

            //Below is how you call a method, Note intellisense does not work for a method
            //It is very important how you write the code to call a helper method
            //Position is also very important

            //The "world" will be passed into the second formula string to be combined with the 'hello'
            //As seen below, you can use multiple inputs for a single method

            ///string myValue = superSecretFormula("world");
            string myValue = superSecretFormula("sunshine");
            Console.WriteLine(myValue);
            //The Console.WriteLine can take in a number of different data types
            Console.ReadLine();

        }
        //'private' means the method can only be called within this class
        //The 'static' helps the code in the main method to not be an error
        //When you create a method, you can choose to have it have zero or more input parameters
        //Those parameters would then be used in the method itself(see below)

        //Methods can be reused if need be
        //Note: despite having the same name, the two methods below have different signatures
        //that will be recognized and used differently depending on what is put into the 'myValue'
        //As long as the Methods have data types are different or have different numbers 
        //of parameters, the methods can coexist with the same name(ex: don't have both of them
        //have different string names)

        private static string superSecretFormula()
        {
            //some cool stuff here. DEAL WITH IT
            //use camel case on helper methods too
            return "Hello World!";
            //This return can guarantee the method will return a data type of string
            //This is just a simple example, but the concept is powerful and is a crucial
            //step for building more complex code

            //The data type of the returned value can be found in the method's signature/name
            //Here it will return a string, but the KEYWORD 'void' means a method will not 
            //return any values. Like in the MAIN METHOD, as that method uses a 'void'
            //Void will mean the codes just does it's job and quietly executes it, with no return value
            //FOR NOW: just know 'void' means the function won't return anything
        }

        private static string superSecretFormula(string name)
        {
            return string.Format("Hello, {0}!", name);
        }
    }
}
