using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;

namespace HAnX_RemoteConnect
{
    public class HanxMenu
    {
        // Writes the header for the program, the Bool arg is to decide on clearing the console before printing
        public static void SysHeader(bool clear) {
            //Clears the header if arg "clear" is true
            if(clear){
                Console.Clear();
            }
                
            Console.WriteLine("------------ HAnX Remote Client ------------");
            Console.WriteLine("------------ v1.1.0 By Colassal ------------\n\n");
        }

        // Used to process server replies to the console
        public static void ServerReply(string serverReply) {
            Console.WriteLine("Reply: " + serverReply);
        }

        // Used to create a multiple chouce menu when fed a list of options
        public static void MenuOptions(int optionCount, List<string> options) {
            // Prints out each item in the list to the screen with it's index + 1 as the choice #
            for(var i = 0; i < optionCount; i++) {
                int v = i + 1;
                Console.WriteLine("Enter " + v.ToString() + ") " + options.ElementAt(i));
            }
        }

        // Processes input for multiple choice menu and returns an int = to the menu choice
        public static int MenuSelectNumber() {
            int retVal = 0;
            try {
                retVal = Convert.ToInt32(Console.ReadLine());
                return retVal;
            } catch {
                //I'm to bad at coding, and too lazy to create a proper catch - have fun
                Console.WriteLine("NOT AN INTEGER - CRASHING.");
            }
            return 0;
        }

        // Processes Yes Or No Input as bool 
        public static bool MenuSelectBool(){
            string confirmInput = Console.ReadLine().ToUpper();
            if(confirmInput == "Y" || confirmInput == "YES") {
                return true;
            } else if (confirmInput == "N" || confirmInput == "NO") {
                return false;
            } else {
                return false;
            }
        }

        //Gets the IP input of the switch and returns it as a string after the user confirms the choice
        public static string getSwitchIp() {
            string sysIpAddress;
            SysHeader(true);
            Console.WriteLine("Enter Your Switch IP Address:");
            sysIpAddress = Console.ReadLine();
            Console.WriteLine("Is " + sysIpAddress + " Correct? Y/N");
            if(MenuSelectBool()) {
                return sysIpAddress;
            } else {
                return "NULLIP";
            }
        }

        public static int getSwitchPort() {
            string sysPort;
            int sysPortId = 0;
            SysHeader(true);
            Console.WriteLine("Enter Your Switch Port (Default 5555):");
            sysPort = Console.ReadLine();
            Console.WriteLine("Is " + sysPort + " Correct? Y/N");
            if(MenuSelectBool()) {
                try {
                    sysPortId = Convert.ToInt32(sysPort);
                } catch {
                    Console.WriteLine("NOT AN INT. CRASHING?");
                    Console.ReadKey();
                }
                return sysPortId;
            } else {
                return sysPortId;
            }
        }
    }
}