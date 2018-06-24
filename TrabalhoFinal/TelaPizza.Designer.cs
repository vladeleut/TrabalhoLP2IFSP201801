namespace TrabalhoFinal
{
    partial class TelaPizza
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
            this.btnAddPedido = new System.Windows.Forms.Button();
            this.btnCancelaPedido = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgPedidoAdcPizza = new System.Windows.Forms.DataGridView();
            this.Adicional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPedidoPizza = new System.Windows.Forms.DataGridView();
            this.Pizza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgListaPizza = new System.Windows.Forms.DataGridView();
            this.dgListaPizzaColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgListaPizzaColPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgListaPizzaColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidoAdcPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidoPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pizzas:";
            // 
            // btnAddPedido
            // 
            this.btnAddPedido.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAddPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPedido.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPedido.Location = new System.Drawing.Point(631, 311);
            this.btnAddPedido.Name = "btnAddPedido";
            this.btnAddPedido.Size = new System.Drawing.Size(157, 68);
            this.btnAddPedido.TabIndex = 3;
            this.btnAddPedido.Text = "Adicionar ao Pedido";
            this.btnAddPedido.UseVisualStyleBackColor = false;
            // 
            // btnCancelaPedido
            // 
            this.btnCancelaPedido.Location = new System.Drawing.Point(670, 385);
            this.btnCancelaPedido.Name = "btnCancelaPedido";
            this.btnCancelaPedido.Size = new System.Drawing.Size(96, 33);
            this.btnCancelaPedido.TabIndex = 20;
            this.btnCancelaPedido.Text = "Cancelar Pedido";
            this.btnCancelaPedido.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Adicionais:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Pedido:";
            // 
            // dgPedidoAdcPizza
            // 
            this.dgPedidoAdcPizza.AllowUserToAddRows = false;
            this.dgPedidoAdcPizza.AllowUserToDeleteRows = false;
            this.dgPedidoAdcPizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidoAdcPizza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adicional,
            this.Valor});
            this.dgPedidoAdcPizza.Location = new System.Drawing.Point(372, 221);
            this.dgPedidoAdcPizza.Name = "dgPedidoAdcPizza";
            this.dgPedidoAdcPizza.ReadOnly = true;
            this.dgPedidoAdcPizza.Size = new System.Drawing.Size(240, 208);
            this.dgPedidoAdcPizza.TabIndex = 17;
            // 
            // Adicional
            // 
            this.Adicional.HeaderText = "Adicional";
            this.Adicional.Name = "Adicional";
            this.Adicional.ReadOnly = true;
            this.Adicional.Width = 130;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // dgPedidoPizza
            // 
            this.dgPedidoPizza.AllowUserToAddRows = false;
            this.dgPedidoPizza.AllowUserToDeleteRows = false;
            this.dgPedidoPizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidoPizza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pizza,
            this.Quantidade,
            this.Preço});
            this.dgPedidoPizza.Location = new System.Drawing.Point(372, 39);
            this.dgPedidoPizza.Name = "dgPedidoPizza";
            this.dgPedidoPizza.ReadOnly = true;
            this.dgPedidoPizza.Size = new System.Drawing.Size(412, 143);
            this.dgPedidoPizza.TabIndex = 16;
            // 
            // Pizza
            // 
            this.Pizza.HeaderText = "Pizza";
            this.Pizza.Name = "Pizza";
            this.Pizza.ReadOnly = true;
            this.Pizza.Width = 200;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quatidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 85;
            // 
            // Preço
            // 
            this.Preço.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            this.Preço.ReadOnly = true;
            // 
            // dgListaPizza
            // 
            this.dgListaPizza.AllowUserToAddRows = false;
            this.dgListaPizza.AllowUserToDeleteRows = false;
            this.dgListaPizza.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListaPizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaPizza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgListaPizzaColNome,
            this.dgListaPizzaColPreco,
            this.dgListaPizzaColCodigo});
            this.dgListaPizza.Location = new System.Drawing.Point(12, 39);
            this.dgListaPizza.Name = "dgListaPizza";
            this.dgListaPizza.ReadOnly = true;
            this.dgListaPizza.Size = new System.Drawing.Size(280, 390);
            this.dgListaPizza.TabIndex = 15;
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
            // TelaPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelaPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgPedidoAdcPizza);
            this.Controls.Add(this.dgPedidoPizza);
            this.Controls.Add(this.dgListaPizza);
            this.Controls.Add(this.btnAddPedido);
            this.Controls.Add(this.label1);
            this.Name = "TelaPizza";
            this.Text = "FormPizza";
            this.Load += new System.EventHandler(this.FormPizza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidoAdcPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidoPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPedido;
        private System.Windows.Forms.Button btnCancelaPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgPedidoAdcPizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adicional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridView dgPedidoPizza;
        private System.Windows.Forms.DataGridView dgListaPizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaPizzaColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaPizzaColPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaPizzaColCodigo;
    }
}