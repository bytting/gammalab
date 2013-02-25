namespace GammaGUI
{
    partial class FormGammaGUI_ShowSpec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGammaGUI_ShowSpec));
            this.toolsSpec = new System.Windows.Forms.ToolStrip();
            this.buttonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonZoomOutAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.labelRealTime = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.labelLiveTime = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.labelDeadTime = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.labelNumChannels = new System.Windows.Forms.ToolStripLabel();
            this.status = new System.Windows.Forms.StatusStrip();
            this.labelMeasurementDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelDummy1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelEditChannelCaption = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelEditChannel = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelEditCountCaption = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelEditCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.graph = new ZedGraph.ZedGraphControl();
            this.toolsSpec.SuspendLayout();
            this.status.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolsSpec
            // 
            this.toolsSpec.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsSpec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonClose,
            this.toolStripSeparator3,
            this.buttonZoomOutAll,
            this.toolStripSeparator2,
            this.labelRealTime,
            this.toolStripSeparator4,
            this.labelLiveTime,
            this.toolStripSeparator1,
            this.labelDeadTime,
            this.toolStripSeparator5,
            this.labelNumChannels});
            this.toolsSpec.Location = new System.Drawing.Point(0, 0);
            this.toolsSpec.Name = "toolsSpec";
            this.toolsSpec.Size = new System.Drawing.Size(934, 25);
            this.toolsSpec.TabIndex = 0;
            this.toolsSpec.Text = "toolStrip1";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(56, 22);
            this.buttonClose.Text = "Close";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonZoomOutAll
            // 
            this.buttonZoomOutAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonZoomOutAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonZoomOutAll.Image")));
            this.buttonZoomOutAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonZoomOutAll.Name = "buttonZoomOutAll";
            this.buttonZoomOutAll.Size = new System.Drawing.Size(59, 22);
            this.buttonZoomOutAll.Text = "Reset";
            this.buttonZoomOutAll.Click += new System.EventHandler(this.buttonZoomOutAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // labelRealTime
            // 
            this.labelRealTime.Name = "labelRealTime";
            this.labelRealTime.Size = new System.Drawing.Size(81, 22);
            this.labelRealTime.Text = "labelRealTime";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // labelLiveTime
            // 
            this.labelLiveTime.Name = "labelLiveTime";
            this.labelLiveTime.Size = new System.Drawing.Size(80, 22);
            this.labelLiveTime.Text = "labelLiveTime";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // labelDeadTime
            // 
            this.labelDeadTime.Name = "labelDeadTime";
            this.labelDeadTime.Size = new System.Drawing.Size(86, 22);
            this.labelDeadTime.Text = "labelDeadTime";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // labelNumChannels
            // 
            this.labelNumChannels.Name = "labelNumChannels";
            this.labelNumChannels.Size = new System.Drawing.Size(108, 22);
            this.labelNumChannels.Text = "labelNumChannels";
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelMeasurementDate,
            this.labelDummy1,
            this.labelEditChannelCaption,
            this.labelEditChannel,
            this.labelEditCountCaption,
            this.labelEditCount});
            this.status.Location = new System.Drawing.Point(0, 490);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(934, 22);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // labelMeasurementDate
            // 
            this.labelMeasurementDate.Name = "labelMeasurementDate";
            this.labelMeasurementDate.Size = new System.Drawing.Size(129, 17);
            this.labelMeasurementDate.Text = "labelMeasurementDate";
            // 
            // labelDummy1
            // 
            this.labelDummy1.Name = "labelDummy1";
            this.labelDummy1.Size = new System.Drawing.Size(25, 17);
            this.labelDummy1.Text = "      ";
            // 
            // labelEditChannelCaption
            // 
            this.labelEditChannelCaption.Name = "labelEditChannelCaption";
            this.labelEditChannelCaption.Size = new System.Drawing.Size(0, 17);
            // 
            // labelEditChannel
            // 
            this.labelEditChannel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelEditChannel.Name = "labelEditChannel";
            this.labelEditChannel.Size = new System.Drawing.Size(0, 17);
            // 
            // labelEditCountCaption
            // 
            this.labelEditCountCaption.Name = "labelEditCountCaption";
            this.labelEditCountCaption.Size = new System.Drawing.Size(0, 17);
            // 
            // labelEditCount
            // 
            this.labelEditCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelEditCount.Name = "labelEditCount";
            this.labelEditCount.Size = new System.Drawing.Size(0, 17);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.graph);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(934, 465);
            this.panelMain.TabIndex = 3;
            // 
            // graph
            // 
            this.graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graph.IsAutoScrollRange = true;
            this.graph.IsEnableVPan = false;
            this.graph.IsEnableVZoom = false;
            this.graph.IsShowHScrollBar = true;
            this.graph.IsShowVScrollBar = true;
            this.graph.Location = new System.Drawing.Point(0, 0);
            this.graph.Name = "graph";
            this.graph.ScrollGrace = 0D;
            this.graph.ScrollMaxX = 0D;
            this.graph.ScrollMaxY = 0D;
            this.graph.ScrollMaxY2 = 0D;
            this.graph.ScrollMinX = 0D;
            this.graph.ScrollMinY = 0D;
            this.graph.ScrollMinY2 = 0D;
            this.graph.Size = new System.Drawing.Size(934, 465);
            this.graph.TabIndex = 0;
            // 
            // FormGammaGUI_ShowSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.status);
            this.Controls.Add(this.toolsSpec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormGammaGUI_ShowSpec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormGammaGUI_ShowSpec_Load);
            this.toolsSpec.ResumeLayout(false);
            this.toolsSpec.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolsSpec;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.Panel panelMain;
        private ZedGraph.ZedGraphControl graph;
        private System.Windows.Forms.ToolStripLabel labelRealTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel labelLiveTime;
        private System.Windows.Forms.ToolStripButton buttonZoomOutAll;
        private System.Windows.Forms.ToolStripButton buttonClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel labelNumChannels;
        private System.Windows.Forms.ToolStripLabel labelDeadTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel labelMeasurementDate;
        private System.Windows.Forms.ToolStripStatusLabel labelEditChannelCaption;
        private System.Windows.Forms.ToolStripStatusLabel labelEditChannel;
        private System.Windows.Forms.ToolStripStatusLabel labelEditCountCaption;
        private System.Windows.Forms.ToolStripStatusLabel labelEditCount;
        private System.Windows.Forms.ToolStripStatusLabel labelDummy1;
    }
}