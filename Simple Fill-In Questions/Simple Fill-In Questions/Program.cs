using Simple_Fill_In_Questions;
using Survey;
using System;

namespace Survey
{
    class Data
    {
        public string Name;
        public int Age;
        public string Month;
        public string Flower;

        public void Display()
        {
            //Answers
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("You are: {0}", Age);
            Console.WriteLine("Your favorite flowers are: {0}", Flower);
            Console.WriteLine("You were born in: {0}", Month);

            //Month Birth Signs
            switch (Month)
            {
                case "january":
                    Console.WriteLine("You are a Capricorn.");
                    break;
                case "february":
                    Console.WriteLine("You are a Aquarius.");
                    break;
                case "march":
                        Console.WriteLine("You are an Aries or taurus.");
                    break;
                case "april":
                        Console.WriteLine("You are a Aries.");
                    break;
                case "may":
                        Console.WriteLine("You are a taurus.");
                    break;
                case "june":
                        Console.WriteLine("You are a gemini.");
                    break;
                case "july":
                        Console.WriteLine("You are a cancer.");
                    break;
                case "august":
                        Console.WriteLine("You are a Leo.");
                    break;
                case "september":
                        Console.WriteLine("You are a Virgo.");
                    break;
                case "october":
                        Console.WriteLine("You are a Libra.");
                    break;
                case "november":
                        Console.WriteLine("You are a Scorpio.");
                    break;
                case "december":
                        Console.WriteLine("You are a Sagittarius.");
                    break;
            }
        }
    }
    }
    

    class Program
    {
    public static event Action Posted;

        static void Main(string[] args)
        {
        var Stats = new Stats();
        Stats.Start();

            var data = new Data();
            //Questions
            Console.WriteLine("What is your name?");
            data.Name = TryAnswer();

            Console.WriteLine("What is your age?");
            data.Age = int.Parse(TryAnswer());

            Console.WriteLine("What are your favorite flowers?");
            data.Flower = TryAnswer();

            Console.WriteLine("What month were you born in? (all text must be lowercase)");
            data.Month = TryAnswer();

        if (Posted != null)
         Posted();

            data.Display();

        //Try Again if an accidental enter is pressed
        static string TryAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("You didn't type anything, please try again.");
                return Console.ReadLine();
            }
            return answer;
        }
    }
}
