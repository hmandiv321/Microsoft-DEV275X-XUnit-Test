using System;

namespace myLib
{
    public class MathHelper
    {
        public int Max(int numberOne, int numberTwo)
        {
            /*since this is TDD, now that our implementation of the test fails
             * now we will fix this max implementation, to make the test pass
             */
            if(numberOne ==  numberTwo)
            {
                return numberOne;
            }
            throw new NotImplementedException("Write tests!");
        }

    }
}
