using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Programme de tour de Hanoi qui bouge tout les disques d'un pole, à un pole destiné. 
 * Le porgramme ne va jamais mettre un disque plus large sur un plus petit. Le programme accompli se mouvement dans un nombre minimale de mouvement.
 * Créé par Jacob Schnell le 7 Mars 2019 */


namespace Tower_of_Hanoi
{
    public partial class frmMain : Form
    {
        //Initialise les variables
        static char[] rodNames = { 'A', 'B', 'C' };
        static Brush[] longColors = { Brushes.DarkRed, Brushes.Red, Brushes.OrangeRed, Brushes.Orange, Brushes.Yellow, Brushes.YellowGreen, Brushes.Green, Brushes.DarkGreen, Brushes.Turquoise, Brushes.LightBlue, Brushes.Blue, Brushes.DarkBlue, Brushes.Indigo, Brushes.MediumPurple, Brushes.Purple, Brushes.Magenta };
        static Brush[] shortColors = { Brushes.Yellow, Brushes.Orange, Brushes.Red, Brushes.Green, Brushes.Turquoise, Brushes.LightBlue, Brushes.Indigo, Brushes.Purple };
        List<int>[] rodValues = { new List<int>(), new List<int>(), new List<int>() };
		int currentRod;
		public frmMain()
		{
			InitializeComponent();
		}

		private void picMain_Paint(object sender, PaintEventArgs e)
		{
            //Afficher les poles
			e.Graphics.FillRectangle(Brushes.Brown, 162, 150, 10, 450);
			e.Graphics.FillRectangle(Brushes.Brown, 496, 150, 10, 450);
			e.Graphics.FillRectangle(Brushes.Brown, 830, 150, 10, 450);
            e.Graphics.FillRectangle(Brushes.Brown, 0, 550, 1000, 50);
            //Choisir la largeur et couleur selon le nombre de disques
            int diskWidth = 40;
            Brush[] diskColors = shortColors;
            if ((int)updHeight.Value > 8)
            {
                diskColors = longColors;
                diskWidth = 20;
            }
            //Afficher les disques
			for (int k = 0; k < 3; k++)
			{
				for (int i = 0; i < rodValues[k].Count; i++)
				{
					e.Graphics.FillRectangle(diskColors[rodValues[k][i] - 1], 167 * (2 * k + 1) - (diskWidth/2) * rodValues[k][i], 550 - 20 * (i + 1), rodValues[k][i] * diskWidth, 20);
				}
			}
		}

		private void towerOfHanoi(int disks, int fromRod, int auxRod, int toRod)
		{
            void performMove(int nDisks, int nFromRod, int nToRod)
            {
                int fromLength = rodValues[fromRod].Count;
                //Afficher l'action exécuté
                lstActions.Items.Add(string.Format("Disk {0} from {1} to {2}", nDisks, rodNames[nFromRod], rodNames[nToRod]));
                lstActions.Refresh();
                //Mettre à jour le nombre d'actions exécutés
                txtCount.Text = Convert.ToString(Convert.ToInt32(txtCount.Text) + 1);
                txtCount.Refresh();
                //Déplacer le disques d'une tour à l'autre
                rodValues[nToRod].Add(rodValues[nFromRod][fromLength - 1]);
                rodValues[nFromRod].RemoveAt(fromLength - 1);
                //Mettre à jour l'affichage
                picMain.Refresh();
                //Attendre selon le nombre de secondes spécifés
                System.Threading.Thread.Sleep((int)(updSpeed.Value * 1000));
                return;
            }
			if (disks == 1)
            {
                //Si le nombre disques est 1, bouge le disque à la destination
                performMove(disks, fromRod, toRod);
                return;
			}
            //Si non asseye de bouger le disque par dessus au pole auxilière
			towerOfHanoi(disks - 1, fromRod, toRod, auxRod);
            //Ensuite bouge le disk à la destination
            performMove(disks, fromRod, toRod);
            //Et finallement bouge le disque qui était par dessus du pole auxilière à la destination
			towerOfHanoi(disks - 1, auxRod, fromRod, toRod);
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
            //Initalise la boite combo et place les disques sur le premier pole
			cmbToBox.SelectedIndex = 0;
			currentRod = 0;
            btnReset.PerformClick();
		}

		private void btnExecute_Click(object sender, EventArgs e)
		{
            //Quand le bouton d'exécution est appuyé désactiver le bouton de réinitialisation
            btnReset.Enabled = false;
			if(currentRod != cmbToBox.SelectedIndex)
			{
                //Si la destination est valide, appuis le boutton de réinitialisation
				btnReset.PerformClick();
                //Puis détermine le pole auxiliaire
                int auxRod = 2;
				for (int i = 0; i< 3; i++)
				{
					if (i != currentRod && i != cmbToBox.SelectedIndex)
					{
						auxRod = i;
						break;
					}
				}
                //Puis exécute le code et change le pole actif à celle destiné
				towerOfHanoi((int)updHeight.Value, currentRod, auxRod, cmbToBox.SelectedIndex);
				currentRod = cmbToBox.SelectedIndex;
			}
            //Finalement réactiver le boutton de réinitialisation
            btnReset.Enabled = true;
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
            //Quand le boutton de réinitialisation est appuyé réinitialise la liste d'actions et le comte d'actions
			for (int i = lstActions.Items.Count - 1; i >= 0; i--)
            {
                lstActions.Items.RemoveAt(i);
            }
            txtCount.Text = "0";
            //Réinitialise les poles
			for (int i = 0; i < 3; i++)
			{
				rodValues[i] = new List<int>();
			}
            //Puis place les disques sur le pole actif
			for (int i = (int)updHeight.Value; i >= 1; i--)
			{
				rodValues[currentRod].Add(i);
			}
            //Finallement afficher les poles
			picMain.Refresh();
		}
	}
}
