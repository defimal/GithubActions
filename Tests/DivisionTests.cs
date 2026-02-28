namespace GithubActionsLab;

[TestClass]
public class Division
{
    [TestMethod]
    public void Divide_Valid_Kapaba()
    {
        Assert.AreEqual(2, Program.Divide("4", "2"));
        Assert.AreEqual(3, Program.Divide("9", "3"));
    }

    [TestMethod]
    public void Divide_Invalid_Kapaba()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("2", "b"));
    }

    [TestMethod]
    public void Divide_Null_Kapaba()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "2"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("2", null));
    }
}