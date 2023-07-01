namespace OBeco
{
    partial class Emprestimo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgDisponiveis = new System.Windows.Forms.DataGridView();
            this.bibliotecaDataSet = new OBeco.bibliotecaDataSet();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrosTableAdapter = new OBeco.bibliotecaDataSetTableAdapters.LivrosTableAdapter();
            this.dtgDevolver = new System.Windows.Forms.DataGridView();
            this.anoPublicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo2dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisponiveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevolver)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(704, 84);
            this.label1.TabIndex = 3;
            this.label1.Text = "Empréstimos e Devoluções";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(175)))));
            this.label2.Location = new System.Drawing.Point(179, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 56);
            this.label2.TabIndex = 22;
            this.label2.Text = "Livros Disponíveis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(175)))));
            this.label3.Location = new System.Drawing.Point(1112, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 56);
            this.label3.TabIndex = 23;
            this.label3.Text = "Livros a Devolver";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtgDisponiveis
            // 
            this.dtgDisponiveis.AllowUserToAddRows = false;
            this.dtgDisponiveis.AllowUserToDeleteRows = false;
            this.dtgDisponiveis.AllowUserToResizeColumns = false;
            this.dtgDisponiveis.AllowUserToResizeRows = false;
            this.dtgDisponiveis.AutoGenerateColumns = false;
            this.dtgDisponiveis.BackgroundColor = System.Drawing.Color.White;
            this.dtgDisponiveis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDisponiveis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDisponiveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anoPublicDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.Column1});
            this.dtgDisponiveis.DataSource = this.livrosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDisponiveis.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDisponiveis.EnableHeadersVisualStyles = false;
            this.dtgDisponiveis.Location = new System.Drawing.Point(40, 330);
            this.dtgDisponiveis.Name = "dtgDisponiveis";
            this.dtgDisponiveis.Size = new System.Drawing.Size(650, 465);
            this.dtgDisponiveis.TabIndex = 33;
            this.dtgDisponiveis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLivros_CellContentClick);
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // dtgDevolver
            // 
            this.dtgDevolver.AllowUserToAddRows = false;
            this.dtgDevolver.AllowUserToDeleteRows = false;
            this.dtgDevolver.AllowUserToResizeColumns = false;
            this.dtgDevolver.AllowUserToResizeRows = false;
            this.dtgDevolver.AutoGenerateColumns = false;
            this.dtgDevolver.BackgroundColor = System.Drawing.Color.White;
            this.dtgDevolver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDevolver.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDevolver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDevolver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.titulo2dataGridViewTextBoxColumn2,
            this.dataGridViewButtonColumn1});
            this.dtgDevolver.DataSource = this.livrosBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDevolver.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgDevolver.EnableHeadersVisualStyles = false;
            this.dtgDevolver.Location = new System.Drawing.Point(950, 330);
            this.dtgDevolver.Name = "dtgDevolver";
            this.dtgDevolver.Size = new System.Drawing.Size(650, 465);
            this.dtgDevolver.TabIndex = 34;
            this.dtgDevolver.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDevolver_CellContentClick);
            // 
            // anoPublicDataGridViewTextBoxColumn
            // 
            this.anoPublicDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.anoPublicDataGridViewTextBoxColumn.DataPropertyName = "Ano_Public";
            this.anoPublicDataGridViewTextBoxColumn.FillWeight = 150F;
            this.anoPublicDataGridViewTextBoxColumn.HeaderText = "Publicação";
            this.anoPublicDataGridViewTextBoxColumn.Name = "anoPublicDataGridViewTextBoxColumn";
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.FillWeight = 150F;
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 150F;
            this.Column1.HeaderText = "Emprestar";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Emprestar";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(175)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1493, 162);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton1.Size = new System.Drawing.Size(110, 44);
            this.iconButton1.TabIndex = 32;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OBeco.Properties.Resources.Rectangle_20;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1695, 132);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ano_Public";
            this.dataGridViewTextBoxColumn1.FillWeight = 150F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Publicação";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // titulo2dataGridViewTextBoxColumn2
            // 
            this.titulo2dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titulo2dataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.titulo2dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.titulo2dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.titulo2dataGridViewTextBoxColumn2.Name = "titulo2dataGridViewTextBoxColumn2";
            this.titulo2dataGridViewTextBoxColumn2.ToolTipText = "Titulo";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn1.FillWeight = 150F;
            this.dataGridViewButtonColumn1.HeaderText = "Devolver";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Devolver";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // Emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 881);
            this.Controls.Add(this.dtgDevolver);
            this.Controls.Add(this.dtgDisponiveis);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Emprestimo";
            this.Text = "Emprestimo";
            this.Load += new System.EventHandler(this.Emprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisponiveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView dtgDisponiveis;
        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private bibliotecaDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.DataGridView dtgDevolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoPublicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo2dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}