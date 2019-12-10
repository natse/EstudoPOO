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
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario salva = new Funcionario();
            salva.Cargo = txtNomeFuncinario.Text;
            salva.DataAdmissao = dateDataAdmitrassaoFuncionario.Value;
            salva.Matricula = textBoxMatriculoFuncionario.Text;
            salva.Pis = txtPisFuncionario.Text;
            salva.Cpf = mtxtCpfFuncinario.Text;
            salva.Matricula = textBoxMatriculoFuncionario.Text;
            salva.Nome = txtNomeFuncinario.Text;
            salva.Salva();
            MessageBox.Show("Sucesso");
        }

        private void btnAlterarFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario altera = new Funcionario();
            altera.Cargo = txtNomeFuncinario.Text;
            altera.DataAdmissao = dateDataAdmitrassaoFuncionario.Value;
            altera.Matricula = textBoxMatriculoFuncionario.Text;
            altera.Pis = txtPisFuncionario.Text;
            altera.Cpf = mtxtCpfFuncinario.Text;
            altera.Matricula = textBoxMatriculoFuncionario.Text;
            altera.Nome = txtNomeFuncinario.Text;
            btnAlterarFuncionario.Update();
        }

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario excluir = new Funcionario();
            excluir.Cargo = txtNomeFuncinario.Text;
            excluir.DataAdmissao = dateDataAdmitrassaoFuncionario.Value;
            excluir.Matricula = textBoxMatriculoFuncionario.Text;
            excluir.Pis = txtPisFuncionario.Text;
            excluir.Cpf = mtxtCpfFuncinario.Text;
            excluir.Matricula = textBoxMatriculoFuncionario.Text;
            excluir.Nome = txtNomeFuncinario.Text;
            excluir.Excluir();
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario novo = new Funcionario();
            novo.Cargo = txtNomeFuncinario.Text;
            novo.DataAdmissao = dateDataAdmitrassaoFuncionario.Value;
            novo.Matricula = textBoxMatriculoFuncionario.Text;
            novo.Pis = txtPisFuncionario.Text;
            novo.Cpf = mtxtCpfFuncinario.Text;
            novo.Matricula = textBoxMatriculoFuncionario.Text;
            novo.Nome = txtNomeFuncinario.Text;
            novo.novo();
        }
    }
}
