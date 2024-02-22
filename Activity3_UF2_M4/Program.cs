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
                    case ConsoleKey.D1: CuestionariCyber(); break;
                    case ConsoleKey.D2: CuestionariComputers(); break;
                    case ConsoleKey.D3: CuestionariNetworks(); break;
                    default:
                        MsgNextScreen("Error.Prem una tecla per tornar al menu..."); break;
                }
            }
            while (Tecla.Key != ConsoleKey.D0);
        }
        public static void MsgNextScreen(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        public static void ShowOptions()
        {
            Console.WriteLine("1. CyberSecuity");
            Console.WriteLine("2. Google");
            Console.WriteLine("3. Elon Musk");
            Console.WriteLine("0. Salir");
        }
        /// <summary
        ///  Cuestionari de CyberSecuity
        /// </summary>
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