
//List
using System.Runtime.CompilerServices;

List<int> numbers =
[
    4, 1, 5, 7, 11, 14, 23, 28, 29, 34, 
    37, 39, 44, 49, 56, 65, 69, 70, 83, 
    97, 99, 32, 55, 21, 11, 39, 43, 61
];

var greaterThan100 = numbers.Any(num => num > 100);

var OddGreaterThan90 = numbers.Any(num => (num > 90) && (num % 2 != 0));

Console.WriteLine(nameof(greaterThan100) + " = " + greaterThan100);
Console.WriteLine(nameof(OddGreaterThan90) + " = " + OddGreaterThan90);


//Custom Object

List <Person> persons = new List<Person>() {
    new("Hasib", "Programmer", 52345.75m),
    new("Hamim", "Doctor", 81230.50m),
    new("Bill Gates", "Businessman", 999999.99m),
    new("Elon Musk", "Entrepreneur", 875000.25m),
    new("Mark Zuckerberg", "Engineer", 645000.80m),
    new("Steve Jobs", "Designer", 710500.40m),
    new("Larry Page", "Entrepreneur", 689320.10m),
    new("Sergey Brin", "Scientist", 672150.60m),
    new("Sundar Pichai", "CEO", 950000.00m),
    new("Satya Nadella", "CEO", 932450.35m),
    new("Jeff Bezos", "Businessman", 980000.75m),
    new("Warren Buffett", "Investor", 910200.90m),
    new("Jack Ma", "Entrepreneur", 745320.45m),
    new("Tim Cook", "Executive", 805430.20m),
    new("Linus Torvalds", "Programmer", 150000.55m),
    new("Dennis Ritchie", "Computer Scientist", 142300.15m),
    new("Bjarne Stroustrup", "Engineer", 168750.95m),
    new("James Gosling", "Programmer", 155600.70m),
    new("Guido van Rossum", "Programmer", 148900.30m),
    new("Brendan Eich", "Programmer", 152340.85m)
};

var AnyEngineer = persons.Any(person => person.Job == "Engineer");
var AnyDoctor = persons.Any(person => person.Job == "Doctor");
var AnyTeacher = persons.Any(person => person.Job == "Farmer");

var AnyEngineerEarnMoreThan1000000 = persons.Any(person => (person.Job == "Engineer") && (person.Salary >= 1000000));

var AnyEntrepreneurEarnLessThan100000 = persons.Any(person => (person.Job == "Entrepreneur") && (person.Salary <= 100000));

Console.WriteLine($"{nameof(AnyEngineerEarnMoreThan1000000)} = {AnyEngineerEarnMoreThan1000000} ");
Console.WriteLine($"{nameof(AnyEntrepreneurEarnLessThan100000)} = {AnyEntrepreneurEarnLessThan100000} ");













class Person
{
    public string Name { get; set; }
    public string Job { get; set; }
    public decimal Salary { get; set; }

    public Person(string N, string J, decimal S)
    {
        Name = N;
        Job = J;
        Salary = S;
    }
}