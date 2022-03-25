using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTests.LevelThree
{
    public class LevelThree
    {
        public string Execute(string command)
        {
            var idx = command.IndexOf(' ');
            string cmd2 = command.Substring(0, idx);
            switch (cmd2)
            {
                case "Hello":
                    Console.WriteLine("Hello, " + command.Substring(idx + 1), ", and welcome to the micro-app LevelThree! What can I do for you?");
                    break;
                case "Add":
                    return int.Parse(command.Substring(idx + 1, command.IndexOf(' ', idx + 1) - idx - 1)) + int.Parse(command.Substring(command.IndexOf(' ', idx + 1) + 1)) + "";
                case "Print":
                    var svc = new PrinterService();
                    svc.PrintFile(command.Substring(idx + 1));
                    break;
                default:
                    Console.WriteLine("Error, command " + cmd2 + " not found");
                    break;
            }
            return "";
        }
    }

    internal class PrinterService
    {
        public void PrintFile(string filename)
        {
            Console.WriteLine("Printing file " + filename + " on the printer");
        }
    }
}
