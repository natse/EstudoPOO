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
    public partial class FormEmprestimo : Form
    {
        public FormEmprestimo()
        {
            InitializeComponent();
        }

        private void btnSalvarLivro_Click(object sender, EventArgs e)
        {
            Emprestimo salva = new Emprestimo();
           
            
        }
    }
}
