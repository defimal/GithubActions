namespace GithubActionsLab;

[TestClass]
public class Multiplication
{
    [TestMethod]
    public void Multiply_Valid_Kapaba()
    {
        Assert.AreEqual(6, Program.Multiply("2", "3"));
        Assert.AreEqual(0, Program.Multiply("0", "5"));
        Assert.AreEqual(-6, Program.Multiply("-2", "3"));
    }

    [TestMethod]
    public void Multiply_Invalid_Kapaba()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("2", "b"));
    }

    [TestMethod]
    public void Multiply_Null_Kapaba()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "2"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("2", null));
    }
}