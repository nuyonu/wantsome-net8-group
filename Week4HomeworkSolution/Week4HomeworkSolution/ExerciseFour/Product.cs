namespace Week4HomeworkSolution.ExerciseFour
{
    public class Product
    {
        // Fields. Can be encapsulated (make them private)
        // We can use also naming convention like this for fields:
        public string _name;
        public double _price;
        public int _quantity;

        // Constructor
        public Product(string name, double price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        // Getters and setters for the fields
        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public double GetPrice()
        {
            return _price;
        }

        public void SetPrice(double price)
        {
            _price = price;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }
    }
}
