
List <Person> persons = new List<Person>() {
    new("Hasib", "Programmer", 52345.75m),
    new("Hamim", "Doctor", 52345.75m),
    new("Tofayel", "Businessman", 52345.75m),
    new("Habib", "Entrepreneur", 8700.25m),
    new("Fardin", "Engineer", 645000.80m),
    new("Ador", "Designer", 710500.40m),
    new("Rajib", "Entrepreneur", 689320.10m),
    new("fahim", "Scientist", 672150.60m),
    new("Mr. X", "CEO", 950000.00m),
    new("Mr. Y", "CEO", 932450.35m),
    new("Mr. Z", "Businessman", 980000.75m),
    new("Mr. P", "Investor", 910200.90m),
    new("Mr. Q", "Entrepreneur", 745320.45m),
    new("Mr. R", "Executive", 805430.20m),
    new("Mr. A", "Programmer", 150000.55m),
    new("Dennis Ritchie", "Computer Scientist", 142300.15m),
    new("Bjarne Stroustrup", "Engineer", 168750.95m),
    new("James Gosling", "Programmer", 155600.70m),
    new("Guido van Rossum", "Programmer", 148900.30m),
    new("Brendan Eich", "Programmer", 152340.85m)
};


var jobs = persons
    .Select(person => "=> " + person.Job)
    .Distinct();

var dataInString = persons 
    .Select(person => $"{person.Name} is a {person.Job} & He is earning {person.Salary} yearly!");


foreach (var item in jobs)
{
    Console.Write(item + " ");
}

Console.WriteLine();

foreach (var item in dataInString)
{
    Console.WriteLine(item);
}







//Person Class
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