/*
The MIT License(MIT)
Copyright(c) 2015 Freddy Juhel
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using DownloadPDF.Properties;
using HtmlAgilityPack;
using NamespaceYouAreUsing;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace DownloadPDF
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    readonly Dictionary<string, string> _languageDicoEn = new Dictionary<string, string>();
    readonly Dictionary<string, string> _languageDicoFr = new Dictionary<string, string>();
    private string _currentLanguage = "english";

    private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveWindowValue();
      Application.Exit();
    }

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutBoxApplication aboutBoxApplication = new AboutBoxApplication();
      aboutBoxApplication.ShowDialog();
    }

    private void DisplayTitle()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      Text += string.Format(" V{0}.{1}.{2}.{3}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart);
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      LoadSettingsAtStartup();
    }

    private void LoadSettingsAtStartup()
    {
      DisplayTitle();
      GetWindowValue();
      LoadLanguages();
      SetLanguage(Settings.Default.LastLanguageUsed);
      SetDefaultUrl();
    }

    private void SetDefaultUrl()
    {
      if (textBoxUrl.Text == string.Empty || textBoxUrl.Text.ToLower() == "https://")
      {
        textBoxUrl.Text = "http://blogs.msdn.com/b/mssmallbiz/archive/2015/07/07/i-m-giving-away-millions-of-free-microsoft-ebooks-again-including-windows-10-windows-8-1-windows-8-windows-7-office-2013-office-365-sharepoint-2013-dynamics-crm-powershell-exchange-server-lync-2013-system-center-azure-clo.aspx";
      }
    }

    private void LoadLanguages()
    {
      if (!File.Exists(Settings.Default.LanguageFileName))
      {
        CreateLanguageFile();
      }

      // read the translation file and feed the language
      XDocument xDoc = XDocument.Load(Settings.Default.LanguageFileName);
      var result = from node in xDoc.Descendants("term")
                   where node.HasElements
                   let xElementName = node.Element("name")
                   where xElementName != null
                   let xElementEnglish = node.Element("englishValue")
                   where xElementEnglish != null
                   let xElementFrench = node.Element("frenchValue")
                   where xElementFrench != null
                   select new
                   {
                     name = xElementName.Value,
                     englishValue = xElementEnglish.Value,
                     frenchValue = xElementFrench.Value
                   };
      foreach (var i in result)
      {
        _languageDicoEn.Add(i.name, i.englishValue);
        _languageDicoFr.Add(i.name, i.frenchValue);
      }
    }

    private static void CreateLanguageFile()
    {
      var minimumVersion = new List<string>
      {
        "<?xml version=\"1.0\" encoding=\"utf - 8\" ?>",
        "<Document>",
        "<DocumentVersion>",
        "<version> 1.0 </version>",
        "</DocumentVersion>",
        "<terms>",
         "<term>",
        "<name>MenuFile</name>",
        "<englishValue>File</englishValue>",
        "<frenchValue>Fichier</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFileNew</name>",
        "<englishValue>New</englishValue>",
        "<frenchValue>Nouveau</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFileOpen</name>",
        "<englishValue>Open</englishValue>",
        "<frenchValue>Ouvrir</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFileSave</name>",
        "<englishValue>Save</englishValue>",
        "<frenchValue>Enregistrer</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFileSaveAs</name>",
        "<englishValue>Save as ...</englishValue>",
        "<frenchValue>Enregistrer sous ...</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFilePrint</name>",
        "<englishValue>Print ...</englishValue>",
        "<frenchValue>Imprimer ...</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenufilePageSetup</name>",
          "<englishValue>Page setup</englishValue>",
          "<frenchValue>Aperçu avant impression</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenufileQuit</name>",
          "<englishValue>Quit</englishValue>",
          "<frenchValue>Quitter</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEdit</name>",
          "<englishValue>Edit</englishValue>",
          "<frenchValue>Edition</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditCancel</name>",
          "<englishValue>Cancel</englishValue>",
          "<frenchValue>Annuler</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditRedo</name>",
          "<englishValue>Redo</englishValue>",
          "<frenchValue>Rétablir</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditCut</name>",
          "<englishValue>Cut</englishValue>",
          "<frenchValue>Couper</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditCopy</name>",
          "<englishValue>Copy</englishValue>",
          "<frenchValue>Copier</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditPaste</name>",
          "<englishValue>Paste</englishValue>",
          "<frenchValue>Coller</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditSelectAll</name>",
          "<englishValue>Select All</englishValue>",
          "<frenchValue>Sélectionner tout</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuTools</name>",
          "<englishValue>Tools</englishValue>",
          "<frenchValue>Outils</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuToolsCustomize</name>",
          "<englishValue>Customize ...</englishValue>",
          "<frenchValue>Personaliser ...</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuToolsOptions</name>",
          "<englishValue>Options</englishValue>",
          "<frenchValue>Options</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuLanguage</name>",
          "<englishValue>Language</englishValue>",
          "<frenchValue>Langage</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuLanguageEnglish</name>",
          "<englishValue>English</englishValue>",
          "<frenchValue>Anglais</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuLanguageFrench</name>",
          "<englishValue>French</englishValue>",
          "<frenchValue>Français</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelp</name>",
          "<englishValue>Help</englishValue>",
          "<frenchValue>Aide</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelpSummary</name>",
          "<englishValue>Summary</englishValue>",
          "<frenchValue>Sommaire</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelpIndex</name>",
          "<englishValue>Index</englishValue>",
          "<frenchValue>Index</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelpSearch</name>",
          "<englishValue>Search</englishValue>",
          "<frenchValue>Rechercher</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelpAbout</name>",
          "<englishValue>About</englishValue>",
          "<frenchValue>A propos de ...</frenchValue>",
        "</term>",
        "</terms>",
        "</Document>"
      };
      StreamWriter sw = new StreamWriter(Settings.Default.LanguageFileName);
      foreach (string item in minimumVersion)
      {
        sw.WriteLine(item);
      }

      sw.Close();
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
      textBoxChangeUnknownFormat.Text = Settings.Default.textBoxChangeUnknownFormat;
      textBoxUrl.Text = Settings.Default.textBoxUrl;
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      Settings.Default.LastLanguageUsed = frenchToolStripMenuItem.Checked ? "French" : "English";
      Settings.Default.textBoxUrl = textBoxUrl.Text;
      Settings.Default.textBoxChangeUnknownFormat = textBoxChangeUnknownFormat.Text;
      Settings.Default.Save();
    }

    private void FormMainFormClosing(object sender, FormClosingEventArgs e)
    {
      SaveWindowValue();
    }

    private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _currentLanguage = Language.French.ToString();
      SetLanguage(Language.French.ToString());
    }

    private void englishToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _currentLanguage = Language.English.ToString();
      SetLanguage(Language.English.ToString());
    }

    private void SetLanguage(string myLanguage)
    {
      switch (myLanguage)
      {
        case "English":
          frenchToolStripMenuItem.Checked = false;
          englishToolStripMenuItem.Checked = true;
          fileToolStripMenuItem.Text = _languageDicoEn["MenuFile"];
          newToolStripMenuItem.Text = _languageDicoEn["MenuFileNew"];
          openToolStripMenuItem.Text = _languageDicoEn["MenuFileOpen"];
          saveToolStripMenuItem.Text = _languageDicoEn["MenuFileSave"];
          saveasToolStripMenuItem.Text = _languageDicoEn["MenuFileSaveAs"];
          printPreviewToolStripMenuItem.Text = _languageDicoEn["MenuFilePrint"];
          printPreviewToolStripMenuItem.Text = _languageDicoEn["MenufilePageSetup"];
          quitToolStripMenuItem.Text = _languageDicoEn["MenufileQuit"];
          editToolStripMenuItem.Text = _languageDicoEn["MenuEdit"];
          cancelToolStripMenuItem.Text = _languageDicoEn["MenuEditCancel"];
          redoToolStripMenuItem.Text = _languageDicoEn["MenuEditRedo"];
          cutToolStripMenuItem.Text = _languageDicoEn["MenuEditCut"];
          copyToolStripMenuItem.Text = _languageDicoEn["MenuEditCopy"];
          pasteToolStripMenuItem.Text = _languageDicoEn["MenuEditPaste"];
          selectAllToolStripMenuItem.Text = _languageDicoEn["MenuEditSelectAll"];
          toolsToolStripMenuItem.Text = _languageDicoEn["MenuTools"];
          personalizeToolStripMenuItem.Text = _languageDicoEn["MenuToolsCustomize"];
          optionsToolStripMenuItem.Text = _languageDicoEn["MenuToolsOptions"];
          languagetoolStripMenuItem.Text = _languageDicoEn["MenuLanguage"];
          englishToolStripMenuItem.Text = _languageDicoEn["MenuLanguageEnglish"];
          frenchToolStripMenuItem.Text = _languageDicoEn["MenuLanguageFrench"];
          helpToolStripMenuItem.Text = _languageDicoEn["MenuHelp"];
          summaryToolStripMenuItem.Text = _languageDicoEn["MenuHelpSummary"];
          indexToolStripMenuItem.Text = _languageDicoEn["MenuHelpIndex"];
          searchToolStripMenuItem.Text = _languageDicoEn["MenuHelpSearch"];
          aboutToolStripMenuItem.Text = _languageDicoEn["MenuHelpAbout"];
          buttonClearLogTextBox.Text = _languageDicoEn["Clear Log"];
          buttonSelectUnselectAll.Text = _languageDicoEn["Select-Unselect All"];
          labelSelectListViewItems.Text = _languageDicoEn["Select the PDF files you want to download"];
          buttonGetPdfFileList.Text = _languageDicoEn["Get Titles"];
          buttonDownloadSelectedItems.Text = _languageDicoEn["Download"];
          buttonDownloadAlleBooks.Text = _languageDicoEn["List all ebooks"];
          buttonClearAllItems.Text = _languageDicoEn["Unselect All"];
          buttonTogglePdf.Text = _languageDicoEn["Select-Unselect PDF"];
          buttonToggleEpub.Text = _languageDicoEn["Select-Unselect EPUB"];
          buttonToggleMobi.Text = _languageDicoEn["Select-Unselect MOBI"];
          buttonChangeUnknownFormat.Text = _languageDicoEn["Change unknown format to"];

          _currentLanguage = "English";
          break;
        case "French":
          frenchToolStripMenuItem.Checked = true;
          englishToolStripMenuItem.Checked = false;
          fileToolStripMenuItem.Text = _languageDicoFr["MenuFile"];
          newToolStripMenuItem.Text = _languageDicoFr["MenuFileNew"];
          openToolStripMenuItem.Text = _languageDicoFr["MenuFileOpen"];
          saveToolStripMenuItem.Text = _languageDicoFr["MenuFileSave"];
          saveasToolStripMenuItem.Text = _languageDicoFr["MenuFileSaveAs"];
          printPreviewToolStripMenuItem.Text = _languageDicoFr["MenuFilePrint"];
          printPreviewToolStripMenuItem.Text = _languageDicoFr["MenufilePageSetup"];
          quitToolStripMenuItem.Text = _languageDicoFr["MenufileQuit"];
          editToolStripMenuItem.Text = _languageDicoFr["MenuEdit"];
          cancelToolStripMenuItem.Text = _languageDicoFr["MenuEditCancel"];
          redoToolStripMenuItem.Text = _languageDicoFr["MenuEditRedo"];
          cutToolStripMenuItem.Text = _languageDicoFr["MenuEditCut"];
          copyToolStripMenuItem.Text = _languageDicoFr["MenuEditCopy"];
          pasteToolStripMenuItem.Text = _languageDicoFr["MenuEditPaste"];
          selectAllToolStripMenuItem.Text = _languageDicoFr["MenuEditSelectAll"];
          toolsToolStripMenuItem.Text = _languageDicoFr["MenuTools"];
          personalizeToolStripMenuItem.Text = _languageDicoFr["MenuToolsCustomize"];
          optionsToolStripMenuItem.Text = _languageDicoFr["MenuToolsOptions"];
          languagetoolStripMenuItem.Text = _languageDicoFr["MenuLanguage"];
          englishToolStripMenuItem.Text = _languageDicoFr["MenuLanguageEnglish"];
          frenchToolStripMenuItem.Text = _languageDicoFr["MenuLanguageFrench"];
          helpToolStripMenuItem.Text = _languageDicoFr["MenuHelp"];
          summaryToolStripMenuItem.Text = _languageDicoFr["MenuHelpSummary"];
          indexToolStripMenuItem.Text = _languageDicoFr["MenuHelpIndex"];
          searchToolStripMenuItem.Text = _languageDicoFr["MenuHelpSearch"];
          aboutToolStripMenuItem.Text = _languageDicoFr["MenuHelpAbout"];
          buttonClearLogTextBox.Text = _languageDicoFr["Clear Log"];
          buttonSelectUnselectAll.Text = _languageDicoFr["Select-Unselect All"];
          labelSelectListViewItems.Text = _languageDicoFr["Select the PDF files you want to download"];
          buttonGetPdfFileList.Text = _languageDicoFr["Get Titles"];
          buttonDownloadSelectedItems.Text = _languageDicoFr["Download"];
          buttonDownloadAlleBooks.Text = _languageDicoFr["List all ebooks"];
          buttonClearAllItems.Text = _languageDicoFr["Unselect All"];
          buttonTogglePdf.Text = _languageDicoFr["Select-Unselect PDF"];
          buttonToggleEpub.Text = _languageDicoFr["Select-Unselect EPUB"];
          buttonToggleMobi.Text = _languageDicoFr["Select-Unselect MOBI"];
          buttonChangeUnknownFormat.Text = _languageDicoFr["Change unknown format to"];
          _currentLanguage = "French";
          break;
      }
    }

    private void cutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { textBoxUrl });
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        CutToClipboard(tb);
      }
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { textBoxUrl });
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        CopyToClipboard(tb);
      }
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { textBoxUrl });
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        PasteFromClipboard(tb);
      }
    }

    private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { textBoxUrl });
      TextBox control = focusedControl as TextBox;
      if (control != null)
      {
        control.SelectAll();
      }
    }

    private void CutToClipboard(TextBoxBase tb, string errorMessage = "nothing")
    {
      if (tb != ActiveControl) return;
      if (tb.Text == string.Empty)
      {
        DisplayMessage(Translate("ThereIs") + Punctuation.OneSpace +
          Translate(errorMessage) + Punctuation.OneSpace +
          Translate("ToCut") + Punctuation.OneSpace, Translate(errorMessage),
          MessageBoxButtons.OK);
        return;
      }

      if (tb.SelectedText == string.Empty)
      {
        DisplayMessage(Translate("NoTextHasBeenSelected"),
          Translate(errorMessage), MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(tb.SelectedText);
      tb.SelectedText = string.Empty;
    }

    private void CopyToClipboard(TextBoxBase tb, string message = "nothing")
    {
      if (tb != ActiveControl) return;
      if (tb.Text == string.Empty)
      {
        DisplayMessage(Translate("ThereIsNothingToCopy") + Punctuation.OneSpace,
          Translate(message), MessageBoxButtons.OK);
        return;
      }

      if (tb.SelectedText == string.Empty)
      {
        DisplayMessage(Translate("NoTextHasBeenSelected"),
          Translate(message), MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(tb.SelectedText);
    }

    private void PasteFromClipboard(TextBoxBase tb)
    {
      if (tb != ActiveControl) return;
      var selectionIndex = tb.SelectionStart;
      tb.Text = tb.Text.Insert(selectionIndex, Clipboard.GetText());
      tb.SelectionStart = selectionIndex + Clipboard.GetText().Length;
    }

    private void DisplayMessage(string message, string title, MessageBoxButtons buttons)
    {
      MessageBox.Show(this, message, title, buttons);
    }

    private string Translate(string index)
    {
      string result = string.Empty;
      switch (_currentLanguage.ToLower())
      {
        case "english":
          result = _languageDicoEn.ContainsKey(index) ? _languageDicoEn[index] :
           "the term: \"" + index + "\" has not been translated yet.\nPlease add the translation term in the Translations.xml file or tell the developer to translate this term";
          break;
        case "french":
          result = _languageDicoFr.ContainsKey(index) ? _languageDicoFr[index] :
            "the term: \"" + index + "\" has not been translated yet.\nPlease add the translation term in the Translations.xml file or tell the developer to translate this term";
          break;
      }

      return result;
    }

    private static Control FindFocusedControl(List<Control> container)
    {
      return container.FirstOrDefault(control => control.Focused);
    }

    private static bool GetWebClientBinaries(string url = "http://www.google.com/",
      string fileName = "untitled-file.pdf")
    {
      WebClient client = new WebClient();
      bool result = false;
      // set the user agent to IE6
      client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; .NET CLR 1.0.3705;)");
      try
      {
        client.DownloadFile(url, fileName);
        result = true;
      }
      catch (WebException)
      {
        result = false;
      }
      catch (NotSupportedException)
      {
        result = false;
      }

      return result;
    }

    private void buttonSelectUnselect_Click(object sender, EventArgs e)
    {
      if (listViewPdfFiles.Items.Count != 0)
      {
        ToggleAllItems(listViewPdfFiles);
      }
    }

    private static void ToggleAllItems(ListView lvw)
    {
      lvw.Items.OfType<ListViewItem>().ToList().ForEach(item => item.Checked = !item.Checked);
    }

    private void buttonClearLogTextBox_Click(object sender, EventArgs e)
    {
      textBoxLog.Text = string.Empty;
    }

    private void buttonGetPdfFilesTitles_Click(object sender, EventArgs e)
    {
      Logger.Clear(textBoxLog);
      Logger.Add(textBoxLog, Translate("Clearing past results"));
      if (textBoxUrl.Text == string.Empty)
      {
        DisplayMessage(Translate("The URL is empty") +
          Punctuation.Period + Punctuation.NewLine +
          Translate("Enter a correct URL"),
          Translate("URL empty"), MessageBoxButtons.OK);
        Logger.Add(textBoxLog, Translate("The URL is empty"));
        return;
      }

      if (!UrlIsValid(textBoxUrl.Text))
      {
        DisplayMessage(Translate("The URL is not correct") +
          Punctuation.Period + Punctuation.NewLine +
          Translate("Enter a correct url"),
          Translate("Bad URL"), MessageBoxButtons.OK);
        Logger.Add(textBoxLog, Translate("The URL is not correct"));
        return;
      }

      Logger.Add(textBoxLog, Translate("Connecting to the url to get PDF files"));
      HttpWebRequest request = WebRequest.Create(textBoxUrl.Text) as HttpWebRequest;
      request.Method = "GET";
      HttpWebResponse response = request.GetResponse() as HttpWebResponse;
      int statusCode = (int)response.StatusCode;
      if (statusCode >= 100 && statusCode < 400) //Good requests
      {
        // parse response for some div
        Logger.Add(textBoxLog, "web response ok");
      }
      else
      {
        // bad request display error and quit
        Logger.Add(textBoxLog, "web response not ok - an error occured");
        return;
      }

      StreamReader responseStream = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

      string queryContent = responseStream.ReadToEnd();
      HtmlDocument doc = new HtmlDocument();
      doc.LoadHtml(queryContent);
      HtmlNode bodyNode = doc.DocumentNode.SelectSingleNode("//body | //BODY");
      var downloadList = new List<string>();
      var links = doc.DocumentNode.Descendants("a");
      foreach (var link in links)
      {
        downloadList.Add(link.InnerText);
        var href = link.Attributes["href"];
        if (href != null)
        {
          downloadList.Add(href.Value);
        }
      }

      downloadList = new List<string>();
      foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
      {
        downloadList.Add(link.InnerText);
      }

      listViewPdfFiles.Items.Clear();

      listViewPdfFiles.Columns.Add("To be updated", 240, HorizontalAlignment.Left);
      listViewPdfFiles.Columns.Add("PDF Name", 240, HorizontalAlignment.Left);
      listViewPdfFiles.Columns.Add("File Format", 240, HorizontalAlignment.Left);
      listViewPdfFiles.Columns.Add("URL", 640, HorizontalAlignment.Left);

      listViewPdfFiles.View = View.Details;
      listViewPdfFiles.LabelEdit = false;
      listViewPdfFiles.AllowColumnReorder = true;
      listViewPdfFiles.CheckBoxes = true;
      listViewPdfFiles.FullRowSelect = true;
      listViewPdfFiles.GridLines = true;
      listViewPdfFiles.Sorting = SortOrder.None;
      int PdfFileCount = 0;
      string tmpPdfFileName = "";
      string tmpPdfFiledescription = "";
      var listOfPdfFiles = new List<string>();
      if (listOfPdfFiles.Count != 0)
      {
        ListViewItem item1 = new ListViewItem(tmpPdfFileName) { Checked = false };
        item1.SubItems.Add(tmpPdfFileName);
        item1.SubItems.Add(tmpPdfFiledescription);
        listViewPdfFiles.Items.Add(item1);
        PdfFileCount++;
      }

      buttonDownloadSelectedItems.Enabled = true;
      Logger.Add(textBoxLog, PdfFileCount + Punctuation.OneSpace +
        Translate("PDF file") + Plural(PdfFileCount) +
        Punctuation.OneSpace + Translate(Plural(PdfFileCount, "has")) + Punctuation.OneSpace +
        Translate("been found") + FrenchPlural(PdfFileCount, _currentLanguage));
    }

    public static string InvertModifier(string text, bool correctCasing = true)
    {
      if (text == string.Empty)
      {
        return string.Empty;
      }

      if (text.Split(' ').Count() != 2)
      {
        return string.Empty;
      }

      string result = text.Split(' ')[1] + " ";
      result += correctCasing ? text.Split(' ')[0].ToLower() : text.Split(' ')[0];
      return result;
    }

    public static bool UrlIsValid(string url)
    {
      return url.StartsWith("http");
    }

    public static bool IsUrlValid(string url)
    {
      Uri uriResult;
      bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeHttp
                        || uriResult.Scheme == Uri.UriSchemeHttps);
      return result;
    }

    public static bool IsUrlWellFormed(string url)
    {
      return Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute);
    }

    private static string Plural(int number, string irregularNoun = "")
    {
      switch (irregularNoun)
      {
        case "":
          return number > 1 ? "s" : string.Empty;
        case "al":
          return number > 1 ? "aux" : "al";
        case "au":
          return number > 1 ? "aux" : "au";
        case "eau":
          return number > 1 ? "eaux" : "eau";
        case "eu":
          return number > 1 ? "eux" : "eu";
        case "landau":
          return number > 1 ? "landaus" : "landau";
        case "sarrau":
          return number > 1 ? "sarraus" : "sarrau";
        case "bleu":
          return number > 1 ? "bleus" : "bleu";
        case "émeu":
          return number > 1 ? "émeus" : "émeu";
        case "lieu":
          return number > 1 ? "lieux" : "lieu";
        case "pneu":
          return number > 1 ? "pneus" : "pneu";
        case "aval":
          return number > 1 ? "avals" : "aval";
        case "bal":
          return number > 1 ? "bals" : "bal";
        case "chacal":
          return number > 1 ? "chacals" : "chacal";
        case "carnaval":
          return number > 1 ? "carnavals" : "carnaval";
        case "festival":
          return number > 1 ? "festivals" : "festival";
        case "récital":
          return number > 1 ? "récitals" : "récital";
        case "régal":
          return number > 1 ? "régals" : "régal";
        case "cal":
          return number > 1 ? "cals" : "cal";
        case "serval":
          return number > 1 ? "servals" : "serval";
        case "choral":
          return number > 1 ? "chorals" : "choral";
        case "narval":
          return number > 1 ? "narvals" : "narval";
        case "bail":
          return number > 1 ? "baux" : "bail";
        case "corail":
          return number > 1 ? "coraux" : "corail";
        case "émail":
          return number > 1 ? "émaux" : "émail";
        case "soupirail":
          return number > 1 ? "soupiraux" : "soupirail";
        case "travail":
          return number > 1 ? "travaux" : "travail";
        case "vantail":
          return number > 1 ? "vantaux" : "vantail";
        case "vitrail":
          return number > 1 ? "vitraux" : "vitrail";
        case "bijou":
          return number > 1 ? "bijoux" : "bijou";
        case "caillou":
          return number > 1 ? "cailloux" : "caillou";
        case "chou":
          return number > 1 ? "choux" : "chou";
        case "genou":
          return number > 1 ? "genoux" : "genou";
        case "hibou":
          return number > 1 ? "hiboux" : "hibou";
        case "joujou":
          return number > 1 ? "joujoux" : "joujou";
        case "pou":
          return number > 1 ? "poux" : "pou";
        case "est":
          return number > 1 ? "sont" : "est";

        // English
        case " is":
          return number > 1 ? "s are" : " is"; // with a space before
        case "is":
          return number > 1 ? "are" : "is"; // without a space before
        case "The":
          return "The"; // CAPITAL useful when used with Translate method because of French plural
        case "the":
          return "the"; // lower case useful when used with Translate method because of French plural
        case "has":
          return number > 1 ? "have" : "has";
        default:
          return number > 1 ? "s" : string.Empty;
      }
    }

    private static string FrenchPlural(int number, string currentLanguage = "english")
    {
      return (number > 1 && currentLanguage.ToLower() == "french") ? "s" : string.Empty;
    }

    private void buttonDownloadSelectedItems_Click(object sender, EventArgs e)
    {
      foreach (ListViewItem row in listViewPdfFiles.CheckedItems)
      {
        string url = row.SubItems[3].Text;
        string bookName = row.SubItems[1].Text + "." + row.SubItems[2].Text;

        if (GetWebClientBinaries(url, bookName))
        {
          Logger.Add(textBoxLog, Translate("Download ok for ebook"));
          Logger.Add(textBoxLog, Translate("Name for ebook") + Punctuation.Colon + Punctuation.OneSpace + bookName);
        }
        else
        {
          Logger.Add(textBoxLog, Translate("Download not ok for ebook"));
          Logger.Add(textBoxLog, Translate("Name for ebook") + Punctuation.Colon + Punctuation.OneSpace + bookName);
          Logger.Add(textBoxLog, Translate("ebook url") + Punctuation.Colon + Punctuation.OneSpace + url);
        }
      }

      DisplayMessage(Translate("Download process is over"), Translate("Download over"), MessageBoxButtons.OK);
    }

    private void buttonDownloadAlleBooks_Click(object sender, EventArgs e)
    {
      Logger.Clear(textBoxLog);
      HttpWebRequest request = WebRequest.Create(textBoxUrl.Text) as HttpWebRequest;
      request.Method = "GET";
      HttpWebResponse response = request.GetResponse() as HttpWebResponse;
      int statusCode = (int)response.StatusCode;
      if (statusCode >= 100 && statusCode < 400) //Good requests
      {
        // parse response for some div
        Logger.Add(textBoxLog, Translate("web response ok"));
      }
      else
      {
        // bad request display error and quit
        Logger.Add(textBoxLog, Translate("web response not ok, error"));
        return;
      }

      StreamReader responseStream = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

      string queryContent = responseStream.ReadToEnd();
      HtmlDocument doc = new HtmlDocument();
      doc.LoadHtml(queryContent);
      var downloadList = new List<string>();
      var ebooks = new List<Tuple<string, string, string>>();
      var links = doc.DocumentNode.Descendants("a");
      foreach (var link in links)
      {
        downloadList.Add(link.InnerText);
        string name = link.InnerText;
        string url = "";
        string fileFormat = "";
        var href = link.Attributes["href"];
        if (href != null)
        {
          downloadList.Add(href.Value);
          url = href.Value;
        }
        var font = link.Attributes["font"];
        if (font != null)
        {
          fileFormat = font.ToString();
        }

        var ebook1 = new Tuple<string, string, string>(name, fileFormat, url);
        ebooks.Add(ebook1);
      }

      // removing bad entries
      var ebooksOK = new List<Tuple<string, string, string>>();
      var ebooksNOK = new List<Tuple<string, string, string>>();
      foreach (Tuple<string, string, string> t in ebooks)
      {
        if (IsInList(t.Item1, new[] { "ZIP", "EPUB", "MOBI", "PDF", "DOC", "XPS", "DOCX", "PPTX" }))
        {
          ebooksOK.Add(t);
        }
        else if (t.Item3.StartsWith("http://ligman.me/"))
        {
          ebooksOK.Add(t);
        }
        else
        {
          ebooksNOK.Add(t);
        }

      }

      ebooksNOK = null;
      ebooks = null;
      var ebooksNoFileFormat = new List<Tuple<string, string, string>>();
      var ebooksFileFormatOk = new List<Tuple<string, string, string>>();
      foreach (Tuple<string, string, string> t in ebooksOK)
      {
        if (t.Item1 == "")
        {
          ebooksNoFileFormat.Add(t);
        }
        else
        {
          ebooksFileFormatOk.Add(t);
        }
      }

      ebooksOK = null;
      var ebooksWellformatted = new List<Tuple<string, string, string>>();
      int bookNb = 1;
      foreach (Tuple<string, string, string> t in ebooksFileFormatOk)
      {
        if (IsInList(t.Item1, new[] { "ZIP", "EPUB", "MOBI", "PDF", "DOC", "XPS", "DOCX", "PPTX" }))
        {
          ebooksWellformatted.Add(Tuple.Create("ebook" + bookNb, t.Item1, t.Item3.Trim()));
          bookNb++;
        }
        else
        {
          ebooksWellformatted.Add(Tuple.Create(t.Item1, "UnknownFileFormat", t.Item3.Trim()));
        }
      }

      ebooksFileFormatOk = null;
      listViewPdfFiles.Items.Clear();
      listViewPdfFiles.Columns.Add("Download", 65, HorizontalAlignment.Left);
      listViewPdfFiles.Columns.Add("Book Name", 240, HorizontalAlignment.Left);
      listViewPdfFiles.Columns.Add("File Format", 240, HorizontalAlignment.Left);
      listViewPdfFiles.Columns.Add("URL", 640, HorizontalAlignment.Left);

      listViewPdfFiles.View = View.Details;
      listViewPdfFiles.LabelEdit = false;
      listViewPdfFiles.AllowColumnReorder = true;
      listViewPdfFiles.CheckBoxes = true;
      listViewPdfFiles.FullRowSelect = true;
      listViewPdfFiles.GridLines = true;
      listViewPdfFiles.Sorting = SortOrder.None;
      foreach (Tuple<string, string, string> t in ebooksWellformatted)
      {
        ListViewItem item1 = new ListViewItem("") { Checked = false };
        item1.SubItems.Add(t.Item1);
        item1.SubItems.Add(t.Item2);
        item1.SubItems.Add(t.Item3);
        listViewPdfFiles.Items.Add(item1);
      }

      ebooksWellformatted = null;
      EnableToggleButtons();
      buttonDownloadSelectedItems.Enabled = true;
      Logger.Add(textBoxLog, Translate("search is over, please check ebooks you want to download"));
    }

    public static bool IsInList(string word, string[] listOfWords)
    {
      bool result = false;
      // LINQ return listOfWords.Any(wordInList => string.Compare(word, wordInList, StringComparison.InvariantCultureIgnoreCase) == 0);
      foreach (string wordInList in listOfWords)
      {
        if (string.Compare(word, wordInList, StringComparison.InvariantCultureIgnoreCase) == 0)
        {
          result = true;
          break;
        }
      }

      return result;
    }

    private void EnableToggleButtons()
    {
      buttonToggleEpub.Enabled = true;
      buttonToggleMobi.Enabled = true;
      buttonTogglePdf.Enabled = true;
      buttonSelectUnselectAll.Enabled = true;
      buttonClearAllItems.Enabled = true;
      buttonChangeUnknownFormat.Enabled = true;
    }

    private void buttonTogglePdf_Click(object sender, EventArgs e)
    {
      if (listViewPdfFiles.Items.Count != 0)
      {
        ToggleAllItems(listViewPdfFiles, "pdf");
      }
    }

    private void buttonToggleEpub_Click(object sender, EventArgs e)
    {
      if (listViewPdfFiles.Items.Count != 0)
      {
        ToggleAllItems(listViewPdfFiles, "epub");
      }
    }

    private void buttonToggleMobi_Click(object sender, EventArgs e)
    {
      if (listViewPdfFiles.Items.Count != 0)
      {
        ToggleAllItems(listViewPdfFiles, "mobi");
      }
    }

    private static void ToggleAllItems(ListView lvw, string fileFormat)
    {
      if (lvw.Items.Count != 0)
      {
        foreach (ListViewItem row in lvw.Items)
        {
          if (string.Equals(row.SubItems[2].Text, fileFormat, StringComparison.CurrentCultureIgnoreCase))
          {
            row.Checked = !row.Checked;
          }
        }
      }
    }

    private void buttonClearAllItems_Click(object sender, EventArgs e)
    {
      if (listViewPdfFiles.Items.Count != 0)
      {
        foreach (ListViewItem row in listViewPdfFiles.Items)
        {
          row.Checked = false;
        }
      }
    }

    private void buttonChangeUnknownFormat_Click(object sender, EventArgs e)
    {
      if (listViewPdfFiles.Items.Count != 0)
      {
        if (textBoxChangeUnknownFormat.Text != string.Empty)
        {
          foreach (ListViewItem row in listViewPdfFiles.Items)
          {
            if (string.Equals(row.SubItems[2].Text, "UnknownFileFormat", StringComparison.CurrentCultureIgnoreCase))
            {
              row.SubItems[2].Text = textBoxChangeUnknownFormat.Text;
            }
          }
        }
      }
    }
  }
}