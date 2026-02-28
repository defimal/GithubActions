namespace GithubActionsLab;

[TestClass]
public class Subtraction
{
    [TestMethod]
    public void Subtract_Valid_Kapaba()
    {
        Assert.AreEqual(1, Program.Subtract("3", "2"));
        Assert.AreEqual(0, Program.Subtract("5", "5"));
        Assert.AreEqual(-2, Program.Subtract("3", "5"));
    }

    [TestMethod]
    public void Subtract_Invalid_Kapaba()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
    }

    [TestMethod]
    public void Subtract_Null_Kapaba()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
    }
}