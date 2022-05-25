namespace ExelReader
{
    public class DistractionCalculator
    {
        public static long GetSwing(List<int> numbers)
        {
            numbers.Sort();
            return numbers[numbers.Count - 1] - numbers[0];
        }

        public static Decimal GetStandardDeviation(List<int> numbers)
        {
            return (Decimal)Math.Sqrt(GetDispersion(numbers));
        }

        public static Double GetDispersion(List<int> numbers)
        {
            if (numbers==null||numbers.Count < 2) throw new ArgumentException("The collection must contain at least two elements.");
            double average = StatisticsCalculator.GetAverage(numbers);
            double sumOfSquaresOfDifferences = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sumOfSquaresOfDifferences += (numbers[i] - average) * (numbers[i] + average);
            }
            return sumOfSquaresOfDifferences / numbers.Count;
        }
    }
}
