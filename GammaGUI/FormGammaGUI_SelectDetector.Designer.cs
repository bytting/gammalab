namespace GammaGUI
{
    partial class FormGammaGUI_SelectDetector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGammaGUI_SelectDetector));
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtYear = new VintageControls.LabeledTextBox();
            this.txtDetector = new VintageControls.LabeledTextBox();
            this.dialogCHNFile = new VintageControls.LabeledFileDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.status.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 186);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(333, 22);
            this.status.TabIndex = 0;
            this.status.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tools
            // 
            this.tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(333, 25);
            this.tools.TabIndex = 1;
            this.tools.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 135);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(305, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 135);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtYear);
            this.panel3.Controls.Add(this.txtDetector);
            this.panel3.Controls.Add(this.dialogCHNFile);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(25, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 135);
            this.panel3.TabIndex = 4;
            // 
            // txtYear
            // 
            this.txtYear.Caption = "Year";
            this.txtYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtYear.Enabled = false;
            this.txtYear.Location = new System.Drawing.Point(0, 42);
            this.txtYear.MaxStringLength = 2;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(280, 21);
            this.txtYear.TabIndex = 1;
            this.txtYear.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtYear.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // txtDetector
            // 
            this.txtDetector.Caption = "Detector";
            this.txtDetector.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDetector.Enabled = false;
            this.txtDetector.Location = new System.Drawing.Point(0, 21);
            this.txtDetector.MaxStringLength = 32767;
            this.txtDetector.Name = "txtDetector";
            this.txtDetector.Size = new System.Drawing.Size(280, 21);
            this.txtDetector.TabIndex = 4;
            this.txtDetector.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // dialogCHNFile
            // 
            this.dialogCHNFile.Caption = "CHN file";
            this.dialogCHNFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogCHNFile.Location = new System.Drawing.Point(0, 0);
            this.dialogCHNFile.Name = "dialogCHNFile";
            this.dialogCHNFile.Size = new System.Drawing.Size(280, 21);
            this.dialogCHNFile.TabIndex = 5;
            this.dialogCHNFile.ButtonClicked += new System.EventHandler(this.dialogCHNFile_ButtonClicked);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonOk);
            this.panel4.Controls.Add(this.buttonCancel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 26);
            this.panel4.TabIndex = 5;
            // 
            // buttonOk
            // 
            this.buttonOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOk.Location = new System.Drawing.Point(183, 0);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 26);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.Location = new System.Drawing.Point(258, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 26);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormGammaGUI_SelectDetector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 208);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGammaGUI_SelectDetector";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select CHN spectrum file to import";
            this.Load += new System.EventHandler(this.FormGammaGUI_SelectDetector_Load);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private VintageControls.LabeledTextBox txtYear;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private VintageControls.LabeledTextBox txtDetector;
        private VintageControls.LabeledFileDialog dialogCHNFile;
        private System.Windows.Forms.Button buttonCancel;
    }
}