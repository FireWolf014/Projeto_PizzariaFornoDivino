namespace PizzariaFornoDivino.Views
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            panel10 = new Panel();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            PnPedidos = new Panel();
            btnTdPedidos = new Button();
            btnIncluir = new Button();
            btnPedidos = new Button();
            panel9 = new Panel();
            PnCadastro = new Panel();
            btnAlterarCliente = new Button();
            btnClientes = new Button();
            btnCadastro = new Button();
            panel7 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel6 = new Panel();
            label4 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            lblEntrega = new Label();
            panel4 = new Panel();
            label1 = new Label();
            lblPreparo = new Label();
            panelControler = new Panel();
            panel1.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PnPedidos.SuspendLayout();
            PnCadastro.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(237, 252, 25);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(PnPedidos);
            panel1.Controls.Add(btnPedidos);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(PnCadastro);
            panel1.Controls.Add(btnCadastro);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 814);
            panel1.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Controls.Add(label6);
            panel10.Controls.Add(linkLabel1);
            panel10.Controls.Add(pictureBox2);
            panel10.Controls.Add(label5);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 751);
            panel10.Name = "panel10";
            panel10.Size = new Size(251, 63);
            panel10.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(79, 34);
            label6.Name = "label6";
            label6.Size = new Size(45, 17);
            label6.TabIndex = 0;
            label6.Text = "Admin";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(208, 6);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(37, 21);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sair";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(5, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(71, 6);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 0;
            label5.Text = "Usuario";
            // 
            // PnPedidos
            // 
            PnPedidos.Controls.Add(btnTdPedidos);
            PnPedidos.Controls.Add(btnIncluir);
            PnPedidos.Dock = DockStyle.Top;
            PnPedidos.Location = new Point(0, 453);
            PnPedidos.Name = "PnPedidos";
            PnPedidos.Size = new Size(251, 121);
            PnPedidos.TabIndex = 14;
            // 
            // btnTdPedidos
            // 
            btnTdPedidos.Cursor = Cursors.Hand;
            btnTdPedidos.Dock = DockStyle.Top;
            btnTdPedidos.FlatAppearance.BorderSize = 0;
            btnTdPedidos.Location = new Point(0, 40);
            btnTdPedidos.Name = "btnTdPedidos";
            btnTdPedidos.Size = new Size(251, 40);
            btnTdPedidos.TabIndex = 5;
            btnTdPedidos.Text = "Todos pedidos";
            btnTdPedidos.UseVisualStyleBackColor = true;
            btnTdPedidos.Click += btnTdPedidos_Click;
            // 
            // btnIncluir
            // 
            btnIncluir.Cursor = Cursors.Hand;
            btnIncluir.Dock = DockStyle.Top;
            btnIncluir.FlatAppearance.BorderSize = 0;
            btnIncluir.Location = new Point(0, 0);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(251, 40);
            btnIncluir.TabIndex = 3;
            btnIncluir.Text = "Incluir pedidos";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Cursor = Cursors.Hand;
            btnPedidos.Dock = DockStyle.Top;
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.Location = new Point(0, 413);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(251, 40);
            btnPedidos.TabIndex = 13;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 405);
            panel9.Name = "panel9";
            panel9.Size = new Size(251, 8);
            panel9.TabIndex = 11;
            // 
            // PnCadastro
            // 
            PnCadastro.Controls.Add(btnAlterarCliente);
            PnCadastro.Controls.Add(btnClientes);
            PnCadastro.Dock = DockStyle.Top;
            PnCadastro.Location = new Point(0, 295);
            PnCadastro.Name = "PnCadastro";
            PnCadastro.Size = new Size(251, 110);
            PnCadastro.TabIndex = 12;
            // 
            // btnAlterarCliente
            // 
            btnAlterarCliente.Cursor = Cursors.Hand;
            btnAlterarCliente.Dock = DockStyle.Top;
            btnAlterarCliente.FlatAppearance.BorderSize = 0;
            btnAlterarCliente.Location = new Point(0, 40);
            btnAlterarCliente.Name = "btnAlterarCliente";
            btnAlterarCliente.Size = new Size(251, 40);
            btnAlterarCliente.TabIndex = 8;
            btnAlterarCliente.Text = "Alterar Cliente";
            btnAlterarCliente.UseVisualStyleBackColor = true;
            btnAlterarCliente.Click += btnAlterarCliente_Click;
            // 
            // btnClientes
            // 
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.Location = new Point(0, 0);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(251, 40);
            btnClientes.TabIndex = 6;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnCadastro
            // 
            btnCadastro.Cursor = Cursors.Hand;
            btnCadastro.Dock = DockStyle.Top;
            btnCadastro.FlatAppearance.BorderSize = 0;
            btnCadastro.Location = new Point(0, 255);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(251, 40);
            btnCadastro.TabIndex = 10;
            btnCadastro.Text = "Cadastro";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 236);
            panel7.Name = "panel7";
            panel7.Size = new Size(251, 19);
            panel7.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 236);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(237, 252, 25);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(251, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1561, 114);
            panel3.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(1136, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(185, 88);
            panel6.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(68, 47);
            label4.Name = "label4";
            label4.Size = new Size(33, 40);
            label4.TabIndex = 2;
            label4.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(18, 5);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 1;
            label2.Text = "Pedido Entregue";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(lblEntrega);
            panel5.Location = new Point(721, 13);
            panel5.Name = "panel5";
            panel5.Size = new Size(185, 88);
            panel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 47);
            label3.Name = "label3";
            label3.Size = new Size(33, 40);
            label3.TabIndex = 2;
            label3.Text = "0";
            // 
            // lblEntrega
            // 
            lblEntrega.AutoSize = true;
            lblEntrega.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntrega.ForeColor = Color.Orange;
            lblEntrega.Location = new Point(12, 4);
            lblEntrega.Name = "lblEntrega";
            lblEntrega.Size = new Size(162, 25);
            lblEntrega.TabIndex = 1;
            lblEntrega.Text = "Pedido Acaminho";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(lblPreparo);
            panel4.Location = new Point(209, 13);
            panel4.Name = "panel4";
            panel4.Size = new Size(185, 88);
            panel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 46);
            label1.Name = "label1";
            label1.Size = new Size(45, 40);
            label1.TabIndex = 1;
            label1.Text = "01";
            // 
            // lblPreparo
            // 
            lblPreparo.AutoSize = true;
            lblPreparo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreparo.ForeColor = Color.DarkGreen;
            lblPreparo.Location = new Point(2, 4);
            lblPreparo.Name = "lblPreparo";
            lblPreparo.Size = new Size(174, 25);
            lblPreparo.TabIndex = 0;
            lblPreparo.Text = "Pedido em preparo";
            // 
            // panelControler
            // 
            panelControler.BackColor = SystemColors.ControlLightLight;
            panelControler.Dock = DockStyle.Fill;
            panelControler.Location = new Point(251, 114);
            panelControler.Name = "panelControler";
            panelControler.Size = new Size(1561, 700);
            panelControler.TabIndex = 2;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1812, 814);
            Controls.Add(panelControler);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PnPedidos.ResumeLayout(false);
            PnCadastro.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Label lblPreparo;
        private Label label2;
        private Label lblEntrega;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel PnPedidos;
        private Button btnTdPedidos;
        private Button btnIncluir;
        private Button btnPedidos;
        private Panel panel9;
        private Panel PnCadastro;
        private Button btnAlterarCliente;
        private Button btnClientes;
        private Button btnCadastro;
        private Panel panel7;
        private Panel panelControler;
        private Panel panel10;
        private Label label6;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
        private Label label5;
    }
}