namespace TrabalhoFinal
{
    partial class TelaPedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.cbTaxaDeEntrega = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPeditoTelCliente = new System.Windows.Forms.ComboBox();
            this.mtxtDDD = new System.Windows.Forms.MaskedTextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnFinalizaPedido = new System.Windows.Forms.Button();
            this.btnPedidoAdicionaPizza = new System.Windows.Forms.Button();
            this.btnPedidoAdicionaLanche = new System.Windows.Forms.Button();
            this.btnPedidoAdicionaBebida = new System.Windows.Forms.Button();
            this.btnPedidoAdicionaOutros = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgPedido = new System.Windows.Forms.DataGridView();
            this.dgPedidoCoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPedidoColPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPedidoColQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPedidoColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDescValorTotalPedido = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancelaTelaPedido = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtValeRefeicao = new System.Windows.Forms.TextBox();
            this.txtCartaoDebito = new System.Windows.Forms.TextBox();
            this.txtCartaoCredito = new System.Windows.Forms.TextBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedido)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Complemento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Referência";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Observação";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblBairro);
            this.panel1.Controls.Add(this.cbTaxaDeEntrega);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbPeditoTelCliente);
            this.panel1.Controls.Add(this.mtxtDDD);
            this.panel1.Controls.Add(this.txtObservacao);
            this.panel1.Controls.Add(this.txtReferencia);
            this.panel1.Controls.Add(this.txtComplemento);
            this.panel1.Controls.Add(this.txtLogradouro);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(596, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 227);
            this.panel1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 19;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(67, 112);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(49, 15);
            this.lblBairro.TabIndex = 20;
            this.lblBairro.Text = "Bairro";
            // 
            // cbTaxaDeEntrega
            // 
            this.cbTaxaDeEntrega.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTaxaDeEntrega.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTaxaDeEntrega.FormattingEnabled = true;
            this.cbTaxaDeEntrega.Location = new System.Drawing.Point(122, 193);
            this.cbTaxaDeEntrega.Name = "cbTaxaDeEntrega";
            this.cbTaxaDeEntrega.Size = new System.Drawing.Size(145, 21);
            this.cbTaxaDeEntrega.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Taxa de Entrega";
            // 
            // cbPeditoTelCliente
            // 
            this.cbPeditoTelCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPeditoTelCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPeditoTelCliente.FormattingEnabled = true;
            this.cbPeditoTelCliente.Location = new System.Drawing.Point(153, 6);
            this.cbPeditoTelCliente.Name = "cbPeditoTelCliente";
            this.cbPeditoTelCliente.Size = new System.Drawing.Size(114, 21);
            this.cbPeditoTelCliente.TabIndex = 1;
            this.cbPeditoTelCliente.TextChanged += new System.EventHandler(this.cbPeditoTelCliente_TextChanged);
            this.cbPeditoTelCliente.Leave += new System.EventHandler(this.cbPeditoTelCliente_Leave);
            // 
            // mtxtDDD
            // 
            this.mtxtDDD.Location = new System.Drawing.Point(122, 7);
            this.mtxtDDD.Mask = "(00)";
            this.mtxtDDD.Name = "mtxtDDD";
            this.mtxtDDD.Size = new System.Drawing.Size(25, 20);
            this.mtxtDDD.TabIndex = 16;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(122, 167);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(145, 20);
            this.txtObservacao.TabIndex = 6;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(122, 138);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(145, 20);
            this.txtReferencia.TabIndex = 5;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(122, 85);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(145, 20);
            this.txtComplemento.TabIndex = 4;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(122, 59);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(145, 20);
            this.txtLogradouro.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(122, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(145, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btnFinalizaPedido
            // 
            this.btnFinalizaPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFinalizaPedido.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizaPedido.Location = new System.Drawing.Point(52, 309);
            this.btnFinalizaPedido.Name = "btnFinalizaPedido";
            this.btnFinalizaPedido.Size = new System.Drawing.Size(218, 74);
            this.btnFinalizaPedido.TabIndex = 11;
            this.btnFinalizaPedido.Text = "Finalizar Pedido";
            this.btnFinalizaPedido.UseVisualStyleBackColor = false;
            this.btnFinalizaPedido.Click += new System.EventHandler(this.btnFinalizaPedido_Click);
            // 
            // btnPedidoAdicionaPizza
            // 
            this.btnPedidoAdicionaPizza.BackColor = System.Drawing.Color.Silver;
            this.btnPedidoAdicionaPizza.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoAdicionaPizza.Location = new System.Drawing.Point(352, 37);
            this.btnPedidoAdicionaPizza.Name = "btnPedidoAdicionaPizza";
            this.btnPedidoAdicionaPizza.Size = new System.Drawing.Size(218, 74);
            this.btnPedidoAdicionaPizza.TabIndex = 7;
            this.btnPedidoAdicionaPizza.Text = "Adicionar Pizza";
            this.btnPedidoAdicionaPizza.UseVisualStyleBackColor = false;
            this.btnPedidoAdicionaPizza.Click += new System.EventHandler(this.btnPedidoAdicionaPizza_Click);
            // 
            // btnPedidoAdicionaLanche
            // 
            this.btnPedidoAdicionaLanche.BackColor = System.Drawing.Color.Silver;
            this.btnPedidoAdicionaLanche.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoAdicionaLanche.Location = new System.Drawing.Point(352, 117);
            this.btnPedidoAdicionaLanche.Name = "btnPedidoAdicionaLanche";
            this.btnPedidoAdicionaLanche.Size = new System.Drawing.Size(218, 75);
            this.btnPedidoAdicionaLanche.TabIndex = 8;
            this.btnPedidoAdicionaLanche.Text = "Adicionar Lanche";
            this.btnPedidoAdicionaLanche.UseVisualStyleBackColor = false;
            this.btnPedidoAdicionaLanche.Click += new System.EventHandler(this.bttAdcLanche_Click);
            // 
            // btnPedidoAdicionaBebida
            // 
            this.btnPedidoAdicionaBebida.BackColor = System.Drawing.Color.Silver;
            this.btnPedidoAdicionaBebida.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoAdicionaBebida.Location = new System.Drawing.Point(352, 198);
            this.btnPedidoAdicionaBebida.Name = "btnPedidoAdicionaBebida";
            this.btnPedidoAdicionaBebida.Size = new System.Drawing.Size(218, 72);
            this.btnPedidoAdicionaBebida.TabIndex = 9;
            this.btnPedidoAdicionaBebida.Text = "Adicionar Bebida";
            this.btnPedidoAdicionaBebida.UseVisualStyleBackColor = false;
            this.btnPedidoAdicionaBebida.Click += new System.EventHandler(this.bttAdcBebida_Click);
            // 
            // btnPedidoAdicionaOutros
            // 
            this.btnPedidoAdicionaOutros.BackColor = System.Drawing.Color.Silver;
            this.btnPedidoAdicionaOutros.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoAdicionaOutros.Location = new System.Drawing.Point(352, 276);
            this.btnPedidoAdicionaOutros.Name = "btnPedidoAdicionaOutros";
            this.btnPedidoAdicionaOutros.Size = new System.Drawing.Size(218, 73);
            this.btnPedidoAdicionaOutros.TabIndex = 10;
            this.btnPedidoAdicionaOutros.Text = "Adicionar Outros";
            this.btnPedidoAdicionaOutros.UseVisualStyleBackColor = false;
            this.btnPedidoAdicionaOutros.Click += new System.EventHandler(this.bttAdcOutro_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.dgPedido);
            this.panel2.Location = new System.Drawing.Point(12, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 254);
            this.panel2.TabIndex = 25;
            // 
            // dgPedido
            // 
            this.dgPedido.AllowUserToAddRows = false;
            this.dgPedido.AllowUserToDeleteRows = false;
            this.dgPedido.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgPedidoCoItem,
            this.dgPedidoColPreco,
            this.dgPedidoColQtde,
            this.dgPedidoColCodigo});
            this.dgPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPedido.Location = new System.Drawing.Point(0, 0);
            this.dgPedido.Name = "dgPedido";
            this.dgPedido.ReadOnly = true;
            this.dgPedido.Size = new System.Drawing.Size(300, 254);
            this.dgPedido.TabIndex = 0;
            this.dgPedido.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPedido_CellContentDoubleClick);
            // 
            // dgPedidoCoItem
            // 
            this.dgPedidoCoItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgPedidoCoItem.HeaderText = "Item";
            this.dgPedidoCoItem.Name = "dgPedidoCoItem";
            this.dgPedidoCoItem.ReadOnly = true;
            // 
            // dgPedidoColPreco
            // 
            this.dgPedidoColPreco.HeaderText = "Preço";
            this.dgPedidoColPreco.Name = "dgPedidoColPreco";
            this.dgPedidoColPreco.ReadOnly = true;
            this.dgPedidoColPreco.Width = 60;
            // 
            // dgPedidoColQtde
            // 
            this.dgPedidoColQtde.HeaderText = "Quantidade";
            this.dgPedidoColQtde.Name = "dgPedidoColQtde";
            this.dgPedidoColQtde.ReadOnly = true;
            this.dgPedidoColQtde.Width = 65;
            // 
            // dgPedidoColCodigo
            // 
            this.dgPedidoColCodigo.HeaderText = "Código";
            this.dgPedidoColCodigo.Name = "dgPedidoColCodigo";
            this.dgPedidoColCodigo.ReadOnly = true;
            this.dgPedidoColCodigo.Visible = false;
            // 
            // lblDescValorTotalPedido
            // 
            this.lblDescValorTotalPedido.AutoSize = true;
            this.lblDescValorTotalPedido.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescValorTotalPedido.Location = new System.Drawing.Point(396, 364);
            this.lblDescValorTotalPedido.Name = "lblDescValorTotalPedido";
            this.lblDescValorTotalPedido.Size = new System.Drawing.Size(127, 22);
            this.lblDescValorTotalPedido.TabIndex = 2;
            this.lblDescValorTotalPedido.Text = "Valor Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(417, 398);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(82, 22);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "R$0,00";
            // 
            // btnCancelaTelaPedido
            // 
            this.btnCancelaTelaPedido.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelaTelaPedido.Location = new System.Drawing.Point(108, 398);
            this.btnCancelaTelaPedido.Name = "btnCancelaTelaPedido";
            this.btnCancelaTelaPedido.Size = new System.Drawing.Size(87, 29);
            this.btnCancelaTelaPedido.TabIndex = 10;
            this.btnCancelaTelaPedido.TabStop = false;
            this.btnCancelaTelaPedido.Text = "Cancelar";
            this.btnCancelaTelaPedido.UseVisualStyleBackColor = true;
            this.btnCancelaTelaPedido.Click += new System.EventHandler(this.btnCancelaTelaPedido_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCliente.Location = new System.Drawing.Point(685, 260);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(126, 38);
            this.btnNovoCliente.TabIndex = 26;
            this.btnNovoCliente.TabStop = false;
            this.btnNovoCliente.Text = "Cadastrar Novo Cliente";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Lucida Fax", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão de Crédito",
            "Cartão de Débito",
            "Vale Refeição"});
            this.checkedListBox1.Location = new System.Drawing.Point(20, 9);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(192, 92);
            this.checkedListBox1.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtValeRefeicao);
            this.panel3.Controls.Add(this.txtCartaoDebito);
            this.panel3.Controls.Add(this.txtCartaoCredito);
            this.panel3.Controls.Add(this.txtDinheiro);
            this.panel3.Controls.Add(this.checkedListBox1);
            this.panel3.Location = new System.Drawing.Point(576, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 111);
            this.panel3.TabIndex = 28;
            // 
            // txtValeRefeicao
            // 
            this.txtValeRefeicao.Location = new System.Drawing.Point(218, 81);
            this.txtValeRefeicao.Name = "txtValeRefeicao";
            this.txtValeRefeicao.Size = new System.Drawing.Size(62, 20);
            this.txtValeRefeicao.TabIndex = 31;
            // 
            // txtCartaoDebito
            // 
            this.txtCartaoDebito.Location = new System.Drawing.Point(218, 57);
            this.txtCartaoDebito.Name = "txtCartaoDebito";
            this.txtCartaoDebito.Size = new System.Drawing.Size(62, 20);
            this.txtCartaoDebito.TabIndex = 30;
            // 
            // txtCartaoCredito
            // 
            this.txtCartaoCredito.Location = new System.Drawing.Point(218, 33);
            this.txtCartaoCredito.Name = "txtCartaoCredito";
            this.txtCartaoCredito.Size = new System.Drawing.Size(62, 20);
            this.txtCartaoCredito.TabIndex = 29;
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Location = new System.Drawing.Point(218, 9);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(62, 20);
            this.txtDinheiro.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(623, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Opções de Pagamento";
            // 
            // TelaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 443);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDescValorTotalPedido);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.btnCancelaTelaPedido);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPedidoAdicionaOutros);
            this.Controls.Add(this.btnPedidoAdicionaBebida);
            this.Controls.Add(this.btnPedidoAdicionaLanche);
            this.Controls.Add(this.btnPedidoAdicionaPizza);
            this.Controls.Add(this.btnFinalizaPedido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "TelaPedido";
            this.Text = "TelaPedido";
            this.Load += new System.EventHandler(this.TelaPedido_Load);
            this.MouseEnter += new System.EventHandler(this.TelaPedido_MouseEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedido)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnFinalizaPedido;
        private System.Windows.Forms.Button btnPedidoAdicionaPizza;
        private System.Windows.Forms.Button btnPedidoAdicionaLanche;
        private System.Windows.Forms.Button btnPedidoAdicionaBebida;
        private System.Windows.Forms.Button btnPedidoAdicionaOutros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgPedido;
        private System.Windows.Forms.Button btnCancelaTelaPedido;
        private System.Windows.Forms.MaskedTextBox mtxtDDD;
        private System.Windows.Forms.ComboBox cbPeditoTelCliente;
        private System.Windows.Forms.ComboBox cbTaxaDeEntrega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblDescValorTotalPedido;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtValeRefeicao;
        private System.Windows.Forms.TextBox txtCartaoDebito;
        private System.Windows.Forms.TextBox txtCartaoCredito;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPedidoCoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPedidoColPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPedidoColQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPedidoColCodigo;
    }
}