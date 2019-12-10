
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
using BibliotecaFrancisco.DAO;





namespace BibliotecaFrancisco.Formulario
{
    public partial class FormAluno : Form
    {
        public FormAluno()
        {
            InitializeComponent();
        }
        public void BuscaLIsta()
        {
            Aluno aluno = new Aluno();
            aluno = aluno.FindAll();

        }
        private void btnSalvarAluno_Click(object sender, EventArgs e)
        {
            Aluno salva = new Aluno();
            salva.Cidade = txtCidadeAluno.Text;
            salva.Nome = txtNomeAluno.Text;
            salva.Cpf = txtCpfAluno.Text;
            salva.DataNascimento = DateDataDeNasciementoAluno.MaxDate;
            if (radioBtnSexoFeminino.Checked)
            {
                salva.Sexo = "F";
            }
            else
            {
                if (radBtnSexoMaculinoAluno.Checked)
                {
                    salva.Sexo = "M";
                }
            }
            salva.Numero = lblNumeroAluno.Text;
            salva.OrgaoExpeditor = txtOrgaoExpeditorAluno.Text;
            salva.Rg = txtRgAluno.Text;
            salva.Rua = txtRuaAluno.Text;
            salva.Sexo = radBtnSexoMaculinoAluno.Text;
            salva.Sexo = radioBtnSexoFeminino.Text;
            salva.Salva();
            MessageBox.Show("Sucesso");
           
        }

        private void btnAlterarAluno_Click(object sender, EventArgs e)
        {
            Aluno Altera = new Aluno();
            Altera.DataNascimento = DateDataDeNasciementoAluno.Value;
            if (radioBtnSexoFeminino.Checked)
            {
                Altera.Sexo = "F";
            }
            else
            {
                if (radBtnSexoMaculinoAluno.Checked)
                {
                    Altera.Sexo = "M";
                }
            }
            Altera.Cidade = txtCidadeAluno.Text;
            Altera.Nome = txtNomeAluno.Text;
            Altera.Cpf = txtCpfAluno.Text;
            Altera.Numero = lblNumeroAluno.Text;
            Altera.OrgaoExpeditor = txtOrgaoExpeditorAluno.Text;
            Altera.Rg = txtRgAluno.Text;
            Altera.Rua = txtRuaAluno.Text;
            Altera.Sexo = radBtnSexoMaculinoAluno.Text;
            Altera.Sexo = radioBtnSexoFeminino.Text;
            btnSalvarAluno.Update();
            
           
        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            Aluno excluir = new Aluno();
            excluir.DataNascimento = DateDataDeNasciementoAluno.Value;

            excluir.Cidade = txtCidadeAluno.Text;
            excluir.Nome = txtNomeAluno.Text;
            excluir.Cpf = txtCpfAluno.Text;
            excluir.Numero = lblNumeroAluno.Text;
            excluir.OrgaoExpeditor = txtOrgaoExpeditorAluno.Text;
            excluir.Rg = txtRgAluno.Text;
            excluir.Rua = txtRuaAluno.Text;
            excluir.Sexo = radBtnSexoMaculinoAluno.Text;
            excluir.Sexo = radioBtnSexoFeminino.Text;
            excluir.Excluir();

        }

        private void btnNovoAluno_Click(object sender, EventArgs e)
        {
            Aluno novo = new Aluno();
            novo.DataNascimento = DateDataDeNasciementoAluno.Value;

            novo.Cidade = txtCidadeAluno.Text;
            novo.Nome = txtNomeAluno.Text;
            novo.Cpf = txtCpfAluno.Text;
            novo.Numero = lblNumeroAluno.Text;
            novo.OrgaoExpeditor = txtOrgaoExpeditorAluno.Text;
            novo.Rg = txtRgAluno.Text;
            novo.Rua = txtRuaAluno.Text;
            novo.Sexo = radBtnSexoMaculinoAluno.Text;
            novo.Sexo = radioBtnSexoFeminino.Text;
            novo.Novo();
        }
    }
}
