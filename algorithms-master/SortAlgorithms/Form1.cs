using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        private readonly List<SortedItem> items = new List<SortedItem>();

        public Form1()
        {
            InitializeComponent();
        }


        private void addNumber_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBoxNumber.Text, out value))
            {
                var item = new SortedItem(value);
                items.Add(item);
                panel2.Controls.Add(item.ProgressBar);
                panel2.Controls.Add(item.Label);
            }

            textBoxNumber.Text = "";
        }

        private void addRandomNumber_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBoxRandomNubmer.Text, out value))
            {
                var random = new Random();
                for (var i = 0; i < value; i++)
                {
                    var item = new SortedItem(random.Next());
                    items.Add(item);
                    panel2.Controls.Add(item.ProgressBar);
                    panel2.Controls.Add(item.Label);
                }
            }

            textBoxRandomNubmer.Text = "";
        }
    }
}