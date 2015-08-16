namespace DownloadPDF
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.personalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.languagetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.labelUrl = new System.Windows.Forms.Label();
      this.textBoxUrl = new System.Windows.Forms.TextBox();
      this.buttonGetPdfFileList = new System.Windows.Forms.Button();
      this.listViewPdfFiles = new System.Windows.Forms.ListView();
      this.buttonSelectUnselectAll = new System.Windows.Forms.Button();
      this.textBoxLog = new System.Windows.Forms.TextBox();
      this.buttonClearLogTextBox = new System.Windows.Forms.Button();
      this.labelSelectListViewItems = new System.Windows.Forms.Label();
      this.buttonDownloadSelectedItems = new System.Windows.Forms.Button();
      this.buttonDownloadAlleBooks = new System.Windows.Forms.Button();
      this.buttonTogglePdf = new System.Windows.Forms.Button();
      this.buttonToggleEpub = new System.Windows.Forms.Button();
      this.buttonToggleMobi = new System.Windows.Forms.Button();
      this.buttonClearAllItems = new System.Windows.Forms.Button();
      this.buttonChangeUnknownFormat = new System.Windows.Forms.Button();
      this.textBoxChangeUnknownFormat = new System.Windows.Forms.TextBox();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.languagetoolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(1010, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveasToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
      this.fileToolStripMenuItem.Text = "&Fichier";
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.newToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.newToolStripMenuItem.Text = "&Nouveau";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.openToolStripMenuItem.Text = "&Ouvrir";
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(202, 6);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.saveToolStripMenuItem.Text = "&Enregistrer";
      // 
      // saveasToolStripMenuItem
      // 
      this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
      this.saveasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.saveasToolStripMenuItem.Text = "Enregistrer &sous";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
      // 
      // printToolStripMenuItem
      // 
      this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.printToolStripMenuItem.Name = "printToolStripMenuItem";
      this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.printToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.printToolStripMenuItem.Text = "&Imprimer";
      // 
      // printPreviewToolStripMenuItem
      // 
      this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
      this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.printPreviewToolStripMenuItem.Text = "Aperçu a&vant impression";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
      // 
      // quitToolStripMenuItem
      // 
      this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
      this.quitToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.quitToolStripMenuItem.Text = "&Quitter";
      this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
      this.editToolStripMenuItem.Text = "&Edition";
      // 
      // cancelToolStripMenuItem
      // 
      this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
      this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.cancelToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.cancelToolStripMenuItem.Text = "&Annuler";
      // 
      // redoToolStripMenuItem
      // 
      this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
      this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.redoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.redoToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
      // 
      // cutToolStripMenuItem
      // 
      this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
      this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.cutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.cutToolStripMenuItem.Text = "&Couper";
      this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.copyToolStripMenuItem.Text = "Co&pier";
      this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
      // 
      // pasteToolStripMenuItem
      // 
      this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.pasteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.pasteToolStripMenuItem.Text = "Co&ller";
      this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
      // 
      // selectAllToolStripMenuItem
      // 
      this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
      this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.selectAllToolStripMenuItem.Text = "Sélectio&nner tout";
      this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
      // 
      // toolsToolStripMenuItem
      // 
      this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
      this.toolsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.toolsToolStripMenuItem.Text = "&Outils";
      // 
      // personalizeToolStripMenuItem
      // 
      this.personalizeToolStripMenuItem.Name = "personalizeToolStripMenuItem";
      this.personalizeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.personalizeToolStripMenuItem.Text = "&Personnaliser";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.optionsToolStripMenuItem.Text = "&Options";
      // 
      // languagetoolStripMenuItem
      // 
      this.languagetoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frenchToolStripMenuItem,
            this.englishToolStripMenuItem});
      this.languagetoolStripMenuItem.Name = "languagetoolStripMenuItem";
      this.languagetoolStripMenuItem.Size = new System.Drawing.Size(71, 20);
      this.languagetoolStripMenuItem.Text = "Language";
      // 
      // frenchToolStripMenuItem
      // 
      this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
      this.frenchToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
      this.frenchToolStripMenuItem.Text = "Français";
      this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
      // 
      // englishToolStripMenuItem
      // 
      this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
      this.englishToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
      this.englishToolStripMenuItem.Text = "Anglais";
      this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.helpToolStripMenuItem.Text = "&Aide";
      // 
      // summaryToolStripMenuItem
      // 
      this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
      this.summaryToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.summaryToolStripMenuItem.Text = "&Sommaire";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.indexToolStripMenuItem.Text = "&Index";
      // 
      // searchToolStripMenuItem
      // 
      this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
      this.searchToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.searchToolStripMenuItem.Text = "&Rechercher";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(144, 6);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.aboutToolStripMenuItem.Text = "À &propos de...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
      // 
      // labelUrl
      // 
      this.labelUrl.AutoSize = true;
      this.labelUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelUrl.Location = new System.Drawing.Point(16, 47);
      this.labelUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelUrl.Name = "labelUrl";
      this.labelUrl.Size = new System.Drawing.Size(40, 17);
      this.labelUrl.TabIndex = 2;
      this.labelUrl.Text = "URL:";
      // 
      // textBoxUrl
      // 
      this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxUrl.Location = new System.Drawing.Point(56, 44);
      this.textBoxUrl.Margin = new System.Windows.Forms.Padding(2);
      this.textBoxUrl.Name = "textBoxUrl";
      this.textBoxUrl.Size = new System.Drawing.Size(937, 23);
      this.textBoxUrl.TabIndex = 3;
      this.textBoxUrl.Text = resources.GetString("textBoxUrl.Text");
      // 
      // buttonGetPdfFileList
      // 
      this.buttonGetPdfFileList.Enabled = false;
      this.buttonGetPdfFileList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonGetPdfFileList.Location = new System.Drawing.Point(340, 238);
      this.buttonGetPdfFileList.Margin = new System.Windows.Forms.Padding(2);
      this.buttonGetPdfFileList.Name = "buttonGetPdfFileList";
      this.buttonGetPdfFileList.Size = new System.Drawing.Size(138, 25);
      this.buttonGetPdfFileList.TabIndex = 4;
      this.buttonGetPdfFileList.Text = "Get Titles";
      this.buttonGetPdfFileList.UseVisualStyleBackColor = true;
      this.buttonGetPdfFileList.Click += new System.EventHandler(this.buttonGetPdfFilesTitles_Click);
      // 
      // listViewPdfFiles
      // 
      this.listViewPdfFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listViewPdfFiles.Location = new System.Drawing.Point(19, 336);
      this.listViewPdfFiles.Margin = new System.Windows.Forms.Padding(2);
      this.listViewPdfFiles.Name = "listViewPdfFiles";
      this.listViewPdfFiles.Size = new System.Drawing.Size(974, 311);
      this.listViewPdfFiles.TabIndex = 5;
      this.listViewPdfFiles.UseCompatibleStateImageBehavior = false;
      // 
      // buttonSelectUnselectAll
      // 
      this.buttonSelectUnselectAll.Enabled = false;
      this.buttonSelectUnselectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonSelectUnselectAll.Location = new System.Drawing.Point(180, 269);
      this.buttonSelectUnselectAll.Margin = new System.Windows.Forms.Padding(2);
      this.buttonSelectUnselectAll.Name = "buttonSelectUnselectAll";
      this.buttonSelectUnselectAll.Size = new System.Drawing.Size(170, 25);
      this.buttonSelectUnselectAll.TabIndex = 6;
      this.buttonSelectUnselectAll.Text = "Select-Unselect All";
      this.buttonSelectUnselectAll.UseVisualStyleBackColor = true;
      this.buttonSelectUnselectAll.Click += new System.EventHandler(this.buttonSelectUnselect_Click);
      // 
      // textBoxLog
      // 
      this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxLog.Location = new System.Drawing.Point(19, 118);
      this.textBoxLog.Margin = new System.Windows.Forms.Padding(2);
      this.textBoxLog.Multiline = true;
      this.textBoxLog.Name = "textBoxLog";
      this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxLog.Size = new System.Drawing.Size(974, 108);
      this.textBoxLog.TabIndex = 15;
      this.textBoxLog.Text = "Log";
      // 
      // buttonClearLogTextBox
      // 
      this.buttonClearLogTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonClearLogTextBox.Location = new System.Drawing.Point(19, 80);
      this.buttonClearLogTextBox.Margin = new System.Windows.Forms.Padding(2);
      this.buttonClearLogTextBox.Name = "buttonClearLogTextBox";
      this.buttonClearLogTextBox.Size = new System.Drawing.Size(99, 25);
      this.buttonClearLogTextBox.TabIndex = 19;
      this.buttonClearLogTextBox.Text = "Clear Log";
      this.buttonClearLogTextBox.UseVisualStyleBackColor = true;
      this.buttonClearLogTextBox.Click += new System.EventHandler(this.buttonClearLogTextBox_Click);
      // 
      // labelSelectListViewItems
      // 
      this.labelSelectListViewItems.AutoSize = true;
      this.labelSelectListViewItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelSelectListViewItems.Location = new System.Drawing.Point(21, 238);
      this.labelSelectListViewItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelSelectListViewItems.Name = "labelSelectListViewItems";
      this.labelSelectListViewItems.Size = new System.Drawing.Size(306, 20);
      this.labelSelectListViewItems.TabIndex = 20;
      this.labelSelectListViewItems.Text = "Select the PDF files you want to download";
      // 
      // buttonDownloadSelectedItems
      // 
      this.buttonDownloadSelectedItems.Enabled = false;
      this.buttonDownloadSelectedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonDownloadSelectedItems.Location = new System.Drawing.Point(488, 238);
      this.buttonDownloadSelectedItems.Margin = new System.Windows.Forms.Padding(2);
      this.buttonDownloadSelectedItems.Name = "buttonDownloadSelectedItems";
      this.buttonDownloadSelectedItems.Size = new System.Drawing.Size(97, 25);
      this.buttonDownloadSelectedItems.TabIndex = 21;
      this.buttonDownloadSelectedItems.Text = "Download";
      this.buttonDownloadSelectedItems.UseVisualStyleBackColor = true;
      this.buttonDownloadSelectedItems.Click += new System.EventHandler(this.buttonDownloadSelectedItems_Click);
      // 
      // buttonDownloadAlleBooks
      // 
      this.buttonDownloadAlleBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonDownloadAlleBooks.Location = new System.Drawing.Point(592, 238);
      this.buttonDownloadAlleBooks.Margin = new System.Windows.Forms.Padding(2);
      this.buttonDownloadAlleBooks.Name = "buttonDownloadAlleBooks";
      this.buttonDownloadAlleBooks.Size = new System.Drawing.Size(154, 25);
      this.buttonDownloadAlleBooks.TabIndex = 22;
      this.buttonDownloadAlleBooks.Text = "List all ebooks";
      this.buttonDownloadAlleBooks.UseVisualStyleBackColor = true;
      this.buttonDownloadAlleBooks.Click += new System.EventHandler(this.buttonDownloadAlleBooks_Click);
      // 
      // buttonTogglePdf
      // 
      this.buttonTogglePdf.Enabled = false;
      this.buttonTogglePdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonTogglePdf.Location = new System.Drawing.Point(368, 269);
      this.buttonTogglePdf.Margin = new System.Windows.Forms.Padding(2);
      this.buttonTogglePdf.Name = "buttonTogglePdf";
      this.buttonTogglePdf.Size = new System.Drawing.Size(170, 25);
      this.buttonTogglePdf.TabIndex = 23;
      this.buttonTogglePdf.Text = "Select-Unselect PDF";
      this.buttonTogglePdf.UseVisualStyleBackColor = true;
      this.buttonTogglePdf.Click += new System.EventHandler(this.buttonTogglePdf_Click);
      // 
      // buttonToggleEpub
      // 
      this.buttonToggleEpub.Enabled = false;
      this.buttonToggleEpub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonToggleEpub.Location = new System.Drawing.Point(563, 269);
      this.buttonToggleEpub.Margin = new System.Windows.Forms.Padding(2);
      this.buttonToggleEpub.Name = "buttonToggleEpub";
      this.buttonToggleEpub.Size = new System.Drawing.Size(170, 25);
      this.buttonToggleEpub.TabIndex = 24;
      this.buttonToggleEpub.Text = "Select-Unselect EPUB";
      this.buttonToggleEpub.UseVisualStyleBackColor = true;
      this.buttonToggleEpub.Click += new System.EventHandler(this.buttonToggleEpub_Click);
      // 
      // buttonToggleMobi
      // 
      this.buttonToggleMobi.Enabled = false;
      this.buttonToggleMobi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonToggleMobi.Location = new System.Drawing.Point(742, 269);
      this.buttonToggleMobi.Margin = new System.Windows.Forms.Padding(2);
      this.buttonToggleMobi.Name = "buttonToggleMobi";
      this.buttonToggleMobi.Size = new System.Drawing.Size(170, 25);
      this.buttonToggleMobi.TabIndex = 25;
      this.buttonToggleMobi.Text = "Select-Unselect MOBI";
      this.buttonToggleMobi.UseVisualStyleBackColor = true;
      this.buttonToggleMobi.Click += new System.EventHandler(this.buttonToggleMobi_Click);
      // 
      // buttonClearAllItems
      // 
      this.buttonClearAllItems.Enabled = false;
      this.buttonClearAllItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonClearAllItems.Location = new System.Drawing.Point(19, 269);
      this.buttonClearAllItems.Margin = new System.Windows.Forms.Padding(2);
      this.buttonClearAllItems.Name = "buttonClearAllItems";
      this.buttonClearAllItems.Size = new System.Drawing.Size(157, 25);
      this.buttonClearAllItems.TabIndex = 26;
      this.buttonClearAllItems.Text = "Unselect All";
      this.buttonClearAllItems.UseVisualStyleBackColor = true;
      this.buttonClearAllItems.Click += new System.EventHandler(this.buttonClearAllItems_Click);
      // 
      // buttonChangeUnknownFormat
      // 
      this.buttonChangeUnknownFormat.Enabled = false;
      this.buttonChangeUnknownFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonChangeUnknownFormat.Location = new System.Drawing.Point(19, 298);
      this.buttonChangeUnknownFormat.Margin = new System.Windows.Forms.Padding(2);
      this.buttonChangeUnknownFormat.Name = "buttonChangeUnknownFormat";
      this.buttonChangeUnknownFormat.Size = new System.Drawing.Size(331, 25);
      this.buttonChangeUnknownFormat.TabIndex = 27;
      this.buttonChangeUnknownFormat.Text = "Change unknown format to";
      this.buttonChangeUnknownFormat.UseVisualStyleBackColor = true;
      this.buttonChangeUnknownFormat.Click += new System.EventHandler(this.buttonChangeUnknownFormat_Click);
      // 
      // textBoxChangeUnknownFormat
      // 
      this.textBoxChangeUnknownFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxChangeUnknownFormat.Location = new System.Drawing.Point(368, 303);
      this.textBoxChangeUnknownFormat.Name = "textBoxChangeUnknownFormat";
      this.textBoxChangeUnknownFormat.Size = new System.Drawing.Size(170, 23);
      this.textBoxChangeUnknownFormat.TabIndex = 28;
      this.textBoxChangeUnknownFormat.Text = "txt";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1010, 665);
      this.Controls.Add(this.textBoxChangeUnknownFormat);
      this.Controls.Add(this.buttonChangeUnknownFormat);
      this.Controls.Add(this.buttonClearAllItems);
      this.Controls.Add(this.buttonToggleMobi);
      this.Controls.Add(this.buttonToggleEpub);
      this.Controls.Add(this.buttonTogglePdf);
      this.Controls.Add(this.buttonDownloadAlleBooks);
      this.Controls.Add(this.buttonDownloadSelectedItems);
      this.Controls.Add(this.labelSelectListViewItems);
      this.Controls.Add(this.buttonClearLogTextBox);
      this.Controls.Add(this.textBoxLog);
      this.Controls.Add(this.buttonSelectUnselectAll);
      this.Controls.Add(this.listViewPdfFiles);
      this.Controls.Add(this.buttonGetPdfFileList);
      this.Controls.Add(this.textBoxUrl);
      this.Controls.Add(this.labelUrl);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "FormMain";
      this.ShowIcon = false;
      this.Text = "Download PDF files";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainFormClosing);
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveasToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem personalizeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem languagetoolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    private System.Windows.Forms.Label labelUrl;
    private System.Windows.Forms.TextBox textBoxUrl;
    private System.Windows.Forms.Button buttonGetPdfFileList;
    private System.Windows.Forms.ListView listViewPdfFiles;
    private System.Windows.Forms.Button buttonSelectUnselectAll;
    private System.Windows.Forms.TextBox textBoxLog;
    private System.Windows.Forms.Button buttonClearLogTextBox;
    private System.Windows.Forms.Label labelSelectListViewItems;
    private System.Windows.Forms.Button buttonDownloadSelectedItems;
    private System.Windows.Forms.Button buttonDownloadAlleBooks;
    private System.Windows.Forms.Button buttonTogglePdf;
    private System.Windows.Forms.Button buttonToggleEpub;
    private System.Windows.Forms.Button buttonToggleMobi;
    private System.Windows.Forms.Button buttonClearAllItems;
    private System.Windows.Forms.Button buttonChangeUnknownFormat;
    private System.Windows.Forms.TextBox textBoxChangeUnknownFormat;
  }
}