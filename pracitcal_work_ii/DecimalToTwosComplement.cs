using System;
namespace poo{
    public class DecimalToTwosComplement : Conversion{
        private int size = 16;
        public DecimalToTwosComplement(string name, string definition) : base(name,definition,new DecimalInputValidator(),true){

        }
        public void SetSize(int size){
            this.size = size;
        }
        public override string Change(string input)
        {
            int number = Int32.Parse(input);
            if (number >= 0)
            {
                return (Convert.ToString(number, 2).PadLeft(size, '0'));
            }
            else
            {
                int positive = (1 << size) + number;
                return (Convert.ToString(positive, 2));
            }
        }
        public override string Change(string input, int bits)
        {
            int number = Int32.Parse(input);

            int minVal = -(1 << (bits - 1));
            int maxVal = (1 << (bits - 1))-1;

            if(number < minVal || number > maxVal)
                throw new ArgumentOutOfRangeException(nameof(input), $"Number must fit within {bits} bits");
            
            uint unsignedValue = (uint) number & ((1u << bits)-1);
            string binaryString = Convert.ToString(unsignedValue,2).PadLeft(bits,'0');

            return(binaryString);
        }
    }
}