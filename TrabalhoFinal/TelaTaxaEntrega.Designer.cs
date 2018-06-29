namespace TrabalhoFinal
{
    partial class TelaTaxaEntrega
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
            this.txtPesqTaxa = new System.Windows.Forms.TextBox();
            this.btnNovaTaxa = new System.Windows.Forms.Button();
            this.btnTelaProdCancela = new System.Windows.Forms.Button();
            this.btnEditaTaxa = new System.Windows.Forms.Button();
            this.btnExcluiTaxa = new System.Windows.Forms.Button();
            this.lblPesqTaxa = new System.Windows.Forms.Label();
            this.dgEntregas = new System.Windows.Forms.DataGridView();
            this.dgEntregasColDist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEntregasColBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEntregasColPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtPrecoTaxa = new System.Windows.Forms.TextBox();
            this.lblPrecoTaxa = new System.Windows.Forms.Label();
            this.btnInsereTaxa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntregas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesqTaxa
            // 
            this.txtPesqTaxa.Location = new System.Drawing.Point(35, 49);
            this.txtPesqTaxa.Name = "txtPesqTaxa";
            this.txtPesqTaxa.Size = new System.Drawing.Size(220, 20);
            this.txtPesqTaxa.TabIndex = 0;
            this.txtPesqTaxa.TextChanged += new System.EventHandler(this.txtPesqTaxa_TextChanged);
            // 
            // btnNovaTaxa
            // 
            this.btnNovaTaxa.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaTaxa.Location = new System.Drawing.Point(12, 94);
            this.btnNovaTaxa.Name = "btnNovaTaxa";
            this.btnNovaTaxa.Size = new System.Drawing.Size(85, 35);
            this.btnNovaTaxa.TabIndex = 1;
            this.btnNovaTaxa.Text = "Novo";
            this.btnNovaTaxa.UseVisualStyleBackColor = true;
            this.btnNovaTaxa.Click += new System.EventHandler(this.btnNovaTaxa_Click);
            // 
            // btnTelaProdCancela
            // 
            this.btnTelaProdCancela.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaProdCancela.Location = new System.Drawing.Point(103, 338);
            this.btnTelaProdCancela.Name = "btnTelaProdCancela";
            this.btnTelaProdCancela.Size = new System.Drawing.Size(85, 35);
            this.btnTelaProdCancela.TabIndex = 8;
            this.btnTelaProdCancela.Text = "Cancelar";
            this.btnTelaProdCancela.UseVisualStyleBackColor = true;
            this.btnTelaProdCancela.Visible = false;
            this.btnTelaProdCancela.Click += new System.EventHandler(this.btnTelaProdCancela_Click);
            // 
            // btnEditaTaxa
            // 
            this.btnEditaTaxa.Enabled = false;
            this.btnEditaTaxa.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditaTaxa.Location = new System.Drawing.Point(103, 94);
            this.btnEditaTaxa.Name = "btnEditaTaxa";
            this.btnEditaTaxa.Size = new System.Drawing.Size(85, 35);
            this.btnEditaTaxa.TabIndex = 2;
            this.btnEditaTaxa.Text = "Editar";
            this.btnEditaTaxa.UseVisualStyleBackColor = true;
            // 
            // btnExcluiTaxa
            // 
            this.btnExcluiTaxa.Enabled = false;
            this.btnExcluiTaxa.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluiTaxa.Location = new System.Drawing.Point(194, 94);
            this.btnExcluiTaxa.Name = "btnExcluiTaxa";
            this.btnExcluiTaxa.Size = new System.Drawing.Size(85, 35);
            this.btnExcluiTaxa.TabIndex = 3;
            this.btnExcluiTaxa.Text = "Excluir";
            this.btnExcluiTaxa.UseVisualStyleBackColor = true;
            // 
            // lblPesqTaxa
            // 
            this.lblPesqTaxa.AutoSize = true;
            this.lblPesqTaxa.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqTaxa.Location = new System.Drawing.Point(105, 28);
            this.lblPesqTaxa.Name = "lblPesqTaxa";
            this.lblPesqTaxa.Size = new System.Drawing.Size(91, 18);
            this.lblPesqTaxa.TabIndex = 12;
            this.lblPesqTaxa.Text = "Pesquisar";
            // 
            // dgEntregas
            // 
            this.dgEntregas.AllowUserToAddRows = false;
            this.dgEntregas.AllowUserToDeleteRows = false;
            this.dgEntregas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEntregas.BackgroundColor = System.Drawing.Color.White;
            this.dgEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntregas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgEntregasColDist,
            this.dgEntregasColBairro,
            this.dgEntregasColPreco});
            this.dgEntregas.Location = new System.Drawing.Point(304, 13);
            this.dgEntregas.Name = "dgEntregas";
            this.dgEntregas.ReadOnly = true;
            this.dgEntregas.Size = new System.Drawing.Size(368, 362);
            this.dgEntregas.TabIndex = 1;
            // 
            // dgEntregasColDist
            // 
            this.dgEntregasColDist.FillWeight = 56.35656F;
            this.dgEntregasColDist.HeaderText = "Distância";
            this.dgEntregasColDist.Name = "dgEntregasColDist";
            this.dgEntregasColDist.ReadOnly = true;
            // 
            // dgEntregasColBairro
            // 
            this.dgEntregasColBairro.FillWeight = 167.5013F;
            this.dgEntregasColBairro.HeaderText = "Bairro";
            this.dgEntregasColBairro.Name = "dgEntregasColBairro";
            this.dgEntregasColBairro.ReadOnly = true;
            // 
            // dgEntregasColPreco
            // 
            this.dgEntregasColPreco.FillWeight = 76.14214F;
            this.dgEntregasColPreco.HeaderText = "Preço";
            this.dgEntregasColPreco.Name = "dgEntregasColPreco";
            this.dgEntregasColPreco.ReadOnly = true;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(110, 224);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(145, 20);
            this.txtBairro.TabIndex = 5;
            this.txtBairro.Visible = false;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(45, 223);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(59, 18);
            this.lblBairro.TabIndex = 32;
            this.lblBairro.Text = "Bairro";
            this.lblBairro.Visible = false;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(110, 182);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(145, 20);
            this.txtDistancia.TabIndex = 4;
            this.txtDistancia.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(17, 181);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(87, 18);
            this.lblNome.TabIndex = 31;
            this.lblNome.Text = "Distância";
            this.lblNome.Visible = false;
            // 
            // txtPrecoTaxa
            // 
            this.txtPrecoTaxa.Location = new System.Drawing.Point(110, 266);
            this.txtPrecoTaxa.Name = "txtPrecoTaxa";
            this.txtPrecoTaxa.Size = new System.Drawing.Size(145, 20);
            this.txtPrecoTaxa.TabIndex = 6;
            this.txtPrecoTaxa.Visible = false;
            // 
            // lblPrecoTaxa
            // 
            this.lblPrecoTaxa.AutoSize = true;
            this.lblPrecoTaxa.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoTaxa.Location = new System.Drawing.Point(49, 265);
            this.lblPrecoTaxa.Name = "lblPrecoTaxa";
            this.lblPrecoTaxa.Size = new System.Drawing.Size(55, 18);
            this.lblPrecoTaxa.TabIndex = 34;
            this.lblPrecoTaxa.Text = "Preço";
            this.lblPrecoTaxa.Visible = false;
            // 
            // btnInsereTaxa
            // 
            this.btnInsereTaxa.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsereTaxa.Location = new System.Drawing.Point(103, 297);
            this.btnInsereTaxa.Name = "btnInsereTaxa";
            this.btnInsereTaxa.Size = new System.Drawing.Size(85, 35);
            this.btnInsereTaxa.TabIndex = 7;
            this.btnInsereTaxa.Text = "Inserir";
            this.btnInsereTaxa.UseVisualStyleBackColor = true;
            this.btnInsereTaxa.Visible = false;
            this.btnInsereTaxa.Click += new System.EventHandler(this.btnInsereTaxa_Click);
            // 
            // TelaTaxaEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 385);
            this.Controls.Add(this.btnInsereTaxa);
            this.Controls.Add(this.txtPrecoTaxa);
            this.Controls.Add(this.lblPrecoTaxa);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dgEntregas);
            this.Controls.Add(this.lblPesqTaxa);
            this.Controls.Add(this.btnTelaProdCancela);
            this.Controls.Add(this.btnExcluiTaxa);
            this.Controls.Add(this.btnEditaTaxa);
            this.Controls.Add(this.txtPesqTaxa);
            this.Controls.Add(this.btnNovaTaxa);
            this.Name = "TelaTaxaEntrega";
            this.Text = "TelaTaxaEntrega";
            this.Load += new System.EventHandler(this.TelaTaxaEntrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEntregas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPesqTaxa;
        private System.Windows.Forms.Button btnNovaTaxa;
        private System.Windows.Forms.Button btnTelaProdCancela;
        private System.Windows.Forms.Button btnEditaTaxa;
        private System.Windows.Forms.Button btnExcluiTaxa;
        private System.Windows.Forms.Label lblPesqTaxa;
        private System.Windows.Forms.DataGridView dgEntregas;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtPrecoTaxa;
        private System.Windows.Forms.Label lblPrecoTaxa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEntregasColDist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEntregasColBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEntregasColPreco;
        private System.Windows.Forms.Button btnInsereTaxa;
    }
}