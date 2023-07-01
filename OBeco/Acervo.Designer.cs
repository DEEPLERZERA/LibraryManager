namespace OBeco
{
    partial class Acervo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgLivros = new System.Windows.Forms.DataGridView();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoPublicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet2 = new OBeco.BibliotecaDataSet2();
            this.livrosTableAdapter = new OBeco.BibliotecaDataSet2TableAdapters.LivrosTableAdapter();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(175)))));
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acervo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(175)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1414, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "+ Adicionar Livro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 24F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(175)))));
            this.label2.Location = new System.Drawing.Point(63, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 56);
            this.label2.TabIndex = 21;
            this.label2.Text = "Filtros";
            // 
            // dtgLivros
            // 
            this.dtgLivros.AllowUserToAddRows = false;
            this.dtgLivros.AllowUserToDeleteRows = false;
            this.dtgLivros.AllowUserToResizeColumns = false;
            this.dtgLivros.AllowUserToResizeRows = false;
            this.dtgLivros.AutoGenerateColumns = false;
            this.dtgLivros.BackgroundColor = System.Drawing.Color.White;
            this.dtgLivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgLivros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autorDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.editoraDataGridViewTextBoxColumn,
            this.anoPublicDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.Column1});
            this.dtgLivros.DataSource = this.livrosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgLivros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgLivros.EnableHeadersVisualStyles = false;
            this.dtgLivros.Location = new System.Drawing.Point(73, 352);
            this.dtgLivros.Name = "dtgLivros";
            this.dtgLivros.Size = new System.Drawing.Size(1540, 446);
            this.dtgLivros.TabIndex = 28;
            this.dtgLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLivros_CellContentClick);
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.FillWeight = 150F;
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.FillWeight = 150F;
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // editoraDataGridViewTextBoxColumn
            // 
            this.editoraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.editoraDataGridViewTextBoxColumn.DataPropertyName = "Editora";
            this.editoraDataGridViewTextBoxColumn.FillWeight = 150F;
            this.editoraDataGridViewTextBoxColumn.HeaderText = "Editora";
            this.editoraDataGridViewTextBoxColumn.Name = "editoraDataGridViewTextBoxColumn";
            // 
            // anoPublicDataGridViewTextBoxColumn
            // 
            this.anoPublicDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.anoPublicDataGridViewTextBoxColumn.DataPropertyName = "Ano_Public";
            this.anoPublicDataGridViewTextBoxColumn.FillWeight = 150F;
            this.anoPublicDataGridViewTextBoxColumn.HeaderText = "Ano_Public";
            this.anoPublicDataGridViewTextBoxColumn.Name = "anoPublicDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.FillWeight = 150F;
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 150F;
            this.Column1.HeaderText = "Deletar";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Deletar";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.bibliotecaDataSet2;
            // 
            // bibliotecaDataSet2
            // 
            this.bibliotecaDataSet2.DataSetName = "BibliotecaDataSet2";
            this.bibliotecaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(175)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1503, 175);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton1.Size = new System.Drawing.Size(110, 44);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OBeco.Properties.Resources.Rectangle_20;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1695, 132);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(175)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(1371, 288);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(37, 35);
            this.iconButton2.TabIndex = 29;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // Acervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 881);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.dtgLivros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Acervo";
            this.Text = "Acervo";
            this.Load += new System.EventHandler(this.Acervo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgLivros;
        private BibliotecaDataSet2 bibliotecaDataSet2;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private BibliotecaDataSet2TableAdapters.LivrosTableAdapter livrosTableAdapter;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoPublicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}