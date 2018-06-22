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
            this.components = new System.ComponentModel.Container();
            this.btnAddPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bebidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabalhofinalDataSet3 = new TrabalhoFinal.trabalhofinalDataSet3();
            this.btnCancelaPedido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bebidaTableAdapter = new TrabalhoFinal.trabalhofinalDataSet3TableAdapters.bebidaTableAdapter();
            this.dgPedidoTempBebida = new System.Windows.Forms.DataGridView();
            this.dgBebidas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bebidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhofinalDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidoTempBebida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).BeginInit();
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
            // bebidaBindingSource
            // 
            this.bebidaBindingSource.DataMember = "bebida";
            this.bebidaBindingSource.DataSource = this.trabalhofinalDataSet3;
            // 
            // trabalhofinalDataSet3
            // 
            this.trabalhofinalDataSet3.DataSetName = "trabalhofinalDataSet3";
            this.trabalhofinalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // bebidaTableAdapter
            // 
            this.bebidaTableAdapter.ClearBeforeFill = true;
            // 
            // dgPedidoTempBebida
            // 
            this.dgPedidoTempBebida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidoTempBebida.Location = new System.Drawing.Point(322, 40);
            this.dgPedidoTempBebida.Name = "dgPedidoTempBebida";
            this.dgPedidoTempBebida.Size = new System.Drawing.Size(265, 192);
            this.dgPedidoTempBebida.TabIndex = 23;
            // 
            // dgBebidas
            // 
            this.dgBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBebidas.Location = new System.Drawing.Point(17, 40);
            this.dgBebidas.Name = "dgBebidas";
            this.dgBebidas.Size = new System.Drawing.Size(265, 331);
            this.dgBebidas.TabIndex = 24;
            // 
            // TelaBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 383);
            this.Controls.Add(this.dgBebidas);
            this.Controls.Add(this.dgPedidoTempBebida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelaPedido);
            this.Controls.Add(this.btnAddPedido);
            this.Controls.Add(this.label1);
            this.Name = "TelaBebida";
            this.Text = "FormBebida";
            this.Load += new System.EventHandler(this.FormBebida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bebidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhofinalDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidoTempBebida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelaPedido;
        private System.Windows.Forms.Label label2;
        private trabalhofinalDataSet3 trabalhofinalDataSet3;
        private System.Windows.Forms.BindingSource bebidaBindingSource;
        private trabalhofinalDataSet3TableAdapters.bebidaTableAdapter bebidaTableAdapter;
        private System.Windows.Forms.DataGridView dgPedidoTempBebida;
        private System.Windows.Forms.DataGridView dgBebidas;
    }
}