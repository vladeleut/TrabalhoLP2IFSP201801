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
            this.cbTelCliente = new System.Windows.Forms.ComboBox();
            this.btnEditarProd = new System.Windows.Forms.Button();
            this.panProdutos = new System.Windows.Forms.Panel();
            this.lblPesqProd = new System.Windows.Forms.Label();
            this.dgListaClientes = new System.Windows.Forms.DataGridView();
            this.dgClienteColTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgClienteColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgClienteColEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgClienteColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisaProdutos = new System.Windows.Forms.TextBox();
            this.btnTelaProdCancela = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtEndCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastraProduto = new System.Windows.Forms.Button();
            this.txtBairroCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObsCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(163, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbTelCliente
            // 
            this.cbTelCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTelCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTelCliente.FormattingEnabled = true;
            this.cbTelCliente.Location = new System.Drawing.Point(120, 45);
            this.cbTelCliente.Name = "cbTelCliente";
            this.cbTelCliente.Size = new System.Drawing.Size(145, 21);
            this.cbTelCliente.TabIndex = 0;
            this.cbTelCliente.SelectionChangeCommitted += new System.EventHandler(this.cbTelCliente_SelectionChangeCommitted);
            // 
            // btnEditarProd
            // 
            this.btnEditarProd.Enabled = false;
            this.btnEditarProd.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProd.Location = new System.Drawing.Point(30, 274);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.Size = new System.Drawing.Size(101, 35);
            this.btnEditarProd.TabIndex = 22;
            this.btnEditarProd.Text = "Excluir";
            this.btnEditarProd.UseVisualStyleBackColor = true;
            // 
            // panProdutos
            // 
            this.panProdutos.Controls.Add(this.lblPesqProd);
            this.panProdutos.Controls.Add(this.dgListaClientes);
            this.panProdutos.Controls.Add(this.txtPesquisaProdutos);
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
            // txtPesquisaProdutos
            // 
            this.txtPesquisaProdutos.Location = new System.Drawing.Point(117, 6);
            this.txtPesquisaProdutos.Name = "txtPesquisaProdutos";
            this.txtPesquisaProdutos.Size = new System.Drawing.Size(461, 20);
            this.txtPesquisaProdutos.TabIndex = 20;
            // 
            // btnTelaProdCancela
            // 
            this.btnTelaProdCancela.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaProdCancela.Location = new System.Drawing.Point(164, 274);
            this.btnTelaProdCancela.Name = "btnTelaProdCancela";
            this.btnTelaProdCancela.Size = new System.Drawing.Size(100, 35);
            this.btnTelaProdCancela.TabIndex = 21;
            this.btnTelaProdCancela.Text = "Cancelar";
            this.btnTelaProdCancela.UseVisualStyleBackColor = true;
            this.btnTelaProdCancela.Click += new System.EventHandler(this.btnTelaProdCancela_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(120, 73);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(145, 20);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // txtEndCliente
            // 
            this.txtEndCliente.Location = new System.Drawing.Point(120, 99);
            this.txtEndCliente.Name = "txtEndCliente";
            this.txtEndCliente.Size = new System.Drawing.Size(145, 20);
            this.txtEndCliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome";
            // 
            // btnCadastraProduto
            // 
            this.btnCadastraProduto.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraProduto.Location = new System.Drawing.Point(30, 209);
            this.btnCadastraProduto.Name = "btnCadastraProduto";
            this.btnCadastraProduto.Size = new System.Drawing.Size(101, 35);
            this.btnCadastraProduto.TabIndex = 5;
            this.btnCadastraProduto.Text = "Cadastrar";
            this.btnCadastraProduto.UseVisualStyleBackColor = true;
            this.btnCadastraProduto.Click += new System.EventHandler(this.btnCadastraProduto_Click);
            // 
            // txtBairroCliente
            // 
            this.txtBairroCliente.Location = new System.Drawing.Point(120, 125);
            this.txtBairroCliente.Name = "txtBairroCliente";
            this.txtBairroCliente.Size = new System.Drawing.Size(145, 20);
            this.txtBairroCliente.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Bairro";
            // 
            // txtObsCliente
            // 
            this.txtObsCliente.Location = new System.Drawing.Point(120, 151);
            this.txtObsCliente.Name = "txtObsCliente";
            this.txtObsCliente.Size = new System.Drawing.Size(145, 20);
            this.txtObsCliente.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-3, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Observações";
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 322);
            this.Controls.Add(this.txtObsCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBairroCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbTelCliente);
            this.Controls.Add(this.btnEditarProd);
            this.Controls.Add(this.panProdutos);
            this.Controls.Add(this.btnTelaProdCancela);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtEndCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.ComboBox cbTelCliente;
        private System.Windows.Forms.Button btnEditarProd;
        private System.Windows.Forms.Panel panProdutos;
        private System.Windows.Forms.Label lblPesqProd;
        private System.Windows.Forms.DataGridView dgListaClientes;
        private System.Windows.Forms.TextBox txtPesquisaProdutos;
        private System.Windows.Forms.Button btnTelaProdCancela;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtEndCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastraProduto;
        private System.Windows.Forms.TextBox txtBairroCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObsCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgClienteColTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgClienteColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgClienteColEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgClienteColCodigo;
    }
}