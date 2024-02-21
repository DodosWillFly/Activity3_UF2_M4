using System.Runtime.Intrinsics.X86;

namespace Activity3_UF2_M4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo Tecla;
            do
            {

                Console.Clear(); // Limpia la consola. Esto se hace al inicio de cada iteración para asegurar que solo se muestre el menú actual.
                ShowOptions();
                Tecla = Console.ReadKey(); //Declara una variable Tecla de tipo ConsoleKeyInfo, que se utiliza para almacenar la tecla que el usuario presiona.
                Console.Clear();
                switch (Tecla.Key) // Este es un bloque switch que realiza diferentes acciones dependiendo de la tecla que el usuario presionó
                {
                    case ConsoleKey.D1: CuestionariFacebook(); break; 
                    case ConsoleKey.D2: CuestionariGoogle(); break;
                    case ConsoleKey.D3: CuestionariElonMusk(); ; break;

                    default:
                        MsgNextScreen("Error.Prem una tecla per tornar al menu..."); break;
                }
            }
            while (Tecla.Key != ConsoleKey.D0); //este es un bucle do -while que se ejecuta hasta que el usuario presiona la tecla ‘0’.
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
        public static void ShowOptions()
        {
            Console.WriteLine("1. Facebook");
            Console.WriteLine("2. Google");
            Console.WriteLine("3. Elon Musk");
            Console.WriteLine("0. Salir");
        }
        /// <summary>
        ///  Cuestionari de Facebook
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
    }
}