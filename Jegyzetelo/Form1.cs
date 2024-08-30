using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jegyzetelo
{
    public partial class Form1 : Form
    {
        public Boolean szovegVanE(TextBox TB_keres)
        {
            if (TB_Keres.Text.Length > 0)
            {
                return true;
            }
            MessageBox.Show("Nincs szöveg!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        private List<string[]> szovegek;
        public Form1()
        {
            InitializeComponent();
            szovegek = new List<string[]>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(RTB_Szoveg.Text.Length > 0&& TB_Hozza.Text.Length > 0)
            {
                string[] ujElem = { TB_Hozza.Text, RTB_Szoveg.Text };
                szovegek.Add(ujElem);

                LB_Lista.Items.Add(TB_Hozza.Text);
                RTB_Szoveg.Clear();
                TB_Hozza.Clear();
                MessageBox.Show("Elmentve!", "Mentve!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BT_Keres_Click(object sender, EventArgs e)
        {
            if(szovegVanE(TB_Keres))
            {
                foreach (string[] elem in szovegek)
                {
                    if (TB_Keres.Text.Equals(elem[0]))
                        MessageBox.Show(elem[1], elem[0], MessageBoxButtons.OK, MessageBoxIcon.Information);
                    {
                    }
                }
            }
            TB_Keres.Clear();
        }

        private void BT_Szerkezzt_Click(object sender, EventArgs e)
        {
            String torolni_valo = null;
            if (szovegVanE(TB_Keres))
            {
                foreach (string[] elem in szovegek)
                {
                    if (TB_Keres.Text.Equals(elem[0])){
                        RTB_Szoveg.Text = elem[1];
                        TB_Hozza.Text = elem[0];
                        torolni_valo = elem[0];
                        Torol(torolni_valo);
                        break;
                    }
                }
            }
        }
        public void Torol(string x)
        {
            if (szovegVanE(TB_Keres))
            {

            for(int i=0; i < szovegek.Count; i++) 
            {
                if (TB_Keres.Text.Equals(x))
                {
                        szovegek.RemoveAt(i);
                    LB_Lista.Items.RemoveAt(i);
                }
            }
            }
            TB_Keres.Clear();
        }

        private void BT_Mentes_Click(object sender, EventArgs e)
        {
            

            StreamWriter sw = new StreamWriter("Szovegek.txt");
            foreach (string[] elem in szovegek)
            {
                sw.WriteLine(elem[0] + ";" + elem[1]);
            }
            sw.Close();
        }

        private void BT_torles_Click(object sender, EventArgs e)
        {
            String torolni_valo = TB_Keres.Text;
            if(MessageBox.Show("Törölni szeretnéd a: "+torolni_valo+" címkéjű bejegyzést?", "Törlés!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
            Torol(torolni_valo);
            }
        }

        private void BT_Betolt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztos szeretnéd beolvasni? (Előtte ments!)", "Beolvasás!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                string sor;
                try
                {
                    using (StreamReader sr = new StreamReader("Szovegek.txt"))
                    {
                        while ((sor = sr.ReadLine()) != null)
                        {
                            if (!string.IsNullOrWhiteSpace(sor) && sor.Contains(';'))
                            {
                                string[] elem = sor.Split(';');
                                if (elem.Length == 2) 
                                {
                                    szovegek.Add(elem);
                                    LB_Lista.Items.Add(elem[0]);
                                }
                                else
                                {
                                    MessageBox.Show("A fájl egyik sora érvénytelen formátumú.", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba történt a fájl betöltésekor: {ex.Message}", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
