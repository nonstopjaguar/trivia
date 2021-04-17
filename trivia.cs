using System;

namespace Trivia_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            // Question 1
            Console.WriteLine("1.) What is my favorite food?");
            Console.WriteLine("\ta. Egg");
            Console.WriteLine("\tb. Fries");
            Console.WriteLine("\tc. Cream Dory");
            
            Console.WriteLine("Kindly type the letter of your answer.");
            string answer = Console.ReadLine();
            if (answer == "a")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer == "b")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }

            // Question 2
            Console.WriteLine("2.) What is my favorite sport?");
            Console.WriteLine("\ta. Basketball");
            Console.WriteLine("\tb. Football");
            Console.WriteLine("\tc. Badminton");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer2 = Console.ReadLine();
            if (answer2 == "b")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer2 == "a")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer2 == "c")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }
            
            // Question 3
            Console.WriteLine("3.) What is my favorite color?");
            Console.WriteLine("\ta. Pink");
            Console.WriteLine("\tb. Black");
            Console.WriteLine("\tc. Red");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer3= Console.ReadLine();
            if (answer3 == "c")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer3== "b")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer3 == "a")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }
            
            // Question 4
            Console.WriteLine("4.) Who is my favorite superhero?");
            Console.WriteLine("\ta. Batman");
            Console.WriteLine("\tb. Iron Man");
            Console.WriteLine("\tc. Shazam");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer4 = Console.ReadLine();
            if (answer4 == "a")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer4 == "b")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer4 == "c")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }
            
            // Question 5
            Console.WriteLine("5.) What ice cream flavor is my favorite?");
            Console.WriteLine("\ta. Strawberry");
            Console.WriteLine("\tb. Avocado");
            Console.WriteLine("\tc. Ube");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer5 = Console.ReadLine();
            if (answer5 == "c")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer5 == "a")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer5 == "b")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }
            
            // Question 6
            Console.WriteLine("6.) Do I smoke?");
            Console.WriteLine("\ta. Yes");
            Console.WriteLine("\tb. No");
            Console.WriteLine("\tc. Maybe");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer6 = Console.ReadLine();
            if (answer6 == "b")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer6 == "a")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer6 == "c")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }
            
            // Question 7
            Console.WriteLine("7.) What is my dream car?");
            Console.WriteLine("\ta. Ferrari");
            Console.WriteLine("\tb. BMW M3 GTR");
            Console.WriteLine("\tc. Porsche Cayman S");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer7 = Console.ReadLine();
            if (answer7 == "c")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer7 == "b")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer7 == "a")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }
            
            // Question 8
            Console.WriteLine("8.) Where do I study?");
            Console.WriteLine("\ta. De La Salle University");
            Console.WriteLine("\tb. University of the Philippines");
            Console.WriteLine("\tc. De La Salle-College of Saint Benilde");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer8 = Console.ReadLine();
            if (answer8 == "c")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer8 == "b")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer8 == "a")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }
            
            // Question 9
            Console.WriteLine("9.) Where do I live?");
            Console.WriteLine("\ta. Atlanta");
            Console.WriteLine("\tb. Bacoor");
            Console.WriteLine("\tc. Quezon City");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer9 = Console.ReadLine();
            if (answer9 == "b")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer9 == "a")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer9 == "c")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }
            
            // Question 10
            Console.WriteLine("10.) Who is my favorite basketball player?");
            Console.WriteLine("\ta. Kobe Bryant");
            Console.WriteLine("\tb. Michael Jordan");
            Console.WriteLine("\tc. Yao Ming");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer10 = Console.ReadLine();
            if (answer10 == "a")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer10 == "b")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer10 == "c")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }
            
            // Question 11
            Console.WriteLine("11.) What is my street?");
            Console.WriteLine("\ta. Purok");
            Console.WriteLine("\tb. Visayas");
            Console.WriteLine("\tc. Bagtikan");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer11 = Console.ReadLine();
            if (answer11 == "c")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer11 == "b")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer11 == "a")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }
            
            // Question 12
            Console.WriteLine("12.) What is my laptop brand?");
            Console.WriteLine("\ta. Asus");
            Console.WriteLine("\tb. HP");
            Console.WriteLine("\tc. Dell");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer12 = Console.ReadLine();
            if (answer12 == "c")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer12 == "b")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer12 == "a")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }
            
            // Question 13
            Console.WriteLine("13.) What is my favorite programming language?");
            Console.WriteLine("\ta. Python");
            Console.WriteLine("\tb. R");
            Console.WriteLine("\tc. C#");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer13 = Console.ReadLine();
            if (answer13 == "a")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer13 == "b")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer13 == "c")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }
            
            // Question 14
            Console.WriteLine("14.) What is my favorite drink?");
            Console.WriteLine("\ta. Smirnoff");
            Console.WriteLine("\tb. Water");
            Console.WriteLine("\tc. Gatorade");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer14 = Console.ReadLine();
            if (answer14 == "b")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer14 == "a")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer14 == "c")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }

            // Question 15
            Console.WriteLine("15.) What brand is my phone?");
            Console.WriteLine("\ta. Samsung");
            Console.WriteLine("\tb. RealMe");
            Console.WriteLine("\tc. Apple");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer15 = Console.ReadLine();
            if (answer15 == "c")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer15 == "a")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer15 == "b")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }
            
            // Question 16
            Console.WriteLine("16.) What is my car?");
            Console.WriteLine("\ta. Land Cruiser");
            Console.WriteLine("\tb. Corolla Altis");
            Console.WriteLine("\tc. L300 FB");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer16 = Console.ReadLine();
            if (answer16 == "b")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer16 == "a")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer16 == "c")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }
            
            // Question 17
            Console.WriteLine("17.) Am I single?");
            Console.WriteLine("\ta. No");
            Console.WriteLine("\tb. Yes");
            Console.WriteLine("\tc. Maybe");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer17 = Console.ReadLine();
            if (answer17 == "a")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer17 == "b")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer17 == "c")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }
            
            // Question 18
            Console.WriteLine("18.) What is my favorite Grand Theft Auto Series?");
            Console.WriteLine("\ta. San Andreas");
            Console.WriteLine("\tb. Vice City");
            Console.WriteLine("\tc. GTA 5");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer18 = Console.ReadLine();
            if (answer18 == "a")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer18 == "b")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer18 == "c")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }
            
            // Question 19
            Console.WriteLine("19.) What is my favorite country?");
            Console.WriteLine("\ta. Japan");
            Console.WriteLine("\tb. Iceland");
            Console.WriteLine("\tc. Colombia");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer19 = Console.ReadLine();
            if (answer19 == "b")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer19 == "a")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer19 == "c")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }
            
            // Question 20
            Console.WriteLine("20.) What is my birthday?");
            Console.WriteLine("\ta. June 3, 2001");
            Console.WriteLine("\tb. July 12, 2001");
            Console.WriteLine("\tc. April 10, 2001");

            Console.WriteLine("Kindly type the letter of your answer.");
            string answer20 = Console.ReadLine();
            if (answer20 == "c")
            {
                Console.WriteLine("You're right!");
                score++;
            }
            else if (answer20 == "b")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else if (answer20 == "a")
            {
                Console.WriteLine("Wrong answer! :(");
            }
            else
            {
                Console.WriteLine("Your answer was not from the given choices.");
            }

           Console.WriteLine($"Thank you for answering my trivia game. \nYour score is: {score}");
            if (score >= 15)
            {
                Console.WriteLine("You're a true friend");
            }
            else if (score < 10)
            {
                Console.WriteLine("Huhuhu sad :<");
            }
        }
    }
}



