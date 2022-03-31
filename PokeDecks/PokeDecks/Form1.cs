using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Console;

namespace PokeDecks
{
    public partial class PokeDex : Form
    {
        string poke = string.Empty;
        public ArrayList Pokies = new ArrayList();
        int currentIndex = 0;
        public PokeDex()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("Pokemon.json");
            while (reader.Peek() > -1)
            {
                Pokies.Add(JsonSerializer.Deserialize<Pokemon>(reader.ReadLine()));
            }
            reader.Close();
                NavigationReader(0);
            
        }
        private void OnClick_Click(object sender, EventArgs e)
        {
            PictureBox b = (PictureBox)sender;
            for (int i = 0; i < Pokies.Count; i++)
            {
                Pokemon thing = (Pokemon)Pokies[i];
                if (thing.m_Picture == b.ImageLocation)
                {
                    Form2 form2 = new Form2();
                    this.Hide();
                    form2.poki = thing.m_Name;
                    form2.Pokies = Pokies;
                    form2.Closed += (s, args) => this.Close();
                    form2.ShowDialog();
                    form2.Location = this.Location;

                }
            }
        }
        private void NavigationReader(int index)
        {
            if (index >= 0 && index < Pokies.Count)
            {
                
                Pokemon p = (Pokemon)Pokies[index];
                NameLabelSave1.Text = p.m_Name;
                NumberLabelSave1.Text = NumberFormat(p.m_Number);
                PictureSave1.ImageLocation = p.m_Picture;
                if (index + 1 < Pokies.Count)
                {
                    p = (Pokemon)Pokies[index + 1];
                    if (p != null)
                    {
                        NameLabelSave2.Text = p.m_Name;
                        NumberLabelSave2.Text = NumberFormat(p.m_Number);
                        PictureSave2.ImageLocation = p.m_Picture;
                    }
                    else
                    {
                        NumberLabelSave2.Text = NumberFormat(p.m_Number);
                    }

                }
                if (index + 2 < Pokies.Count)
                {
                    p = (Pokemon)Pokies[index + 2];
                    if (p != null)
                    {
                        NameLabelSave3.Text = p.m_Name;
                        NumberLabelSave3.Text = NumberFormat(p.m_Number);
                        PictureSave3.ImageLocation = p.m_Picture;
                    }
                }
                if (index + 3 < Pokies.Count)
                {
                    p = (Pokemon)Pokies[index + 3];
                    if (p != null)
                    {
                        NameLabelSave4.Text = p.m_Name;
                        NumberLabelSave4.Text = NumberFormat(p.m_Number);
                        PictureSave4.ImageLocation = p.m_Picture;
                    }
                }
                if (index + 4 < Pokies.Count)
                {
                    p = (Pokemon)Pokies[index + 4];
                    if (p != null)
                    {
                        NameLabelSave5.Text = p.m_Name;
                        NumberLabelSave5.Text = NumberFormat(p.m_Number);
                        PictureSave5.ImageLocation = p.m_Picture;
                    }
                }
            }
        }
        string NumberFormat(int number)
        {
            string value = null;
            if (number < 10)
                value = "00" + number.ToString();
            else if (number < 100)
                value = "0" + number.ToString();
            else if (number < 1000)
                value = number.ToString();
            return value;
        }
        private void NextNavButton_Click(object sender, EventArgs e)
        {
            Clear();
            NavigationReader(currentIndex + 5);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = true;
        }
        private void AddClear()
        {
            PictureSave.ImageLocation = string.Empty;
            NameSave.Clear();
            TypeSave.Clear();
            AbilitySave.Clear();
            DescriptionSave.Clear();
            HPSave.Clear();
        }
        private void Clear()
        {
            NameLabelSave1.Text = string.Empty;
            NameLabelSave2.Text = string.Empty;
            NameLabelSave3.Text = string.Empty;
            NameLabelSave4.Text = string.Empty;
            NameLabelSave5.Text = string.Empty;
            NumberLabelSave1.Text = string.Empty;
            NumberLabelSave2.Text = string.Empty;
            NumberLabelSave3.Text = string.Empty;
            NumberLabelSave4.Text = string.Empty;
            NumberLabelSave5.Text = string.Empty;
            PictureSave1.ImageLocation = string.Empty;
            PictureSave2.ImageLocation = string.Empty;
            PictureSave3.ImageLocation = string.Empty;
            PictureSave4.ImageLocation = string.Empty;
            PictureSave5.ImageLocation = string.Empty;
        }

        private void AddSaveButton_Click(object sender, EventArgs e)
        {
            if (PictureSave.ImageLocation == null) { MessageBox.Show("Add The Picture....BTW APPLICATION IS GOING TO CRASH GOOD LUCK!"); }
            var p = new Pokemon
            {
                m_Name = NameSave.Text,
                m_Ability = AbilitySave.Text,
                m_Type = TypeSave.Text,
                m_Description = DescriptionSave.Text,
                m_HP = int.Parse(HPSave.Text),
                m_Number = Pokies.Count + 1,
                m_Picture = PictureSave.ImageLocation
            };
            
            Pokies.Add(p);
            StreamWriter outFile = File.CreateText("Pokemon.json");
            foreach (var items in Pokies)
            {
                outFile.WriteLine(JsonSerializer.Serialize(items));
                
            }
            outFile.Close();
            AddPanel.Visible = false;
            NavigationReader(currentIndex);
            AddClear();
        }

        private void PictureSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            PictureSave.ImageLocation = openFileDialog1.FileName;
        }

        private void BackNavButton_Click(object sender, EventArgs e)
        {
            Clear();
            if (currentIndex <= 0)
            {
                currentIndex = 0;
            }
            else
            {
                currentIndex -= 5;
            }
            NavigationReader(currentIndex);
        }

        private void FirstNavButton_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            NavigationReader(currentIndex);
        }

        private void LastNavButton_Click(object sender, EventArgs e)
        {
            bool done = false;
            Clear();
            currentIndex = Pokies.Count;
            while(done == false)
            {
                if (currentIndex % 1 == 0)
                {
                    done = true;
                }
                else
                {
                    ++currentIndex;
                }
            }
        }
    }
}