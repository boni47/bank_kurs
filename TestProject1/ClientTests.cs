using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinancialOperation;

[TestClass]
public class ClientTests
{
    [TestMethod]
    public void Client_ShouldValidatePhone()
    {
        // Arrange
        var client = new Clients();

        // Act & Assert
        client.Phone = "+79991112233";
        Assert.IsTrue(client.IsPhoneValid());

        client.Phone = "123";
        Assert.IsFalse(client.IsPhoneValid());
    }
}