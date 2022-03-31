using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PokeDecks
{
    public partial class Form2 : Form
    {
        public string poki = string.Empty;
        public ArrayList Pokies = new ArrayList();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Clear();
            for (int i = 0; i < Pokies.Count; i++)
            {
                Pokemon thing = (Pokemon)Pokies[i];
                if (thing.m_Name == poki)
                {
                    PokeNameTextbox.Text = thing.m_Name;
                    PokeTypeTextbox.Text = thing.m_Type;
                    PokeAbilityTextbox.Text = thing.m_Ability;
                    PokeDescriptionTextbox.Text = thing.m_Description;
                    PokePicture.ImageLocation = thing.m_Picture;
                    PokeHPTextbox.Text = thing.m_HP.ToString();
                    PokeNumber.Text = thing.m_Number.ToString().PadLeft(3, '0');

                }
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PokeDex form1 = new PokeDex();
            form1.Closed += (s, args) => this.Close();
            form1.ShowDialog();
        }
        private void Clear()
        {
            PokeAbilityTextbox.Text = string.Empty;
            PokeDescriptionTextbox.Text = string.Empty;
            PokeHPTextbox.Text = string.Empty;
            PokeNameTextbox.Text = string.Empty;
            PokePicture.Image = null;
            PokeTypeTextbox.Text = string.Empty;
        }
    }
}
