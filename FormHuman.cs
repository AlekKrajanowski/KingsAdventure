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
    public partial class FormHuman : Form
    {
        SqlConnection connection;
        public FormHuman()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source = DATIX2\ALEKSANDERSQL; database=KingAdventure; Trusted_Connection=Yes");
            timerHumanStats.Start();
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
        
        Human humanik = new Human();
        public static int sitelevel;
        /// <summary>
        /// Dzięki temu Buttonowi przechodzimy do FormularzaBattle, oraz zwiększamy odpowiednie zmienne 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBattleHuman_Click(object sender, EventArgs e)
        {
            FormBattleHuman formBattleHuman = new FormBattleHuman();
            formBattleHuman.ShowDialog();
            points = points + 1;
            humanik.money = humanik.money + 200;
           

            humanik.level = humanik.level + 1;
            int x;
            Random kostek = new Random();
            x = kostek.Next(1, 100);

            if (humanik.attack <= 5)
            {
                humanik.board = 90 + humanik.stamina + humanik.defence;
            }
            if (humanik.attack == 6 || humanik.attack == 7 || humanik.attack == 8 || humanik.attack == 9)
            {
                humanik.board = 75 + humanik.stamina + humanik.defence;
            }
            if (humanik.attack == 10 || humanik.attack == 11 || humanik.attack == 12 || humanik.attack == 13 || humanik.attack == 14)
            {
                humanik.board = 50 + humanik.stamina + humanik.defence;
            }
            if (humanik.attack == 15 || humanik.attack == 16 || humanik.attack == 17 || humanik.attack == 18 || humanik.attack == 19)
            {
                humanik.board = 30 + humanik.stamina + humanik.defence;
            }
            if (humanik.attack >= 20)
            {
                humanik.board = 10 + humanik.stamina + humanik.defence;
            }
            if (x <= humanik.board && x > 0)
            {
                MessageBox.Show("Mission " + humanik.battle + "Completed!!!!!");
            }
            if (x > humanik.board && x > 0)
            {
                MessageBox.Show("Mission" + humanik.battle + " Failed!!!!!");
                points = points - 1;
            }
            humanik.suma = (lvlarmor + lvlarmor1 + lvlarmor2 + lvlarmor3 + lvlarmor4);
            if (humanik.suma == 5 || humanik.suma == 10 || humanik.suma == 15 || humanik.suma == 20 || humanik.suma == 25)
            {
                points = points + 2;
            }


        }
        /// <summary>
        /// Opis Timera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerHumanStats_Tick(object sender, EventArgs e)
        {
            labelAttackHuman.Text = humanik.attack.ToString();
            labelDefenceHuman.Text = humanik.defence.ToString();
            labelStaminaHuman.Text = humanik.stamina.ToString();
            labelLevelHuman.Text = humanik.level.ToString();
            labelStatsHuman.Text = points.ToString();
            labelHumanMoney.Text = humanik.money.ToString();
            buttonBuyArmorHuman.Text = valuearmor.ToString();
            buttonBuyHelmetHuman.Text = valuearmor1.ToString();
            buttonBuyPantsHuman.Text = valuearmor2.ToString();
            buttonBuyGlovesHuman.Text = valuearmor3.ToString();
            buttonBuyBootsHuman.Text = valuearmor4.ToString();
            if (humanik.level == 0 || humanik.level == 1)
            {
                labelHumanAchivement.Text = "Podróżnik".ToString();
            }
            if (humanik.level == 2 || humanik.level == 3)
            {
                labelHumanAchivement.Text = "Odkrywca".ToString();
            }
            if (humanik.level == 4 || humanik.level == 5)
            {
                labelHumanAchivement.Text = "Zdobywca".ToString();
            }
            if (humanik.level == 6 || humanik.level == 7)
            {
                labelHumanAchivement.Text = "Kolonista".ToString();
            }
            if (humanik.level == 8 || humanik.level == 9)
            {
                labelHumanAchivement.Text = "Mistrz".ToString();
            }
            sitelevel = humanik.attack;
        }

       

        /// <summary>
        /// Przyciski dodawania i odejmowania punktów.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonHumanAttackPlus_Click(object sender, EventArgs e)
        {
            if (points > 0 )
            {
                humanik.attack = humanik.attack + 1;
                points = points - 1;
                
            }
        }
        private void buttonHumanStaminaPlus_Click(object sender, EventArgs e)
        {
            if (points > 0)
            {
                humanik.stamina = humanik.stamina + 1;
                points = points - 1;
               
            }
        }

        private void buttonHumanDefencePlus_Click(object sender, EventArgs e)
        {
            if (points > 0)
            {
                humanik.defence = humanik.defence + 1;
                points = points - 1;
               
            }
        }

        private void buttonHumanAttackMinus_Click(object sender, EventArgs e)
        {
            if (humanik.attack > 0)
            {
                humanik.attack = humanik.attack - 1;
                points = points + 1;
            }
        }

        private void buttonHumanStaminaMinus_Click(object sender, EventArgs e)
        {
            if (humanik.stamina > 0)
            {
                humanik.stamina = humanik.stamina - 1;
                points = points + 1;
            }
        }

        private void buttonHumanDefenceMinus_Click(object sender, EventArgs e)
        {
            if (humanik.defence > 0)
            {
                humanik.defence = humanik.defence - 1;
                points = points + 1;
            }
        }
        /// <summary>
        /// Przycisk dzięki któremu załączmy drugą grę.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHumanDualBattle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Alek\Desktop\Gra na PO\Game SKoczek\Skoczek.exe");
        }
        /// <summary>
        /// Przycisk dzięki któremu zapisujemy dane naszej postaci po skończeniu gry. Dane są przenoszone do bazy danych.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveStatsHuman_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect =
            new SqlConnection(@"Data Source = DATIX2\ALEKSANDERSQL; database = KingAdventure; Trusted_Connection=Yes");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"INSERT INTO Creature( Name, Attack, Stamina, Defence, Points, Lvl) VALUES ('" + humanik.name + "'," + labelAttackHuman.Text + "," + labelStaminaHuman.Text + "," + labelDefenceHuman.Text + "," + labelStatsHuman.Text + "," + labelLevelHuman.Text + ")";
            cmd.Connection = sqlConnect;

            sqlConnect.Open();
            cmd.ExecuteNonQuery();
            sqlConnect.Close();
        }
        /// <summary>
        /// Ładowanie nazwy postaci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormHuman_Load(object sender, EventArgs e)
        {
            labelNameHuman.Text = FormSelectClass.named;
            humanik.name = Form1.name;
            humanik.battle = FormBattleHuman.battlename;
        }


        
        /// <summary>
        /// Button, po klinknięciu kupujemy zbroję
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyArmorHuman_Click(object sender, EventArgs e)
        {
            if (humanik.money >= 0)
            {
                humanik.money = humanik.money - valuearmor;

            }
            valuearmor = valuearmor + 250;


            lvlarmor++;
            if (lvlarmor == 1)
            {
                checkBoxArmorHuman1.Checked = true;

            }
            if (lvlarmor == 2)
            {
                checkBoxArmorHuman2.Checked = true;

            }
            if (lvlarmor == 3)
            {
                checkBoxArmorHuman3.Checked = true;

            }
            if (lvlarmor == 4)
            {
                checkBoxArmorHuman4.Checked = true;
            }
            if (lvlarmor == 5)
            {
                checkBoxArmorHuman5.Checked = true;
                buttonBuyArmorHuman.Text = "MAX";
            }

        }
        /// <summary>
        /// kupowanie hełmu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyHelmetHuman_Click(object sender, EventArgs e)
        {
            if (humanik.money >= 0)
            {
                humanik.money = humanik.money - valuearmor1;

            }
            valuearmor1 = valuearmor1 + 250;


            lvlarmor1++;
            if (lvlarmor1 == 1)
            {
                checkBoxHelmetHuman1.Checked = true;

            }
            if (lvlarmor1 == 2)
            {
                checkBoxHelmetHuman2.Checked = true;

            }
            if (lvlarmor1 == 3)
            {
                checkBoxHelmetHuman3.Checked = true;

            }
            if (lvlarmor1 == 4)
            {
                checkBoxHelmetHuman4.Checked = true;
            }
            if (lvlarmor1 == 5)
            {
                checkBoxHelmetHuman5.Checked = true;
                buttonBuyHelmetHuman.Text = "MAX";
            }
        }
        /// <summary>
        /// kupowanie spodni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyPantsHuman_Click(object sender, EventArgs e)
        {
            if (humanik.money >= 0)
            {
                humanik.money = humanik.money - valuearmor2;

            }
            valuearmor2 = valuearmor2 + 250;


            lvlarmor2++;
            if (lvlarmor2 == 1)
            {
                checkBoxPantsHuman1.Checked = true;

            }
            if (lvlarmor2 == 2)
            {
                checkBoxPantsHuman2.Checked = true;

            }
            if (lvlarmor2 == 3)
            {
                checkBoxPantsHuman3.Checked = true;

            }
            if (lvlarmor2 == 4)
            {
                checkBoxPantsHuman4.Checked = true;
            }
            if (lvlarmor2 == 5)
            {
                checkBoxPantsHuman5.Checked = true;
                buttonBuyPantsHuman.Text = "MAX";
            }

        }
        /// <summary>
        /// kupowanie rękawic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyGlovesHuman_Click(object sender, EventArgs e)
        {
            if (humanik.money >= 0)
            {
                humanik.money = humanik.money - valuearmor3;

            }
            valuearmor3 = valuearmor3 + 250;


            lvlarmor3++;
            if (lvlarmor3 == 1)
            {
                checkBoxGlovesHuman1.Checked = true;

            }
            if (lvlarmor3 == 2)
            {
                checkBoxGlovesHuman2.Checked = true;

            }
            if (lvlarmor3 == 3)
            {
                checkBoxGlovesHuman3.Checked = true;

            }
            if (lvlarmor3 == 4)
            {
                checkBoxGlovesHuman4.Checked = true;
            }
            if (lvlarmor3 == 5)
            {
                checkBoxGlovesHuman5.Checked = true;
                buttonBuyGlovesHuman.Text = "MAX";
            }
        }
        /// <summary>
        /// kupowanie butów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyBootsHuman_Click(object sender, EventArgs e)
        {
            if (humanik.money >= 0)
            {
                humanik.money = humanik.money - valuearmor4;

            }
            valuearmor4 = valuearmor4 + 250;


            lvlarmor4++;
            if (lvlarmor4 == 1)
            {
                checkBoxBootsHuman1.Checked = true;

            }
            if (lvlarmor4 == 2)
            {
                checkBoxBootsHuman2.Checked = true;

            }
            if (lvlarmor4 == 3)
            {
                checkBoxBootsHuman3.Checked = true;

            }
            if (lvlarmor4 == 4)
            {
                checkBoxBootsHuman4.Checked = true;
            }
            if (lvlarmor4 == 5)
            {
                checkBoxBootsHuman5.Checked = true;
                buttonBuyBootsHuman.Text = "MAX";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (humanik.money > 250)
            {
                points = points + 1;
                humanik.money = humanik.money - 250;

            }
        }
    }
}
