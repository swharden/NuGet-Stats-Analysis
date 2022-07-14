namespace NGSA.App;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.lbPackages = new System.Windows.Forms.CheckedListBox();
            this.cbPalette = new System.Windows.Forms.ComboBox();
            this.cbLog = new System.Windows.Forms.CheckBox();
            this.nudThickness = new System.Windows.Forms.NumericUpDown();
            this.cbAlign = new System.Windows.Forms.CheckBox();
            this.cbRate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudThickness)).BeginInit();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formsPlot1.Location = new System.Drawing.Point(167, 12);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(620, 397);
            this.formsPlot1.TabIndex = 0;
            // 
            // lbPackages
            // 
            this.lbPackages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPackages.CheckOnClick = true;
            this.lbPackages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPackages.FormattingEnabled = true;
            this.lbPackages.Location = new System.Drawing.Point(12, 12);
            this.lbPackages.Name = "lbPackages";
            this.lbPackages.Size = new System.Drawing.Size(148, 412);
            this.lbPackages.TabIndex = 1;
            this.lbPackages.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // cbPalette
            // 
            this.cbPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPalette.FormattingEnabled = true;
            this.cbPalette.Location = new System.Drawing.Point(167, 415);
            this.cbPalette.Name = "cbPalette";
            this.cbPalette.Size = new System.Drawing.Size(121, 23);
            this.cbPalette.TabIndex = 2;
            this.cbPalette.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbLog
            // 
            this.cbLog.AutoSize = true;
            this.cbLog.Location = new System.Drawing.Point(353, 417);
            this.cbLog.Name = "cbLog";
            this.cbLog.Size = new System.Drawing.Size(46, 19);
            this.cbLog.TabIndex = 3;
            this.cbLog.Text = "Log";
            this.cbLog.UseVisualStyleBackColor = true;
            this.cbLog.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nudThickness
            // 
            this.nudThickness.Location = new System.Drawing.Point(294, 415);
            this.nudThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThickness.Name = "nudThickness";
            this.nudThickness.Size = new System.Drawing.Size(53, 23);
            this.nudThickness.TabIndex = 4;
            this.nudThickness.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudThickness.ValueChanged += new System.EventHandler(this.nudThickness_ValueChanged);
            // 
            // cbAlign
            // 
            this.cbAlign.AutoSize = true;
            this.cbAlign.Location = new System.Drawing.Point(405, 417);
            this.cbAlign.Name = "cbAlign";
            this.cbAlign.Size = new System.Drawing.Size(54, 19);
            this.cbAlign.TabIndex = 5;
            this.cbAlign.Text = "Align";
            this.cbAlign.UseVisualStyleBackColor = true;
            this.cbAlign.CheckedChanged += new System.EventHandler(this.cbAlign_CheckedChanged);
            // 
            // cbRate
            // 
            this.cbRate.AutoSize = true;
            this.cbRate.Location = new System.Drawing.Point(465, 417);
            this.cbRate.Name = "cbRate";
            this.cbRate.Size = new System.Drawing.Size(49, 19);
            this.cbRate.TabIndex = 6;
            this.cbRate.Text = "Rate";
            this.cbRate.UseVisualStyleBackColor = true;
            this.cbRate.CheckedChanged += new System.EventHandler(this.cbRate_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbRate);
            this.Controls.Add(this.cbAlign);
            this.Controls.Add(this.nudThickness);
            this.Controls.Add(this.cbLog);
            this.Controls.Add(this.cbPalette);
            this.Controls.Add(this.lbPackages);
            this.Controls.Add(this.formsPlot1);
            this.Name = "Form1";
            this.Text = "NuGet Stats Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.nudThickness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private ScottPlot.FormsPlot formsPlot1;
    private CheckedListBox lbPackages;
    private ComboBox cbPalette;
    private CheckBox cbLog;
    private NumericUpDown nudThickness;
    private CheckBox cbAlign;
    private CheckBox cbRate;
}
