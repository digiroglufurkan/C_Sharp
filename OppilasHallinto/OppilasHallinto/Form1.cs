using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OppilasHallinto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            idTB.Text = "";
            enimiTB.Text = "";
            snimiTB.Text = "";
            puhTB.Text = "";
            emailTB.Text = "";
            oNroTB.Text = "";
        }
        opiskelija op = new opiskelija();
        private void tallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = enimiTB.Text;
            String snimi = snimiTB.Text;
            String puh = puhTB.Text;
            String email = emailTB.Text;
            int oNro = Int32.Parse(oNroTB.Text);
           

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kent�t - Etu- ja sukunimi, Puhelin, S�hk�posti ja Opiskelijanumero", "Tyhj� kentt�", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaOpiskelija = op.lisaaOpiskelija(enimi, snimi, puh, email, oNro);
                if (lisaaOpiskelija)
                {
                    MessageBox.Show("Uusi opiskelijaa lis�tty onnistuneesti", "Opiskelijan lis�ys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lis��m��n", "Opiskelijan lis�ys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Tietotaulu.DataSource = op.haeOpiskelijat();
            
        }

        private void paivitaBT_Click(object sender, EventArgs e)
        {
            String enimi = enimiTB.Text;
            String snimi = snimiTB.Text;
            String puh = puhTB.Text;
            String email = emailTB.Text;
            int oNro = Int32.Parse(oNroTB.Text);
            int oid = Int32.Parse(idTB.Text);


            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kent�t - OID, Etu- ja sukunimi, Puhelin, S�hk�posti ja Opiskelijanumero", "Tyhj� kentt�", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean muokkaaOpiskelija = op.muokkaaOpiskelijaa(oid, enimi, snimi, puh, email, oNro);
                if (muokkaaOpiskelija)
                {
                    MessageBox.Show("Opiskelija muokattu onnistuneesti", "Opiskelijan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty muokkaamaan", "Opiskelijan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Tietotaulu.DataSource = op.haeOpiskelijat();
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            int ktunnus = Int32.Parse(idTB.Text);
            if (op.poistaOpiskelija(ktunnus))
            {
                Tietotaulu.DataSource = op.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaBT.PerformClick();
        }

        private void YllapitoForm_Load(object sender, EventArgs e)
        {
            Tietotaulu.DataSource = op.haeOpiskelijat();
            Tietotaulu.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            var datagridview = new DataGridView();
            datagridview.RowTemplate.MinimumHeight = 125;
        }

        private void Tietotaulu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enimiTB.Text = Tietotaulu.CurrentRow.Cells[1].Value.ToString();
            snimiTB.Text = Tietotaulu.CurrentRow.Cells[2].Value.ToString();
            puhTB.Text = Tietotaulu.CurrentRow.Cells[3].Value.ToString();
            emailTB.Text = Tietotaulu.CurrentRow.Cells[4].Value.ToString();
            oNroTB.Text = Tietotaulu.CurrentRow.Cells[5].Value.ToString();
            idTB.Text = Tietotaulu.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
