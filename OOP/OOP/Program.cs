using OOP.Week4;

//Student bogdan = new Student();
//bogdan.age = 25;
//bogdan.lastName = "Bogdan";
//bogdan.firstName = "Bogdan";
//bogdan.nrMatricol = 1;

//Console.WriteLine(bogdan.firstName);
//Console.WriteLine(bogdan.lastName);

Car dacia = new Car("Dacia", "Logan", 2022);
//dacia.model = "Logan";
//dacia.brand = "Dacia";
//dacia.year = 2022;
dacia.color = "white";
dacia.nrOfSeats = 4;

Console.WriteLine($"Model: {dacia.model}, Brand: {dacia.brand}, Year: {dacia.year}, Color: {dacia.color}");

dacia.ChangeColor("red");
dacia.year = 2021;

Console.WriteLine($"Model: {dacia.model}, Brand: {dacia.brand}, Year: {dacia.year}, Color: {dacia.color}");

string uniqueCode = dacia.GetModelCode();

Console.WriteLine(uniqueCode);

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