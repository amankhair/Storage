using ClassBase;
using MyDvdDisc;
using MyFlashDisk;
using MyHddDisc;
using System;

namespace DzNasledovanie
{
    class Program
    {

        static void Main(string[] args)
        {
            Storage[] storage = new Storage[3];
            storage[0] = new FlashDisk("Transcend", "TC12345", 12, 16);
            storage[1] = new DvdDisc("Sharp", "DVD-R", 1.32, 4.7);
            storage[2] = new HddDisc("Toshiba", "T2890", 480, 4, 1);


            foreach (Storage s in storage)
            {
                s.GetDeviceInformation();
                Console.WriteLine("\n");
            }

            int option = 0;

            option = Int32.Parse(Console.ReadLine());

            Console.WriteLine("1. Информация об устроиствах" +
                              "2. Pасчет общего количества памяти всех устройств\n" +
                              "3. Kопирование информации на устройства и расчет времени необходимого для копирования\n" +
                                  "\t ");

            switch (option)
            {
                case 1:
                    {
                        break;
                    }
            }
        }





    }
}
