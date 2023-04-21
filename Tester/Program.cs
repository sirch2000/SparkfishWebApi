using NumberUtils;// See https://aka.ms/new-console-template for more information

var nums = Enumerable.Range(1, 50);
Console.WriteLine(nums.ToArray()[3]);
Console.WriteLine(nums.ToArray()[51]);

var list = new Listify(100, 200);
var i = list[50];
Console.WriteLine($"your number is {i}");


foreach(var item in list)
{
    Console.WriteLine(item);
}