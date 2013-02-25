namespace GammaGUI
{
    partial class FormGammaGUI_ArchiveSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGammaGUI_ArchiveSearch));
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.txtToken = new VintageControls.LabeledTextBox();
            this.cboxField = new VintageControls.LabeledComboBox();
            this.cboxYear = new VintageControls.LabeledComboBox();
            this.cboxDetector = new VintageControls.LabeledComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.status.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 184);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(352, 22);
            this.status.TabIndex = 0;
            this.status.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tools
            // 
            this.tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(352, 25);
            this.tools.TabIndex = 1;
            this.tools.Text = "toolStrip1";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelCenter);
            this.panelMain.Controls.Add(this.panelRight);
            this.panelMain.Controls.Add(this.panelLeft);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(352, 159);
            this.panelMain.TabIndex = 2;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.panel2);
            this.panelCenter.Controls.Add(this.txtToken);
            this.panelCenter.Controls.Add(this.cboxField);
            this.panelCenter.Controls.Add(this.cboxYear);
            this.panelCenter.Controls.Add(this.cboxDetector);
            this.panelCenter.Controls.Add(this.panel1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(30, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(292, 159);
            this.panelCenter.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 26);
            this.panel2.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSearch.Location = new System.Drawing.Point(142, 0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 26);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.Location = new System.Drawing.Point(217, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 26);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // txtToken
            // 
            this.txtToken.Caption = "Token";
            this.txtToken.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtToken.Location = new System.Drawing.Point(0, 83);
            this.txtToken.MaxStringLength = 40;
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(292, 21);
            this.txtToken.TabIndex = 4;
            // 
            // cboxField
            // 
            this.cboxField.Caption = "Field";
            this.cboxField.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxField.Location = new System.Drawing.Point(0, 62);
            this.cboxField.Name = "cboxField";
            this.cboxField.Size = new System.Drawing.Size(292, 21);
            this.cboxField.TabIndex = 3;
            // 
            // cboxYear
            // 
            this.cboxYear.Caption = "Year";
            this.cboxYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxYear.Location = new System.Drawing.Point(0, 41);
            this.cboxYear.Name = "cboxYear";
            this.cboxYear.Size = new System.Drawing.Size(292, 21);
            this.cboxYear.TabIndex = 6;
            // 
            // cboxDetector
            // 
            this.cboxDetector.Caption = "Detector";
            this.cboxDetector.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxDetector.Location = new System.Drawing.Point(0, 20);
            this.cboxDetector.Name = "cboxDetector";
            this.cboxDetector.Size = new System.Drawing.Size(292, 21);
            this.cboxDetector.TabIndex = 1;
            this.cboxDetector.SelectedValueChanged += new System.EventHandler(this.cboxDetector_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 20);
            this.panel1.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(322, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(30, 159);
            this.panelRight.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(30, 159);
            this.panelLeft.TabIndex = 0;
            // 
            // FormGammaGUI_ArchiveSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 206);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGammaGUI_ArchiveSearch";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search archive";
            this.Load += new System.EventHandler(this.FormGammaGUI_ArchiveSearch_Load);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private VintageControls.LabeledTextBox txtToken;
        private VintageControls.LabeledComboBox cboxField;
        private VintageControls.LabeledComboBox cboxDetector;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonCancel;
        private VintageControls.LabeledComboBox cboxYear;
    }
}