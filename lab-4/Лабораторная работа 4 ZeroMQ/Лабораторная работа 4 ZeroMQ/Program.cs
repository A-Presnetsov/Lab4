using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroMQ;

namespace Лабораторная_работа_4_ZeroMQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new ZContext();
            var s = new ZSocket(c, ZSocketType.PUSH);
            s.Bind("tcp://127.0.0.1:1918");
            Console.WriteLine("Сервер запущен.");
            while (true)
            {
                Console.Write("Введите строку: ");
                var message = Console.ReadLine();
                s.SendFrame(new ZFrame(message));
            }
        }
    }
}
