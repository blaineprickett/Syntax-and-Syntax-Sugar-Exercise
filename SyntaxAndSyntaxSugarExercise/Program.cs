﻿namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 9;
            var response = (answer < 9) ? $"{answer} is less than 9" : $"{answer} is greater than or equal to 9";
            Console.WriteLine(response);
        }
    }
}
