namespace Empresa.UI.Windows
{
    partial class principalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botaoPainel = new System.Windows.Forms.Panel();
            this.botaoFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.fichaPanel = new System.Windows.Forms.Panel();
            this.listaDataGridView = new System.Windows.Forms.DataGridView();
            this.idLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.novoButton = new System.Windows.Forms.Button();
            this.atualizarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.confirmarNovoButton = new System.Windows.Forms.Button();
            this.confirmarAlterarButton = new System.Windows.Forms.Button();
            this.confirmarExcluirButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.botaoPainel.SuspendLayout();
            this.botaoFlowLayoutPanel.SuspendLayout();
            this.fichaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // botaoPainel
            // 
            this.botaoPainel.Controls.Add(this.botaoFlowLayoutPanel);
            this.botaoPainel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botaoPainel.Location = new System.Drawing.Point(0, 336);
            this.botaoPainel.Name = "botaoPainel";
            this.botaoPainel.Size = new System.Drawing.Size(877, 56);
            this.botaoPainel.TabIndex = 1;
            // 
            // botaoFlowLayoutPanel
            // 
            this.botaoFlowLayoutPanel.Controls.Add(this.novoButton);
            this.botaoFlowLayoutPanel.Controls.Add(this.atualizarButton);
            this.botaoFlowLayoutPanel.Controls.Add(this.excluirButton);
            this.botaoFlowLayoutPanel.Controls.Add(this.confirmarNovoButton);
            this.botaoFlowLayoutPanel.Controls.Add(this.confirmarAlterarButton);
            this.botaoFlowLayoutPanel.Controls.Add(this.confirmarExcluirButton);
            this.botaoFlowLayoutPanel.Controls.Add(this.sairButton);
            this.botaoFlowLayoutPanel.Controls.Add(this.voltarButton);
            this.botaoFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botaoFlowLayoutPanel.Location = new System.Drawing.Point(0, 3);
            this.botaoFlowLayoutPanel.Name = "botaoFlowLayoutPanel";
            this.botaoFlowLayoutPanel.Size = new System.Drawing.Size(877, 53);
            this.botaoFlowLayoutPanel.TabIndex = 0;
            // 
            // fichaPanel
            // 
            this.fichaPanel.Controls.Add(this.telefoneTextBox);
            this.fichaPanel.Controls.Add(this.emailTextBox);
            this.fichaPanel.Controls.Add(this.nomeTextBox);
            this.fichaPanel.Controls.Add(this.idTextBox);
            this.fichaPanel.Controls.Add(this.telefoneLabel);
            this.fichaPanel.Controls.Add(this.emailLabel);
            this.fichaPanel.Controls.Add(this.nomeLabel);
            this.fichaPanel.Controls.Add(this.idLabel);
            this.fichaPanel.Location = new System.Drawing.Point(0, 27);
            this.fichaPanel.Name = "fichaPanel";
            this.fichaPanel.Size = new System.Drawing.Size(437, 303);
            this.fichaPanel.TabIndex = 2;
            // 
            // listaDataGridView
            // 
            this.listaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDataGridView.Location = new System.Drawing.Point(443, 27);
            this.listaDataGridView.Name = "listaDataGridView";
            this.listaDataGridView.Size = new System.Drawing.Size(422, 303);
            this.listaDataGridView.TabIndex = 3;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(128, 26);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Id:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(109, 86);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(112, 156);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email:";
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(95, 231);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(52, 13);
            this.telefoneLabel.TabIndex = 3;
            this.telefoneLabel.Text = "Telefone:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(153, 23);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(64, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(153, 83);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(232, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(153, 153);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(232, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(153, 228);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(232, 20);
            this.telefoneTextBox.TabIndex = 7;
            // 
            // novoButton
            // 
            this.novoButton.Location = new System.Drawing.Point(3, 3);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 0;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // atualizarButton
            // 
            this.atualizarButton.Location = new System.Drawing.Point(84, 3);
            this.atualizarButton.Name = "atualizarButton";
            this.atualizarButton.Size = new System.Drawing.Size(75, 23);
            this.atualizarButton.TabIndex = 1;
            this.atualizarButton.Text = "Atualizar";
            this.atualizarButton.UseVisualStyleBackColor = true;
            this.atualizarButton.Click += new System.EventHandler(this.atualizarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(165, 3);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 2;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // confirmarNovoButton
            // 
            this.confirmarNovoButton.Location = new System.Drawing.Point(246, 3);
            this.confirmarNovoButton.Name = "confirmarNovoButton";
            this.confirmarNovoButton.Size = new System.Drawing.Size(75, 23);
            this.confirmarNovoButton.TabIndex = 3;
            this.confirmarNovoButton.Text = "Inserir";
            this.confirmarNovoButton.UseVisualStyleBackColor = true;
            this.confirmarNovoButton.Click += new System.EventHandler(this.confirmarNovoButton_Click);
            // 
            // confirmarAlterarButton
            // 
            this.confirmarAlterarButton.Location = new System.Drawing.Point(327, 3);
            this.confirmarAlterarButton.Name = "confirmarAlterarButton";
            this.confirmarAlterarButton.Size = new System.Drawing.Size(110, 23);
            this.confirmarAlterarButton.TabIndex = 4;
            this.confirmarAlterarButton.Text = "Confirmar Alteração";
            this.confirmarAlterarButton.UseVisualStyleBackColor = true;
            this.confirmarAlterarButton.Click += new System.EventHandler(this.confirmarAlterarButton_Click);
            // 
            // confirmarExcluirButton
            // 
            this.confirmarExcluirButton.Location = new System.Drawing.Point(443, 3);
            this.confirmarExcluirButton.Name = "confirmarExcluirButton";
            this.confirmarExcluirButton.Size = new System.Drawing.Size(127, 23);
            this.confirmarExcluirButton.TabIndex = 5;
            this.confirmarExcluirButton.Text = "Confirmar Exclusão";
            this.confirmarExcluirButton.UseVisualStyleBackColor = true;
            this.confirmarExcluirButton.Click += new System.EventHandler(this.confirmarExcluirButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(576, 3);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 6;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(657, 3);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(75, 23);
            this.voltarButton.TabIndex = 7;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // principalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 392);
            this.Controls.Add(this.listaDataGridView);
            this.Controls.Add(this.fichaPanel);
            this.Controls.Add(this.botaoPainel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "principalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.principalForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.botaoPainel.ResumeLayout(false);
            this.botaoFlowLayoutPanel.ResumeLayout(false);
            this.fichaPanel.ResumeLayout(false);
            this.fichaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.Panel botaoPainel;
        private System.Windows.Forms.FlowLayoutPanel botaoFlowLayoutPanel;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button atualizarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button confirmarNovoButton;
        private System.Windows.Forms.Button confirmarAlterarButton;
        private System.Windows.Forms.Button confirmarExcluirButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Panel fichaPanel;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label telefoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.DataGridView listaDataGridView;
    }
}

