namespace BugTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var bug = new Bug(Bug.State.Open);
        Assert.AreEqual(Bug.State.Open, bug.getState());
    }
    [TestMethod]
    public void TestMethod2()
    {
        var bug = new Bug(Bug.State.Open);
        bug.Assign();
        Assert.AreEqual(Bug.State.Assigned, bug.getState());
    }
    [TestMethod]
    public void TestMethod3()
    {
        var bug = new Bug(Bug.State.Open);
        bug.Assign();
        bug.Defer();
        Assert.AreEqual(Bug.State.Defered, bug.getState());
    }
    [TestMethod]
    public void TestMethod4()
    {
        var bug = new Bug(Bug.State.Open);
        bug.Assign();
        bug.Defer();
        bug.Fix();
        bug.Assign();
        Assert.AreEqual(Bug.State.Assigned, bug.getState());
    }
    [TestMethod]
    public void TestMethod5()
    {
        var bug = new Bug(Bug.State.Open);
        bug.Assign();
        bug.Defer();
        bug.Fix();
        bug.Close();
        Assert.AreEqual(Bug.State.Closed, bug.getState());
    }
    [TestMethod]
    public void TestMethod6()
    {
        var bug = new Bug(Bug.State.Open);
        bug.Assign();
        bug.Defer();
        bug.Fix();
        bug.Close();
        bug.Assign();
        Assert.AreEqual(Bug.State.Assigned, bug.getState());
    }
    [TestMethod]
    public void TestMethod7()
    {
        var bug = new Bug(Bug.State.Open);
        bug.Assign();
        bug.Assign();
        Assert.AreEqual(Bug.State.Assigned, bug.getState());
    }
    [TestMethod]
    public void TestMethod8()
    {
        var bug = new Bug(Bug.State.Open);
        bug.Assign();
        bug.Defer();
        bug.Fix();
        bug.Defer();
        bug.Assign();
        bug.Close();
        Assert.AreEqual(Bug.State.Closed, bug.getState());
    }
    [TestMethod]
    public void TestMethod9()
    {
        var bug = new Bug(Bug.State.Closed);
        bug.Assign();
        bug.Fix();
        Assert.AreEqual(Bug.State.Fixed, bug.getState());
    }
    [TestMethod]
    public void TestMethod10()
    {
        var bug = new Bug(Bug.State.Closed);
        bug.Assign();
        bug.Fix();
        bug.Defer();
        Assert.AreEqual(Bug.State.Defered, bug.getState());
    }
    [TestMethod]
    public void TestMethod11()
    {
        var bug = new Bug(Bug.State.Closed);
        bug.Assign();
        bug.Fix();
        bug.Defer();
        bug.Assign();
        bug.Close();
        Assert.AreEqual(Bug.State.Closed, bug.getState());
    }
}