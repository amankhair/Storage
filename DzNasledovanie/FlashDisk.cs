using ClassBase;
using System;

namespace MyFlashDisk
{
    class FlashDisk : Storage
    {
        public double speedUsb30;
        public double volume;

        public FlashDisk(string name, string model, double speedUsb30, double volume) : base(name, model)
        {
            this.speedUsb30 = speedUsb30;
            this.volume = volume;
        }

        //получение объема памяти
        public override double GetMemory()
        {
            return volume;
        }

        //копирование данных (файлов/папок) на устройство
        public override void CopyingData()
        {
            //double gb = 565.0;
            //double mb = 780.0;

            //gb = gb * 1024; // 578560
            ////mb = gb / mb; // 741.7

            //volume = volume * 1024; //16384
            //gb = gb / volume; // 35.3125

            //gb = (int)gb;
            //Console.WriteLine(gb);

            int file = 780;
            int flashMemory = 0;
            int flashDisc = 0;
            volume *= 1024;

            while (flashMemory < volume)
            {
                flashMemory += file;

            }
        }

        //получение информации о свободном объеме памяти на устройстве
        public override void GetInformation()
        {

        }

        //получение общей/полной информации об устройстве
        public override void GetDeviceInformation()
        {
            Console.WriteLine("Наименование носителя: " + Name + "\nМодель: " + Model);
            Console.WriteLine("Скорость записи USB 3.0 (Мбайт/сек) : " + speedUsb30 + "\nОбъем памяти (Гб) : " + volume);

        }




    }
}
