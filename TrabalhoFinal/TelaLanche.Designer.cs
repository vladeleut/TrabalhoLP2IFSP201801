namespace TrabalhoFinal
{
    partial class TelaLanche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLanche));
            this.btnAddPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgPedidoTempLanche = new System.Windows.Forms.DataGridView();
            this.dgAdicionaisLanche = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelaPedido = new System.Windows.Forms.Button();
            this.dgListaLanche = new System.Windows.Forms.DataGridView();
            this.dgListaPizzaColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgListaPizzaColPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgListaPizzaColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAvisoLanche = new System.Windows.Forms.Label();
            this.dgPedidoTempLancheCoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPedidoTempLancheColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPedidoTempLancheCoICódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTelaValor = new System.Windows.Forms.Label();
            this.lblValorLanche = new System.Windows.Forms.Label();
            this.dgAdicionaisLancheColAdc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAdicionaisLancheColPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAdicionaisLancheColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidoTempLanche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdicionaisLanche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaLanche)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPedido
            // 
            this.btnAddPedido.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAddPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPedido.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPedido.Location = new System.Drawing.Point(630, 308);
            this.btnAddPedido.Name = "btnAddPedido";
            this.btnAddPedido.Size = new System.Drawing.Size(157, 68);
            this.btnAddPedido.TabIndex = 6;
            this.btnAddPedido.Text = "Adicionar ao Pedido";
            this.btnAddPedido.UseVisualStyleBackColor = false;
            this.btnAddPedido.Click += new System.EventHandler(this.btnAddPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lanches:";
            // 
            // dgPedidoTempLanche
            // 
            this.dgPedidoTempLanche.AllowUserToAddRows = false;
            this.dgPedidoTempLanche.AllowUserToDeleteRows = false;
            this.dgPedidoTempLanche.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPedidoTempLanche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidoTempLanche.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgPedidoTempLancheCoItem,
            this.dgPedidoTempLancheColTipo,
            this.dgPedidoTempLancheCoICódigo});
            this.dgPedidoTempLanche.Location = new System.Drawing.Point(367, 47);
            this.dgPedidoTempLanche.Name = "dgPedidoTempLanche";
            this.dgPedidoTempLanche.ReadOnly = true;
            this.dgPedidoTempLanche.Size = new System.Drawing.Size(412, 143);
            this.dgPedidoTempLanche.TabIndex = 10;
            // 
            // dgAdicionaisLanche
            // 
            this.dgAdicionaisLanche.AllowUserToAddRows = false;
            this.dgAdicionaisLanche.AllowUserToDeleteRows = false;
            this.dgAdicionaisLanche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAdicionaisLanche.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgAdicionaisLancheColAdc,
            this.dgAdicionaisLancheColPreco,
            this.dgAdicionaisLancheColCodigo});
            this.dgAdicionaisLanche.Location = new System.Drawing.Point(367, 254);
            this.dgAdicionaisLanche.Name = "dgAdicionaisLanche";
            this.dgAdicionaisLanche.ReadOnly = true;
            this.dgAdicionaisLanche.Size = new System.Drawing.Size(240, 183);
            this.dgAdicionaisLanche.TabIndex = 11;
            this.dgAdicionaisLanche.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgAdicionaisLanche_CellMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pedido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Adicionais:";
            // 
            // btnCancelaPedido
            // 
            this.btnCancelaPedido.Location = new System.Drawing.Point(662, 382);
            this.btnCancelaPedido.Name = "btnCancelaPedido";
            this.btnCancelaPedido.Size = new System.Drawing.Size(96, 33);
            this.btnCancelaPedido.TabIndex = 14;
            this.btnCancelaPedido.Text = "Cancelar Pedido";
            this.btnCancelaPedido.UseVisualStyleBackColor = true;
            this.btnCancelaPedido.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgListaLanche
            // 
            this.dgListaLanche.AllowUserToAddRows = false;
            this.dgListaLanche.AllowUserToDeleteRows = false;
            this.dgListaLanche.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListaLanche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaLanche.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgListaPizzaColNome,
            this.dgListaPizzaColPreco,
            this.dgListaPizzaColCodigo});
            this.dgListaLanche.Location = new System.Drawing.Point(12, 47);
            this.dgListaLanche.Name = "dgListaLanche";
            this.dgListaLanche.ReadOnly = true;
            this.dgListaLanche.Size = new System.Drawing.Size(280, 390);
            this.dgListaLanche.TabIndex = 16;
            this.dgListaLanche.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgListaLanche_CellMouseDoubleClick);
            // 
            // dgListaPizzaColNome
            // 
            this.dgListaPizzaColNome.FillWeight = 149.2386F;
            this.dgListaPizzaColNome.HeaderText = "Nome";
            this.dgListaPizzaColNome.Name = "dgListaPizzaColNome";
            this.dgListaPizzaColNome.ReadOnly = true;
            // 
            // dgListaPizzaColPreco
            // 
            this.dgListaPizzaColPreco.FillWeight = 50.76142F;
            this.dgListaPizzaColPreco.HeaderText = "Preço";
            this.dgListaPizzaColPreco.Name = "dgListaPizzaColPreco";
            this.dgListaPizzaColPreco.ReadOnly = true;
            // 
            // dgListaPizzaColCodigo
            // 
            this.dgListaPizzaColCodigo.HeaderText = "Código";
            this.dgListaPizzaColCodigo.Name = "dgListaPizzaColCodigo";
            this.dgListaPizzaColCodigo.ReadOnly = true;
            this.dgListaPizzaColCodigo.Visible = false;
            // 
            // lblAvisoLanche
            // 
            this.lblAvisoLanche.AutoSize = true;
            this.lblAvisoLanche.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoLanche.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoLanche.Location = new System.Drawing.Point(373, 193);
            this.lblAvisoLanche.Name = "lblAvisoLanche";
            this.lblAvisoLanche.Size = new System.Drawing.Size(232, 14);
            this.lblAvisoLanche.TabIndex = 17;
            this.lblAvisoLanche.Text = "! Adicione apenas um lanche por vez!";
            // 
            // dgPedidoTempLancheCoItem
            // 
            this.dgPedidoTempLancheCoItem.HeaderText = "Item";
            this.dgPedidoTempLancheCoItem.Name = "dgPedidoTempLancheCoItem";
            this.dgPedidoTempLancheCoItem.ReadOnly = true;
            // 
            // dgPedidoTempLancheColTipo
            // 
            this.dgPedidoTempLancheColTipo.HeaderText = "Tipo";
            this.dgPedidoTempLancheColTipo.Name = "dgPedidoTempLancheColTipo";
            this.dgPedidoTempLancheColTipo.ReadOnly = true;
            this.dgPedidoTempLancheColTipo.Visible = false;
            // 
            // dgPedidoTempLancheCoICódigo
            // 
            this.dgPedidoTempLancheCoICódigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgPedidoTempLancheCoICódigo.HeaderText = "Código";
            this.dgPedidoTempLancheCoICódigo.Name = "dgPedidoTempLancheCoICódigo";
            this.dgPedidoTempLancheCoICódigo.ReadOnly = true;
            this.dgPedidoTempLancheCoICódigo.Visible = false;
            // 
            // lblTelaValor
            // 
            this.lblTelaValor.AutoSize = true;
            this.lblTelaValor.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelaValor.ForeColor = System.Drawing.Color.Black;
            this.lblTelaValor.Location = new System.Drawing.Point(652, 227);
            this.lblTelaValor.Name = "lblTelaValor";
            this.lblTelaValor.Size = new System.Drawing.Size(106, 14);
            this.lblTelaValor.TabIndex = 18;
            this.lblTelaValor.Text = "Valor do Lanche:";
            // 
            // lblValorLanche
            // 
            this.lblValorLanche.AutoSize = true;
            this.lblValorLanche.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblValorLanche.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorLanche.ForeColor = System.Drawing.Color.Black;
            this.lblValorLanche.Location = new System.Drawing.Point(659, 254);
            this.lblValorLanche.Name = "lblValorLanche";
            this.lblValorLanche.Size = new System.Drawing.Size(39, 24);
            this.lblValorLanche.TabIndex = 19;
            this.lblValorLanche.Text = "R$";
            this.lblValorLanche.Visible = false;
            // 
            // dgAdicionaisLancheColAdc
            // 
            this.dgAdicionaisLancheColAdc.FillWeight = 60F;
            this.dgAdicionaisLancheColAdc.HeaderText = "Adicional";
            this.dgAdicionaisLancheColAdc.Name = "dgAdicionaisLancheColAdc";
            this.dgAdicionaisLancheColAdc.ReadOnly = true;
            this.dgAdicionaisLancheColAdc.Width = 130;
            // 
            // dgAdicionaisLancheColPreco
            // 
            this.dgAdicionaisLancheColPreco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgAdicionaisLancheColPreco.HeaderText = "Preço";
            this.dgAdicionaisLancheColPreco.Name = "dgAdicionaisLancheColPreco";
            this.dgAdicionaisLancheColPreco.ReadOnly = true;
            // 
            // dgAdicionaisLancheColCodigo
            // 
            this.dgAdicionaisLancheColCodigo.HeaderText = "Código";
            this.dgAdicionaisLancheColCodigo.Name = "dgAdicionaisLancheColCodigo";
            this.dgAdicionaisLancheColCodigo.ReadOnly = true;
            this.dgAdicionaisLancheColCodigo.Visible = false;
            // 
            // TelaLanche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 449);
            this.Controls.Add(this.lblValorLanche);
            this.Controls.Add(this.lblTelaValor);
            this.Controls.Add(this.lblAvisoLanche);
            this.Controls.Add(this.dgListaLanche);
            this.Controls.Add(this.btnCancelaPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgAdicionaisLanche);
            this.Controls.Add(this.dgPedidoTempLanche);
            this.Controls.Add(this.btnAddPedido);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaLanche";
            this.Text = "FormLanche";
            this.Load += new System.EventHandler(this.FormLanche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidoTempLanche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdicionaisLanche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaLanche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgPedidoTempLanche;
        private System.Windows.Forms.DataGridView dgAdicionaisLanche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelaPedido;
        private System.Windows.Forms.DataGridView dgListaLanche;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaPizzaColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaPizzaColPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaPizzaColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPedidoTempLancheCoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPedidoTempLancheColTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPedidoTempLancheCoICódigo;
        private System.Windows.Forms.Label lblAvisoLanche;
        private System.Windows.Forms.Label lblTelaValor;
        private System.Windows.Forms.Label lblValorLanche;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAdicionaisLancheColAdc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAdicionaisLancheColPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAdicionaisLancheColCodigo;
    }
}