using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingsAdventure
{
    public partial class FormElf : Form
    {
        SqlConnection connection;
        public FormElf()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source = DATIX2\ALEKSANDERSQL; database=KingAdventure; Trusted_Connection=Yes");
            timerElfStats.Start();
        }
        /// <summary>
        /// zmienne globalne
        /// </summary>
        public int lvlarmor = 0;
        int valuearmor = 200;
        public int lvlarmor1 = 0;
        int valuearmor1 = 200;
        public int lvlarmor2 = 0;
        int valuearmor2 = 200;
        public int lvlarmor3 = 0;
        int valuearmor3 = 200;
        public int lvlarmor4 = 0;
        int valuearmor4 = 200;
        int points = 7;
    
        Elf elfik = new Elf();
        public static int sitelevel;
       
        private void buttonBattleElf_Click(object sender, EventArgs e)
        {
            FormBattleElf formBattleElf = new FormBattleElf();
            formBattleElf.ShowDialog();
            points = points + 1;
            elfik.money = elfik.money + 200;
            

            elfik.level = elfik.level + 1;
            int x;
            Random kostek = new Random();
            x = kostek.Next(1, 100);

            if (elfik.attack <= 5)
            {
                elfik.board = 90 + elfik.stamina + elfik.defence;
            }
            if (elfik.attack == 6 || elfik.attack == 7 || elfik.attack == 8 || elfik.attack == 9)
            {
                elfik.board = 75 + elfik.stamina + elfik.defence;
            }
            if (elfik.attack == 10 || elfik.attack == 11 || elfik.attack == 12 || elfik.attack == 13 || elfik.attack == 14)
            {
                elfik.board = 50 + elfik.stamina + elfik.defence;
            }
            if (elfik.attack == 15 || elfik.attack == 16 || elfik.attack == 17 || elfik.attack == 18 || elfik.attack == 19)
            {
                elfik.board = 30 + elfik.stamina + elfik.defence;
            }
            if (elfik.attack >= 20)
            {
                elfik.board = 10 + elfik.stamina + elfik.defence;
            }
            if (x <= elfik.board && x > 0)
            {
                MessageBox.Show("Mission " + elfik.battle + "Completed!!!!!");
            }
            if (x > elfik.board && x > 0)
            {
                MessageBox.Show("Mission" + elfik.battle + " Failed!!!!!");
                points = points - 1;
            }
            elfik.suma = (lvlarmor + lvlarmor1 + lvlarmor2 + lvlarmor3 + lvlarmor4);
            if (elfik.suma == 5 || elfik.suma == 10 || elfik.suma == 15 || elfik.suma == 20 || elfik.suma == 25)
            {
                points = points + 2;
            }
        }

        private void timerElfStats_Tick(object sender, EventArgs e)
        {
            labelAttackElf.Text = elfik.attack.ToString();
            labelDefenceElf.Text = elfik.defence.ToString();
            labelStaminaElf.Text = elfik.stamina.ToString();
            labelLevelElf.Text = elfik.level.ToString();
            labelStatsElf.Text = points.ToString();
            labelElfMoney.Text = elfik.money.ToString();
            buttonBuyArmorElf.Text = valuearmor.ToString();
            buttonBuyHelmetElf.Text = valuearmor1.ToString();
            buttonBuyPantsElf.Text = valuearmor2.ToString();
            buttonBuyGlovesElf.Text = valuearmor3.ToString();
            buttonBuyBootsElf.Text = valuearmor4.ToString();
            if (elfik.level == 0 || elfik.level == 1)
            {
                labelElfAchivement.Text = "Podróżnik".ToString();
            }
            if (elfik.level == 2 || elfik.level == 3)
            {
                labelElfAchivement.Text = "Odkrywca".ToString();
            }
            if (elfik.level == 4 || elfik.level == 5)
            {
                labelElfAchivement.Text = "Zdobywca".ToString();
            }
            if (elfik.level == 6 || elfik.level == 7)
            {
                labelElfAchivement.Text = "Kolonista".ToString();
            }
            if (elfik.level == 8 || elfik.level == 9)
            {
                labelElfAchivement.Text = "Mistrz".ToString();
            }
            sitelevel = elfik.attack;
        }


       

       
        private void buttonElfAttackPlus_Click(object sender, EventArgs e)
        {
            if (points > 0)
            {
                elfik.attack = elfik.attack + 1;
                points = points - 1;
              
            }
        }
        private void buttonElfStaminaPlus_Click(object sender, EventArgs e)
        {
            if (points > 0)
            {
                elfik.stamina = elfik.stamina + 1;
                points = points - 1;
                
            }
        }

        private void buttonElfDefencePlus_Click(object sender, EventArgs e)
        {

            if (points > 0)
            {elfik.defence = elfik.defence + 1;
                points = points - 1;
               
            }
        }
        private void buttonElfAttackMinus_Click(object sender, EventArgs e)
        {
            if (elfik.attack > 0)
            {
                elfik.stamina = elfik.stamina - 1;
                points = points + 1;
            }
        }

        private void buttonElffStaminaMinus_Click(object sender, EventArgs e)
        {
            if (elfik.stamina > 0)
            {
                elfik.stamina = elfik.stamina - 1;
                points = points + 1;
            }
        }

        private void buttonElfDefenceMinus_Click(object sender, EventArgs e)
        {
            if (elfik.attack > 0)
            {
                elfik.defence = elfik.defence - 1;
                points = points + 1;
            }
        }
  
        private void buttonElfDualBattle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Alek\Desktop\Projekt gry na PO\Gra na PO\Game SKoczek\Skoczek.exe");
        }
       
        private void buttonSaveStatsElf_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect =
           new SqlConnection(@"Data Source = DATIX2\ALEKSANDERSQL; database = KingAdventure; Trusted_Connection=Yes");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"INSERT INTO Creature( Name, Attack, Stamina, Defence, Points, Lvl) VALUES ('" + elfik.name + "'," + labelAttackElf.Text + "," + labelStaminaElf.Text + "," + labelDefenceElf.Text + "," + labelStatsElf.Text + "," + labelLevelElf.Text + ")";
            cmd.Connection = sqlConnect;

            sqlConnect.Open();
            cmd.ExecuteNonQuery();
            sqlConnect.Close();
        }
       
        private void FormElf_Load(object sender, EventArgs e)
        {
            labelNameElf.Text = FormSelectClass.named;
            elfik.name = Form1.name;
            elfik.battle = FormBattleElf.battlename;
        }


       


        private void IncreaseProgressBar(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Button, po klinknięciu kupujemy zbroję
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyArmorElf_Click(object sender, EventArgs e)
        {
            if (elfik.money >= 0)
            {
                elfik.money =elfik.money - valuearmor;

            }
            valuearmor = valuearmor + 250;


            lvlarmor++;
            if (lvlarmor == 1)
            {
                checkBoxArmorElf1.Checked = true;

            }
            if (lvlarmor == 2)
            {
                checkBoxArmorElf2.Checked = true;

            }
            if (lvlarmor == 3)
            {
                checkBoxArmorElf3.Checked = true;

            }
            if (lvlarmor == 4)
            {
                checkBoxArmorElf4.Checked = true;
            }
            if (lvlarmor == 5)
            {
                checkBoxArmorElf5.Checked = true;
                buttonBuyArmorElf.Text = "MAX";
            }

        }
       
        private void buttonBuyHelmetElf_Click(object sender, EventArgs e)
        {
            if (elfik.money >= 0)
            {
                elfik.money = elfik.money - valuearmor1;

            }
            valuearmor1 = valuearmor1 + 250;


            lvlarmor1++;
            if (lvlarmor1 == 1)
            {
                checkBoxHelmetElf1.Checked = true;

            }
            if (lvlarmor1 == 2)
            {
                checkBoxHelmetElf2.Checked = true;

            }
            if (lvlarmor1 == 3)
            {
                checkBoxHelmetElf3.Checked = true;

            }
            if (lvlarmor1 == 4)
            {
                checkBoxHelmetElf4.Checked = true;
            }
            if (lvlarmor1 == 5)
            {
                checkBoxHelmetElf5.Checked = true;
                buttonBuyHelmetElf.Text = "MAX";
            }
        }
       
        private void buttonBuyPantsElf_Click(object sender, EventArgs e)
        {
            if (elfik.money >= 0)
            {
                elfik.money = elfik.money - valuearmor2;

            }
            valuearmor2 = valuearmor2 + 250;


            lvlarmor2++;
            if (lvlarmor2 == 1)
            {
                checkBoxPantsElff1.Checked = true;

            }
            if (lvlarmor2 == 2)
            {
                checkBoxPantsElf2.Checked = true;

            }
            if (lvlarmor2 == 3)
            {
                checkBoxPantsElf3.Checked = true;

            }
            if (lvlarmor2 == 4)
            {
                checkBoxPantsElf4.Checked = true;
            }
            if (lvlarmor2 == 5)
            {
                checkBoxPantsElff5.Checked = true;
                buttonBuyPantsElf.Text = "MAX";
            }
        }
       
        private void buttonBuyGlovesElf_Click(object sender, EventArgs e)
        {
            if (elfik.money >= 0)
            {
                elfik.money = elfik.money - valuearmor3;

            }
            valuearmor3 = valuearmor3 + 250;


            lvlarmor3++;
            if (lvlarmor3 == 1)
            {
                checkBoxGlovesElf1.Checked = true;

            }
            if (lvlarmor3 == 2)
            {
                checkBoxGlovesElf2.Checked = true;

            }
            if (lvlarmor3 == 3)
            {
                checkBoxGlovesElf3.Checked = true;

            }
            if (lvlarmor3 == 4)
            {
                checkBoxGlovesElf4.Checked = true;
            }
            if (lvlarmor3 == 5)
            {
                checkBoxGlovesElf5.Checked = true;
                buttonBuyGlovesElf.Text = "MAX";
            }
        }
       
        private void buttonBuyBootsElf_Click(object sender, EventArgs e)
        {
            if (elfik.money >= 0)
            {
                elfik.money = elfik.money - valuearmor4;

            }
            valuearmor4 = valuearmor4 + 250;


            lvlarmor4++;
            if (lvlarmor4 == 1)
            {
                checkBoxBootsElf1.Checked = true;

            }
            if (lvlarmor4 == 2)
            {
                checkBoxBootsElf2.Checked = true;

            }
            if (lvlarmor4 == 3)
            {
                checkBoxBootsElf3.Checked = true;

            }
            if (lvlarmor4 == 4)
            {
                checkBoxBootsElf4.Checked = true;
            }
            if (lvlarmor4 == 5)
            {
                checkBoxBootsElf5.Checked = true;
                buttonBuyBootsElf.Text = "MAX";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (elfik.money > 250)
            {
                points = points + 1;
                elfik.money = elfik.money - 250;

            }
        }
    }
}
