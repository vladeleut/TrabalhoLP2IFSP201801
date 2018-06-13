namespace TrabalhoFinal
{
    partial class FormLanche
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lanche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adicional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelaPedido = new System.Windows.Forms.Button();
            this.Lanche1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.btnAddPedido.Click += new System.EventHandler(this.button1_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lanche1,
            this.Preço1});
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(280, 387);
            this.dataGridView1.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lanche,
            this.Quantidade,
            this.Preço});
            this.dataGridView2.Location = new System.Drawing.Point(367, 39);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(412, 143);
            this.dataGridView2.TabIndex = 10;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adicional,
            this.Valor});
            this.dataGridView3.Location = new System.Drawing.Point(367, 221);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 205);
            this.dataGridView3.TabIndex = 11;
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
            this.label3.Location = new System.Drawing.Point(363, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Adicionais:";
            // 
            // Lanche
            // 
            this.Lanche.HeaderText = "Lanche";
            this.Lanche.Name = "Lanche";
            this.Lanche.Width = 200;
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
            // Lanche1
            // 
            this.Lanche1.HeaderText = "Lanche1";
            this.Lanche1.Name = "Lanche1";
            this.Lanche1.Width = 160;
            // 
            // Preço1
            // 
            this.Preço1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Preço1.HeaderText = "Preço1";
            this.Preço1.Name = "Preço1";
            // 
            // FormLanche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 449);
            this.Controls.Add(this.btnCancelaPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddPedido);
            this.Controls.Add(this.label1);
            this.Name = "FormLanche";
            this.Text = "FormLanche";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lanche1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lanche;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adicional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelaPedido;
    }
}