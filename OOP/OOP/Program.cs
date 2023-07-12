using OOP.Week5_Classwork;
using OOP.Week5;

//Student bogdan = new Student();
//bogdan.age = 25;
//bogdan.lastName = "Bogdan";
//bogdan.firstName = "Bogdan";
//bogdan.nrMatricol = 1;

//Console.WriteLine(bogdan.firstName);
//Console.WriteLine(bogdan.lastName);

//Car dacia = new Car("Dacia", "Logan", 2022) 
//{ 
//    color = "white",
//    nrOfSeats = 4
//};
////dacia.model = "Logan";
////dacia.brand = "Dacia";
////dacia.year = 2022;
//dacia.color = "white";
//dacia.nrOfSeats = 4;

//Console.WriteLine($"Model: {dacia.model}, Brand: {dacia.brand}, Year: {dacia.year}, Color: {dacia.color}");

//dacia.ChangeColor("red");
//dacia.year = 2021;

//Console.WriteLine($"Model: {dacia.model}, Brand: {dacia.brand}, Year: {dacia.year}, Color: {dacia.color}");

//string uniqueCode = dacia.GetModelCode();

//Console.WriteLine(uniqueCode);

//Employee alex = new Employee("alex", "alexLastName", "1982323");
////alex.cnp = "1982312312";
//alex.age = 25;
//alex.startDate = new DateOnly(2020, 5, 1);
////alex.firstName = "alex";
////alex.lastName = "alexLastName";
//alex.salary = 1999.99;

//Console.WriteLine($"Last name: {alex.lastName}, First name: {alex.firstName}, Salary: {alex.salary}");

//alex.IncreaseSalaryByAge();

//Console.WriteLine($"Last name: {alex.lastName}, First name: {alex.firstName}, Salary: {alex.salary}");

//Console.WriteLine(alex.age);

//alex.IncreaseAge();

//Console.WriteLine(alex.age);

//alex.IncreaseAge();

//Console.WriteLine(alex.age);



// Exercise 2
//Car honda = new Car(null, 2010, "red", 1000);
//Console.WriteLine(honda.GetModel());
//Console.WriteLine(honda.GetModel2("Dacia"));
//Console.WriteLine(honda.GetMileage());
//honda.Drive();
//Console.WriteLine(honda.GetMileage());
//honda.Drive();
//Console.WriteLine(honda.GetMileage());

// Exercise 4
//Author eminescu = new Author("Mihai Eminescu", "eminescu@eminescu.com", "Romania");
//eminescu.Print();


//Student alexStudent = new Student("Alex", 25);
//alexStudent.AddScore(5);
//alexStudent.AddScore(8);
//alexStudent.AddScore(4);
//alexStudent.AddScore(10);

//Console.WriteLine(alexStudent.GetAverageScore());
//Console.WriteLine(alexStudent.GetMaxScore());
//Console.WriteLine(alexStudent.GetInfo());

//Person AlexPerson = new Person("Alex", "AlexLastName", 25, "Malee");


//Account alexAccount = new Account();

//Console.WriteLine($"Account balance: {alexAccount.GetBalance()}");

//Console.WriteLine("Withdraw money: ");
//double input = double.Parse(Console.ReadLine());

//alexAccount.Withdraw(input);

////alexAccount.balance = alexAccount.balance - input;

//Console.WriteLine($"Account balance: {alexAccount.GetBalance()}");

//Account alexAccount = new Account();

//Console.WriteLine($"Account balance: {alexAccount.Balance}");

//Console.WriteLine("Withdraw money: ");
//double input = double.Parse(Console.ReadLine());

//alexAccount.Balance = alexAccount.Balance - input;
////alexAccount.Withdraw(input);

////alexAccount.balance = alexAccount.balance - input;

//Console.WriteLine($"Account balance: {alexAccount.Balance}");

//Console.WriteLine(alexAccount.Balance); // GET
//alexAccount.Balance = 100; // SET

//Account alex2Account = new Account
//{
//    Balance = 100
//};

//// Equal with:

//Account alex3Account = new Account();
//alex3Account.Balance = 100;


//List<int> numbers = new List<int>{ 2, 5, 10, 15 };

//Author creanga = new Author("Romania", "Ion Creanga", "Email");
//creanga.Print();

BankAccount alexBankAccount = new BankAccount
{
    AccountHolder = "Alex",
    AccountNumber = 1
};
alexBankAccount.Deposit(1000);
alexBankAccount.Withdraw(100);
Console.WriteLine(alexBankAccount.GetBalance());
Console.WriteLine(alexBankAccount.AccountHolder);

foreach (var transtaction in alexBankAccount.GetTransactions())
{
    Console.WriteLine(transtaction);
}