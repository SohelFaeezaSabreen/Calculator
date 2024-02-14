namespace UtilityLibraries;
public static class StringLibrary
{
public static decimal Add(decimal number1, decimal number2)
        {  
           decimal sum = number1 + number2;
            return sum;
        }

        public static decimal Subtract(decimal number1=10, decimal number2=10)
        {  
           decimal difference = number1 - number2;
            return difference;
        }

        public static decimal Multiply(decimal number1, decimal number2)
        {  
           decimal product = number1 * number2;
            return product;
        }

      
        public static decimal Divide(decimal number1, decimal number2)
        {  
           decimal quotient = number1 / number2;
            return quotient;
        }

        public static decimal Modulo(decimal number1, decimal number2)
        {  
           decimal remainder = number1 % number2;
            return remainder;
        }
}
