// Takiyah Travis, Program Template, v0.01
using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
                //Create TWO Strings, Integer, and Float variables.
                string myString1 = "I like animals";
                string myString2 = "I like to sleep";
;
                int myInt1 = 4000;
                int myInt2 = 24;

                float myFloat1 = 0.2F;
                float myFloat2 = 6.0F;

                // Arithetic Operators
                Console.WriteLine(myInt1 + myInt2);
                Console.WriteLine(myString1 + myString2 );
                Console.WriteLine(myFloat1 + myFloat2);
                Console.WriteLine(myInt1 + myInt2);

                Console.WriteLine(myInt1 - myInt2);
                //Console.WriteLine(myString1 - myString2 );
                Console.WriteLine(myFloat1 - myFloat2);
                Console.WriteLine(myInt1 - myInt2);

                Console.WriteLine(myInt1 / myInt2);
                //Console.WriteLine(myString1 / myString2 );
                Console.WriteLine(myFloat1 / myFloat2);
                Console.WriteLine(myInt1 / myInt2);

                Console.WriteLine(myInt1 * myInt2);
                //Console.WriteLine(myString1 * myString2 );
                Console.WriteLine(myFloat1 * myFloat2);
                Console.WriteLine(myInt1 * myInt2);

                // Modulus
                Console.WriteLine("Modulus");
                Console.WriteLine(10 % 2);
                Console.WriteLine(9 % 4);

                // Increment
                int myInt3 = 1;
                myInt3++;
                Console.WriteLine(myInt3);

                // Decrement
                int myInt4 = 2;
                myInt4--;
                Console.WriteLine(myInt4);

                // Assignment Operators
                // = THIS ASSIGNMENT OPERATORS THROW OUT OLD VALUES
                myInt3 = 5;
                
                // this assignment operators keep old values!!
                // +=
                myInt3 += -1;
                // -=
                myInt3 -= 2;
                // *=
                myInt3 *= 3;
                // /=
                myInt3 /= 2;
                Console.WriteLine(myInt3);

                // Comparison Operators
                //Is Equal To
                Console.WriteLine(5 == 4);
                // Greater Than
                Console.WriteLine(3 != 2);
                // Greater Than or Equal To
                Console.WriteLine(5 > 3);
                // Less Than
                Console.WriteLine(-1 > -2);
                //Less Than or Equal To
                Console.WriteLine(1 <= 5);
                //Not Equal To
                
                // Logical Operators
                // And
                Console.WriteLine(3 > 2 && 2 == 3); // True and True = True
                Console.WriteLine(3 > 2 && 5 > 6); // True and False = False
                // Or -- ONE condition must be ture for the whole statement to be true.
                Console.WriteLine(5 < 9 || 5 != 4); // True or True = True
                Console.WriteLine(9 < 10|| 3 > 5); // True or False = True
                // Not -- Find the 'opposite' value.
                Console.WriteLine(!(4 > 3)); // 
    
         }
    
    }
}
