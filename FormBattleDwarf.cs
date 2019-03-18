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
    public partial class FormBattleDwarf : Form
    {
        
        public FormBattleDwarf()
        {
            InitializeComponent();

            time.time = 1000 + (100*time.level);
            
            
        }
        Dwarf time = new Dwarf();
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
        
        private void timerBattleDwarf_Tick(object sender, EventArgs e)
        {
            if (time.level <= 5)
            {
                labelDwarfBattleMissonName.Text = "  Wzgórza Hotamu ".ToString();
            }
            if (time.level==6 || time.level == 7 || time.level == 8 || time.level == 9)
            {
                labelDwarfBattleMissonName.Text = "  Cieśnina Bólu ".ToString();
            }
            if (time.level == 10 || time.level == 11 || time.level == 12 || time.level == 13 || time.level == 14)
            {
                labelDwarfBattleMissonName.Text = "  Jaskinie Trolli ".ToString();
            }
            if (time.level == 15 || time.level == 16 || time.level == 17 || time.level == 18 || time.level == 19)
            {
                labelDwarfBattleMissonName.Text = "  Głębokie Kopalnie ".ToString();
            }
            if (time.level >= 20)
            {
                labelDwarfBattleMissonName.Text = "  Opuszczone Królestwo krasnoludów ".ToString();
            }
            battlename = labelDwarfBattleMissonName.Text;
        }

        private async void buttonStartBattleDwarf_Click(object sender, EventArgs e)
          

        {

            time.level = time.level + 1;
            timerBattleDwarf.Start();
            List<string> list = new List<string>();
            for (int i = 0; i < time.time; i++)
               
                
                list.Add(i.ToString());
            labelBattleDwarfProgress.Text = "Working...";
            var progress = new Progress<ProgressBar>();
            progress.ProgressChanged += (o, report) =>
            {
                labelBattleDwarfProgress.Text = string.Format("{0}%", report.PercentComplete);
                progressBarBattleDwarf.Value = report.PercentComplete;
                progressBarBattleDwarf.Update();
            };
            await ProcessData(list, progress);
            labelBattleDwarfProgress.Text = "DONE !!";
            Close();


           
        }

        private void FormBattleDwarf_Load(object sender, EventArgs e)
        {
            time.level = FormDwarf.sitelevel;
        }
    }
}
