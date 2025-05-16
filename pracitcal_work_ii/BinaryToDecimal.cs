using System;
namespace poo{
    public class BinaryToDecimal : Conversion{
        public BinaryToDecimal(string name, string definition) : base(name,definition, new BinaryInputValidator()){

        }
        public override string Change(string input)
        {
            int number = Int32.Parse(input);
            
            int n = input.Length;

            int result = 0;

            for(int i = 0; i<n;i++){
                    int bit = input[i] - '0';
                    result += bit*(int)Math.Pow(2,n - i -1);
            }
            return(result.ToString());
            
        }
    }
}