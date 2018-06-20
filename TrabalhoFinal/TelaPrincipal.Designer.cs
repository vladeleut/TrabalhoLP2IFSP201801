namespace TrabalhoFinal
{
    partial class Inicio
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.tabGeral = new System.Windows.Forms.TabControl();
            this.TabInicio = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAbreCaixa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCaixa = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panDadosDoCaixa = new System.Windows.Forms.Panel();
            this.lblAbertura = new System.Windows.Forms.Label();
            this.lblAbertoEm = new System.Windows.Forms.Label();
            this.btnFechaCaixa = new System.Windows.Forms.Button();
            this.tabTelaPedido = new System.Windows.Forms.TabPage();
            this.panDGPedidos = new System.Windows.Forms.Panel();
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.nroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aberturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.trabalhofinalDataSet2 = new TrabalhoFinal.trabalhofinalDataSet2();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bttNovoPedido = new System.Windows.Forms.Button();
            this.trabalhofinalDataSet = new TrabalhoFinal.trabalhofinalDataSet();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter = new TrabalhoFinal.trabalhofinalDataSetTableAdapters.pedidoTableAdapter();
            this.trabalhofinalDataSet1 = new TrabalhoFinal.trabalhofinalDataSet1();
            this.pedidoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter1 = new TrabalhoFinal.trabalhofinalDataSet1TableAdapters.pedidoTableAdapter();
            this.pedidoTableAdapter2 = new TrabalhoFinal.trabalhofinalDataSet2TableAdapters.pedidoTableAdapter();
            this.btnChamaProduto = new System.Windows.Forms.Button();
            this.tabGeral.SuspendLayout();
            this.TabInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCaixa.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panDadosDoCaixa.SuspendLayout();
            this.tabTelaPedido.SuspendLayout();
            this.panDGPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhofinalDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhofinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhofinalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGeral
            // 
            this.tabGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabGeral.Controls.Add(this.TabInicio);
            this.tabGeral.Controls.Add(this.tabCaixa);
            this.tabGeral.Controls.Add(this.tabTelaPedido);
            this.tabGeral.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGeral.Location = new System.Drawing.Point(12, 12);
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.SelectedIndex = 0;
            this.tabGeral.Size = new System.Drawing.Size(776, 448);
            this.tabGeral.TabIndex = 1;
            // 
            // TabInicio
            // 
            this.TabInicio.BackColor = System.Drawing.Color.White;
            this.TabInicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TabInicio.Controls.Add(this.btnChamaProduto);
            this.TabInicio.Controls.Add(this.pictureBox4);
            this.TabInicio.Controls.Add(this.pictureBox3);
            this.TabInicio.Controls.Add(this.pictureBox1);
            this.TabInicio.Controls.Add(this.btnAbreCaixa);
            this.TabInicio.Controls.Add(this.label1);
            this.TabInicio.Location = new System.Drawing.Point(4, 24);
            this.TabInicio.Name = "TabInicio";
            this.TabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.TabInicio.Size = new System.Drawing.Size(768, 420);
            this.TabInicio.TabIndex = 0;
            this.TabInicio.Text = "Início";
            this.TabInicio.Click += new System.EventHandler(this.TabInicio_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(517, 85);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(187, 97);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-4, 343);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(776, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnAbreCaixa
            // 
            this.btnAbreCaixa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAbreCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAbreCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbreCaixa.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbreCaixa.Location = new System.Drawing.Point(280, 267);
            this.btnAbreCaixa.Name = "btnAbreCaixa";
            this.btnAbreCaixa.Size = new System.Drawing.Size(191, 70);
            this.btnAbreCaixa.TabIndex = 3;
            this.btnAbreCaixa.Text = "Abrir Caixa";
            this.btnAbreCaixa.UseVisualStyleBackColor = false;
            this.btnAbreCaixa.Click += new System.EventHandler(this.btnAbreCaixaClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seja bem vindo! Para iniciar, abra o caixa:";
            // 
            // tabCaixa
            // 
            this.tabCaixa.BackColor = System.Drawing.Color.Transparent;
            this.tabCaixa.Controls.Add(this.panel1);
            this.tabCaixa.Controls.Add(this.panDadosDoCaixa);
            this.tabCaixa.Controls.Add(this.btnFechaCaixa);
            this.tabCaixa.Location = new System.Drawing.Point(4, 24);
            this.tabCaixa.Name = "tabCaixa";
            this.tabCaixa.Padding = new System.Windows.Forms.Padding(3);
            this.tabCaixa.Size = new System.Drawing.Size(768, 420);
            this.tabCaixa.TabIndex = 1;
            this.tabCaixa.Text = "Caixa";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Location = new System.Drawing.Point(0, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 408);
            this.panel1.TabIndex = 10;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(359, 408);
            this.dataGridView3.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Hora";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Valor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Forma de Pagamento";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // panDadosDoCaixa
            // 
            this.panDadosDoCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panDadosDoCaixa.Controls.Add(this.lblAbertura);
            this.panDadosDoCaixa.Controls.Add(this.lblAbertoEm);
            this.panDadosDoCaixa.Location = new System.Drawing.Point(375, 320);
            this.panDadosDoCaixa.Name = "panDadosDoCaixa";
            this.panDadosDoCaixa.Size = new System.Drawing.Size(237, 100);
            this.panDadosDoCaixa.TabIndex = 9;
            // 
            // lblAbertura
            // 
            this.lblAbertura.AutoSize = true;
            this.lblAbertura.Location = new System.Drawing.Point(58, 43);
            this.lblAbertura.Name = "lblAbertura";
            this.lblAbertura.Size = new System.Drawing.Size(106, 15);
            this.lblAbertura.TabIndex = 9;
            this.lblAbertura.Text = "Caixa Fechado";
            // 
            // lblAbertoEm
            // 
            this.lblAbertoEm.AutoSize = true;
            this.lblAbertoEm.Location = new System.Drawing.Point(80, 14);
            this.lblAbertoEm.Name = "lblAbertoEm";
            this.lblAbertoEm.Size = new System.Drawing.Size(84, 15);
            this.lblAbertoEm.TabIndex = 8;
            this.lblAbertoEm.Text = "Aberto em:";
            // 
            // btnFechaCaixa
            // 
            this.btnFechaCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechaCaixa.BackColor = System.Drawing.Color.Red;
            this.btnFechaCaixa.Location = new System.Drawing.Point(630, 354);
            this.btnFechaCaixa.Name = "btnFechaCaixa";
            this.btnFechaCaixa.Size = new System.Drawing.Size(116, 33);
            this.btnFechaCaixa.TabIndex = 4;
            this.btnFechaCaixa.Text = "Fechar Caixa";
            this.btnFechaCaixa.UseVisualStyleBackColor = false;
            this.btnFechaCaixa.Click += new System.EventHandler(this.btnFechaCaixa_Click);
            // 
            // tabTelaPedido
            // 
            this.tabTelaPedido.Controls.Add(this.panDGPedidos);
            this.tabTelaPedido.Controls.Add(this.pictureBox5);
            this.tabTelaPedido.Controls.Add(this.pictureBox2);
            this.tabTelaPedido.Controls.Add(this.bttNovoPedido);
            this.tabTelaPedido.Location = new System.Drawing.Point(4, 24);
            this.tabTelaPedido.Name = "tabTelaPedido";
            this.tabTelaPedido.Padding = new System.Windows.Forms.Padding(3);
            this.tabTelaPedido.Size = new System.Drawing.Size(768, 420);
            this.tabTelaPedido.TabIndex = 2;
            this.tabTelaPedido.Text = "Pedidos";
            this.tabTelaPedido.UseVisualStyleBackColor = true;
            // 
            // panDGPedidos
            // 
            this.panDGPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panDGPedidos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panDGPedidos.Controls.Add(this.dgPedidos);
            this.panDGPedidos.Location = new System.Drawing.Point(4, 200);
            this.panDGPedidos.Name = "panDGPedidos";
            this.panDGPedidos.Size = new System.Drawing.Size(764, 220);
            this.panDGPedidos.TabIndex = 11;
            // 
            // dgPedidos
            // 
            this.dgPedidos.AutoGenerateColumns = false;
            this.dgPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroDataGridViewTextBoxColumn,
            this.aberturaDataGridViewTextBoxColumn,
            this.fechamentoDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn});
            this.dgPedidos.DataSource = this.pedidoBindingSource2;
            this.dgPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPedidos.Location = new System.Drawing.Point(0, 0);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.ReadOnly = true;
            this.dgPedidos.Size = new System.Drawing.Size(764, 220);
            this.dgPedidos.TabIndex = 0;
            // 
            // nroDataGridViewTextBoxColumn
            // 
            this.nroDataGridViewTextBoxColumn.DataPropertyName = "nro";
            this.nroDataGridViewTextBoxColumn.HeaderText = "nro";
            this.nroDataGridViewTextBoxColumn.Name = "nroDataGridViewTextBoxColumn";
            this.nroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aberturaDataGridViewTextBoxColumn
            // 
            this.aberturaDataGridViewTextBoxColumn.DataPropertyName = "abertura";
            this.aberturaDataGridViewTextBoxColumn.HeaderText = "abertura";
            this.aberturaDataGridViewTextBoxColumn.Name = "aberturaDataGridViewTextBoxColumn";
            this.aberturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechamentoDataGridViewTextBoxColumn
            // 
            this.fechamentoDataGridViewTextBoxColumn.DataPropertyName = "fechamento";
            this.fechamentoDataGridViewTextBoxColumn.HeaderText = "fechamento";
            this.fechamentoDataGridViewTextBoxColumn.Name = "fechamentoDataGridViewTextBoxColumn";
            this.fechamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pedidoBindingSource2
            // 
            this.pedidoBindingSource2.DataMember = "pedido";
            this.pedidoBindingSource2.DataSource = this.trabalhofinalDataSet2;
            // 
            // trabalhofinalDataSet2
            // 
            this.trabalhofinalDataSet2.DataSetName = "trabalhofinalDataSet2";
            this.trabalhofinalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 125);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(768, 71);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(549, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // bttNovoPedido
            // 
            this.bttNovoPedido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bttNovoPedido.BackColor = System.Drawing.Color.LawnGreen;
            this.bttNovoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttNovoPedido.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNovoPedido.Location = new System.Drawing.Point(61, 28);
            this.bttNovoPedido.Name = "bttNovoPedido";
            this.bttNovoPedido.Size = new System.Drawing.Size(195, 76);
            this.bttNovoPedido.TabIndex = 6;
            this.bttNovoPedido.Text = "Novo Pedido";
            this.bttNovoPedido.UseVisualStyleBackColor = false;
            this.bttNovoPedido.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // trabalhofinalDataSet
            // 
            this.trabalhofinalDataSet.DataSetName = "trabalhofinalDataSet";
            this.trabalhofinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "pedido";
            this.pedidoBindingSource.DataSource = this.trabalhofinalDataSet;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // trabalhofinalDataSet1
            // 
            this.trabalhofinalDataSet1.DataSetName = "trabalhofinalDataSet1";
            this.trabalhofinalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoBindingSource1
            // 
            this.pedidoBindingSource1.DataMember = "pedido";
            this.pedidoBindingSource1.DataSource = this.trabalhofinalDataSet1;
            // 
            // pedidoTableAdapter1
            // 
            this.pedidoTableAdapter1.ClearBeforeFill = true;
            // 
            // pedidoTableAdapter2
            // 
            this.pedidoTableAdapter2.ClearBeforeFill = true;
            // 
            // btnChamaProduto
            // 
            this.btnChamaProduto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnChamaProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnChamaProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChamaProduto.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamaProduto.Location = new System.Drawing.Point(567, 267);
            this.btnChamaProduto.Name = "btnChamaProduto";
            this.btnChamaProduto.Size = new System.Drawing.Size(191, 70);
            this.btnChamaProduto.TabIndex = 10;
            this.btnChamaProduto.Text = "Produtos";
            this.btnChamaProduto.UseVisualStyleBackColor = false;
            this.btnChamaProduto.Click += new System.EventHandler(this.btnChamaProduto_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.tabGeral);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.tabGeral.ResumeLayout(false);
            this.TabInicio.ResumeLayout(false);
            this.TabInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCaixa.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panDadosDoCaixa.ResumeLayout(false);
            this.panDadosDoCaixa.PerformLayout();
            this.tabTelaPedido.ResumeLayout(false);
            this.panDGPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhofinalDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhofinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhofinalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGeral;
        private System.Windows.Forms.TabPage TabInicio;
        private System.Windows.Forms.Button btnAbreCaixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCaixa;
        private System.Windows.Forms.TabPage tabTelaPedido;
        private System.Windows.Forms.Button btnFechaCaixa;
        private System.Windows.Forms.Button bttNovoPedido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panDadosDoCaixa;
        private System.Windows.Forms.Label lblAbertura;
        private System.Windows.Forms.Label lblAbertoEm;
        private System.Windows.Forms.Panel panDGPedidos;
        private trabalhofinalDataSet trabalhofinalDataSet;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private trabalhofinalDataSetTableAdapters.pedidoTableAdapter pedidoTableAdapter;
        private System.Windows.Forms.DataGridView dgPedidos;
        private trabalhofinalDataSet1 trabalhofinalDataSet1;
        private System.Windows.Forms.BindingSource pedidoBindingSource1;
        private trabalhofinalDataSet1TableAdapters.pedidoTableAdapter pedidoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aberturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private trabalhofinalDataSet2 trabalhofinalDataSet2;
        private System.Windows.Forms.BindingSource pedidoBindingSource2;
        private trabalhofinalDataSet2TableAdapters.pedidoTableAdapter pedidoTableAdapter2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChamaProduto;
    }
}

