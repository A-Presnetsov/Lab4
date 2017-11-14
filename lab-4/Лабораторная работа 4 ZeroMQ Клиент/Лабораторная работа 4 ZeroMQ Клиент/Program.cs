using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroMQ;

namespace Лабораторная_работа_4_ZeroMQ_Клиент
{
    class Program
    {
        static void Main(string[] args)
        {
            ZContext c = new ZContext();
            ZSocket s = new ZSocket(c, ZSocketType.PULL);
            s.Connect("tcp://127.0.0.1:1918");
            while (true)
            {
                ZFrame frame = s.ReceiveFrame();
                Console.WriteLine("Сервер прислал строку: " + frame.ReadString());
            }
        }
    }
}
