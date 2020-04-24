using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak4LV3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleNotification message = new ConsoleNotification("Luka Vukadin", "Snjeguljica", "Sedam patuljaka", DateTime.Now, Category.INFO, ConsoleColor.DarkYellow);
            NotificationManager Graditelj = new NotificationManager();

            Graditelj.Display(message);
        }
    }
}


