using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;

namespace Activity3_UF2_M4
{
    internal class Program
    {
        /// <summary>
        /// questionary main options
        /// </summary>
        /// <param name="args"></param>
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
                        CuestionariNetworks();
                        break;
                    case ConsoleKey.D5:
                        CuestionariComputers();
                        break;
                    case ConsoleKey.D6:
                        CuestionariCyber();
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
            Console.WriteLine("4. CuestionariNetworks");
            Console.WriteLine("5. CuestionariComputers");
            Console.WriteLine("6. CuestionariCyber");
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
        /// <summary>
        /// Aquest mètode mostra un missatge a l'usuari i després fa una pausa en l'execució del programa fins que l'usuari prem una tecla.
        /// </summary>
        /// <param name="message">El missatge que es mostrarà a l'usuari.</param>
        public static void MsgNextScreen(string message)
        {
            // Mostra el missatge a l'usuari
            Console.WriteLine(message);
            // Espera que l'usuari premi una tecla per continuar
            Console.ReadKey();
        }
        /// <summary>
        /// This function is to show the options of the program
        /// </summary>

        public static void CuestionariFacebook()
        { // mostra el quiestionari
            Console.WriteLine("Cuestionari de Facebook");
            // Pregunta 1
            Console.WriteLine("1. Quina empresa va fundar Mark Zuckerberg?");
            Console.WriteLine("   a) Google");
            Console.WriteLine("   b) Facebook");
            Console.WriteLine("   c) Amazon");
            Console.WriteLine("   d) Apple");
            // Declara una variable per emmagatzemar la resposta de l'usuari

            Console.Write("Introdueix la teva elecció (a/b/c/d): ");
            string respostaUsuari1;
            respostaUsuari1 = Console.ReadLine();
            if (respostaUsuari1 == "b")
            {
                Console.WriteLine("Correcte");
            }
            else
            {
                Console.WriteLine("Fals");
            }

            // Pregunta 2
            Console.WriteLine("2. Qui és el CEO actual de Facebook?"); //jsdbckjbsdcb jsb
            Console.WriteLine("   a) Mark Zuckerberg");
            Console.WriteLine("   b) Jeff Bezos");
            Console.WriteLine("   c) Sundar Pichai");
            Console.WriteLine("   d) Tim Cook");
            // Declara una variable per emmagatzemar la resposta de l'usuari

            Console.Write("Introdueix la teva elecció (a/b/c/d): ");

            string respostaUsuari2;
            respostaUsuari2 = Console.ReadLine();
            if (respostaUsuari2 == "a")
            {
                Console.WriteLine("Correcte");
            }
            else
            {
                Console.WriteLine("Fals");
            }

            // Pregunta 3
            Console.WriteLine("3. Quina funció permet als usuaris expressar la seva aprovació en una publicació?");
            Console.WriteLine("   a) M'agrada");
            Console.WriteLine("   b) Compartir");
            Console.WriteLine("   c) Comentar");
            Console.WriteLine("   d) Reaccionar");
            // Declara una variable per emmagatzemar la resposta de l'usuari

            Console.Write("Introdueix la teva elecció (a/b/c/d): ");
            string respostaUsuari3;
            respostaUsuari3 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari3 == "a")
            {
                Console.WriteLine("Correcte");
            }
            else
            {
                Console.WriteLine("Fals");
            }
            // Pregunta 4
            Console.WriteLine("4. Quina característica de Facebook permet als usuaris compartir fotos i vídeos que desapareixen després d'un temps?");
            Console.WriteLine("   a) Publicacions");
            Console.WriteLine("   b) Històries");
            Console.WriteLine("   c) Grups");
            Console.WriteLine("   d) Pàgines");
            // Declara una variable per emmagatzemar la resposta de l'usuari

