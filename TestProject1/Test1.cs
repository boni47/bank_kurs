using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using FinancialOperation;

[TestClass]
public class BasicTests
{
    [TestMethod]
    public void Account_Creation()
    {
        var account = new Accounts();
        Assert.IsNotNull(account, "Не удалось создать экземпляр Accounts");
    }

    [TestMethod]
    public void Client_Creation()
    {
        var client = new Clients();
        Assert.IsNotNull(client, "Не удалось создать экземпляр Clients");
    }

    [TestMethod]
    [STAThread]
    public void MainForm_Creation()
    {
        var form = new Main();
        Assert.IsNotNull(form, "Не удалось создать главную форму");
    }

    [TestMethod]
    [STAThread]
    public void UserControl_Initialization()
    {
        var control = new UserControlTransactions();
        Assert.IsNotNull(control, "Не удалось инициализировать UserControl");
    }
}