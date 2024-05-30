namespace PizzariaFornoDivino.Views.Pedidos
{
    partial class IncluirPedido
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
            panel1 = new Panel();
            btnFinaliza = new Button();
            Title = new Label();
            panel3 = new Panel();
            label14 = new Label();
            txtTotal = new TextBox();
            label12 = new Label();
            txtNumero = new TextBox();
            cbForma = new ComboBox();
            label11 = new Label();
            panel2 = new Panel();
            btnAdicionar = new Button();
            vlTotal = new Label();
            button3 = new Button();
            cbStatus = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtDescricao = new TextBox();
            txtBairro = new TextBox();
            txtComplemento = new TextBox();
            txtEndereco = new TextBox();
            textBox2 = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            txtCod = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnFinaliza);
            panel1.Controls.Add(Title);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1521, 62);
            panel1.TabIndex = 0;
            // 
            // btnFinaliza
            // 
            btnFinaliza.Cursor = Cursors.Hand;
            btnFinaliza.Location = new Point(1381, 18);
            btnFinaliza.Name = "btnFinaliza";
            btnFinaliza.Size = new Size(128, 37);
            btnFinaliza.TabIndex = 6;
            btnFinaliza.Text = "Finalizar Pedido";
            btnFinaliza.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            Title.ForeColor = SystemColors.Highlight;
            Title.Location = new Point(21, 9);
            Title.Name = "Title";
            Title.Size = new Size(172, 32);
            Title.TabIndex = 0;
            Title.Text = "Incluir Pedidos";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txtTotal);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtNumero);
            panel3.Controls.Add(cbForma);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(cbStatus);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtDescricao);
            panel3.Controls.Add(txtBairro);
            panel3.Controls.Add(txtComplemento);
            panel3.Controls.Add(txtEndereco);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(txtNome);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtCod);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(1521, 787);
            panel3.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(1144, 189);
            label14.Name = "label14";
            label14.Size = new Size(82, 21);
            label14.TabIndex = 28;
            label14.Text = "Valor Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(1148, 213);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(179, 23);
            txtTotal.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(1240, 14);
            label12.Name = "label12";
            label12.Size = new Size(28, 21);
            label12.TabIndex = 26;
            label12.Text = "N°";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(1240, 38);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(96, 23);
            txtNumero.TabIndex = 25;
            // 
            // cbForma
            // 
            cbForma.FormattingEnabled = true;
            cbForma.Items.AddRange(new object[] { "Cartao de Credito", "Cartao de Debito", "Pix", "Dinheiro" });
            cbForma.Location = new Point(1121, 119);
            cbForma.Name = "cbForma";
            cbForma.Size = new Size(246, 23);
            cbForma.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(1121, 91);
            label11.Name = "label11";
            label11.Size = new Size(158, 21);
            label11.TabIndex = 23;
            label11.Text = "Forma de Pagamento";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAdicionar);
            panel2.Controls.Add(vlTotal);
            panel2.Controls.Add(button3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 724);
            panel2.Name = "panel2";
            panel2.Size = new Size(1519, 61);
            panel2.TabIndex = 22;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.Location = new Point(22, 12);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(95, 37);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar Item";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // vlTotal
            // 
            vlTotal.AutoSize = true;
            vlTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vlTotal.Location = new Point(1419, 28);
            vlTotal.Name = "vlTotal";
            vlTotal.Size = new Size(62, 21);
            vlTotal.TabIndex = 4;
            vlTotal.Text = "             ";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(146, 12);
            button3.Name = "button3";
            button3.Size = new Size(95, 37);
            button3.TabIndex = 2;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Em preparasão", "Saio para entrega", "Pedido entregue" });
            cbStatus.Location = new Point(810, 119);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(246, 23);
            cbStatus.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(65, 164);
            label10.Name = "label10";
            label10.Size = new Size(77, 21);
            label10.TabIndex = 19;
            label10.Text = "Descricao";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(810, 91);
            label9.Name = "label9";
            label9.Size = new Size(52, 21);
            label9.TabIndex = 18;
            label9.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(396, 95);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 15;
            label6.Text = "Bairro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(65, 95);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 14;
            label5.Text = "Complemento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(876, 14);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 13;
            label4.Text = "Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(569, 14);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 12;
            label3.Text = "Telefone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(230, 14);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 11;
            label2.Text = "Cliente";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(65, 191);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(1036, 264);
            txtDescricao.TabIndex = 8;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(396, 119);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(362, 23);
            txtBairro.TabIndex = 6;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(65, 119);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(268, 23);
            txtComplemento.TabIndex = 5;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(876, 38);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(350, 23);
            txtEndereco.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(569, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 23);
            textBox2.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(230, 38);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(290, 23);
            txtNome.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 14);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 1;
            label1.Text = "Codigo Pedido";
            // 
            // txtCod
            // 
            txtCod.Location = new Point(65, 38);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(129, 23);
            txtCod.TabIndex = 0;
            txtCod.Enter += IncluirPedido_Load;
            // 
            // IncluirPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "IncluirPedido";
            Size = new Size(1521, 849);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Title;
        private Panel panel3;
        private Label label1;
        private TextBox txtCod;
        private TextBox txtValorUni;
        private TextBox txtDescricao;
        private TextBox txtCep;
        private TextBox txtComplemento;
        private TextBox txtEndereco;
        private TextBox textBox2;
        private TextBox txtNome;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbStatus;
        private ComboBox cbForma;
        private Label label11;
        private Panel panel2;
        private Label label12;
        private TextBox txtNumero;
        private Button button3;
        private Label label6;
        private TextBox txtBairro;
        private Label vlTotal;
        private Button btnFinaliza;
        private Button btnAdicionar;
        private Label label14;
        private TextBox txtTotal;
    }
}
