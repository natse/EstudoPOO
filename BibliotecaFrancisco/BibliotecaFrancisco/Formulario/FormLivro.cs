using BibliotecaFrancisco.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaFrancisco.Formulario
{
    public partial class FormLivro : Form
    {
        public FormLivro()
        {
            InitializeComponent();
        }

        private void btnSalvarLivro_Click(object sender, EventArgs e)
        {
            Livro salva = new Livro();
            salva.Autor = txtAutor.Text;
            salva.DataPublicacao = dateTimeEvolusaoLivro.Value;
            salva.Editora = txtEditora.Text;
            salva.Titulo = txtTitulo.Text;
            salva.Salva();
            MessageBox.Show("Sucesso");
        }

        private void btnAlteraLivro_Click(object sender, EventArgs e)
        {
            Livro altera = new Livro();
            altera.Autor = txtAutor.Text;
            altera.DataPublicacao = dateTimeEvolusaoLivro.Value;
            altera.Editora = txtEditora.Text;
            altera.Titulo = txtTitulo.Text;
            btnAlteraLivro.Update();
        }

        private void btnExcluirLivro_Click(object sender, EventArgs e)
        {
            Livro excluir = new Livro();
            excluir.Autor = txtAutor.Text;
            excluir.DataPublicacao = dateTimeEvolusaoLivro.Value;
            excluir.Editora = txtEditora.Text;
            excluir.Titulo = txtTitulo.Text;
            excluir.Excluir();
        }

        private void btnNovoLivro_Click(object sender, EventArgs e)
        {
            Livro novo = new Livro();
            novo.Autor = txtAutor.Text;
            novo.DataPublicacao = dateTimeEvolusaoLivro.Value;
            novo.Editora = txtEditora.Text;
            novo.Titulo = txtTitulo.Text;
            novo.novo();
        }
    }
}
