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
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.txtPrecoProd = new System.Windows.Forms.TextBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastraProduto
            // 
            this.btnCadastraProduto.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraProduto.Location = new System.Drawing.Point(115, 233);
            this.btnCadastraProduto.Name = "btnCadastraProduto";
            this.btnCadastraProduto.Size = new System.Drawing.Size(101, 35);
            this.btnCadastraProduto.TabIndex = 0;
            this.btnCadastraProduto.Text = "Cadastrar";
            this.btnCadastraProduto.UseVisualStyleBackColor = true;
            this.btnCadastraProduto.Click += new System.EventHandler(this.btnCadastraProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 119);
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
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "pizza",
            "lanche",
            "bebida",
            "outros"});
            this.cbTipo.Location = new System.Drawing.Point(115, 34);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(145, 21);
            this.cbTipo.TabIndex = 5;
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.Location = new System.Drawing.Point(115, 159);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.Size = new System.Drawing.Size(70, 20);
            this.txtCodigoProd.TabIndex = 6;
            // 
            // txtPrecoProd
            // 
            this.txtPrecoProd.Location = new System.Drawing.Point(115, 117);
            this.txtPrecoProd.Name = "txtPrecoProd";
            this.txtPrecoProd.Size = new System.Drawing.Size(70, 20);
            this.txtPrecoProd.TabIndex = 7;
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(115, 78);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(145, 20);
            this.txtNomeProd.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(273, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 321);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.txtPrecoProd);
            this.Controls.Add(this.txtCodigoProd);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastraProduto);
            this.Name = "TelaCadastroProduto";
            this.Text = "TelaCadastroProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastraProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox txtCodigoProd;
        private System.Windows.Forms.TextBox txtPrecoProd;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.Button button2;
    }
}