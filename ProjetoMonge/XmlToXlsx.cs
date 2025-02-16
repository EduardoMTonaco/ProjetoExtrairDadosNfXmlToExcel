using ProjetoMonge.Class;
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

namespace ProjetoMonge
{
    public partial class XmlToXlsx : Form
    {
        public XmlToXlsx()
        {
            InitializeComponent();
            this.Name = "Monge";
            Btn_SelecionaXML.Text = "Seleciona Caminho";
            Dgv_XmlPath.ReadOnly = true;
            Lbl_Titulo.Text = "Transformar Nota Fiscal(XML) em Xlsx";
            Lbl_XlsxPath.Text = "Selecionar caminho para o Excel";
            Lbl_XmlPath.Text = "Selecionar arquivos Xlsx";

            Btn_SelecionaXML.Text = "Selecionar XML";
            Btn_XlsxPath.Text = "Buscar destino Xlsx";
            Btn_Convert.Text = "Confirmar";

            Txt_XlsxPath.Text = "";
            Txt_XlsxPath.ReadOnly = true;
            Txt_XlsxPath.BackColor = System.Drawing.Color.White;

            Txt_FileName.Text = "ArquivoXlsx";
        }

        private void Btn_SelecionaXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            this.Dgv_XmlPath.Rows.Clear();
            // Permite a seleção de múltiplos arquivos
            openFileDialog.Multiselect = true;

            // Filtra apenas arquivos XML
            openFileDialog.Filter = "Arquivos XML (*.xml)|*.xml";

            // Título da caixa de diálogo
            openFileDialog.Title = "Selecione os arquivos XML";

            // Exibe a caixa de diálogo e verifica se o usuário selecionou algo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Exibe os arquivos selecionados no console ou faz o que for necessário com os arquivos
                int i = 0;
                foreach (string fileName in openFileDialog.FileNames)
                {
                    this.Dgv_XmlPath.Rows.Insert(i, fileName);
                    i++;
                }
            }
        }

        private void Btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_XmlPath.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum Arquivo selecionado,\r\n por favor selecione ao menos um arquivo Xml.", "Nenhum Arquivo selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (Txt_XlsxPath.Text == "")
                {
                    MessageBox.Show("Destino para o Excel não definido,\r\n por favor selecione uma pasta destino para o arquivo Excel", "Destino para o Excel não definido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (Txt_FileName.Text == "")
                {
                    MessageBox.Show("Nome do arquivo Xlsx não preenchido,\r\n por favor preencha o nome do arquivo Xlsx.", "Nome do arquivo Xlsx não preenchido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                List<string[]> nf = new List<string[]>();
                XmlHandler read = new XmlHandler();
                foreach (DataGridViewRow row in Dgv_XmlPath.Rows)
                {
                    if (row.Cells[0].Value == null)
                    {
                        break;
                    }
                    List<string> NFHard = read.ReadXml(row.Cells[0].Value.ToString());
                    string[] nfs = new string[2];
                    bool addOne = false;
                    bool addTwo = false;
                    for (int i = 0; i < NFHard.Count - 1; i++)
                    {

                        if (NFHard[i] == "<nNF>")
                        {
                            nfs[0] = NFHard[i + 1].ToString();
                            addOne = true;


                        }
                        if (NFHard[i] == "<vNF>")
                        {
                            nfs[1] = NFHard[i + 1].ToString();
                            addTwo = true;
                        }
                    }
                    if (addOne && addTwo)
                    {
                        nf.Add(nfs);
                    }                   
                }
                if (nf.Count > 0) {
                    XlsxHandler ListToXlsx = new XlsxHandler();
                    string filePath = Txt_XlsxPath.Text + "\\" + Txt_FileName.Text + ".xlsx";
                    ListToXlsx.CreateXlsx(filePath, nf);
                    System.Diagnostics.Process.Start("explorer.exe", Txt_XlsxPath.Text);
                    MessageBox.Show("Operação concluída com sucesso!", "Operação Finalizada", MessageBoxButtons.OK, MessageBoxIcon.None);
                } else {
                    MessageBox.Show("Não encontrado dados de nota Fiscal", "Algum erro ocorreu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Algum erro ocorreu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_XlsxPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select a folder";
                dialog.ShowNewFolderButton = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Txt_XlsxPath.Text = dialog.SelectedPath;
                }
            }
        }
    }
}
