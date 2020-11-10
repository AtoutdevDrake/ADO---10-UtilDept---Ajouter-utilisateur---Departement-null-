using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilisateurs
{
    /// <summary>
    /// 
    ///     1 - Afficher la table 'v_utildept'.
    ///     2 - Supprimer utilisateur
    ///     3 - Ajouter département (gestion doublons)
    ///     4 - Gestion du département null
    ///     
    /// </summary>
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            // Chargement des DataTables à partir du SGBD
            Fill_DataTables();
        }

        private void btActualiser_Click(object sender, EventArgs e)
        {
            // Ré-actualisation des DataTables
            Fill_DataTables();
        }

        private void v_utildeptBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (v_utildeptBindingSource.Current != null)
            {
                // Récupération de l'enregistrement courant
                dl09_2DataSet.v_utildeptRow currentRow = (dl09_2DataSet.v_utildeptRow)((DataRowView)v_utildeptBindingSource.Current).Row;

                // la checkbox doit être sélectionnée si valeur null
                ckbxNull.Checked = currentRow.IsIdDeptNull();
            }
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            // Vérifier si il y a un enregistrement courant
            if (v_utildeptBindingSource.Current != null)
            {
                // Récupération de l'enregistrement courant
                dl09_2DataSet.v_utildeptRow currentRow = (dl09_2DataSet.v_utildeptRow)((DataRowView)v_utildeptBindingSource.Current).Row;

                // Demande confirmation Suppression
                if (MessageBox.Show(Properties.Resources.TXT_SUPP, String.Format(Properties.Resources.TITRE_SUPP, currentRow.Prenom, currentRow.Nom), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    // Le champ IdDept peut être null, il faut donc le tester
                    String IdDept = currentRow.IsIdDeptNull() ? null : currentRow.IdDept;

                    // Suppression de l'enregistrement courant dans le SGBD
                    int nb = utilisateursTableAdapter.Delete(currentRow.IdUtil, currentRow.Nom, currentRow.Prenom, currentRow.DtNaiss, IdDept);

                    // On teste si la ligne a bien été supprimée
                    if (nb != 0)
                    {
                        // Ré-actualisation des DataTables
                        Fill_DataTables();
                    }
                    else
                    {
                        // Affichage d'un message d'erreur
                        MessageBox.Show(Properties.Resources.TXT_ERRSUPP, Properties.Resources.TITRE_ERRSUPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            long? nbCountUtil = utilisateursTableAdapter.CountUtilisateurs(txtNom.Text, txtPrenom.Text, dtpDtNaiss.Value);

            if (nbCountUtil == 0)
            {                
                // On teste si la CheckBox null est cochée ou pas de département de sélectionné.
                string idDept = ckbxNull.Checked || cbxIdDept.SelectedValue == null ? null : cbxIdDept.SelectedValue.ToString();

                // On ajoute l'utilisateur
                int nbUtil = utilisateursTableAdapter.Insert(txtNom.Text, txtPrenom.Text, dtpDtNaiss.Value, idDept);

                // On teste si la ligne a bien été ajoutée
                if (nbUtil == 0)
                {
                    // Affichage d'un message d'erreur
                    MessageBox.Show(Properties.Resources.TXT_ERRADDUTIL, Properties.Resources.TITRE_ERRADDUTIL, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Ré-actualisation des DataTables
                Fill_DataTables();
            }
            else
            {
                MessageBox.Show(String.Format(Properties.Resources.TXT_ERRDOUBL, txtPrenom.Text, txtNom.Text), Properties.Resources.TITRE_ERRDOUBL, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region Fonctions perso

        private void Fill_DataTables()
        {
            // Chargement de la table 'departements' à partir du SGBD
            departementsTableAdapter.Fill(dl09_2DataSet.departements);

            // Chargement de la table 'utilisateurs' à partir du SGBD
            utilisateursTableAdapter.Fill(dl09_2DataSet.utilisateurs);

            // Chargement de la table 'v_utildept' à partir du SGBD
            v_utildeptTableAdapter.Fill(dl09_2DataSet.v_utildept);
        }

        #endregion Fonctions perso                

        private void ckbxNull_CheckedChanged(object sender, EventArgs e)
        {
            cbxIdDept.Enabled = !ckbxNull.Checked;
        }

		private void button1_Click(object sender, EventArgs e)
		{

			if (v_utildeptBindingSource.Current != null)
			{
				dl09_2DataSet.v_utildeptRow currentRow = (dl09_2DataSet.v_utildeptRow)((DataRowView)v_utildeptBindingSource.Current).Row;
				String IdDepte = currentRow.IsIdDeptNull() ? null : currentRow.IdDept;
				string idDept = ckbxNull.Checked || cbxIdDept.SelectedValue == null ? null : cbxIdDept.SelectedValue.ToString();


				utilisateursTableAdapter.Update(txtNom.Text, txtPrenom.Text, dtpDtNaiss.Value, idDept, currentRow.IdUtil, currentRow.Nom, currentRow.Prenom, currentRow.DtNaiss, IdDepte);
				Fill_DataTables();
			}
		}
	}
}
