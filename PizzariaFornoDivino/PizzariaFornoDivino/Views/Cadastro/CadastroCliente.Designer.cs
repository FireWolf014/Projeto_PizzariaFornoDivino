namespace PizzariaFornoDivino.Views
{
    partial class CadastroCliente
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
            lblCadastro = new Label();
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            txtBairro = new TextBox();
            txtNumero = new TextBox();
            txtEmail = new TextBox();
            txtCep = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTelefone = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            btnCancel = new Button();
            btnSalvar = new Button();
            txtComplemento = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblCadastro);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1354, 38);
            panel1.TabIndex = 0;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCadastro.ForeColor = SystemColors.Highlight;
            lblCadastro.Location = new Point(0, 0);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(184, 25);
            lblCadastro.TabIndex = 0;
            lblCadastro.Text = "Cadastro de clientes";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(73, 164);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(368, 23);
            txtNome.TabIndex = 1;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(504, 164);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(360, 23);
            txtEndereco.TabIndex = 2;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(1095, 164);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(214, 23);
            txtBairro.TabIndex = 3;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(913, 164);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(93, 23);
            txtNumero.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(776, 346);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(420, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(285, 346);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(215, 23);
            txtCep.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 140);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(504, 140);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 8;
            label2.Text = "Endereço";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(535, 346);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(199, 23);
            txtTelefone.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(913, 140);
            label3.Name = "label3";
            label3.Size = new Size(28, 21);
            label3.TabIndex = 10;
            label3.Text = "N°";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1095, 140);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 11;
            label4.Text = "Bairro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(285, 322);
            label5.Name = "label5";
            label5.Size = new Size(37, 21);
            label5.TabIndex = 12;
            label5.Text = "Cep";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(535, 322);
            label6.Name = "label6";
            label6.Size = new Size(67, 21);
            label6.TabIndex = 13;
            label6.Text = "Telefone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(776, 322);
            label7.Name = "label7";
            label7.Size = new Size(48, 21);
            label7.TabIndex = 14;
            label7.Text = "Email";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSalvar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 612);
            panel2.Name = "panel2";
            panel2.Size = new Size(1354, 77);
            panel2.TabIndex = 15;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.HighlightText;
            btnCancel.Location = new Point(268, 21);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Gold;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.HighlightText;
            btnSalvar.Location = new Point(72, 21);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(141, 40);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(73, 346);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(176, 23);
            txtComplemento.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(73, 322);
            label8.Name = "label8";
            label8.Size = new Size(109, 21);
            label8.TabIndex = 17;
            label8.Text = "Complemento";
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(label8);
            Controls.Add(txtComplemento);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTelefone);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCep);
            Controls.Add(txtEmail);
            Controls.Add(txtNumero);
            Controls.Add(txtBairro);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Controls.Add(panel1);
            Name = "CadastroCliente";
            Size = new Size(1354, 689);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblCadastro;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtBairro;
        private TextBox txtNumero;
        private TextBox txtEmail;
        private TextBox txtCep;
        private Label label1;
        private Label label2;
        private TextBox txtTelefone;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel2;
        private Button btnCancel;
        private Button btnSalvar;
        private TextBox txtComplemento;
        private Label label8;
    }
}
