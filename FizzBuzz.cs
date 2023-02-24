using System;

namespace WhiteBoardChallenge;

public class program
{
    static void Main(string[] args)
    {
        string ans1 = FizzBuzz.FizzBuzzMethod(3);

        string ans2 = FizzBuzz.FizzBuzzMethod(5);

        string ans3 = FizzBuzz.FizzBuzzMethod(15);

        string ans4 = FizzBuzz.FizzBuzzMethod(4);

        System.Console.WriteLine($"{an1}, {ans2}, {ans3}, {ans4}");
    }
}

public static class FizzBuzz
{
    public static string FizzBuzzMethod(int num)
    {
        if (num % 3 == 0 && num % 5 == 0)
        {
            return "fizzbuzz";
        }
        else if (num % 3 == 0)
        {
            return "fizz";
        }
        else if (num % 5 == 0)
        {
            return "buzz";
        }
        else
        {
            return "No Answer";
        }
    }
}
//when the number is divisible by 3 return the word fizz

//when the number is divisible by 5 return the word buzz

//when the number is divisible by both, return the word fizzbuzz