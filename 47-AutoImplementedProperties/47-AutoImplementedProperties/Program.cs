namespace AutoImplementedProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auto-Implemented properties = shortcut when no additional logic is required in the property
            //                               you do not have to define a field for a property
            //                               you only have to write get; and/or set; inside the property

            Car car = new Car("Porsche");

            Console.WriteLine(car.Model);
        }
    }

    class Car
    {
        public String Model { get; set; }

        //String model;

        //public String Model
        //{
        //    get { return model; }
        //    set { model = value; }
        //}

        public Car(String model)
        {
            this.Model = model;
        }
    }
}