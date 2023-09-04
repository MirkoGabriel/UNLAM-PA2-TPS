namespace Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void success_result_when_sum_two_numbers()
    {
        int result = Program.sumNumbers(3,3);
        Assert.AreEqual(6,result);
    }

    [TestMethod]
    public void success_result_when_trim_string()
    {
        string result = Program.trimString("Testeand");
        Assert.AreEqual("Test",result);
    }

    [TestMethod]
    public void error_result_when_trim_string()
    {
        string result = Program.trimString("Testeando");
        Assert.AreEqual("Error we need a word with 8 characters",result);
    }

    [TestMethod]
    public void success_result_when_i_get_a_color()
    {
        string result = Program.colorSwitch("azul");
        Assert.AreEqual("azul",result);
    }

    [TestMethod]
    public void success_result_when_i_set_a_number_gratter_than_ten()
    {
        int result = Program.gratterThanTen(65);
        Assert.AreEqual(65,result);
    }

    [TestMethod]
    public void error_result_when_i_set_a_number_gratter_than_ten()
    {
        int result = Program.gratterThanTen(8);
        Assert.AreEqual(-1,result);
    }
}