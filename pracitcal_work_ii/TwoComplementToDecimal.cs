using System;
namespace poo{
    public class TwoComplementToDecimal : Conversion{
        public TwoComplementToDecimal(string name, string definition) : base(name,definition, new BinaryInputValidator()){

        }
        public override string Change(string input)
        {
            int number = Int32.Parse(input);

            int n = input.Length;
            bool isNgeative = input[0] == '1';

            int result = 0;

            if(!isNgeative){
                for(int i = 0; i<n;i++){
                    int bit = input[i] - '0';
                    result += bit*(int)Math.Pow(2,n - i -1);
                }
            }
            else{
                char[] inverted = new char[n];
                for(int i = 0; i<n; i++)
                    inverted[i] = input[i] == '0' ? '1' : '0';
                for(int i = n-1; i>=0;i--){
                    if(inverted[i] == '0'){
                        inverted[i] = '1';
                        break;
                    }
                    else
                        inverted[i] = '0';
                }
                for(int i = 0;i<n;i++){
                    int bit = inverted[i] - '0';
                    result += bit * (int)Math.Pow(2,n-i-1);
                }
                result *= -1;
            }
            return(result.ToString());
        }
        
    }
}