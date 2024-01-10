// Takiyah Travis, Program Template, v0.01
using System;

namespace ReviewProject
{
    class ReviewProject
    {
        static void Main(string[] args)
        {
           
           // Declaring and Assigning Variables
           // Integer  -- -2,147,483,438,648 to 2,147,483,438,648
           // Integar = 4 Bytes
           int myInt = 221;

           // Long -- -9,147,483,438,648 to 9,147,483,438,648
           // Long = 8 Bytes
           long myLong = 4724759203857920;

           // Sting
           // 2-bytes PER CHARACTER
           // Must be in Double QUOTES " "
           string myString "I love nachos!";

           // Float -- Staores up to 6-7 decimal didgits.
           // Float = 4 Bytes
           float myFloat = 66.9;

           // Double -- Store up to 15 decimal digits.
           // Double = 8 Bytes
           double myDouble = 6.19476830204792373482D;

           // Boolean -- true / false
           // Boolean = 1 bit
           bool myBool = false;

           // Charaters (char)
           // Single character, in SINGLE QUOTES ' '
           // 2-bytes
           char myChar = 'C';
           
           // Type Casting -- changing one data type to another.
           // IMPLICIT -- happens automatically when going smaller -> larger
           // char -> int -> long -> float -> double

           int myInt = 9;
           double my Double = myInt;
           Console.WriteLine(myDouble);

           // EXPLICIT --  Must be done manually when going larger -> smaller.
           // double -> float -> long -> int -> char
           double exampleDouble = 9.869273502D;
           int myInt = (int) myDouble;

           // Conversation Methods
           Convert.ToString() // String
           string myString "I want to go home, school sucks"; 

           Convert.ToDouble() // Double
           double myDouble = 2.957204865837206;

           Convert.ToInt32() // Integer
           int myInt = 321;

           Convert.ToInt64() // Long
           long myLong = -7,694,380,204,802


        }
    
    }
}