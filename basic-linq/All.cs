//Dataset
List<Animal> animals = new List<Animal>()
{
    new Animal("Leo", "Lion", 5),
    new Animal("Milo", "Cat", 2),
    new Animal("Bella", "Dog", 3),
    new Animal("Nemo", "Fish", 1),
    new Animal("Daisy", "Cow", 4),
    new Animal("Charlie", "Horse", 7),
    new Animal("Lola", "Rabbit", 1),
    new Animal("Max", "Dog", 6),
    new Animal("Coco", "Parrot", 2),
    new Animal("Rocky", "Bear", 8)
};


//Linq
var areAllLion = animals.All(animal => animal.Species == "Lion");

var areAllDogsMoreThan2YearsOld = animals
    .Where(animal => animal.Species == "Dog")
    .All(animal => animal.Age > 2);


//Prints
Console.WriteLine($"{nameof(areAllLion)} = {areAllLion}");
Console.WriteLine($"{nameof(areAllDogsMoreThan2YearsOld)} = {areAllDogsMoreThan2YearsOld}");



//Animal Object
public class Animal
{
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }

    public Animal(string name, string species, int age)
    {
        Name = name;
        Species = species;
        Age = age;
    }
}