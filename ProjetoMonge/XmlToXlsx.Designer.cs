namespace ProjetoMonge
{
    partial class XmlToXlsx
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_SelecionaXML = new System.Windows.Forms.Button();
            this.Dgv_XmlPath = new System.Windows.Forms.DataGridView();
            this.XMLPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Txt_XlsxPath = new System.Windows.Forms.TextBox();
            this.Lbl_XlsxPath = new System.Windows.Forms.Label();
            this.Lbl_XmlPath = new System.Windows.Forms.Label();
            this.Btn_XlsxPath = new System.Windows.Forms.Button();
            this.Btn_Convert = new System.Windows.Forms.Button();
            this.Txt_FileName = new System.Windows.Forms.TextBox();
            this.Lbl_FileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_XmlPath)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_SelecionaXML
            // 
            this.Btn_SelecionaXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SelecionaXML.Location = new System.Drawing.Point(16, 233);
            this.Btn_SelecionaXML.Name = "Btn_SelecionaXML";
            this.Btn_SelecionaXML.Size = new System.Drawing.Size(180, 42);
            this.Btn_SelecionaXML.TabIndex = 3;
            this.Btn_SelecionaXML.Text = "Btn_SelecionaXML";
            this.Btn_SelecionaXML.UseVisualStyleBackColor = true;
            this.Btn_SelecionaXML.Click += new System.EventHandler(this.Btn_SelecionaXML_Click);
            // 
            // Dgv_XmlPath
            // 
            this.Dgv_XmlPath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_XmlPath.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.XMLPath});
            this.Dgv_XmlPath.Location = new System.Drawing.Point(16, 292);
            this.Dgv_XmlPath.Name = "Dgv_XmlPath";
            this.Dgv_XmlPath.RowHeadersWidth = 45;
            this.Dgv_XmlPath.Size = new System.Drawing.Size(547, 546);
            this.Dgv_XmlPath.TabIndex = 6;
            this.Dgv_XmlPath.TabStop = false;
            // 
            // XMLPath
            // 
            this.XMLPath.HeaderText = "XML Caminho completo";
            this.XMLPath.MinimumWidth = 6;
            this.XMLPath.Name = "XMLPath";
            this.XMLPath.ReadOnly = true;
            this.XMLPath.Width = 500;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(127, 28);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(106, 25);
            this.Lbl_Titulo.TabIndex = 3;
            this.Lbl_Titulo.Text = "Lbl_Titulo";
            // 
            // Txt_XlsxPath
            // 
            this.Txt_XlsxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_XlsxPath.Location = new System.Drawing.Point(12, 160);
            this.Txt_XlsxPath.Name = "Txt_XlsxPath";
            this.Txt_XlsxPath.Size = new System.Drawing.Size(551, 28);
            this.Txt_XlsxPath.TabIndex = 6;
            this.Txt_XlsxPath.TabStop = false;
            this.Txt_XlsxPath.Text = "Txt_XlsxPath";
            // 
            // Lbl_XlsxPath
            // 
            this.Lbl_XlsxPath.AutoSize = true;
            this.Lbl_XlsxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_XlsxPath.Location = new System.Drawing.Point(12, 65);
            this.Lbl_XlsxPath.Name = "Lbl_XlsxPath";
            this.Lbl_XlsxPath.Size = new System.Drawing.Size(93, 18);
            this.Lbl_XlsxPath.TabIndex = 7;
            this.Lbl_XlsxPath.Text = "Lbl_XlsxPath";
            // 
            // Lbl_XmlPath
            // 
            this.Lbl_XmlPath.AutoSize = true;
            this.Lbl_XmlPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_XmlPath.Location = new System.Drawing.Point(16, 198);
            this.Lbl_XmlPath.Name = "Lbl_XmlPath";
            this.Lbl_XmlPath.Size = new System.Drawing.Size(91, 18);
            this.Lbl_XmlPath.TabIndex = 8;
            this.Lbl_XmlPath.Text = "Lbl_XmlPath";
            // 
            // Btn_XlsxPath
            // 
            this.Btn_XlsxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_XlsxPath.Location = new System.Drawing.Point(12, 101);
            this.Btn_XlsxPath.Name = "Btn_XlsxPath";
            this.Btn_XlsxPath.Size = new System.Drawing.Size(180, 42);
            this.Btn_XlsxPath.TabIndex = 1;
            this.Btn_XlsxPath.Text = "Btn_XlsxPath";
            this.Btn_XlsxPath.UseVisualStyleBackColor = true;
            this.Btn_XlsxPath.Click += new System.EventHandler(this.Btn_XlsxPath_Click);
            // 
            // Btn_Convert
            // 
            this.Btn_Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Convert.Location = new System.Drawing.Point(202, 860);
            this.Btn_Convert.Name = "Btn_Convert";
            this.Btn_Convert.Size = new System.Drawing.Size(180, 42);
            this.Btn_Convert.TabIndex = 4;
            this.Btn_Convert.Text = "Btn_Convert";
            this.Btn_Convert.UseVisualStyleBackColor = true;
            this.Btn_Convert.Click += new System.EventHandler(this.Btn_Convert_Click);
            // 
            // Txt_FileName
            // 
            this.Txt_FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FileName.Location = new System.Drawing.Point(290, 101);
            this.Txt_FileName.Name = "Txt_FileName";
            this.Txt_FileName.Size = new System.Drawing.Size(259, 28);
            this.Txt_FileName.TabIndex = 2;
            this.Txt_FileName.Text = "Txt_FileName";
            // 
            // Lbl_FileName
            // 
            this.Lbl_FileName.AutoSize = true;
            this.Lbl_FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FileName.Location = new System.Drawing.Point(290, 65);
            this.Lbl_FileName.Name = "Lbl_FileName";
            this.Lbl_FileName.Size = new System.Drawing.Size(98, 18);
            this.Lbl_FileName.TabIndex = 12;
            this.Lbl_FileName.Text = "Lbl_FileName";
            // 
            // XmlToXlsx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 930);
            this.Controls.Add(this.Lbl_FileName);
            this.Controls.Add(this.Txt_FileName);
            this.Controls.Add(this.Btn_Convert);
            this.Controls.Add(this.Btn_XlsxPath);
            this.Controls.Add(this.Lbl_XmlPath);
            this.Controls.Add(this.Lbl_XlsxPath);
            this.Controls.Add(this.Txt_XlsxPath);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Dgv_XmlPath);
            this.Controls.Add(this.Btn_SelecionaXML);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "XmlToXlsx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XmlToXlsx";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_XmlPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_SelecionaXML;
        private System.Windows.Forms.DataGridView Dgv_XmlPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn XMLPath;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.TextBox Txt_XlsxPath;
        private System.Windows.Forms.Label Lbl_XlsxPath;
        private System.Windows.Forms.Label Lbl_XmlPath;
        private System.Windows.Forms.Button Btn_XlsxPath;
        private System.Windows.Forms.Button Btn_Convert;
        private System.Windows.Forms.TextBox Txt_FileName;
        private System.Windows.Forms.Label Lbl_FileName;
    }
}

