namespace PizzaApp.WebUI.Services
{
    public class NumbersService
    {
        public NumbersService()
        {
            Numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        }

        public List<int> Numbers { get; set; }
    }
}
