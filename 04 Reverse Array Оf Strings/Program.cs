string[] stringArray = Console.ReadLine().Split(' ');

//for (int i = 0; i < stringArray.Length/ 2; i++)
//{
//    var oldElement = stringArray[i];
//    stringArray[i] = stringArray[stringArray.Length - 1 - i];
//    stringArray[stringArray.Length - 1 - i] = oldElement;

//}
//Console.WriteLine(string.Join(" ", stringArray));




//alternative
string[] reversedArray = stringArray.Reverse().ToArray();

foreach (string element in reversedArray)
{ 
    Console.Write(element + " "); 
}