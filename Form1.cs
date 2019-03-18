using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingsAdventure
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }
        
        public static string name;
        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            
            name = textBoxLogin.Text;

        }

        private void buttonInstruction_Click(object sender, EventArgs e)
        {
            FormInstruction formInstruction = new FormInstruction();
            formInstruction.ShowDialog();

        }

        private void buttonTopGamers_Click(object sender, EventArgs e)
        {
            TopGamers topGamers = new TopGamers();
            topGamers.ShowDialog();

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            Cross formCross = new Cross();
            formCross.ShowDialog();
        }
    }
}
