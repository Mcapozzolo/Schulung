//// See https://aka.ms/new-console-template for more information
//using System.Diagnostics;
//using SortConsole;

//Console.WriteLine("Hello, World!");
//char a = (char)85;
//Console.WriteLine(a);// a
//// Example array to be sorted with console method
//int[] arr = { 187, 234, 234, 234, 156, 1888, 1987 };

//Console.WriteLine("Original array:");

//Console.Write("[");
//for (int j = 0; j < arr.Length - 1; j++)
//{
//    Console.Write(arr[j] + ",");
//}
//Console.Write(arr[arr.Length - 1]);
//Console.Write("]");
//Console.WriteLine();
//Console.WriteLine();
//Sorter sorter = new Sorter();

//int[] sol = Sorter.sort(arr);

//Console.WriteLine("Sorted Array");
//Console.Write("[");

//for (int i = 0; i < sol.Length - 1; i++)
//{
//    Console.Write(sol[i] + ",");
//}
//Console.Write(sol[sol.Length - 1]);
//Console.Write("]");
//Console.WriteLine();
//Console.WriteLine();

//// Example array to be sorted with string concatenation method
//Console.WriteLine("string concatenation method");
//string[] los = new string[sol.Length];
//int count = 0;
//foreach (int i in sol)
//{
//    los[count] = i.ToString();
//    count++;
//}
//String h = "";
//foreach (String j in los)
//{

//    h = h + j + ",";
//}
//h = h.Remove(h.Length - 2);
//Console.WriteLine(h);

//Console.Write((char)(10));
//Console.Write((char)(13));
//Console.WriteLine(Environment.NewLine);

//Console.WriteLine("Sample Array");
//int[] sample = { 2, 6, 1, 8 };

//char[] ex = new char[sample.Length];

//for (int x = 0; x < ex.Length; x++)
//{
//    ex[x] = (char)(sample[x] + 48);
//    Console.Write(ex[x]);
//}
//Console.WriteLine();



//Console.ReadKey();

