namespace TrabalhoFinal
{
    partial class TelaBebida
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
            this.btnAddPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelaPedido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgPedidoTempBebida = new System.Windows.Forms.DataGridView();
            this.dgListaBebidas = new System.Windows.Forms.DataGridView();
            this.dgListaPizzaColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgListaPizzaColPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgListaPizzaColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidoTempBebida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaBebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPedido
            // 
            this.btnAddPedido.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAddPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPedido.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPedido.Location = new System.Drawing.Point(380, 249);
            this.btnAddPedido.Name = "btnAddPedido";
            this.btnAddPedido.Size = new System.Drawing.Size(157, 68);
            this.btnAddPedido.TabIndex = 7;
            this.btnAddPedido.Text = "Adicionar ao Pedido";
            this.btnAddPedido.UseVisualStyleBackColor = false;
            this.btnAddPedido.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bebidas:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancelaPedido
            // 
            this.btnCancelaPedido.Location = new System.Drawing.Point(414, 338);
            this.btnCancelaPedido.Name = "btnCancelaPedido";
            this.btnCancelaPedido.Size = new System.Drawing.Size(96, 33);
            this.btnCancelaPedido.TabIndex = 21;
            this.btnCancelaPedido.Text = "Cancelar Pedido";
            this.btnCancelaPedido.UseVisualStyleBackColor = true;
            this.btnCancelaPedido.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pedido:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgPedidoTempBebida
            // 
            this.dgPedidoTempBebida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidoTempBebida.Location = new System.Drawing.Point(322, 40);
            this.dgPedidoTempBebida.Name = "dgPedidoTempBebida";
            this.dgPedidoTempBebida.Size = new System.Drawing.Size(265, 192);
            this.dgPedidoTempBebida.TabIndex = 23;
            // 
            // dgListaBebidas
            // 
            this.dgListaBebidas.AllowUserToAddRows = false;
            this.dgListaBebidas.AllowUserToDeleteRows = false;
            this.dgListaBebidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListaBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgListaPizzaColNome,
            this.dgListaPizzaColPreco,
            this.dgListaPizzaColCodigo});
            this.dgListaBebidas.Location = new System.Drawing.Point(12, 40);
            this.dgListaBebidas.Name = "dgListaBebidas";
            this.dgListaBebidas.ReadOnly = true;
            this.dgListaBebidas.Size = new System.Drawing.Size(280, 331);
            this.dgListaBebidas.TabIndex = 24;
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
            // TelaBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 383);
            this.Controls.Add(this.dgListaBebidas);
            this.Controls.Add(this.dgPedidoTempBebida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelaPedido);
            this.Controls.Add(this.btnAddPedido);
            this.Controls.Add(this.label1);
            this.Name = "TelaBebida";
            this.Text = "FormBebida";
            this.Load += new System.EventHandler(this.FormBebida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidoTempBebida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaBebidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelaPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgPedidoTempBebida;
        private System.Windows.Forms.DataGridView dgListaBebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaPizzaColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaPizzaColPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaPizzaColCodigo;
    }
}