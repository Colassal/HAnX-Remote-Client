using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAnX_RemoteConnect
{
    public class HanxMenu
    {
        public static void SysHeader(bool clear) {
            if(clear){
                Console.Clear();
            }
                
            Console.WriteLine("------------ HAnX Remote Client ------------");
            Console.WriteLine("------------ v1.1.0 By Colassal ------------\n\n");
        }

        public static void ServerReply(string serverReply) {
            Console.WriteLine("Reply: " + serverReply);
        }

        public static void MenuOptions(int optionCount, List<string> options) {
            for(var i = 0; i < optionCount; i++) {
                v = i + 1;
                Console.WriteLine("Enter " + v.ToString() + ") " + options.ElementAt(i));
            }
        }

        public static int MenuSelectNumber() {
            int retVal = 0;
            try {
                retVal = Console.ReadLine().ToInt32();
                return retVal;
            } catch {
                Console.WriteLine("NOT AN INTEGER - CRASHING.");
            }
        }
    }
}