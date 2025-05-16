using System;
namespace poo{
    public class DecimalToHex : Conversion{
        public DecimalToHex(string name, string definition) : base(name,definition, new DecimalInputValidator()){

        }
        public override string Change(string input)
        {
            int number = Int32.Parse(input);
            char[] hexchars = "0123456789ABCDEF".ToCharArray();
            
            if(number == 0)
                return ("0");

            string hexString = "";

            while(number>0){
                int remainder = number%16;
                hexString = hexchars[remainder] + hexString;
                number /= 16;
            }
            return(hexString);
        }
    }
}