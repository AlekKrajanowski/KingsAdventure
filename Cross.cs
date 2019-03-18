using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingsAdventure
{
    public partial class Cross : Form
    {
        public Cross()
        {
            InitializeComponent();

        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormSelectClass formSelectClass = new FormSelectClass();
            formSelectClass.ShowDialog();
        }
        
        private Task ProcessData(List<string> list, IProgress<ProgressBar> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var progressReport = new ProgressBar();
            return Task.Run(() =>
            {
                for (int i = 0; i < totalProcess; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(progressReport);
                    Thread.Sleep(10);
                }
            });
        }

        private async void Cross_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 1000; i++)


                list.Add(i.ToString());
            buttonClose.Text = "Loading...";
            var progress = new Progress<ProgressBar>();
            progress.ProgressChanged += (o, report) =>
            {
                progressBarClose.Text = string.Format("{0}%", report.PercentComplete);
                progressBarClose.Value = report.PercentComplete;
                progressBarClose.Update();
            };
            await ProcessData(list, progress);
            buttonClose.Text = "CLOSE";

        }
    }
}
