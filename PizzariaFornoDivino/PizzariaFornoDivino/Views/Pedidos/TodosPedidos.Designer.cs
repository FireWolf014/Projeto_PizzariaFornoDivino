namespace PizzariaFornoDivino.Views.Pedidos
{
    partial class TodosPedidos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodosPedidos));
            btnAtualizar = new Button();
            txtBusca = new Panel();
            textBox1 = new TextBox();
            brnPesquisa = new Button();
            btnExcluir = new Button();
            panel2 = new Panel();
            btnAlterar = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            dgvPedidos = new DataGridView();
            Codigo_pedido = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Endereço = new DataGridViewTextBoxColumn();
            Complemento = new DataGridViewTextBoxColumn();
            Descrição = new DataGridViewTextBoxColumn();
            Forma_de_pagamento = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Valor_unitario = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Data_inclusão = new DataGridViewTextBoxColumn();
            Data_alterasão = new DataGridViewTextBoxColumn();
            txtBusca.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // btnAtualizar
            // 
            btnAtualizar.Cursor = Cursors.Hand;
            btnAtualizar.Location = new Point(20, 5);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(93, 32);
            btnAtualizar.TabIndex = 5;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // txtBusca
            // 
            txtBusca.BackColor = Color.White;
            txtBusca.BorderStyle = BorderStyle.FixedSingle;
            txtBusca.Controls.Add(textBox1);
            txtBusca.Location = new Point(1112, 2);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(327, 38);
            txtBusca.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(8, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 20);
            textBox1.TabIndex = 3;
            // 
            // brnPesquisa
            // 
            brnPesquisa.BackgroundImage = (Image)resources.GetObject("brnPesquisa.BackgroundImage");
            brnPesquisa.BackgroundImageLayout = ImageLayout.Zoom;
            brnPesquisa.Location = new Point(1439, 0);
            brnPesquisa.Name = "brnPesquisa";
            brnPesquisa.Size = new Size(42, 40);
            brnPesquisa.TabIndex = 3;
            brnPesquisa.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.Location = new Point(245, 5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(92, 32);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnAtualizar);
            panel2.Controls.Add(txtBusca);
            panel2.Controls.Add(brnPesquisa);
            panel2.Controls.Add(btnExcluir);
            panel2.Controls.Add(btnAlterar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(1610, 44);
            panel2.TabIndex = 6;
            // 
            // btnAlterar
            // 
            btnAlterar.Cursor = Cursors.Hand;
            btnAlterar.Location = new Point(132, 5);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(93, 32);
            btnAlterar.TabIndex = 0;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 32);
            label1.TabIndex = 0;
            label1.Text = "Pedidos";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1610, 47);
            panel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvPedidos);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(1610, 756);
            panel3.TabIndex = 7;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { Codigo_pedido, Nome, Telefone, Endereço, Complemento, Descrição, Forma_de_pagamento, Status, Valor_unitario, Total, Data_inclusão, Data_alterasão });
            dgvPedidos.Dock = DockStyle.Fill;
            dgvPedidos.Location = new Point(0, 0);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.Size = new Size(1610, 756);
            dgvPedidos.TabIndex = 8;
            // 
            // Codigo_pedido
            // 
            Codigo_pedido.HeaderText = "Codigo_pedido";
            Codigo_pedido.Name = "Codigo_pedido";
            Codigo_pedido.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Telefone
            // 
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            // 
            // Endereço
            // 
            Endereço.HeaderText = "Endereço";
            Endereço.Name = "Endereço";
            Endereço.ReadOnly = true;
            // 
            // Complemento
            // 
            Complemento.HeaderText = "Complemento";
            Complemento.Name = "Complemento";
            Complemento.ReadOnly = true;
            // 
            // Descrição
            // 
            Descrição.HeaderText = "Descrição";
            Descrição.Name = "Descrição";
            Descrição.ReadOnly = true;
            // 
            // Forma_de_pagamento
            // 
            Forma_de_pagamento.HeaderText = "Forma_de_pagamento";
            Forma_de_pagamento.Name = "Forma_de_pagamento";
            Forma_de_pagamento.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Valor_unitario
            // 
            Valor_unitario.HeaderText = "Valor_unitario";
            Valor_unitario.Name = "Valor_unitario";
            Valor_unitario.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // Data_inclusão
            // 
            Data_inclusão.HeaderText = "Data_inclusão";
            Data_inclusão.Name = "Data_inclusão";
            Data_inclusão.ReadOnly = true;
            // 
            // Data_alterasão
            // 
            Data_alterasão.HeaderText = "Data_alterasão";
            Data_alterasão.Name = "Data_alterasão";
            Data_alterasão.ReadOnly = true;
            // 
            // TodosPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TodosPedidos";
            Size = new Size(1610, 847);
            txtBusca.ResumeLayout(false);
            txtBusca.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAtualizar;
        private Panel txtBusca;
        private TextBox textBox1;
        private Button brnPesquisa;
        private Button btnExcluir;
        private Panel panel2;
        private Button btnAlterar;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private DataGridView dgvPedidos;
        private DataGridViewTextBoxColumn Codigo_pedido;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Endereço;
        private DataGridViewTextBoxColumn Complemento;
        private DataGridViewTextBoxColumn Descrição;
        private DataGridViewTextBoxColumn Forma_de_pagamento;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Valor_unitario;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Data_inclusão;
        private DataGridViewTextBoxColumn Data_alterasão;
    }
}
