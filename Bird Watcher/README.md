Introduction
Arrays
In C#, data structures that can hold zero or more elements are known as collections. An array is a collection that has a fixed size/length and whose elements must all be of the same type. Elements can be assigned to an array or retrieved from it using an index. C# arrays are zero-based, meaning that the first element's index is always zero:

// Declare array with explicit size (size is 2)
int[] twoInts = new int[2];

// Assign second element by index
twoInts[1] = 8;

// Retrieve the second element by index
twoInts[1] == 8; // => true
Arrays can also be defined using a shortcut notation that allows you to both create the array and set its value. As the compiler can now tell how many elements the array will have, the length can be omitted:

// Three equivalent ways to declare and initialize an array (size is 3)
int[] threeIntsV1 = new int[] { 4, 9, 7 };
int[] threeIntsV2 = new[] { 4, 9, 7 };
int[] threeIntsV3 = { 4, 9, 7 };
Arrays can be manipulated by either calling an array instance's methods or properties, or by using the static methods defined in the Array class.

For Loops
A for loop allows one to repeatedly execute code in a loop until a condition is met.

for (int i = 0; i < 5; i++)
{
    System.Console.Write(i);
}

// => 01234
A for loop consists of four parts:

The initializer: executed once before entering the loop. Usually used to define variables used within the loop.
The condition: executed before each loop iteration. The loop continues to execute while this evaluates to true.
The iterator: execute after each loop iteration. Usually used to modify (often: increment/decrement) the loop variable(s).
The body: the code that gets executed each loop iteration.
Foreach Loops
The fact that an array is also a collection means that, besides accessing values by index, you can iterate over all its values using a foreach loop:

char[] vowels = new [] { 'a', 'e', 'i', 'o', 'u' };

foreach (char vowel in vowels)
{
    // Output the vowel
    System.Console.Write(vowel);
}

// => aeiou
