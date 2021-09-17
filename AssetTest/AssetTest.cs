using System;

namespace AssetTest
{
    class AssetTest
    {
        static void Main(string[] args)
        {
            //Exercise 4.11: The Asset Class
            //Create a class called Asset that includes 3 pieces of information 
            //as either instance variables or auto-implemented properties.

            //1. asset name (type string)
            //2. asset value (type double , I prefer doubles to decimals)
            //3. depreciation rate (type double)

            //Your class should have a constructor that initializes the values.
            //Provide a property with a get and set accessor for any instance variable.
            //If the asset value or depreciation rate is negative, the values should remain unchanged.
            //Write a test app called AssetTest that test the class. 
            //Create two objects of Asset and test the class features.


            //1. Create an Object
            Asset asset1 = new Asset("Hotel", 150000, 10);

            //Accessing Object Properties
            Console.WriteLine($"Asset 1 is a {asset1.AssetName}, it's value is {asset1.AssetValue} \n ");

            //Access the Methods
            Console.WriteLine($"The depreciation amount is {asset1.AmtDepreciation()} \n ");
            Console.WriteLine($"The value after depreciation is {asset1.ValueDepreciation()}");

            Console.ReadLine();
        }
    }
}
