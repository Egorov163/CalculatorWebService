namespace Calculator.Services
{
    public class NumbHelper
    {
        public static List<double> Parser(string str)
        {
            var strNumb = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var num = new List<double>();

            for (int i = 0; i < strNumb.Length; i++)
            {
                num.Add(double.Parse(strNumb[i]));
            }
            return num;
        }
    }
}
