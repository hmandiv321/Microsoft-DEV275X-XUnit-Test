using System;

namespace myLib
{
    public class MathHelper
    {
        /// <summary>
        /// Accepts two nunbers and checks if the two numbers are same,
        /// if the numbers are same then it returns the number, ex: Max(0,0) 
        /// returns 0.
        /// if one number is greater than the other, then the greater number is 
        /// returned, ex: Max(89,99), returns 99.
        /// The Max method is commutative - returns the same result independent 
        /// of the order of the operands.
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <returns>
        /// Max number between the two numbers entered as input
        /// </returns>
        public int Max(int numberOne, int numberTwo)
        {
            /*since this is TDD, now that our implementation of the test fails
             * now we will fix this max implementation, to make the test pass
             */
            if(numberOne ==  numberTwo)
            {
                return numberOne;
            }
            
            if(numberOne > numberTwo)
            {
                return numberOne;
            }
            else
            {
                return numberTwo;
            }

            throw new NotImplementedException("Write tests!");
        }

    }
}
