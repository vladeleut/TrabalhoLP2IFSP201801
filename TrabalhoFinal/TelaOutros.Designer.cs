namespace TrabalhoFinal
{
    partial class TelaOutros
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
            this.btnCancelaPedido = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Adicional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Pizza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddPedidoOutros = new System.Windows.Forms.Button();
            this.lblOutros = new System.Windows.Forms.Label();
            this.dgListaOutros = new System.Windows.Forms.DataGridView();
            this.dgListaOutrosColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgListaPizzaColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgListaPizzaColPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgListaPizzaColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaOutros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelaPedido
            // 
            this.btnCancelaPedido.Location = new System.Drawing.Point(670, 391);
            this.btnCancelaPedido.Name = "btnCancelaPedido";
            this.btnCancelaPedido.Size = new System.Drawing.Size(96, 33);
            this.btnCancelaPedido.TabIndex = 28;
            this.btnCancelaPedido.Text = "Cancelar Pedido";
            this.btnCancelaPedido.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Adicionais:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Pedido:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adicional,
            this.Valor});
            this.dataGridView3.Location = new System.Drawing.Point(372, 227);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 208);
            this.dataGridView3.TabIndex = 25;
            // 
            // Adicional
            // 
            this.Adicional.HeaderText = "Adicional";
            this.Adicional.Name = "Adicional";
            this.Adicional.Width = 130;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pizza,
            this.Quantidade,
            this.Preço});
            this.dataGridView2.Location = new System.Drawing.Point(372, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(412, 143);
            this.dataGridView2.TabIndex = 24;
            // 
            // Pizza
            // 
            this.Pizza.HeaderText = "Pizza";
            this.Pizza.Name = "Pizza";
            this.Pizza.Width = 200;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quatidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 85;
            // 
            // Preço
            // 
            this.Preço.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            // 
            // btnAddPedidoOutros
            // 
            this.btnAddPedidoOutros.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAddPedidoOutros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPedidoOutros.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPedidoOutros.Location = new System.Drawing.Point(631, 317);
            this.btnAddPedidoOutros.Name = "btnAddPedidoOutros";
            this.btnAddPedidoOutros.Size = new System.Drawing.Size(157, 68);
            this.btnAddPedidoOutros.TabIndex = 22;
            this.btnAddPedidoOutros.Text = "Adicionar ao Pedido";
            this.btnAddPedidoOutros.UseVisualStyleBackColor = false;
            // 
            // lblOutros
            // 
            this.lblOutros.AutoSize = true;
            this.lblOutros.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutros.Location = new System.Drawing.Point(12, 15);
            this.lblOutros.Name = "lblOutros";
            this.lblOutros.Size = new System.Drawing.Size(105, 27);
            this.lblOutros.TabIndex = 21;
            this.lblOutros.Text = "Outros:";
            // 
            // dgListaOutros
            // 
            this.dgListaOutros.AllowUserToAddRows = false;
            this.dgListaOutros.AllowUserToDeleteRows = false;
            this.dgListaOutros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListaOutros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaOutros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgListaOutrosColTipo,
            this.dgListaPizzaColNome,
            this.dgListaPizzaColPreco,
            this.dgListaPizzaColCodigo});
            this.dgListaOutros.Location = new System.Drawing.Point(12, 45);
            this.dgListaOutros.Name = "dgListaOutros";
            this.dgListaOutros.ReadOnly = true;
            this.dgListaOutros.Size = new System.Drawing.Size(337, 390);
            this.dgListaOutros.TabIndex = 29;
            // 
            // dgListaOutrosColTipo
            // 
            this.dgListaOutrosColTipo.HeaderText = "Tipo";
            this.dgListaOutrosColTipo.Name = "dgListaOutrosColTipo";
            this.dgListaOutrosColTipo.ReadOnly = true;
            // 
            // dgListaPizzaColNome
            // 
            this.dgListaPizzaColNome.HeaderText = "Nome";
            this.dgListaPizzaColNome.Name = "dgListaPizzaColNome";
            this.dgListaPizzaColNome.ReadOnly = true;
            // 
            // dgListaPizzaColPreco
            // 
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
            // TelaOutros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgListaOutros);
            this.Controls.Add(this.btnCancelaPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnAddPedidoOutros);
            this.Controls.Add(this.lblOutros);
            this.Name = "TelaOutros";
            this.Text = "TeleOutros";
            this.Load += new System.EventHandler(this.TelaOutros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaOutros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelaPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adicional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.Button btnAddPedidoOutros;
        private System.Windows.Forms.Label lblOutros;
        private System.Windows.Forms.DataGridView dgListaOutros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaOutrosColTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaPizzaColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaPizzaColPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaPizzaColCodigo;
    }
}