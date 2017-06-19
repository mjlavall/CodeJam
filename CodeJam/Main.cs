using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeJam
{
    public partial class Main : Form
    {
        public List<string> Input { get; set; }
        public Main()
        {
            InitializeComponent();
        }

        private void ofdButton_Click(object sender, EventArgs e)
        {
            Input = null;
            var ofd = new OpenFileDialog
            {
                Title = "Select and input file",
                Filter = "Input File | *.in",
                InitialDirectory = @"C:\Users\mlavalley\Downloads"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var filename = ofd.FileName;
                Input = File.ReadAllLines(filename).ToList();
                ofdTextBox.Text = Path.GetFileNameWithoutExtension(filename);
            }
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            var timer = System.Diagnostics.Stopwatch.StartNew();
            timeLabel.Text = "";
            statusLabel.Text = "Processing...";
            solveButton.Enabled = false;
            if (Input == null) return;
            var problem = new _2017.QualA(Input);
            var sfd = new SaveFileDialog
            {
                FileName = $"{ofdTextBox.Text}-solution.txt",
                Filter = "Text File | *.txt"
            };
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                var solution = problem.Solve();
                using (var writer = new StreamWriter(sfd.OpenFile()))
                {
                    foreach(var line in solution)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            solveButton.Enabled = true;
            statusLabel.Text = "Solved";
            timer.Stop();
            timeLabel.Text = timer.Elapsed.ToString("mm':'ss'.'fff");
        }
    }
}
