namespace Calculadora_Impostos_Importacao
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.TxtPrecoProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFrete = new System.Windows.Forms.TextBox();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.CmbRemessaConforme = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPrecoTotalProd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtValorAduaneiro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtValorTaxa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtTaxaPorCem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtPrecoICMS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtICMS = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtSomaImpostos = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtSomaImpostosPorCem = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtPrecoProduto
            // 
            this.TxtPrecoProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecoProduto.Location = new System.Drawing.Point(23, 95);
            this.TxtPrecoProduto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtPrecoProduto.Name = "TxtPrecoProduto";
            this.TxtPrecoProduto.Size = new System.Drawing.Size(184, 22);
            this.TxtPrecoProduto.TabIndex = 0;
            this.TxtPrecoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecoProduto_KeyPress);
            this.TxtPrecoProduto.Leave += new System.EventHandler(this.TxtPrecoProduto_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preço do produto:";
            // 
            // TxtFrete
            // 
            this.TxtFrete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFrete.Location = new System.Drawing.Point(225, 95);
            this.TxtFrete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtFrete.Name = "TxtFrete";
            this.TxtFrete.Size = new System.Drawing.Size(209, 22);
            this.TxtFrete.TabIndex = 2;
            this.TxtFrete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFrete_KeyPress);
            this.TxtFrete.Leave += new System.EventHandler(this.TxtFrete_Leave);
            // 
            // CmbEstado
            // 
            this.CmbEstado.DropDownHeight = 80;
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.IntegralHeight = false;
            this.CmbEstado.Items.AddRange(new object[] {
            "",
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.CmbEstado.Location = new System.Drawing.Point(22, 151);
            this.CmbEstado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(184, 24);
            this.CmbEstado.TabIndex = 3;
            // 
            // CmbRemessaConforme
            // 
            this.CmbRemessaConforme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRemessaConforme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbRemessaConforme.FormattingEnabled = true;
            this.CmbRemessaConforme.Items.AddRange(new object[] {
            "",
            "Sim",
            "Não"});
            this.CmbRemessaConforme.Location = new System.Drawing.Point(224, 151);
            this.CmbRemessaConforme.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CmbRemessaConforme.Name = "CmbRemessaConforme";
            this.CmbRemessaConforme.Size = new System.Drawing.Size(209, 24);
            this.CmbRemessaConforme.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Está no Remessa Conforme?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor do frete:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 49);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 49);
            this.panel2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(62, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "CALCULADORA DE IMPOSTOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(70, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "CALCULADORA DE IMPOSTOS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 252);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 10);
            this.panel3.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(221, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Preço total do produto";
            // 
            // TxtPrecoTotalProd
            // 
            this.TxtPrecoTotalProd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecoTotalProd.Location = new System.Drawing.Point(224, 312);
            this.TxtPrecoTotalProd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtPrecoTotalProd.Name = "TxtPrecoTotalProd";
            this.TxtPrecoTotalProd.ReadOnly = true;
            this.TxtPrecoTotalProd.Size = new System.Drawing.Size(209, 22);
            this.TxtPrecoTotalProd.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 293);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Valor aduaneiro";
            // 
            // TxtValorAduaneiro
            // 
            this.TxtValorAduaneiro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorAduaneiro.Location = new System.Drawing.Point(22, 312);
            this.TxtValorAduaneiro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtValorAduaneiro.Name = "TxtValorAduaneiro";
            this.TxtValorAduaneiro.ReadOnly = true;
            this.TxtValorAduaneiro.Size = new System.Drawing.Size(184, 22);
            this.TxtValorAduaneiro.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(220, 342);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Valor da taxa";
            // 
            // TxtValorTaxa
            // 
            this.TxtValorTaxa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorTaxa.Location = new System.Drawing.Point(223, 361);
            this.TxtValorTaxa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtValorTaxa.Name = "TxtValorTaxa";
            this.TxtValorTaxa.ReadOnly = true;
            this.TxtValorTaxa.Size = new System.Drawing.Size(209, 22);
            this.TxtValorTaxa.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 342);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Taxa de importação";
            // 
            // TxtTaxaPorCem
            // 
            this.TxtTaxaPorCem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTaxaPorCem.Location = new System.Drawing.Point(22, 361);
            this.TxtTaxaPorCem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtTaxaPorCem.Name = "TxtTaxaPorCem";
            this.TxtTaxaPorCem.ReadOnly = true;
            this.TxtTaxaPorCem.Size = new System.Drawing.Size(184, 22);
            this.TxtTaxaPorCem.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(220, 389);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Preço ICMS";
            // 
            // TxtPrecoICMS
            // 
            this.TxtPrecoICMS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecoICMS.Location = new System.Drawing.Point(224, 408);
            this.TxtPrecoICMS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtPrecoICMS.Name = "TxtPrecoICMS";
            this.TxtPrecoICMS.ReadOnly = true;
            this.TxtPrecoICMS.Size = new System.Drawing.Size(209, 22);
            this.TxtPrecoICMS.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 389);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "ICMS";
            // 
            // TxtICMS
            // 
            this.TxtICMS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtICMS.Location = new System.Drawing.Point(22, 408);
            this.TxtICMS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtICMS.Name = "TxtICMS";
            this.TxtICMS.ReadOnly = true;
            this.TxtICMS.Size = new System.Drawing.Size(184, 22);
            this.TxtICMS.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(221, 440);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Valor total dos impostos:";
            // 
            // TxtSomaImpostos
            // 
            this.TxtSomaImpostos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSomaImpostos.Location = new System.Drawing.Point(224, 459);
            this.TxtSomaImpostos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtSomaImpostos.Name = "TxtSomaImpostos";
            this.TxtSomaImpostos.ReadOnly = true;
            this.TxtSomaImpostos.Size = new System.Drawing.Size(209, 22);
            this.TxtSomaImpostos.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 440);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Soma dos impostos:";
            // 
            // TxtSomaImpostosPorCem
            // 
            this.TxtSomaImpostosPorCem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSomaImpostosPorCem.Location = new System.Drawing.Point(22, 459);
            this.TxtSomaImpostosPorCem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtSomaImpostosPorCem.Name = "TxtSomaImpostosPorCem";
            this.TxtSomaImpostosPorCem.ReadOnly = true;
            this.TxtSomaImpostosPorCem.Size = new System.Drawing.Size(184, 22);
            this.TxtSomaImpostosPorCem.TabIndex = 22;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.Green;
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(111, 200);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(95, 34);
            this.BtnCalcular.TabIndex = 26;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Yellow;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(224, 200);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(95, 34);
            this.BtnLimpar.TabIndex = 27;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(-12, 255);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(469, 260);
            this.panel4.TabIndex = 10;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(455, 511);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtSomaImpostos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtSomaImpostosPorCem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtPrecoICMS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtICMS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtValorTaxa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtTaxaPorCem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtPrecoTotalProd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtValorAduaneiro);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbRemessaConforme);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.TxtFrete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPrecoProduto);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPrecoProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFrete;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.ComboBox CmbRemessaConforme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPrecoTotalProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtValorAduaneiro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtValorTaxa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtTaxaPorCem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtPrecoICMS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtICMS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtSomaImpostos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtSomaImpostosPorCem;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Panel panel4;
    }
}

