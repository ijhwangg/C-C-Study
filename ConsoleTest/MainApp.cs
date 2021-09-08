using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
namespace CSharpStudy
{
    public class MainApp
    {
        static void Main()
        {
            TicketOffice WinTech = new TicketOffice();
            TicketSeller hwang = new TicketSeller(WinTech);
            Theater CGV = new Theater(hwang);
        }
    }
}
