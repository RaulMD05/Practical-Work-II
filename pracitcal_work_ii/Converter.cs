using System;
namespace poo{
    public class Converter
    {
        private List<Conversion> operations;

        public Converter()
        {
            this.operations = new List<Conversion>();
            this.operations.Add(new DecimalToBinary("Binary", "Decimal to binary"));
            this.operations.Add(new DecimalToOctal("Octal", "Decimal to octal"));
            this.operations.Add(new DecimalToHex("Hex", "Decimal to hexadecimal"));
            this.operations.Add(new DecimalToTwosComplement("Twos Complement", "Decimal to binary (2Complement)"));
            this.operations.Add(new BinaryToDecimal("Decimal", "Binary To Decimal"));
            this.operations.Add(new TwoComplementToDecimal("Decimal", "Binary(2Complement) to Decimal"));
            this.operations.Add(new OctaToDecimal("Decimal", "Octal To Decimal"));
            this.operations.Add(new HexToDecimal("Decimal", "Hex To Decimal"));
        }

        public int Exit()
        {
            return (this.operations.Count + 1);
        }

        public int GetNumberOperations()
        {
            return (this.operations.Count);
        }

        public int PrintOperations()
        {
            Console.Clear();
            Console.WriteLine("______________________________");
            for (int i = 1; i <= this.operations.Count; i++)
            {
                Console.WriteLine($"{i}. {this.operations[i - 1].GetDefinition()}");
            }
            Console.WriteLine($"{this.Exit()}. Exit");
            Console.WriteLine("______________________________");

            string tmp = Console.ReadLine();

            if (tmp == "") 
                return (this.GetNumberOperations() + 1);

            int option = int.Parse(tmp);

            return (option < 1 || option > this.GetNumberOperations()) ? this.GetNumberOperations() + 1 : option;
        }

        public string PerformConversion(int op, string input)
        {
            this.operations[op-1].validate(input);
            
            if(this.operations[op-1].NeedBitSize()){
                Console.Write("How many Bits should I use?: ");
                int bits = Int32.Parse(Console.ReadLine());

                return (this.operations[op - 1].Change(input,bits));
            }
            return (this.operations[op - 1].Change(input));
        }

        public void PrintConversion(int op, string input, string output)
        {
            this.operations[op - 1].PrintConversion(input, output);
        }
        
    }
}