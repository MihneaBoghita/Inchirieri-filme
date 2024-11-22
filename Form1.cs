using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inchirieri_filme
{
    public partial class Videoteca : Form
    {
        string[] filme = { "Titanic", "Don Juan De Marco", "Tom si Jerry", "Matrix", "Letters to Juliet","Bleach","TQQ","JoJo","Bunny Girl Senpai", "Classroom of the Elite" };
        string[] domenii = { "Dragoste", "Dragoste", "Animatie", "Actiune", "Dragoste","Anime", "Anime" , "Anime" , "Anime" , "Anime" };
        string[] imagini = { "Titanic.jpg", "Don_Juan_De_Marco.jpg", "Tom_si_Jerry.jpg", "Matrix.jpg", "Letters_to_Juliet.jpg", "Bleach.jpg", "TQQ.jpg", "JoJo.jpg", "Bunny_Girl_Senpai.jpg", "Classroom_of_the_Elite.jpg" };
        string[] inchiriate_clienti = {"","","","","","","","","","","","","","","","","",""};
        public Videoteca()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now.AddDays(1);
            comboBox_Domeniul.SelectedIndex = 0;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Videoteca_Load(object sender, EventArgs e)
        {
           
        }
        
        private void incarca_Combo_Filme()
        {
            int i;
            try
            {
                string dom;
                if (comboBox_Domeniul.SelectedIndex == 0)
                    dom = "";
                else
                    dom = comboBox_Domeniul.SelectedItem.ToString();
                if(dom =="")
                    for(i=0; i < filme.Length;i++)
                    {
                        if (inchiriate_clienti[i] == "")
                            comboBox_Filmul.Items.Add(filme[i]);
                    }
                else
                    for(i=0;i<filme.Length;i++)
                    {
                        if ((dom == domenii[i]) && (inchiriate_clienti[i] == ""))
                            comboBox_Filmul.Items.Add(filme[i]);

                    }
                if (comboBox_Filmul.Items.Count == 0)
                    MessageBox.Show("Nu mai sunt filme disponibile din\n domeniul selectat", "Atentie!");

            }
            catch(Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
        }
        private void reseteaza_filmul()
        {
            comboBox_Filmul.Items.Clear();
            comboBox_Filmul.SelectedIndex = -1;
            pictureBox1.ImageLocation= null;
        }

        private void comboBox_Domeniul_SelectedIndexChanged(object sender, EventArgs e)
        {
            reseteaza_filmul();
            incarca_Combo_Filme();
        }

        private void comboBox_Filmul_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int i;
                for (i = 0; i < filme.Length && comboBox_Filmul.SelectedItem.ToString() != filme[i]; i++) ;
                pictureBox1.Image = Image.FromFile("D:\\Proiecte c#\\Inchirieri filme\\Inchirieri filme\\Poze\\" + imagini[i]);
                pictureBox1.Visible = true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message,"Nu o mers na");
            }
        }

        private void button_Inchiriez_Click(object sender, EventArgs e)
        {
            int i, gasit;
            string nume_cli = textBox_Nume.Text.Trim();
            string film_sel;
                try
            {
                if (comboBox_Filmul.SelectedIndex == -1)
                    throw new Exception("Va rugam selectati un film");
                if (nume_cli == "")
                    throw new Exception("Va rugam tastati un nume");
                film_sel = comboBox_Filmul.SelectedItem.ToString();
                gasit = 0;
                for(i = 0;i<filme.Length && gasit==0;i++)
                {
                    if (filme[i]==film_sel)
                    {
                        inchiriate_clienti[i] = nume_cli;
                        gasit = 1;
                    }
                }
                int nrzile = dateTimePicker1.Value.Subtract(DateTime.Now).Days + 1;
                label_Mesaj.Text = nume_cli + " - a inchiriat filmul - " + film_sel + "--" + "pentru " + nrzile + "zile";
                reseteaza_filmul();
                incarca_Combo_Filme();

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Eroare!");
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            comboBox_Domeniul.SelectedIndex = 0;
            dateTimePicker1.Value=DateTime.Now.AddDays(1);
            textBox_Nume.Text = "";
            label_Mesaj.Text = "";
            reseteaza_filmul();
            incarca_Combo_Filme();
        }
    }
}


