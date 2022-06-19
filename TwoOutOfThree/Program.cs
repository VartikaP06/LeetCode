// See https://aka.ms/new-console-template for more information
using TwoOutOfThree;

var arr1 = new int[] { 1, 2, 2 };
var arr2 = new int[] { 4, 3, 3 };
var arr3 = new int[] { 5, 5, 5 };

var resList = new Implementation().TwoOutOfThree(arr1, arr2, arr3);

foreach (var item in resList)
{
    Console.Write(item + ", ");
}


