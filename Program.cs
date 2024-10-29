// See https://aka.ms/new-console-template for more information

using System;

public class Program
{
    public static void Main(string[] args){
        Write1ThroughN_While(-1);
        Write1ThroughN_While(5);
        Write1ThroughN_While(0);
        
        Write1ThroughN_For(-1);
        Write1ThroughN_For(5);
        Write1ThroughN_For(0);

        WriteNThrough1_While(-1);
        WriteNThrough1_While(5);
        WriteNThrough1_While(0);

        WriteNThrough1_For(-1);
        WriteNThrough1_For(5);
        WriteNThrough1_For(0);

        WriteEvensThrough100();

        FindSum(5);
        FindSum()

    }

    public static void Write1ThroughN_While(int n){
        int x = 0;

        if (n <= 0){
            Console.WriteLine($"{n} is out of range.");
            return; 
            // Return used, as the Console.WriteLine() later on will format everything weird. End the function here.
        }

        while (x < n){
            x++; // If x++ was after write, int x would need to be 1 and x <= n
            Console.Write($"{x} ");
            
        }

        Console.WriteLine(); // formatting purposes, sets up the next line, so the next Console.Write is ready
    }

    public static void Write1ThroughN_For(int n){
        
        if (n <= 0){
            Console.WriteLine($"{n} is out of range.");
            return;
        }

        for (int i = 1; i <= n; i++){
            Console.Write($"{i} ");
        }

        Console.WriteLine();
    }

    public static void WriteNThrough1_While(int n){
        int x = n;
        if (n <= 0){
            Console.WriteLine($"{n} is out of range.");
            return;
        }
        while (x > 0){
            Console.Write($"{x} ");
            x--;
        }

        Console.WriteLine();

    }

    public static void WriteNThrough1_For(int n){
        
        if (n <= 0){
            Console.WriteLine($"{n} is out of range.");
            return;
        }

        for (int i = n; i > 0; i--){
            Console.Write($"{i} ");
        }

        Console.WriteLine();
    }

    public static void WriteEvensThrough100(){
        for (int i = 2; i <= 100; i+=2){
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

    public static void FindSum(int n){
        int sum = 0;

        if (n >= 0){
            for (int i = 1; i <= n; i++){ // could start int i = 0, but useless iteration
            sum = sum + i;
            // Testing - Console.WriteLine($"This is the sum: {sum}");
            }
        } else { // the number is negative, use negative loop
            for (int i = n; i <= 1; i++){
                sum = sum + i;
                // Console.WriteLine($"This is the sum: {sum}");
            }
        }

        Console.WriteLine(sum);
    }

    public static void FindSumOfEvenNumbers(int n){
        int sum = 0;

        if (n > 0){
            for (int i = 0; i <= n; i++){
                if (i % 2 == 0){
                    sum += i;
                }
            }
        } else { // negative loop
            for (int i = n; i < 0; i++){
                if (i % 2 == 0){
                    sum += i;
                }
            }
        }
        Console.WriteLine(sum);
    }

    public static void FindSumOfOddNumbers(int n){
        int sum = 0;

        if (n > 0){
            for (int i = 1; i < n; i++){
                if (i % 2 == 1){
                    sum += i;
                }
            }
        } else { // Negative loop
            for (int i = n; i <= 1; i++){
                if (i % 2 == -1 || i % 2 == 1){
                    sum += i;
                }
            }
        }
        
        Console.WriteLine(sum);
    }

    public static void OutputRightTriangle(int _base){
        if (_base >= 0){
            for(int i = 1; i <= _base; i++){
                Console.WriteLine("");
                for(int u = 0; u < i; u++){
                    Console.Write("▲");
                }
            }
            Console.WriteLine();

        } else { // if base is negative
            for(int i = _base; i <= 0; i++){
                Console.WriteLine("");
                for(int u = i; u < 0; u++){
                    Console.Write("▲");
                }
            }
        }

    }

}