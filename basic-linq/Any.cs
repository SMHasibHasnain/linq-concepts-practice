
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
