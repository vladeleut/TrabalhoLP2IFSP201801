namespace TrabalhoFinal
{
    partial class TelaCliente
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditarProd = new System.Windows.Forms.Button();
            this.panProdutos = new System.Windows.Forms.Panel();
            this.lblPesqProd = new System.Windows.Forms.Label();
            this.dgListaClientes = new System.Windows.Forms.DataGridView();
            this.dgClienteColTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgClienteColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgClienteColEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgClienteColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisaNomes = new System.Windows.Forms.TextBox();
            this.btnTelaProdCancela = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndCliente = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCadastraProduto = new System.Windows.Forms.Button();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtObsCliente = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.panProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(163, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEditarProd
            // 
            this.btnEditarProd.Enabled = false;
            this.btnEditarProd.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProd.Location = new System.Drawing.Point(30, 274);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.Size = new System.Drawing.Size(101, 35);
            this.btnEditarProd.TabIndex = 9;
            this.btnEditarProd.Text = "Excluir";
            this.btnEditarProd.UseVisualStyleBackColor = true;
            // 
            // panProdutos
            // 
            this.panProdutos.Controls.Add(this.lblPesqProd);
            this.panProdutos.Controls.Add(this.dgListaClientes);
            this.panProdutos.Controls.Add(this.txtPesquisaNomes);
            this.panProdutos.Controls.Add(this.label8);
            this.panProdutos.Location = new System.Drawing.Point(302, 12);
            this.panProdutos.Name = "panProdutos";
            this.panProdutos.Size = new System.Drawing.Size(581, 297);
            this.panProdutos.TabIndex = 23;
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
            // dgListaClientes
            // 
            this.dgListaClientes.AllowUserToAddRows = false;
            this.dgListaClientes.AllowUserToDeleteRows = false;
            this.dgListaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgClienteColTel,
            this.dgClienteColNome,
            this.dgClienteColEndereco,
            this.dgClienteColCodigo});
            this.dgListaClientes.Location = new System.Drawing.Point(0, 32);
            this.dgListaClientes.Name = "dgListaClientes";
            this.dgListaClientes.ReadOnly = true;
            this.dgListaClientes.Size = new System.Drawing.Size(578, 265);
            this.dgListaClientes.TabIndex = 1;
            // 
            // dgClienteColTel
            // 
            this.dgClienteColTel.HeaderText = "Telefone";
            this.dgClienteColTel.Name = "dgClienteColTel";
            this.dgClienteColTel.ReadOnly = true;
            // 
            // dgClienteColNome
            // 
            this.dgClienteColNome.HeaderText = "Nome";
            this.dgClienteColNome.Name = "dgClienteColNome";
            this.dgClienteColNome.ReadOnly = true;
            // 
            // dgClienteColEndereco
            // 
            this.dgClienteColEndereco.HeaderText = "Endereço";
            this.dgClienteColEndereco.Name = "dgClienteColEndereco";
            this.dgClienteColEndereco.ReadOnly = true;
            // 
            // dgClienteColCodigo
            // 
            this.dgClienteColCodigo.HeaderText = "Código";
            this.dgClienteColCodigo.Name = "dgClienteColCodigo";
            this.dgClienteColCodigo.ReadOnly = true;
            this.dgClienteColCodigo.Visible = false;
            // 
            // txtPesquisaNomes
            // 
            this.txtPesquisaNomes.Location = new System.Drawing.Point(117, 6);
            this.txtPesquisaNomes.Name = "txtPesquisaNomes";
            this.txtPesquisaNomes.Size = new System.Drawing.Size(461, 20);
            this.txtPesquisaNomes.TabIndex = 11;
            this.txtPesquisaNomes.TextChanged += new System.EventHandler(this.txtPesquisaProdutos_TextChanged);
            // 
            // btnTelaProdCancela
            // 
            this.btnTelaProdCancela.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaProdCancela.Location = new System.Drawing.Point(164, 274);
            this.btnTelaProdCancela.Name = "btnTelaProdCancela";
            this.btnTelaProdCancela.Size = new System.Drawing.Size(100, 35);
            this.btnTelaProdCancela.TabIndex = 10;
            this.btnTelaProdCancela.Text = "Cancelar";
            this.btnTelaProdCancela.UseVisualStyleBackColor = true;
            this.btnTelaProdCancela.Click += new System.EventHandler(this.btnTelaProdCancela_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(137, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(145, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtEndCliente
            // 
            this.txtEndCliente.Location = new System.Drawing.Point(137, 72);
            this.txtEndCliente.Name = "txtEndCliente";
            this.txtEndCliente.Size = new System.Drawing.Size(145, 20);
            this.txtEndCliente.TabIndex = 2;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(44, 71);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(87, 18);
            this.lblEndereco.TabIndex = 18;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(47, 20);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(84, 18);
            this.lblTelefone.TabIndex = 16;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(74, 45);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 18);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome";
            // 
            // btnCadastraProduto
            // 
            this.btnCadastraProduto.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraProduto.Location = new System.Drawing.Point(30, 233);
            this.btnCadastraProduto.Name = "btnCadastraProduto";
            this.btnCadastraProduto.Size = new System.Drawing.Size(101, 35);
            this.btnCadastraProduto.TabIndex = 7;
            this.btnCadastraProduto.Text = "Cadastrar";
            this.btnCadastraProduto.UseVisualStyleBackColor = true;
            this.btnCadastraProduto.Click += new System.EventHandler(this.btnCadastraProduto_Click);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(137, 124);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(145, 20);
            this.txtBairro.TabIndex = 4;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(72, 123);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(59, 18);
            this.lblBairro.TabIndex = 26;
            this.lblBairro.Text = "Bairro";
            // 
            // txtObsCliente
            // 
            this.txtObsCliente.Location = new System.Drawing.Point(137, 176);
            this.txtObsCliente.Name = "txtObsCliente";
            this.txtObsCliente.Size = new System.Drawing.Size(145, 20);
            this.txtObsCliente.TabIndex = 6;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(14, 175);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(117, 18);
            this.lblObs.TabIndex = 28;
            this.lblObs.Text = "Observações";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Referência";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(137, 98);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(145, 20);
            this.txtComplemento.TabIndex = 3;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(4, 97);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(127, 18);
            this.lblComplemento.TabIndex = 39;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(137, 150);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(145, 20);
            this.txtReferencia.TabIndex = 5;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.Location = new System.Drawing.Point(32, 149);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(99, 18);
            this.lblReferencia.TabIndex = 41;
            this.lblReferencia.Text = "Referência";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(137, 21);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(145, 20);
            this.txtTelefone.TabIndex = 0;
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 322);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.lblReferencia);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txtObsCliente);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditarProd);
            this.Controls.Add(this.panProdutos);
            this.Controls.Add(this.btnTelaProdCancela);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEndCliente);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCadastraProduto);
            this.Name = "TelaCliente";
            this.ShowInTaskbar = false;
            this.Text = "TelaCliente";
            this.Load += new System.EventHandler(this.TelaCliente_Load);
            this.panProdutos.ResumeLayout(false);
            this.panProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditarProd;
        private System.Windows.Forms.Panel panProdutos;
        private System.Windows.Forms.Label lblPesqProd;
        private System.Windows.Forms.DataGridView dgListaClientes;
        private System.Windows.Forms.TextBox txtPesquisaNomes;
        private System.Windows.Forms.Button btnTelaProdCancela;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndCliente;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCadastraProduto;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtObsCliente;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgClienteColTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgClienteColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgClienteColEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgClienteColCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.TextBox txtTelefone;
    }
}