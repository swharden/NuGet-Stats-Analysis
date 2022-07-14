namespace NGSA.App;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        string sampleDataFolder = Path.GetFullPath("../../../../../data/history/");
        UpdateListOfPalettes();
        UpdatePackageList(sampleDataFolder);
        UpdatePlot();
    }

    private void UpdateListOfPalettes()
    {
        string[] colormapNames = ScottPlot.Palette.GetPalettes().Select(x => x.Name).ToArray();
        cbPalette.Items.AddRange(colormapNames);
        cbPalette.SelectedIndex = Array.IndexOf(colormapNames, "Category10");
    }

    private void UpdatePackageList(string dataFolder)
    {
        if (!Directory.Exists(dataFolder))
        {
            throw new DirectoryNotFoundException();
        }

        foreach (string path in Directory.GetFiles(dataFolder, "*.json"))
        {
            lbPackages.Items.Add(new JsonHistoryFile(path), isChecked: true);
        }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) => UpdatePlot();

    private void checkBox1_CheckedChanged(object sender, EventArgs e) => UpdatePlot();

    private void nudThickness_ValueChanged(object sender, EventArgs e) => UpdatePlot();

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) => UpdatePlot();

    private void cbAlign_CheckedChanged(object sender, EventArgs e) => UpdatePlot();

    private void cbRate_CheckedChanged(object sender, EventArgs e) => UpdatePlot();

    private void UpdatePlot()
    {
        formsPlot1.Plot.Palette = ScottPlot.Palette.GetPalettes().First(x => x.Name == cbPalette.SelectedItem.ToString());

        formsPlot1.Plot.Clear();

        foreach (JsonHistoryFile jf in lbPackages.CheckedItems)
        {
            double[] xs = cbAlign.Checked ? jf.DeltaXs : jf.Xs;

            double[] ys = cbRate.Checked ? jf.YsPerWeek : jf.Ys;
            if (cbLog.Checked)
                ys = ys.Select(x => Math.Log10(x)).ToArray();

            var sig = formsPlot1.Plot.AddSignalXY(xs, ys);
            sig.Label = jf.ToString();
            sig.LineWidth = (int)(nudThickness.Value);
        }

        Func<double, string> yTickFormatter = cbLog.Checked
            ? (y) => Math.Pow(10, y).ToString("N0")
            : (y) => y.ToString("N0");

        formsPlot1.Plot.YAxis.Label(cbRate.Checked ? "Downloads / week" : "Total Downloads");
        formsPlot1.Plot.YAxis.TickLabelFormat(yTickFormatter);
        formsPlot1.Plot.YAxis.MinorLogScale(cbLog.Checked);
        formsPlot1.Plot.XAxis.Label(cbAlign.Checked ? "Days Since First Upload" : "Update Date");
        formsPlot1.Plot.XAxis.DateTimeFormat(!cbAlign.Checked);

        formsPlot1.Plot.AxisAuto();
        formsPlot1.Plot.Legend(true, ScottPlot.Alignment.UpperLeft);
        formsPlot1.Refresh();
    }
}
