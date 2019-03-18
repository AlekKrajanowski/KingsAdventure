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
    public partial class FormBattleElf : Form
    {
        public FormBattleElf()
        {
            InitializeComponent();
           
            time.time = 1000 + (100 * time.level);

        }
        Elf time = new Elf();
        public static string battlename;

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
    
        private void timerBattleElf_Tick(object sender, EventArgs e)
        {


            if (time.level <= 5)
            {
                labelElfBattleMissonName.Text = "   Polana Spokoju ".ToString();
            }
            if (time.level == 6 || time.level == 7 || time.level == 8 || time.level == 9)
            {
                labelElfBattleMissonName.Text = "  Brzeg Lasu ".ToString();
            }
            if (time.level == 10 || time.level == 11 || time.level == 12 || time.level == 13 || time.level == 14)
            {
                labelElfBattleMissonName.Text = "  Zagajnik ".ToString();
            }
            if (time.level == 15 || time.level == 16 || time.level == 17 || time.level == 18 || time.level == 19)
            {
                labelElfBattleMissonName.Text = "  Mroczna Puszcza ".ToString();
            }
            if (time.level >= 20)
            {
                labelElfBattleMissonName.Text = "  Centrum Lasu ".ToString();
            }
            battlename = labelElfBattleMissonName.Text;
        }

        private async void buttonStartBattleElf_Click(object sender, EventArgs e)


        {


            timerBattleElf.Start();
            List<string> list = new List<string>();
            for (int i = 0; i < time.time; i++)


                list.Add(i.ToString());
            labelBattleElfProgress.Text = "Working...";
            var progress = new Progress<ProgressBar>();
            progress.ProgressChanged += (o, report) =>
            {
                labelBattleElfProgress.Text = string.Format("{0}%", report.PercentComplete);
                progressBarBattleElf.Value = report.PercentComplete;
                progressBarBattleElf.Update();
            };
            await ProcessData(list, progress);
            labelBattleElfProgress.Text = "DONE !!";
            Close();


        }

        private void FormBattleElf_Load(object sender, EventArgs e)
        {
            time.level = FormElf.sitelevel;
        }

        private void labelBattleElfProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
