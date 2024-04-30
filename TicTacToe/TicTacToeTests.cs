using NUnit.Framework;
using TicTacToe;

[TestFixture]
internal class TicTacToeTests
{
    private TicTacToeModel ticTacToe;
    private int size;
    [SetUp]
    public void SetUp()
    {
        size = 3;
        ticTacToe = new TicTacToeModel(size);
    }

    #region
    [TestCase(1, 1, 1,
              null, null, null,
              null, null, null)]
    [TestCase(null, null, null,
                 0, 0, 0,
              null, null, null)]
    [TestCase(null, null, null,
              null, null, null,
                 1, 1, 1)]
    [TestCase(1, null, null,
              1, null, null,
              1, null, null)]
    [TestCase(null, 0, null,
              null, 0, null,
              null, 0, null)]
    [TestCase(null, null, 1,
              null, null, 1,
              null, null, 1)]
    [TestCase(1, null, 1,
              null, 1, 0,
              null, null, 1)]
    [TestCase(0, 1, 0,
              1, 0, 0,
              0, 1, 1)]
    #endregion
    public void IsCheckTestTrue(params int?[] values)
    {
        for (int i = 0; i < values.Length; i++)
            ticTacToe[i] = values[i];

        Assert.That(ticTacToe.IsCheck(), Is.EqualTo(true));
    }

    #region
    [TestCase(null, 1, 1,
              null, null, null,
              null, null, null)]
    [TestCase(null, null, null,
              null, 0, 0,
              null, null, null)]
    [TestCase(null, null, null,
              null, null, null,
              null, 1, 1)]
    [TestCase(1, null, null,
              0, null, null,
              1, null, null)]
    [TestCase(null, 0, null,
              null, 1, null,
              null, 0, null)]
    [TestCase(null, null, 1,
              null, null, 1,
              null, null, null)]
    [TestCase(null, null, 1,
              null, null, 1,
              null, null, 0)]
    [TestCase(0, 1, 1,
              1, 0, 0,
              0, 1, 1)]
    #endregion
    public void IsCheckTestFalse(params int?[] values)
    {
        for (int i = 0; i < values.Length; i++)
            ticTacToe[i] = values[i];

        Assert.That(ticTacToe.IsCheck(), Is.EqualTo(false));
    }

    #region
    [TestCase(1, 1, 0,
                0, 1, 1,
              null, null, 1)]
    #endregion
    public void NewInitianalTestTrue(params int?[] values)
    {
        for (int i = 0; i < values.Length; i++)
            ticTacToe[i] = values[i];
        ticTacToe.NewInitianal();
        bool IsNewInitial = true;
        for (int i = 0; i < values.Length; i++)
            if (ticTacToe[i] != null)
            {
                IsNewInitial = false;
                break;
            }
        Assert.That(IsNewInitial);
    }

    [Test]
    public void NewInitianalTestFalse()
    {
        ticTacToe.NewInitianal();

        ticTacToe[4] = 1;

        bool IsNewInitial = true;
        for (int i = 0; i < size * size; i++)
            if (ticTacToe[i] != null)
            {
                IsNewInitial = false;
                break;
            }
        Assert.That(!IsNewInitial);
    }

    #region
    [Test]
    [TestCase(null, 1, 0,
                 0, 0, 1,
                 0, 0, 0)]
    [TestCase(0, 1, 1,
                 1, null, 1,
                 0, 0, 0)]
    [TestCase(1, 1, 1,
                 1, 1, 1,
                 1, 1, null)]
    #endregion
    public void IsStandoffTestFalse(params int?[] values)
    {
        for (int i = 0; i < values.Length; i++)
            ticTacToe[i] = values[i];
        Assert.That(ticTacToe.IsStandoff, Is.EqualTo(false));
    }

    #region
    [Test]
    [TestCase(   0, 1, 0,
                 0, 0, 1,
                 0, 0, 0)]
    #endregion
    public void IsStandoffTestTrue(params int?[] values)
    {
        for (int i = 0; i < values.Length; i++)
            ticTacToe[i] = values[i];
        Assert.That(ticTacToe.IsStandoff, Is.EqualTo(true));
    }

    #region
    [Test]
    [TestCase ( 0, 1, null,
                0, null, null,
                0, 0, 0)]
    #endregion
    public void EasyStrategyAttackOrProtectionTest(params int?[] values)
    {
        for (int i = 0; i < values.Length; i++)
            ticTacToe[i] = values[i];
        for (int i = 0; i < 10; i++)
            Assert.That(ticTacToe.RundomPositionComputer(ticTacToe.EasyStrategyAttackOrProtection), Is.AnyOf(2,4,5));
    }

    #region
    [Test]
    [TestCase(  0, 0, null,
                0, null, null,
                0, 1, 0)]
    [TestCase(  0, 0, 1,
                0, null, 0,
                0, 0, 1)]
    [TestCase(  0, 0, 1,
                0, null, null,
                null, 0, 0)]
    [TestCase(  0, 0, 1,
                0, null, null,
                0, null, 0)]
    [TestCase(0, 0, 1,
                0, null, null,
                0,    0, null)]
    #endregion
    public void AverageStrategyAttackOrProtectionTest(params int?[] values)
    {
        for (int i = 0; i < values.Length; i++)
            ticTacToe[i] = values[i];
        Assert.That(ticTacToe.RundomPositionComputer(ticTacToe.AverageStrategyAttackOrProtection), Is.AnyOf(2, 4, 6, 7, 8));
    }

    #region
    [Test]
    [TestCase(   null,  0,  null,
                 1,   null, null,
                 1,      0, null)]
    [TestCase(0, 0, 1,
               0, null, 0,
               0, 0, 1)]
    [TestCase(1, 0, 0,
               null, 1, null,
               null, 1, 0)]
    #endregion
    public void DifficultStrategyAttackOrProtectionTest(params int?[] values)
    {
        for (int i = 0; i < values.Length; i++)
            ticTacToe[i] = values[i];

        Assert.That(ticTacToe.RundomPositionComputer(ticTacToe.DifficultStrategyAttackOrProtection), Is.AnyOf(0, 4, 5));
    }

    #region
    [Test]
    [TestCase(null, 0, null,
                 0, 1, null,
                 1, 0, 1)]
    [TestCase( 0,   0, 1,
               1, null, 0,
               1,   1, 0)]
    #endregion
    public void SuperDifficultStrategyAttackOrProtectionTest(params int?[] values)
    {
        for (int i = 0; i < values.Length; i++)
            ticTacToe[i] = values[i];

        Assert.That(ticTacToe.RundomPositionComputer(ticTacToe.SuperDifficultStrategyAttackOrProtection), Is.AnyOf(0, 4, 5));
    }

}