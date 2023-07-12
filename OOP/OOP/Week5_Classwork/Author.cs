namespace OOP.Week5_Classwork
{
    public class Author
    {
        private string country;

        public Author(string country, string name, string email)
        {
            Name = name;
            Country = country;
            Email = email;
        }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Country
        {
            get 
            { 
                return country; 
            }
            set 
            { 
                country = value; 
            }
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Email: {Email}, Country: {Country}");
        }
    }
}


/*
 * 
 * For this exercise you should implement get and set accesors for properties.

Create a class Author with one constructor to initialize the following Properties:
- Name
- Email
- Country

Add Print Method (to show all details)
 */