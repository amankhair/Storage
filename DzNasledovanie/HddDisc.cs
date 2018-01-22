using ClassBase;
using System;

namespace MyHddDisc
{
    class HddDisc : Storage
    {
        public double speedUsb20;
        public byte numberOfPartitions;
        public double volumeOfSections;

        public HddDisc(string name, string model, double speedUsb20, byte numberOfPartitions, double volumeOfSections) : base(name, model)
        {
            this.speedUsb20 = speedUsb20;
            this.numberOfPartitions = numberOfPartitions;
            this.volumeOfSections = volumeOfSections;
        }

        //получение объема памяти
        public override double GetMemory()
        {
            return volumeOfSections;
        }

        //копирование данных (файлов/папок) на устройство
        public override void CopyingData()
        {

        }

        //получение информации о свободном объеме памяти на устройстве
        public override void GetInformation()
        {

        }

        //получение общей/полной информации об устройстве
        public override void GetDeviceInformation()
        {
            Console.WriteLine("Наименование носителя: " + Name + "\nМодель: " + Model);
            Console.WriteLine("Скорость записи USB 3.0 (Мбит/сек) : " + speedUsb20 + "\nКоличество разделов: " + numberOfPartitions + "\nОбъем разделов (Гб) : " + volumeOfSections);
        }

    }
}
