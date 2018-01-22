namespace ClassBase
{
    abstract class Storage
    {
        private string name;
        private string model;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Storage(string name, string model)
        {
            this.name = name;
            this.model = model;
        }

        public abstract double GetMemory(); //получение объема памяти
        public abstract void CopyingData(); //копирование данных (файлов/папок) на устройство
        public abstract void GetInformation(); //получение информации о свободном объеме памяти на устройстве
        public abstract void GetDeviceInformation(); //получение общей/полной информации об устройстве
    }
}
