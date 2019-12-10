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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAluno aluno = new FormAluno();
            aluno.MdiParent = this;
            aluno.Show();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionario funcionario = new FormFuncionario();
            funcionario.MdiParent = this;
            funcionario.Show();
        }

        private void emprestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmprestimo emprestimo = new FormEmprestimo();
            emprestimo.MdiParent = this;
            emprestimo.Show();
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLivro livro = new FormLivro();
            livro.MdiParent = this;
            livro.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
