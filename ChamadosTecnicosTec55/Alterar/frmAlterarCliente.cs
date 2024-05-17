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
    public partial class frmAlterarCliente : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;

        public frmAlterarCliente(int codigo)
        {
            InitializeComponent();

            // Verifica se o código é maior que zero 
            if(codigo > 0)
            {
                // Cria uma instância do objeto Cliente
                Cliente cliente = new Cliente();
                ClienteDao clientedao = new ClienteDao(_conexao);

                cliente = clientedao.ObtemCliente(codigo);

                //Se o cliente não foi encontrado
                if(cliente == null )
                {
                    MessageBox.Show("Cliente não encontrado");
                    this.Close();
                }

                txbCod.Text = cliente.CodigoCliente.ToString();
                txbNome.Text = cliente.Nome;
                txbProf.Text = cliente.Profissao;
                TxbSetor.Text = cliente.Setor;
                TxbObs.Text = cliente.Obs;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteDao clienteDao = new ClienteDao(_conexao);

            try
            {
                cliente.Nome = txbNome.Text;
                cliente.Profissao = txbProf.Text;
                cliente.Setor = TxbSetor.Text;
                cliente.Obs = TxbObs.Text;

                int codigo = Convert.ToInt32(txbCod.Text);

                cliente.CodigoCliente = codigo;

                clienteDao.AlteraCliente(cliente);
                this.Close();

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
    }
}
