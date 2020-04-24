using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak5LV3
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationBuilder Builder = new NotificationBuilder();
            Builder.SetAuthor("Luka Vukadin");
            Builder.SetColor(ConsoleColor.DarkBlue);
            Builder.SetLevel(Category.INFO);
            Builder.SetText("nesta novo");
            Builder.SetTitle("Naslov");
            Builder.SetTime(DateTime.Now);
            ConsoleNotification message = Builder.Build();
            Builder.Display(message);
        }
    }
}
