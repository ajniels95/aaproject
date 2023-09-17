/* Output a variable that combines two strings together
string bob = "Saget" + " Bundy";
 string ted = "Bundy";
var lastNames = bob;
    Console.WriteLine(lastNames);*/


// Fix the issues below:
// int age = 5;
// int age = 8;
// string weight = "265";

// Complete the if statment that checks if testOne is greater thatn testTwo
//int testone = 11;
//int testtwo = 10;
//if (testone > testtwo)
//{
//Console.WriteLine("It is greater!");
//}
//else
//{
//Console.WriteLine("It is less!");
//}

// Complete the for loop to log out all of the values in the array
//string[] stringArr = { "Yo", "he", "Ya", "wa" };
//for (int i = 0; i < stringArr.Length; i++)
//{
//    Console.WriteLine(stringArr[i]);
//}

// Complete the for each to log out all of the values in the array
//string[] stringArrTwo = { "Yo", "He", "Ya", "Wa" };
//foreach (string i in stringArrTwo)
//{
//    Console.WriteLine(i);
//}

// Fizz Buzz Challenge: 
// Loop through this array of random number.
// If the number is a multiple of 3, write out Fizz
// If the number is a multiple of 5, write out Buzz
// If the number is a multiple of 3 and 5, write out Fizz Buzz


int[] arr = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18};
// foreach (int i in arr)
// {

//     if (i % 3 == 0 && i % 5 == 0)
//     {
//         Console.WriteLine("Fizz Buzz");
//     } 

//     else if (i % 3 == 0)
//     {
//         Console.WriteLine("Fizz");
//     }

//     else if (i % 5 == 0)
//     {
//         Console.WriteLine("Buzz");
//     }

//     else 
//     {
//         Console.WriteLine(i);
//     }
// }

foreach (int i in arr)
{
    bool fizz = i % 3 == 0;
    bool buzz = i % 5 == 0;
    Console.WriteLine((fizz && buzz) ? "Fizz Buzz" : fizz ? "Fizz" : buzz ? "Buzz" : i);
}