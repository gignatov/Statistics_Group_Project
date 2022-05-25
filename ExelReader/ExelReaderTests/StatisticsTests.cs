using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExelReader;
using NUnit.Framework;

namespace ExelReaderTests
{
    public class StatisticsTests
    {
        [Test]
        public void GetMedian_ListOfData_OddNumber_Returns10()
        {
            List<int> testData = new() { 5, 7, 10, 13, 15 };
            Decimal result = StatisticsCalculator.GetMedian(testData);
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void GetMedian_ListOfData_EvenNumber_Returns8_5()
        {
            List<int> testData = new() { 5, 7, 10, 13 };
            Decimal result = StatisticsCalculator.GetMedian(testData);
            Assert.That(result, Is.EqualTo(8.5));
        }

        [Test]
        public void GetMedian_EmptyListOfData_ThrowsArgumentException()
        {
            List<int> testData = new();
            Assert.Throws<ArgumentException>(() => StatisticsCalculator.GetMedian(testData));
        }

        [Test]
        public void GetAverage_ListOfData_Returns9()
        {
            List<int> testData = new() { 5, 7, 10, 14 };
            Double result = StatisticsCalculator.GetAverage(testData);
            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void GetAverage_ListOfData_OneItem_Returns1()
        {
            List<int> testData = new() { 1 };
            Double result = StatisticsCalculator.GetAverage(testData);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void GetAverage_EmptyListOfData_ThrowsArgumentException()
        {
            List<int> testData = new();
            Assert.Throws<ArgumentException>(() => StatisticsCalculator.GetMedian(testData));
        }
    }
}
