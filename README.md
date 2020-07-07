# FormLargestNumberFromArray
Form largest number from the elements of an array.
Language: C#

## Input/Output
1. Input: { 57,9,75,7,79,53,5,63 } 
2. Output: 9797756357553

## Logic
1. Convert an array of int to array of string
2. Sort the array into descending order.
3. There is an issue here where 75 comes before 7. For such cases,
    X = 75, Y = 7
    XY > YX => X should come before Y in the array 
    XY < YX => Y should come before X in the array
    757 < 775 => 7 should come before 75 to form the largest number
    Note: Use this logic only for numbers with same starting digit. Like in 7 and 75, 7 is the common starting digit.
4. Convert the string array into a single string.
5. Return the string
      
