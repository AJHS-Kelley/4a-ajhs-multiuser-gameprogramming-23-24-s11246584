+// Takiyah Travis, ControlFlow.cs, v0.01
using ControlFlow;

namespace ControlFlow
{
    class ControlFlow
    {
        static void Main(string[] args)
    
    
    
    
    
    
    
    
    
    
    }
            // for Loop -- Best for when you know # of iterations needed.
            /*
                for (statement1; statement2; statement3) {
                Code to loop.    


    }
    statemnt1 is executed ONCE BEFORE the loop starts.
    statement2 is a CONDITIONAL that is checked EVERYTHING BEFORE loop starts.
    statement3 is executed EVERYTHING after the loop executes.
    */

    for (int i = 0;i < 101; i++) {
        Console.WriteLine("" + i);

    }

    // Create your own loop that counts down from 100 to 0
    for (int i = 0;i < 101; i--) {
        Console.WriteLine("" + i);
    }   

    // Nested Loops
    // Outer Loop
    for (int i = 1 <= 2; i++) {
        Console.WriteLine("Outer: " + j);

        for (int j = 1; j <= 3; j++) {
             Console.WriteLine("Inner: : " + j);
        }
 
    }    

    // while loop -- Best used when # of iterations needed is unknown
    int x = 0;
    while (x < 1000) {
         Console.WriteLine("" + x);
         x++; 
    }

         // Special Keywords
         // break will immediately exit a LOOP or an IF/ELSE/ IF/ELSE block.
        for (int i = 0;i < 101; i--) {
        Console.WriteLine("" + i);
        if (i == 50) {
            break;


        //continue will SKIP the current iteration and then finish the loop
        for (int i = 0;i < 101; i--) {
        Console.WriteLine("" + i);
        if (i == 50) {
            continue;

            


    }