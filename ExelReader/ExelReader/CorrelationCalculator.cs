namespace ExelReader
{
    public class CorrelationCalculator
    {
        public static double ComputeCoeff(List<int> values1, List<int> values2)
        {
            if (values1.Count != values2.Count)
                throw new ArgumentException("values must be the same length");

            double avg1 = StatisticsCalculator.GetAverage(values1);
            double avg2 = StatisticsCalculator.GetAverage(values2);

            double sum1 = 0;
            for (int i = 0; i < values1.Count; i++)
            {
                sum1 += (values1[i] - avg1) * (values2[i] - avg2);
            }

            double sumSqr1 = 0;
            for (int i = 0; i < values1.Count; i++)
            {
                sumSqr1 += Math.Pow((values1[i] - avg1), 2.0);
            }

            double sumSqr2 = 0;
            for (int i = 0; i < values1.Count; i++)
            {
                sumSqr2 += Math.Pow((values2[i] - avg2), 2.0);
            }

            var result = sum1 / Math.Sqrt(sumSqr1 * sumSqr2);
            return result;
        }
    }
}
