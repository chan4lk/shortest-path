using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Greedy.Tests
{
    [TestFixture]
    public class GreedyTests
    {
        [Test]
        public void GetLengthByCordsFromRootTest()
        {
            ShortestPath path = new ShortestPath();
            Point root = new Point(0, 0);
            Point point = new Point(3, 4);
            
            var length = path.CalculateLength(root, point);
            Assert.That(length, Is.EqualTo(5));
        }

        [Test]
        public void GetLengthByCordsTest()
        {
            ShortestPath path = new ShortestPath();
            Point root = new Point(2, 3);
            Point point = new Point(3, 4);

            var length = path.CalculateLength(root, point);
            Assert.That(length, Is.EqualTo(Math.Sqrt(2)));
        }

        [Test]
        public void CalculateZeroCitiesLength()
        {
            ShortestPath path = new ShortestPath();            

            double length = path.CalculatePerimeter(new List<Point>());
            Assert.That(length, Is.EqualTo(0));
        }

        [Test]
        public void CalculateSingleCitiesLength()
        {
            ShortestPath path = new ShortestPath();
            Point root = new Point(2, 3);
            double length = path.CalculatePerimeter(new List<Point>() { root });
            Assert.That(length, Is.EqualTo(0));
        }

        [Test]
        public void CalculateTwoCitiesLength()
        {
            ShortestPath path = new ShortestPath();
            Point city1 = new Point(0, 0);
            Point city2 = new Point(3, 4);
            double length = path.CalculatePerimeter(new List<Point>() { city1, city2 });
            Assert.That(length, Is.EqualTo(5));
        }

        [Test]
        public void CalculateThreeCitiesLength()
        {
            ShortestPath path = new ShortestPath();
            Point city1 = new Point(0, 0);
            Point city2 = new Point(2, 3);
            Point city3 = new Point(3, 4);
            double length = path.CalculatePerimeter(new List<Point>() { city1,city2, city3 });
            Assert.That(length, Is.EqualTo(Math.Sqrt(13) + Math.Sqrt(2) + 5));
        }
    }
}
