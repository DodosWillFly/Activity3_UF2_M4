using System.Linq.Expressions;

namespace Activity3_UF2_M4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo Tecla;
            do
            {
                Console.Clear();
                ShowOptions();
                Tecla = Console.ReadKey();
                Console.Clear();
                switch (Tecla.Key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.D5:
                        break;
                    case ConsoleKey.D6:
                        break;
                    case ConsoleKey.D7:
                        Videogames();
                        break;
                    case ConsoleKey.D8:
                        OnePiece();
                        break;
                    case ConsoleKey.D9:
                        VideoGames_2();
                        break;
                }

            }
            while (Tecla.Key != ConsoleKey.D0);

        }
        private static void ShowOptions()
        {
            Console.WriteLine("1. França");
            Console.WriteLine("2. C#");
            Console.WriteLine("3. KdGAJGFKJG");
            Console.WriteLine("4. DoReadAValidTimeStamp");
            Console.WriteLine("5. DoEnterValidDate");
            Console.WriteLine("6. DoTry2EnterValidDate");
            Console.WriteLine("7. VideoGames");
            Console.WriteLine("8. OnePiece");
            Console.WriteLine("9. Videogames_2");
            Console.WriteLine("0. Exit");
        }

        public static void Videogames()
        {
            // Question 1
            Console.WriteLine("Which manga is the Souls Series inspired of?");

            //Answers
            Console.WriteLine("1 - Berserk");
            Console.WriteLine("2 - Re:Zero");
            Console.WriteLine("3 - Sword Art Online");
            Console.WriteLine("4 - Attack on Titan");
            string answer1;
            answer1 = Console.ReadLine();
            bool correctAnswer1 = false;

            // Bucle que no se sale hasta repsonder correctamente la pregunta
            while (!correctAnswer1)
            {

                if (answer1 == "1")
                {
                    Console.WriteLine("CORRECT!");
                    correctAnswer1 = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT! TRY AGAIN");
                    answer1 = Console.ReadLine();
                }

            }

            // Question 2
            Console.WriteLine("Who's the final boss of the Indie Game Undertale in a Evil run");
            bool correctAnswer2 = false;
            // Answers

            Console.WriteLine("1 - Rick&Morty");
            Console.WriteLine("2 - Sans");
            Console.WriteLine("3 - Undyne");
            Console.WriteLine("4 - Flowey");

            string answer2;
            answer2 = Console.ReadLine();

            while (!correctAnswer2)
            {

                if (answer2 == "2")
                {
                    Console.WriteLine("CORRECT!");
                    correctAnswer2 = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT! TRY AGAIN");
                    answer2 = Console.ReadLine();
                }

            }

            // Question 3

            Console.WriteLine("In Baldur's Gate 3, where do Drow usually live?");
            bool correctAnswer3 = false;
            // Answers

            Console.WriteLine("1 - Baldur's Gate");
            Console.WriteLine("2 - Underdark");
            Console.WriteLine("3 - Shadow Cursed Lands");
            Console.WriteLine("4 - Faerun");

            string answer3;
            answer3 = Console.ReadLine();

            while (!correctAnswer3)
            {

                if (answer3 == "2")
                {
                    Console.WriteLine("CORRECT!");
                    correctAnswer3 = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT! TRY AGAIN");
                    answer3 = Console.ReadLine();
                }

            }

            // Question 4 

            Console.WriteLine("Which videogame has released on PS4/PS5 BUT not on PC and gamers reeeeeeeeeeeeeeeeeally want it on PC");
            bool correctAnswer4 = false;

            // Answers

            Console.WriteLine("1 - Hollow Knight");
            Console.WriteLine("2 - Devil May Cry 5");
            Console.WriteLine("3 - World of Warcraft");
            Console.WriteLine("4 - Bloodborne");

            string answer4;
            answer4 = Console.ReadLine();

            while (!correctAnswer4)
            {

                if (answer4 == "4")
                {
                    Console.WriteLine("CORRECT!");
                    correctAnswer4 = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT! TRY AGAIN");
                    answer4 = Console.ReadLine();
                }

            }

            // Question 5

            Console.WriteLine("Why did World of Warcraft had a plague back in Classic Wow?");

            // Answers

            Console.WriteLine("1 - Because of a bug with Pets");
            Console.WriteLine("2 - New patch introduced covid");
            Console.WriteLine("3 - Hunter's pets could bring a boss dissease that was lethal to low level players");
            Console.WriteLine("4 - Zombies attacked the town and could trasnform you into one of them");

            bool correctAnswer5 = false;

            string answer5;
            answer5 = Console.ReadLine();

            while (!correctAnswer5)
            {

                if (answer5 == "3")
                {
                    Console.WriteLine("CORRECT!");
                    correctAnswer5 = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT! TRY AGAIN");
                    answer5 = Console.ReadLine();
                }
            }





        }

        public static void OnePiece()
        {

            // Question 1
            Console.WriteLine("Where has Whitebeard never received an attack?");

            //Answers
            Console.WriteLine("1 - Back");
            Console.WriteLine("2 - Chest");
            Console.WriteLine("3 - Knee");
            Console.WriteLine("4 - Arm");
            string answer1;
            answer1 = Console.ReadLine();
            bool correctAnswer1 = false;

            while (!correctAnswer1)
            {

                if (answer1 == "1")
                {
                    Console.WriteLine("CORRECT!");
                    correctAnswer1 = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT! TRY AGAIN");
                    answer1 = Console.ReadLine();
                }

            }

            // Question 2
            Console.WriteLine("Where do we see Observation Haki for the first time?");
            bool correctAnswer2 = false;
            // Answers

            Console.WriteLine("1 - Punk Hazard");
            Console.WriteLine("2 - Skypea");
            Console.WriteLine("3 - Sabahody");
            Console.WriteLine("4 - Marineford");

            string answer2;
            answer2 = Console.ReadLine();

            while (!correctAnswer2)
            {

                if (answer2 == "2")
                {
                    Console.WriteLine("CORRECT!");
                    correctAnswer2 = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT! TRY AGAIN");
                    answer2 = Console.ReadLine();
                }

            }

            // Question 3

            Console.WriteLine("Who's the first to kill in One Piece?");
            bool correctAnswer3 = false;
            // Answers

            Console.WriteLine("1 - Shanks");
            Console.WriteLine("2 - Blackbeard");
            Console.WriteLine("3 - Zoro");
            Console.WriteLine("4 - Lucky Roo");

            string answer3;
            answer3 = Console.ReadLine();

            while (!correctAnswer3)
            {

                if (answer3 == "4")
                {
                    Console.WriteLine("CORRECT!");
                    correctAnswer3 = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT! TRY AGAIN");
                    answer3 = Console.ReadLine();
                }

            }

            // Question 4 

            Console.WriteLine("Why does Luffy want to be King of the Pirates?");
            bool correctAnswer4 = false;

            // Answers

            Console.WriteLine("1 - To be rich");
            Console.WriteLine("2 - Because it has been his dream since he was little");
            Console.WriteLine("3 - To be the person with the most freedom in the world");
            Console.WriteLine("4 - Because he wants to win agaisnt Shanks");

            string answer4;
            answer4 = Console.ReadLine();

            while (!correctAnswer4)
            {

                if (answer4 == "3")
                {
                    Console.WriteLine("CORRECT!");
                    correctAnswer4 = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT! TRY AGAIN");
                    answer4 = Console.ReadLine();
                }

            }

            // Question 5

            Console.WriteLine("Who's the first wearer of the Straw Hat?");

            // Answers

            Console.WriteLine("1 - Luffy");
            Console.WriteLine("2 - Shanks");
            Console.WriteLine("3 - Roger");
            Console.WriteLine("4 - Buggy");

            bool correctAnswer5 = false;

            string answer5;
            answer5 = Console.ReadLine();

            while (!correctAnswer5)
            {

                if (answer5 == "3")
                {
                    Console.WriteLine("CORRECT!");
                    correctAnswer5 = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT! TRY AGAIN");
                    answer5 = Console.ReadLine();
                }
            }
        }

        public static void VideoGames_2()
        {

            // Question 1
            Console.WriteLine("Which game is never gonna be released?");

            //Answers
            Console.WriteLine("1 - Hollow Knight");
            Console.WriteLine("2 - Bloodborne");
            Console.WriteLine("3 - Hollow Knight: Silksong");
            Console.WriteLine("4 - Helldivers 2");
            string answer1;
            answer1 = Console.ReadLine();
            bool correctAnswer1 = false;

            while (!correctAnswer1)
            {

                if (answer1 == "3")
                {
                    Console.WriteLine("CORRECT!");
                    correctAnswer1 = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT! TRY AGAIN");
                    answer1 = Console.ReadLine();
                }

            }

            // Question 2
            Console.WriteLine("How is it called a game made by less than 10 people, even 1?");
            bool correctAnswer2 = false;
            // Answers

            Console.WriteLine("1 - Indie");
            Console.WriteLine("2 - AAA");
            Console.WriteLine("3 - RPG");
            Console.WriteLine("4 - J-RPG");

            string answer2;
            answer2 = Console.ReadLine();

            while (!correctAnswer2)
            {

                if (answer2 == "1")
                {
                    Console.WriteLine("CORRECT!");
                    correctAnswer2 = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT! TRY AGAIN");
                    answer2 = Console.ReadLine();
                }

            }

            // Question 3

            Console.WriteLine("How many round do you have to win in order to win a Valorant game?");
            bool correctAnswer3 = false;
            // Answers

            Console.WriteLine("1 - 10");
            Console.WriteLine("2 - 15");
            Console.WriteLine("3 - 18");
            Console.WriteLine("4 - 13");

            string answer3;
            answer3 = Console.ReadLine();

            while (!correctAnswer3)
            {

                if (answer3 == "4")
                {
                    Console.WriteLine("CORRECT!");
                    correctAnswer3 = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT! TRY AGAIN");
                    answer3 = Console.ReadLine();
                }

            }

            // Question 4 

            Console.WriteLine("Which company does not want their fans to do anything with their games, mods, ports, songs, etc?");
            bool correctAnswer4 = false;

            // Answers

            Console.WriteLine("1 - Bethesda");
            Console.WriteLine("2 - Larian Studios");
            Console.WriteLine("3 - Nintendo");
            Console.WriteLine("4 - Activision");

            string answer4;
            answer4 = Console.ReadLine();

            while (!correctAnswer4)
            {

                if (answer4 == "3")
                {
                    Console.WriteLine("CORRECT!");
                    correctAnswer4 = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT! TRY AGAIN");
                    answer4 = Console.ReadLine();
                }

            }

            // Question 5

            Console.WriteLine("In Divinity: Original Sin 2 what is the main objective in the game?");

            // Answers

            Console.WriteLine("1 - To become King");
            Console.WriteLine("2 - To kill the BBEG");
            Console.WriteLine("3 - To become a God");
            Console.WriteLine("4 - To travel the world");

            bool correctAnswer5 = false;

            string answer5;
            answer5 = Console.ReadLine();

            while (!correctAnswer5)
            {

                if (answer5 == "3")
                {
                    Console.WriteLine("CORRECT!");
                    correctAnswer5 = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT! TRY AGAIN");
                    answer5 = Console.ReadLine();
                }
            }
        }
    }
}
