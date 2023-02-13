
using System;
class HelloWorld
{
  static string[] InputText (string Logo, string[]arr)
  {

    for (int i = 0; i < arr.Length; i++)
      {
	arr[i] = Console.ReadLine ();
      }
    return arr;
  }


  static string[] LengthLow3 (string[]arr)
  {
    int count = 0;
    string[]arrReturn = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
      {
	if (arr[i].Length <= 3)
	  {
	    arrReturn[count] = arr[i];
	    count += 1;
	  }
      }
    return arrReturn;
  }


  static void PrintPlusNumber (string[]arr)
  {
    Console.Write ($ "{String.Join(", ", arr)} -> {arr.Length}");
    Console.WriteLine ();
  }


  static void Main ()
  {
    Console.WriteLine ("text");
    int N = Convert.ToInt32 (Console.ReadLine ());

    string[]arr = new string[N];
    arr = InputText ("text", arr);

    string[]arrLow3 = new string[N];
    arrLow3 = LengthLow3 (arr);

    PrintPlusNumber (arr);
    PrintPlusNumber (arrLow3);
  }
}

