using Week4HomeworkSolution.ExerciseEight;
using Week4HomeworkSolution.ExerciseFive;
using Week4HomeworkSolution.ExerciseFour;
using Week4HomeworkSolution.ExerciseOne;
using Week4HomeworkSolution.ExerciseSeven;
using Week4HomeworkSolution.ExerciseSix;
using Week4HomeworkSolution.ExerciseThree;
using Week4HomeworkSolution.ExerciseTwo;

Console.WriteLine("<<<<<<Exercise 1>>>>>>");
// Exercise 1
Crop carrot = new Crop("Carrot");
carrot.PrintCurrentStage();
carrot.Water();
carrot.PrintCurrentStage();
carrot.Water();
carrot.PrintCurrentStage();
carrot.Water();
carrot.PrintCurrentStage();
carrot.Harvest();
carrot.PrintCurrentStage();

Console.WriteLine("\n\n<<<<<<Exercise 2>>>>>>");
// Exercise 2
Farm happyVillage = new Farm("Happy Village", 1800);
happyVillage.AddAnimals(200);
Console.WriteLine(happyVillage.CalculateDensity().ToString("N2")); // Format value to show only 2 digits after the decimal point
happyVillage.AddAnimals(200);
Console.WriteLine(happyVillage.CalculateDensity().ToString("N4")); // Format value to show only 4 digits after the decimal point
happyVillage.AddAnimals(350);
Console.WriteLine(happyVillage.CalculateDensity());

Console.WriteLine("\n\n<<<<<<Exercise 3>>>>>>");
// Exercise 3
Book book = new Book("War and Peace", "Leo Tolstoy", 1869);

Console.WriteLine(book.GetTitle()); // Outputs "War and Peace"
Console.WriteLine(book.GetAuthor()); // Outputs "Leo Tolstoy"
Console.WriteLine(book.GetYear()); // Outputs 1869

book.SetTitle("Anna Karenina");
book.SetAuthor("Leo Tolstoy");
book.SetYear(1877);

Console.WriteLine(book.GetTitle()); // Outputs "Anna Karenina"
Console.WriteLine(book.GetAuthor()); // Outputs "Leo Tolstoy"
Console.WriteLine(book.GetYear()); // Outputs 1877

Console.WriteLine("\n\n<<<<<<Exercise 4>>>>>>");
// Exercise 4
Product product = new Product("Apple", 0.99, 10);

Console.WriteLine(product.GetName()); // Outputs "Apple"
Console.WriteLine(product.GetPrice()); // Outputs 0.99
Console.WriteLine(product.GetQuantity()); // Outputs 10

product.SetName("Orange");
product.SetPrice(1.49);
product.SetQuantity(20);

Console.WriteLine(product.GetName()); // Outputs "Orange"
Console.WriteLine(product.GetPrice()); // Outputs 1.49
Console.WriteLine(product.GetQuantity()); // Outputs 20

Console.WriteLine("\n\n<<<<<<Exercise 5>>>>>>");
// Exercise 5
Animal animal = new Animal("Max", "Dog", "Labrador Retriever", 2, "Yellow", 75, true);

Console.WriteLine(animal.GetName()); // Outputs "Max"
Console.WriteLine(animal.GetSpecies()); // Outputs "Dog"
Console.WriteLine(animal.GetBreed()); // Outputs "Labrador Retriever"
Console.WriteLine(animal.GetAge()); // Outputs 2
Console.WriteLine(animal.GetColor()); // Outputs "Yellow"
Console.WriteLine(animal.GetWeight()); // Outputs 75
Console.WriteLine(animal.IsSpayedOrNeutered()); // Outputs true

animal.SetName("Buddy");
animal.SetSpecies("Cat");
animal.SetBreed("Siamese");
animal.SetAge(5);
animal.SetColor("Gray");
animal.SetWeight(12);
animal.SetIsSpayedOrNeutered(false);

Console.WriteLine(animal.GetName()); // Outputs "Buddy"
Console.WriteLine(animal.GetSpecies()); // Outputs "Cat"
Console.WriteLine(animal.GetBreed()); // Outputs "Siamese"
Console.WriteLine(animal.GetAge()); // Outputs 5
Console.WriteLine(animal.GetColor()); // Outputs "Gray"
Console.WriteLine(animal.GetWeight()); // Outputs 12
Console.WriteLine(animal.IsSpayedOrNeutered()); // Outputs false

Console.WriteLine("\n\n<<<<<<Exercise 6>>>>>>");
// Exercise 6
Calculator calculator = new Calculator();

Console.WriteLine(calculator.Add(2, 3)); // Outputs 5
Console.WriteLine(calculator.Subtract(5, 2)); // Outputs 3
Console.WriteLine(calculator.Multiply(3, 4)); // Outputs 12
Console.WriteLine(calculator.Divide(10, 5)); // Outputs 2
Console.WriteLine(calculator.Power(2, 3)); // Outputs 8
Console.WriteLine(calculator.SquareRoot(9)); // Outputs 3

Console.WriteLine("\n\n<<<<<<Exercise 7>>>>>>");
// Exercise 7
University myUniversity = new University("My University");

Student john = new Student("John", "Doe", 123456, 3.8);
Student jane = new Student("Jane", "Smith", 654321, 3.6);

myUniversity.AddStudent(john);
myUniversity.AddStudent(jane);

Faculty mary = new Faculty("Mary", "Jones", 111111, new List<string> { "Math", "Physics" });
Faculty bob = new Faculty("Bob", "Smith", 222222, new List<string> { "English", "History" });

myUniversity.AddFaculty(mary);
myUniversity.AddFaculty(bob);

Console.WriteLine(myUniversity.GetStudentCount()); // Outputs 2
Console.WriteLine(myUniversity.GetFacultyCount()); // Outputs 2

Console.WriteLine("\n\n<<<<<<Exercise 8>>>>>>");
// Exercise 8
College alexandruIoanCuzaCollege = new College();
alexandruIoanCuzaCollege.city = "Iasi";
alexandruIoanCuzaCollege.name = "Alexandru Ioan Cuza";

StudentEight johny = new StudentEight("John Doe", DateTime.Now.AddYears(3), null, alexandruIoanCuzaCollege, DateTime.Now.AddYears(-20));
StudentEight janee = new StudentEight("Jane Smith", DateTime.Now.AddYears(5), DateTime.Now.AddYears(-1), alexandruIoanCuzaCollege, DateTime.Now.AddYears(-22));

var ionProf = new Professor("Ion Palade", "Informatica", "Dr.");
ionProf.studentsWhoGiveTheirDegree.Add(johny);

foreach (var student in ionProf.studentsWhoGiveTheirDegree)
{
    Console.WriteLine(student.name);
}