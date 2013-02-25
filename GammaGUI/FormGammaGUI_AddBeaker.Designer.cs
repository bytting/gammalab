namespace GammaGUI
{
    partial class FormGammaGUI_AddBeaker
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
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtComment = new VintageControls.LabeledTextBox();
            this.txtManufacturer = new VintageControls.LabeledTextBox();
            this.txtMaxFillHeight = new VintageControls.LabeledTextBox();
            this.txtMinFillHeight = new VintageControls.LabeledTextBox();
            this.txtInnerHeight = new VintageControls.LabeledTextBox();
            this.txtInnerRadius = new VintageControls.LabeledTextBox();
            this.cbMarinelli = new System.Windows.Forms.CheckBox();
            this.txtHeight = new VintageControls.LabeledTextBox();
            this.txtRadius = new VintageControls.LabeledTextBox();
            this.txtName = new VintageControls.LabeledTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.status.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 514);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(424, 22);
            this.status.TabIndex = 0;
            this.status.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 42);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCreate);
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 489);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 25);
            this.panel2.TabIndex = 2;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCreate.Location = new System.Drawing.Point(274, 0);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 25);
            this.buttonCreate.TabIndex = 1;
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
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 447);
            this.panel3.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtComment);
            this.panel6.Controls.Add(this.txtManufacturer);
            this.panel6.Controls.Add(this.txtMaxFillHeight);
            this.panel6.Controls.Add(this.txtMinFillHeight);
            this.panel6.Controls.Add(this.txtInnerHeight);
            this.panel6.Controls.Add(this.txtInnerRadius);
            this.panel6.Controls.Add(this.cbMarinelli);
            this.panel6.Controls.Add(this.txtHeight);
            this.panel6.Controls.Add(this.txtRadius);
            this.panel6.Controls.Add(this.txtName);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(30, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(364, 447);
            this.panel6.TabIndex = 2;
            // 
            // txtComment
            // 
            this.txtComment.Caption = "Comment";
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtComment.Location = new System.Drawing.Point(0, 185);
            this.txtComment.MaxStringLength = 256;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(364, 21);
            this.txtComment.TabIndex = 9;
            this.txtComment.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Caption = "Manufacturer";
            this.txtManufacturer.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtManufacturer.Location = new System.Drawing.Point(0, 164);
            this.txtManufacturer.MaxStringLength = 80;
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(364, 21);
            this.txtManufacturer.TabIndex = 8;
            this.txtManufacturer.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // txtMaxFillHeight
            // 
            this.txtMaxFillHeight.Caption = "Max fill height (mm)";
            this.txtMaxFillHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMaxFillHeight.Location = new System.Drawing.Point(0, 143);
            this.txtMaxFillHeight.MaxStringLength = 30;
            this.txtMaxFillHeight.Name = "txtMaxFillHeight";
            this.txtMaxFillHeight.Size = new System.Drawing.Size(364, 21);
            this.txtMaxFillHeight.TabIndex = 7;
            this.txtMaxFillHeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtMaxFillHeight.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtMaxFillHeight.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtMinFillHeight
            // 
            this.txtMinFillHeight.Caption = "Min fill height (mm)";
            this.txtMinFillHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMinFillHeight.Location = new System.Drawing.Point(0, 122);
            this.txtMinFillHeight.MaxStringLength = 30;
            this.txtMinFillHeight.Name = "txtMinFillHeight";
            this.txtMinFillHeight.Size = new System.Drawing.Size(364, 21);
            this.txtMinFillHeight.TabIndex = 6;
            this.txtMinFillHeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtMinFillHeight.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtMinFillHeight.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtInnerHeight
            // 
            this.txtInnerHeight.Caption = "Inner height (mm)";
            this.txtInnerHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtInnerHeight.Enabled = false;
            this.txtInnerHeight.Location = new System.Drawing.Point(0, 101);
            this.txtInnerHeight.MaxStringLength = 32767;
            this.txtInnerHeight.Name = "txtInnerHeight";
            this.txtInnerHeight.Size = new System.Drawing.Size(364, 21);
            this.txtInnerHeight.TabIndex = 5;
            this.txtInnerHeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtInnerHeight.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtInnerHeight.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtInnerRadius
            // 
            this.txtInnerRadius.Caption = "Inner radius (mm)";
            this.txtInnerRadius.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtInnerRadius.Enabled = false;
            this.txtInnerRadius.Location = new System.Drawing.Point(0, 80);
            this.txtInnerRadius.MaxStringLength = 32767;
            this.txtInnerRadius.Name = "txtInnerRadius";
            this.txtInnerRadius.Size = new System.Drawing.Size(364, 21);
            this.txtInnerRadius.TabIndex = 4;
            this.txtInnerRadius.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtInnerRadius.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtInnerRadius.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // cbMarinelli
            // 
            this.cbMarinelli.AutoSize = true;
            this.cbMarinelli.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbMarinelli.Location = new System.Drawing.Point(0, 63);
            this.cbMarinelli.Name = "cbMarinelli";
            this.cbMarinelli.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.cbMarinelli.Size = new System.Drawing.Size(364, 17);
            this.cbMarinelli.TabIndex = 3;
            this.cbMarinelli.Text = "Marinelli beaker";
            this.cbMarinelli.UseVisualStyleBackColor = true;
            this.cbMarinelli.CheckedChanged += new System.EventHandler(this.cbMarinelli_CheckedChanged);
            // 
            // txtHeight
            // 
            this.txtHeight.Caption = "Height (mm)";
            this.txtHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHeight.Location = new System.Drawing.Point(0, 42);
            this.txtHeight.MaxStringLength = 30;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(364, 21);
            this.txtHeight.TabIndex = 2;
            this.txtHeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtHeight.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtHeight.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtRadius
            // 
            this.txtRadius.Caption = "Radius (mm)";
            this.txtRadius.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRadius.Location = new System.Drawing.Point(0, 21);
            this.txtRadius.MaxStringLength = 30;
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(364, 21);
            this.txtRadius.TabIndex = 1;
            this.txtRadius.TextBackColor = System.Drawing.SystemColors.Window;
            this.txtRadius.KeyWasPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            this.txtRadius.Leave += new System.EventHandler(this.Numeric_Leave);
            // 
            // txtName
            // 
            this.txtName.Caption = "Name";
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.Location = new System.Drawing.Point(0, 0);
            this.txtName.MaxStringLength = 2;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(364, 21);
            this.txtName.TabIndex = 0;
            this.txtName.TextBackColor = System.Drawing.SystemColors.Window;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(394, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 447);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 447);
            this.panel4.TabIndex = 0;
            // 
            // FormGammaGUI_AddBeaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 536);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGammaGUI_AddBeaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create new beaker";
            this.Load += new System.EventHandler(this.FormGammaGUI_AddBeaker_Load);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
        private VintageControls.LabeledTextBox txtRadius;
        private VintageControls.LabeledTextBox txtName;
        private VintageControls.LabeledTextBox txtHeight;
        private VintageControls.LabeledTextBox txtMaxFillHeight;
        private VintageControls.LabeledTextBox txtMinFillHeight;
        private VintageControls.LabeledTextBox txtManufacturer;
        private VintageControls.LabeledTextBox txtComment;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.CheckBox cbMarinelli;
        private VintageControls.LabeledTextBox txtInnerRadius;
        private VintageControls.LabeledTextBox txtInnerHeight;
    }
}