            Console.Write("Introdueix la teva elecció (a/b/c/d): ");
            string respostaUsuari4;
            respostaUsuari4 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari4 == "b")
            {
                Console.WriteLine("Correcte");
            }
            else
            {
                // Si la resposta és incorrecta, mostra un missatge d'error
                Console.WriteLine("Fals");
            }
            // Pregunta 5
            Console.WriteLine("5. Quina de les següents opcions NO és una característica de Facebook?");
            Console.WriteLine("   a) Events");
            Console.WriteLine("   b) Messenger");
            Console.WriteLine("   c) Watch");
            Console.WriteLine("   d) LinkedIn");
            Console.Write("Introdueix la teva elecció (a/b/c/d): ");
            string respostaUsuari5;
            respostaUsuari5 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari5 == "d")
            {
                Console.WriteLine("Correcte");
            }
            else
            {
                // Si la resposta és incorrecta, mostra un missatge d'error
                Console.WriteLine("Fals");
            }
        }
        /// <summary>
        ///  Cuestionari de Google
        /// </summary>

        public static void CuestionariGoogle()
        {
            Console.WriteLine("Cuestionari de Google");
            // Pregunta 1
            Console.WriteLine("1. Quin motor de cerca és propietat de Google?");
            Console.WriteLine("   a) Bing");
            Console.WriteLine("   b) Yahoo");
            Console.WriteLine("   c) Google");
            Console.WriteLine("   d) DuckDuckGo");
            // Declara una variable per emmagatzemar la resposta de l'usuari

            Console.Write("Introdueix la teva elecció (a/b/c/d): ");
            string respostaUsuari1;
            respostaUsuari1 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari1 == "c")
            {
                // Si la resposta és correcta, mostra un missatge de confirmació
                Console.WriteLine("Correcte");
            }
            else
            {
                // Si la resposta és incorrecta, mostra un missatge d'error
                Console.WriteLine("Fals");
            }

            // Pregunta 2
            Console.WriteLine("2. Quina empresa desenvolupa el sistema operatiu Android?");
            Console.WriteLine("   a) Microsoft");
            Console.WriteLine("   b) Apple");
            Console.WriteLine("   c) Google");
            Console.WriteLine("   d) Samsung");
            // Declara una variable per emmagatzemar la resposta de l'usuari

            Console.Write("Introdueix la teva elecció (a/b/c/d): ");
            string respostaUsuari2;
            respostaUsuari2 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari2 == "c")
            {
                // Si la resposta és correcta, mostra un missatge de confirmació

                Console.WriteLine("Correcte");
            }
            else
            {
                // Si la resposta és incorrecta, mostra un missatge d'error

                Console.WriteLine("Fals");
            }

            // Pregunta 3
            Console.WriteLine("3. Quin navegador web és desenvolupat per Google?");
            Console.WriteLine("   a) Firefox");
            Console.WriteLine("   b) Safari");
            Console.WriteLine("   c) Chrome");
            Console.WriteLine("   d) Edge");
            // Declara una variable per emmagatzemar la resposta de l'usuari

            Console.Write("Introdueix la teva elecció (a/b/c/d): ");
            string respostaUsuari3;
            respostaUsuari3 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari3 == "c")
            {
                // Si la resposta és correcta, mostra un missatge de confirmació

                Console.WriteLine("Correcte");
            }
            else
            {
                // Si la resposta és incorrecta, mostra un missatge d'error

                Console.WriteLine("Fals");
            }
            // Pregunta 4
            Console.WriteLine("4. Quina aplicació de Google s'utilitza per crear i editar documents de text?");
            Console.WriteLine("   a) Google Sheets");
            Console.WriteLine("   b) Google Slides");
            Console.WriteLine("   c) Google Docs");
            Console.WriteLine("   d) Google Forms");
            // Declara una variable per emmagatzemar la resposta de l'usuari

            Console.Write("Introdueix la teva elecció (a/b/c/d): ");
            string respostaUsuari4;
            respostaUsuari4 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari4 == "c")
            {
                // Si la resposta és correcta, mostra un missatge de confirmació

                Console.WriteLine("Correcte");
            }
            else
            {
                // Si la resposta és incorrecta, mostra un missatge d'error

                Console.WriteLine("Fals");
            }
            // Pregunta 5
            Console.WriteLine("5. Quina de les següents opcions NO és un producte de Google?");
            Console.WriteLine("   a) YouTube");
            Console.WriteLine("   b) Google Photos");
            Console.WriteLine("   c) Microsoft Word");
            Console.WriteLine("   d) Google Translate");
            // Declara una variable per emmagatzemar la resposta de l'usuari

            Console.Write("Introdueix la teva elecció (a/b/c/d): ");
            string respostaUsuari5;
            respostaUsuari5 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari5 == "c")
            {
                // Si la resposta és correcta, mostra un missatge de confirmació

                Console.WriteLine("Correcte");
            }
            else
            {
                // Si la resposta és incorrecta, mostra un missatge d'error

                Console.WriteLine("Fals");
            }
        }
        /// <summary>
        ///  Cuestionari de ElonMusk
        /// </summary>
        public static void CuestionariElonMusk()
        {// mostra el quiestionari
            Console.WriteLine("Cuestionari d'Elon Musk");
            // Pregunta 1
            Console.WriteLine("1. Quina empresa està relacionada amb Elon Musk?");
            Console.WriteLine("   a) Tesla");
            Console.WriteLine("   b) SpaceX");
            Console.WriteLine("   c) Amazon");
            Console.WriteLine("   d) Microsoft");
            // Declara una variable per emmagatzemar la resposta de l'usuari

            Console.Write("Introdueix la teva elecció (a/b/c/d): ");
            string respostaUsuari1;
            respostaUsuari1 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari1 == "b")
            {
                // Si la resposta és correcta, mostra un missatge de confirmació

                Console.WriteLine("Correcte");
            }
            else
            {
                // Si la resposta és incorrecta, mostra un missatge d'error

                Console.WriteLine("Fals");
            }
            // Pregunta 2
            Console.WriteLine("2. Quin projecte d'Elon Musk té com a objectiu colonitzar Mart?");
            Console.WriteLine("   a) Tesla Roadster");
            Console.WriteLine("   b) Starship");
            Console.WriteLine("   c) Falcon Heavy");
            Console.WriteLine("   d) Dragon");
            Console.Write("Introdueix la teva elecció (a/b/c/d): ");
            string respostaUsuari2;
            respostaUsuari2 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari2 == "b")
            {
                // Si la resposta és correcta, mostra un missatge de confirmació

                Console.WriteLine("Correcte");
            }
            else
            {
                Console.WriteLine("Fals");
            }

            // Pregunta 3
            Console.WriteLine("3. Quin vehicle elèctric de Tesla és conegut per la seva acceleració impressionant?");
            Console.WriteLine("   a) Model S");
            Console.WriteLine("   b) Model X");
            Console.WriteLine("   c) Model 3");
            Console.WriteLine("   d) Model Y");
            // Declara una variable per emmagatzemar la resposta de l'usuari

            Console.Write("Introdueix la teva elecció (a/b/c/d): ");
            string respostaUsuari3;
            respostaUsuari3 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari3 == "a")
            {
                // Si la resposta és correcta, mostra un missatge de confirmació

                Console.WriteLine("Correcte");
            }
            else
            {
                // Si la resposta és incorrecta, mostra un missatge d'error

                Console.WriteLine("Fals");
            }
            // Pregunta 4
            Console.WriteLine("4. Quina altra empresa fundada per Elon Musk es dedica a la perforació de túnels?");
            Console.WriteLine("   a) The Boring Company");
            Console.WriteLine("   b) Neuralink");
            Console.WriteLine("   c) SolarCity");
            Console.WriteLine("   d) Hyperloop");
            // Declara una variable per emmagatzemar la resposta de l'usuari

            Console.Write("Introdueix la teva elecció (a/b/c/d): ");

            string respostaUsuari4;
            respostaUsuari4 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari4 == "a")
            {
                // Si la resposta és correcta, mostra un missatge de confirmació

                Console.WriteLine("Correcte");
            }
            else
            {
                Console.WriteLine("Fals");
            }
            // Pregunta 5
            // la ultima pregunta 
            Console.WriteLine("5. Quina de les següents opcions NO està relacionada amb Elon Musk?");
            Console.WriteLine("   a) PayPal");
            Console.WriteLine("   b) SolarCity");
            Console.WriteLine("   c) Neuralink");
            Console.WriteLine("   d) Blue Origin");
            // Declara una variable per emmagatzemar la resposta de l'usuari

            Console.Write("Introdueix la teva elecció (a/b/c/d): ");
            string respostaUsuari5;
            respostaUsuari5 = Console.ReadLine();
            if (respostaUsuari3 == "d")
            {
                // Si la resposta és correcta, mostra un missatge de confirmació

                Console.WriteLine("Correcte");
            }
            else
            {
                // Si la resposta és incorrecta, mostra un missatge d'error

                Console.WriteLine("Fals");
            }
        }

        public static void CuestionariCyber()
        {
            Console.WriteLine("CyberSecuity questionary");
            // Pregunta 1
            Console.WriteLine("1. WHAT IS A MALWARE?");
            Console.WriteLine("   a) A PROBLEM OF THE SOFTWARE FROM THE COMPUTER");
            Console.WriteLine("   b) A TIPE OF SOFTWARE USED FOR DAMAGING THE COMPUTER");
            Console.WriteLine("   c) A FABRICATION ERROR OF A COMPUTER");
            Console.WriteLine("   d) A BENEFICIOUS PROGRAM FOR HELPING THE COMPUTER PROCESS");

            Console.Write("Introdueix la teva elecció (a/b/c/d): ");
            string respostaUsuari1;

            respostaUsuari1 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari1 == "b")
            {
                Console.WriteLine("CORRECT");
            }
            else
            {
                Console.WriteLine("FAIL");
            }

            // Pregunta 2
            Console.WriteLine("2. What does the term \"firewall\" refer to in cyber security?");
            Console.WriteLine("   a) A protective suit worn by cybersecurity professionals");
            Console.WriteLine("   b) A physical barrier around computer servers");
            Console.WriteLine("   c) A security system that monitors and controls network traffic");
            Console.WriteLine("   d) Software for preventing computer overheating");
            Console.Write("Introduce your selection: (a/b/c/d): ");
            string respostaUsuari2;
            respostaUsuari2 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari2 == "c")
            {
                Console.WriteLine("CORRECT");
            }
            else
            {
                Console.WriteLine("FAIL");
            }

            // Pregunta 3
            Console.WriteLine("3. What type of software infects a machine, locks the files, then asks for money?");
            Console.WriteLine("   a) Worm");
            Console.WriteLine("   b) Trojan");
            Console.WriteLine("   c) Ransomware");
            Console.WriteLine("   d) Browser Hijacker");
            Console.Write("Introduce your selection: (a/b/c/d): ");
            string respostaUsuari3;
            respostaUsuari3 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari3 == "c")
            {
                Console.WriteLine("CORRECT");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
            // Pregunta 4
            Console.WriteLine("4. What is the primary purpose of a VPN (Virtual Private Network) in cyber security?");
            Console.WriteLine("   a) Speed up internet connection");
            Console.WriteLine("   b) Encrypt and secure communication over the internet");
            Console.WriteLine("   c) Block malicious websites");
            Console.WriteLine("   d) Boost Wi-Fi signal strength");
            Console.Write("Introduce your selection: (a/b/c/d): ");
            string respostaUsuari4;
            respostaUsuari4 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari4 == "b")
            {
                Console.WriteLine("CORRECT");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
            // Pregunta 5
            Console.WriteLine("5. What is a group of computers networked together and used by hackers to steal information called?");
            Console.WriteLine("   a) Rootkit");
            Console.WriteLine("   b) Operating System");
            Console.WriteLine("   c) Botnet");
            Console.WriteLine("   d) DDoS");
            Console.Write("Introduce your selection: (a/b/c/d): ");
            string respostaUsuari5;
            respostaUsuari5 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari5 == "c")
            {
                Console.WriteLine("CORRECT");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
        }
        /// <summary>
        ///  Cuestionari de Ordinadors
        /// </summary>

        public static void CuestionariComputers()
        {
            Console.WriteLine("COMPUTER QUIZ");
            // Pregunta 1
            Console.WriteLine("1. What is the hardware?");
            Console.WriteLine("   a) They are the virtual components of the PC");
            Console.WriteLine("   b) They are the physical components of the PC");
            Console.WriteLine("   c) It is a very well known action movie");
            Console.WriteLine("   d) It is the hard drive and the files it contains");
            Console.Write("Introduce your selection: (a/b/c/d): ");
            string respostaUsuari1;
            respostaUsuari1 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari1 == "b")
            {
                Console.WriteLine("CORRECT");
            }
            else
            {
                Console.WriteLine("FAIL");
            }

            // Pregunta 2
            Console.WriteLine("2. The system unit is composed of...");
            Console.WriteLine("   a) The hard drive and memory");
            Console.WriteLine("   b) The cpu and the pc files");
            Console.WriteLine("   c) Main memory and printer");
            Console.WriteLine("   d) CPU and main memory");
            Console.Write("Introduce your selection: (a/b/c/d): ");
            string respostaUsuari2;
            respostaUsuari2 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari2 == "D")
            {
                Console.WriteLine("CORRECT");
            }
            else
            {
                Console.WriteLine("FAIL");
            }

            // Pregunta 3
            Console.WriteLine("3. Witch of the following peripherals is output?");
            Console.WriteLine("   a) Mouse");
            Console.WriteLine("   b) Keyboard");
            Console.WriteLine("   c) Microphone");
            Console.WriteLine("   d) Hearphones");
            Console.Write("Introduce your selection: (a/b/c/d): ");
            string respostaUsuari3;
            respostaUsuari3 = Convert.ToString(Console.ReadLine());
            if (respostaUsuari3 == "d")
            {
                Console.WriteLine("CORRECT");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
            // Pregunta 4
            Console.WriteLine("4. What is the primary function of a computer's motherboard?");
            Console.WriteLine("   a) Connects all the computer hardware together");
            Console.WriteLine("   b) Stores the computer's operating system");
            Console.WriteLine("   c) Performs calculations");
            Console.WriteLine("   d) Outputs video to the monitor");
            Console.Write("Enter your selection: (a/b/c/d): ");
            string userAnswer6 = Convert.ToString(Console.ReadLine());
            if (userAnswer6 == "a")
            {
                Console.WriteLine("CORRECT");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
            // Pregunta 5
            Console.WriteLine("5. Which of the following is an example of a programming language?");
            Console.WriteLine("   a) HTML");
            Console.WriteLine("   b) CSS");
            Console.WriteLine("   c) Python");
            Console.WriteLine("   d) Microsoft Word");
            Console.Write("Enter your selection: (a/b/c/d): ");
            string userAnswer7 = Convert.ToString(Console.ReadLine());
            if (userAnswer7 == "c")
            {
                Console.WriteLine("CORRECT");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
        }
        /// <summary>
        ///  Cuestionary Networks
        /// </summary>
        public static void CuestionariNetworks()
        {
            Console.WriteLine("NETWORKS AND COMMUNICATIONS QUIZ");
            // Question 1
            Console.WriteLine("1. What does IP stand for in the context of networking?");
            Console.WriteLine("   a) Internet Protocol");
            Console.WriteLine("   b) Internal Protocol");
            Console.WriteLine("   c) Internet Provider");
            Console.WriteLine("   d) Internal Provider");
            Console.Write("Enter your selection: (a/b/c/d): ");
            string userAnswer1 = Convert.ToString(Console.ReadLine());
            if (userAnswer1 == "a")
            {
                Console.WriteLine("CORRECT");
            }
            else
            {
                Console.WriteLine("FAIL");
            }

            // Question 2
            Console.WriteLine("2. Which of the following is a type of network topology?");
            Console.WriteLine("   a) Star");
            Console.WriteLine("   b) Circle");
            Console.WriteLine("   c) Triangle");
            Console.WriteLine("   d) Square");
            Console.Write("Enter your selection: (a/b/c/d): ");
            string userAnswer2 = Convert.ToString(Console.ReadLine());
            if (userAnswer2 == "a")
            {
                Console.WriteLine("CORRECT");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
            // Question 3
            Console.WriteLine("3. What is the main purpose of a router in a network?");
            Console.WriteLine("   a) To provide wireless connectivity");
            Console.WriteLine("   b) To connect multiple networks and route network traffic");
            Console.WriteLine("   c) To store data");
            Console.WriteLine("   d) To provide a user interface for network management");
            Console.Write("Enter your selection: (a/b/c/d): ");
            string userAnswer3 = Convert.ToString(Console.ReadLine());
            if (userAnswer3 == "b")
            {
                Console.WriteLine("CORRECT");
            }
            else
            {
                Console.WriteLine("FAIL");
            }

            // Question 4
            Console.WriteLine("4. What does the 'https' in a URL signify?");
            Console.WriteLine("   a) Hyper Text Transfer Protocol Secure");
            Console.WriteLine("   b) High Transfer Protocol Secure");
            Console.WriteLine("   c) Hyper Text Transfer Protocol Speed");
            Console.WriteLine("   d) High Transfer Protocol Speed");
            Console.Write("Enter your selection: (a/b/c/d): ");
            string userAnswer4 = Convert.ToString(Console.ReadLine());
            if (userAnswer4 == "a")
            {
                Console.WriteLine("CORRECT");
            }
            else
            {
                Console.WriteLine("FAIL");
            }

            // Question 5
            Console.WriteLine("5. What is a firewall in the context of network security?");
            Console.WriteLine("   a) A physical barrier to prevent unauthorized access");
            Console.WriteLine("   b) A software program to protect against viruses");
            Console.WriteLine("   c) A network security system that monitors and controls incoming and outgoing network traffic");
            Console.WriteLine("   d) A component of a computer's operating system");
            Console.Write("Enter your selection: (a/b/c/d): ");
            string userAnswer5 = Convert.ToString(Console.ReadLine());
            if (userAnswer5 == "c")
            {
                Console.WriteLine("CORRECT");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
        }
    }

}

