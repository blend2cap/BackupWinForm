using System;
using System.IO;
using System.Windows.Forms;
using BackupLib;

namespace BackupWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            origineBox.Text = "\\\\PCLS\\Stage2017\\ServerFittizio\\WebApps\\CambiaPasswordWeb\\bin\\CambiaPasswordWeb.dll";


        }


        private void OrigineButt_Click(object sender, EventArgs e)
        {

            
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
                origineBox.Text = openFileDialog1.FileName;

            /*if (OrigineBrowser.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Origine Selezionata:\n "+ OrigineBrowser.SelectedPath);*/
        }

        private void DestinazioneButt_Click(object sender, EventArgs e)
        {

            DialogResult result = DestinazioneBrowser.ShowDialog();

            if (result == DialogResult.OK)
                destinazioneBox.Text = DestinazioneBrowser.SelectedPath;
        }

        private void CopiaButt_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utils.CheckFolderExist(Utils.GetPathDestinazione(origineBox.Text, destinazioneBox.Text, Utils.GetNomeApplicazione(origineBox.Text.Split('\\'))), false))
                    MessageBox.Show("Backup gia eseguito per questa versione");
                else
                {
                    this.Cursor = Cursors.WaitCursor;
                    errorBox.Text="Backup in corso";
                    Application.DoEvents();
                    Utils.Copia(Utils‬.PathOrigine(origineBox.Text), Utils‬.GetPathDestinazione(origineBox.Text, destinazioneBox.Text, Utils‬.GetNomeApplicazione(origineBox.Text.Split('\\'))));
                    this.Cursor = Cursors.Arrow;
                    errorBox.Text = "";
                    MessageBox.Show("Backup Completato");
                }
            }
            catch (Exception ex)
            {
                errorBox.Text = ex.Message;
            }
           
        }

       
    }
}
