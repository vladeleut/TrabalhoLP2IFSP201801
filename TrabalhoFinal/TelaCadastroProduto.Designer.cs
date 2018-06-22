namespace TrabalhoFinal
{
    partial class TelaCadastroProduto
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
            this.btnCadastraProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.txtPrecoProd = new System.Windows.Forms.TextBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.btnTelaProdCancela = new System.Windows.Forms.Button();
            this.panProdutos = new System.Windows.Forms.Panel();
            this.lblPesqProd = new System.Windows.Forms.Label();
            this.dgListaProd = new System.Windows.Forms.DataGridView();
            this.dgProdColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProdColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProdColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProdColPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisaProdutos = new System.Windows.Forms.TextBox();
            this.btnEditarProd = new System.Windows.Forms.Button();
            this.cbTipoProd = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaProd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastraProduto
            // 
            this.btnCadastraProduto.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraProduto.Location = new System.Drawing.Point(38, 209);
            this.btnCadastraProduto.Name = "btnCadastraProduto";
            this.btnCadastraProduto.Size = new System.Drawing.Size(101, 35);
            this.btnCadastraProduto.TabIndex = 3;
            this.btnCadastraProduto.Text = "Cadastrar";
            this.btnCadastraProduto.UseVisualStyleBackColor = true;
            this.btnCadastraProduto.Click += new System.EventHandler(this.btnCadastraProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Codigo?";
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.Location = new System.Drawing.Point(115, 159);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.ReadOnly = true;
            this.txtCodigoProd.Size = new System.Drawing.Size(70, 20);
            this.txtCodigoProd.TabIndex = 3;
            // 
            // txtPrecoProd
            // 
            this.txtPrecoProd.Location = new System.Drawing.Point(115, 117);
            this.txtPrecoProd.Name = "txtPrecoProd";
            this.txtPrecoProd.Size = new System.Drawing.Size(70, 20);
            this.txtPrecoProd.TabIndex = 2;
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(115, 78);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(145, 20);
            this.txtNomeProd.TabIndex = 1;
            // 
            // btnTelaProdCancela
            // 
            this.btnTelaProdCancela.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaProdCancela.Location = new System.Drawing.Point(198, 209);
            this.btnTelaProdCancela.Name = "btnTelaProdCancela";
            this.btnTelaProdCancela.Size = new System.Drawing.Size(100, 35);
            this.btnTelaProdCancela.TabIndex = 5;
            this.btnTelaProdCancela.Text = "Cancelar";
            this.btnTelaProdCancela.UseVisualStyleBackColor = true;
            this.btnTelaProdCancela.Click += new System.EventHandler(this.btnTelaProdCancela_Click);
            // 
            // panProdutos
            // 
            this.panProdutos.Controls.Add(this.lblPesqProd);
            this.panProdutos.Controls.Add(this.dgListaProd);
            this.panProdutos.Controls.Add(this.txtPesquisaProdutos);
            this.panProdutos.Location = new System.Drawing.Point(327, 12);
            this.panProdutos.Name = "panProdutos";
            this.panProdutos.Size = new System.Drawing.Size(486, 297);
            this.panProdutos.TabIndex = 10;
            // 
            // lblPesqProd
            // 
            this.lblPesqProd.AutoSize = true;
            this.lblPesqProd.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqProd.Location = new System.Drawing.Point(20, 8);
            this.lblPesqProd.Name = "lblPesqProd";
            this.lblPesqProd.Size = new System.Drawing.Size(91, 18);
            this.lblPesqProd.TabIndex = 12;
            this.lblPesqProd.Text = "Pesquisar";
            // 
            // dgListaProd
            // 
            this.dgListaProd.AllowUserToAddRows = false;
            this.dgListaProd.AllowUserToDeleteRows = false;
            this.dgListaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgProdColTipo,
            this.dgProdColCodigo,
            this.dgProdColNome,
            this.dgProdColPreco});
            this.dgListaProd.Location = new System.Drawing.Point(0, 32);
            this.dgListaProd.Name = "dgListaProd";
            this.dgListaProd.ReadOnly = true;
            this.dgListaProd.Size = new System.Drawing.Size(483, 265);
            this.dgListaProd.TabIndex = 1;
            this.dgListaProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaProd_MouseClick);
            this.dgListaProd.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaProd_CellContentDoubleClick);
            // 
            // dgProdColTipo
            // 
            this.dgProdColTipo.HeaderText = "Tipo";
            this.dgProdColTipo.Name = "dgProdColTipo";
            this.dgProdColTipo.ReadOnly = true;
            this.dgProdColTipo.Width = 110;
            // 
            // dgProdColCodigo
            // 
            this.dgProdColCodigo.HeaderText = "Código";
            this.dgProdColCodigo.Name = "dgProdColCodigo";
            this.dgProdColCodigo.ReadOnly = true;
            this.dgProdColCodigo.Width = 110;
            // 
            // dgProdColNome
            // 
            this.dgProdColNome.HeaderText = "Nome";
            this.dgProdColNome.Name = "dgProdColNome";
            this.dgProdColNome.ReadOnly = true;
            this.dgProdColNome.Width = 110;
            // 
            // dgProdColPreco
            // 
            this.dgProdColPreco.HeaderText = "Preço";
            this.dgProdColPreco.Name = "dgProdColPreco";
            this.dgProdColPreco.ReadOnly = true;
            this.dgProdColPreco.Width = 110;
            // 
            // txtPesquisaProdutos
            // 
            this.txtPesquisaProdutos.Location = new System.Drawing.Point(117, 6);
            this.txtPesquisaProdutos.Name = "txtPesquisaProdutos";
            this.txtPesquisaProdutos.Size = new System.Drawing.Size(358, 20);
            this.txtPesquisaProdutos.TabIndex = 20;
            // 
            // btnEditarProd
            // 
            this.btnEditarProd.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProd.Location = new System.Drawing.Point(38, 274);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.Size = new System.Drawing.Size(101, 35);
            this.btnEditarProd.TabIndex = 6;
            this.btnEditarProd.Text = "Editar";
            this.btnEditarProd.UseVisualStyleBackColor = true;
            // 
            // cbTipoProd
            // 
            this.cbTipoProd.FormattingEnabled = true;
            this.cbTipoProd.Location = new System.Drawing.Point(115, 34);
            this.cbTipoProd.Name = "cbTipoProd";
            this.cbTipoProd.Size = new System.Drawing.Size(145, 21);
            this.cbTipoProd.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(197, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbTipoProd);
            this.Controls.Add(this.btnEditarProd);
            this.Controls.Add(this.panProdutos);
            this.Controls.Add(this.btnTelaProdCancela);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.txtPrecoProd);
            this.Controls.Add(this.txtCodigoProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastraProduto);
            this.Name = "TelaCadastroProduto";
            this.Text = "TelaCadastroProduto";
            this.Load += new System.EventHandler(this.TelaCadastroProduto_Load);
            this.panProdutos.ResumeLayout(false);
            this.panProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastraProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoProd;
        private System.Windows.Forms.TextBox txtPrecoProd;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.Button btnTelaProdCancela;
        private System.Windows.Forms.Panel panProdutos;
        private System.Windows.Forms.DataGridView dgListaProd;
        private System.Windows.Forms.TextBox txtPesquisaProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProdColTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProdColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProdColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProdColPreco;
        private System.Windows.Forms.Button btnEditarProd;
        private System.Windows.Forms.Label lblPesqProd;
        private System.Windows.Forms.ComboBox cbTipoProd;
        private System.Windows.Forms.Button button1;
    }
}