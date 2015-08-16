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

    #region IsInList
    [TestMethod]
    public void TestMethod_IsInList_true_lowercase()
    {
      const string source1 = "zip";
      string[] source2 = {"ZIP", "EPUB", "MOBI", "PDF", "DOC", "XPS", "DOCX", "PPTX"};
      const bool expected = true;
      bool result = FormMain.IsInList(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsInList_true_uppercase()
    {
      const string source1 = "ZIP";
      string[] source2 = { "ZIP", "EPUB", "MOBI", "PDF", "DOC", "XPS", "DOCX", "PPTX" };
      const bool expected = true;
      bool result = FormMain.IsInList(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsInList_false()
    {
      const string source1 = "zipper";
      string[] source2 = { "ZIP", "EPUB", "MOBI", "PDF", "DOC", "XPS", "DOCX", "PPTX" };
      const bool expected = false;
      bool result = FormMain.IsInList(source1, source2);
      Assert.AreEqual(result, expected);
    }
    #endregion IsInList
  }
}