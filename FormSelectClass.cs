using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingsAdventure
{
    public partial class FormSelectClass : Form
    {
        public static string named;
        public FormSelectClass()
        {
            InitializeComponent();
        }
      
        private void pictureBoxHumanName_Click(object sender, EventArgs e)
        {
            FormHuman formHuman = new FormHuman();
            formHuman.ShowDialog();
          
        }

        private void pictureBoxElfName_Click(object sender, EventArgs e)
        {
            FormElf formElf = new FormElf();
            formElf.ShowDialog();
           
        }

        private void pictureBoxDwarfName_Click(object sender, EventArgs e)
        {
            FormDwarf formDwarf = new FormDwarf();
            formDwarf.ShowDialog();
           
        }

        private void FormSelectClass_Load(object sender, EventArgs e)
        {

        }

        private void buttonSaveSelect_Click(object sender, EventArgs e)
        {
            named = textBoxSelectClass.Text;
        }
    }
}
