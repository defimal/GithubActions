namespace GithubActionsLab;

[TestClass]
public class PowerTests
{
    [TestMethod]
    public void Power_Valid_Kapaba()
    {
        Assert.AreEqual(8, Program.Power("2", "3"));
        Assert.AreEqual(1, Program.Power("5", "0"));
        Assert.AreEqual(16, Program.Power("4", "2"));
    }

    [TestMethod]
    public void Power_Invalid_Kapaba()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Power("2", "b"));
    }

    [TestMethod]
    public void Power_Null_Kapaba()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "2"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("2", null));
    }
}