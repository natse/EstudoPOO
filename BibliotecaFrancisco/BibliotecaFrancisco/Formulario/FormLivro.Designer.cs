namespace BibliotecaFrancisco.Formulario
{
    partial class FormLivro
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbLivro = new System.Windows.Forms.GroupBox();
            this.textBoxLivro = new System.Windows.Forms.TextBox();
            this.labLivroLivro = new System.Windows.Forms.Label();
            this.dateTimeEvolusaoLivro = new System.Windows.Forms.DateTimePicker();
            this.labDataDEvolusaoEmprestimo = new System.Windows.Forms.Label();
            this.dateDataPublicacaoLivro = new System.Windows.Forms.DateTimePicker();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnNovoLivro = new System.Windows.Forms.Button();
            this.btnExcluirLivro = new System.Windows.Forms.Button();
            this.btnAlteraLivro = new System.Windows.Forms.Button();
            this.btnSalvarLivro = new System.Windows.Forms.Button();
            this.lblEditora = new System.Windows.Forms.Label();
            this.lblDataPublicacaoLivro = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.bgBuscarLivros = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridLivro = new System.Windows.Forms.DataGridView();
            this.gbLivro.SuspendLayout();
            this.bgBuscarLivros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(16, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(39, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo :";
            // 
            // gbLivro
            // 
            this.gbLivro.Controls.Add(this.textBoxLivro);
            this.gbLivro.Controls.Add(this.labLivroLivro);
            this.gbLivro.Controls.Add(this.dateTimeEvolusaoLivro);
            this.gbLivro.Controls.Add(this.labDataDEvolusaoEmprestimo);
            this.gbLivro.Controls.Add(this.dateDataPublicacaoLivro);
            this.gbLivro.Controls.Add(this.txtEditora);
            this.gbLivro.Controls.Add(this.txtAutor);
            this.gbLivro.Controls.Add(this.txtTitulo);
            this.gbLivro.Controls.Add(this.btnNovoLivro);
            this.gbLivro.Controls.Add(this.btnExcluirLivro);
            this.gbLivro.Controls.Add(this.btnAlteraLivro);
            this.gbLivro.Controls.Add(this.btnSalvarLivro);
            this.gbLivro.Controls.Add(this.lblEditora);
            this.gbLivro.Controls.Add(this.lblDataPublicacaoLivro);
            this.gbLivro.Controls.Add(this.lblAutor);
            this.gbLivro.Controls.Add(this.lblTitulo);
            this.gbLivro.Location = new System.Drawing.Point(12, 7);
            this.gbLivro.Name = "gbLivro";
            this.gbLivro.Size = new System.Drawing.Size(605, 257);
            this.gbLivro.TabIndex = 1;
            this.gbLivro.TabStop = false;
            this.gbLivro.Text = "Livros";
            // 
            // textBoxLivro
            // 
            this.textBoxLivro.Location = new System.Drawing.Point(136, 65);
            this.textBoxLivro.Name = "textBoxLivro";
            this.textBoxLivro.Size = new System.Drawing.Size(100, 20);
            this.textBoxLivro.TabIndex = 17;
            // 
            // labLivroLivro
            // 
            this.labLivroLivro.AutoSize = true;
            this.labLivroLivro.Location = new System.Drawing.Point(16, 65);
            this.labLivroLivro.Name = "labLivroLivro";
            this.labLivroLivro.Size = new System.Drawing.Size(30, 13);
            this.labLivroLivro.TabIndex = 16;
            this.labLivroLivro.Text = "Livro";
            // 
            // dateTimeEvolusaoLivro
            // 
            this.dateTimeEvolusaoLivro.Location = new System.Drawing.Point(136, 119);
            this.dateTimeEvolusaoLivro.Name = "dateTimeEvolusaoLivro";
            this.dateTimeEvolusaoLivro.Size = new System.Drawing.Size(200, 20);
            this.dateTimeEvolusaoLivro.TabIndex = 15;
            // 
            // labDataDEvolusaoEmprestimo
            // 
            this.labDataDEvolusaoEmprestimo.AutoSize = true;
            this.labDataDEvolusaoEmprestimo.Location = new System.Drawing.Point(16, 125);
            this.labDataDEvolusaoEmprestimo.Name = "labDataDEvolusaoEmprestimo";
            this.labDataDEvolusaoEmprestimo.Size = new System.Drawing.Size(103, 13);
            this.labDataDEvolusaoEmprestimo.TabIndex = 14;
            this.labDataDEvolusaoEmprestimo.Text = "Data da Devolução ";
            // 
            // dateDataPublicacaoLivro
            // 
            this.dateDataPublicacaoLivro.Location = new System.Drawing.Point(136, 171);
            this.dateDataPublicacaoLivro.Name = "dateDataPublicacaoLivro";
            this.dateDataPublicacaoLivro.Size = new System.Drawing.Size(200, 20);
            this.dateDataPublicacaoLivro.TabIndex = 11;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(489, 65);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(100, 20);
            this.txtEditora.TabIndex = 10;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(489, 19);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 9;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(136, 29);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 8;
            // 
            // btnNovoLivro
            // 
            this.btnNovoLivro.Location = new System.Drawing.Point(386, 215);
            this.btnNovoLivro.Name = "btnNovoLivro";
            this.btnNovoLivro.Size = new System.Drawing.Size(75, 23);
            this.btnNovoLivro.TabIndex = 7;
            this.btnNovoLivro.Text = "Novo";
            this.btnNovoLivro.UseVisualStyleBackColor = true;
            this.btnNovoLivro.Click += new System.EventHandler(this.btnNovoLivro_Click);
            // 
            // btnExcluirLivro
            // 
            this.btnExcluirLivro.Location = new System.Drawing.Point(292, 215);
            this.btnExcluirLivro.Name = "btnExcluirLivro";
            this.btnExcluirLivro.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirLivro.TabIndex = 6;
            this.btnExcluirLivro.Text = "Excluir";
            this.btnExcluirLivro.UseVisualStyleBackColor = true;
            this.btnExcluirLivro.Click += new System.EventHandler(this.btnExcluirLivro_Click);
            // 
            // btnAlteraLivro
            // 
            this.btnAlteraLivro.Location = new System.Drawing.Point(195, 215);
            this.btnAlteraLivro.Name = "btnAlteraLivro";
            this.btnAlteraLivro.Size = new System.Drawing.Size(75, 23);
            this.btnAlteraLivro.TabIndex = 5;
            this.btnAlteraLivro.Text = "Altera";
            this.btnAlteraLivro.UseVisualStyleBackColor = true;
            this.btnAlteraLivro.Click += new System.EventHandler(this.btnAlteraLivro_Click);
            // 
            // btnSalvarLivro
            // 
            this.btnSalvarLivro.Location = new System.Drawing.Point(105, 215);
            this.btnSalvarLivro.Name = "btnSalvarLivro";
            this.btnSalvarLivro.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarLivro.TabIndex = 4;
            this.btnSalvarLivro.Text = "Salvar";
            this.btnSalvarLivro.UseVisualStyleBackColor = true;
            this.btnSalvarLivro.Click += new System.EventHandler(this.btnSalvarLivro_Click);
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(378, 74);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(40, 13);
            this.lblEditora.TabIndex = 3;
            this.lblEditora.Text = "Editora";
            // 
            // lblDataPublicacaoLivro
            // 
            this.lblDataPublicacaoLivro.AutoSize = true;
            this.lblDataPublicacaoLivro.Location = new System.Drawing.Point(8, 177);
            this.lblDataPublicacaoLivro.Name = "lblDataPublicacaoLivro";
            this.lblDataPublicacaoLivro.Size = new System.Drawing.Size(86, 13);
            this.lblDataPublicacaoLivro.TabIndex = 2;
            this.lblDataPublicacaoLivro.Text = "Data Publicação";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(378, 26);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(38, 13);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor :";
            // 
            // bgBuscarLivros
            // 
            this.bgBuscarLivros.Controls.Add(this.txtBuscar);
            this.bgBuscarLivros.Controls.Add(this.btnBuscar);
            this.bgBuscarLivros.Controls.Add(this.dataGridLivro);
            this.bgBuscarLivros.Location = new System.Drawing.Point(12, 297);
            this.bgBuscarLivros.Name = "bgBuscarLivros";
            this.bgBuscarLivros.Size = new System.Drawing.Size(605, 141);
            this.bgBuscarLivros.TabIndex = 2;
            this.bgBuscarLivros.TabStop = false;
            this.bgBuscarLivros.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(67, 48);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(415, 20);
            this.txtBuscar.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(489, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridLivro
            // 
            this.dataGridLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLivro.Location = new System.Drawing.Point(9, 77);
            this.dataGridLivro.Name = "dataGridLivro";
            this.dataGridLivro.Size = new System.Drawing.Size(554, 91);
            this.dataGridLivro.TabIndex = 0;
            // 
            // FormLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.bgBuscarLivros);
            this.Controls.Add(this.gbLivro);
            this.Name = "FormLivro";
            this.Text = "FormLivro";
            this.gbLivro.ResumeLayout(false);
            this.gbLivro.PerformLayout();
            this.bgBuscarLivros.ResumeLayout(false);
            this.bgBuscarLivros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbLivro;
        private System.Windows.Forms.Label lblDataPublicacaoLivro;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.DateTimePicker dateDataPublicacaoLivro;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnNovoLivro;
        private System.Windows.Forms.Button btnExcluirLivro;
        private System.Windows.Forms.Button btnAlteraLivro;
        private System.Windows.Forms.Button btnSalvarLivro;
        private System.Windows.Forms.GroupBox bgBuscarLivros;
        private System.Windows.Forms.DataGridView dataGridLivro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dateTimeEvolusaoLivro;
        private System.Windows.Forms.Label labDataDEvolusaoEmprestimo;
        private System.Windows.Forms.TextBox textBoxLivro;
        private System.Windows.Forms.Label labLivroLivro;
    }

}
