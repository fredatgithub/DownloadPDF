using Microsoft.VisualStudio.TestTools.UnitTesting;
using DownloadPDF;
namespace UnitTestApplication
{
  [TestClass]
  public class UnitTestApplication
  {
    #region UrlIsValid
    [TestMethod]
    public void TestMethod_UrlIsValid_true()
    {
      const string source = @"http://blogs.msdn.com/b/mssmallbiz/archive/2015/07/07/i-m-giving-away-millions-of-free-microsoft-ebooks-again-including-windows-10-windows-8-1-windows-8-windows-7-office-2013-office-365-sharepoint-2013-dynamics-crm-powershell-exchange-server-lync-2013-system-center-azure-clo.aspx";
      const bool expected = true;
      bool result = FormMain.IsUrlValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_UrlIsValid_false()
    {
      const string source = @"blogs.msdn.com/b/mssmallbiz/archive/2015/07/07/i-m-giving-away-millions-of-free-microsoft-ebooks-again-including-windows-10-windows-8-1-windows-8-windows-7-office-2013-office-365-sharepoint-2013-dynamics-crm-powershell-exchange-server-lync-2013-system-center-azure-clo.aspx";
      const bool expected = false;
      bool result = FormMain.IsUrlValid(source);
      Assert.AreEqual(result, expected);
    }

    #endregion UrlIsValid

    #region InvertModifier
    [TestMethod]
    public void TestMethod_InvertModifier_true()
    {
      const string source = "blue table";
      const string expected = "table blue";
      string result = FormMain.InvertModifier(source);
      Assert.AreEqual(result, expected);
    }
    #endregion InvertModifier
  }
}