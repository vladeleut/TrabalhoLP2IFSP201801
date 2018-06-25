namespace TrabalhoFinal
{
    partial class TelaPedido
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.cbTaxaDeEntrega = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPeditoTelCliente = new System.Windows.Forms.ComboBox();
            this.mtxtDDD = new System.Windows.Forms.MaskedTextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnFinalizaPedido = new System.Windows.Forms.Button();
            this.btnPedidoAdicionaPizza = new System.Windows.Forms.Button();
            this.btnPedidoAdicionaLanche = new System.Windows.Forms.Button();
            this.btnPedidoAdicionaBebida = new System.Windows.Forms.Button();
            this.btnPedidoAdicionaOutros = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancelaTelaPedido = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Logradouro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Complemento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Referência";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Observação";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblBairro);
            this.panel1.Controls.Add(this.cbTaxaDeEntrega);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbPeditoTelCliente);
            this.panel1.Controls.Add(this.mtxtDDD);
            this.panel1.Controls.Add(this.txtObservacao);
            this.panel1.Controls.Add(this.txtReferencia);
            this.panel1.Controls.Add(this.txtComplemento);
            this.panel1.Controls.Add(this.txtLogradouro);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(596, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 227);
            this.panel1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 19;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(67, 112);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(49, 15);
            this.lblBairro.TabIndex = 20;
            this.lblBairro.Text = "Bairro";
            // 
            // cbTaxaDeEntrega
            // 
            this.cbTaxaDeEntrega.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTaxaDeEntrega.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTaxaDeEntrega.FormattingEnabled = true;
            this.cbTaxaDeEntrega.Location = new System.Drawing.Point(122, 193);
            this.cbTaxaDeEntrega.Name = "cbTaxaDeEntrega";
            this.cbTaxaDeEntrega.Size = new System.Drawing.Size(145, 21);
            this.cbTaxaDeEntrega.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Taxa de Entrega";
            // 
            // cbPeditoTelCliente
            // 
            this.cbPeditoTelCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPeditoTelCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPeditoTelCliente.FormattingEnabled = true;
            this.cbPeditoTelCliente.Location = new System.Drawing.Point(153, 6);
            this.cbPeditoTelCliente.Name = "cbPeditoTelCliente";
            this.cbPeditoTelCliente.Size = new System.Drawing.Size(114, 21);
            this.cbPeditoTelCliente.TabIndex = 1;
            this.cbPeditoTelCliente.TextChanged += new System.EventHandler(this.cbPeditoTelCliente_TextChanged);
            this.cbPeditoTelCliente.Leave += new System.EventHandler(this.cbPeditoTelCliente_Leave);
            // 
            // mtxtDDD
            // 
            this.mtxtDDD.Location = new System.Drawing.Point(122, 7);
            this.mtxtDDD.Mask = "(00)";
            this.mtxtDDD.Name = "mtxtDDD";
            this.mtxtDDD.Size = new System.Drawing.Size(25, 20);
            this.mtxtDDD.TabIndex = 16;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(122, 167);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(145, 20);
            this.txtObservacao.TabIndex = 6;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(122, 138);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(145, 20);
            this.txtReferencia.TabIndex = 5;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(122, 85);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(145, 20);
            this.txtComplemento.TabIndex = 4;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(122, 59);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(145, 20);
            this.txtLogradouro.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(122, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(145, 20);
            this.txtNome.TabIndex = 2;
            // 
            // btnFinalizaPedido
            // 
            this.btnFinalizaPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFinalizaPedido.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizaPedido.Location = new System.Drawing.Point(643, 260);
            this.btnFinalizaPedido.Name = "btnFinalizaPedido";
            this.btnFinalizaPedido.Size = new System.Drawing.Size(218, 74);
            this.btnFinalizaPedido.TabIndex = 11;
            this.btnFinalizaPedido.Text = "Finalizar Pedido";
            this.btnFinalizaPedido.UseVisualStyleBackColor = false;
            this.btnFinalizaPedido.Click += new System.EventHandler(this.btnFinalizaPedido_Click);
            // 
            // btnPedidoAdicionaPizza
            // 
            this.btnPedidoAdicionaPizza.BackColor = System.Drawing.Color.Silver;
            this.btnPedidoAdicionaPizza.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoAdicionaPizza.Location = new System.Drawing.Point(350, 27);
            this.btnPedidoAdicionaPizza.Name = "btnPedidoAdicionaPizza";
            this.btnPedidoAdicionaPizza.Size = new System.Drawing.Size(218, 74);
            this.btnPedidoAdicionaPizza.TabIndex = 7;
            this.btnPedidoAdicionaPizza.Text = "Adicionar Pizza";
            this.btnPedidoAdicionaPizza.UseVisualStyleBackColor = false;
            this.btnPedidoAdicionaPizza.Click += new System.EventHandler(this.btnPedidoAdicionaPizza_Click);
            // 
            // btnPedidoAdicionaLanche
            // 
            this.btnPedidoAdicionaLanche.BackColor = System.Drawing.Color.Silver;
            this.btnPedidoAdicionaLanche.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoAdicionaLanche.Location = new System.Drawing.Point(350, 111);
            this.btnPedidoAdicionaLanche.Name = "btnPedidoAdicionaLanche";
            this.btnPedidoAdicionaLanche.Size = new System.Drawing.Size(218, 75);
            this.btnPedidoAdicionaLanche.TabIndex = 8;
            this.btnPedidoAdicionaLanche.Text = "Adicionar Lanche";
            this.btnPedidoAdicionaLanche.UseVisualStyleBackColor = false;
            this.btnPedidoAdicionaLanche.Click += new System.EventHandler(this.bttAdcLanche_Click);
            // 
            // btnPedidoAdicionaBebida
            // 
            this.btnPedidoAdicionaBebida.BackColor = System.Drawing.Color.Silver;
            this.btnPedidoAdicionaBebida.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoAdicionaBebida.Location = new System.Drawing.Point(350, 195);
            this.btnPedidoAdicionaBebida.Name = "btnPedidoAdicionaBebida";
            this.btnPedidoAdicionaBebida.Size = new System.Drawing.Size(218, 72);
            this.btnPedidoAdicionaBebida.TabIndex = 9;
            this.btnPedidoAdicionaBebida.Text = "Adicionar Bebida";
            this.btnPedidoAdicionaBebida.UseVisualStyleBackColor = false;
            this.btnPedidoAdicionaBebida.Click += new System.EventHandler(this.bttAdcBebida_Click);
            // 
            // btnPedidoAdicionaOutros
            // 
            this.btnPedidoAdicionaOutros.BackColor = System.Drawing.Color.Silver;
            this.btnPedidoAdicionaOutros.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoAdicionaOutros.Location = new System.Drawing.Point(350, 283);
            this.btnPedidoAdicionaOutros.Name = "btnPedidoAdicionaOutros";
            this.btnPedidoAdicionaOutros.Size = new System.Drawing.Size(218, 73);
            this.btnPedidoAdicionaOutros.TabIndex = 10;
            this.btnPedidoAdicionaOutros.Text = "Adicionar Outros";
            this.btnPedidoAdicionaOutros.UseVisualStyleBackColor = false;
            this.btnPedidoAdicionaOutros.Click += new System.EventHandler(this.bttAdcOutro_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 335);
            this.panel2.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "label10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(300, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCancelaTelaPedido
            // 
            this.btnCancelaTelaPedido.Location = new System.Drawing.Point(718, 340);
            this.btnCancelaTelaPedido.Name = "btnCancelaTelaPedido";
            this.btnCancelaTelaPedido.Size = new System.Drawing.Size(87, 29);
            this.btnCancelaTelaPedido.TabIndex = 10;
            this.btnCancelaTelaPedido.TabStop = false;
            this.btnCancelaTelaPedido.Text = "Cancelar";
            this.btnCancelaTelaPedido.UseVisualStyleBackColor = true;
            this.btnCancelaTelaPedido.Click += new System.EventHandler(this.btnCancelaTelaPedido_Click);
            // 
            // TelaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 418);
            this.Controls.Add(this.btnCancelaTelaPedido);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPedidoAdicionaOutros);
            this.Controls.Add(this.btnPedidoAdicionaBebida);
            this.Controls.Add(this.btnPedidoAdicionaLanche);
            this.Controls.Add(this.btnPedidoAdicionaPizza);
            this.Controls.Add(this.btnFinalizaPedido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "TelaPedido";
            this.Text = "TelaPedido";
            this.Load += new System.EventHandler(this.TelaPedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnFinalizaPedido;
        private System.Windows.Forms.Button btnPedidoAdicionaPizza;
        private System.Windows.Forms.Button btnPedidoAdicionaLanche;
        private System.Windows.Forms.Button btnPedidoAdicionaBebida;
        private System.Windows.Forms.Button btnPedidoAdicionaOutros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancelaTelaPedido;
        private System.Windows.Forms.MaskedTextBox mtxtDDD;
        private System.Windows.Forms.ComboBox cbPeditoTelCliente;
        private System.Windows.Forms.ComboBox cbTaxaDeEntrega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
    }
}