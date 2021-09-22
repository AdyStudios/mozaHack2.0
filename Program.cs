using System;
using System.Threading;

namespace MozaHack2_0
{
    class Program
    {
        static string ThankYouText = @"
  _______   _                       _                                   __                                   
 |__   __| | |                     | |                                 / _|                                  
    | |    | |__     __ _   _ __   | | __    _   _    ___    _   _    | |_    ___    _ __                    
    | |    | '_ \   / _` | | '_ \  | |/ /   | | | |  / _ \  | | | |   |  _|  / _ \  | '__|                   
    | |    | | | | | (_| | | | | | |   <    | |_| | | (_) | | |_| |   | |   | (_) | | |                      
    |_|    |_| |_|  \__,_| |_| |_| |_|\_\    \__, |  \___/   \__,_|   |_|    \___/  |_|                      
                                              __/ |                                                          
                                             |___/                                                           
                _                                                                                            
               (_)                                                                                           
  _   _   ___   _   _ __     __ _                                                                            
 | | | | / __| | | | '_ \   / _` |                                                                           
 | |_| | \__ \ | | | | | | | (_| |                                                                           
  \__,_| |___/ |_| |_| |_|  \__, |                                                                           
                             __/ |                                                                           
                            |___/                                                                            
  __  __  ____ ______         _    _          _____ _  __               
 |  \/  |/ __ \___  /   /\   | |  | |   /\   / ____| |/ /               
 | \  / | |  | | / /   /  \  | |__| |  /  \ | |    | ' /   _____  _____ 
 | |\/| | |  | |/ /   / /\ \ |  __  | / /\ \| |    |  <   / _ \ \/ / _ \
 | |  | | |__| / /__ / ____ \| |  | |/ ____ \ |____| . \ |  __/>  <  __/
 |_|  |_|\____/_____/_/    \_\_|  |_/_/    \_\_____|_|\_(_)___/_/\_\___|

";

    static string Methods = @"
    [01] Brute Force [02] S.M.A.R.T
    [03] Pswd file   [04] General";
        static void Main(string[] args)
        {
            System.Random random = new System.Random(); 
            //Console settings
            Console.Title = "Kréta hack";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            //Program start
            Console.WriteLine("Welcome to the Moza Hack\n");
            Loading(10);
            Thread.Sleep(random.Next(1000, 2000));
            //Console.WriteLine("WARNING: No one should take this seriously!\n");
            Console.WriteLine("\n\n What method do you want to use (enter the number)?\n" + Methods + "  ");
            string methodNum = Console.ReadLine();
            Console.WriteLine(methodNum);
            string methodName = "";
            if(methodNum == "1" ||methodNum == "01"){
                methodName = "Brute Force";
            }
            if(methodNum == "2" ||methodNum == "02"){
                methodName = "S.M.A.R.T";
            }
            if(methodNum == "3" ||methodNum == "03"){
                methodName = "Pswd file";
            }
            if(methodNum == "4" ||methodNum == "04"){
                methodName = "General";
            }
            /*if(methodNum != "1" ||methodNum != "01" || methodNum != "2" ||methodNum != "02" || methodNum != "3" ||methodNum != "03" ||methodNum != "4" ||methodNum != "04"){
                Console.WriteLine("Not a valid number, exiting MozaHack2.0.exe...\n Press any key the exit...");
                Console.ReadKey();
                return;
            }*/
            Console.WriteLine("\n" + methodName + " selected.");
            ASCIIloading(10);
            Thread.Sleep(random.Next(1000, 1500));

            Console.Write("\nWhat is your Moza username (inculding spaces and special characters): ");
            string username = Console.ReadLine();
            Console.Write("\nIs this your username: " + username + "? [Y/N]: ");
            string confirmation = Console.ReadLine();
            if(confirmation == "Y" || confirmation == "y"){
                HackKreta(methodName);
            }
            else{
                Console.WriteLine("Not a valid number, exiting MozaHack2.0.exe...\n Press any key the exit...");
                Console.ReadKey();
                return;
            }

        }
        static void Loading(int time){
            ConsoleUtility.WriteProgressBar(0);
            for (var i = 0; i <= 100; ++i)
            {
                ConsoleUtility.WriteProgressBar(i,true);
                Thread.Sleep(time);
            }
            Console.WriteLine("\n");
        }
        static void ASCIIloading(int time){
            ConsoleUtility.WriteProgress(0);
            for (var i = 0; i <= time; ++i)
            {
                ConsoleUtility.WriteProgress(i, true);
                Thread.Sleep(50);
            }
        }
        static void HackKreta(string methodName){
            System.Random random = new System.Random(); 
            Console.WriteLine("\n\nLaunching the Moza Hack...");
            Loading(100);
            Console.WriteLine("\n Checking connection");
            Thread.Sleep(random.Next(2000, 4000));
            Console.WriteLine("\n Connecting to http://mozahackservices.com");
            ASCIIloading(20);
            Console.WriteLine("\nConnection established!");
            Thread.Sleep(random.Next(1000, 1500));
            Console.WriteLine("\nLoading resources");
            Loading(40);
            Console.WriteLine("\n\nDone!");
            Thread.Sleep(random.Next(1000, 2000));
            Console.Write("\nPlease enter what grade you want to replace your current grades with: ");
            string grade = Console.ReadLine();
            Console.Write("\nWarning! All your grades will be replaced with " + grade + ". Confirm [Y/N]: ");
            string confirmation = Console.ReadLine();
            if(confirmation == "N" || confirmation == "n") return;
            Console.WriteLine("\nStarting" + methodName + "process: (%appdata%/mozahack.cs");
            ASCIIloading(10);
            Console.WriteLine("Starting connection to moza hacking services");
            ASCIIloading(20);
            Console.WriteLine("\n\nSuccesful connection!\nDeploying hack");
            Loading(20);
            Console.WriteLine("\n\nEditing moza registry files");
            Loading(30);
            Console.WriteLine("\n\nDone!\n\nBrutefrocing passwords form pswd.txt");
            Loading(100);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n Succesful attack!");
            Thread.Sleep(random.Next(1000, 1500));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(ThankYouText);
            Console.WriteLine("\n Press any key the exit...");
            Console.ReadKey();
            return;
            
        }
    }
}
