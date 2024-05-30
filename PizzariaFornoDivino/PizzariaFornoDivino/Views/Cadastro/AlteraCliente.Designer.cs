namespace PizzariaFornoDivino.Views.Cadastro
{
    partial class AlteraCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlteraCliente));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnAtualizar = new Button();
            panel3 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            btnExcluir = new Button();
            btnAlterar = new Button();
            dgvClientes = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Endereco = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Complemento = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Cep = new DataGridViewTextBoxColumn();
            Data_Inclusão = new DataGridViewTextBoxColumn();
            Data_alterasão = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1488, 47);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnAtualizar);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnExcluir);
            panel2.Controls.Add(btnAlterar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(1488, 44);
            panel2.TabIndex = 3;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(20, 5);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(93, 32);
            btnAtualizar.TabIndex = 5;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(1112, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(327, 38);
            panel3.TabIndex = 4;
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
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(1439, 0);
            button1.Name = "button1";
            button1.Size = new Size(42, 40);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(245, 5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(92, 32);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(132, 5);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(93, 32);
            btnAlterar.TabIndex = 0;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Nome, Endereco, Telefone, Complemento, Email, Cep, Data_Inclusão, Data_alterasão });
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.Location = new Point(0, 91);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.Size = new Size(1488, 777);
            dgvClientes.TabIndex = 4;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Endereco
            // 
            Endereco.HeaderText = "Endereco";
            Endereco.Name = "Endereco";
            Endereco.ReadOnly = true;
            // 
            // Telefone
            // 
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            // 
            // Complemento
            // 
            Complemento.HeaderText = "Complemento";
            Complemento.Name = "Complemento";
            Complemento.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Cep
            // 
            Cep.HeaderText = "Cep";
            Cep.Name = "Cep";
            Cep.ReadOnly = true;
            // 
            // Data_Inclusão
            // 
            Data_Inclusão.HeaderText = "Data_Inclusão";
            Data_Inclusão.Name = "Data_Inclusão";
            Data_Inclusão.ReadOnly = true;
            // 
            // Data_alterasão
            // 
            Data_alterasão.HeaderText = "Data_alterasão";
            Data_alterasão.Name = "Data_alterasão";
            Data_alterasão.ReadOnly = true;
            // 
            // AlteraCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvClientes);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AlteraCliente";
            Size = new Size(1488, 868);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox1;
        private Button button1;
        private Button btnExcluir;
        private Button btnAlterar;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Endereco;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Complemento;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Cep;
        private DataGridViewTextBoxColumn Data_Inclusão;
        private DataGridViewTextBoxColumn Data_alterasão;
        private Button btnAtualizar;
    }
}
