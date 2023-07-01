namespace OBeco
{
    partial class Reserva
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgReservas = new System.Windows.Forms.DataGridView();
            this.livrosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet2 = new OBeco.bibliotecaDataSet2();
            this.dtgDisponiveis = new System.Windows.Forms.DataGridView();
            this.anoPublicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmprestarDataGridViewButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet1 = new OBeco.bibliotecaDataSet1();
            this.livrosTableAdapter = new OBeco.bibliotecaDataSet1TableAdapters.LivrosTableAdapter();
            this.livrosTableAdapter1 = new OBeco.bibliotecaDataSet2TableAdapters.LivrosTableAdapter();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.anoPublicDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo2DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisponiveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(175)))));
            this.label3.Location = new System.Drawing.Point(1107, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 56);
            this.label3.TabIndex = 27;
            this.label3.Text = "Livros Reservados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(175)))));
            this.label2.Location = new System.Drawing.Point(174, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 56);
            this.label2.TabIndex = 26;
            this.label2.Text = "Livros Disponíveis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(175)))));
            this.label1.Location = new System.Drawing.Point(7, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 84);
            this.label1.TabIndex = 25;
            this.label1.Text = "Reservas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OBeco.Properties.Resources.Rectangle_20;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1695, 132);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // dtgReservas
            // 
            this.dtgReservas.AllowUserToAddRows = false;
            this.dtgReservas.AllowUserToDeleteRows = false;
            this.dtgReservas.AllowUserToResizeColumns = false;
            this.dtgReservas.AllowUserToResizeRows = false;
            this.dtgReservas.AutoGenerateColumns = false;
            this.dtgReservas.BackgroundColor = System.Drawing.Color.White;
            this.dtgReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anoPublicDataGridViewTextBoxColumn1,
            this.titulo2DataGridViewTextBoxColumn2,
            this.dataGridViewButtonColumn1});
            this.dtgReservas.DataSource = this.livrosBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgReservas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgReservas.EnableHeadersVisualStyles = false;
            this.dtgReservas.Location = new System.Drawing.Point(950, 330);
            this.dtgReservas.Name = "dtgReservas";
            this.dtgReservas.Size = new System.Drawing.Size(650, 465);
            this.dtgReservas.TabIndex = 36;
            this.dtgReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgReservas_CellContentClick);
            // 
            // livrosBindingSource1
            // 
            this.livrosBindingSource1.DataMember = "Livros";
            this.livrosBindingSource1.DataSource = this.bibliotecaDataSet2;
            // 
            // bibliotecaDataSet2
            // 
            this.bibliotecaDataSet2.DataSetName = "bibliotecaDataSet2";
            this.bibliotecaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDisponiveis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDisponiveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anoPublicDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.EmprestarDataGridViewButtonColumn});
            this.dtgDisponiveis.DataSource = this.livrosBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDisponiveis.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgDisponiveis.EnableHeadersVisualStyles = false;
            this.dtgDisponiveis.Location = new System.Drawing.Point(40, 330);
            this.dtgDisponiveis.Name = "dtgDisponiveis";
            this.dtgDisponiveis.Size = new System.Drawing.Size(650, 465);
            this.dtgDisponiveis.TabIndex = 35;
            this.dtgDisponiveis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDisponiveis_CellContentClick);
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
            // EmprestarDataGridViewButtonColumn
            // 
            this.EmprestarDataGridViewButtonColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmprestarDataGridViewButtonColumn.FillWeight = 150F;
            this.EmprestarDataGridViewButtonColumn.HeaderText = "Reservar";
            this.EmprestarDataGridViewButtonColumn.Name = "EmprestarDataGridViewButtonColumn";
            this.EmprestarDataGridViewButtonColumn.Text = "Reservar";
            this.EmprestarDataGridViewButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.bibliotecaDataSet1;
            // 
            // bibliotecaDataSet1
            // 
            this.bibliotecaDataSet1.DataSetName = "bibliotecaDataSet1";
            this.bibliotecaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // livrosTableAdapter1
            // 
            this.livrosTableAdapter1.ClearBeforeFill = true;
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
            this.iconButton1.TabIndex = 37;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // anoPublicDataGridViewTextBoxColumn1
            // 
            this.anoPublicDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.anoPublicDataGridViewTextBoxColumn1.DataPropertyName = "Ano_Public";
            this.anoPublicDataGridViewTextBoxColumn1.FillWeight = 150F;
            this.anoPublicDataGridViewTextBoxColumn1.HeaderText = "Publicação";
            this.anoPublicDataGridViewTextBoxColumn1.Name = "anoPublicDataGridViewTextBoxColumn1";
            // 
            // titulo2DataGridViewTextBoxColumn2
            // 
            this.titulo2DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titulo2DataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.titulo2DataGridViewTextBoxColumn2.FillWeight = 150F;
            this.titulo2DataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.titulo2DataGridViewTextBoxColumn2.Name = "titulo2DataGridViewTextBoxColumn2";
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
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 881);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dtgReservas);
            this.Controls.Add(this.dtgDisponiveis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Reserva";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.Reserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisponiveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgReservas;
        private System.Windows.Forms.DataGridView dtgDisponiveis;
        private bibliotecaDataSet1 bibliotecaDataSet1;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private bibliotecaDataSet1TableAdapters.LivrosTableAdapter livrosTableAdapter;
        private bibliotecaDataSet2 bibliotecaDataSet2;
        private System.Windows.Forms.BindingSource livrosBindingSource1;
        private bibliotecaDataSet2TableAdapters.LivrosTableAdapter livrosTableAdapter1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoPublicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EmprestarDataGridViewButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoPublicDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo2DataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}