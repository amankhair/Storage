using ClassBase;
using System;

namespace MyDvdDisc
{
    class DvdDisc : Storage
    {
        public double recSpeed; //скорость записи
        public double singleLayer; //односторонний

        public DvdDisc(string name, string model, double recSpeed, double singleLayer) : base(name, model)
        {
            this.recSpeed = recSpeed;
            this.singleLayer = singleLayer;
        }

        //получение объема памяти
        public override double GetMemory()
        {
            return singleLayer;
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
            Console.WriteLine("Скорость чтения (Мбайт/сек) : " + recSpeed + "\nТип односторонний. Объем памяти (Гб) : " + singleLayer);

        }
    }
}
