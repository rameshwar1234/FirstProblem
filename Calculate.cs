using System.Collections.Generic;

namespace FirstProblem
{
    public class Calculate
    {
        /// <summary>
        /// This Method is for Calculation the total price of Product given by the User.
        /// </summary>
        /// <param name="products"></param>
        /// <returns>total amount of ptoduct</returns>
        public int GetTotalPrice(List<Product> products)
        {
            int occurrenceOf_A = 0;
            int occurrenceOf_B = 0;
            int occurrenceOf_C = 0;
            int occurrenceOf_D = 0;

            //Below Value Can be configurable
            int priceofA = 50;
            int priceofB = 30;
            int priceofC = 20;
            int priceofD = 15;

            foreach (Product pr in products)
            {
                if (pr.Id == "A" || pr.Id == "a")
                {
                    occurrenceOf_A = occurrenceOf_A + 1;
                }
                if (pr.Id == "B" || pr.Id == "b")
                {
                    occurrenceOf_B = occurrenceOf_B + 1;
                }
                if (pr.Id == "C" || pr.Id == "c")
                {
                    occurrenceOf_C = occurrenceOf_C + 1;
                }
                if (pr.Id == "D" || pr.Id == "d")
                {
                    occurrenceOf_D = occurrenceOf_D + 1;
                }
            }

            //Promotion Engine Logic Implemented here

            int totalPriceofA = (occurrenceOf_A / 3) * 130 + (occurrenceOf_A % 3 * priceofA);
            int totalPriceofB = (occurrenceOf_B / 2) * 45 + (occurrenceOf_B % 2 * priceofB);
            int totalPriceofC = (occurrenceOf_C * priceofC);
            int totalPriceofD = (occurrenceOf_D * priceofD);

            //Calculating total value of Product
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;

        }
    }
    
}
