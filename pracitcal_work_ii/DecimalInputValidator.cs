using System;
namespace poo{
    public class DecimalInputValidator : InputValidator{
        public override void validate(string input)
        {
            for(int i = 0; i < input.Length; i++){
                if(input[i] == '-' && i > 0)
                    throw new FormatException("Bad Format: input is not a valid integer.");
                else if(!char.IsDigit(input[i]))
                    throw new FormatException("Bad Format: input is not a valid integer");
            }
        }
    }
}