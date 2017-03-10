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
            Assert.AreEqual(0, value);
        }

        [Test]
        public void ValueofSingleCell2()
        {
            Game g = new Game();
            int value = g.GetCellValue(2, 2);
            Assert.AreEqual(0, value);
        }

        [Test]
        public void ValueofCellAfterMove()
        {
            Game g = new Game();
            g.Move(0);
            int value = g.GetCellValue(0, 0);
            Assert.AreEqual(1, value);
        }

        [Test]
        public void ValueofCellAfter2ndMove()
        {
            Game g = new Game();
            g.Move(0);
            g.Move(0);
            int value = g.GetCellValue(0, 1);
            Assert.AreEqual(2, value);
        }

        [Test]
        public void ValueofCellAfter3Moves()
        {
            Game g = new Game();
            g.Move(0);
            g.Move(0);
            g.Move(0);
            int value = g.GetCellValue(0, 2);
            Assert.AreEqual(1, value);
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
            Assert.AreEqual(2, value);
        }

        [Test]
        public void ChangePlayer()
        {
            Game g = new Game();
            g.player = 1;
            g.ChangePlayer();
            Assert.AreEqual(2, g.player);
            g.ChangePlayer();
            Assert.AreEqual(1, g.player);
            g.ChangePlayer();
            Assert.AreEqual(2, g.player);
        }

        [Test]
        public void CheckVerticalWin()
        {
            Game g = new Game();
            g.Move(0);
            g.Move(1);
            g.Move(0);
            g.Move(1);
            g.Move(0);
            g.Move(1);
            g.Move(0);
            Assert.AreEqual(true, g.HasWon);
        }
        [Test]
        public void CheckHorizWin()
        {
            Game g = new Game();
            g.Move(0);
            g.Move(0);
            g.Move(1);
            g.Move(1);
            g.Move(2);
            g.Move(2);
            g.Move(3);
            Assert.AreEqual(true, g.HasWon);
        }
        [Test]
        public void CheckDiagWin()
        {
            Game g = new Game();
            g.Move(0);
            g.Move(1);
            g.Move(1);
            g.Move(3);
            g.Move(2);
            g.Move(2);
            g.Move(2);
            g.Move(3);
            g.Move(3);
            g.Move(4);
            g.Move(3);
            Assert.AreEqual(true, g.HasWon);
        }
        [Test]
        public void CheckDiagWin2()
        {
            Game g = new Game();
            g.Move(4);
            g.Move(3);
            g.Move(3);
            g.Move(1);
            g.Move(2);
            g.Move(2);
            g.Move(2);
            g.Move(1);
            g.Move(1);
            g.Move(0);
            g.Move(1);
            Assert.AreEqual(true, g.HasWon);
        }
    }
}
