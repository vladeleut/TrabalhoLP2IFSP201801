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
            this.dgAdicionaisPizza = new System.Windows.Forms.DataGridView();
            this.dgAdicionaisPizzaColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAdicionaisPizzaColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAdicionaisPizzaColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPedidoPizza = new System.Windows.Forms.DataGridView();
            this.dgListaPizza = new System.Windows.Forms.DataGridView();
            this.dgListaPizzaColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgListaPizzaColPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgListaPizzaColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAvisoAvisoPizza1 = new System.Windows.Forms.Label();
            this.lblAvisoPizza2 = new System.Windows.Forms.Label();
            this.lblValorPizza = new System.Windows.Forms.Label();
            this.lblTelaValorPizza = new System.Windows.Forms.Label();
            this.lblContadorDePartes = new System.Windows.Forms.Label();
            this.Pizza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgPedidoPizzaColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdicionaisPizza)).BeginInit();
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
            this.btnAddPedido.Click += new System.EventHandler(this.btnAddPedido_Click);
            // 
            // btnCancelaPedido
            // 
            this.btnCancelaPedido.Location = new System.Drawing.Point(659, 385);
            this.btnCancelaPedido.Name = "btnCancelaPedido";
            this.btnCancelaPedido.Size = new System.Drawing.Size(96, 33);
            this.btnCancelaPedido.TabIndex = 20;
            this.btnCancelaPedido.Text = "Cancelar Pedido";
            this.btnCancelaPedido.UseVisualStyleBackColor = true;
            this.btnCancelaPedido.Click += new System.EventHandler(this.btnCancelaPedido_Click);
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
            // dgAdicionaisPizza
            // 
            this.dgAdicionaisPizza.AllowUserToAddRows = false;
            this.dgAdicionaisPizza.AllowUserToDeleteRows = false;
            this.dgAdicionaisPizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAdicionaisPizza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgAdicionaisPizzaColNome,
            this.dgAdicionaisPizzaColValor,
            this.dgAdicionaisPizzaColCodigo});
            this.dgAdicionaisPizza.Location = new System.Drawing.Point(372, 221);
            this.dgAdicionaisPizza.Name = "dgAdicionaisPizza";
            this.dgAdicionaisPizza.ReadOnly = true;
            this.dgAdicionaisPizza.Size = new System.Drawing.Size(240, 208);
            this.dgAdicionaisPizza.TabIndex = 17;
            this.dgAdicionaisPizza.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgAdicionaisPizza_CellMouseDoubleClick);
            // 
            // dgAdicionaisPizzaColNome
            // 
            this.dgAdicionaisPizzaColNome.HeaderText = "Adicional";
            this.dgAdicionaisPizzaColNome.Name = "dgAdicionaisPizzaColNome";
            this.dgAdicionaisPizzaColNome.ReadOnly = true;
            this.dgAdicionaisPizzaColNome.Width = 130;
            // 
            // dgAdicionaisPizzaColValor
            // 
            this.dgAdicionaisPizzaColValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgAdicionaisPizzaColValor.HeaderText = "Valor";
            this.dgAdicionaisPizzaColValor.Name = "dgAdicionaisPizzaColValor";
            this.dgAdicionaisPizzaColValor.ReadOnly = true;
            // 
            // dgAdicionaisPizzaColCodigo
            // 
            this.dgAdicionaisPizzaColCodigo.HeaderText = "Código";
            this.dgAdicionaisPizzaColCodigo.Name = "dgAdicionaisPizzaColCodigo";
            this.dgAdicionaisPizzaColCodigo.ReadOnly = true;
            this.dgAdicionaisPizzaColCodigo.Visible = false;
            // 
            // dgPedidoPizza
            // 
            this.dgPedidoPizza.AllowUserToAddRows = false;
            this.dgPedidoPizza.AllowUserToDeleteRows = false;
            this.dgPedidoPizza.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPedidoPizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidoPizza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pizza,
            this.DgPedidoPizzaColCodigo});
            this.dgPedidoPizza.Location = new System.Drawing.Point(372, 39);
            this.dgPedidoPizza.Name = "dgPedidoPizza";
            this.dgPedidoPizza.ReadOnly = true;
            this.dgPedidoPizza.Size = new System.Drawing.Size(412, 143);
            this.dgPedidoPizza.TabIndex = 16;
            this.dgPedidoPizza.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPedidoPizza_CellMouseDoubleClick);
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
            this.dgListaPizza.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgListaPizza_CellMouseDoubleClick);
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
            // lblAvisoAvisoPizza1
            // 
            this.lblAvisoAvisoPizza1.AutoSize = true;
            this.lblAvisoAvisoPizza1.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoAvisoPizza1.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoAvisoPizza1.Location = new System.Drawing.Point(637, 185);
            this.lblAvisoAvisoPizza1.Name = "lblAvisoAvisoPizza1";
            this.lblAvisoAvisoPizza1.Size = new System.Drawing.Size(130, 14);
            this.lblAvisoAvisoPizza1.TabIndex = 21;
            this.lblAvisoAvisoPizza1.Text = "Sabores adicionados:";
            // 
            // lblAvisoPizza2
            // 
            this.lblAvisoPizza2.AutoSize = true;
            this.lblAvisoPizza2.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoPizza2.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoPizza2.Location = new System.Drawing.Point(578, 199);
            this.lblAvisoPizza2.Name = "lblAvisoPizza2";
            this.lblAvisoPizza2.Size = new System.Drawing.Size(206, 14);
            this.lblAvisoPizza2.TabIndex = 22;
            this.lblAvisoPizza2.Text = " Remova ou adicione outra pizza.";
            this.lblAvisoPizza2.Visible = false;
            // 
            // lblValorPizza
            // 
            this.lblValorPizza.AutoSize = true;
            this.lblValorPizza.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblValorPizza.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPizza.ForeColor = System.Drawing.Color.Black;
            this.lblValorPizza.Location = new System.Drawing.Point(668, 263);
            this.lblValorPizza.Name = "lblValorPizza";
            this.lblValorPizza.Size = new System.Drawing.Size(39, 24);
            this.lblValorPizza.TabIndex = 24;
            this.lblValorPizza.Text = "R$";
            this.lblValorPizza.Visible = false;
            // 
            // lblTelaValorPizza
            // 
            this.lblTelaValorPizza.AutoSize = true;
            this.lblTelaValorPizza.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelaValorPizza.ForeColor = System.Drawing.Color.Black;
            this.lblTelaValorPizza.Location = new System.Drawing.Point(661, 236);
            this.lblTelaValorPizza.Name = "lblTelaValorPizza";
            this.lblTelaValorPizza.Size = new System.Drawing.Size(94, 14);
            this.lblTelaValorPizza.TabIndex = 23;
            this.lblTelaValorPizza.Text = "Valor da Pizza:";
            // 
            // lblContadorDePartes
            // 
            this.lblContadorDePartes.AutoSize = true;
            this.lblContadorDePartes.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorDePartes.ForeColor = System.Drawing.Color.Red;
            this.lblContadorDePartes.Location = new System.Drawing.Point(770, 185);
            this.lblContadorDePartes.Name = "lblContadorDePartes";
            this.lblContadorDePartes.Size = new System.Drawing.Size(14, 14);
            this.lblContadorDePartes.TabIndex = 25;
            this.lblContadorDePartes.Text = "0";
            // 
            // Pizza
            // 
            this.Pizza.HeaderText = "Pizza";
            this.Pizza.Name = "Pizza";
            this.Pizza.ReadOnly = true;
            // 
            // DgPedidoPizzaColCodigo
            // 
            this.DgPedidoPizzaColCodigo.HeaderText = "Código";
            this.DgPedidoPizzaColCodigo.Name = "DgPedidoPizzaColCodigo";
            this.DgPedidoPizzaColCodigo.ReadOnly = true;
            this.DgPedidoPizzaColCodigo.Visible = false;
            // 
            // TelaPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblContadorDePartes);
            this.Controls.Add(this.lblValorPizza);
            this.Controls.Add(this.lblTelaValorPizza);
            this.Controls.Add(this.lblAvisoPizza2);
            this.Controls.Add(this.lblAvisoAvisoPizza1);
            this.Controls.Add(this.btnCancelaPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgAdicionaisPizza);
            this.Controls.Add(this.dgPedidoPizza);
            this.Controls.Add(this.dgListaPizza);
            this.Controls.Add(this.btnAddPedido);
            this.Controls.Add(this.label1);
            this.Name = "TelaPizza";
            this.Text = "FormPizza";
            this.Load += new System.EventHandler(this.FormPizza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAdicionaisPizza)).EndInit();
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
        private System.Windows.Forms.DataGridView dgAdicionaisPizza;
        private System.Windows.Forms.DataGridView dgPedidoPizza;
        private System.Windows.Forms.DataGridView dgListaPizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaPizzaColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaPizzaColPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaPizzaColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAdicionaisPizzaColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAdicionaisPizzaColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAdicionaisPizzaColCodigo;
        private System.Windows.Forms.Label lblAvisoAvisoPizza1;
        private System.Windows.Forms.Label lblAvisoPizza2;
        private System.Windows.Forms.Label lblValorPizza;
        private System.Windows.Forms.Label lblTelaValorPizza;
        private System.Windows.Forms.Label lblContadorDePartes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgPedidoPizzaColCodigo;
    }
}