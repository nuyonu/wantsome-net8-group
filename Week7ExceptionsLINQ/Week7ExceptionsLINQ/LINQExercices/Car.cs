namespace Week7ExceptionsLINQ.LINQExercices
{
    public class Car
    {
        public Car(string model, int nrOfWheels, string color, bool isElectric, int year)
        {
            Model = model;
            NrOfWheels = nrOfWheels;
            Color = color;
            IsElectric = isElectric;
            Year = year;
        }

        public string Model { get; set; }

        public int NrOfWheels { get; set; }

        public string Color { get; set; }

        public bool IsElectric { get; set; }

        public int Year { get; set; }

        public override string? ToString()
        {
            return $"Model: {Model}, NrOfWheels: {NrOfWheels}, Color: {Color}, IsElectric: {IsElectric}, Year: {Year}";
        }
    }
}
