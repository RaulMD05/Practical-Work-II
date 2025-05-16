using System;
namespace poo{
    public class HexadecimalInputValidator : InputValidator{
        public override void validate(string input)
        {
            for(int i = 0; i < input.Length; i++){
                char c = input[i];

                bool IsDigit = c >= '0' && c <= '9';
                bool isUpper = c >= 'A' && c <= 'F';
                bool isLower = c >= 'a' && c <= 'f';

                if(!IsDigit && !isUpper && !isLower)
                    throw new FormatException("Bad Format: input is not a valid Hex number.");
            }
        }
    }
}