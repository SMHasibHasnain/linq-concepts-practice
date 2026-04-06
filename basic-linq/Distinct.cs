
var nums = new int[]
{
    4, 2, 9, 8, 5, 1, 5, 9, 3, 4
};

var distinctNums = nums.Distinct().OrderBy(num => num);

foreach (int item in distinctNums)
{
    Console.Write(item + " ");
}