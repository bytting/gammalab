namespace GammaGUI
{
    partial class FormGammaGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGammaGUI));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.wizardMain = new TabControlWizard.TabControlWizard();
            this.pageMenu = new System.Windows.Forms.TabPage();
            this.flowMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonMenuDetectors = new System.Windows.Forms.Button();
            this.buttonMenuArchive = new System.Windows.Forms.Button();
            this.buttonMenuLibraries = new System.Windows.Forms.Button();
            this.toolsMain = new System.Windows.Forms.ToolStrip();
            this.labelMain = new System.Windows.Forms.ToolStripLabel();
            this.pageSelDet = new System.Windows.Forms.TabPage();
            this.panelStartStop = new System.Windows.Forms.Panel();
            this.flowMenuDetectors = new System.Windows.Forms.FlowLayoutPanel();
            this.toolsStartStop = new System.Windows.Forms.ToolStrip();
            this.buttonStartStopBack = new System.Windows.Forms.ToolStripButton();
            this.labelStartStopTitle = new System.Windows.Forms.ToolStripLabel();
            this.pageReAnal = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.splitterEditAnal = new System.Windows.Forms.SplitContainer();
            this.panelReAnalTopMiddle = new System.Windows.Forms.Panel();
            this.dialogReAnalNuclLib = new VintageControls.LabeledFileDialog();
            this.txtReAnalSampleStop = new VintageControls.LabeledTextBox();
            this.txtReAnalQuantityUncertainty = new VintageControls.LabeledTextBox();
            this.txtReAnalSampleHeight = new VintageControls.LabeledTextBox();
            this.txtReAnalSamplePlace = new VintageControls.LabeledTextBox();
            this.txtReAnalYear = new VintageControls.LabeledTextBox();
            this.panelReAnalTopRight = new System.Windows.Forms.Panel();
            this.dialogReAnalDetLimLib = new VintageControls.LabeledFileDialog();
            this.cboxReAnalSignature = new VintageControls.LabeledComboBox();
            this.cboxReAnalSampQuantUnit = new VintageControls.LabeledComboBox();
            this.txtReAnalSampleWeight = new VintageControls.LabeledTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtReAnalSpecnum = new VintageControls.LabeledTextBox();
            this.panelReAnalTopLeft = new System.Windows.Forms.Panel();
            this.labelReAnalPath = new System.Windows.Forms.Label();
            this.txtReAnalReferenceTime = new VintageControls.LabeledTextBox();
            this.txtReAnalSampleStart = new VintageControls.LabeledTextBox();
            this.txtReAnalQuantity = new VintageControls.LabeledTextBox();
            this.cboxReAnalSampBeaker = new VintageControls.LabeledComboBox();
            this.txtReAnalSampleId = new VintageControls.LabeledTextBox();
            this.txtReAnalDetector = new VintageControls.LabeledTextBox();
            this.panelReAnalBottomMiddle = new System.Windows.Forms.Panel();
            this.txtReAnalVolume = new VintageControls.LabeledTextBox();
            this.dialogReAnalPefFile = new VintageControls.LabeledFileDialog();
            this.dialogReAnalBackgroundFile = new VintageControls.LabeledFileDialog();
            this.txtReAnalETOL = new VintageControls.LabeledTextBox();
            this.txtReAnalFWHMAN = new VintageControls.LabeledTextBox();
            this.cboxReAnalSampMethod = new VintageControls.LabeledComboBox();
            this.txtReAnalRealtime = new VintageControls.LabeledTextBox();
            this.txtReAnalMeasurementStop = new VintageControls.LabeledTextBox();
            this.panel48 = new System.Windows.Forms.Panel();
            this.panelReAnalBottomRight = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonReAnalRecalculate = new System.Windows.Forms.Button();
            this.dialogReAnalTefFile = new VintageControls.LabeledFileDialog();
            this.dialogReAnalEnergyFile = new VintageControls.LabeledFileDialog();
            this.txtReAnalLOCH = new VintageControls.LabeledTextBox();
            this.txtReAnalTHRESH = new VintageControls.LabeledTextBox();
            this.txtReAnalRecLen = new VintageControls.LabeledTextBox();
            this.txtReAnalDeadtime = new VintageControls.LabeledTextBox();
            this.txtReAnalMeasurementTime = new VintageControls.LabeledTextBox();
            this.panel51 = new System.Windows.Forms.Panel();
            this.panelReAnalBottomLeft = new System.Windows.Forms.Panel();
            this.txtReAnalDensity = new VintageControls.LabeledTextBox();
            this.txtReAnalFormat = new VintageControls.LabeledTextBox();
            this.cbReAnalICA = new VintageControls.LabeledCheckBox();
            this.txtReAnalBSTF = new VintageControls.LabeledTextBox();
            this.txtReAnalFWHMPS = new VintageControls.LabeledTextBox();
            this.cboxReAnalSampChannels = new VintageControls.LabeledComboBox();
            this.txtReAnalLivetime = new VintageControls.LabeledTextBox();
            this.txtReAnalMeasurementStart = new VintageControls.LabeledTextBox();
            this.panel55 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.toolsReAnal = new System.Windows.Forms.ToolStrip();
            this.buttonReAnalBack = new System.Windows.Forms.ToolStripButton();
            this.labelEditAnalyzeTitle = new System.Windows.Forms.ToolStripLabel();
            this.buttonReAnalCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonReAnal = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonReAnalToggleAdvanced = new System.Windows.Forms.ToolStripButton();
            this.pageAnal = new System.Windows.Forms.TabPage();
            this.splitterNewAnal = new System.Windows.Forms.SplitContainer();
            this.panelAnalTopMiddle = new System.Windows.Forms.Panel();
            this.dialogAnalNuclLib = new VintageControls.LabeledFileDialog();
            this.txtAnalSamplingStop = new VintageControls.LabeledTextBox();
            this.txtAnalQuantityUncertainty = new VintageControls.LabeledTextBox();
            this.txtAnalHeight = new VintageControls.LabeledTextBox();
            this.txtAnalSamplePlace = new VintageControls.LabeledTextBox();
            this.txtAnalYear = new VintageControls.LabeledTextBox();
            this.panelAnalTopRight = new System.Windows.Forms.Panel();
            this.dialogAnalDetLimLib = new VintageControls.LabeledFileDialog();
            this.cboxAnalSignature = new VintageControls.LabeledComboBox();
            this.cboxAnalSampQuantUnit = new VintageControls.LabeledComboBox();
            this.txtAnalWeight = new VintageControls.LabeledTextBox();
            this.panel29 = new System.Windows.Forms.Panel();
            this.txtAnalSpecNum = new VintageControls.LabeledTextBox();
            this.panelAnalTopLeft = new System.Windows.Forms.Panel();
            this.txtAnalReferenceTime = new VintageControls.LabeledTextBox();
            this.txtAnalSamplingStart = new VintageControls.LabeledTextBox();
            this.txtAnalQuantity = new VintageControls.LabeledTextBox();
            this.cboxAnalSampBeaker = new VintageControls.LabeledComboBox();
            this.txtAnalSampleId = new VintageControls.LabeledTextBox();
            this.txtAnalDetector = new VintageControls.LabeledTextBox();
            this.panelAnalBottomMiddle = new System.Windows.Forms.Panel();
            this.txtAnalVolume = new VintageControls.LabeledTextBox();
            this.labeledTextBox31 = new VintageControls.LabeledTextBox();
            this.labeledTextBox28 = new VintageControls.LabeledTextBox();
            this.panel27 = new System.Windows.Forms.Panel();
            this.dialogAnalPEFFile = new VintageControls.LabeledFileDialog();
            this.dialogAnalBackgroundFile = new VintageControls.LabeledFileDialog();
            this.txtAnalETOL = new VintageControls.LabeledTextBox();
            this.txtAnalFWHMAN = new VintageControls.LabeledTextBox();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panelAnalBottomRight = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.buttonAnalRecalculate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeledTextBox29 = new VintageControls.LabeledTextBox();
            this.panel28 = new System.Windows.Forms.Panel();
            this.dialogAnalTEFFile = new VintageControls.LabeledFileDialog();
            this.dialogAnalEnergyFile = new VintageControls.LabeledFileDialog();
            this.txtAnalLOCH = new VintageControls.LabeledTextBox();
            this.txtAnalTHRESH = new VintageControls.LabeledTextBox();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panelAnalBottomLeft = new System.Windows.Forms.Panel();
            this.txtAnalDensity = new VintageControls.LabeledTextBox();
            this.labeledTextBox30 = new VintageControls.LabeledTextBox();
            this.labeledTextBox19 = new VintageControls.LabeledTextBox();
            this.panel26 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.cbAnalICA = new VintageControls.LabeledCheckBox();
            this.txtAnalBSTF = new VintageControls.LabeledTextBox();
            this.txtAnalFWHMPS = new VintageControls.LabeledTextBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.toolsStartStopView = new System.Windows.Forms.ToolStrip();
            this.buttonStartStopViewBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonAnalStart = new System.Windows.Forms.ToolStripButton();
            this.buttonAnalStop = new System.Windows.Forms.ToolStripButton();
            this.buttonAnalBuffer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonAnalToggleAdvanced = new System.Windows.Forms.ToolStripButton();
            this.labelAnalMeasurement = new System.Windows.Forms.ToolStripLabel();
            this.labelStartStopView = new System.Windows.Forms.ToolStripLabel();
            this.pageAdmin = new System.Windows.Forms.TabPage();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.pageAdminConfig = new System.Windows.Forms.TabPage();
            this.panel50 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.cbAdminEmulateFixCHN = new System.Windows.Forms.CheckBox();
            this.cbAdminUseDafaultPrinter = new System.Windows.Forms.CheckBox();
            this.panel57 = new System.Windows.Forms.Panel();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel56 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.labeledFileDialog18 = new VintageControls.LabeledFileDialog();
            this.labeledFileDialog17 = new VintageControls.LabeledFileDialog();
            this.dialogAdminDefDetLib = new VintageControls.LabeledFileDialog();
            this.dialogAdminDefNuclLib = new VintageControls.LabeledFileDialog();
            this.panel54 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panelAdminSetup = new System.Windows.Forms.Panel();
            this.pageAdminDetectors = new System.Windows.Forms.TabPage();
            this.listViewAdminDetectors = new System.Windows.Forms.ListView();
            this.columnAdminDetectorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAdminSpecSoft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAdminDetectorType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAdminDetectorActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAdminDetectorConnected = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel58 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.buttonAdminDetSave = new System.Windows.Forms.Button();
            this.cboxAdminDetPefTef = new VintageControls.LabeledComboBox();
            this.panel65 = new System.Windows.Forms.Panel();
            this.cboxAdminDetBkgFiles = new VintageControls.LabeledComboBox();
            this.panel61 = new System.Windows.Forms.Panel();
            this.txtAdminDetETOL = new VintageControls.LabeledTextBox();
            this.cbAdminICA = new VintageControls.LabeledCheckBox();
            this.txtAdminDetFWHMAN = new VintageControls.LabeledTextBox();
            this.panel63 = new System.Windows.Forms.Panel();
            this.txtAdminDetComment = new VintageControls.LabeledTextBox();
            this.cboxAdminDetRecords = new VintageControls.LabeledComboBox();
            this.panel62 = new System.Windows.Forms.Panel();
            this.cbAdminDetActive = new System.Windows.Forms.CheckBox();
            this.cbAdminDetConnected = new System.Windows.Forms.CheckBox();
            this.cbAdminDetDummy = new System.Windows.Forms.CheckBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.labelAdminDetDetector = new System.Windows.Forms.Label();
            this.panel59 = new System.Windows.Forms.Panel();
            this.cboxAdminDetBeakers = new VintageControls.LabeledComboBox();
            this.panel64 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cboxAdminDetEngFiles = new VintageControls.LabeledComboBox();
            this.txtAdminDetLOCH = new VintageControls.LabeledTextBox();
            this.txtAdminDetBSTF = new VintageControls.LabeledTextBox();
            this.txtAdminDetTHRESH = new VintageControls.LabeledTextBox();
            this.txtAdminDetFWHMPS = new VintageControls.LabeledTextBox();
            this.panel60 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cboxAdminDetSpecFmt = new VintageControls.LabeledComboBox();
            this.cboxAdminDetChannels = new VintageControls.LabeledComboBox();
            this.txtAdminDetID = new VintageControls.LabeledTextBox();
            this.panel68 = new System.Windows.Forms.Panel();
            this.labelAdminDetTitle = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.pageAdminBeaker = new System.Windows.Forms.TabPage();
            this.panelAdmBeakerConf = new System.Windows.Forms.Panel();
            this.lvAdmBeakers = new System.Windows.Forms.ListView();
            this.headerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerRadius = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerInnerRadius = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerInnerHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelAdmBeakerConfParam = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.buttonAdminBeaSave = new System.Windows.Forms.Button();
            this.txtAdminBeakerComment = new VintageControls.LabeledTextBox();
            this.txtAdminBeakerManufacturer = new VintageControls.LabeledTextBox();
            this.txtAdminBeakerMaxFillHeight = new VintageControls.LabeledTextBox();
            this.txtAdminBeakerMinFillHeight = new VintageControls.LabeledTextBox();
            this.txtAdminBeakerInnerHeight = new VintageControls.LabeledTextBox();
            this.txtAdminBeakerInnerRadius = new VintageControls.LabeledTextBox();
            this.cbAdminBeakerMarinelli = new System.Windows.Forms.CheckBox();
            this.txtAdminBeakerHeight = new VintageControls.LabeledTextBox();
            this.txtAdminBeakerRadius = new VintageControls.LabeledTextBox();
            this.txtAdminBeakerName = new VintageControls.LabeledTextBox();
            this.panel69 = new System.Windows.Forms.Panel();
            this.cbAdminBeakerInUse = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.labelAdminBeaBeaker = new System.Windows.Forms.Label();
            this.pageAdminMaestro = new System.Windows.Forms.TabPage();
            this.panelAdminMaestro = new System.Windows.Forms.Panel();
            this.tabControlAdminScripts = new System.Windows.Forms.TabControl();
            this.pageAdminScriptsBuffer = new System.Windows.Forms.TabPage();
            this.txtAdminScriptsBuffer = new System.Windows.Forms.TextBox();
            this.pageAdminScriptsStart = new System.Windows.Forms.TabPage();
            this.txtAdminScriptsStart = new System.Windows.Forms.TextBox();
            this.pageAdminScriptsStop = new System.Windows.Forms.TabPage();
            this.txtAdminScriptsStop = new System.Windows.Forms.TextBox();
            this.panelAdminScriptsLeft = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAdminScriptsSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelAdminMaestroConfig = new System.Windows.Forms.Label();
            this.labelAdminMaestroExecutable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdminMaestroSetup = new System.Windows.Forms.Button();
            this.tabAdminGenie = new System.Windows.Forms.TabPage();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.labelAdminGenieConfig = new System.Windows.Forms.Label();
            this.labelAdminGenieFolder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdminGenieSetup = new System.Windows.Forms.Button();
            this.toolsAdmin = new System.Windows.Forms.ToolStrip();
            this.buttonAdminBack = new System.Windows.Forms.ToolStripButton();
            this.labelAdminTitle = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonAdminAddDummyDetector = new System.Windows.Forms.ToolStripButton();
            this.buttonAdminAddBeaker = new System.Windows.Forms.ToolStripButton();
            this.pageAnalArchive = new System.Windows.Forms.TabPage();
            this.panelArchive = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listViewArchive = new System.Windows.Forms.ListView();
            this.lwArchiveName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwArchiveDetector = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwArchiveYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwArchiveSpec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwArchiveINPExists = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwArchiveLISExists = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwArchivePlotExists = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwArchivePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuArchiveFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuArchiveFilesReanalyse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchiveFilesShowLIS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchiveFilesShowINP = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchiveFilesShowSpectrum = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchiveFilesPrintAnalyse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchiveCreateBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsArchiveFiles = new System.Windows.Forms.ToolStrip();
            this.toolButtonReAnalyse = new System.Windows.Forms.ToolStripButton();
            this.buttonArchiveShowLIS = new System.Windows.Forms.ToolStripButton();
            this.buttonArchiveShowINP = new System.Windows.Forms.ToolStripButton();
            this.buttonArchiveShowSpec = new System.Windows.Forms.ToolStripButton();
            this.buttonArchivePrintAnalyse = new System.Windows.Forms.ToolStripButton();
            this.buttonArchiveCreateBackground = new System.Windows.Forms.ToolStripButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.treeArchive = new System.Windows.Forms.TreeView();
            this.imageListFolder = new System.Windows.Forms.ImageList(this.components);
            this.toolsArchiveTree = new System.Windows.Forms.ToolStrip();
            this.buttonArchiveCollapse = new System.Windows.Forms.ToolStripButton();
            this.buttonArchiveExpand = new System.Windows.Forms.ToolStripButton();
            this.labelArchiveFileCount = new System.Windows.Forms.ToolStripLabel();
            this.toolsArchive = new System.Windows.Forms.ToolStrip();
            this.buttonArchiveBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonArchiveShowHistory = new System.Windows.Forms.ToolStripButton();
            this.buttonArchiveSearch = new System.Windows.Forms.ToolStripButton();
            this.buttonCreateJournal = new System.Windows.Forms.ToolStripButton();
            this.pageLog = new System.Windows.Forms.TabPage();
            this.textBoxMessages = new System.Windows.Forms.RichTextBox();
            this.toolsLog = new System.Windows.Forms.ToolStrip();
            this.buttonLogBack = new System.Windows.Forms.ToolStripButton();
            this.toolLabelLog = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonLogSave = new System.Windows.Forms.ToolStripButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.labeledComboBox6 = new VintageControls.LabeledComboBox();
            this.labeledComboBox7 = new VintageControls.LabeledComboBox();
            this.labeledTextBox20 = new VintageControls.LabeledTextBox();
            this.labeledTextBox21 = new VintageControls.LabeledTextBox();
            this.labeledTextBox22 = new VintageControls.LabeledTextBox();
            this.labeledTextBox23 = new VintageControls.LabeledTextBox();
            this.labeledTextBox24 = new VintageControls.LabeledTextBox();
            this.labeledTextBox25 = new VintageControls.LabeledTextBox();
            this.labeledTextBox26 = new VintageControls.LabeledTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.labeledTextBox27 = new VintageControls.LabeledTextBox();
            this.labeledComboBox8 = new VintageControls.LabeledComboBox();
            this.labeledComboBox9 = new VintageControls.LabeledComboBox();
            this.labeledComboBox10 = new VintageControls.LabeledComboBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.wizardMain.SuspendLayout();
            this.pageMenu.SuspendLayout();
            this.flowMenu.SuspendLayout();
            this.toolsMain.SuspendLayout();
            this.pageSelDet.SuspendLayout();
            this.panelStartStop.SuspendLayout();
            this.toolsStartStop.SuspendLayout();
            this.pageReAnal.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterEditAnal)).BeginInit();
            this.splitterEditAnal.Panel1.SuspendLayout();
            this.splitterEditAnal.Panel2.SuspendLayout();
            this.splitterEditAnal.SuspendLayout();
            this.panelReAnalTopMiddle.SuspendLayout();
            this.panelReAnalTopRight.SuspendLayout();
            this.panelReAnalTopLeft.SuspendLayout();
            this.panelReAnalBottomMiddle.SuspendLayout();
            this.panelReAnalBottomRight.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelReAnalBottomLeft.SuspendLayout();
            this.panel55.SuspendLayout();
            this.toolsReAnal.SuspendLayout();
            this.pageAnal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterNewAnal)).BeginInit();
            this.splitterNewAnal.Panel1.SuspendLayout();
            this.splitterNewAnal.Panel2.SuspendLayout();
            this.splitterNewAnal.SuspendLayout();
            this.panelAnalTopMiddle.SuspendLayout();
            this.panelAnalTopRight.SuspendLayout();
            this.panelAnalTopLeft.SuspendLayout();
            this.panelAnalBottomMiddle.SuspendLayout();
            this.panelAnalBottomRight.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panelAnalBottomLeft.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel22.SuspendLayout();
            this.toolsStartStopView.SuspendLayout();
            this.pageAdmin.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.tabControlAdmin.SuspendLayout();
            this.pageAdminConfig.SuspendLayout();
            this.panel50.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel57.SuspendLayout();
            this.panel56.SuspendLayout();
            this.panel54.SuspendLayout();
            this.pageAdminDetectors.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel58.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel62.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel59.SuspendLayout();
            this.panel64.SuspendLayout();
            this.panel60.SuspendLayout();
            this.panel68.SuspendLayout();
            this.pageAdminBeaker.SuspendLayout();
            this.panelAdmBeakerConf.SuspendLayout();
            this.panelAdmBeakerConfParam.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel69.SuspendLayout();
            this.panel16.SuspendLayout();
            this.pageAdminMaestro.SuspendLayout();
            this.panelAdminMaestro.SuspendLayout();
            this.tabControlAdminScripts.SuspendLayout();
            this.pageAdminScriptsBuffer.SuspendLayout();
            this.pageAdminScriptsStart.SuspendLayout();
            this.pageAdminScriptsStop.SuspendLayout();
            this.panelAdminScriptsLeft.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabAdminGenie.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel31.SuspendLayout();
            this.toolsAdmin.SuspendLayout();
            this.pageAnalArchive.SuspendLayout();
            this.panelArchive.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menuArchiveFiles.SuspendLayout();
            this.toolsArchiveFiles.SuspendLayout();
            this.panel6.SuspendLayout();
            this.toolsArchiveTree.SuspendLayout();
            this.toolsArchive.SuspendLayout();
            this.pageLog.SuspendLayout();
            this.toolsLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hjelpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(2, 2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1004, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLog,
            this.menuItemAdmin,
            this.toolStripSeparator8,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // menuItemLog
            // 
            this.menuItemLog.Name = "menuItemLog";
            this.menuItemLog.Size = new System.Drawing.Size(158, 22);
            this.menuItemLog.Text = "&Log";
            this.menuItemLog.Click += new System.EventHandler(this.menuItemLog_Click);
            // 
            // menuItemAdmin
            // 
            this.menuItemAdmin.Name = "menuItemAdmin";
            this.menuItemAdmin.Size = new System.Drawing.Size(158, 22);
            this.menuItemAdmin.Text = "&Administration";
            this.menuItemAdmin.Click += new System.EventHandler(this.menuItemAdmin_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(155, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // hjelpToolStripMenuItem
            // 
            this.hjelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indexToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.hjelpToolStripMenuItem.Name = "hjelpToolStripMenuItem";
            this.hjelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hjelpToolStripMenuItem.Text = "&Help";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            this.indexToolStripMenuItem.Click += new System.EventHandler(this.indexToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(105, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProgress,
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(2, 538);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1004, 22);
            this.status.TabIndex = 1;
            // 
            // statusProgress
            // 
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.Size = new System.Drawing.Size(256, 16);
            this.statusProgress.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(34, 17);
            this.statusLabel.Text = "label";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.wizardMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(2, 26);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1004, 512);
            this.panelMain.TabIndex = 3;
            // 
            // wizardMain
            // 
            this.wizardMain.Controls.Add(this.pageMenu);
            this.wizardMain.Controls.Add(this.pageSelDet);
            this.wizardMain.Controls.Add(this.pageReAnal);
            this.wizardMain.Controls.Add(this.pageAnal);
            this.wizardMain.Controls.Add(this.pageAdmin);
            this.wizardMain.Controls.Add(this.pageAnalArchive);
            this.wizardMain.Controls.Add(this.pageLog);
            this.wizardMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardMain.Location = new System.Drawing.Point(0, 0);
            this.wizardMain.Name = "wizardMain";
            this.wizardMain.SelectedIndex = 0;
            this.wizardMain.Size = new System.Drawing.Size(1004, 512);
            this.wizardMain.TabIndex = 0;
            this.wizardMain.SelectedIndexChanged += new System.EventHandler(this.wizardMain_SelectedIndexChanged);
            this.wizardMain.Resize += new System.EventHandler(this.wizardMain_Resize);
            // 
            // pageMenu
            // 
            this.pageMenu.BackColor = System.Drawing.SystemColors.Control;
            this.pageMenu.Controls.Add(this.flowMenu);
            this.pageMenu.Controls.Add(this.toolsMain);
            this.pageMenu.Location = new System.Drawing.Point(4, 23);
            this.pageMenu.Name = "pageMenu";
            this.pageMenu.Padding = new System.Windows.Forms.Padding(3);
            this.pageMenu.Size = new System.Drawing.Size(996, 485);
            this.pageMenu.TabIndex = 0;
            this.pageMenu.Text = "Menu";
            // 
            // flowMenu
            // 
            this.flowMenu.AutoScroll = true;
            this.flowMenu.AutoSize = true;
            this.flowMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowMenu.Controls.Add(this.buttonMenuDetectors);
            this.flowMenu.Controls.Add(this.buttonMenuArchive);
            this.flowMenu.Controls.Add(this.buttonMenuLibraries);
            this.flowMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMenu.Location = new System.Drawing.Point(3, 28);
            this.flowMenu.Name = "flowMenu";
            this.flowMenu.Padding = new System.Windows.Forms.Padding(16);
            this.flowMenu.Size = new System.Drawing.Size(990, 454);
            this.flowMenu.TabIndex = 2;
            // 
            // buttonMenuDetectors
            // 
            this.buttonMenuDetectors.FlatAppearance.BorderSize = 0;
            this.buttonMenuDetectors.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.buttonMenuDetectors.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonMenuDetectors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuDetectors.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuDetectors.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenuDetectors.Image")));
            this.buttonMenuDetectors.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMenuDetectors.Location = new System.Drawing.Point(19, 19);
            this.buttonMenuDetectors.Name = "buttonMenuDetectors";
            this.buttonMenuDetectors.Size = new System.Drawing.Size(90, 105);
            this.buttonMenuDetectors.TabIndex = 0;
            this.buttonMenuDetectors.Text = "Detectors";
            this.buttonMenuDetectors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMenuDetectors.UseVisualStyleBackColor = true;
            this.buttonMenuDetectors.Click += new System.EventHandler(this.flowMenu_Click);
            // 
            // buttonMenuArchive
            // 
            this.buttonMenuArchive.FlatAppearance.BorderSize = 0;
            this.buttonMenuArchive.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.buttonMenuArchive.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonMenuArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuArchive.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuArchive.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenuArchive.Image")));
            this.buttonMenuArchive.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMenuArchive.Location = new System.Drawing.Point(115, 19);
            this.buttonMenuArchive.Name = "buttonMenuArchive";
            this.buttonMenuArchive.Size = new System.Drawing.Size(90, 105);
            this.buttonMenuArchive.TabIndex = 1;
            this.buttonMenuArchive.Text = "Archive";
            this.buttonMenuArchive.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMenuArchive.UseVisualStyleBackColor = true;
            this.buttonMenuArchive.Click += new System.EventHandler(this.flowMenu_Click);
            // 
            // buttonMenuLibraries
            // 
            this.buttonMenuLibraries.Enabled = false;
            this.buttonMenuLibraries.FlatAppearance.BorderSize = 0;
            this.buttonMenuLibraries.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.buttonMenuLibraries.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonMenuLibraries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuLibraries.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuLibraries.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenuLibraries.Image")));
            this.buttonMenuLibraries.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMenuLibraries.Location = new System.Drawing.Point(211, 19);
            this.buttonMenuLibraries.Name = "buttonMenuLibraries";
            this.buttonMenuLibraries.Size = new System.Drawing.Size(90, 105);
            this.buttonMenuLibraries.TabIndex = 2;
            this.buttonMenuLibraries.Text = "Library files";
            this.buttonMenuLibraries.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMenuLibraries.UseVisualStyleBackColor = true;
            // 
            // toolsMain
            // 
            this.toolsMain.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelMain});
            this.toolsMain.Location = new System.Drawing.Point(3, 3);
            this.toolsMain.Name = "toolsMain";
            this.toolsMain.Size = new System.Drawing.Size(990, 25);
            this.toolsMain.TabIndex = 1;
            this.toolsMain.Text = "toolStrip1";
            // 
            // labelMain
            // 
            this.labelMain.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(69, 22);
            this.labelMain.Text = "Main menu";
            // 
            // pageSelDet
            // 
            this.pageSelDet.BackColor = System.Drawing.SystemColors.Control;
            this.pageSelDet.Controls.Add(this.panelStartStop);
            this.pageSelDet.Controls.Add(this.toolsStartStop);
            this.pageSelDet.Location = new System.Drawing.Point(4, 23);
            this.pageSelDet.Name = "pageSelDet";
            this.pageSelDet.Padding = new System.Windows.Forms.Padding(3);
            this.pageSelDet.Size = new System.Drawing.Size(996, 485);
            this.pageSelDet.TabIndex = 1;
            this.pageSelDet.Text = "SelectDet";
            // 
            // panelStartStop
            // 
            this.panelStartStop.Controls.Add(this.flowMenuDetectors);
            this.panelStartStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStartStop.Location = new System.Drawing.Point(3, 28);
            this.panelStartStop.Name = "panelStartStop";
            this.panelStartStop.Size = new System.Drawing.Size(990, 454);
            this.panelStartStop.TabIndex = 5;
            // 
            // flowMenuDetectors
            // 
            this.flowMenuDetectors.AutoScroll = true;
            this.flowMenuDetectors.AutoSize = true;
            this.flowMenuDetectors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowMenuDetectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMenuDetectors.Location = new System.Drawing.Point(0, 0);
            this.flowMenuDetectors.Name = "flowMenuDetectors";
            this.flowMenuDetectors.Padding = new System.Windows.Forms.Padding(16);
            this.flowMenuDetectors.Size = new System.Drawing.Size(990, 454);
            this.flowMenuDetectors.TabIndex = 3;
            // 
            // toolsStartStop
            // 
            this.toolsStartStop.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolsStartStop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsStartStop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonStartStopBack,
            this.labelStartStopTitle});
            this.toolsStartStop.Location = new System.Drawing.Point(3, 3);
            this.toolsStartStop.Name = "toolsStartStop";
            this.toolsStartStop.Size = new System.Drawing.Size(990, 25);
            this.toolsStartStop.TabIndex = 2;
            this.toolsStartStop.Text = "toolStrip1";
            // 
            // buttonStartStopBack
            // 
            this.buttonStartStopBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonStartStopBack.Image")));
            this.buttonStartStopBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonStartStopBack.Name = "buttonStartStopBack";
            this.buttonStartStopBack.Size = new System.Drawing.Size(89, 22);
            this.buttonStartStopBack.Text = "Main menu";
            this.buttonStartStopBack.ToolTipText = "Back to main menu";
            this.buttonStartStopBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelStartStopTitle
            // 
            this.labelStartStopTitle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelStartStopTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelStartStopTitle.Name = "labelStartStopTitle";
            this.labelStartStopTitle.Size = new System.Drawing.Size(92, 22);
            this.labelStartStopTitle.Text = "Detector menu";
            // 
            // pageReAnal
            // 
            this.pageReAnal.Controls.Add(this.panel10);
            this.pageReAnal.Controls.Add(this.toolsReAnal);
            this.pageReAnal.Location = new System.Drawing.Point(4, 23);
            this.pageReAnal.Name = "pageReAnal";
            this.pageReAnal.Padding = new System.Windows.Forms.Padding(3);
            this.pageReAnal.Size = new System.Drawing.Size(996, 485);
            this.pageReAnal.TabIndex = 2;
            this.pageReAnal.Text = "ReAnal";
            this.pageReAnal.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 28);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(990, 454);
            this.panel10.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.splitterEditAnal);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(990, 454);
            this.panel11.TabIndex = 2;
            // 
            // splitterEditAnal
            // 
            this.splitterEditAnal.BackColor = System.Drawing.SystemColors.Control;
            this.splitterEditAnal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterEditAnal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitterEditAnal.IsSplitterFixed = true;
            this.splitterEditAnal.Location = new System.Drawing.Point(0, 0);
            this.splitterEditAnal.Name = "splitterEditAnal";
            this.splitterEditAnal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitterEditAnal.Panel1
            // 
            this.splitterEditAnal.Panel1.Controls.Add(this.panelReAnalTopMiddle);
            this.splitterEditAnal.Panel1.Controls.Add(this.panelReAnalTopRight);
            this.splitterEditAnal.Panel1.Controls.Add(this.panelReAnalTopLeft);
            // 
            // splitterEditAnal.Panel2
            // 
            this.splitterEditAnal.Panel2.Controls.Add(this.panelReAnalBottomMiddle);
            this.splitterEditAnal.Panel2.Controls.Add(this.panelReAnalBottomRight);
            this.splitterEditAnal.Panel2.Controls.Add(this.panelReAnalBottomLeft);
            this.splitterEditAnal.Size = new System.Drawing.Size(990, 454);
            this.splitterEditAnal.SplitterDistance = 178;
            this.splitterEditAnal.SplitterWidth = 6;
            this.splitterEditAnal.TabIndex = 1;
            this.splitterEditAnal.Resize += new System.EventHandler(this.splitterEditAnal_Resize);
            // 
            // panelReAnalTopMiddle
            // 
            this.panelReAnalTopMiddle.Controls.Add(this.dialogReAnalNuclLib);
            this.panelReAnalTopMiddle.Controls.Add(this.txtReAnalSampleStop);
            this.panelReAnalTopMiddle.Controls.Add(this.txtReAnalQuantityUncertainty);
            this.panelReAnalTopMiddle.Controls.Add(this.txtReAnalSampleHeight);
            this.panelReAnalTopMiddle.Controls.Add(this.txtReAnalSamplePlace);
            this.panelReAnalTopMiddle.Controls.Add(this.txtReAnalYear);
            this.panelReAnalTopMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReAnalTopMiddle.Location = new System.Drawing.Point(326, 0);
            this.panelReAnalTopMiddle.Name = "panelReAnalTopMiddle";
            this.panelReAnalTopMiddle.Size = new System.Drawing.Size(338, 178);
            this.panelReAnalTopMiddle.TabIndex = 1;
            // 
            // dialogReAnalNuclLib
            // 
            this.dialogReAnalNuclLib.Caption = "Nuclide library";
            this.dialogReAnalNuclLib.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogReAnalNuclLib.Location = new System.Drawing.Point(0, 105);
            this.dialogReAnalNuclLib.Name = "dialogReAnalNuclLib";
            this.dialogReAnalNuclLib.Size = new System.Drawing.Size(338, 21);
            this.dialogReAnalNuclLib.TabIndex = 6;
            this.dialogReAnalNuclLib.ButtonClicked += new System.EventHandler(this.dialogReAnalNuclLib_ButtonClicked);
            // 
            // txtReAnalSampleStop
            // 
            this.txtReAnalSampleStop.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalSampleStop.Caption = "Sampling stop";
            this.txtReAnalSampleStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalSampleStop.Location = new System.Drawing.Point(0, 84);
            this.txtReAnalSampleStop.MaxStringLength = 12;
            this.txtReAnalSampleStop.Name = "txtReAnalSampleStop";
            this.txtReAnalSampleStop.Size = new System.Drawing.Size(338, 21);
            this.txtReAnalSampleStop.TabIndex = 5;
            this.txtReAnalSampleStop.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtReAnalSampleStop.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            this.txtReAnalSampleStop.Leave += new System.EventHandler(this.Datum_Leave);
            // 
            // txtReAnalQuantityUncertainty
            // 
            this.txtReAnalQuantityUncertainty.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalQuantityUncertainty.Caption = "Quantity uncertainty";
            this.txtReAnalQuantityUncertainty.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalQuantityUncertainty.Location = new System.Drawing.Point(0, 63);
            this.txtReAnalQuantityUncertainty.MaxStringLength = 32767;
            this.txtReAnalQuantityUncertainty.Name = "txtReAnalQuantityUncertainty";
            this.txtReAnalQuantityUncertainty.Size = new System.Drawing.Size(338, 21);
            this.txtReAnalQuantityUncertainty.TabIndex = 4;
            this.txtReAnalQuantityUncertainty.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtReAnalQuantityUncertainty.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtReAnalQuantityUncertainty.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtReAnalSampleHeight
            // 
            this.txtReAnalSampleHeight.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalSampleHeight.Caption = "Height (mm)";
            this.txtReAnalSampleHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalSampleHeight.Location = new System.Drawing.Point(0, 42);
            this.txtReAnalSampleHeight.MaxStringLength = 30;
            this.txtReAnalSampleHeight.Name = "txtReAnalSampleHeight";
            this.txtReAnalSampleHeight.Size = new System.Drawing.Size(338, 21);
            this.txtReAnalSampleHeight.TabIndex = 2;
            this.txtReAnalSampleHeight.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtReAnalSampleHeight.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtReAnalSampleHeight.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtReAnalSamplePlace
            // 
            this.txtReAnalSamplePlace.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalSamplePlace.Caption = "Sample place";
            this.txtReAnalSamplePlace.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalSamplePlace.Location = new System.Drawing.Point(0, 21);
            this.txtReAnalSamplePlace.MaxStringLength = 29;
            this.txtReAnalSamplePlace.Name = "txtReAnalSamplePlace";
            this.txtReAnalSamplePlace.Size = new System.Drawing.Size(338, 21);
            this.txtReAnalSamplePlace.TabIndex = 1;
            this.txtReAnalSamplePlace.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // txtReAnalYear
            // 
            this.txtReAnalYear.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalYear.Caption = "Year";
            this.txtReAnalYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalYear.Enabled = false;
            this.txtReAnalYear.Location = new System.Drawing.Point(0, 0);
            this.txtReAnalYear.MaxStringLength = 32767;
            this.txtReAnalYear.Name = "txtReAnalYear";
            this.txtReAnalYear.Size = new System.Drawing.Size(338, 21);
            this.txtReAnalYear.TabIndex = 0;
            this.txtReAnalYear.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // panelReAnalTopRight
            // 
            this.panelReAnalTopRight.Controls.Add(this.dialogReAnalDetLimLib);
            this.panelReAnalTopRight.Controls.Add(this.cboxReAnalSignature);
            this.panelReAnalTopRight.Controls.Add(this.cboxReAnalSampQuantUnit);
            this.panelReAnalTopRight.Controls.Add(this.txtReAnalSampleWeight);
            this.panelReAnalTopRight.Controls.Add(this.panel8);
            this.panelReAnalTopRight.Controls.Add(this.txtReAnalSpecnum);
            this.panelReAnalTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelReAnalTopRight.Location = new System.Drawing.Point(664, 0);
            this.panelReAnalTopRight.Name = "panelReAnalTopRight";
            this.panelReAnalTopRight.Size = new System.Drawing.Size(326, 178);
            this.panelReAnalTopRight.TabIndex = 2;
            // 
            // dialogReAnalDetLimLib
            // 
            this.dialogReAnalDetLimLib.Caption = "Detection limit lib";
            this.dialogReAnalDetLimLib.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogReAnalDetLimLib.Location = new System.Drawing.Point(0, 107);
            this.dialogReAnalDetLimLib.Name = "dialogReAnalDetLimLib";
            this.dialogReAnalDetLimLib.Size = new System.Drawing.Size(326, 21);
            this.dialogReAnalDetLimLib.TabIndex = 5;
            this.dialogReAnalDetLimLib.ButtonClicked += new System.EventHandler(this.dialogReAnalDetLimLib_ButtonClicked);
            // 
            // cboxReAnalSignature
            // 
            this.cboxReAnalSignature.Caption = "Signature";
            this.cboxReAnalSignature.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxReAnalSignature.Enabled = false;
            this.cboxReAnalSignature.Location = new System.Drawing.Point(0, 86);
            this.cboxReAnalSignature.Name = "cboxReAnalSignature";
            this.cboxReAnalSignature.Size = new System.Drawing.Size(326, 21);
            this.cboxReAnalSignature.TabIndex = 6;
            // 
            // cboxReAnalSampQuantUnit
            // 
            this.cboxReAnalSampQuantUnit.Caption = "Quantity unit";
            this.cboxReAnalSampQuantUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxReAnalSampQuantUnit.Location = new System.Drawing.Point(0, 65);
            this.cboxReAnalSampQuantUnit.Name = "cboxReAnalSampQuantUnit";
            this.cboxReAnalSampQuantUnit.Size = new System.Drawing.Size(326, 21);
            this.cboxReAnalSampQuantUnit.TabIndex = 3;
            // 
            // txtReAnalSampleWeight
            // 
            this.txtReAnalSampleWeight.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalSampleWeight.Caption = "Weight (g)";
            this.txtReAnalSampleWeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalSampleWeight.Location = new System.Drawing.Point(0, 44);
            this.txtReAnalSampleWeight.MaxStringLength = 30;
            this.txtReAnalSampleWeight.Name = "txtReAnalSampleWeight";
            this.txtReAnalSampleWeight.Size = new System.Drawing.Size(326, 21);
            this.txtReAnalSampleWeight.TabIndex = 2;
            this.txtReAnalSampleWeight.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtReAnalSampleWeight.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtReAnalSampleWeight.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 21);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(326, 23);
            this.panel8.TabIndex = 1;
            // 
            // txtReAnalSpecnum
            // 
            this.txtReAnalSpecnum.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalSpecnum.Caption = "Spectrum nr.";
            this.txtReAnalSpecnum.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalSpecnum.Enabled = false;
            this.txtReAnalSpecnum.Location = new System.Drawing.Point(0, 0);
            this.txtReAnalSpecnum.MaxStringLength = 32767;
            this.txtReAnalSpecnum.Name = "txtReAnalSpecnum";
            this.txtReAnalSpecnum.Size = new System.Drawing.Size(326, 21);
            this.txtReAnalSpecnum.TabIndex = 0;
            this.txtReAnalSpecnum.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // panelReAnalTopLeft
            // 
            this.panelReAnalTopLeft.Controls.Add(this.labelReAnalPath);
            this.panelReAnalTopLeft.Controls.Add(this.txtReAnalReferenceTime);
            this.panelReAnalTopLeft.Controls.Add(this.txtReAnalSampleStart);
            this.panelReAnalTopLeft.Controls.Add(this.txtReAnalQuantity);
            this.panelReAnalTopLeft.Controls.Add(this.cboxReAnalSampBeaker);
            this.panelReAnalTopLeft.Controls.Add(this.txtReAnalSampleId);
            this.panelReAnalTopLeft.Controls.Add(this.txtReAnalDetector);
            this.panelReAnalTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelReAnalTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panelReAnalTopLeft.Name = "panelReAnalTopLeft";
            this.panelReAnalTopLeft.Size = new System.Drawing.Size(326, 178);
            this.panelReAnalTopLeft.TabIndex = 0;
            // 
            // labelReAnalPath
            // 
            this.labelReAnalPath.AutoSize = true;
            this.labelReAnalPath.Location = new System.Drawing.Point(91, 150);
            this.labelReAnalPath.Name = "labelReAnalPath";
            this.labelReAnalPath.Size = new System.Drawing.Size(29, 13);
            this.labelReAnalPath.TabIndex = 7;
            this.labelReAnalPath.Text = "Path";
            this.labelReAnalPath.Visible = false;
            // 
            // txtReAnalReferenceTime
            // 
            this.txtReAnalReferenceTime.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalReferenceTime.Caption = "Reference time";
            this.txtReAnalReferenceTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalReferenceTime.Location = new System.Drawing.Point(0, 105);
            this.txtReAnalReferenceTime.MaxStringLength = 12;
            this.txtReAnalReferenceTime.Name = "txtReAnalReferenceTime";
            this.txtReAnalReferenceTime.Size = new System.Drawing.Size(326, 21);
            this.txtReAnalReferenceTime.TabIndex = 6;
            this.txtReAnalReferenceTime.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtReAnalReferenceTime.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            this.txtReAnalReferenceTime.Leave += new System.EventHandler(this.Datum_Leave);
            // 
            // txtReAnalSampleStart
            // 
            this.txtReAnalSampleStart.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalSampleStart.Caption = "Sampling start";
            this.txtReAnalSampleStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalSampleStart.Location = new System.Drawing.Point(0, 84);
            this.txtReAnalSampleStart.MaxStringLength = 12;
            this.txtReAnalSampleStart.Name = "txtReAnalSampleStart";
            this.txtReAnalSampleStart.Size = new System.Drawing.Size(326, 21);
            this.txtReAnalSampleStart.TabIndex = 5;
            this.txtReAnalSampleStart.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtReAnalSampleStart.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            this.txtReAnalSampleStart.Leave += new System.EventHandler(this.Datum_Leave);
            // 
            // txtReAnalQuantity
            // 
            this.txtReAnalQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalQuantity.Caption = "Quantity";
            this.txtReAnalQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalQuantity.Location = new System.Drawing.Point(0, 63);
            this.txtReAnalQuantity.MaxStringLength = 32767;
            this.txtReAnalQuantity.Name = "txtReAnalQuantity";
            this.txtReAnalQuantity.Size = new System.Drawing.Size(326, 21);
            this.txtReAnalQuantity.TabIndex = 4;
            this.txtReAnalQuantity.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtReAnalQuantity.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtReAnalQuantity.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // cboxReAnalSampBeaker
            // 
            this.cboxReAnalSampBeaker.Caption = "Beaker";
            this.cboxReAnalSampBeaker.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxReAnalSampBeaker.Location = new System.Drawing.Point(0, 42);
            this.cboxReAnalSampBeaker.Name = "cboxReAnalSampBeaker";
            this.cboxReAnalSampBeaker.Size = new System.Drawing.Size(326, 21);
            this.cboxReAnalSampBeaker.TabIndex = 2;
            this.cboxReAnalSampBeaker.SelectedValueChanged += new System.EventHandler(this.cboxReAnalSampBeaker_SelectedValueChanged);
            // 
            // txtReAnalSampleId
            // 
            this.txtReAnalSampleId.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalSampleId.Caption = "Sample Id/Type";
            this.txtReAnalSampleId.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalSampleId.Location = new System.Drawing.Point(0, 21);
            this.txtReAnalSampleId.MaxStringLength = 39;
            this.txtReAnalSampleId.Name = "txtReAnalSampleId";
            this.txtReAnalSampleId.Size = new System.Drawing.Size(326, 21);
            this.txtReAnalSampleId.TabIndex = 1;
            this.txtReAnalSampleId.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            // 
            // txtReAnalDetector
            // 
            this.txtReAnalDetector.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalDetector.Caption = "Detector";
            this.txtReAnalDetector.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalDetector.Enabled = false;
            this.txtReAnalDetector.Location = new System.Drawing.Point(0, 0);
            this.txtReAnalDetector.MaxStringLength = 32767;
            this.txtReAnalDetector.Name = "txtReAnalDetector";
            this.txtReAnalDetector.Size = new System.Drawing.Size(326, 21);
            this.txtReAnalDetector.TabIndex = 0;
            this.txtReAnalDetector.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // panelReAnalBottomMiddle
            // 
            this.panelReAnalBottomMiddle.Controls.Add(this.txtReAnalVolume);
            this.panelReAnalBottomMiddle.Controls.Add(this.dialogReAnalPefFile);
            this.panelReAnalBottomMiddle.Controls.Add(this.dialogReAnalBackgroundFile);
            this.panelReAnalBottomMiddle.Controls.Add(this.txtReAnalETOL);
            this.panelReAnalBottomMiddle.Controls.Add(this.txtReAnalFWHMAN);
            this.panelReAnalBottomMiddle.Controls.Add(this.cboxReAnalSampMethod);
            this.panelReAnalBottomMiddle.Controls.Add(this.txtReAnalRealtime);
            this.panelReAnalBottomMiddle.Controls.Add(this.txtReAnalMeasurementStop);
            this.panelReAnalBottomMiddle.Controls.Add(this.panel48);
            this.panelReAnalBottomMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReAnalBottomMiddle.Location = new System.Drawing.Point(326, 0);
            this.panelReAnalBottomMiddle.Name = "panelReAnalBottomMiddle";
            this.panelReAnalBottomMiddle.Size = new System.Drawing.Size(338, 270);
            this.panelReAnalBottomMiddle.TabIndex = 1;
            // 
            // txtReAnalVolume
            // 
            this.txtReAnalVolume.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalVolume.Caption = "Volume (cm3)";
            this.txtReAnalVolume.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalVolume.Location = new System.Drawing.Point(0, 170);
            this.txtReAnalVolume.MaxStringLength = 30;
            this.txtReAnalVolume.Name = "txtReAnalVolume";
            this.txtReAnalVolume.Size = new System.Drawing.Size(338, 21);
            this.txtReAnalVolume.TabIndex = 7;
            this.txtReAnalVolume.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtReAnalVolume.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtReAnalVolume.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // dialogReAnalPefFile
            // 
            this.dialogReAnalPefFile.Caption = "PEF file";
            this.dialogReAnalPefFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogReAnalPefFile.Location = new System.Drawing.Point(0, 149);
            this.dialogReAnalPefFile.Name = "dialogReAnalPefFile";
            this.dialogReAnalPefFile.Size = new System.Drawing.Size(338, 21);
            this.dialogReAnalPefFile.TabIndex = 6;
            this.dialogReAnalPefFile.ButtonClicked += new System.EventHandler(this.dialogReAnalPefFile_ButtonClicked);
            // 
            // dialogReAnalBackgroundFile
            // 
            this.dialogReAnalBackgroundFile.Caption = "Background file";
            this.dialogReAnalBackgroundFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogReAnalBackgroundFile.Location = new System.Drawing.Point(0, 128);
            this.dialogReAnalBackgroundFile.Name = "dialogReAnalBackgroundFile";
            this.dialogReAnalBackgroundFile.Size = new System.Drawing.Size(338, 21);
            this.dialogReAnalBackgroundFile.TabIndex = 5;
            this.dialogReAnalBackgroundFile.ButtonClicked += new System.EventHandler(this.dialogReAnalBackgroundFile_ButtonClicked);
            // 
            // txtReAnalETOL
            // 
            this.txtReAnalETOL.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalETOL.Caption = "ETOL";
            this.txtReAnalETOL.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalETOL.Location = new System.Drawing.Point(0, 107);
            this.txtReAnalETOL.MaxStringLength = 30;
            this.txtReAnalETOL.Name = "txtReAnalETOL";
            this.txtReAnalETOL.Size = new System.Drawing.Size(338, 21);
            this.txtReAnalETOL.TabIndex = 4;
            this.txtReAnalETOL.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtReAnalETOL.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtReAnalETOL.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtReAnalFWHMAN
            // 
            this.txtReAnalFWHMAN.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalFWHMAN.Caption = "FWHMAN";
            this.txtReAnalFWHMAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalFWHMAN.Location = new System.Drawing.Point(0, 86);
            this.txtReAnalFWHMAN.MaxStringLength = 30;
            this.txtReAnalFWHMAN.Name = "txtReAnalFWHMAN";
            this.txtReAnalFWHMAN.Size = new System.Drawing.Size(338, 21);
            this.txtReAnalFWHMAN.TabIndex = 3;
            this.txtReAnalFWHMAN.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtReAnalFWHMAN.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtReAnalFWHMAN.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // cboxReAnalSampMethod
            // 
            this.cboxReAnalSampMethod.Caption = "Analysis method";
            this.cboxReAnalSampMethod.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxReAnalSampMethod.Enabled = false;
            this.cboxReAnalSampMethod.Location = new System.Drawing.Point(0, 65);
            this.cboxReAnalSampMethod.Name = "cboxReAnalSampMethod";
            this.cboxReAnalSampMethod.Size = new System.Drawing.Size(338, 21);
            this.cboxReAnalSampMethod.TabIndex = 2;
            // 
            // txtReAnalRealtime
            // 
            this.txtReAnalRealtime.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalRealtime.Caption = "Real time";
            this.txtReAnalRealtime.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalRealtime.Location = new System.Drawing.Point(0, 44);
            this.txtReAnalRealtime.MaxStringLength = 30;
            this.txtReAnalRealtime.Name = "txtReAnalRealtime";
            this.txtReAnalRealtime.Size = new System.Drawing.Size(338, 21);
            this.txtReAnalRealtime.TabIndex = 1;
            this.txtReAnalRealtime.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtReAnalRealtime.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtReAnalRealtime.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtReAnalMeasurementStop
            // 
            this.txtReAnalMeasurementStop.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalMeasurementStop.Caption = "Measurement stop";
            this.txtReAnalMeasurementStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalMeasurementStop.Location = new System.Drawing.Point(0, 23);
            this.txtReAnalMeasurementStop.MaxStringLength = 12;
            this.txtReAnalMeasurementStop.Name = "txtReAnalMeasurementStop";
            this.txtReAnalMeasurementStop.Size = new System.Drawing.Size(338, 21);
            this.txtReAnalMeasurementStop.TabIndex = 0;
            this.txtReAnalMeasurementStop.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtReAnalMeasurementStop.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            this.txtReAnalMeasurementStop.Leave += new System.EventHandler(this.Datum_Leave);
            // 
            // panel48
            // 
            this.panel48.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel48.Location = new System.Drawing.Point(0, 0);
            this.panel48.Name = "panel48";
            this.panel48.Size = new System.Drawing.Size(338, 23);
            this.panel48.TabIndex = 0;
            // 
            // panelReAnalBottomRight
            // 
            this.panelReAnalBottomRight.Controls.Add(this.panel4);
            this.panelReAnalBottomRight.Controls.Add(this.dialogReAnalTefFile);
            this.panelReAnalBottomRight.Controls.Add(this.dialogReAnalEnergyFile);
            this.panelReAnalBottomRight.Controls.Add(this.txtReAnalLOCH);
            this.panelReAnalBottomRight.Controls.Add(this.txtReAnalTHRESH);
            this.panelReAnalBottomRight.Controls.Add(this.txtReAnalRecLen);
            this.panelReAnalBottomRight.Controls.Add(this.txtReAnalDeadtime);
            this.panelReAnalBottomRight.Controls.Add(this.txtReAnalMeasurementTime);
            this.panelReAnalBottomRight.Controls.Add(this.panel51);
            this.panelReAnalBottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelReAnalBottomRight.Location = new System.Drawing.Point(664, 0);
            this.panelReAnalBottomRight.Name = "panelReAnalBottomRight";
            this.panelReAnalBottomRight.Size = new System.Drawing.Size(326, 270);
            this.panelReAnalBottomRight.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonReAnalRecalculate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 21);
            this.panel4.TabIndex = 9;
            // 
            // buttonReAnalRecalculate
            // 
            this.buttonReAnalRecalculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReAnalRecalculate.Location = new System.Drawing.Point(0, 0);
            this.buttonReAnalRecalculate.Name = "buttonReAnalRecalculate";
            this.buttonReAnalRecalculate.Size = new System.Drawing.Size(326, 21);
            this.buttonReAnalRecalculate.TabIndex = 0;
            this.buttonReAnalRecalculate.Text = "Calculate density and volume";
            this.buttonReAnalRecalculate.UseVisualStyleBackColor = true;
            this.buttonReAnalRecalculate.Click += new System.EventHandler(this.buttonReAnalRecalculate_Click);
            // 
            // dialogReAnalTefFile
            // 
            this.dialogReAnalTefFile.Caption = "TEF file";
            this.dialogReAnalTefFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogReAnalTefFile.Location = new System.Drawing.Point(0, 149);
            this.dialogReAnalTefFile.Name = "dialogReAnalTefFile";
            this.dialogReAnalTefFile.Size = new System.Drawing.Size(326, 21);
            this.dialogReAnalTefFile.TabIndex = 6;
            this.dialogReAnalTefFile.ButtonClicked += new System.EventHandler(this.dialogReAnalTefFile_ButtonClicked);
            // 
            // dialogReAnalEnergyFile
            // 
            this.dialogReAnalEnergyFile.Caption = "Energy file";
            this.dialogReAnalEnergyFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogReAnalEnergyFile.Location = new System.Drawing.Point(0, 128);
            this.dialogReAnalEnergyFile.Name = "dialogReAnalEnergyFile";
            this.dialogReAnalEnergyFile.Size = new System.Drawing.Size(326, 21);
            this.dialogReAnalEnergyFile.TabIndex = 5;
            this.dialogReAnalEnergyFile.ButtonClicked += new System.EventHandler(this.dialogReAnalEnergyFile_ButtonClicked);
            // 
            // txtReAnalLOCH
            // 
            this.txtReAnalLOCH.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalLOCH.Caption = "LOCH";
            this.txtReAnalLOCH.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalLOCH.Location = new System.Drawing.Point(0, 107);
            this.txtReAnalLOCH.MaxStringLength = 30;
            this.txtReAnalLOCH.Name = "txtReAnalLOCH";
            this.txtReAnalLOCH.Size = new System.Drawing.Size(326, 21);
            this.txtReAnalLOCH.TabIndex = 4;
            this.txtReAnalLOCH.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtReAnalLOCH.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtReAnalLOCH.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtReAnalTHRESH
            // 
            this.txtReAnalTHRESH.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalTHRESH.Caption = "THRESH";
            this.txtReAnalTHRESH.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalTHRESH.Location = new System.Drawing.Point(0, 86);
            this.txtReAnalTHRESH.MaxStringLength = 30;
            this.txtReAnalTHRESH.Name = "txtReAnalTHRESH";
            this.txtReAnalTHRESH.Size = new System.Drawing.Size(326, 21);
            this.txtReAnalTHRESH.TabIndex = 3;
            this.txtReAnalTHRESH.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtReAnalTHRESH.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtReAnalTHRESH.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtReAnalRecLen
            // 
            this.txtReAnalRecLen.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalRecLen.Caption = "Record length";
            this.txtReAnalRecLen.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalRecLen.Enabled = false;
            this.txtReAnalRecLen.Location = new System.Drawing.Point(0, 65);
            this.txtReAnalRecLen.MaxStringLength = 32767;
            this.txtReAnalRecLen.Name = "txtReAnalRecLen";
            this.txtReAnalRecLen.Size = new System.Drawing.Size(326, 21);
            this.txtReAnalRecLen.TabIndex = 2;
            this.txtReAnalRecLen.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // txtReAnalDeadtime
            // 
            this.txtReAnalDeadtime.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalDeadtime.Caption = "Dead time";
            this.txtReAnalDeadtime.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalDeadtime.Location = new System.Drawing.Point(0, 44);
            this.txtReAnalDeadtime.MaxStringLength = 30;
            this.txtReAnalDeadtime.Name = "txtReAnalDeadtime";
            this.txtReAnalDeadtime.Size = new System.Drawing.Size(326, 21);
            this.txtReAnalDeadtime.TabIndex = 1;
            this.txtReAnalDeadtime.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtReAnalDeadtime.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtReAnalDeadtime.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtReAnalMeasurementTime
            // 
            this.txtReAnalMeasurementTime.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalMeasurementTime.Caption = "Measurement time";
            this.txtReAnalMeasurementTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalMeasurementTime.Location = new System.Drawing.Point(0, 23);
            this.txtReAnalMeasurementTime.MaxStringLength = 20;
            this.txtReAnalMeasurementTime.Name = "txtReAnalMeasurementTime";
            this.txtReAnalMeasurementTime.Size = new System.Drawing.Size(326, 21);
            this.txtReAnalMeasurementTime.TabIndex = 0;
            this.txtReAnalMeasurementTime.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtReAnalMeasurementTime.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // panel51
            // 
            this.panel51.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel51.Location = new System.Drawing.Point(0, 0);
            this.panel51.Name = "panel51";
            this.panel51.Size = new System.Drawing.Size(326, 23);
            this.panel51.TabIndex = 0;
            // 
            // panelReAnalBottomLeft
            // 
            this.panelReAnalBottomLeft.Controls.Add(this.txtReAnalDensity);
            this.panelReAnalBottomLeft.Controls.Add(this.txtReAnalFormat);
            this.panelReAnalBottomLeft.Controls.Add(this.cbReAnalICA);
            this.panelReAnalBottomLeft.Controls.Add(this.txtReAnalBSTF);
            this.panelReAnalBottomLeft.Controls.Add(this.txtReAnalFWHMPS);
            this.panelReAnalBottomLeft.Controls.Add(this.cboxReAnalSampChannels);
            this.panelReAnalBottomLeft.Controls.Add(this.txtReAnalLivetime);
            this.panelReAnalBottomLeft.Controls.Add(this.txtReAnalMeasurementStart);
            this.panelReAnalBottomLeft.Controls.Add(this.panel55);
            this.panelReAnalBottomLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelReAnalBottomLeft.Location = new System.Drawing.Point(0, 0);
            this.panelReAnalBottomLeft.Name = "panelReAnalBottomLeft";
            this.panelReAnalBottomLeft.Size = new System.Drawing.Size(326, 270);
            this.panelReAnalBottomLeft.TabIndex = 0;
            // 
            // txtReAnalDensity
            // 
            this.txtReAnalDensity.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalDensity.Caption = "Density (g/cm3)";
            this.txtReAnalDensity.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalDensity.Location = new System.Drawing.Point(0, 170);
            this.txtReAnalDensity.MaxStringLength = 30;
            this.txtReAnalDensity.Name = "txtReAnalDensity";
            this.txtReAnalDensity.Size = new System.Drawing.Size(326, 21);
            this.txtReAnalDensity.TabIndex = 7;
            this.txtReAnalDensity.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtReAnalDensity.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtReAnalDensity.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtReAnalFormat
            // 
            this.txtReAnalFormat.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalFormat.Caption = "Format";
            this.txtReAnalFormat.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalFormat.Enabled = false;
            this.txtReAnalFormat.Location = new System.Drawing.Point(0, 149);
            this.txtReAnalFormat.MaxStringLength = 32767;
            this.txtReAnalFormat.Name = "txtReAnalFormat";
            this.txtReAnalFormat.Size = new System.Drawing.Size(326, 21);
            this.txtReAnalFormat.TabIndex = 6;
            this.txtReAnalFormat.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // cbReAnalICA
            // 
            this.cbReAnalICA.Caption = "ICA";
            this.cbReAnalICA.Checked = true;
            this.cbReAnalICA.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbReAnalICA.Location = new System.Drawing.Point(0, 128);
            this.cbReAnalICA.Name = "cbReAnalICA";
            this.cbReAnalICA.Size = new System.Drawing.Size(326, 21);
            this.cbReAnalICA.TabIndex = 8;
            // 
            // txtReAnalBSTF
            // 
            this.txtReAnalBSTF.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalBSTF.Caption = "BSTF";
            this.txtReAnalBSTF.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalBSTF.Location = new System.Drawing.Point(0, 107);
            this.txtReAnalBSTF.MaxStringLength = 30;
            this.txtReAnalBSTF.Name = "txtReAnalBSTF";
            this.txtReAnalBSTF.Size = new System.Drawing.Size(326, 21);
            this.txtReAnalBSTF.TabIndex = 4;
            this.txtReAnalBSTF.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtReAnalBSTF.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtReAnalBSTF.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtReAnalFWHMPS
            // 
            this.txtReAnalFWHMPS.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalFWHMPS.Caption = "FWHMPS";
            this.txtReAnalFWHMPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalFWHMPS.Location = new System.Drawing.Point(0, 86);
            this.txtReAnalFWHMPS.MaxStringLength = 30;
            this.txtReAnalFWHMPS.Name = "txtReAnalFWHMPS";
            this.txtReAnalFWHMPS.Size = new System.Drawing.Size(326, 21);
            this.txtReAnalFWHMPS.TabIndex = 3;
            this.txtReAnalFWHMPS.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtReAnalFWHMPS.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtReAnalFWHMPS.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // cboxReAnalSampChannels
            // 
            this.cboxReAnalSampChannels.Caption = "Channel count";
            this.cboxReAnalSampChannels.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxReAnalSampChannels.Location = new System.Drawing.Point(0, 65);
            this.cboxReAnalSampChannels.Name = "cboxReAnalSampChannels";
            this.cboxReAnalSampChannels.Size = new System.Drawing.Size(326, 21);
            this.cboxReAnalSampChannels.TabIndex = 2;
            // 
            // txtReAnalLivetime
            // 
            this.txtReAnalLivetime.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalLivetime.Caption = "Live time";
            this.txtReAnalLivetime.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalLivetime.Location = new System.Drawing.Point(0, 44);
            this.txtReAnalLivetime.MaxStringLength = 30;
            this.txtReAnalLivetime.Name = "txtReAnalLivetime";
            this.txtReAnalLivetime.Size = new System.Drawing.Size(326, 21);
            this.txtReAnalLivetime.TabIndex = 1;
            this.txtReAnalLivetime.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtReAnalLivetime.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtReAnalLivetime.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtReAnalMeasurementStart
            // 
            this.txtReAnalMeasurementStart.BackColor = System.Drawing.SystemColors.Control;
            this.txtReAnalMeasurementStart.Caption = "Measurement start";
            this.txtReAnalMeasurementStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReAnalMeasurementStart.Location = new System.Drawing.Point(0, 23);
            this.txtReAnalMeasurementStart.MaxStringLength = 12;
            this.txtReAnalMeasurementStart.Name = "txtReAnalMeasurementStart";
            this.txtReAnalMeasurementStart.Size = new System.Drawing.Size(326, 21);
            this.txtReAnalMeasurementStart.TabIndex = 0;
            this.txtReAnalMeasurementStart.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtReAnalMeasurementStart.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            this.txtReAnalMeasurementStart.Leave += new System.EventHandler(this.Datum_Leave);
            // 
            // panel55
            // 
            this.panel55.Controls.Add(this.label8);
            this.panel55.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel55.Location = new System.Drawing.Point(0, 0);
            this.panel55.Name = "panel55";
            this.panel55.Size = new System.Drawing.Size(326, 23);
            this.panel55.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Advanced";
            // 
            // toolsReAnal
            // 
            this.toolsReAnal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolsReAnal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsReAnal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonReAnalBack,
            this.labelEditAnalyzeTitle,
            this.buttonReAnalCancel,
            this.toolStripSeparator3,
            this.buttonReAnal,
            this.toolStripSeparator4,
            this.buttonReAnalToggleAdvanced});
            this.toolsReAnal.Location = new System.Drawing.Point(3, 3);
            this.toolsReAnal.Name = "toolsReAnal";
            this.toolsReAnal.Size = new System.Drawing.Size(990, 25);
            this.toolsReAnal.TabIndex = 0;
            // 
            // buttonReAnalBack
            // 
            this.buttonReAnalBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonReAnalBack.Image")));
            this.buttonReAnalBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonReAnalBack.Name = "buttonReAnalBack";
            this.buttonReAnalBack.Size = new System.Drawing.Size(89, 22);
            this.buttonReAnalBack.Text = "Main menu";
            this.buttonReAnalBack.ToolTipText = "Back to main menu";
            this.buttonReAnalBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelEditAnalyzeTitle
            // 
            this.labelEditAnalyzeTitle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelEditAnalyzeTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelEditAnalyzeTitle.Name = "labelEditAnalyzeTitle";
            this.labelEditAnalyzeTitle.Size = new System.Drawing.Size(66, 22);
            this.labelEditAnalyzeTitle.Text = "Reanalyse";
            // 
            // buttonReAnalCancel
            // 
            this.buttonReAnalCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonReAnalCancel.Image")));
            this.buttonReAnalCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonReAnalCancel.Name = "buttonReAnalCancel";
            this.buttonReAnalCancel.Size = new System.Drawing.Size(70, 22);
            this.buttonReAnalCancel.Text = "Archive";
            this.buttonReAnalCancel.ToolTipText = "Return to archive";
            this.buttonReAnalCancel.Click += new System.EventHandler(this.buttonReAnalCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonReAnal
            // 
            this.buttonReAnal.Image = ((System.Drawing.Image)(resources.GetObject("buttonReAnal.Image")));
            this.buttonReAnal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonReAnal.Name = "buttonReAnal";
            this.buttonReAnal.Size = new System.Drawing.Size(86, 22);
            this.buttonReAnal.Text = "Reanalyse";
            this.buttonReAnal.ToolTipText = "Reanalyse this spectrum";
            this.buttonReAnal.Click += new System.EventHandler(this.buttonReAnal_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonReAnalToggleAdvanced
            // 
            this.buttonReAnalToggleAdvanced.Image = ((System.Drawing.Image)(resources.GetObject("buttonReAnalToggleAdvanced.Image")));
            this.buttonReAnalToggleAdvanced.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonReAnalToggleAdvanced.Name = "buttonReAnalToggleAdvanced";
            this.buttonReAnalToggleAdvanced.Size = new System.Drawing.Size(193, 22);
            this.buttonReAnalToggleAdvanced.Text = "Toggle advanced parameters";
            this.buttonReAnalToggleAdvanced.ToolTipText = "Toggle advanced input parameters";
            this.buttonReAnalToggleAdvanced.Click += new System.EventHandler(this.buttonReAnalToggleAdvanced_Click);
            // 
            // pageAnal
            // 
            this.pageAnal.BackColor = System.Drawing.SystemColors.Control;
            this.pageAnal.Controls.Add(this.splitterNewAnal);
            this.pageAnal.Controls.Add(this.toolsStartStopView);
            this.pageAnal.Location = new System.Drawing.Point(4, 23);
            this.pageAnal.Name = "pageAnal";
            this.pageAnal.Padding = new System.Windows.Forms.Padding(3);
            this.pageAnal.Size = new System.Drawing.Size(996, 485);
            this.pageAnal.TabIndex = 4;
            this.pageAnal.Text = "Anal";
            // 
            // splitterNewAnal
            // 
            this.splitterNewAnal.BackColor = System.Drawing.SystemColors.Control;
            this.splitterNewAnal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterNewAnal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitterNewAnal.IsSplitterFixed = true;
            this.splitterNewAnal.Location = new System.Drawing.Point(3, 28);
            this.splitterNewAnal.Name = "splitterNewAnal";
            this.splitterNewAnal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitterNewAnal.Panel1
            // 
            this.splitterNewAnal.Panel1.Controls.Add(this.panelAnalTopMiddle);
            this.splitterNewAnal.Panel1.Controls.Add(this.panelAnalTopRight);
            this.splitterNewAnal.Panel1.Controls.Add(this.panelAnalTopLeft);
            // 
            // splitterNewAnal.Panel2
            // 
            this.splitterNewAnal.Panel2.Controls.Add(this.panelAnalBottomMiddle);
            this.splitterNewAnal.Panel2.Controls.Add(this.panelAnalBottomRight);
            this.splitterNewAnal.Panel2.Controls.Add(this.panelAnalBottomLeft);
            this.splitterNewAnal.Size = new System.Drawing.Size(990, 454);
            this.splitterNewAnal.SplitterDistance = 178;
            this.splitterNewAnal.SplitterWidth = 6;
            this.splitterNewAnal.TabIndex = 0;
            this.splitterNewAnal.Resize += new System.EventHandler(this.splitterNewAnal_Resize);
            // 
            // panelAnalTopMiddle
            // 
            this.panelAnalTopMiddle.Controls.Add(this.dialogAnalNuclLib);
            this.panelAnalTopMiddle.Controls.Add(this.txtAnalSamplingStop);
            this.panelAnalTopMiddle.Controls.Add(this.txtAnalQuantityUncertainty);
            this.panelAnalTopMiddle.Controls.Add(this.txtAnalHeight);
            this.panelAnalTopMiddle.Controls.Add(this.txtAnalSamplePlace);
            this.panelAnalTopMiddle.Controls.Add(this.txtAnalYear);
            this.panelAnalTopMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnalTopMiddle.Location = new System.Drawing.Point(326, 0);
            this.panelAnalTopMiddle.Name = "panelAnalTopMiddle";
            this.panelAnalTopMiddle.Size = new System.Drawing.Size(338, 178);
            this.panelAnalTopMiddle.TabIndex = 0;
            // 
            // dialogAnalNuclLib
            // 
            this.dialogAnalNuclLib.Caption = "Nuclide library";
            this.dialogAnalNuclLib.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogAnalNuclLib.Location = new System.Drawing.Point(0, 105);
            this.dialogAnalNuclLib.Name = "dialogAnalNuclLib";
            this.dialogAnalNuclLib.Size = new System.Drawing.Size(338, 21);
            this.dialogAnalNuclLib.TabIndex = 6;
            this.dialogAnalNuclLib.ButtonClicked += new System.EventHandler(this.dialogAnalNuclLib_ButtonClicked);
            // 
            // txtAnalSamplingStop
            // 
            this.txtAnalSamplingStop.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalSamplingStop.Caption = "Sampling stop";
            this.txtAnalSamplingStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalSamplingStop.Location = new System.Drawing.Point(0, 84);
            this.txtAnalSamplingStop.MaxStringLength = 12;
            this.txtAnalSamplingStop.Name = "txtAnalSamplingStop";
            this.txtAnalSamplingStop.Size = new System.Drawing.Size(338, 21);
            this.txtAnalSamplingStop.TabIndex = 5;
            this.txtAnalSamplingStop.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtAnalSamplingStop.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            this.txtAnalSamplingStop.Leave += new System.EventHandler(this.Datum_Leave);
            // 
            // txtAnalQuantityUncertainty
            // 
            this.txtAnalQuantityUncertainty.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalQuantityUncertainty.Caption = "Quantity uncertainty";
            this.txtAnalQuantityUncertainty.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalQuantityUncertainty.Location = new System.Drawing.Point(0, 63);
            this.txtAnalQuantityUncertainty.MaxStringLength = 30;
            this.txtAnalQuantityUncertainty.Name = "txtAnalQuantityUncertainty";
            this.txtAnalQuantityUncertainty.Size = new System.Drawing.Size(338, 21);
            this.txtAnalQuantityUncertainty.TabIndex = 4;
            this.txtAnalQuantityUncertainty.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtAnalQuantityUncertainty.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAnalQuantityUncertainty.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtAnalHeight
            // 
            this.txtAnalHeight.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalHeight.Caption = "Height (mm)";
            this.txtAnalHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalHeight.Location = new System.Drawing.Point(0, 42);
            this.txtAnalHeight.MaxStringLength = 30;
            this.txtAnalHeight.Name = "txtAnalHeight";
            this.txtAnalHeight.Size = new System.Drawing.Size(338, 21);
            this.txtAnalHeight.TabIndex = 2;
            this.txtAnalHeight.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtAnalHeight.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAnalHeight.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtAnalSamplePlace
            // 
            this.txtAnalSamplePlace.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalSamplePlace.Caption = "Sample place";
            this.txtAnalSamplePlace.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalSamplePlace.Location = new System.Drawing.Point(0, 21);
            this.txtAnalSamplePlace.MaxStringLength = 29;
            this.txtAnalSamplePlace.Name = "txtAnalSamplePlace";
            this.txtAnalSamplePlace.Size = new System.Drawing.Size(338, 21);
            this.txtAnalSamplePlace.TabIndex = 1;
            this.txtAnalSamplePlace.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // txtAnalYear
            // 
            this.txtAnalYear.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalYear.Caption = "Year";
            this.txtAnalYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalYear.Enabled = false;
            this.txtAnalYear.Location = new System.Drawing.Point(0, 0);
            this.txtAnalYear.MaxStringLength = 32767;
            this.txtAnalYear.Name = "txtAnalYear";
            this.txtAnalYear.Size = new System.Drawing.Size(338, 21);
            this.txtAnalYear.TabIndex = 0;
            this.txtAnalYear.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // panelAnalTopRight
            // 
            this.panelAnalTopRight.Controls.Add(this.dialogAnalDetLimLib);
            this.panelAnalTopRight.Controls.Add(this.cboxAnalSignature);
            this.panelAnalTopRight.Controls.Add(this.cboxAnalSampQuantUnit);
            this.panelAnalTopRight.Controls.Add(this.txtAnalWeight);
            this.panelAnalTopRight.Controls.Add(this.panel29);
            this.panelAnalTopRight.Controls.Add(this.txtAnalSpecNum);
            this.panelAnalTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAnalTopRight.Location = new System.Drawing.Point(664, 0);
            this.panelAnalTopRight.Name = "panelAnalTopRight";
            this.panelAnalTopRight.Size = new System.Drawing.Size(326, 178);
            this.panelAnalTopRight.TabIndex = 0;
            // 
            // dialogAnalDetLimLib
            // 
            this.dialogAnalDetLimLib.Caption = "Detection limit lib";
            this.dialogAnalDetLimLib.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogAnalDetLimLib.Location = new System.Drawing.Point(0, 107);
            this.dialogAnalDetLimLib.Name = "dialogAnalDetLimLib";
            this.dialogAnalDetLimLib.Size = new System.Drawing.Size(326, 21);
            this.dialogAnalDetLimLib.TabIndex = 5;
            this.dialogAnalDetLimLib.ButtonClicked += new System.EventHandler(this.dialogAnalDetLimLib_ButtonClicked);
            // 
            // cboxAnalSignature
            // 
            this.cboxAnalSignature.Caption = "Signature";
            this.cboxAnalSignature.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxAnalSignature.Enabled = false;
            this.cboxAnalSignature.Location = new System.Drawing.Point(0, 86);
            this.cboxAnalSignature.Name = "cboxAnalSignature";
            this.cboxAnalSignature.Size = new System.Drawing.Size(326, 21);
            this.cboxAnalSignature.TabIndex = 6;
            // 
            // cboxAnalSampQuantUnit
            // 
            this.cboxAnalSampQuantUnit.Caption = "Quantity unit";
            this.cboxAnalSampQuantUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxAnalSampQuantUnit.Location = new System.Drawing.Point(0, 65);
            this.cboxAnalSampQuantUnit.Name = "cboxAnalSampQuantUnit";
            this.cboxAnalSampQuantUnit.Size = new System.Drawing.Size(326, 21);
            this.cboxAnalSampQuantUnit.TabIndex = 3;
            // 
            // txtAnalWeight
            // 
            this.txtAnalWeight.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalWeight.Caption = "Weight (g)";
            this.txtAnalWeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalWeight.Location = new System.Drawing.Point(0, 44);
            this.txtAnalWeight.MaxStringLength = 30;
            this.txtAnalWeight.Name = "txtAnalWeight";
            this.txtAnalWeight.Size = new System.Drawing.Size(326, 21);
            this.txtAnalWeight.TabIndex = 2;
            this.txtAnalWeight.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtAnalWeight.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAnalWeight.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // panel29
            // 
            this.panel29.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel29.Location = new System.Drawing.Point(0, 21);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(326, 23);
            this.panel29.TabIndex = 1;
            // 
            // txtAnalSpecNum
            // 
            this.txtAnalSpecNum.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalSpecNum.Caption = "Spectrum nr.";
            this.txtAnalSpecNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalSpecNum.Enabled = false;
            this.txtAnalSpecNum.Location = new System.Drawing.Point(0, 0);
            this.txtAnalSpecNum.MaxStringLength = 32767;
            this.txtAnalSpecNum.Name = "txtAnalSpecNum";
            this.txtAnalSpecNum.Size = new System.Drawing.Size(326, 21);
            this.txtAnalSpecNum.TabIndex = 0;
            this.txtAnalSpecNum.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // panelAnalTopLeft
            // 
            this.panelAnalTopLeft.Controls.Add(this.txtAnalReferenceTime);
            this.panelAnalTopLeft.Controls.Add(this.txtAnalSamplingStart);
            this.panelAnalTopLeft.Controls.Add(this.txtAnalQuantity);
            this.panelAnalTopLeft.Controls.Add(this.cboxAnalSampBeaker);
            this.panelAnalTopLeft.Controls.Add(this.txtAnalSampleId);
            this.panelAnalTopLeft.Controls.Add(this.txtAnalDetector);
            this.panelAnalTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAnalTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panelAnalTopLeft.Name = "panelAnalTopLeft";
            this.panelAnalTopLeft.Size = new System.Drawing.Size(326, 178);
            this.panelAnalTopLeft.TabIndex = 0;
            // 
            // txtAnalReferenceTime
            // 
            this.txtAnalReferenceTime.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalReferenceTime.Caption = "Reference time";
            this.txtAnalReferenceTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalReferenceTime.Location = new System.Drawing.Point(0, 105);
            this.txtAnalReferenceTime.MaxStringLength = 12;
            this.txtAnalReferenceTime.Name = "txtAnalReferenceTime";
            this.txtAnalReferenceTime.Size = new System.Drawing.Size(326, 21);
            this.txtAnalReferenceTime.TabIndex = 6;
            this.txtAnalReferenceTime.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtAnalReferenceTime.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            this.txtAnalReferenceTime.Leave += new System.EventHandler(this.Datum_Leave);
            // 
            // txtAnalSamplingStart
            // 
            this.txtAnalSamplingStart.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalSamplingStart.Caption = "Sampling start";
            this.txtAnalSamplingStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalSamplingStart.Location = new System.Drawing.Point(0, 84);
            this.txtAnalSamplingStart.MaxStringLength = 12;
            this.txtAnalSamplingStart.Name = "txtAnalSamplingStart";
            this.txtAnalSamplingStart.Size = new System.Drawing.Size(326, 21);
            this.txtAnalSamplingStart.TabIndex = 5;
            this.txtAnalSamplingStart.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtAnalSamplingStart.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            this.txtAnalSamplingStart.Leave += new System.EventHandler(this.Datum_Leave);
            // 
            // txtAnalQuantity
            // 
            this.txtAnalQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalQuantity.Caption = "Quantity";
            this.txtAnalQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalQuantity.Location = new System.Drawing.Point(0, 63);
            this.txtAnalQuantity.MaxStringLength = 30;
            this.txtAnalQuantity.Name = "txtAnalQuantity";
            this.txtAnalQuantity.Size = new System.Drawing.Size(326, 21);
            this.txtAnalQuantity.TabIndex = 4;
            this.txtAnalQuantity.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtAnalQuantity.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAnalQuantity.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // cboxAnalSampBeaker
            // 
            this.cboxAnalSampBeaker.Caption = "Beaker";
            this.cboxAnalSampBeaker.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxAnalSampBeaker.Location = new System.Drawing.Point(0, 42);
            this.cboxAnalSampBeaker.Name = "cboxAnalSampBeaker";
            this.cboxAnalSampBeaker.Size = new System.Drawing.Size(326, 21);
            this.cboxAnalSampBeaker.TabIndex = 2;
            this.cboxAnalSampBeaker.SelectedValueChanged += new System.EventHandler(this.cboxAnalSampBeaker_SelectedValueChanged);
            // 
            // txtAnalSampleId
            // 
            this.txtAnalSampleId.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalSampleId.Caption = "Sample Id/Type";
            this.txtAnalSampleId.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalSampleId.Location = new System.Drawing.Point(0, 21);
            this.txtAnalSampleId.MaxStringLength = 39;
            this.txtAnalSampleId.Name = "txtAnalSampleId";
            this.txtAnalSampleId.Size = new System.Drawing.Size(326, 21);
            this.txtAnalSampleId.TabIndex = 1;
            this.txtAnalSampleId.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            // 
            // txtAnalDetector
            // 
            this.txtAnalDetector.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalDetector.Caption = "Detector";
            this.txtAnalDetector.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalDetector.Enabled = false;
            this.txtAnalDetector.Location = new System.Drawing.Point(0, 0);
            this.txtAnalDetector.MaxStringLength = 32767;
            this.txtAnalDetector.Name = "txtAnalDetector";
            this.txtAnalDetector.Size = new System.Drawing.Size(326, 21);
            this.txtAnalDetector.TabIndex = 0;
            this.txtAnalDetector.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // panelAnalBottomMiddle
            // 
            this.panelAnalBottomMiddle.Controls.Add(this.txtAnalVolume);
            this.panelAnalBottomMiddle.Controls.Add(this.labeledTextBox31);
            this.panelAnalBottomMiddle.Controls.Add(this.labeledTextBox28);
            this.panelAnalBottomMiddle.Controls.Add(this.panel27);
            this.panelAnalBottomMiddle.Controls.Add(this.dialogAnalPEFFile);
            this.panelAnalBottomMiddle.Controls.Add(this.dialogAnalBackgroundFile);
            this.panelAnalBottomMiddle.Controls.Add(this.txtAnalETOL);
            this.panelAnalBottomMiddle.Controls.Add(this.txtAnalFWHMAN);
            this.panelAnalBottomMiddle.Controls.Add(this.panel23);
            this.panelAnalBottomMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnalBottomMiddle.Location = new System.Drawing.Point(326, 0);
            this.panelAnalBottomMiddle.Name = "panelAnalBottomMiddle";
            this.panelAnalBottomMiddle.Size = new System.Drawing.Size(338, 270);
            this.panelAnalBottomMiddle.TabIndex = 0;
            // 
            // txtAnalVolume
            // 
            this.txtAnalVolume.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalVolume.Caption = "Volume (cm3)";
            this.txtAnalVolume.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalVolume.Location = new System.Drawing.Point(0, 172);
            this.txtAnalVolume.MaxStringLength = 30;
            this.txtAnalVolume.Name = "txtAnalVolume";
            this.txtAnalVolume.Size = new System.Drawing.Size(338, 21);
            this.txtAnalVolume.TabIndex = 7;
            this.txtAnalVolume.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtAnalVolume.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAnalVolume.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // labeledTextBox31
            // 
            this.labeledTextBox31.BackColor = System.Drawing.SystemColors.Control;
            this.labeledTextBox31.Caption = "Channel stop";
            this.labeledTextBox31.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeledTextBox31.Enabled = false;
            this.labeledTextBox31.Location = new System.Drawing.Point(0, 151);
            this.labeledTextBox31.MaxStringLength = 20;
            this.labeledTextBox31.Name = "labeledTextBox31";
            this.labeledTextBox31.Size = new System.Drawing.Size(338, 21);
            this.labeledTextBox31.TabIndex = 6;
            this.labeledTextBox31.TextBackColor = System.Drawing.SystemColors.Window;
            this.labeledTextBox31.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // labeledTextBox28
            // 
            this.labeledTextBox28.BackColor = System.Drawing.SystemColors.Control;
            this.labeledTextBox28.Caption = "Real time";
            this.labeledTextBox28.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeledTextBox28.Enabled = false;
            this.labeledTextBox28.Location = new System.Drawing.Point(0, 130);
            this.labeledTextBox28.MaxStringLength = 30;
            this.labeledTextBox28.Name = "labeledTextBox28";
            this.labeledTextBox28.Size = new System.Drawing.Size(338, 21);
            this.labeledTextBox28.TabIndex = 5;
            this.labeledTextBox28.TextBackColor = System.Drawing.SystemColors.Window;
            this.labeledTextBox28.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.labeledTextBox28.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // panel27
            // 
            this.panel27.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel27.Location = new System.Drawing.Point(0, 107);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(338, 23);
            this.panel27.TabIndex = 4;
            // 
            // dialogAnalPEFFile
            // 
            this.dialogAnalPEFFile.Caption = "PEF file";
            this.dialogAnalPEFFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogAnalPEFFile.Location = new System.Drawing.Point(0, 86);
            this.dialogAnalPEFFile.Name = "dialogAnalPEFFile";
            this.dialogAnalPEFFile.Size = new System.Drawing.Size(338, 21);
            this.dialogAnalPEFFile.TabIndex = 3;
            this.dialogAnalPEFFile.ButtonClicked += new System.EventHandler(this.dialogAnalPEFFile_ButtonClicked);
            // 
            // dialogAnalBackgroundFile
            // 
            this.dialogAnalBackgroundFile.Caption = "Background file";
            this.dialogAnalBackgroundFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogAnalBackgroundFile.Location = new System.Drawing.Point(0, 65);
            this.dialogAnalBackgroundFile.Name = "dialogAnalBackgroundFile";
            this.dialogAnalBackgroundFile.Size = new System.Drawing.Size(338, 21);
            this.dialogAnalBackgroundFile.TabIndex = 2;
            this.dialogAnalBackgroundFile.ButtonClicked += new System.EventHandler(this.dialogAnalBackgroundFile_ButtonClicked);
            // 
            // txtAnalETOL
            // 
            this.txtAnalETOL.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalETOL.Caption = "ETOL";
            this.txtAnalETOL.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalETOL.Location = new System.Drawing.Point(0, 44);
            this.txtAnalETOL.MaxStringLength = 30;
            this.txtAnalETOL.Name = "txtAnalETOL";
            this.txtAnalETOL.Size = new System.Drawing.Size(338, 21);
            this.txtAnalETOL.TabIndex = 1;
            this.txtAnalETOL.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtAnalETOL.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAnalETOL.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtAnalFWHMAN
            // 
            this.txtAnalFWHMAN.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalFWHMAN.Caption = "FWHMAN";
            this.txtAnalFWHMAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalFWHMAN.Location = new System.Drawing.Point(0, 23);
            this.txtAnalFWHMAN.MaxStringLength = 30;
            this.txtAnalFWHMAN.Name = "txtAnalFWHMAN";
            this.txtAnalFWHMAN.Size = new System.Drawing.Size(338, 21);
            this.txtAnalFWHMAN.TabIndex = 0;
            this.txtAnalFWHMAN.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtAnalFWHMAN.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAnalFWHMAN.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // panel23
            // 
            this.panel23.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel23.Location = new System.Drawing.Point(0, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(338, 23);
            this.panel23.TabIndex = 0;
            // 
            // panelAnalBottomRight
            // 
            this.panelAnalBottomRight.Controls.Add(this.panel12);
            this.panelAnalBottomRight.Controls.Add(this.panel1);
            this.panelAnalBottomRight.Controls.Add(this.labeledTextBox29);
            this.panelAnalBottomRight.Controls.Add(this.panel28);
            this.panelAnalBottomRight.Controls.Add(this.dialogAnalTEFFile);
            this.panelAnalBottomRight.Controls.Add(this.dialogAnalEnergyFile);
            this.panelAnalBottomRight.Controls.Add(this.txtAnalLOCH);
            this.panelAnalBottomRight.Controls.Add(this.txtAnalTHRESH);
            this.panelAnalBottomRight.Controls.Add(this.panel24);
            this.panelAnalBottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAnalBottomRight.Location = new System.Drawing.Point(664, 0);
            this.panelAnalBottomRight.Name = "panelAnalBottomRight";
            this.panelAnalBottomRight.Size = new System.Drawing.Size(326, 270);
            this.panelAnalBottomRight.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.buttonAnalRecalculate);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 174);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(326, 21);
            this.panel12.TabIndex = 9;
            // 
            // buttonAnalRecalculate
            // 
            this.buttonAnalRecalculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnalRecalculate.Location = new System.Drawing.Point(0, 0);
            this.buttonAnalRecalculate.Name = "buttonAnalRecalculate";
            this.buttonAnalRecalculate.Size = new System.Drawing.Size(326, 21);
            this.buttonAnalRecalculate.TabIndex = 0;
            this.buttonAnalRecalculate.Text = "Calculate density and volume";
            this.buttonAnalRecalculate.UseVisualStyleBackColor = true;
            this.buttonAnalRecalculate.Click += new System.EventHandler(this.buttonAnalRecalculate_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 23);
            this.panel1.TabIndex = 6;
            // 
            // labeledTextBox29
            // 
            this.labeledTextBox29.BackColor = System.Drawing.SystemColors.Control;
            this.labeledTextBox29.Caption = "Integral ROI";
            this.labeledTextBox29.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeledTextBox29.Enabled = false;
            this.labeledTextBox29.Location = new System.Drawing.Point(0, 130);
            this.labeledTextBox29.MaxStringLength = 30;
            this.labeledTextBox29.Name = "labeledTextBox29";
            this.labeledTextBox29.Size = new System.Drawing.Size(326, 21);
            this.labeledTextBox29.TabIndex = 5;
            this.labeledTextBox29.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // panel28
            // 
            this.panel28.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel28.Location = new System.Drawing.Point(0, 107);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(326, 23);
            this.panel28.TabIndex = 4;
            // 
            // dialogAnalTEFFile
            // 
            this.dialogAnalTEFFile.Caption = "TEF file";
            this.dialogAnalTEFFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogAnalTEFFile.Location = new System.Drawing.Point(0, 86);
            this.dialogAnalTEFFile.Name = "dialogAnalTEFFile";
            this.dialogAnalTEFFile.Size = new System.Drawing.Size(326, 21);
            this.dialogAnalTEFFile.TabIndex = 3;
            this.dialogAnalTEFFile.ButtonClicked += new System.EventHandler(this.dialogAnalTEFFile_ButtonClicked);
            // 
            // dialogAnalEnergyFile
            // 
            this.dialogAnalEnergyFile.Caption = "Energy file";
            this.dialogAnalEnergyFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogAnalEnergyFile.Location = new System.Drawing.Point(0, 65);
            this.dialogAnalEnergyFile.Name = "dialogAnalEnergyFile";
            this.dialogAnalEnergyFile.Size = new System.Drawing.Size(326, 21);
            this.dialogAnalEnergyFile.TabIndex = 2;
            this.dialogAnalEnergyFile.ButtonClicked += new System.EventHandler(this.dialogAnalEnergyFile_ButtonClicked);
            // 
            // txtAnalLOCH
            // 
            this.txtAnalLOCH.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalLOCH.Caption = "LOCH";
            this.txtAnalLOCH.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalLOCH.Location = new System.Drawing.Point(0, 44);
            this.txtAnalLOCH.MaxStringLength = 30;
            this.txtAnalLOCH.Name = "txtAnalLOCH";
            this.txtAnalLOCH.Size = new System.Drawing.Size(326, 21);
            this.txtAnalLOCH.TabIndex = 1;
            this.txtAnalLOCH.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtAnalLOCH.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAnalLOCH.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtAnalTHRESH
            // 
            this.txtAnalTHRESH.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalTHRESH.Caption = "THRESH";
            this.txtAnalTHRESH.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalTHRESH.Location = new System.Drawing.Point(0, 23);
            this.txtAnalTHRESH.MaxStringLength = 30;
            this.txtAnalTHRESH.Name = "txtAnalTHRESH";
            this.txtAnalTHRESH.Size = new System.Drawing.Size(326, 21);
            this.txtAnalTHRESH.TabIndex = 0;
            this.txtAnalTHRESH.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtAnalTHRESH.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAnalTHRESH.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // panel24
            // 
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(0, 0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(326, 23);
            this.panel24.TabIndex = 0;
            // 
            // panelAnalBottomLeft
            // 
            this.panelAnalBottomLeft.Controls.Add(this.txtAnalDensity);
            this.panelAnalBottomLeft.Controls.Add(this.labeledTextBox30);
            this.panelAnalBottomLeft.Controls.Add(this.labeledTextBox19);
            this.panelAnalBottomLeft.Controls.Add(this.panel26);
            this.panelAnalBottomLeft.Controls.Add(this.panel25);
            this.panelAnalBottomLeft.Controls.Add(this.cbAnalICA);
            this.panelAnalBottomLeft.Controls.Add(this.txtAnalBSTF);
            this.panelAnalBottomLeft.Controls.Add(this.txtAnalFWHMPS);
            this.panelAnalBottomLeft.Controls.Add(this.panel22);
            this.panelAnalBottomLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAnalBottomLeft.Location = new System.Drawing.Point(0, 0);
            this.panelAnalBottomLeft.Name = "panelAnalBottomLeft";
            this.panelAnalBottomLeft.Size = new System.Drawing.Size(326, 270);
            this.panelAnalBottomLeft.TabIndex = 0;
            // 
            // txtAnalDensity
            // 
            this.txtAnalDensity.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalDensity.Caption = "Density (g/cm3)";
            this.txtAnalDensity.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalDensity.Location = new System.Drawing.Point(0, 172);
            this.txtAnalDensity.MaxStringLength = 30;
            this.txtAnalDensity.Name = "txtAnalDensity";
            this.txtAnalDensity.Size = new System.Drawing.Size(326, 21);
            this.txtAnalDensity.TabIndex = 7;
            this.txtAnalDensity.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtAnalDensity.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAnalDensity.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // labeledTextBox30
            // 
            this.labeledTextBox30.BackColor = System.Drawing.SystemColors.Control;
            this.labeledTextBox30.Caption = "Channel start";
            this.labeledTextBox30.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeledTextBox30.Enabled = false;
            this.labeledTextBox30.Location = new System.Drawing.Point(0, 151);
            this.labeledTextBox30.MaxStringLength = 20;
            this.labeledTextBox30.Name = "labeledTextBox30";
            this.labeledTextBox30.Size = new System.Drawing.Size(326, 21);
            this.labeledTextBox30.TabIndex = 6;
            this.labeledTextBox30.TextBackColor = System.Drawing.SystemColors.Window;
            this.labeledTextBox30.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // labeledTextBox19
            // 
            this.labeledTextBox19.BackColor = System.Drawing.SystemColors.Control;
            this.labeledTextBox19.Caption = "Live time";
            this.labeledTextBox19.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeledTextBox19.Enabled = false;
            this.labeledTextBox19.Location = new System.Drawing.Point(0, 130);
            this.labeledTextBox19.MaxStringLength = 30;
            this.labeledTextBox19.Name = "labeledTextBox19";
            this.labeledTextBox19.Size = new System.Drawing.Size(326, 21);
            this.labeledTextBox19.TabIndex = 5;
            this.labeledTextBox19.TextBackColor = System.Drawing.SystemColors.Window;
            this.labeledTextBox19.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.labeledTextBox19.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.label4);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel26.Location = new System.Drawing.Point(0, 107);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(326, 23);
            this.panel26.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Presets";
            // 
            // panel25
            // 
            this.panel25.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel25.Location = new System.Drawing.Point(0, 86);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(326, 21);
            this.panel25.TabIndex = 3;
            // 
            // cbAnalICA
            // 
            this.cbAnalICA.Caption = "ICA";
            this.cbAnalICA.Checked = true;
            this.cbAnalICA.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAnalICA.Location = new System.Drawing.Point(0, 65);
            this.cbAnalICA.Name = "cbAnalICA";
            this.cbAnalICA.Size = new System.Drawing.Size(326, 21);
            this.cbAnalICA.TabIndex = 8;
            // 
            // txtAnalBSTF
            // 
            this.txtAnalBSTF.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalBSTF.Caption = "BSTF";
            this.txtAnalBSTF.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalBSTF.Location = new System.Drawing.Point(0, 44);
            this.txtAnalBSTF.MaxStringLength = 30;
            this.txtAnalBSTF.Name = "txtAnalBSTF";
            this.txtAnalBSTF.Size = new System.Drawing.Size(326, 21);
            this.txtAnalBSTF.TabIndex = 1;
            this.txtAnalBSTF.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtAnalBSTF.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAnalBSTF.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtAnalFWHMPS
            // 
            this.txtAnalFWHMPS.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalFWHMPS.Caption = "FWHMPS";
            this.txtAnalFWHMPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAnalFWHMPS.Location = new System.Drawing.Point(0, 23);
            this.txtAnalFWHMPS.MaxStringLength = 30;
            this.txtAnalFWHMPS.Name = "txtAnalFWHMPS";
            this.txtAnalFWHMPS.Size = new System.Drawing.Size(326, 21);
            this.txtAnalFWHMPS.TabIndex = 0;
            this.txtAnalFWHMPS.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtAnalFWHMPS.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAnalFWHMPS.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.label3);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel22.Location = new System.Drawing.Point(0, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(326, 23);
            this.panel22.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Advanced";
            // 
            // toolsStartStopView
            // 
            this.toolsStartStopView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolsStartStopView.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsStartStopView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonStartStopViewBack,
            this.toolStripSeparator1,
            this.buttonAnalStart,
            this.buttonAnalStop,
            this.buttonAnalBuffer,
            this.toolStripSeparator6,
            this.buttonAnalToggleAdvanced,
            this.labelAnalMeasurement,
            this.labelStartStopView});
            this.toolsStartStopView.Location = new System.Drawing.Point(3, 3);
            this.toolsStartStopView.Name = "toolsStartStopView";
            this.toolsStartStopView.Size = new System.Drawing.Size(990, 25);
            this.toolsStartStopView.TabIndex = 0;
            // 
            // buttonStartStopViewBack
            // 
            this.buttonStartStopViewBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonStartStopViewBack.Image")));
            this.buttonStartStopViewBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonStartStopViewBack.Name = "buttonStartStopViewBack";
            this.buttonStartStopViewBack.Size = new System.Drawing.Size(112, 22);
            this.buttonStartStopViewBack.Text = "Detector menu";
            this.buttonStartStopViewBack.ToolTipText = "Back to detector menu";
            this.buttonStartStopViewBack.Click += new System.EventHandler(this.buttonStartStopViewBack_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonAnalStart
            // 
            this.buttonAnalStart.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnalStart.Image")));
            this.buttonAnalStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAnalStart.Name = "buttonAnalStart";
            this.buttonAnalStart.Size = new System.Drawing.Size(56, 22);
            this.buttonAnalStart.Text = "Start";
            this.buttonAnalStart.ToolTipText = "Start a new mesaurement";
            this.buttonAnalStart.Click += new System.EventHandler(this.buttonAnalStart_Click);
            // 
            // buttonAnalStop
            // 
            this.buttonAnalStop.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnalStop.Image")));
            this.buttonAnalStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAnalStop.Name = "buttonAnalStop";
            this.buttonAnalStop.Size = new System.Drawing.Size(53, 22);
            this.buttonAnalStop.Text = "Stop";
            this.buttonAnalStop.ToolTipText = "Stop current measurement";
            this.buttonAnalStop.Click += new System.EventHandler(this.buttonAnalStop_Click);
            // 
            // buttonAnalBuffer
            // 
            this.buttonAnalBuffer.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnalBuffer.Image")));
            this.buttonAnalBuffer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAnalBuffer.Name = "buttonAnalBuffer";
            this.buttonAnalBuffer.Size = new System.Drawing.Size(55, 22);
            this.buttonAnalBuffer.Text = "Peek";
            this.buttonAnalBuffer.ToolTipText = "Create a buffer spectrum of current measurement";
            this.buttonAnalBuffer.Click += new System.EventHandler(this.buttonAnalBuffer_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonAnalToggleAdvanced
            // 
            this.buttonAnalToggleAdvanced.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnalToggleAdvanced.Image")));
            this.buttonAnalToggleAdvanced.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAnalToggleAdvanced.Name = "buttonAnalToggleAdvanced";
            this.buttonAnalToggleAdvanced.Size = new System.Drawing.Size(193, 22);
            this.buttonAnalToggleAdvanced.Text = "Toggle advanced parameters";
            this.buttonAnalToggleAdvanced.ToolTipText = "Toggle advanced input parameters";
            this.buttonAnalToggleAdvanced.Click += new System.EventHandler(this.buttonAnalToggleAdvanced_Click);
            // 
            // labelAnalMeasurement
            // 
            this.labelAnalMeasurement.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelAnalMeasurement.Name = "labelAnalMeasurement";
            this.labelAnalMeasurement.Size = new System.Drawing.Size(86, 22);
            this.labelAnalMeasurement.Text = "Measurement";
            // 
            // labelStartStopView
            // 
            this.labelStartStopView.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelStartStopView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelStartStopView.Name = "labelStartStopView";
            this.labelStartStopView.Size = new System.Drawing.Size(57, 22);
            this.labelStartStopView.Text = "Detector";
            // 
            // pageAdmin
            // 
            this.pageAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.pageAdmin.Controls.Add(this.panelAdmin);
            this.pageAdmin.Controls.Add(this.toolsAdmin);
            this.pageAdmin.Location = new System.Drawing.Point(4, 23);
            this.pageAdmin.Name = "pageAdmin";
            this.pageAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.pageAdmin.Size = new System.Drawing.Size(996, 485);
            this.pageAdmin.TabIndex = 5;
            this.pageAdmin.Text = "Admin";
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.tabControlAdmin);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdmin.Location = new System.Drawing.Point(3, 28);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(990, 454);
            this.panelAdmin.TabIndex = 2;
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.pageAdminConfig);
            this.tabControlAdmin.Controls.Add(this.pageAdminDetectors);
            this.tabControlAdmin.Controls.Add(this.pageAdminBeaker);
            this.tabControlAdmin.Controls.Add(this.pageAdminMaestro);
            this.tabControlAdmin.Controls.Add(this.tabAdminGenie);
            this.tabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(990, 454);
            this.tabControlAdmin.TabIndex = 1;
            this.tabControlAdmin.SelectedIndexChanged += new System.EventHandler(this.tabControlAdmin_SelectedIndexChanged);
            // 
            // pageAdminConfig
            // 
            this.pageAdminConfig.BackColor = System.Drawing.SystemColors.Control;
            this.pageAdminConfig.Controls.Add(this.panel50);
            this.pageAdminConfig.Location = new System.Drawing.Point(4, 22);
            this.pageAdminConfig.Name = "pageAdminConfig";
            this.pageAdminConfig.Padding = new System.Windows.Forms.Padding(3);
            this.pageAdminConfig.Size = new System.Drawing.Size(982, 428);
            this.pageAdminConfig.TabIndex = 0;
            this.pageAdminConfig.Text = "System configuration";
            // 
            // panel50
            // 
            this.panel50.Controls.Add(this.panel30);
            this.panel50.Controls.Add(this.panel57);
            this.panel50.Controls.Add(this.panel56);
            this.panel50.Controls.Add(this.labeledFileDialog18);
            this.panel50.Controls.Add(this.labeledFileDialog17);
            this.panel50.Controls.Add(this.dialogAdminDefDetLib);
            this.panel50.Controls.Add(this.dialogAdminDefNuclLib);
            this.panel50.Controls.Add(this.panel54);
            this.panel50.Controls.Add(this.panelAdminSetup);
            this.panel50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel50.Location = new System.Drawing.Point(3, 3);
            this.panel50.Name = "panel50";
            this.panel50.Size = new System.Drawing.Size(976, 422);
            this.panel50.TabIndex = 0;
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.cbAdminEmulateFixCHN);
            this.panel30.Controls.Add(this.cbAdminUseDafaultPrinter);
            this.panel30.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel30.Location = new System.Drawing.Point(0, 189);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(976, 26);
            this.panel30.TabIndex = 9;
            // 
            // cbAdminEmulateFixCHN
            // 
            this.cbAdminEmulateFixCHN.AutoSize = true;
            this.cbAdminEmulateFixCHN.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbAdminEmulateFixCHN.Enabled = false;
            this.cbAdminEmulateFixCHN.Location = new System.Drawing.Point(173, 0);
            this.cbAdminEmulateFixCHN.Name = "cbAdminEmulateFixCHN";
            this.cbAdminEmulateFixCHN.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cbAdminEmulateFixCHN.Size = new System.Drawing.Size(123, 26);
            this.cbAdminEmulateFixCHN.TabIndex = 3;
            this.cbAdminEmulateFixCHN.Text = "Emulate fixchn.exe";
            this.cbAdminEmulateFixCHN.UseVisualStyleBackColor = true;
            this.cbAdminEmulateFixCHN.Visible = false;
            // 
            // cbAdminUseDafaultPrinter
            // 
            this.cbAdminUseDafaultPrinter.AutoSize = true;
            this.cbAdminUseDafaultPrinter.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbAdminUseDafaultPrinter.Location = new System.Drawing.Point(0, 0);
            this.cbAdminUseDafaultPrinter.Name = "cbAdminUseDafaultPrinter";
            this.cbAdminUseDafaultPrinter.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cbAdminUseDafaultPrinter.Size = new System.Drawing.Size(173, 26);
            this.cbAdminUseDafaultPrinter.TabIndex = 2;
            this.cbAdminUseDafaultPrinter.Text = "Use default printer if available";
            this.cbAdminUseDafaultPrinter.UseVisualStyleBackColor = true;
            this.cbAdminUseDafaultPrinter.CheckedChanged += new System.EventHandler(this.cbAdminUseDafaultPrinter_CheckedChanged);
            // 
            // panel57
            // 
            this.panel57.Controls.Add(this.checkBox6);
            this.panel57.Controls.Add(this.checkBox5);
            this.panel57.Controls.Add(this.checkBox4);
            this.panel57.Controls.Add(this.checkBox3);
            this.panel57.Controls.Add(this.checkBox2);
            this.panel57.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel57.Location = new System.Drawing.Point(0, 163);
            this.panel57.Name = "panel57";
            this.panel57.Size = new System.Drawing.Size(976, 26);
            this.panel57.TabIndex = 8;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox6.Enabled = false;
            this.checkBox6.Location = new System.Drawing.Point(228, 0);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkBox6.Size = new System.Drawing.Size(65, 26);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Text = "Exdisk";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.Visible = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(162, 0);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkBox5.Size = new System.Drawing.Size(66, 26);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.Text = "Exprint";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Visible = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(107, 0);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkBox4.Size = new System.Drawing.Size(55, 26);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "Disk";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(55, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkBox3.Size = new System.Drawing.Size(52, 26);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Plot";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(0, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkBox2.Size = new System.Drawing.Size(55, 26);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Print";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // panel56
            // 
            this.panel56.Controls.Add(this.label10);
            this.panel56.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel56.Location = new System.Drawing.Point(0, 133);
            this.panel56.Name = "panel56";
            this.panel56.Size = new System.Drawing.Size(976, 30);
            this.panel56.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label10.Size = new System.Drawing.Size(111, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Output parameters";
            // 
            // labeledFileDialog18
            // 
            this.labeledFileDialog18.Caption = "Default QA reference nuclide library";
            this.labeledFileDialog18.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeledFileDialog18.Enabled = false;
            this.labeledFileDialog18.Location = new System.Drawing.Point(0, 112);
            this.labeledFileDialog18.Name = "labeledFileDialog18";
            this.labeledFileDialog18.Size = new System.Drawing.Size(976, 21);
            this.labeledFileDialog18.TabIndex = 6;
            // 
            // labeledFileDialog17
            // 
            this.labeledFileDialog17.Caption = "Default QA background nuclide library";
            this.labeledFileDialog17.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeledFileDialog17.Enabled = false;
            this.labeledFileDialog17.Location = new System.Drawing.Point(0, 91);
            this.labeledFileDialog17.Name = "labeledFileDialog17";
            this.labeledFileDialog17.Size = new System.Drawing.Size(976, 21);
            this.labeledFileDialog17.TabIndex = 5;
            // 
            // dialogAdminDefDetLib
            // 
            this.dialogAdminDefDetLib.Caption = "Default detection limit library ";
            this.dialogAdminDefDetLib.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogAdminDefDetLib.Location = new System.Drawing.Point(0, 70);
            this.dialogAdminDefDetLib.Name = "dialogAdminDefDetLib";
            this.dialogAdminDefDetLib.Size = new System.Drawing.Size(976, 21);
            this.dialogAdminDefDetLib.TabIndex = 4;
            this.dialogAdminDefDetLib.FileSelected += new System.EventHandler(this.dialogAdminDefDetLib_FileSelected);
            this.dialogAdminDefDetLib.ButtonClicked += new System.EventHandler(this.dialogAdminDefDetLib_ButtonClicked);
            // 
            // dialogAdminDefNuclLib
            // 
            this.dialogAdminDefNuclLib.Caption = "Default nuclide library";
            this.dialogAdminDefNuclLib.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogAdminDefNuclLib.Location = new System.Drawing.Point(0, 49);
            this.dialogAdminDefNuclLib.Name = "dialogAdminDefNuclLib";
            this.dialogAdminDefNuclLib.Size = new System.Drawing.Size(976, 21);
            this.dialogAdminDefNuclLib.TabIndex = 3;
            this.dialogAdminDefNuclLib.FileSelected += new System.EventHandler(this.dialogAdminDefNuclLib_FileSelected);
            this.dialogAdminDefNuclLib.ButtonClicked += new System.EventHandler(this.dialogAdminDefNuclLib_ButtonClicked);
            // 
            // panel54
            // 
            this.panel54.Controls.Add(this.label9);
            this.panel54.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel54.Location = new System.Drawing.Point(0, 19);
            this.panel54.Name = "panel54";
            this.panel54.Size = new System.Drawing.Size(976, 30);
            this.panel54.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label9.Size = new System.Drawing.Size(96, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Default libraries";
            // 
            // panelAdminSetup
            // 
            this.panelAdminSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminSetup.Location = new System.Drawing.Point(0, 0);
            this.panelAdminSetup.Name = "panelAdminSetup";
            this.panelAdminSetup.Size = new System.Drawing.Size(976, 19);
            this.panelAdminSetup.TabIndex = 0;
            // 
            // pageAdminDetectors
            // 
            this.pageAdminDetectors.Controls.Add(this.listViewAdminDetectors);
            this.pageAdminDetectors.Controls.Add(this.panel7);
            this.pageAdminDetectors.Location = new System.Drawing.Point(4, 22);
            this.pageAdminDetectors.Name = "pageAdminDetectors";
            this.pageAdminDetectors.Padding = new System.Windows.Forms.Padding(3);
            this.pageAdminDetectors.Size = new System.Drawing.Size(178, 16);
            this.pageAdminDetectors.TabIndex = 1;
            this.pageAdminDetectors.Text = "Detector configuration";
            this.pageAdminDetectors.UseVisualStyleBackColor = true;
            // 
            // listViewAdminDetectors
            // 
            this.listViewAdminDetectors.BackColor = System.Drawing.SystemColors.Window;
            this.listViewAdminDetectors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAdminDetectorName,
            this.columnAdminSpecSoft,
            this.columnAdminDetectorType,
            this.columnAdminDetectorActive,
            this.columnAdminDetectorConnected});
            this.listViewAdminDetectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAdminDetectors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAdminDetectors.FullRowSelect = true;
            this.listViewAdminDetectors.Location = new System.Drawing.Point(3, 3);
            this.listViewAdminDetectors.MultiSelect = false;
            this.listViewAdminDetectors.Name = "listViewAdminDetectors";
            this.listViewAdminDetectors.Size = new System.Drawing.Size(452, 422);
            this.listViewAdminDetectors.SmallImageList = this.imageListSmall;
            this.listViewAdminDetectors.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewAdminDetectors.TabIndex = 0;
            this.listViewAdminDetectors.UseCompatibleStateImageBehavior = false;
            this.listViewAdminDetectors.View = System.Windows.Forms.View.Details;
            this.listViewAdminDetectors.SelectedIndexChanged += new System.EventHandler(this.listViewAdminDetectors_SelectedIndexChanged);
            this.listViewAdminDetectors.Resize += new System.EventHandler(this.listViewAdminDetectors_Resize);
            // 
            // columnAdminDetectorName
            // 
            this.columnAdminDetectorName.Text = "Name";
            this.columnAdminDetectorName.Width = 67;
            // 
            // columnAdminSpecSoft
            // 
            this.columnAdminSpecSoft.Text = "Software";
            this.columnAdminSpecSoft.Width = 80;
            // 
            // columnAdminDetectorType
            // 
            this.columnAdminDetectorType.Text = "Type";
            this.columnAdminDetectorType.Width = 80;
            // 
            // columnAdminDetectorActive
            // 
            this.columnAdminDetectorActive.Text = "Active";
            this.columnAdminDetectorActive.Width = 80;
            // 
            // columnAdminDetectorConnected
            // 
            this.columnAdminDetectorConnected.Text = "Connected";
            this.columnAdminDetectorConnected.Width = 87;
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "detector16.png");
            this.imageListSmall.Images.SetKeyName(1, "drawer16.png");
            this.imageListSmall.Images.SetKeyName(2, "beaker16.png");
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(455, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(524, 422);
            this.panel7.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel58);
            this.panel9.Controls.Add(this.panel59);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(524, 422);
            this.panel9.TabIndex = 1;
            // 
            // panel58
            // 
            this.panel58.BackColor = System.Drawing.SystemColors.Control;
            this.panel58.Controls.Add(this.panel15);
            this.panel58.Controls.Add(this.cboxAdminDetPefTef);
            this.panel58.Controls.Add(this.panel65);
            this.panel58.Controls.Add(this.cboxAdminDetBkgFiles);
            this.panel58.Controls.Add(this.panel61);
            this.panel58.Controls.Add(this.txtAdminDetETOL);
            this.panel58.Controls.Add(this.cbAdminICA);
            this.panel58.Controls.Add(this.txtAdminDetFWHMAN);
            this.panel58.Controls.Add(this.panel63);
            this.panel58.Controls.Add(this.txtAdminDetComment);
            this.panel58.Controls.Add(this.cboxAdminDetRecords);
            this.panel58.Controls.Add(this.panel62);
            this.panel58.Controls.Add(this.panel14);
            this.panel58.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel58.Location = new System.Drawing.Point(269, 0);
            this.panel58.Name = "panel58";
            this.panel58.Size = new System.Drawing.Size(255, 422);
            this.panel58.TabIndex = 4;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.buttonAdminDetSave);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 397);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(255, 25);
            this.panel15.TabIndex = 13;
            // 
            // buttonAdminDetSave
            // 
            this.buttonAdminDetSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAdminDetSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminDetSave.Location = new System.Drawing.Point(155, 0);
            this.buttonAdminDetSave.Name = "buttonAdminDetSave";
            this.buttonAdminDetSave.Size = new System.Drawing.Size(100, 25);
            this.buttonAdminDetSave.TabIndex = 0;
            this.buttonAdminDetSave.Text = "Save";
            this.buttonAdminDetSave.UseVisualStyleBackColor = true;
            this.buttonAdminDetSave.Click += new System.EventHandler(this.buttonAdminSaveDetector_Click);
            // 
            // cboxAdminDetPefTef
            // 
            this.cboxAdminDetPefTef.Caption = "Pef / Tef";
            this.cboxAdminDetPefTef.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxAdminDetPefTef.Location = new System.Drawing.Point(0, 268);
            this.cboxAdminDetPefTef.Name = "cboxAdminDetPefTef";
            this.cboxAdminDetPefTef.Size = new System.Drawing.Size(255, 21);
            this.cboxAdminDetPefTef.TabIndex = 11;
            // 
            // panel65
            // 
            this.panel65.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel65.Location = new System.Drawing.Point(0, 243);
            this.panel65.Name = "panel65";
            this.panel65.Size = new System.Drawing.Size(255, 25);
            this.panel65.TabIndex = 10;
            // 
            // cboxAdminDetBkgFiles
            // 
            this.cboxAdminDetBkgFiles.Caption = "BKGFILE";
            this.cboxAdminDetBkgFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxAdminDetBkgFiles.Location = new System.Drawing.Point(0, 222);
            this.cboxAdminDetBkgFiles.Name = "cboxAdminDetBkgFiles";
            this.cboxAdminDetBkgFiles.Size = new System.Drawing.Size(255, 21);
            this.cboxAdminDetBkgFiles.TabIndex = 9;
            // 
            // panel61
            // 
            this.panel61.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel61.Location = new System.Drawing.Point(0, 201);
            this.panel61.Name = "panel61";
            this.panel61.Size = new System.Drawing.Size(255, 21);
            this.panel61.TabIndex = 8;
            // 
            // txtAdminDetETOL
            // 
            this.txtAdminDetETOL.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdminDetETOL.Caption = "ETOL";
            this.txtAdminDetETOL.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdminDetETOL.Location = new System.Drawing.Point(0, 180);
            this.txtAdminDetETOL.MaxStringLength = 32767;
            this.txtAdminDetETOL.Name = "txtAdminDetETOL";
            this.txtAdminDetETOL.Size = new System.Drawing.Size(255, 21);
            this.txtAdminDetETOL.TabIndex = 7;
            this.txtAdminDetETOL.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtAdminDetETOL.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAdminDetETOL.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // cbAdminICA
            // 
            this.cbAdminICA.Caption = "ICA";
            this.cbAdminICA.Checked = true;
            this.cbAdminICA.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAdminICA.Location = new System.Drawing.Point(0, 159);
            this.cbAdminICA.Name = "cbAdminICA";
            this.cbAdminICA.Size = new System.Drawing.Size(255, 21);
            this.cbAdminICA.TabIndex = 14;
            // 
            // txtAdminDetFWHMAN
            // 
            this.txtAdminDetFWHMAN.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdminDetFWHMAN.Caption = "FWHMAN";
            this.txtAdminDetFWHMAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdminDetFWHMAN.Location = new System.Drawing.Point(0, 138);
            this.txtAdminDetFWHMAN.MaxStringLength = 32767;
            this.txtAdminDetFWHMAN.Name = "txtAdminDetFWHMAN";
            this.txtAdminDetFWHMAN.Size = new System.Drawing.Size(255, 21);
            this.txtAdminDetFWHMAN.TabIndex = 5;
            this.txtAdminDetFWHMAN.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtAdminDetFWHMAN.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAdminDetFWHMAN.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // panel63
            // 
            this.panel63.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel63.Location = new System.Drawing.Point(0, 92);
            this.panel63.Name = "panel63";
            this.panel63.Size = new System.Drawing.Size(255, 46);
            this.panel63.TabIndex = 2;
            // 
            // txtAdminDetComment
            // 
            this.txtAdminDetComment.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdminDetComment.Caption = "Comment";
            this.txtAdminDetComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdminDetComment.Location = new System.Drawing.Point(0, 71);
            this.txtAdminDetComment.MaxStringLength = 32767;
            this.txtAdminDetComment.Name = "txtAdminDetComment";
            this.txtAdminDetComment.Size = new System.Drawing.Size(255, 21);
            this.txtAdminDetComment.TabIndex = 3;
            this.txtAdminDetComment.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // cboxAdminDetRecords
            // 
            this.cboxAdminDetRecords.Caption = "Record length";
            this.cboxAdminDetRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxAdminDetRecords.Location = new System.Drawing.Point(0, 50);
            this.cboxAdminDetRecords.Name = "cboxAdminDetRecords";
            this.cboxAdminDetRecords.Size = new System.Drawing.Size(255, 21);
            this.cboxAdminDetRecords.TabIndex = 4;
            // 
            // panel62
            // 
            this.panel62.Controls.Add(this.cbAdminDetActive);
            this.panel62.Controls.Add(this.cbAdminDetConnected);
            this.panel62.Controls.Add(this.cbAdminDetDummy);
            this.panel62.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel62.Location = new System.Drawing.Point(0, 25);
            this.panel62.Name = "panel62";
            this.panel62.Size = new System.Drawing.Size(255, 25);
            this.panel62.TabIndex = 1;
            // 
            // cbAdminDetActive
            // 
            this.cbAdminDetActive.AutoSize = true;
            this.cbAdminDetActive.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbAdminDetActive.Location = new System.Drawing.Point(40, 0);
            this.cbAdminDetActive.Name = "cbAdminDetActive";
            this.cbAdminDetActive.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cbAdminDetActive.Size = new System.Drawing.Size(73, 25);
            this.cbAdminDetActive.TabIndex = 0;
            this.cbAdminDetActive.Text = "Active    ";
            this.cbAdminDetActive.UseVisualStyleBackColor = true;
            // 
            // cbAdminDetConnected
            // 
            this.cbAdminDetConnected.AutoSize = true;
            this.cbAdminDetConnected.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbAdminDetConnected.Enabled = false;
            this.cbAdminDetConnected.Location = new System.Drawing.Point(113, 0);
            this.cbAdminDetConnected.Name = "cbAdminDetConnected";
            this.cbAdminDetConnected.Size = new System.Drawing.Size(81, 25);
            this.cbAdminDetConnected.TabIndex = 2;
            this.cbAdminDetConnected.Text = "Connected ";
            this.cbAdminDetConnected.UseVisualStyleBackColor = true;
            // 
            // cbAdminDetDummy
            // 
            this.cbAdminDetDummy.AutoSize = true;
            this.cbAdminDetDummy.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbAdminDetDummy.Enabled = false;
            this.cbAdminDetDummy.Location = new System.Drawing.Point(194, 0);
            this.cbAdminDetDummy.Margin = new System.Windows.Forms.Padding(0);
            this.cbAdminDetDummy.Name = "cbAdminDetDummy";
            this.cbAdminDetDummy.Size = new System.Drawing.Size(61, 25);
            this.cbAdminDetDummy.TabIndex = 1;
            this.cbAdminDetDummy.Text = "Dummy";
            this.cbAdminDetDummy.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.labelAdminDetDetector);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(255, 25);
            this.panel14.TabIndex = 12;
            // 
            // labelAdminDetDetector
            // 
            this.labelAdminDetDetector.AutoSize = true;
            this.labelAdminDetDetector.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelAdminDetDetector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminDetDetector.Location = new System.Drawing.Point(176, 0);
            this.labelAdminDetDetector.Name = "labelAdminDetDetector";
            this.labelAdminDetDetector.Size = new System.Drawing.Size(79, 20);
            this.labelAdminDetDetector.TabIndex = 1;
            this.labelAdminDetDetector.Text = "Detector";
            // 
            // panel59
            // 
            this.panel59.BackColor = System.Drawing.SystemColors.Control;
            this.panel59.Controls.Add(this.cboxAdminDetBeakers);
            this.panel59.Controls.Add(this.panel64);
            this.panel59.Controls.Add(this.cboxAdminDetEngFiles);
            this.panel59.Controls.Add(this.txtAdminDetLOCH);
            this.panel59.Controls.Add(this.txtAdminDetBSTF);
            this.panel59.Controls.Add(this.txtAdminDetTHRESH);
            this.panel59.Controls.Add(this.txtAdminDetFWHMPS);
            this.panel59.Controls.Add(this.panel60);
            this.panel59.Controls.Add(this.cboxAdminDetSpecFmt);
            this.panel59.Controls.Add(this.cboxAdminDetChannels);
            this.panel59.Controls.Add(this.txtAdminDetID);
            this.panel59.Controls.Add(this.panel68);
            this.panel59.Controls.Add(this.panel13);
            this.panel59.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel59.Location = new System.Drawing.Point(0, 0);
            this.panel59.Name = "panel59";
            this.panel59.Size = new System.Drawing.Size(269, 422);
            this.panel59.TabIndex = 3;
            // 
            // cboxAdminDetBeakers
            // 
            this.cboxAdminDetBeakers.Caption = "Beaker";
            this.cboxAdminDetBeakers.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxAdminDetBeakers.Location = new System.Drawing.Point(0, 268);
            this.cboxAdminDetBeakers.Name = "cboxAdminDetBeakers";
            this.cboxAdminDetBeakers.Size = new System.Drawing.Size(269, 21);
            this.cboxAdminDetBeakers.TabIndex = 12;
            this.cboxAdminDetBeakers.SelectedValueChanged += new System.EventHandler(this.cboxAdminDetBeakers_SelectedValueChanged);
            // 
            // panel64
            // 
            this.panel64.Controls.Add(this.label12);
            this.panel64.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel64.Location = new System.Drawing.Point(0, 243);
            this.panel64.Name = "panel64";
            this.panel64.Size = new System.Drawing.Size(269, 25);
            this.panel64.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label12.Size = new System.Drawing.Size(228, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Default detector beaker efficiency files";
            // 
            // cboxAdminDetEngFiles
            // 
            this.cboxAdminDetEngFiles.Caption = "ENFILE";
            this.cboxAdminDetEngFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxAdminDetEngFiles.Location = new System.Drawing.Point(0, 222);
            this.cboxAdminDetEngFiles.Name = "cboxAdminDetEngFiles";
            this.cboxAdminDetEngFiles.Size = new System.Drawing.Size(269, 21);
            this.cboxAdminDetEngFiles.TabIndex = 10;
            // 
            // txtAdminDetLOCH
            // 
            this.txtAdminDetLOCH.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdminDetLOCH.Caption = "LOCH";
            this.txtAdminDetLOCH.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdminDetLOCH.Location = new System.Drawing.Point(0, 201);
            this.txtAdminDetLOCH.MaxStringLength = 32767;
            this.txtAdminDetLOCH.Name = "txtAdminDetLOCH";
            this.txtAdminDetLOCH.Size = new System.Drawing.Size(269, 21);
            this.txtAdminDetLOCH.TabIndex = 9;
            this.txtAdminDetLOCH.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtAdminDetLOCH.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAdminDetLOCH.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtAdminDetBSTF
            // 
            this.txtAdminDetBSTF.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdminDetBSTF.Caption = "BSTF";
            this.txtAdminDetBSTF.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdminDetBSTF.Location = new System.Drawing.Point(0, 180);
            this.txtAdminDetBSTF.MaxStringLength = 32767;
            this.txtAdminDetBSTF.Name = "txtAdminDetBSTF";
            this.txtAdminDetBSTF.Size = new System.Drawing.Size(269, 21);
            this.txtAdminDetBSTF.TabIndex = 8;
            this.txtAdminDetBSTF.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtAdminDetBSTF.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAdminDetBSTF.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtAdminDetTHRESH
            // 
            this.txtAdminDetTHRESH.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdminDetTHRESH.Caption = "THRESH";
            this.txtAdminDetTHRESH.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdminDetTHRESH.Location = new System.Drawing.Point(0, 159);
            this.txtAdminDetTHRESH.MaxStringLength = 32767;
            this.txtAdminDetTHRESH.Name = "txtAdminDetTHRESH";
            this.txtAdminDetTHRESH.Size = new System.Drawing.Size(269, 21);
            this.txtAdminDetTHRESH.TabIndex = 7;
            this.txtAdminDetTHRESH.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtAdminDetTHRESH.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAdminDetTHRESH.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtAdminDetFWHMPS
            // 
            this.txtAdminDetFWHMPS.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdminDetFWHMPS.Caption = "FWHMPS";
            this.txtAdminDetFWHMPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdminDetFWHMPS.Location = new System.Drawing.Point(0, 138);
            this.txtAdminDetFWHMPS.MaxStringLength = 32767;
            this.txtAdminDetFWHMPS.Name = "txtAdminDetFWHMPS";
            this.txtAdminDetFWHMPS.Size = new System.Drawing.Size(269, 21);
            this.txtAdminDetFWHMPS.TabIndex = 6;
            this.txtAdminDetFWHMPS.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtAdminDetFWHMPS.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAdminDetFWHMPS.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // panel60
            // 
            this.panel60.Controls.Add(this.label11);
            this.panel60.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel60.Location = new System.Drawing.Point(0, 113);
            this.panel60.Name = "panel60";
            this.panel60.Size = new System.Drawing.Size(269, 25);
            this.panel60.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label11.Size = new System.Drawing.Size(119, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Analysis parameters";
            // 
            // cboxAdminDetSpecFmt
            // 
            this.cboxAdminDetSpecFmt.Caption = "Format";
            this.cboxAdminDetSpecFmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxAdminDetSpecFmt.Location = new System.Drawing.Point(0, 92);
            this.cboxAdminDetSpecFmt.Name = "cboxAdminDetSpecFmt";
            this.cboxAdminDetSpecFmt.Size = new System.Drawing.Size(269, 21);
            this.cboxAdminDetSpecFmt.TabIndex = 2;
            // 
            // cboxAdminDetChannels
            // 
            this.cboxAdminDetChannels.Caption = "Channel count";
            this.cboxAdminDetChannels.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxAdminDetChannels.Location = new System.Drawing.Point(0, 71);
            this.cboxAdminDetChannels.Name = "cboxAdminDetChannels";
            this.cboxAdminDetChannels.Size = new System.Drawing.Size(269, 21);
            this.cboxAdminDetChannels.TabIndex = 1;
            // 
            // txtAdminDetID
            // 
            this.txtAdminDetID.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdminDetID.Caption = "Maestro ID";
            this.txtAdminDetID.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdminDetID.Enabled = false;
            this.txtAdminDetID.Location = new System.Drawing.Point(0, 50);
            this.txtAdminDetID.MaxStringLength = 32767;
            this.txtAdminDetID.Name = "txtAdminDetID";
            this.txtAdminDetID.Size = new System.Drawing.Size(269, 21);
            this.txtAdminDetID.TabIndex = 14;
            this.txtAdminDetID.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // panel68
            // 
            this.panel68.Controls.Add(this.labelAdminDetTitle);
            this.panel68.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel68.Location = new System.Drawing.Point(0, 25);
            this.panel68.Name = "panel68";
            this.panel68.Size = new System.Drawing.Size(269, 25);
            this.panel68.TabIndex = 0;
            // 
            // labelAdminDetTitle
            // 
            this.labelAdminDetTitle.AutoSize = true;
            this.labelAdminDetTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelAdminDetTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminDetTitle.Location = new System.Drawing.Point(0, 0);
            this.labelAdminDetTitle.Name = "labelAdminDetTitle";
            this.labelAdminDetTitle.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelAdminDetTitle.Size = new System.Drawing.Size(122, 16);
            this.labelAdminDetTitle.TabIndex = 0;
            this.labelAdminDetTitle.Text = "Detector parameters";
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(269, 25);
            this.panel13.TabIndex = 15;
            // 
            // pageAdminBeaker
            // 
            this.pageAdminBeaker.Controls.Add(this.panelAdmBeakerConf);
            this.pageAdminBeaker.Controls.Add(this.panelAdmBeakerConfParam);
            this.pageAdminBeaker.Location = new System.Drawing.Point(4, 22);
            this.pageAdminBeaker.Name = "pageAdminBeaker";
            this.pageAdminBeaker.Padding = new System.Windows.Forms.Padding(3);
            this.pageAdminBeaker.Size = new System.Drawing.Size(178, 16);
            this.pageAdminBeaker.TabIndex = 2;
            this.pageAdminBeaker.Text = "Beaker configuration";
            this.pageAdminBeaker.UseVisualStyleBackColor = true;
            // 
            // panelAdmBeakerConf
            // 
            this.panelAdmBeakerConf.Controls.Add(this.lvAdmBeakers);
            this.panelAdmBeakerConf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdmBeakerConf.Location = new System.Drawing.Point(3, 3);
            this.panelAdmBeakerConf.Name = "panelAdmBeakerConf";
            this.panelAdmBeakerConf.Size = new System.Drawing.Size(677, 422);
            this.panelAdmBeakerConf.TabIndex = 0;
            // 
            // lvAdmBeakers
            // 
            this.lvAdmBeakers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerName,
            this.headerType,
            this.headerRadius,
            this.headerHeight,
            this.headerInnerRadius,
            this.headerInnerHeight,
            this.headerMin,
            this.headerMax});
            this.lvAdmBeakers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAdmBeakers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAdmBeakers.FullRowSelect = true;
            this.lvAdmBeakers.Location = new System.Drawing.Point(0, 0);
            this.lvAdmBeakers.Name = "lvAdmBeakers";
            this.lvAdmBeakers.Size = new System.Drawing.Size(677, 422);
            this.lvAdmBeakers.SmallImageList = this.imageListSmall;
            this.lvAdmBeakers.TabIndex = 0;
            this.lvAdmBeakers.UseCompatibleStateImageBehavior = false;
            this.lvAdmBeakers.View = System.Windows.Forms.View.Details;
            this.lvAdmBeakers.SelectedIndexChanged += new System.EventHandler(this.lvAdmBeakers_SelectedIndexChanged);
            this.lvAdmBeakers.Resize += new System.EventHandler(this.lvAdmBeakers_Resize);
            // 
            // headerName
            // 
            this.headerName.Text = "Name";
            // 
            // headerType
            // 
            this.headerType.Text = "Type";
            // 
            // headerRadius
            // 
            this.headerRadius.Text = "Radius";
            this.headerRadius.Width = 63;
            // 
            // headerHeight
            // 
            this.headerHeight.Text = "Height";
            this.headerHeight.Width = 65;
            // 
            // headerInnerRadius
            // 
            this.headerInnerRadius.Text = "Inner radius";
            this.headerInnerRadius.Width = 87;
            // 
            // headerInnerHeight
            // 
            this.headerInnerHeight.Text = "Inner height";
            this.headerInnerHeight.Width = 93;
            // 
            // headerMin
            // 
            this.headerMin.Text = "Min fill height";
            this.headerMin.Width = 110;
            // 
            // headerMax
            // 
            this.headerMax.Text = "Max fill height";
            this.headerMax.Width = 119;
            // 
            // panelAdmBeakerConfParam
            // 
            this.panelAdmBeakerConfParam.BackColor = System.Drawing.SystemColors.Control;
            this.panelAdmBeakerConfParam.Controls.Add(this.panel18);
            this.panelAdmBeakerConfParam.Controls.Add(this.txtAdminBeakerComment);
            this.panelAdmBeakerConfParam.Controls.Add(this.txtAdminBeakerManufacturer);
            this.panelAdmBeakerConfParam.Controls.Add(this.txtAdminBeakerMaxFillHeight);
            this.panelAdmBeakerConfParam.Controls.Add(this.txtAdminBeakerMinFillHeight);
            this.panelAdmBeakerConfParam.Controls.Add(this.txtAdminBeakerInnerHeight);
            this.panelAdmBeakerConfParam.Controls.Add(this.txtAdminBeakerInnerRadius);
            this.panelAdmBeakerConfParam.Controls.Add(this.cbAdminBeakerMarinelli);
            this.panelAdmBeakerConfParam.Controls.Add(this.txtAdminBeakerHeight);
            this.panelAdmBeakerConfParam.Controls.Add(this.txtAdminBeakerRadius);
            this.panelAdmBeakerConfParam.Controls.Add(this.txtAdminBeakerName);
            this.panelAdmBeakerConfParam.Controls.Add(this.panel69);
            this.panelAdmBeakerConfParam.Controls.Add(this.panel16);
            this.panelAdmBeakerConfParam.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAdmBeakerConfParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAdmBeakerConfParam.Location = new System.Drawing.Point(680, 3);
            this.panelAdmBeakerConfParam.Name = "panelAdmBeakerConfParam";
            this.panelAdmBeakerConfParam.Size = new System.Drawing.Size(299, 422);
            this.panelAdmBeakerConfParam.TabIndex = 1;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.buttonAdminBeaSave);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel18.Location = new System.Drawing.Point(0, 397);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(299, 25);
            this.panel18.TabIndex = 9;
            // 
            // buttonAdminBeaSave
            // 
            this.buttonAdminBeaSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAdminBeaSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminBeaSave.Location = new System.Drawing.Point(199, 0);
            this.buttonAdminBeaSave.Name = "buttonAdminBeaSave";
            this.buttonAdminBeaSave.Size = new System.Drawing.Size(100, 25);
            this.buttonAdminBeaSave.TabIndex = 0;
            this.buttonAdminBeaSave.Text = "Save";
            this.buttonAdminBeaSave.UseVisualStyleBackColor = true;
            this.buttonAdminBeaSave.Click += new System.EventHandler(this.buttonAdminSaveBeaker_Click);
            // 
            // txtAdminBeakerComment
            // 
            this.txtAdminBeakerComment.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdminBeakerComment.Caption = "Comment";
            this.txtAdminBeakerComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdminBeakerComment.Location = new System.Drawing.Point(0, 233);
            this.txtAdminBeakerComment.MaxStringLength = 32767;
            this.txtAdminBeakerComment.Name = "txtAdminBeakerComment";
            this.txtAdminBeakerComment.Size = new System.Drawing.Size(299, 21);
            this.txtAdminBeakerComment.TabIndex = 9;
            this.txtAdminBeakerComment.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // txtAdminBeakerManufacturer
            // 
            this.txtAdminBeakerManufacturer.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdminBeakerManufacturer.Caption = "Manufacturer";
            this.txtAdminBeakerManufacturer.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdminBeakerManufacturer.Location = new System.Drawing.Point(0, 212);
            this.txtAdminBeakerManufacturer.MaxStringLength = 32767;
            this.txtAdminBeakerManufacturer.Name = "txtAdminBeakerManufacturer";
            this.txtAdminBeakerManufacturer.Size = new System.Drawing.Size(299, 21);
            this.txtAdminBeakerManufacturer.TabIndex = 8;
            this.txtAdminBeakerManufacturer.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // txtAdminBeakerMaxFillHeight
            // 
            this.txtAdminBeakerMaxFillHeight.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdminBeakerMaxFillHeight.Caption = "Max fill height(mm)";
            this.txtAdminBeakerMaxFillHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdminBeakerMaxFillHeight.Location = new System.Drawing.Point(0, 191);
            this.txtAdminBeakerMaxFillHeight.MaxStringLength = 32767;
            this.txtAdminBeakerMaxFillHeight.Name = "txtAdminBeakerMaxFillHeight";
            this.txtAdminBeakerMaxFillHeight.Size = new System.Drawing.Size(299, 21);
            this.txtAdminBeakerMaxFillHeight.TabIndex = 7;
            this.txtAdminBeakerMaxFillHeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtAdminBeakerMaxFillHeight.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAdminBeakerMaxFillHeight.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtAdminBeakerMinFillHeight
            // 
            this.txtAdminBeakerMinFillHeight.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdminBeakerMinFillHeight.Caption = "Min fill height(mm)";
            this.txtAdminBeakerMinFillHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdminBeakerMinFillHeight.Location = new System.Drawing.Point(0, 170);
            this.txtAdminBeakerMinFillHeight.MaxStringLength = 32767;
            this.txtAdminBeakerMinFillHeight.Name = "txtAdminBeakerMinFillHeight";
            this.txtAdminBeakerMinFillHeight.Size = new System.Drawing.Size(299, 21);
            this.txtAdminBeakerMinFillHeight.TabIndex = 6;
            this.txtAdminBeakerMinFillHeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtAdminBeakerMinFillHeight.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAdminBeakerMinFillHeight.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtAdminBeakerInnerHeight
            // 
            this.txtAdminBeakerInnerHeight.Caption = "Inner height (mm)";
            this.txtAdminBeakerInnerHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdminBeakerInnerHeight.Enabled = false;
            this.txtAdminBeakerInnerHeight.Location = new System.Drawing.Point(0, 149);
            this.txtAdminBeakerInnerHeight.MaxStringLength = 32767;
            this.txtAdminBeakerInnerHeight.Name = "txtAdminBeakerInnerHeight";
            this.txtAdminBeakerInnerHeight.Size = new System.Drawing.Size(299, 21);
            this.txtAdminBeakerInnerHeight.TabIndex = 5;
            this.txtAdminBeakerInnerHeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtAdminBeakerInnerHeight.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAdminBeakerInnerHeight.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtAdminBeakerInnerRadius
            // 
            this.txtAdminBeakerInnerRadius.Caption = "Inner radius (mm)";
            this.txtAdminBeakerInnerRadius.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdminBeakerInnerRadius.Enabled = false;
            this.txtAdminBeakerInnerRadius.Location = new System.Drawing.Point(0, 128);
            this.txtAdminBeakerInnerRadius.MaxStringLength = 32767;
            this.txtAdminBeakerInnerRadius.Name = "txtAdminBeakerInnerRadius";
            this.txtAdminBeakerInnerRadius.Size = new System.Drawing.Size(299, 21);
            this.txtAdminBeakerInnerRadius.TabIndex = 4;
            this.txtAdminBeakerInnerRadius.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtAdminBeakerInnerRadius.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAdminBeakerInnerRadius.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // cbAdminBeakerMarinelli
            // 
            this.cbAdminBeakerMarinelli.AutoSize = true;
            this.cbAdminBeakerMarinelli.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAdminBeakerMarinelli.Location = new System.Drawing.Point(0, 111);
            this.cbAdminBeakerMarinelli.Name = "cbAdminBeakerMarinelli";
            this.cbAdminBeakerMarinelli.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.cbAdminBeakerMarinelli.Size = new System.Drawing.Size(299, 17);
            this.cbAdminBeakerMarinelli.TabIndex = 3;
            this.cbAdminBeakerMarinelli.Text = "Marinelli beaker";
            this.cbAdminBeakerMarinelli.UseVisualStyleBackColor = true;
            this.cbAdminBeakerMarinelli.CheckedChanged += new System.EventHandler(this.cbAdminBeakerMarinelli_CheckedChanged);
            // 
            // txtAdminBeakerHeight
            // 
            this.txtAdminBeakerHeight.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdminBeakerHeight.Caption = "Height (mm)";
            this.txtAdminBeakerHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdminBeakerHeight.Location = new System.Drawing.Point(0, 90);
            this.txtAdminBeakerHeight.MaxStringLength = 32767;
            this.txtAdminBeakerHeight.Name = "txtAdminBeakerHeight";
            this.txtAdminBeakerHeight.Size = new System.Drawing.Size(299, 21);
            this.txtAdminBeakerHeight.TabIndex = 2;
            this.txtAdminBeakerHeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtAdminBeakerHeight.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAdminBeakerHeight.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtAdminBeakerRadius
            // 
            this.txtAdminBeakerRadius.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdminBeakerRadius.Caption = "Radius (mm)";
            this.txtAdminBeakerRadius.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdminBeakerRadius.Location = new System.Drawing.Point(0, 69);
            this.txtAdminBeakerRadius.MaxStringLength = 32767;
            this.txtAdminBeakerRadius.Name = "txtAdminBeakerRadius";
            this.txtAdminBeakerRadius.Size = new System.Drawing.Size(299, 21);
            this.txtAdminBeakerRadius.TabIndex = 1;
            this.txtAdminBeakerRadius.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtAdminBeakerRadius.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtAdminBeakerRadius.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtAdminBeakerName
            // 
            this.txtAdminBeakerName.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdminBeakerName.Caption = "Name";
            this.txtAdminBeakerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdminBeakerName.Enabled = false;
            this.txtAdminBeakerName.Location = new System.Drawing.Point(0, 48);
            this.txtAdminBeakerName.MaxStringLength = 32767;
            this.txtAdminBeakerName.Name = "txtAdminBeakerName";
            this.txtAdminBeakerName.Size = new System.Drawing.Size(299, 21);
            this.txtAdminBeakerName.TabIndex = 0;
            this.txtAdminBeakerName.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // panel69
            // 
            this.panel69.Controls.Add(this.cbAdminBeakerInUse);
            this.panel69.Controls.Add(this.label13);
            this.panel69.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel69.Location = new System.Drawing.Point(0, 25);
            this.panel69.Name = "panel69";
            this.panel69.Size = new System.Drawing.Size(299, 23);
            this.panel69.TabIndex = 0;
            // 
            // cbAdminBeakerInUse
            // 
            this.cbAdminBeakerInUse.AutoSize = true;
            this.cbAdminBeakerInUse.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbAdminBeakerInUse.Location = new System.Drawing.Point(226, 0);
            this.cbAdminBeakerInUse.Name = "cbAdminBeakerInUse";
            this.cbAdminBeakerInUse.Size = new System.Drawing.Size(73, 23);
            this.cbAdminBeakerInUse.TabIndex = 1;
            this.cbAdminBeakerInUse.Text = "In use      ";
            this.cbAdminBeakerInUse.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label13.Size = new System.Drawing.Size(113, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Beaker parameters";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.labelAdminBeaBeaker);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(299, 25);
            this.panel16.TabIndex = 8;
            // 
            // labelAdminBeaBeaker
            // 
            this.labelAdminBeaBeaker.AutoSize = true;
            this.labelAdminBeaBeaker.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelAdminBeaBeaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminBeaBeaker.Location = new System.Drawing.Point(233, 0);
            this.labelAdminBeaBeaker.Name = "labelAdminBeaBeaker";
            this.labelAdminBeaBeaker.Size = new System.Drawing.Size(66, 20);
            this.labelAdminBeaBeaker.TabIndex = 0;
            this.labelAdminBeaBeaker.Text = "Beaker";
            // 
            // pageAdminMaestro
            // 
            this.pageAdminMaestro.BackColor = System.Drawing.SystemColors.Control;
            this.pageAdminMaestro.Controls.Add(this.panelAdminMaestro);
            this.pageAdminMaestro.Controls.Add(this.panel3);
            this.pageAdminMaestro.Location = new System.Drawing.Point(4, 22);
            this.pageAdminMaestro.Name = "pageAdminMaestro";
            this.pageAdminMaestro.Padding = new System.Windows.Forms.Padding(3);
            this.pageAdminMaestro.Size = new System.Drawing.Size(178, 16);
            this.pageAdminMaestro.TabIndex = 3;
            this.pageAdminMaestro.Text = "Maestro";
            // 
            // panelAdminMaestro
            // 
            this.panelAdminMaestro.Controls.Add(this.tabControlAdminScripts);
            this.panelAdminMaestro.Controls.Add(this.panelAdminScriptsLeft);
            this.panelAdminMaestro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdminMaestro.Location = new System.Drawing.Point(3, 86);
            this.panelAdminMaestro.Name = "panelAdminMaestro";
            this.panelAdminMaestro.Size = new System.Drawing.Size(976, 339);
            this.panelAdminMaestro.TabIndex = 3;
            // 
            // tabControlAdminScripts
            // 
            this.tabControlAdminScripts.Controls.Add(this.pageAdminScriptsBuffer);
            this.tabControlAdminScripts.Controls.Add(this.pageAdminScriptsStart);
            this.tabControlAdminScripts.Controls.Add(this.pageAdminScriptsStop);
            this.tabControlAdminScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdminScripts.Location = new System.Drawing.Point(200, 0);
            this.tabControlAdminScripts.Name = "tabControlAdminScripts";
            this.tabControlAdminScripts.SelectedIndex = 0;
            this.tabControlAdminScripts.Size = new System.Drawing.Size(776, 339);
            this.tabControlAdminScripts.TabIndex = 3;
            // 
            // pageAdminScriptsBuffer
            // 
            this.pageAdminScriptsBuffer.Controls.Add(this.txtAdminScriptsBuffer);
            this.pageAdminScriptsBuffer.Location = new System.Drawing.Point(4, 22);
            this.pageAdminScriptsBuffer.Name = "pageAdminScriptsBuffer";
            this.pageAdminScriptsBuffer.Padding = new System.Windows.Forms.Padding(3);
            this.pageAdminScriptsBuffer.Size = new System.Drawing.Size(768, 313);
            this.pageAdminScriptsBuffer.TabIndex = 2;
            this.pageAdminScriptsBuffer.Text = "Peek";
            this.pageAdminScriptsBuffer.UseVisualStyleBackColor = true;
            // 
            // txtAdminScriptsBuffer
            // 
            this.txtAdminScriptsBuffer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdminScriptsBuffer.Location = new System.Drawing.Point(3, 3);
            this.txtAdminScriptsBuffer.Multiline = true;
            this.txtAdminScriptsBuffer.Name = "txtAdminScriptsBuffer";
            this.txtAdminScriptsBuffer.Size = new System.Drawing.Size(762, 307);
            this.txtAdminScriptsBuffer.TabIndex = 0;
            // 
            // pageAdminScriptsStart
            // 
            this.pageAdminScriptsStart.Controls.Add(this.txtAdminScriptsStart);
            this.pageAdminScriptsStart.Location = new System.Drawing.Point(4, 22);
            this.pageAdminScriptsStart.Name = "pageAdminScriptsStart";
            this.pageAdminScriptsStart.Padding = new System.Windows.Forms.Padding(3);
            this.pageAdminScriptsStart.Size = new System.Drawing.Size(768, 313);
            this.pageAdminScriptsStart.TabIndex = 0;
            this.pageAdminScriptsStart.Text = "Start";
            this.pageAdminScriptsStart.UseVisualStyleBackColor = true;
            // 
            // txtAdminScriptsStart
            // 
            this.txtAdminScriptsStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdminScriptsStart.Location = new System.Drawing.Point(3, 3);
            this.txtAdminScriptsStart.Multiline = true;
            this.txtAdminScriptsStart.Name = "txtAdminScriptsStart";
            this.txtAdminScriptsStart.Size = new System.Drawing.Size(0, 0);
            this.txtAdminScriptsStart.TabIndex = 0;
            // 
            // pageAdminScriptsStop
            // 
            this.pageAdminScriptsStop.Controls.Add(this.txtAdminScriptsStop);
            this.pageAdminScriptsStop.Location = new System.Drawing.Point(4, 22);
            this.pageAdminScriptsStop.Name = "pageAdminScriptsStop";
            this.pageAdminScriptsStop.Padding = new System.Windows.Forms.Padding(3);
            this.pageAdminScriptsStop.Size = new System.Drawing.Size(768, 313);
            this.pageAdminScriptsStop.TabIndex = 1;
            this.pageAdminScriptsStop.Text = "Stop";
            this.pageAdminScriptsStop.UseVisualStyleBackColor = true;
            // 
            // txtAdminScriptsStop
            // 
            this.txtAdminScriptsStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdminScriptsStop.Location = new System.Drawing.Point(3, 3);
            this.txtAdminScriptsStop.Multiline = true;
            this.txtAdminScriptsStop.Name = "txtAdminScriptsStop";
            this.txtAdminScriptsStop.Size = new System.Drawing.Size(0, 0);
            this.txtAdminScriptsStop.TabIndex = 0;
            // 
            // panelAdminScriptsLeft
            // 
            this.panelAdminScriptsLeft.Controls.Add(this.textBox1);
            this.panelAdminScriptsLeft.Controls.Add(this.buttonAdminScriptsSave);
            this.panelAdminScriptsLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdminScriptsLeft.Location = new System.Drawing.Point(0, 0);
            this.panelAdminScriptsLeft.Name = "panelAdminScriptsLeft";
            this.panelAdminScriptsLeft.Size = new System.Drawing.Size(200, 339);
            this.panelAdminScriptsLeft.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 313);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Macros:\r\n\r\n@DID - Detector ID\r\n\r\n@SAVE_FILE - Filename used for saving spectrums\r" +
    "\n\r\n@BUFFER_FILE - Filename used for saving spectrum buffers\r\n";
            // 
            // buttonAdminScriptsSave
            // 
            this.buttonAdminScriptsSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAdminScriptsSave.Location = new System.Drawing.Point(0, 313);
            this.buttonAdminScriptsSave.Name = "buttonAdminScriptsSave";
            this.buttonAdminScriptsSave.Size = new System.Drawing.Size(200, 26);
            this.buttonAdminScriptsSave.TabIndex = 7;
            this.buttonAdminScriptsSave.Text = "Save scripts";
            this.buttonAdminScriptsSave.UseVisualStyleBackColor = true;
            this.buttonAdminScriptsSave.Click += new System.EventHandler(this.buttonAdminScriptsSave_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelAdminMaestroConfig);
            this.panel3.Controls.Add(this.labelAdminMaestroExecutable);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.buttonAdminMaestroSetup);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(976, 83);
            this.panel3.TabIndex = 5;
            // 
            // labelAdminMaestroConfig
            // 
            this.labelAdminMaestroConfig.AutoSize = true;
            this.labelAdminMaestroConfig.Location = new System.Drawing.Point(455, 35);
            this.labelAdminMaestroConfig.Name = "labelAdminMaestroConfig";
            this.labelAdminMaestroConfig.Size = new System.Drawing.Size(75, 13);
            this.labelAdminMaestroConfig.TabIndex = 5;
            this.labelAdminMaestroConfig.Text = "MaestroConfig";
            // 
            // labelAdminMaestroExecutable
            // 
            this.labelAdminMaestroExecutable.AutoSize = true;
            this.labelAdminMaestroExecutable.Location = new System.Drawing.Point(455, 10);
            this.labelAdminMaestroExecutable.Name = "labelAdminMaestroExecutable";
            this.labelAdminMaestroExecutable.Size = new System.Drawing.Size(98, 13);
            this.labelAdminMaestroExecutable.TabIndex = 4;
            this.labelAdminMaestroExecutable.Text = "MaestroExecutable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Remember to run MCB configuration before running Maestro setup.";
            // 
            // buttonAdminMaestroSetup
            // 
            this.buttonAdminMaestroSetup.Location = new System.Drawing.Point(10, 40);
            this.buttonAdminMaestroSetup.Name = "buttonAdminMaestroSetup";
            this.buttonAdminMaestroSetup.Size = new System.Drawing.Size(190, 24);
            this.buttonAdminMaestroSetup.TabIndex = 2;
            this.buttonAdminMaestroSetup.Text = "Maestro Setup";
            this.buttonAdminMaestroSetup.UseVisualStyleBackColor = true;
            this.buttonAdminMaestroSetup.Click += new System.EventHandler(this.buttonAdminMaestroSetup_Click);
            // 
            // tabAdminGenie
            // 
            this.tabAdminGenie.BackColor = System.Drawing.SystemColors.Control;
            this.tabAdminGenie.Controls.Add(this.panel21);
            this.tabAdminGenie.Location = new System.Drawing.Point(4, 22);
            this.tabAdminGenie.Name = "tabAdminGenie";
            this.tabAdminGenie.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminGenie.Size = new System.Drawing.Size(178, 16);
            this.tabAdminGenie.TabIndex = 4;
            this.tabAdminGenie.Text = "Genie";
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.panel31);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(3, 3);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(976, 422);
            this.panel21.TabIndex = 2;
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.labelAdminGenieConfig);
            this.panel31.Controls.Add(this.labelAdminGenieFolder);
            this.panel31.Controls.Add(this.label2);
            this.panel31.Controls.Add(this.buttonAdminGenieSetup);
            this.panel31.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel31.Location = new System.Drawing.Point(0, 0);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(976, 80);
            this.panel31.TabIndex = 0;
            // 
            // labelAdminGenieConfig
            // 
            this.labelAdminGenieConfig.AutoSize = true;
            this.labelAdminGenieConfig.Location = new System.Drawing.Point(455, 35);
            this.labelAdminGenieConfig.Name = "labelAdminGenieConfig";
            this.labelAdminGenieConfig.Size = new System.Drawing.Size(65, 13);
            this.labelAdminGenieConfig.TabIndex = 6;
            this.labelAdminGenieConfig.Text = "GenieConfig";
            // 
            // labelAdminGenieFolder
            // 
            this.labelAdminGenieFolder.AutoSize = true;
            this.labelAdminGenieFolder.Location = new System.Drawing.Point(455, 10);
            this.labelAdminGenieFolder.Name = "labelAdminGenieFolder";
            this.labelAdminGenieFolder.Size = new System.Drawing.Size(64, 13);
            this.labelAdminGenieFolder.TabIndex = 5;
            this.labelAdminGenieFolder.Text = "GenieFolder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remember to run MCA Input Definition Editor before running Genie setup.";
            // 
            // buttonAdminGenieSetup
            // 
            this.buttonAdminGenieSetup.Location = new System.Drawing.Point(10, 40);
            this.buttonAdminGenieSetup.Name = "buttonAdminGenieSetup";
            this.buttonAdminGenieSetup.Size = new System.Drawing.Size(190, 24);
            this.buttonAdminGenieSetup.TabIndex = 0;
            this.buttonAdminGenieSetup.Text = "Genie Setup";
            this.buttonAdminGenieSetup.UseVisualStyleBackColor = true;
            this.buttonAdminGenieSetup.Click += new System.EventHandler(this.buttonAdminGenieSetup_Click);
            // 
            // toolsAdmin
            // 
            this.toolsAdmin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolsAdmin.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonAdminBack,
            this.labelAdminTitle,
            this.toolStripSeparator2,
            this.buttonAdminAddDummyDetector,
            this.buttonAdminAddBeaker});
            this.toolsAdmin.Location = new System.Drawing.Point(3, 3);
            this.toolsAdmin.Name = "toolsAdmin";
            this.toolsAdmin.Size = new System.Drawing.Size(990, 25);
            this.toolsAdmin.TabIndex = 1;
            this.toolsAdmin.Text = "toolStrip1";
            // 
            // buttonAdminBack
            // 
            this.buttonAdminBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdminBack.Image")));
            this.buttonAdminBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAdminBack.Name = "buttonAdminBack";
            this.buttonAdminBack.Size = new System.Drawing.Size(89, 22);
            this.buttonAdminBack.Text = "Main menu";
            this.buttonAdminBack.ToolTipText = "Back to main menu";
            this.buttonAdminBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelAdminTitle
            // 
            this.labelAdminTitle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelAdminTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelAdminTitle.Name = "labelAdminTitle";
            this.labelAdminTitle.Size = new System.Drawing.Size(91, 22);
            this.labelAdminTitle.Text = "Administration";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonAdminAddDummyDetector
            // 
            this.buttonAdminAddDummyDetector.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdminAddDummyDetector.Image")));
            this.buttonAdminAddDummyDetector.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAdminAddDummyDetector.Name = "buttonAdminAddDummyDetector";
            this.buttonAdminAddDummyDetector.Size = new System.Drawing.Size(163, 22);
            this.buttonAdminAddDummyDetector.Text = "Create dummy detector";
            this.buttonAdminAddDummyDetector.Click += new System.EventHandler(this.buttonAdminAddDummyDetector_Click);
            // 
            // buttonAdminAddBeaker
            // 
            this.buttonAdminAddBeaker.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdminAddBeaker.Image")));
            this.buttonAdminAddBeaker.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAdminAddBeaker.Name = "buttonAdminAddBeaker";
            this.buttonAdminAddBeaker.Size = new System.Drawing.Size(134, 22);
            this.buttonAdminAddBeaker.Text = "Create new beaker";
            this.buttonAdminAddBeaker.ToolTipText = "Create a new beaker definition";
            this.buttonAdminAddBeaker.Click += new System.EventHandler(this.buttonAdminAddBeaker_Click);
            // 
            // pageAnalArchive
            // 
            this.pageAnalArchive.BackColor = System.Drawing.SystemColors.Control;
            this.pageAnalArchive.Controls.Add(this.panelArchive);
            this.pageAnalArchive.Location = new System.Drawing.Point(4, 23);
            this.pageAnalArchive.Name = "pageAnalArchive";
            this.pageAnalArchive.Padding = new System.Windows.Forms.Padding(3);
            this.pageAnalArchive.Size = new System.Drawing.Size(996, 485);
            this.pageAnalArchive.TabIndex = 6;
            this.pageAnalArchive.Text = "AnalArchive";
            // 
            // panelArchive
            // 
            this.panelArchive.Controls.Add(this.panel5);
            this.panelArchive.Controls.Add(this.panel6);
            this.panelArchive.Controls.Add(this.toolsArchive);
            this.panelArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelArchive.Location = new System.Drawing.Point(3, 3);
            this.panelArchive.Name = "panelArchive";
            this.panelArchive.Size = new System.Drawing.Size(186, 67);
            this.panelArchive.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.listViewArchive);
            this.panel5.Controls.Add(this.toolsArchiveFiles);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(222, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 42);
            this.panel5.TabIndex = 2;
            // 
            // listViewArchive
            // 
            this.listViewArchive.BackColor = System.Drawing.SystemColors.Window;
            this.listViewArchive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lwArchiveName,
            this.lwArchiveDetector,
            this.lwArchiveYear,
            this.lwArchiveSpec,
            this.lwArchiveINPExists,
            this.lwArchiveLISExists,
            this.lwArchivePlotExists,
            this.lwArchivePath});
            this.listViewArchive.ContextMenuStrip = this.menuArchiveFiles;
            this.listViewArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewArchive.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewArchive.FullRowSelect = true;
            this.listViewArchive.Location = new System.Drawing.Point(0, 25);
            this.listViewArchive.MultiSelect = false;
            this.listViewArchive.Name = "listViewArchive";
            this.listViewArchive.Size = new System.Drawing.Size(0, 17);
            this.listViewArchive.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewArchive.TabIndex = 2;
            this.listViewArchive.UseCompatibleStateImageBehavior = false;
            this.listViewArchive.View = System.Windows.Forms.View.Details;
            this.listViewArchive.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewArchive_ItemSelectionChanged);
            this.listViewArchive.Resize += new System.EventHandler(this.listViewArchive_Resize);
            // 
            // lwArchiveName
            // 
            this.lwArchiveName.Text = "Name";
            this.lwArchiveName.Width = 80;
            // 
            // lwArchiveDetector
            // 
            this.lwArchiveDetector.Text = "Detector";
            this.lwArchiveDetector.Width = 120;
            // 
            // lwArchiveYear
            // 
            this.lwArchiveYear.Text = "Year";
            this.lwArchiveYear.Width = 120;
            // 
            // lwArchiveSpec
            // 
            this.lwArchiveSpec.Text = "Spectrum";
            this.lwArchiveSpec.Width = 125;
            // 
            // lwArchiveINPExists
            // 
            this.lwArchiveINPExists.Text = "INP";
            // 
            // lwArchiveLISExists
            // 
            this.lwArchiveLISExists.Text = "LIS";
            this.lwArchiveLISExists.Width = 64;
            // 
            // lwArchivePlotExists
            // 
            this.lwArchivePlotExists.Text = "Plot";
            // 
            // lwArchivePath
            // 
            this.lwArchivePath.Text = "Path";
            // 
            // menuArchiveFiles
            // 
            this.menuArchiveFiles.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.menuArchiveFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchiveFilesReanalyse,
            this.menuArchiveFilesShowLIS,
            this.menuArchiveFilesShowINP,
            this.menuArchiveFilesShowSpectrum,
            this.menuArchiveFilesPrintAnalyse,
            this.menuArchiveCreateBackground});
            this.menuArchiveFiles.Name = "menuArchiveFiles";
            this.menuArchiveFiles.Size = new System.Drawing.Size(183, 136);
            // 
            // menuArchiveFilesReanalyse
            // 
            this.menuArchiveFilesReanalyse.Name = "menuArchiveFilesReanalyse";
            this.menuArchiveFilesReanalyse.Size = new System.Drawing.Size(182, 22);
            this.menuArchiveFilesReanalyse.Text = "Reanalyse";
            this.menuArchiveFilesReanalyse.ToolTipText = "Reanalyse selected spectrum";
            this.menuArchiveFilesReanalyse.Click += new System.EventHandler(this.toolButtonReAnalyse_Click);
            // 
            // menuArchiveFilesShowLIS
            // 
            this.menuArchiveFilesShowLIS.Name = "menuArchiveFilesShowLIS";
            this.menuArchiveFilesShowLIS.Size = new System.Drawing.Size(182, 22);
            this.menuArchiveFilesShowLIS.Text = "Show LIS";
            this.menuArchiveFilesShowLIS.ToolTipText = "Show content of selected LIS file";
            this.menuArchiveFilesShowLIS.Click += new System.EventHandler(this.buttonArchiveShowLIS_Click);
            // 
            // menuArchiveFilesShowINP
            // 
            this.menuArchiveFilesShowINP.Name = "menuArchiveFilesShowINP";
            this.menuArchiveFilesShowINP.Size = new System.Drawing.Size(182, 22);
            this.menuArchiveFilesShowINP.Text = "Show INP";
            this.menuArchiveFilesShowINP.ToolTipText = "Show content of selected INP file";
            this.menuArchiveFilesShowINP.Click += new System.EventHandler(this.buttonArchiveShowINP_Click);
            // 
            // menuArchiveFilesShowSpectrum
            // 
            this.menuArchiveFilesShowSpectrum.Name = "menuArchiveFilesShowSpectrum";
            this.menuArchiveFilesShowSpectrum.Size = new System.Drawing.Size(182, 22);
            this.menuArchiveFilesShowSpectrum.Text = "Show Spectrum";
            this.menuArchiveFilesShowSpectrum.ToolTipText = "Plot selected spectrum";
            this.menuArchiveFilesShowSpectrum.Click += new System.EventHandler(this.buttonArchivePlotSpec_Click);
            // 
            // menuArchiveFilesPrintAnalyse
            // 
            this.menuArchiveFilesPrintAnalyse.Name = "menuArchiveFilesPrintAnalyse";
            this.menuArchiveFilesPrintAnalyse.Size = new System.Drawing.Size(182, 22);
            this.menuArchiveFilesPrintAnalyse.Text = "Print Analyse";
            // 
            // menuArchiveCreateBackground
            // 
            this.menuArchiveCreateBackground.Name = "menuArchiveCreateBackground";
            this.menuArchiveCreateBackground.Size = new System.Drawing.Size(182, 22);
            this.menuArchiveCreateBackground.Text = "Create background";
            this.menuArchiveCreateBackground.Click += new System.EventHandler(this.buttonArchiveCreateBackground_Click);
            // 
            // toolsArchiveFiles
            // 
            this.toolsArchiveFiles.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolsArchiveFiles.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsArchiveFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolButtonReAnalyse,
            this.buttonArchiveShowLIS,
            this.buttonArchiveShowINP,
            this.buttonArchiveShowSpec,
            this.buttonArchivePrintAnalyse,
            this.buttonArchiveCreateBackground});
            this.toolsArchiveFiles.Location = new System.Drawing.Point(0, 0);
            this.toolsArchiveFiles.Name = "toolsArchiveFiles";
            this.toolsArchiveFiles.Size = new System.Drawing.Size(0, 25);
            this.toolsArchiveFiles.TabIndex = 3;
            this.toolsArchiveFiles.Text = "toolStrip1";
            // 
            // toolButtonReAnalyse
            // 
            this.toolButtonReAnalyse.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonReAnalyse.Image")));
            this.toolButtonReAnalyse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonReAnalyse.Name = "toolButtonReAnalyse";
            this.toolButtonReAnalyse.Size = new System.Drawing.Size(86, 22);
            this.toolButtonReAnalyse.Text = "Reanalyse";
            this.toolButtonReAnalyse.ToolTipText = "Reanalyse selected spectrum";
            this.toolButtonReAnalyse.Click += new System.EventHandler(this.toolButtonReAnalyse_Click);
            // 
            // buttonArchiveShowLIS
            // 
            this.buttonArchiveShowLIS.Image = ((System.Drawing.Image)(resources.GetObject("buttonArchiveShowLIS.Image")));
            this.buttonArchiveShowLIS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonArchiveShowLIS.Name = "buttonArchiveShowLIS";
            this.buttonArchiveShowLIS.Size = new System.Drawing.Size(78, 22);
            this.buttonArchiveShowLIS.Text = "Show LIS";
            this.buttonArchiveShowLIS.ToolTipText = "Show content of selected LIS file";
            this.buttonArchiveShowLIS.Click += new System.EventHandler(this.buttonArchiveShowLIS_Click);
            // 
            // buttonArchiveShowINP
            // 
            this.buttonArchiveShowINP.Image = ((System.Drawing.Image)(resources.GetObject("buttonArchiveShowINP.Image")));
            this.buttonArchiveShowINP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonArchiveShowINP.Name = "buttonArchiveShowINP";
            this.buttonArchiveShowINP.Size = new System.Drawing.Size(79, 22);
            this.buttonArchiveShowINP.Text = "Show INP";
            this.buttonArchiveShowINP.ToolTipText = "Show content of selected INP file";
            this.buttonArchiveShowINP.Click += new System.EventHandler(this.buttonArchiveShowINP_Click);
            // 
            // buttonArchiveShowSpec
            // 
            this.buttonArchiveShowSpec.Image = ((System.Drawing.Image)(resources.GetObject("buttonArchiveShowSpec.Image")));
            this.buttonArchiveShowSpec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonArchiveShowSpec.Name = "buttonArchiveShowSpec";
            this.buttonArchiveShowSpec.Size = new System.Drawing.Size(115, 22);
            this.buttonArchiveShowSpec.Text = "Show Spectrum";
            this.buttonArchiveShowSpec.ToolTipText = "Plot selected spectrum";
            this.buttonArchiveShowSpec.Click += new System.EventHandler(this.buttonArchivePlotSpec_Click);
            // 
            // buttonArchivePrintAnalyse
            // 
            this.buttonArchivePrintAnalyse.Image = ((System.Drawing.Image)(resources.GetObject("buttonArchivePrintAnalyse.Image")));
            this.buttonArchivePrintAnalyse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonArchivePrintAnalyse.Name = "buttonArchivePrintAnalyse";
            this.buttonArchivePrintAnalyse.Size = new System.Drawing.Size(104, 22);
            this.buttonArchivePrintAnalyse.Text = "Print Analysis";
            this.buttonArchivePrintAnalyse.Click += new System.EventHandler(this.buttonArchivePrintAnalyse_Click);
            // 
            // buttonArchiveCreateBackground
            // 
            this.buttonArchiveCreateBackground.Image = ((System.Drawing.Image)(resources.GetObject("buttonArchiveCreateBackground.Image")));
            this.buttonArchiveCreateBackground.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonArchiveCreateBackground.Name = "buttonArchiveCreateBackground";
            this.buttonArchiveCreateBackground.Size = new System.Drawing.Size(135, 22);
            this.buttonArchiveCreateBackground.Text = "Create background";
            this.buttonArchiveCreateBackground.Click += new System.EventHandler(this.buttonArchiveCreateBackground_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.treeArchive);
            this.panel6.Controls.Add(this.toolsArchiveTree);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 25);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(222, 42);
            this.panel6.TabIndex = 3;
            // 
            // treeArchive
            // 
            this.treeArchive.BackColor = System.Drawing.SystemColors.Window;
            this.treeArchive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeArchive.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeArchive.HideSelection = false;
            this.treeArchive.HotTracking = true;
            this.treeArchive.ImageIndex = 0;
            this.treeArchive.ImageList = this.imageListFolder;
            this.treeArchive.Indent = 56;
            this.treeArchive.Location = new System.Drawing.Point(0, 25);
            this.treeArchive.Name = "treeArchive";
            this.treeArchive.SelectedImageIndex = 1;
            this.treeArchive.Size = new System.Drawing.Size(222, 17);
            this.treeArchive.TabIndex = 1;
            this.treeArchive.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeArchive_NodeMouseClick);
            // 
            // imageListFolder
            // 
            this.imageListFolder.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFolder.ImageStream")));
            this.imageListFolder.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFolder.Images.SetKeyName(0, "folder16.png");
            this.imageListFolder.Images.SetKeyName(1, "folder_open16.png");
            // 
            // toolsArchiveTree
            // 
            this.toolsArchiveTree.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolsArchiveTree.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsArchiveTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonArchiveCollapse,
            this.buttonArchiveExpand,
            this.labelArchiveFileCount});
            this.toolsArchiveTree.Location = new System.Drawing.Point(0, 0);
            this.toolsArchiveTree.Name = "toolsArchiveTree";
            this.toolsArchiveTree.Size = new System.Drawing.Size(222, 25);
            this.toolsArchiveTree.TabIndex = 0;
            this.toolsArchiveTree.Text = "toolStrip1";
            // 
            // buttonArchiveCollapse
            // 
            this.buttonArchiveCollapse.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonArchiveCollapse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonArchiveCollapse.Image = ((System.Drawing.Image)(resources.GetObject("buttonArchiveCollapse.Image")));
            this.buttonArchiveCollapse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonArchiveCollapse.Name = "buttonArchiveCollapse";
            this.buttonArchiveCollapse.Size = new System.Drawing.Size(23, 22);
            this.buttonArchiveCollapse.Text = "toolStripButton1";
            this.buttonArchiveCollapse.ToolTipText = "Collapse tree";
            this.buttonArchiveCollapse.Click += new System.EventHandler(this.buttonArchiveCollapse_Click);
            // 
            // buttonArchiveExpand
            // 
            this.buttonArchiveExpand.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonArchiveExpand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonArchiveExpand.Image = ((System.Drawing.Image)(resources.GetObject("buttonArchiveExpand.Image")));
            this.buttonArchiveExpand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonArchiveExpand.Name = "buttonArchiveExpand";
            this.buttonArchiveExpand.Size = new System.Drawing.Size(23, 22);
            this.buttonArchiveExpand.ToolTipText = "Expand tree";
            this.buttonArchiveExpand.Click += new System.EventHandler(this.buttonArchiveExpand_Click);
            // 
            // labelArchiveFileCount
            // 
            this.labelArchiveFileCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.labelArchiveFileCount.Name = "labelArchiveFileCount";
            this.labelArchiveFileCount.Size = new System.Drawing.Size(0, 22);
            // 
            // toolsArchive
            // 
            this.toolsArchive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolsArchive.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsArchive.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonArchiveBack,
            this.toolStripLabel1,
            this.toolStripSeparator7,
            this.buttonArchiveShowHistory,
            this.buttonArchiveSearch,
            this.buttonCreateJournal});
            this.toolsArchive.Location = new System.Drawing.Point(0, 0);
            this.toolsArchive.Name = "toolsArchive";
            this.toolsArchive.Size = new System.Drawing.Size(186, 25);
            this.toolsArchive.TabIndex = 4;
            this.toolsArchive.Text = "toolStrip3";
            // 
            // buttonArchiveBack
            // 
            this.buttonArchiveBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonArchiveBack.Image")));
            this.buttonArchiveBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonArchiveBack.Name = "buttonArchiveBack";
            this.buttonArchiveBack.Size = new System.Drawing.Size(89, 22);
            this.buttonArchiveBack.Text = "Main menu";
            this.buttonArchiveBack.ToolTipText = "Back to main menu";
            this.buttonArchiveBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "Archive";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonArchiveShowHistory
            // 
            this.buttonArchiveShowHistory.Image = ((System.Drawing.Image)(resources.GetObject("buttonArchiveShowHistory.Image")));
            this.buttonArchiveShowHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonArchiveShowHistory.Name = "buttonArchiveShowHistory";
            this.buttonArchiveShowHistory.Size = new System.Drawing.Size(100, 22);
            this.buttonArchiveShowHistory.Text = "Show history";
            this.buttonArchiveShowHistory.Click += new System.EventHandler(this.buttonArchiveShowHistory_Click);
            // 
            // buttonArchiveSearch
            // 
            this.buttonArchiveSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonArchiveSearch.Image")));
            this.buttonArchiveSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonArchiveSearch.Name = "buttonArchiveSearch";
            this.buttonArchiveSearch.Size = new System.Drawing.Size(111, 22);
            this.buttonArchiveSearch.Text = "Search archive";
            this.buttonArchiveSearch.Click += new System.EventHandler(this.buttonArchiveSearch_Click);
            // 
            // buttonCreateJournal
            // 
            this.buttonCreateJournal.Image = ((System.Drawing.Image)(resources.GetObject("buttonCreateJournal.Image")));
            this.buttonCreateJournal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCreateJournal.Name = "buttonCreateJournal";
            this.buttonCreateJournal.Size = new System.Drawing.Size(108, 22);
            this.buttonCreateJournal.Text = "Create journal";
            this.buttonCreateJournal.Click += new System.EventHandler(this.buttonCreateJournal_Click);
            // 
            // pageLog
            // 
            this.pageLog.BackColor = System.Drawing.SystemColors.Control;
            this.pageLog.Controls.Add(this.textBoxMessages);
            this.pageLog.Controls.Add(this.toolsLog);
            this.pageLog.Location = new System.Drawing.Point(4, 23);
            this.pageLog.Name = "pageLog";
            this.pageLog.Padding = new System.Windows.Forms.Padding(3);
            this.pageLog.Size = new System.Drawing.Size(996, 485);
            this.pageLog.TabIndex = 7;
            this.pageLog.Text = "Log";
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMessages.Location = new System.Drawing.Point(3, 28);
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ReadOnly = true;
            this.textBoxMessages.Size = new System.Drawing.Size(990, 454);
            this.textBoxMessages.TabIndex = 1;
            this.textBoxMessages.Text = "";
            // 
            // toolsLog
            // 
            this.toolsLog.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolsLog.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonLogBack,
            this.toolLabelLog,
            this.toolStripSeparator9,
            this.buttonLogSave});
            this.toolsLog.Location = new System.Drawing.Point(3, 3);
            this.toolsLog.Name = "toolsLog";
            this.toolsLog.Size = new System.Drawing.Size(990, 25);
            this.toolsLog.TabIndex = 0;
            // 
            // buttonLogBack
            // 
            this.buttonLogBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogBack.Image")));
            this.buttonLogBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonLogBack.Name = "buttonLogBack";
            this.buttonLogBack.Size = new System.Drawing.Size(89, 22);
            this.buttonLogBack.Text = "Main menu";
            this.buttonLogBack.ToolTipText = "Back to main menu";
            this.buttonLogBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // toolLabelLog
            // 
            this.toolLabelLog.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolLabelLog.Name = "toolLabelLog";
            this.toolLabelLog.Size = new System.Drawing.Size(27, 22);
            this.toolLabelLog.Text = "Log";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonLogSave
            // 
            this.buttonLogSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogSave.Image")));
            this.buttonLogSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonLogSave.Name = "buttonLogSave";
            this.buttonLogSave.Size = new System.Drawing.Size(90, 22);
            this.buttonLogSave.Text = "Save to file";
            this.buttonLogSave.Click += new System.EventHandler(this.buttonLogSave_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "detector64.png");
            this.imageList.Images.SetKeyName(1, "drawer64.png");
            this.imageList.Images.SetKeyName(2, "beaker64.png");
            // 
            // labeledComboBox6
            // 
            this.labeledComboBox6.Caption = "BKGFIL";
            this.labeledComboBox6.Location = new System.Drawing.Point(328, 287);
            this.labeledComboBox6.Name = "labeledComboBox6";
            this.labeledComboBox6.Size = new System.Drawing.Size(300, 21);
            this.labeledComboBox6.TabIndex = 18;
            // 
            // labeledComboBox7
            // 
            this.labeledComboBox7.Caption = "ENFIL";
            this.labeledComboBox7.Location = new System.Drawing.Point(8, 287);
            this.labeledComboBox7.Name = "labeledComboBox7";
            this.labeledComboBox7.Size = new System.Drawing.Size(300, 21);
            this.labeledComboBox7.TabIndex = 17;
            // 
            // labeledTextBox20
            // 
            this.labeledTextBox20.BackColor = System.Drawing.SystemColors.Window;
            this.labeledTextBox20.Caption = "ICA";
            this.labeledTextBox20.Location = new System.Drawing.Point(420, 246);
            this.labeledTextBox20.MaxStringLength = 32767;
            this.labeledTextBox20.Name = "labeledTextBox20";
            this.labeledTextBox20.Size = new System.Drawing.Size(176, 21);
            this.labeledTextBox20.TabIndex = 16;
            this.labeledTextBox20.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // labeledTextBox21
            // 
            this.labeledTextBox21.BackColor = System.Drawing.SystemColors.Window;
            this.labeledTextBox21.Caption = "LOCH";
            this.labeledTextBox21.Location = new System.Drawing.Point(223, 246);
            this.labeledTextBox21.MaxStringLength = 32767;
            this.labeledTextBox21.Name = "labeledTextBox21";
            this.labeledTextBox21.Size = new System.Drawing.Size(176, 21);
            this.labeledTextBox21.TabIndex = 15;
            this.labeledTextBox21.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // labeledTextBox22
            // 
            this.labeledTextBox22.BackColor = System.Drawing.SystemColors.Window;
            this.labeledTextBox22.Caption = "ETOL";
            this.labeledTextBox22.Location = new System.Drawing.Point(11, 246);
            this.labeledTextBox22.MaxStringLength = 32767;
            this.labeledTextBox22.Name = "labeledTextBox22";
            this.labeledTextBox22.Size = new System.Drawing.Size(176, 21);
            this.labeledTextBox22.TabIndex = 14;
            this.labeledTextBox22.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // labeledTextBox23
            // 
            this.labeledTextBox23.BackColor = System.Drawing.SystemColors.Window;
            this.labeledTextBox23.Caption = "BSTF";
            this.labeledTextBox23.Location = new System.Drawing.Point(624, 210);
            this.labeledTextBox23.MaxStringLength = 32767;
            this.labeledTextBox23.Name = "labeledTextBox23";
            this.labeledTextBox23.Size = new System.Drawing.Size(176, 21);
            this.labeledTextBox23.TabIndex = 13;
            this.labeledTextBox23.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // labeledTextBox24
            // 
            this.labeledTextBox24.BackColor = System.Drawing.SystemColors.Window;
            this.labeledTextBox24.Caption = "THRESH";
            this.labeledTextBox24.Location = new System.Drawing.Point(420, 210);
            this.labeledTextBox24.MaxStringLength = 32767;
            this.labeledTextBox24.Name = "labeledTextBox24";
            this.labeledTextBox24.Size = new System.Drawing.Size(176, 21);
            this.labeledTextBox24.TabIndex = 12;
            this.labeledTextBox24.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // labeledTextBox25
            // 
            this.labeledTextBox25.BackColor = System.Drawing.SystemColors.Window;
            this.labeledTextBox25.Caption = "FWHMAN";
            this.labeledTextBox25.Location = new System.Drawing.Point(223, 210);
            this.labeledTextBox25.MaxStringLength = 32767;
            this.labeledTextBox25.Name = "labeledTextBox25";
            this.labeledTextBox25.Size = new System.Drawing.Size(176, 21);
            this.labeledTextBox25.TabIndex = 11;
            this.labeledTextBox25.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // labeledTextBox26
            // 
            this.labeledTextBox26.BackColor = System.Drawing.SystemColors.Window;
            this.labeledTextBox26.Caption = "FWHMPS";
            this.labeledTextBox26.Location = new System.Drawing.Point(11, 210);
            this.labeledTextBox26.MaxStringLength = 32767;
            this.labeledTextBox26.Name = "labeledTextBox26";
            this.labeledTextBox26.Size = new System.Drawing.Size(176, 21);
            this.labeledTextBox26.TabIndex = 10;
            this.labeledTextBox26.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Analysis parameters";
            // 
            // labeledTextBox27
            // 
            this.labeledTextBox27.BackColor = System.Drawing.SystemColors.Window;
            this.labeledTextBox27.Caption = "Detector info";
            this.labeledTextBox27.Location = new System.Drawing.Point(8, 138);
            this.labeledTextBox27.MaxStringLength = 32767;
            this.labeledTextBox27.Name = "labeledTextBox27";
            this.labeledTextBox27.Size = new System.Drawing.Size(300, 21);
            this.labeledTextBox27.TabIndex = 8;
            this.labeledTextBox27.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // labeledComboBox8
            // 
            this.labeledComboBox8.Caption = "Record length";
            this.labeledComboBox8.Location = new System.Drawing.Point(8, 111);
            this.labeledComboBox8.Name = "labeledComboBox8";
            this.labeledComboBox8.Size = new System.Drawing.Size(300, 21);
            this.labeledComboBox8.TabIndex = 7;
            // 
            // labeledComboBox9
            // 
            this.labeledComboBox9.Caption = "Spectrum file format";
            this.labeledComboBox9.Location = new System.Drawing.Point(8, 84);
            this.labeledComboBox9.Name = "labeledComboBox9";
            this.labeledComboBox9.Size = new System.Drawing.Size(300, 21);
            this.labeledComboBox9.TabIndex = 6;
            // 
            // labeledComboBox10
            // 
            this.labeledComboBox10.Caption = "Number of channels";
            this.labeledComboBox10.Location = new System.Drawing.Point(8, 57);
            this.labeledComboBox10.Name = "labeledComboBox10";
            this.labeledComboBox10.Size = new System.Drawing.Size(300, 21);
            this.labeledComboBox10.TabIndex = 5;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(420, 57);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(56, 17);
            this.checkBox8.TabIndex = 4;
            this.checkBox8.Text = "Active";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Detector parameters";
            // 
            // FormGammaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "FormGammaGUI";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spek10";
            this.Load += new System.EventHandler(this.FormGammaGUI_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormGammaGUI_Paint);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.wizardMain.ResumeLayout(false);
            this.pageMenu.ResumeLayout(false);
            this.pageMenu.PerformLayout();
            this.flowMenu.ResumeLayout(false);
            this.toolsMain.ResumeLayout(false);
            this.toolsMain.PerformLayout();
            this.pageSelDet.ResumeLayout(false);
            this.pageSelDet.PerformLayout();
            this.panelStartStop.ResumeLayout(false);
            this.panelStartStop.PerformLayout();
            this.toolsStartStop.ResumeLayout(false);
            this.toolsStartStop.PerformLayout();
            this.pageReAnal.ResumeLayout(false);
            this.pageReAnal.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.splitterEditAnal.Panel1.ResumeLayout(false);
            this.splitterEditAnal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterEditAnal)).EndInit();
            this.splitterEditAnal.ResumeLayout(false);
            this.panelReAnalTopMiddle.ResumeLayout(false);
            this.panelReAnalTopRight.ResumeLayout(false);
            this.panelReAnalTopLeft.ResumeLayout(false);
            this.panelReAnalTopLeft.PerformLayout();
            this.panelReAnalBottomMiddle.ResumeLayout(false);
            this.panelReAnalBottomRight.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelReAnalBottomLeft.ResumeLayout(false);
            this.panel55.ResumeLayout(false);
            this.panel55.PerformLayout();
            this.toolsReAnal.ResumeLayout(false);
            this.toolsReAnal.PerformLayout();
            this.pageAnal.ResumeLayout(false);
            this.pageAnal.PerformLayout();
            this.splitterNewAnal.Panel1.ResumeLayout(false);
            this.splitterNewAnal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterNewAnal)).EndInit();
            this.splitterNewAnal.ResumeLayout(false);
            this.panelAnalTopMiddle.ResumeLayout(false);
            this.panelAnalTopRight.ResumeLayout(false);
            this.panelAnalTopLeft.ResumeLayout(false);
            this.panelAnalBottomMiddle.ResumeLayout(false);
            this.panelAnalBottomRight.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panelAnalBottomLeft.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.toolsStartStopView.ResumeLayout(false);
            this.toolsStartStopView.PerformLayout();
            this.pageAdmin.ResumeLayout(false);
            this.pageAdmin.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.tabControlAdmin.ResumeLayout(false);
            this.pageAdminConfig.ResumeLayout(false);
            this.panel50.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.panel57.ResumeLayout(false);
            this.panel57.PerformLayout();
            this.panel56.ResumeLayout(false);
            this.panel56.PerformLayout();
            this.panel54.ResumeLayout(false);
            this.panel54.PerformLayout();
            this.pageAdminDetectors.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel58.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel62.ResumeLayout(false);
            this.panel62.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel59.ResumeLayout(false);
            this.panel64.ResumeLayout(false);
            this.panel64.PerformLayout();
            this.panel60.ResumeLayout(false);
            this.panel60.PerformLayout();
            this.panel68.ResumeLayout(false);
            this.panel68.PerformLayout();
            this.pageAdminBeaker.ResumeLayout(false);
            this.panelAdmBeakerConf.ResumeLayout(false);
            this.panelAdmBeakerConfParam.ResumeLayout(false);
            this.panelAdmBeakerConfParam.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel69.ResumeLayout(false);
            this.panel69.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.pageAdminMaestro.ResumeLayout(false);
            this.panelAdminMaestro.ResumeLayout(false);
            this.tabControlAdminScripts.ResumeLayout(false);
            this.pageAdminScriptsBuffer.ResumeLayout(false);
            this.pageAdminScriptsBuffer.PerformLayout();
            this.pageAdminScriptsStart.ResumeLayout(false);
            this.pageAdminScriptsStart.PerformLayout();
            this.pageAdminScriptsStop.ResumeLayout(false);
            this.pageAdminScriptsStop.PerformLayout();
            this.panelAdminScriptsLeft.ResumeLayout(false);
            this.panelAdminScriptsLeft.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabAdminGenie.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel31.ResumeLayout(false);
            this.panel31.PerformLayout();
            this.toolsAdmin.ResumeLayout(false);
            this.toolsAdmin.PerformLayout();
            this.pageAnalArchive.ResumeLayout(false);
            this.panelArchive.ResumeLayout(false);
            this.panelArchive.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.menuArchiveFiles.ResumeLayout(false);
            this.toolsArchiveFiles.ResumeLayout(false);
            this.toolsArchiveFiles.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.toolsArchiveTree.ResumeLayout(false);
            this.toolsArchiveTree.PerformLayout();
            this.toolsArchive.ResumeLayout(false);
            this.toolsArchive.PerformLayout();
            this.pageLog.ResumeLayout(false);
            this.pageLog.PerformLayout();
            this.toolsLog.ResumeLayout(false);
            this.toolsLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem hjelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private TabControlWizard.TabControlWizard wizardMain;
        private System.Windows.Forms.TabPage pageMenu;
        private System.Windows.Forms.TabPage pageSelDet;
        private System.Windows.Forms.TabPage pageReAnal;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStrip toolsStartStop;
        private System.Windows.Forms.ToolStripButton buttonStartStopBack;
        private System.Windows.Forms.ToolStripLabel labelStartStopTitle;
        private System.Windows.Forms.Panel panelStartStop;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.TabPage pageAnal;
        private System.Windows.Forms.ToolStrip toolsStartStopView;
        private System.Windows.Forms.ToolStripButton buttonStartStopViewBack;
        private System.Windows.Forms.ToolStripLabel labelStartStopView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton buttonAnalStart;
        private System.Windows.Forms.ToolStripButton buttonAnalBuffer;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar statusProgress;
        private System.Windows.Forms.TabPage pageAdmin;
        private System.Windows.Forms.ToolStrip toolsAdmin;
        private System.Windows.Forms.ToolStripButton buttonAdminBack;
        private System.Windows.Forms.ToolStripLabel labelAdminTitle;
        private System.Windows.Forms.ToolStripMenuItem menuItemAdmin;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage pageAdminConfig;
        private System.Windows.Forms.TabPage pageAdminDetectors;
        private System.Windows.Forms.ListView listViewAdminDetectors;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ColumnHeader columnAdminDetectorName;
        private System.Windows.Forms.ColumnHeader columnAdminDetectorType;
        private System.Windows.Forms.Panel panel7;
        private VintageControls.LabeledComboBox labeledComboBox6;
        private VintageControls.LabeledComboBox labeledComboBox7;
        private VintageControls.LabeledTextBox labeledTextBox20;
        private VintageControls.LabeledTextBox labeledTextBox21;
        private VintageControls.LabeledTextBox labeledTextBox22;
        private VintageControls.LabeledTextBox labeledTextBox23;
        private VintageControls.LabeledTextBox labeledTextBox24;
        private VintageControls.LabeledTextBox labeledTextBox25;
        private VintageControls.LabeledTextBox labeledTextBox26;
        private System.Windows.Forms.Label label14;
        private VintageControls.LabeledTextBox labeledTextBox27;
        private VintageControls.LabeledComboBox labeledComboBox8;
        private VintageControls.LabeledComboBox labeledComboBox9;
        private VintageControls.LabeledComboBox labeledComboBox10;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.SplitContainer splitterEditAnal;
        private System.Windows.Forms.TabPage pageAnalArchive;
        private System.Windows.Forms.ToolStripButton buttonAnalToggleAdvanced;
        private System.Windows.Forms.TabPage pageAdminBeaker;
        private System.Windows.Forms.Panel panelAdmBeakerConf;
        private System.Windows.Forms.ListView lvAdmBeakers;
        private System.Windows.Forms.Panel panelAdmBeakerConfParam;
        private System.Windows.Forms.ColumnHeader headerName;
        private System.Windows.Forms.ColumnHeader headerRadius;
        private System.Windows.Forms.ColumnHeader headerHeight;
        private System.Windows.Forms.ColumnHeader headerMin;
        private System.Windows.Forms.ColumnHeader headerMax;
        private System.Windows.Forms.Panel panelArchive;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Panel panelReAnalTopMiddle;
        private VintageControls.LabeledTextBox txtReAnalQuantityUncertainty;
        private VintageControls.LabeledTextBox txtReAnalSampleHeight;
        private VintageControls.LabeledTextBox txtReAnalSamplePlace;
        private System.Windows.Forms.Panel panelReAnalTopRight;
        private VintageControls.LabeledFileDialog dialogReAnalDetLimLib;
        private VintageControls.LabeledComboBox cboxReAnalSampQuantUnit;
        private VintageControls.LabeledTextBox txtReAnalSampleWeight;
        private VintageControls.LabeledTextBox txtReAnalSpecnum;
        private System.Windows.Forms.Panel panelReAnalTopLeft;
        private VintageControls.LabeledTextBox txtReAnalQuantity;
        private VintageControls.LabeledComboBox cboxReAnalSampBeaker;
        private VintageControls.LabeledTextBox txtReAnalSampleId;
        private VintageControls.LabeledTextBox txtReAnalDetector;
        private System.Windows.Forms.Panel panelReAnalBottomMiddle;
        private VintageControls.LabeledTextBox txtReAnalRealtime;
        private VintageControls.LabeledTextBox txtReAnalMeasurementStop;
        private System.Windows.Forms.Panel panel48;
        private System.Windows.Forms.Panel panelReAnalBottomRight;
        private VintageControls.LabeledTextBox txtReAnalDeadtime;
        private VintageControls.LabeledTextBox txtReAnalMeasurementTime;
        private System.Windows.Forms.Panel panel51;
        private System.Windows.Forms.Panel panelReAnalBottomLeft;
        private VintageControls.LabeledTextBox txtReAnalLivetime;
        private VintageControls.LabeledTextBox txtReAnalMeasurementStart;
        private System.Windows.Forms.Panel panel55;
        private System.Windows.Forms.Label label8;
        private VintageControls.LabeledFileDialog dialogReAnalPefFile;
        private VintageControls.LabeledFileDialog dialogReAnalBackgroundFile;
        private VintageControls.LabeledTextBox txtReAnalETOL;
        private VintageControls.LabeledTextBox txtReAnalFWHMAN;
        private VintageControls.LabeledComboBox cboxReAnalSampMethod;
        private VintageControls.LabeledFileDialog dialogReAnalTefFile;
        private VintageControls.LabeledTextBox txtReAnalLOCH;
        private VintageControls.LabeledTextBox txtReAnalTHRESH;
        private VintageControls.LabeledTextBox txtReAnalRecLen;
        private VintageControls.LabeledTextBox txtReAnalBSTF;
        private VintageControls.LabeledTextBox txtReAnalFWHMPS;
        private VintageControls.LabeledComboBox cboxReAnalSampChannels;
        private System.Windows.Forms.Panel panel50;
        private VintageControls.LabeledFileDialog labeledFileDialog18;
        private VintageControls.LabeledFileDialog labeledFileDialog17;
        private VintageControls.LabeledFileDialog dialogAdminDefDetLib;
        private VintageControls.LabeledFileDialog dialogAdminDefNuclLib;
        private System.Windows.Forms.Panel panel54;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelAdminSetup;
        private System.Windows.Forms.Panel panel57;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel56;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage pageLog;
        private System.Windows.Forms.RichTextBox textBoxMessages;
        private System.Windows.Forms.ToolStrip toolsLog;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel58;
        private VintageControls.LabeledComboBox cboxAdminDetPefTef;
        private System.Windows.Forms.Panel panel65;
        private VintageControls.LabeledComboBox cboxAdminDetBkgFiles;
        private System.Windows.Forms.Panel panel61;
        private VintageControls.LabeledTextBox txtAdminDetETOL;
        private VintageControls.LabeledTextBox txtAdminDetFWHMAN;
        private System.Windows.Forms.Panel panel63;
        private VintageControls.LabeledTextBox txtAdminDetComment;
        private VintageControls.LabeledComboBox cboxAdminDetRecords;
        private System.Windows.Forms.Panel panel62;
        private System.Windows.Forms.CheckBox cbAdminDetConnected;
        private System.Windows.Forms.CheckBox cbAdminDetDummy;
        private System.Windows.Forms.CheckBox cbAdminDetActive;
        private System.Windows.Forms.Panel panel59;
        private VintageControls.LabeledComboBox cboxAdminDetBeakers;
        private System.Windows.Forms.Panel panel64;
        private System.Windows.Forms.Label label12;
        private VintageControls.LabeledComboBox cboxAdminDetEngFiles;
        private VintageControls.LabeledTextBox txtAdminDetLOCH;
        private VintageControls.LabeledTextBox txtAdminDetBSTF;
        private VintageControls.LabeledTextBox txtAdminDetTHRESH;
        private VintageControls.LabeledTextBox txtAdminDetFWHMPS;
        private System.Windows.Forms.Panel panel60;
        private System.Windows.Forms.Label label11;
        private VintageControls.LabeledComboBox cboxAdminDetSpecFmt;
        private VintageControls.LabeledComboBox cboxAdminDetChannels;
        private System.Windows.Forms.Panel panel68;
        private System.Windows.Forms.Label labelAdminDetTitle;
        private VintageControls.LabeledTextBox txtAdminBeakerComment;
        private VintageControls.LabeledTextBox txtAdminBeakerManufacturer;
        private VintageControls.LabeledTextBox txtAdminBeakerMaxFillHeight;
        private VintageControls.LabeledTextBox txtAdminBeakerMinFillHeight;
        private VintageControls.LabeledTextBox txtAdminBeakerHeight;
        private VintageControls.LabeledTextBox txtAdminBeakerRadius;
        private VintageControls.LabeledTextBox txtAdminBeakerName;
        private System.Windows.Forms.Panel panel69;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem menuItemLog;
        private System.Windows.Forms.ToolStripButton buttonLogBack;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView listViewArchive;
        private System.Windows.Forms.ColumnHeader lwArchiveName;
        private System.Windows.Forms.ColumnHeader lwArchiveDetector;
        private System.Windows.Forms.ColumnHeader lwArchiveYear;
        private System.Windows.Forms.ColumnHeader lwArchiveSpec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ColumnHeader lwArchiveLISExists;
        private System.Windows.Forms.ColumnHeader lwArchiveINPExists;
        private VintageControls.LabeledTextBox txtReAnalYear;
        private VintageControls.LabeledFileDialog dialogReAnalEnergyFile;
        private System.Windows.Forms.ToolStrip toolsReAnal;
        private System.Windows.Forms.ToolStripButton buttonReAnalBack;
        private System.Windows.Forms.ToolStripLabel labelEditAnalyzeTitle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton buttonReAnal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton buttonReAnalToggleAdvanced;
        private System.Windows.Forms.ToolStrip toolsArchive;
        private System.Windows.Forms.ToolStripButton buttonArchiveBack;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ColumnHeader columnAdminDetectorActive;
        private System.Windows.Forms.ColumnHeader columnAdminDetectorConnected;
        private VintageControls.LabeledTextBox txtAdminDetID;
        private System.Windows.Forms.ColumnHeader columnAdminSpecSoft;
        private System.Windows.Forms.ToolStripButton buttonAdminAddBeaker;
        private System.Windows.Forms.Panel panel8;
        private VintageControls.LabeledTextBox txtReAnalReferenceTime;
        private VintageControls.LabeledTextBox txtReAnalSampleStart;
        private VintageControls.LabeledTextBox txtReAnalSampleStop;
        private VintageControls.LabeledFileDialog dialogReAnalNuclLib;
        private VintageControls.LabeledTextBox txtReAnalFormat;
        private System.Windows.Forms.CheckBox cbAdminBeakerInUse;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button buttonAdminDetSave;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label labelAdminBeaBeaker;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button buttonAdminBeaSave;
        private System.Windows.Forms.Label labelAdminDetDetector;
        private System.Windows.Forms.SplitContainer splitterNewAnal;
        private System.Windows.Forms.Panel panelAnalTopMiddle;
        private VintageControls.LabeledFileDialog dialogAnalNuclLib;
        private VintageControls.LabeledTextBox txtAnalSamplingStop;
        private VintageControls.LabeledTextBox txtAnalQuantityUncertainty;
        private VintageControls.LabeledTextBox txtAnalHeight;
        private VintageControls.LabeledTextBox txtAnalSamplePlace;
        private VintageControls.LabeledTextBox txtAnalYear;
        private System.Windows.Forms.Panel panelAnalTopRight;
        private VintageControls.LabeledFileDialog dialogAnalDetLimLib;
        private VintageControls.LabeledComboBox cboxAnalSampQuantUnit;
        private VintageControls.LabeledTextBox txtAnalWeight;
        private System.Windows.Forms.Panel panel29;
        private VintageControls.LabeledTextBox txtAnalSpecNum;
        private System.Windows.Forms.Panel panelAnalTopLeft;
        private VintageControls.LabeledTextBox txtAnalReferenceTime;
        private VintageControls.LabeledTextBox txtAnalSamplingStart;
        private VintageControls.LabeledTextBox txtAnalQuantity;
        private VintageControls.LabeledComboBox cboxAnalSampBeaker;
        private VintageControls.LabeledTextBox txtAnalSampleId;
        private VintageControls.LabeledTextBox txtAnalDetector;
        private System.Windows.Forms.Panel panelAnalBottomMiddle;
        private VintageControls.LabeledTextBox labeledTextBox31;
        private VintageControls.LabeledTextBox labeledTextBox28;
        private System.Windows.Forms.Panel panel27;
        private VintageControls.LabeledFileDialog dialogAnalPEFFile;
        private VintageControls.LabeledFileDialog dialogAnalBackgroundFile;
        private VintageControls.LabeledTextBox txtAnalETOL;
        private VintageControls.LabeledTextBox txtAnalFWHMAN;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panelAnalBottomRight;
        private VintageControls.LabeledTextBox labeledTextBox29;
        private System.Windows.Forms.Panel panel28;
        private VintageControls.LabeledFileDialog dialogAnalTEFFile;
        private VintageControls.LabeledFileDialog dialogAnalEnergyFile;
        private VintageControls.LabeledTextBox txtAnalLOCH;
        private VintageControls.LabeledTextBox txtAnalTHRESH;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panelAnalBottomLeft;
        private VintageControls.LabeledTextBox labeledTextBox30;
        private VintageControls.LabeledTextBox labeledTextBox19;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel25;
        private VintageControls.LabeledTextBox txtAnalBSTF;
        private VintageControls.LabeledTextBox txtAnalFWHMPS;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripLabel toolLabelLog;
        private System.Windows.Forms.ToolStrip toolsMain;
        private System.Windows.Forms.ToolStripLabel labelMain;
        private System.Windows.Forms.ToolStripButton buttonAnalStop;
        private System.Windows.Forms.TreeView treeArchive;
        private System.Windows.Forms.ToolStrip toolsArchiveTree;
        private System.Windows.Forms.ToolStripButton buttonArchiveExpand;
        private System.Windows.Forms.ToolStripButton buttonArchiveCollapse;
        private System.Windows.Forms.ToolStrip toolsArchiveFiles;
        private System.Windows.Forms.ToolStripButton toolButtonReAnalyse;
        private System.Windows.Forms.ToolStripButton buttonArchiveShowLIS;
        private System.Windows.Forms.ToolStripButton buttonArchiveShowINP;
        private System.Windows.Forms.ToolStripButton buttonArchiveShowSpec;
        private System.Windows.Forms.ToolStripLabel labelAnalMeasurement;
        private System.Windows.Forms.ImageList imageListFolder;
        private System.Windows.Forms.ContextMenuStrip menuArchiveFiles;
        private System.Windows.Forms.ToolStripMenuItem menuArchiveFilesReanalyse;
        private System.Windows.Forms.ToolStripMenuItem menuArchiveFilesShowLIS;
        private System.Windows.Forms.ToolStripMenuItem menuArchiveFilesShowINP;
        private System.Windows.Forms.ToolStripMenuItem menuArchiveFilesShowSpectrum;
        private System.Windows.Forms.ColumnHeader lwArchivePath;
        private System.Windows.Forms.Label labelReAnalPath;
        private System.Windows.Forms.ColumnHeader lwArchivePlotExists;
        private System.Windows.Forms.ToolStripButton buttonReAnalCancel;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.ToolStripButton buttonArchivePrintAnalyse;
        private System.Windows.Forms.ToolStripMenuItem menuArchiveFilesPrintAnalyse;
        private System.Windows.Forms.TabPage pageAdminMaestro;
        private System.Windows.Forms.Panel panelAdminMaestro;
        private System.Windows.Forms.ToolStripLabel labelArchiveFileCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton buttonAdminAddDummyDetector;
        private System.Windows.Forms.FlowLayoutPanel flowMenu;
        private System.Windows.Forms.Button buttonMenuDetectors;
        private System.Windows.Forms.Button buttonMenuArchive;
        private System.Windows.Forms.FlowLayoutPanel flowMenuDetectors;
        private System.Windows.Forms.CheckBox cbAdminUseDafaultPrinter;
        private System.Windows.Forms.Button buttonMenuLibraries;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton buttonArchiveShowHistory;
        private System.Windows.Forms.ToolStripButton buttonArchiveSearch;
        private System.Windows.Forms.ToolStripButton buttonCreateJournal;
        private VintageControls.LabeledTextBox txtAnalVolume;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button buttonAnalRecalculate;
        private System.Windows.Forms.Panel panel1;
        private VintageControls.LabeledTextBox txtAnalDensity;
        private VintageControls.LabeledTextBox txtReAnalVolume;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonReAnalRecalculate;
        private VintageControls.LabeledTextBox txtReAnalDensity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton buttonLogSave;
        private VintageControls.LabeledCheckBox cbAdminICA;
        private VintageControls.LabeledCheckBox cbAnalICA;
        private VintageControls.LabeledCheckBox cbReAnalICA;
        private System.Windows.Forms.ToolStripButton buttonArchiveCreateBackground;
        private System.Windows.Forms.ToolStripMenuItem menuArchiveCreateBackground;
        private System.Windows.Forms.TabControl tabControlAdminScripts;
        private System.Windows.Forms.TabPage pageAdminScriptsBuffer;
        private System.Windows.Forms.TextBox txtAdminScriptsBuffer;
        private System.Windows.Forms.TabPage pageAdminScriptsStart;
        private System.Windows.Forms.TextBox txtAdminScriptsStart;
        private System.Windows.Forms.TabPage pageAdminScriptsStop;
        private System.Windows.Forms.TextBox txtAdminScriptsStop;
        private System.Windows.Forms.Panel panelAdminScriptsLeft;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabAdminGenie;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Button buttonAdminMaestroSetup;
        private System.Windows.Forms.Button buttonAdminScriptsSave;
        private System.Windows.Forms.Button buttonAdminGenieSetup;
        private System.Windows.Forms.CheckBox cbAdminBeakerMarinelli;
        private VintageControls.LabeledTextBox txtAdminBeakerInnerHeight;
        private VintageControls.LabeledTextBox txtAdminBeakerInnerRadius;
        private System.Windows.Forms.ColumnHeader headerInnerRadius;
        private System.Windows.Forms.ColumnHeader headerInnerHeight;
        private System.Windows.Forms.ColumnHeader headerType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAdminEmulateFixCHN;
        private System.Windows.Forms.Label labelAdminMaestroExecutable;
        private System.Windows.Forms.Label labelAdminMaestroConfig;
        private System.Windows.Forms.Label labelAdminGenieConfig;
        private System.Windows.Forms.Label labelAdminGenieFolder;
        private VintageControls.LabeledComboBox cboxAnalSignature;
        private VintageControls.LabeledComboBox cboxReAnalSignature;
    }
}

