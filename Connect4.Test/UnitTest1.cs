using NUnit.Framework;
using Connect4.Console;

namespace Connect4.Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual("test6", "test6");
        }

        [Test]
        public void ValueofSingleCell()
        {
            Game g = new Game();
            int value = g.GetCellValue(0,0);
            Assert.AreEqual(value, 0);
        }

        [Test]
        public void ValueofSingleCell2()
        {
            Game g = new Game();
            int value = g.GetCellValue(2, 2);
            Assert.AreEqual(value, 0);
        }

        [Test]
        public void ValueofCellAfterMove()
        {
            Game g = new Game();
            g.Move(0);
            int value = g.GetCellValue(0, 0);
            Assert.AreEqual(value, 1);
        }

        [Test]
        public void ValueofCellAfter2ndMove()
        {
            Game g = new Game();
            g.Move(0);
            g.Move(0);
            int value = g.GetCellValue(0, 1);
            Assert.AreEqual(value, 1);
        }

        [Test]
        public void ValueofCellAfter3Moves()
        {
            Game g = new Game();
            g.Move(0);
            g.Move(0);
            g.Move(0);
            int value = g.GetCellValue(0, 2);
            Assert.AreEqual(value, 1);
        }

        [Test]
        public void ValueofCellAfter4Moves()
        {
            Game g = new Game();
            g.Move(0);
            g.Move(0);
            g.Move(0);
            g.Move(0);
            int value = g.GetCellValue(0, 3);
            Assert.AreEqual(value, 1);
        }
    }
}
