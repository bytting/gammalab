namespace GammaGUI
{
    partial class FormGammaGUI_AnalResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGammaGUI_AnalResult));
            this.status = new System.Windows.Forms.StatusStrip();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.buttonShowSpectrum = new System.Windows.Forms.ToolStripButton();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.cbReject = new System.Windows.Forms.CheckBox();
            this.cbPlot = new System.Windows.Forms.CheckBox();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageGammaOutput = new System.Windows.Forms.TabPage();
            this.txtGammaOutput = new System.Windows.Forms.TextBox();
            this.pageLisOutput = new System.Windows.Forms.TabPage();
            this.txtLISOutput = new System.Windows.Forms.TextBox();
            this.pageINPOutput = new System.Windows.Forms.TabPage();
            this.txtINPOutput = new System.Windows.Forms.TextBox();
            this.tools.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.pageGammaOutput.SuspendLayout();
            this.pageLisOutput.SuspendLayout();
            this.pageINPOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(0, 446);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(790, 22);
            this.status.SizingGrip = false;
            this.status.TabIndex = 0;
            this.status.Text = "statusStrip1";
            // 
            // tools
            // 
            this.tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonShowSpectrum});
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(790, 25);
            this.tools.TabIndex = 1;
            this.tools.Text = "toolStrip1";
            // 
            // buttonShowSpectrum
            // 
            this.buttonShowSpectrum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonShowSpectrum.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowSpectrum.Image")));
            this.buttonShowSpectrum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonShowSpectrum.Name = "buttonShowSpectrum";
            this.buttonShowSpectrum.Size = new System.Drawing.Size(116, 22);
            this.buttonShowSpectrum.Text = "Show Spectrum";
            this.buttonShowSpectrum.Click += new System.EventHandler(this.buttonShowSpectrum_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.cbReject);
            this.panelBottom.Controls.Add(this.cbPlot);
            this.panelBottom.Controls.Add(this.buttonFinish);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 421);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(790, 25);
            this.panelBottom.TabIndex = 2;
            // 
            // cbReject
            // 
            this.cbReject.AutoSize = true;
            this.cbReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReject.Location = new System.Drawing.Point(577, 5);
            this.cbReject.Name = "cbReject";
            this.cbReject.Size = new System.Drawing.Size(104, 17);
            this.cbReject.TabIndex = 2;
            this.cbReject.Text = "Reject results";
            this.cbReject.UseVisualStyleBackColor = true;
            this.cbReject.CheckedChanged += new System.EventHandler(this.cbReject_CheckedChanged);
            // 
            // cbPlot
            // 
            this.cbPlot.AutoSize = true;
            this.cbPlot.Checked = true;
            this.cbPlot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlot.Location = new System.Drawing.Point(483, 5);
            this.cbPlot.Name = "cbPlot";
            this.cbPlot.Size = new System.Drawing.Size(77, 17);
            this.cbPlot.TabIndex = 1;
            this.cbPlot.Text = "Print plot";
            this.cbPlot.UseVisualStyleBackColor = true;
            // 
            // buttonFinish
            // 
            this.buttonFinish.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinish.Location = new System.Drawing.Point(700, 0);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(90, 25);
            this.buttonFinish.TabIndex = 0;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tabControl);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(790, 396);
            this.panelMain.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageGammaOutput);
            this.tabControl.Controls.Add(this.pageLisOutput);
            this.tabControl.Controls.Add(this.pageINPOutput);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(790, 396);
            this.tabControl.TabIndex = 0;
            // 
            // pageGammaOutput
            // 
            this.pageGammaOutput.Controls.Add(this.txtGammaOutput);
            this.pageGammaOutput.Location = new System.Drawing.Point(4, 22);
            this.pageGammaOutput.Name = "pageGammaOutput";
            this.pageGammaOutput.Padding = new System.Windows.Forms.Padding(3);
            this.pageGammaOutput.Size = new System.Drawing.Size(782, 370);
            this.pageGammaOutput.TabIndex = 0;
            this.pageGammaOutput.Text = "Gamma output";
            this.pageGammaOutput.UseVisualStyleBackColor = true;
            // 
            // txtGammaOutput
            // 
            this.txtGammaOutput.BackColor = System.Drawing.SystemColors.Info;
            this.txtGammaOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGammaOutput.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGammaOutput.Location = new System.Drawing.Point(3, 3);
            this.txtGammaOutput.Multiline = true;
            this.txtGammaOutput.Name = "txtGammaOutput";
            this.txtGammaOutput.ReadOnly = true;
            this.txtGammaOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGammaOutput.Size = new System.Drawing.Size(776, 364);
            this.txtGammaOutput.TabIndex = 0;
            this.txtGammaOutput.WordWrap = false;
            // 
            // pageLisOutput
            // 
            this.pageLisOutput.Controls.Add(this.txtLISOutput);
            this.pageLisOutput.Location = new System.Drawing.Point(4, 22);
            this.pageLisOutput.Name = "pageLisOutput";
            this.pageLisOutput.Padding = new System.Windows.Forms.Padding(3);
            this.pageLisOutput.Size = new System.Drawing.Size(782, 370);
            this.pageLisOutput.TabIndex = 1;
            this.pageLisOutput.Text = "LIS output";
            this.pageLisOutput.UseVisualStyleBackColor = true;
            // 
            // txtLISOutput
            // 
            this.txtLISOutput.BackColor = System.Drawing.SystemColors.Info;
            this.txtLISOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLISOutput.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLISOutput.Location = new System.Drawing.Point(3, 3);
            this.txtLISOutput.Multiline = true;
            this.txtLISOutput.Name = "txtLISOutput";
            this.txtLISOutput.ReadOnly = true;
            this.txtLISOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLISOutput.Size = new System.Drawing.Size(776, 364);
            this.txtLISOutput.TabIndex = 1;
            this.txtLISOutput.WordWrap = false;
            // 
            // pageINPOutput
            // 
            this.pageINPOutput.Controls.Add(this.txtINPOutput);
            this.pageINPOutput.Location = new System.Drawing.Point(4, 22);
            this.pageINPOutput.Name = "pageINPOutput";
            this.pageINPOutput.Padding = new System.Windows.Forms.Padding(3);
            this.pageINPOutput.Size = new System.Drawing.Size(782, 370);
            this.pageINPOutput.TabIndex = 2;
            this.pageINPOutput.Text = "INP output";
            this.pageINPOutput.UseVisualStyleBackColor = true;
            // 
            // txtINPOutput
            // 
            this.txtINPOutput.BackColor = System.Drawing.SystemColors.Info;
            this.txtINPOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtINPOutput.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtINPOutput.Location = new System.Drawing.Point(3, 3);
            this.txtINPOutput.Multiline = true;
            this.txtINPOutput.Name = "txtINPOutput";
            this.txtINPOutput.ReadOnly = true;
            this.txtINPOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtINPOutput.Size = new System.Drawing.Size(776, 364);
            this.txtINPOutput.TabIndex = 2;
            this.txtINPOutput.WordWrap = false;
            // 
            // FormGammaGUI_AnalResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 468);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGammaGUI_AnalResult";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Analysis result";
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.pageGammaOutput.ResumeLayout(false);
            this.pageGammaOutput.PerformLayout();
            this.pageLisOutput.ResumeLayout(false);
            this.pageLisOutput.PerformLayout();
            this.pageINPOutput.ResumeLayout(false);
            this.pageINPOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageGammaOutput;
        private System.Windows.Forms.TextBox txtGammaOutput;
        private System.Windows.Forms.TabPage pageLisOutput;
        private System.Windows.Forms.TextBox txtLISOutput;
        private System.Windows.Forms.TabPage pageINPOutput;
        private System.Windows.Forms.TextBox txtINPOutput;
        private System.Windows.Forms.CheckBox cbReject;
        private System.Windows.Forms.CheckBox cbPlot;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.ToolStripButton buttonShowSpectrum;
    }
}