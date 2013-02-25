namespace GammaGUI
{
    partial class FormGammaGUI_AddDetector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGammaGUI_AddDetector));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxComment = new VintageControls.LabeledTextBox();
            this.dialogEnergyCalFile = new VintageControls.LabeledFileDialog();
            this.dialogBackgroundFile = new VintageControls.LabeledFileDialog();
            this.textBoxLOCH = new VintageControls.LabeledTextBox();
            this.textBoxETOL = new VintageControls.LabeledTextBox();
            this.textBoxBSTF = new VintageControls.LabeledTextBox();
            this.cbICA = new VintageControls.LabeledCheckBox();
            this.textBoxTHRESH = new VintageControls.LabeledTextBox();
            this.textBoxFWHMAN = new VintageControls.LabeledTextBox();
            this.textBoxFWHMPS = new VintageControls.LabeledTextBox();
            this.cboxResolutionUnit = new VintageControls.LabeledComboBox();
            this.textBoxResolution = new VintageControls.LabeledTextBox();
            this.textBoxEfficiency = new VintageControls.LabeledTextBox();
            this.textBoxManufacturer = new VintageControls.LabeledTextBox();
            this.cboxBytesPerRecord = new VintageControls.LabeledComboBox();
            this.cboxMethod = new VintageControls.LabeledComboBox();
            this.cboxFormat = new VintageControls.LabeledComboBox();
            this.cboxChannels = new VintageControls.LabeledComboBox();
            this.textBoxID = new VintageControls.LabeledTextBox();
            this.textBoxName = new VintageControls.LabeledTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboxSpectrumSoftware = new VintageControls.LabeledComboBox();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 511);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(424, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCreate);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 25);
            this.panel1.TabIndex = 12;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCreate.Location = new System.Drawing.Point(274, 0);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 25);
            this.buttonCreate.TabIndex = 11;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.Location = new System.Drawing.Point(349, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 25);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 42);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 444);
            this.panel3.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBoxComment);
            this.panel6.Controls.Add(this.dialogEnergyCalFile);
            this.panel6.Controls.Add(this.dialogBackgroundFile);
            this.panel6.Controls.Add(this.textBoxLOCH);
            this.panel6.Controls.Add(this.textBoxETOL);
            this.panel6.Controls.Add(this.textBoxBSTF);
            this.panel6.Controls.Add(this.cbICA);
            this.panel6.Controls.Add(this.textBoxTHRESH);
            this.panel6.Controls.Add(this.textBoxFWHMAN);
            this.panel6.Controls.Add(this.textBoxFWHMPS);
            this.panel6.Controls.Add(this.cboxResolutionUnit);
            this.panel6.Controls.Add(this.textBoxResolution);
            this.panel6.Controls.Add(this.textBoxEfficiency);
            this.panel6.Controls.Add(this.textBoxManufacturer);
            this.panel6.Controls.Add(this.cboxBytesPerRecord);
            this.panel6.Controls.Add(this.cboxMethod);
            this.panel6.Controls.Add(this.cboxFormat);
            this.panel6.Controls.Add(this.cboxChannels);
            this.panel6.Controls.Add(this.textBoxID);
            this.panel6.Controls.Add(this.cboxSpectrumSoftware);
            this.panel6.Controls.Add(this.textBoxName);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(30, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(364, 444);
            this.panel6.TabIndex = 2;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Caption = "Comment";
            this.textBoxComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxComment.Location = new System.Drawing.Point(0, 420);
            this.textBoxComment.MaxStringLength = 256;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(364, 21);
            this.textBoxComment.TabIndex = 41;
            this.textBoxComment.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // dialogEnergyCalFile
            // 
            this.dialogEnergyCalFile.Caption = "Energy calib. file";
            this.dialogEnergyCalFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogEnergyCalFile.Location = new System.Drawing.Point(0, 399);
            this.dialogEnergyCalFile.Name = "dialogEnergyCalFile";
            this.dialogEnergyCalFile.Size = new System.Drawing.Size(364, 21);
            this.dialogEnergyCalFile.TabIndex = 40;
            this.dialogEnergyCalFile.ButtonClicked += new System.EventHandler(this.dialogEnergyCalFile_ButtonClicked);
            // 
            // dialogBackgroundFile
            // 
            this.dialogBackgroundFile.Caption = "Background file";
            this.dialogBackgroundFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogBackgroundFile.Location = new System.Drawing.Point(0, 378);
            this.dialogBackgroundFile.Name = "dialogBackgroundFile";
            this.dialogBackgroundFile.Size = new System.Drawing.Size(364, 21);
            this.dialogBackgroundFile.TabIndex = 39;
            this.dialogBackgroundFile.ButtonClicked += new System.EventHandler(this.dialogBackgroundFile_ButtonClicked);
            // 
            // textBoxLOCH
            // 
            this.textBoxLOCH.Caption = "LOCH";
            this.textBoxLOCH.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxLOCH.Location = new System.Drawing.Point(0, 357);
            this.textBoxLOCH.MaxStringLength = 30;
            this.textBoxLOCH.Name = "textBoxLOCH";
            this.textBoxLOCH.Size = new System.Drawing.Size(364, 21);
            this.textBoxLOCH.TabIndex = 38;
            this.textBoxLOCH.TextBackColor = System.Drawing.SystemColors.Window;
            this.textBoxLOCH.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.textBoxLOCH.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // textBoxETOL
            // 
            this.textBoxETOL.Caption = "ETOL";
            this.textBoxETOL.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxETOL.Location = new System.Drawing.Point(0, 336);
            this.textBoxETOL.MaxStringLength = 30;
            this.textBoxETOL.Name = "textBoxETOL";
            this.textBoxETOL.Size = new System.Drawing.Size(364, 21);
            this.textBoxETOL.TabIndex = 37;
            this.textBoxETOL.TextBackColor = System.Drawing.SystemColors.Window;
            this.textBoxETOL.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.textBoxETOL.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // textBoxBSTF
            // 
            this.textBoxBSTF.Caption = "BSTF";
            this.textBoxBSTF.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxBSTF.Location = new System.Drawing.Point(0, 315);
            this.textBoxBSTF.MaxStringLength = 30;
            this.textBoxBSTF.Name = "textBoxBSTF";
            this.textBoxBSTF.Size = new System.Drawing.Size(364, 21);
            this.textBoxBSTF.TabIndex = 36;
            this.textBoxBSTF.TextBackColor = System.Drawing.SystemColors.Window;
            this.textBoxBSTF.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.textBoxBSTF.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // cbICA
            // 
            this.cbICA.Caption = "ICA";
            this.cbICA.Checked = true;
            this.cbICA.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbICA.Location = new System.Drawing.Point(0, 294);
            this.cbICA.Name = "cbICA";
            this.cbICA.Size = new System.Drawing.Size(364, 21);
            this.cbICA.TabIndex = 43;
            // 
            // textBoxTHRESH
            // 
            this.textBoxTHRESH.Caption = "THRESH";
            this.textBoxTHRESH.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTHRESH.Location = new System.Drawing.Point(0, 273);
            this.textBoxTHRESH.MaxStringLength = 30;
            this.textBoxTHRESH.Name = "textBoxTHRESH";
            this.textBoxTHRESH.Size = new System.Drawing.Size(364, 21);
            this.textBoxTHRESH.TabIndex = 34;
            this.textBoxTHRESH.TextBackColor = System.Drawing.SystemColors.Window;
            this.textBoxTHRESH.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.textBoxTHRESH.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // textBoxFWHMAN
            // 
            this.textBoxFWHMAN.Caption = "FWHMAN";
            this.textBoxFWHMAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxFWHMAN.Location = new System.Drawing.Point(0, 252);
            this.textBoxFWHMAN.MaxStringLength = 30;
            this.textBoxFWHMAN.Name = "textBoxFWHMAN";
            this.textBoxFWHMAN.Size = new System.Drawing.Size(364, 21);
            this.textBoxFWHMAN.TabIndex = 33;
            this.textBoxFWHMAN.TextBackColor = System.Drawing.SystemColors.Window;
            this.textBoxFWHMAN.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.textBoxFWHMAN.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // textBoxFWHMPS
            // 
            this.textBoxFWHMPS.Caption = "FWHMPS";
            this.textBoxFWHMPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxFWHMPS.Location = new System.Drawing.Point(0, 231);
            this.textBoxFWHMPS.MaxStringLength = 30;
            this.textBoxFWHMPS.Name = "textBoxFWHMPS";
            this.textBoxFWHMPS.Size = new System.Drawing.Size(364, 21);
            this.textBoxFWHMPS.TabIndex = 32;
            this.textBoxFWHMPS.TextBackColor = System.Drawing.SystemColors.Window;
            this.textBoxFWHMPS.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.textBoxFWHMPS.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // cboxResolutionUnit
            // 
            this.cboxResolutionUnit.Caption = "Resolution unit";
            this.cboxResolutionUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxResolutionUnit.Location = new System.Drawing.Point(0, 210);
            this.cboxResolutionUnit.Name = "cboxResolutionUnit";
            this.cboxResolutionUnit.Size = new System.Drawing.Size(364, 21);
            this.cboxResolutionUnit.TabIndex = 31;
            // 
            // textBoxResolution
            // 
            this.textBoxResolution.Caption = "Resolution";
            this.textBoxResolution.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxResolution.Location = new System.Drawing.Point(0, 189);
            this.textBoxResolution.MaxStringLength = 30;
            this.textBoxResolution.Name = "textBoxResolution";
            this.textBoxResolution.Size = new System.Drawing.Size(364, 21);
            this.textBoxResolution.TabIndex = 30;
            this.textBoxResolution.TextBackColor = System.Drawing.SystemColors.Window;
            this.textBoxResolution.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.textBoxResolution.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // textBoxEfficiency
            // 
            this.textBoxEfficiency.Caption = "Efficiency";
            this.textBoxEfficiency.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxEfficiency.Location = new System.Drawing.Point(0, 168);
            this.textBoxEfficiency.MaxStringLength = 30;
            this.textBoxEfficiency.Name = "textBoxEfficiency";
            this.textBoxEfficiency.Size = new System.Drawing.Size(364, 21);
            this.textBoxEfficiency.TabIndex = 29;
            this.textBoxEfficiency.TextBackColor = System.Drawing.SystemColors.Window;
            this.textBoxEfficiency.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.textBoxEfficiency.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Caption = "Manufacturer";
            this.textBoxManufacturer.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxManufacturer.Location = new System.Drawing.Point(0, 147);
            this.textBoxManufacturer.MaxStringLength = 80;
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(364, 21);
            this.textBoxManufacturer.TabIndex = 27;
            this.textBoxManufacturer.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // cboxBytesPerRecord
            // 
            this.cboxBytesPerRecord.Caption = "Record length";
            this.cboxBytesPerRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxBytesPerRecord.Location = new System.Drawing.Point(0, 126);
            this.cboxBytesPerRecord.Name = "cboxBytesPerRecord";
            this.cboxBytesPerRecord.Size = new System.Drawing.Size(364, 21);
            this.cboxBytesPerRecord.TabIndex = 26;
            // 
            // cboxMethod
            // 
            this.cboxMethod.Caption = "Analysis method";
            this.cboxMethod.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxMethod.Location = new System.Drawing.Point(0, 105);
            this.cboxMethod.Name = "cboxMethod";
            this.cboxMethod.Size = new System.Drawing.Size(364, 21);
            this.cboxMethod.TabIndex = 42;
            // 
            // cboxFormat
            // 
            this.cboxFormat.Caption = "Format";
            this.cboxFormat.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxFormat.Location = new System.Drawing.Point(0, 84);
            this.cboxFormat.Name = "cboxFormat";
            this.cboxFormat.Size = new System.Drawing.Size(364, 21);
            this.cboxFormat.TabIndex = 25;
            // 
            // cboxChannels
            // 
            this.cboxChannels.Caption = "Channels";
            this.cboxChannels.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxChannels.Location = new System.Drawing.Point(0, 63);
            this.cboxChannels.Name = "cboxChannels";
            this.cboxChannels.Size = new System.Drawing.Size(364, 21);
            this.cboxChannels.TabIndex = 24;
            // 
            // textBoxID
            // 
            this.textBoxID.Caption = "Maestro ID";
            this.textBoxID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxID.Location = new System.Drawing.Point(0, 42);
            this.textBoxID.MaxStringLength = 32767;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(364, 21);
            this.textBoxID.TabIndex = 23;
            this.textBoxID.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // textBoxName
            // 
            this.textBoxName.Caption = "Name";
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxName.Location = new System.Drawing.Point(0, 0);
            this.textBoxName.MaxStringLength = 32767;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(364, 21);
            this.textBoxName.TabIndex = 22;
            this.textBoxName.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(394, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 444);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 444);
            this.panel4.TabIndex = 0;
            // 
            // cboxSpectrumSoftware
            // 
            this.cboxSpectrumSoftware.Caption = "Spectrum software";
            this.cboxSpectrumSoftware.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxSpectrumSoftware.Location = new System.Drawing.Point(0, 21);
            this.cboxSpectrumSoftware.Name = "cboxSpectrumSoftware";
            this.cboxSpectrumSoftware.Size = new System.Drawing.Size(364, 21);
            this.cboxSpectrumSoftware.TabIndex = 44;
            this.cboxSpectrumSoftware.SelectedValueChanged += new System.EventHandler(this.cboxSpectrumSoftware_SelectedValueChanged);
            // 
            // FormGammaGUI_AddDetector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 533);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGammaGUI_AddDetector";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create new detector";
            this.Load += new System.EventHandler(this.FormGammaGUI_AddDetector_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private VintageControls.LabeledTextBox textBoxComment;
        private VintageControls.LabeledFileDialog dialogEnergyCalFile;
        private VintageControls.LabeledFileDialog dialogBackgroundFile;
        private VintageControls.LabeledTextBox textBoxLOCH;
        private VintageControls.LabeledTextBox textBoxETOL;
        private VintageControls.LabeledTextBox textBoxBSTF;
        private VintageControls.LabeledTextBox textBoxTHRESH;
        private VintageControls.LabeledTextBox textBoxFWHMAN;
        private VintageControls.LabeledTextBox textBoxFWHMPS;
        private VintageControls.LabeledComboBox cboxResolutionUnit;
        private VintageControls.LabeledTextBox textBoxResolution;
        private VintageControls.LabeledTextBox textBoxEfficiency;
        private VintageControls.LabeledTextBox textBoxManufacturer;
        private VintageControls.LabeledComboBox cboxBytesPerRecord;
        private VintageControls.LabeledComboBox cboxMethod;
        private VintageControls.LabeledComboBox cboxFormat;
        private VintageControls.LabeledComboBox cboxChannels;
        private VintageControls.LabeledTextBox textBoxID;
        private VintageControls.LabeledTextBox textBoxName;
        private VintageControls.LabeledCheckBox cbICA;
        private VintageControls.LabeledComboBox cboxSpectrumSoftware;
    }
}