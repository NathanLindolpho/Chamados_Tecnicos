using ChamadosTecnicosTec55.Adicionar;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55.Alterar
{
    public partial class frmGerirTecnicos : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frmGerirTecnicos()
        {
            InitializeComponent();
        }
        private void ListarTecnicos()
        {
            // Chama o Tecnico DAO 
            TecnicoDao tecnicoDao = new TecnicoDao(_conexao);
            // Captura o valor digitado na barra texto TXB
            string busca = txbBuscar.Text.ToString();
            // Chama o Metodo BuscaTecnico do objeto 
            DataSet ds = new DataSet();
            ds = tecnicoDao.BuscaTecnico(busca);
            // Defini o DataSource do DataGridView
            dgvTecnico.DataSource = ds;
            // DEFINI O MEMBRO DO DATASET 
            dgvTecnico.DataMember = "Tecnicos";
        }


        private void btnIncluir_Click(object sender, EventArgs e)
        {
            var frmaddTecnico = new frmTecnicoAdicionar();
            frmaddTecnico.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txbBuscar.Text != "")
            {
                ListarTecnicos(); 
            }
            else
            {
                MessageBox.Show("Digite algo para buscar");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Verifique se algum linha está selecionada no DGV
            if (dgvTecnico.SelectedRows.Count > 0)
            {
                // obtém o código do cliente da linha selecionada
                int codigo = Convert.ToInt32(dgvTecnico.CurrentRow.Cells[0].Value);

                var frmAlterarTecnico = new FrmAlterarTecnico(codigo); 
                frmAlterarTecnico.ShowDialog();

                // Apos a tela fechar listar os clientes cadastrados 
                ListarTecnicos();
            }
            else
            {
                // Exibe uma mensagem de Aviso se nenhuma linha estiver selecionada
                MessageBox.Show("Selecione um registro para alteração");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Botao excluir
            //Selecionar Data grid ,  Capturar Id, ENviar para o Dao, Excluir
            if (dgvTecnico.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dgvTecnico.CurrentRow.Cells[0].Value);

                var resultado = MessageBox.Show("Deseja excluir ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resultado == DialogResult.Yes)
                {
                    TecnicoDao tecnicoDao = new TecnicoDao(_conexao);

                    tecnicoDao.ExcluiTecnico(codigo);
                    ListarTecnicos();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Registro!!!!");
            }
        }

        private void frmTecnicos_Load_1(object sender, EventArgs e)
        {
            ListarTecnicos();
        }
    }
}

