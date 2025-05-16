using System;
namespace poo{
    public class OctalInputValidator : InputValidator{
        public override void validate(string input)
        {
            for(int i = 0; i < input.Length; i++){
                char c = input[i];

                bool IsDigit = c >= '0' && c <= '9';

                if(!IsDigit)
                    throw new FormatException("Bad Format: input is not a valid octal number.");
            }
        }
    }
}