using System;

// 1
// public class Program
// {
//     public static int CountYZ(string text)
//     {
//         var word = text.ToLower();
//         var count = 0;
//
//         for (var i = 0; i < word.Length; i++)
//         {
//             var letter = word[i];
//             if ((letter == 'y' || letter == 'z') &&
//                 (i == word.Length - 1 || !char.IsLetter(word[i + 1])))
//             {
//                 count++;
//             }
//         }
//
//         return count;
//     }
//
//     public static void Main()
//     {
//         Console.WriteLine("Satrni kiriting:");
//         var input = Console.ReadLine();
//
//         var result = CountYZ(input);
//
//         Console.WriteLine($"'y' yoki 'z' harfi bilan tugaydigan so'zlar soni: {result}");
//     }
// }

// public class Program
// {
//     public static void function()
//     {
//         
//     }
//
//     public static void Main(string[] args)
//     {
//         
//     }
// }

// 2
// public class Program
// {
//     public static string function(string input1, string input2)
//     {
//         if (input1.Contains(input2))
//         {
//             var searchstring2 = input1.IndexOf(input2);
//            var editinput = input1.Remove(searchstring2, input2.Length);
//            return editinput;
//         }
//         else
//         {
//             var words = "2-satr topilmadi(";
//             return words ;
//         }
//         
//
//     }
//     
//     public static void Main(String[] args)
//     {
//         Console.Write("satr1: ");
//         var input1 = Console.ReadLine();
//         Console.Write("satr2: ");
//         var input2 = Console.ReadLine();
//         var result = function(input1, input2);
//         Console.WriteLine(result);
//     }
// }

// 3
// public class Program
// {
//     public static bool function(string input)
//     {
//         input = input.ToLower();
//         var countIs = 0;
//         var countNot = 0;
//         for (int i = 0; i < input.Length - 1; i++)
//         {
//             if (input[i] == 'i' && input[i + 1] == 's')
//             {
//                 ++countIs;
//             }
//         }
//
//         for (int i = 0; i < input.Length-2; i++)
//         {
//             if (input[i] == 'n' && input[i + 1] == 'o' && input[i + 2] == 't')
//             {
//                 ++countNot;
//             }
//         }
//
//         if (countIs ==countNot)
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }
//
//     public static void Main()
//     {
//         Console.Write("satr: ");
//         var input = Console.ReadLine();
//         var result = function(input);
//         Console.WriteLine(result);
//     }
// }

// 4
// public class Program
// {
//     public static bool function(string input)
//     {
//         var countG = 0;
//         for (int i = 0; i < input.Length; i++)
//         {
//             if (input[i] == 'g')
//             {
//                 ++countG;
//             }
//         }
//         var countTrue = 0;
//         for (int i = 0; i < input.Length-2; i++)
//         {
//             
//             if ((input[i]=='g' || input[i+2]=='g') && input[i+1]=='g')
//             {
//                 ++countTrue;
//             }
//         }
//
//         if ((countG-countTrue)%2==0 )
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }
//     public static void Main()
//     {
//         Console.Write("satr: ");
//         var input = Console.ReadLine();
//         var result = function(input);
//         Console.Write($"natija: {result}");
//     }
// }

public class Program
{
    public static void function()
    {
        
    }

    public static void Main()
    {
        Console.Write("satr: ");
        var text = (Console.ReadLine());
        
    }
}