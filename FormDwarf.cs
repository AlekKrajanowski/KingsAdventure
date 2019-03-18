using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KingsAdventure
{
    public partial class FormDwarf : Form
    {
        SqlConnection connection;
        public FormDwarf()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source = DATIX2\ALEKSANDERSQL; database=KingAdventure; Trusted_Connection=Yes");
            timerDwarfStats.Start();
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
        Dwarf dwarfik = new Dwarf();
        public static int sitelevel;
        
        // private int seed;

        /// <summary>
        /// Dzięki temu Buttonowi przechodzimy do FormularzaBattle, oraz zwiększamy odpowiednie zmienne 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBattleDwarf_Click(object sender, EventArgs e)
        {
            FormBattleDwarf formBattleDwarf = new FormBattleDwarf();
            formBattleDwarf.ShowDialog();
          
            dwarfik.money = dwarfik.money + 200;
            
   
            dwarfik.level = dwarfik.level +1 ;
           

            if (dwarfik.attack<=5)
            {
                dwarfik.board = 90 + dwarfik.stamina + dwarfik.defence; 
            }
            if (dwarfik.attack == 6 || dwarfik.attack == 7 || dwarfik.attack == 8 || dwarfik.attack == 9)
            {
                dwarfik.board = 75 + dwarfik.stamina + dwarfik.defence;
            }
            if (dwarfik.attack == 10 || dwarfik.attack == 11 || dwarfik.attack == 12 || dwarfik.attack == 13 || dwarfik.attack == 14)
            {
                dwarfik.board = 50 + dwarfik.stamina + dwarfik.defence;
            }
            if (dwarfik.attack == 15 || dwarfik.attack == 16 || dwarfik.attack == 17 || dwarfik.attack == 18 || dwarfik.attack == 19)
            {
                dwarfik.board = 30 + dwarfik.stamina + dwarfik.defence;
            }
            if (dwarfik.attack >= 20)
            {
                dwarfik.board = 10 + dwarfik.stamina + dwarfik.defence;
            }
            Random rand = new Random();
            int x = rand.Next(1, 100);
           
            if (x < dwarfik.board || x==dwarfik.board)
            {
                MessageBox.Show("Mission " + dwarfik.battle +  "Completed!!!!!");
                points = points + 1;
            }
            else
            {
                MessageBox.Show("Mission" + dwarfik.battle + " Failed!!!!!");
                points = points - 1;
                dwarfik.money = dwarfik.money - 200;
             
            }
            dwarfik.suma = (lvlarmor + lvlarmor1 + lvlarmor2 + lvlarmor3 + lvlarmor4);
            if (dwarfik.suma==5 || dwarfik.suma==10 || dwarfik.suma==15 || dwarfik.suma==20 || dwarfik.suma == 25)
            {
                points = points + 2;
            }

        }
        /// <summary>
        /// Opis Timera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDwarfStats_Tick(object sender, EventArgs e)
        {
            labelAttackDwarf.Text = dwarfik.attack.ToString();
            labelDefenceDwarf.Text = dwarfik.defence.ToString();
            labelStaminaDwarf.Text = dwarfik.stamina.ToString();
            labelLevelDwarf.Text = dwarfik.level.ToString();
            labelStatsDwarf.Text = points.ToString();
            labelDwarfMoney.Text = dwarfik.money.ToString();
            buttonBuyArmorDwarf.Text = valuearmor.ToString();
            buttonBuyHelmetDwarf.Text = valuearmor1.ToString();
            buttonBuyPantsDwarf.Text = valuearmor2.ToString();
            buttonBuyGlovesDwarf.Text = valuearmor3.ToString();
            buttonBuyBootsDwarf.Text = valuearmor4.ToString();
            if (dwarfik.level == 0 || dwarfik.level == 1)
            {
                labelDwarfAchivement.Text = "Podróżnik".ToString();
            }
            if (dwarfik.level == 2 || dwarfik.level == 3)
            {
                labelDwarfAchivement.Text = "Odkrywca".ToString();
            }
            if (dwarfik.level == 4 || dwarfik.level == 5)
            {
                labelDwarfAchivement.Text = "Zdobywca".ToString();
            }
            if (dwarfik.level == 6 || dwarfik.level == 7)
            {
                labelDwarfAchivement.Text = "Kolonista".ToString();
            }
            if (dwarfik.level == 8 || dwarfik.level == 9)
            {
                labelDwarfAchivement.Text = "Mistrz".ToString();
            }
            
            
           
           
            sitelevel = dwarfik.attack;
        }

        

       /// <summary>
       /// Przyciski dodawania i odejmowania punktów.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>

        private void buttonDwarfAttackPlus_Click(object sender, EventArgs e)
        {
            if(points>0)
            {
                dwarfik.attack = dwarfik.attack + 1;
                points = points - 1;
              
            }
        }
        private void buttonDwarfStaminaPlus_Click(object sender, EventArgs e)
        {
            if (points > 0)
            {
                dwarfik.stamina = dwarfik.stamina + 1;
                points = points - 1;
                
            }
        }

        private void buttonDwarfDefencePlus_Click(object sender, EventArgs e)
        {
            if (points > 0)
            {
                dwarfik.defence = dwarfik.defence + 1;
                points = points - 1;
                
            }
        }

        private void buttonDwarfAttackMinus_Click(object sender, EventArgs e)
        {
            if (dwarfik.attack > 0)
            {
                dwarfik.attack = dwarfik.attack - 1;
                points = points + 1;
            }
        }

        private void buttonDwarfStaminaMinus_Click(object sender, EventArgs e)
        {
            if (dwarfik.stamina > 0)
            {
                dwarfik.stamina = dwarfik.stamina - 1;
                points = points + 1;
            }
        }

        private void buttonDwarfDefenceMinus_Click(object sender, EventArgs e)
        {
            if (dwarfik.defence > 0)
            {
                dwarfik.defence = dwarfik.defence - 1;
                points = points + 1;
            }
        }
        /// <summary>
        /// Przycisk dzięki któremu załączmy drugą grę.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDwarfDualBattle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Alek\Desktop\Gra na PO\Game SKoczek\Skoczek.exe");
            dwarfik.money = dwarfik.money + 300;
        }
        /// <summary>
        /// Przycisk dzięki któremu zapisujemy dane naszej postaci po skończeniu gry. Dane są przenoszone do bazy danych.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveStatsDwarf_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect =
            new SqlConnection(@"Data Source = DATIX2\ALEKSANDERSQL; database = KingAdventure; Trusted_Connection=Yes");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"INSERT INTO Creature( Name, Attack, Stamina, Defence, Points, Lvl) VALUES ('" + dwarfik.name + "'," + labelAttackDwarf.Text + "," + labelStaminaDwarf.Text + "," + labelDefenceDwarf.Text + "," + labelStatsDwarf.Text + "," + labelLevelDwarf.Text +")";
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
        private void FormDwarf_Load(object sender, EventArgs e)
        {
            labelNameDwarf.Text = FormSelectClass.named;
            dwarfik.name = Form1.name;
            dwarfik.battle = FormBattleDwarf.battlename;
        }
           

        
        /// <summary>
        /// Button, po klinknięciu kupujemy zbroję
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyArmorDwarf_Click(object sender, EventArgs e)
        {
            if (dwarfik.money >= valuearmor)
            {
                dwarfik.money = dwarfik.money - valuearmor;
               
            }
            valuearmor = valuearmor + 250;


            lvlarmor ++;
            if (lvlarmor == 1)
            {
                checkBoxArmorDwarf1.Checked = true;
                
            }
            if (lvlarmor == 2)
            {
                checkBoxArmorDwarf2.Checked = true;
                
            }
            if (lvlarmor == 3)
            {
                checkBoxArmorDwarf3.Checked = true;
                
            }
            if (lvlarmor == 4)
            {
                checkBoxArmorDwarf4.Checked = true;
            }
            if (lvlarmor == 5)
            {
                checkBoxArmorDwarf5.Checked = true;
                buttonBuyArmorDwarf.Text = "MAX";
            }
           
        }
        /// <summary>
        /// kupowanie hełmu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyHelmetDwarf_Click(object sender, EventArgs e)
        {
            if (dwarfik.money >= valuearmor1)
            {
                dwarfik.money = dwarfik.money - valuearmor1;

            }
            valuearmor1 = valuearmor1 + 250;


            lvlarmor1++;
            if (lvlarmor1 == 1)
            {
                checkBoxHelmetDwarf1.Checked = true;

            }
            if (lvlarmor1 == 2)
            {
                checkBoxHelmetDwarf2.Checked = true;

            }
            if (lvlarmor1 == 3)
            {
                checkBoxHelmetDwarf3.Checked = true;

            }
            if (lvlarmor1 == 4)
            {
                checkBoxHelmetDwarf4.Checked = true;
            }
            if (lvlarmor1 == 5)
            {
                checkBoxHelmetDwarf5.Checked = true;
                buttonBuyHelmetDwarf.Text = "MAX";
            }
        }
        /// <summary>
        /// kupowanie spodni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyPantsDwarf_Click(object sender, EventArgs e)
        {
            if (dwarfik.money >= valuearmor2)
            {
                dwarfik.money = dwarfik.money - valuearmor2;

            }
            valuearmor2 = valuearmor2 + 250;


            lvlarmor2++;
            if (lvlarmor2 == 1)
            {
                checkBoxPantsDwarf1.Checked = true;

            }
            if (lvlarmor2 == 2)
            {
                checkBoxPantsDwarf2.Checked = true;

            }
            if (lvlarmor2 == 3)
            {
                checkBoxPantsDwarf3.Checked = true;

            }
            if (lvlarmor2 == 4)
            {
                checkBoxPantsDwarf4.Checked = true;
            }
            if (lvlarmor2 == 5)
            {
                checkBoxPantsDwarf5.Checked = true;
                buttonBuyPantsDwarf.Text = "MAX";
            }

        }
        /// <summary>
        /// kupowanie rękawic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyGlovesDwarf_Click(object sender, EventArgs e)
        {
            if (dwarfik.money >= valuearmor3)
            {
                dwarfik.money = dwarfik.money - valuearmor3;

            }
            valuearmor3 = valuearmor3 + 250;


            lvlarmor3++;
            if (lvlarmor3 == 1)
            {
                checkBoxGlovesDwarf1.Checked = true;

            }
            if (lvlarmor3 == 2)
            {
                checkBoxGlovesDwarf2.Checked = true;

            }
            if (lvlarmor3 == 3)
            {
                checkBoxGlovesDwarf3.Checked = true;

            }
            if (lvlarmor3 == 4)
            {
                checkBoxGlovesDwarf4.Checked = true;
            }
            if (lvlarmor3 == 5)
            {
                checkBoxGlovesDwarf5.Checked = true;
                buttonBuyGlovesDwarf.Text = "MAX";
            }
        }
        /// <summary>
        /// kupowanie butów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyBootsDwarf_Click(object sender, EventArgs e)
        {
            if (dwarfik.money >= valuearmor4)
            {
                dwarfik.money = dwarfik.money - valuearmor4;

            }
            valuearmor4 = valuearmor4 + 250;


            lvlarmor4++;
            if (lvlarmor4 == 1)
            {
                checkBoxBootsDwarf1.Checked = true;

            }
            if (lvlarmor4 == 2)
            {
                checkBoxBootsDwarf2.Checked = true;

            }
            if (lvlarmor4 == 3)
            {
                checkBoxBootsDwarf3.Checked = true;

            }
            if (lvlarmor4 == 4)
            {
                checkBoxBootsDwarf4.Checked = true;
            }
            if (lvlarmor4 == 5)
            {
                checkBoxBootsDwarf5.Checked = true;
                buttonBuyBootsDwarf.Text = "MAX";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dwarfik.money > 250)
            {
                points = points + 1;
                dwarfik.money = dwarfik.money - 250;

            }
        }
    }
}
