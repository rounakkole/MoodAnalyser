// See https://aka.ms/new-console-template for more information
using System;

namespace MoodAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mood analyser");
            HappySad happySad = new HappySad();
            string Result = happySad.AnalysingMood();
            Console.WriteLine(Result);
        }
    }
}
