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
    public partial class FrmAlterarTecnico : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;

        public FrmAlterarTecnico(int codigo)
        {
            InitializeComponent();
            // Verifica se o código é maior que zero 
            if (codigo > 0)
            {
                // Cria uma instância do objeto Cliente
                Tecnico tecnico = new Tecnico();
                TecnicoDao tecnicoDao = new TecnicoDao(_conexao);

                tecnico = tecnicoDao.ObtemTecnico(codigo);

                //Se o cliente não foi encontrado
                if (tecnico == null)
                {
                    MessageBox.Show("Cliente não encontrado");
                    this.Close();
                }

                txbCod.Text = tecnico.CodigoTecnico.ToString();
                txbNome.Text = tecnico.Nome;
                txbEsp.Text = tecnico.Especialidade;
                TxbEmail.Text = tecnico.Email;
                txtSenha.Text = tecnico.Senha;
                TxbObs.Text = tecnico.Obs;
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Tecnico tecnico = new Tecnico();
            TecnicoDao tecnicoDao = new TecnicoDao(_conexao);

            try
            {
                tecnico.Nome = txbNome.Text;
                tecnico.Especialidade = txbEsp.Text;
                tecnico.Email = TxbEmail.Text;
                tecnico.Senha = txtSenha.Text;
                tecnico.Obs = TxbObs.Text;

                int codigo = Convert.ToInt32(txbCod.Text);

                tecnico.CodigoTecnico = codigo;

                tecnicoDao.AlteraTecnico(tecnico);
                this.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            Tecnico tecnico = new Tecnico();
            TecnicoDao tecnicoDao = new TecnicoDao(_conexao);

            try
            {
                tecnico.Nome = txbNome.Text;
                tecnico.Especialidade = txbEsp.Text;
                tecnico.Senha = txtSenha.Text;
                tecnico.Email = TxbEmail.Text;
                tecnico.Obs = TxbObs.Text;

                int codigo = Convert.ToInt32(txbCod.Text);

                tecnico.CodigoTecnico = codigo;

                tecnicoDao.AlteraTecnico(tecnico);
                this.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

