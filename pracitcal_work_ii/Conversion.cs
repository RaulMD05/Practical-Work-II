using System;
namespace poo{
    public abstract class Conversion
    {
        protected string name;
        protected string definition;
        protected bool bitSize;
        protected InputValidator validator;

        public Conversion(string name, string definition, InputValidator validator)
        {
            this.name = name;
            this.definition = definition;
            this.validator = validator;
            this.bitSize = false;
        }
        public Conversion(string name, string definition,InputValidator validator, bool bitSize){
            this.name = name;
            this.definition = definition;
            this.validator = validator;
            this.bitSize = bitSize;
        }

        public void validate(string input){
            this.validator.validate(input);
        }
        public string GetName(){
            return (this.name);
        } 
        public string GetDefinition(){
            return(this.definition);
        }    
        public bool NeedBitSize(){
            return(this.bitSize);
        }

        public abstract string Change(string input);
        public virtual string Change(string input, int bits){
            throw new NotImplementedException("This method is not implemented in this subclass");
        }

        public void PrintConversion(string input, string output)
        {
            Console.Clear();
            Console.WriteLine($"{name} representation of {input} is {output}");
            Console.ReadLine();
        }
    }
}
