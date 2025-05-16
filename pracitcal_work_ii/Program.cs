// using System;

// namespace poo
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             Converter converter = new Converter();
//             Operations ops = new Operations(";");

//             int error = 1;
//             string input = "";
//             string output = "";
//             string errorMessage;

//             int operation = converter.PrintOperations();

//             while (operation >= 1 && operation <= converter.GetNumberOperations())
//             {

//                 while(error == 1){
//                     try{
//                         Console.Clear();
//                         Console.Write("Insert the number to convert: ");

//                         input = Console.ReadLine();

//                         output = converter.PerformConversion(operation, input);

//                         converter.PrintConversion(operation, input, output);
         
//                         operation = converter.PrintOperations();
                        
//                         error = 0;
//                         errorMessage = "";

//                     }
//                     catch(OverflowException ex){
//                         errorMessage = ex.Message;
//                         Console.WriteLine("Introduce a valid number/bit for the input ");
//                         Console.ReadLine();
//                     }
//                     catch(FormatException ex){
//                         errorMessage = ex.Message;
//                         Console.WriteLine("Introduce a valid input for the conversion chosen");
//                         Console.ReadLine();
//                     }
//                     catch(Exception ex){
//                         errorMessage = ex.Message;
//                         Console.WriteLine("An unknown error has occured");
//                         Console.ReadLine();
//                     }

//                     ops.AddOperations(input,output,operation, error, errorMessage);
//                 }
                
//             }
//             ops.SaveOperations("output.csv");
//         }
//     }
    
// }
