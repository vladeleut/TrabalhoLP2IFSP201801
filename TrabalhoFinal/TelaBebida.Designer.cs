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
            this.label1 = new System.Windows.Forms.Label();
            this.dgListaBebidas = new System.Windows.Forms.DataGridView();
            this.dgListaPizzaColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgListaPizzaColPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgListaPizzaColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelaPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaBebidas)).BeginInit();
            this.SuspendLayout();
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
            this.dgListaBebidas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgListaBebidas_CellMouseDoubleClick);
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
            // btnCancelaPedido
            // 
            this.btnCancelaPedido.Location = new System.Drawing.Point(110, 377);
            this.btnCancelaPedido.Name = "btnCancelaPedido";
            this.btnCancelaPedido.Size = new System.Drawing.Size(96, 33);
            this.btnCancelaPedido.TabIndex = 21;
            this.btnCancelaPedido.Text = "Cancelar Pedido";
            this.btnCancelaPedido.UseVisualStyleBackColor = true;
            this.btnCancelaPedido.Click += new System.EventHandler(this.btnCancelaPedido_Click);
            // 
            // TelaBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 418);
            this.Controls.Add(this.dgListaBebidas);
            this.Controls.Add(this.btnCancelaPedido);
            this.Controls.Add(this.label1);
            this.Name = "TelaBebida";
            this.Text = "FormBebida";
            this.Load += new System.EventHandler(this.FormBebida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaBebidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgListaBebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaPizzaColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaPizzaColPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgListaPizzaColCodigo;
        private System.Windows.Forms.Button btnCancelaPedido;
    }
}