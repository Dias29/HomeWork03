using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 6 значный билет");


            string ticket = Console.ReadLine();
            if (ticket.Length < 0 && ticket.Length > 6)
            {
                throw new IndexOutOfRangeException();
            }
            int Iticket = Convert.ToInt32(ticket);
            Console.WriteLine((Convert.ToInt32(Convert.ToString(ticket)[0].ToString()) +
                               Convert.ToInt32(Convert.ToString(ticket)[1].ToString()) +
                               Convert.ToInt32(Convert.ToString(ticket)[2].ToString())) ==
                              (Convert.ToInt32(Convert.ToString(ticket)[3].ToString()) +
                               Convert.ToInt32(Convert.ToString(ticket)[4].ToString()) +
                               Convert.ToInt32(Convert.ToString(ticket)[5].ToString()))
                ? "Билет счастливый"
                : "Билет не является счастливым");

            Console.ReadLine();
        }
    }
}
