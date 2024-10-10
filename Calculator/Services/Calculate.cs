namespace Calculator.Services
{
    public class Calculate
    {
        public double Sum(string strNumbers)
        {
            var numbers = NumbHelper.Parser(strNumbers);

            var sum = numbers.Sum(x => Convert.ToDouble(x));
            return sum;
        }
        public double Sub(string strNumbers)
        {
            var numbers = NumbHelper.Parser(strNumbers);

            var sub = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                sub = sub - numbers[i];
            }

            return sub;
        }
        public double Div(string strNumbers)
        {

            var numbers = NumbHelper.Parser(strNumbers);

            var sub = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                sub = sub / numbers[i];
            }
            return sub;
        }
        public double Mul(string strNumbers)
        {
            var numbers = NumbHelper.Parser(strNumbers);

            var sub = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                sub = sub * numbers[i];
            }
            return sub;
        }
    }
}
