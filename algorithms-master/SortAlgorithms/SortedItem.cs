using System.Drawing;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public class SortedItem
    {
        public SortedItem(int value)
        {
            Value = value;
            ProgressBar = new VerticalProgressBar();
            Label = new Label();

            ProgressBar.BorderStyle = BorderStyles.Classic;
            ProgressBar.Color = Color.Blue;
            ProgressBar.Location = new Point(14, 10);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(25, 112);
            ProgressBar.Step = 10;
            ProgressBar.Style = Styles.Solid;
            ProgressBar.TabIndex = 0;
            ProgressBar.Value = Value;
            Label.Location = new Point(14, 125);
            Label.Name = "Label";
            Label.Size = new Size(25, 23);
            Label.TabIndex = 1;
            Label.Text = Value.ToString();
        }

        public VerticalProgressBar ProgressBar { get; }
        public Label Label { get; }
        public int Value { get; set; }
    }
}