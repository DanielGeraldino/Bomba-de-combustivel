namespace Bomba_combustivel
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textoQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoPreco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textoTipo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAbasteceQuantidade = new System.Windows.Forms.Button();
            this.btnAbasteceValor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textoEntrada = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEntradaCombustivel = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textoEntradaCombustivel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textoAlterarPreco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textoAlterarTipo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textoQuantidade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textoPreco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textoTipo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // textoQuantidade
            // 
            this.textoQuantidade.Location = new System.Drawing.Point(99, 74);
            this.textoQuantidade.Name = "textoQuantidade";
            this.textoQuantidade.Size = new System.Drawing.Size(130, 20);
            this.textoQuantidade.TabIndex = 4;
            this.textoQuantidade.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preço/litro";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textoPreco
            // 
            this.textoPreco.Location = new System.Drawing.Point(99, 48);
            this.textoPreco.Name = "textoPreco";
            this.textoPreco.Size = new System.Drawing.Size(130, 20);
            this.textoPreco.TabIndex = 2;
            this.textoPreco.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Combustivel";
            // 
            // textoTipo
            // 
            this.textoTipo.Location = new System.Drawing.Point(99, 19);
            this.textoTipo.Name = "textoTipo";
            this.textoTipo.Size = new System.Drawing.Size(130, 20);
            this.textoTipo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAbasteceQuantidade);
            this.groupBox2.Controls.Add(this.btnAbasteceValor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textoEntrada);
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abastece";
            // 
            // btnAbasteceQuantidade
            // 
            this.btnAbasteceQuantidade.Location = new System.Drawing.Point(118, 50);
            this.btnAbasteceQuantidade.Name = "btnAbasteceQuantidade";
            this.btnAbasteceQuantidade.Size = new System.Drawing.Size(111, 23);
            this.btnAbasteceQuantidade.TabIndex = 9;
            this.btnAbasteceQuantidade.Text = "Quantidade";
            this.btnAbasteceQuantidade.UseVisualStyleBackColor = true;
            this.btnAbasteceQuantidade.Click += new System.EventHandler(this.BtnAbasteceQuantidade_Click);
            // 
            // btnAbasteceValor
            // 
            this.btnAbasteceValor.Location = new System.Drawing.Point(6, 50);
            this.btnAbasteceValor.Name = "btnAbasteceValor";
            this.btnAbasteceValor.Size = new System.Drawing.Size(106, 23);
            this.btnAbasteceValor.TabIndex = 8;
            this.btnAbasteceValor.Text = "Valor";
            this.btnAbasteceValor.UseVisualStyleBackColor = true;
            this.btnAbasteceValor.Click += new System.EventHandler(this.BtnAbasteceValor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Entrada";
            // 
            // textoEntrada
            // 
            this.textoEntrada.Location = new System.Drawing.Point(99, 19);
            this.textoEntrada.Name = "textoEntrada";
            this.textoEntrada.Size = new System.Drawing.Size(130, 20);
            this.textoEntrada.TabIndex = 6;
            this.textoEntrada.TextChanged += new System.EventHandler(this.TextoEntrada_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEntradaCombustivel);
            this.groupBox3.Controls.Add(this.btnSalvar);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textoEntradaCombustivel);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textoAlterarPreco);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textoAlterarTipo);
            this.groupBox3.Location = new System.Drawing.Point(12, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 126);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuração/Alterar";
            // 
            // btnEntradaCombustivel
            // 
            this.btnEntradaCombustivel.Location = new System.Drawing.Point(0, 97);
            this.btnEntradaCombustivel.Name = "btnEntradaCombustivel";
            this.btnEntradaCombustivel.Size = new System.Drawing.Size(112, 23);
            this.btnEntradaCombustivel.TabIndex = 12;
            this.btnEntradaCombustivel.Text = "Entrada";
            this.btnEntradaCombustivel.UseVisualStyleBackColor = true;
            this.btnEntradaCombustivel.Click += new System.EventHandler(this.BtnEntradaCombustivel_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(118, 97);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(111, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quantidade";
            // 
            // textoEntradaCombustivel
            // 
            this.textoEntradaCombustivel.Location = new System.Drawing.Point(99, 71);
            this.textoEntradaCombustivel.Name = "textoEntradaCombustivel";
            this.textoEntradaCombustivel.Size = new System.Drawing.Size(130, 20);
            this.textoEntradaCombustivel.TabIndex = 10;
            this.textoEntradaCombustivel.TextChanged += new System.EventHandler(this.TextoEntradaCombustivel_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Preco";
            // 
            // textoAlterarPreco
            // 
            this.textoAlterarPreco.Location = new System.Drawing.Point(99, 45);
            this.textoAlterarPreco.Name = "textoAlterarPreco";
            this.textoAlterarPreco.Size = new System.Drawing.Size(130, 20);
            this.textoAlterarPreco.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Combustivel";
            // 
            // textoAlterarTipo
            // 
            this.textoAlterarTipo.Location = new System.Drawing.Point(99, 19);
            this.textoAlterarTipo.Name = "textoAlterarTipo";
            this.textoAlterarTipo.Size = new System.Drawing.Size(130, 20);
            this.textoAlterarTipo.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 348);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoTipo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAbasteceQuantidade;
        private System.Windows.Forms.Button btnAbasteceValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textoEntrada;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textoEntradaCombustivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textoAlterarPreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textoAlterarTipo;
        private System.Windows.Forms.Button btnEntradaCombustivel;
    }
}

