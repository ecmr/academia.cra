using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaCondominio
{
    public partial class FrmControleAcesso : Form
    {
        public FrmControleAcesso()
        {
            InitializeComponent();
        }

        private void FrmControleAcesso_Load(object sender, EventArgs e)
        {
            CarregarPacotes();
        }

        private void CarregarPacotes()
        {
            lstVPacotesDisponiveis.Items.Add("Configurações");
            lstVPacotesDisponiveis.Items.Add("Empregador");
            lstVPacotesDisponiveis.Items.Add("Usuários");
            lstVPacotesDisponiveis.Items.Add("Data Hora");
            lstVPacotesDisponiveis.Items.Add("Biometria");
            lstVPacotesDisponiveis.Items.Add("Registros");
            lstVPacotesDisponiveis.Items.Add("Quantidade e Status");
            lstVPacotesDisponiveis.Items.Add("Cartão");
            lstVPacotesDisponiveis.Items.Add("Grupo de Acesso");
            lstVPacotesDisponiveis.Items.Add("Cartão Grupo de Acesso");
            lstVPacotesDisponiveis.Items.Add("Acionamento");
            lstVPacotesDisponiveis.Items.Add("Período");
            lstVPacotesDisponiveis.Items.Add("Horário");
            lstVPacotesDisponiveis.Items.Add("Feriado");
            lstVPacotesDisponiveis.Items.Add("Mensagem");
            lstVPacotesDisponiveis.Items.Add("Evento Online");
            lstVPacotesDisponiveis.Items.Add("Arquivo");
        }
    }
}
