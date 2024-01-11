namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber{get;set;}
        public int SecondNumber { get;set;}
        //about get set : https://www.w3schools.com/cs/cs_properties.php
        public int Add()
        { 
            return FirstNumber+SecondNumber; 
        }

    }
}
