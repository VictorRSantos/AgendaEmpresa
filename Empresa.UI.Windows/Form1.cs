using Empresa.Db;
using Empresa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa.UI.Windows
{
    public partial class principalForm : Form
    {
        public principalForm()
        {
            InitializeComponent();
           
        }

        //Metodos
        //Formatação DataGrid
        public void ExibirGrid()
        {
            listaDataGridView.Visible = true;
            listaDataGridView.Dock = DockStyle.Fill;
            fichaPanel.Visible = false;

            novoButton.Visible = true;
            atualizarButton.Visible = true;
            excluirButton.Visible = true;
            sairButton.Visible = true;


            confirmarNovoButton.Visible = false;
            confirmarExcluirButton.Visible = false;
            confirmarAlterarButton.Visible = false;
            voltarButton.Visible = false;

            var db = new ClienteDb();

            //Colocar a lista na grid
            listaDataGridView.DataSource = db.Listar();

            //AJustes na Grid
            listaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listaDataGridView.ReadOnly = false;

            //Ocupar Toda a Tela
            listaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Excluir Seletor de Linhas
            listaDataGridView.RowHeadersVisible = false;

            //Tirar a identidade do Windows
            listaDataGridView.EnableHeadersVisualStyles = false;

            //Ajustar os campos da Grip
            listaDataGridView.Columns["Id"].Width = 50;
            


            

        }

        public void EscoderLayout()
        {
            fichaPanel.Visible = false;
            listaDataGridView.Visible = false;
            botaoPainel.Visible = false;
        }

        //Exibir Ficha
        public void ExibirFicha()
        {
            fichaPanel.Visible = true;
            fichaPanel.Dock = DockStyle.Fill;

            listaDataGridView.Visible = false;

            novoButton.Visible = false;
            atualizarButton.Visible = false;
            excluirButton.Visible = false;
            sairButton.Visible = false;

            confirmarAlterarButton.Visible = false;
            confirmarExcluirButton.Visible = false;
            confirmarNovoButton.Visible = true;
            voltarButton.Visible = true;

        }


        //Limpar Botao
        public void LimpaFicha()
        {
            idTextBox.Clear();
            nomeTextBox.Clear();
            emailTextBox.Clear();
            telefoneTextBox.Clear();

            nomeTextBox.Focus();
        }


        private void principalForm_Load(object sender, EventArgs e)
        {
            EscoderLayout();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirGrid();
            botaoPainel.Visible = true;

        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            ExibirFicha();

            confirmarExcluirButton.Visible = false;
            confirmarAlterarButton.Visible = false;
            confirmarNovoButton.Visible = true;
            idLabel.Visible = false;
            idTextBox.Visible = false;
            LimpaFicha();            


        }

        private void confirmarNovoButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();


            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Telefone = telefoneTextBox.Text;


            var db = new ClienteDb();
            db.Inserir(cliente);

            ExibirGrid();


        }

        private void atualizarButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listaDataGridView.CurrentRow.DataBoundItem;

            idTextBox.Text = cliente.Id.ToString();
            nomeTextBox.Text = cliente.Nome;
            emailTextBox.Text = cliente.Email;
            telefoneTextBox.Text = cliente.Telefone;

            ExibirFicha();

            confirmarAlterarButton.Visible = true;
            confirmarNovoButton.Visible = false;
            confirmarExcluirButton.Visible = false;
            



            
        }

        private void confirmarAlterarButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listaDataGridView.CurrentRow.DataBoundItem;


            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Telefone = telefoneTextBox.Text;


            var db = new ClienteDb();
            db.Atualizar(cliente);

            ExibirGrid();

        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listaDataGridView.CurrentRow.DataBoundItem;

            idTextBox.Text = cliente.Id.ToString();
            nomeTextBox.Text = cliente.Nome;
            emailTextBox.Text = cliente.Email;
            telefoneTextBox.Text = cliente.Telefone;

            ExibirFicha();

            confirmarAlterarButton.Visible = false;
            confirmarNovoButton.Visible = false;
            confirmarExcluirButton.Visible = true;



        }

        private void confirmarExcluirButton_Click(object sender, EventArgs e)
        {

            Cliente cliente = (Cliente)listaDataGridView.CurrentRow.DataBoundItem;


            cliente.Id = Convert.ToInt32(idTextBox.Text);


            var db = new ClienteDb();
            db.Excluir(cliente.Id);

            ExibirGrid();



        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            ExibirGrid();
        }
    }
}
