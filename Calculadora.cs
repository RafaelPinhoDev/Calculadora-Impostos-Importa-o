
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Impostos_Importacao
{
    public partial class Calculadora : Form
    {
        double PrecoProduto, Frete, Aduaneiro,
        PorcentagemImportacao, PrecoTotal, ValorImportacao, 
        ValorICMS, ICMSPorcentagem, TotalPorcem, TotalImposto;
        string Estado;
        public Calculadora()
        {
            InitializeComponent();
        }





        public bool VerificaCampoVazio()
        {
            if (string.IsNullOrWhiteSpace(TxtPrecoProduto.Text))

            {
                TxtPrecoProduto.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(TxtFrete.Text))
            {
                Task.Delay(1000);
                TxtFrete.Text = "0";
                return false;
            }
            else if (string.IsNullOrEmpty(CmbEstado.Text))
            {
                CmbEstado.Focus();
                return false;

            }
            else if (string.IsNullOrEmpty(CmbRemessaConforme.Text))
            {
                CmbRemessaConforme.Focus();
                return false;

            }
            else
            {
                return true;
            }


        }
            private void TxtPrecoProduto_Leave(object sender, EventArgs e)
            {
            if (!string.IsNullOrWhiteSpace(TxtPrecoProduto.Text))
            {
                var preco = Convert.ToDecimal(TxtPrecoProduto.Text);

                if (preco % 10 == 9)
                {
                   
                    Math.Round(preco);
                }


                TxtPrecoProduto.Text = preco.ToString("N2");
            }

        }

            private void TxtFrete_Leave(object sender, EventArgs e)
            {
            if (!string.IsNullOrWhiteSpace(TxtFrete.Text))
            {
                var frete = Convert.ToDecimal(TxtFrete.Text);

                if (frete % 10 == 9)
                {

                    Math.Round(frete);
                }


                TxtFrete.Text = frete.ToString("N2");
            }



        }

        public bool LimparCampos()
        {
            TxtFrete.Text = string.Empty;
            TxtPrecoProduto.Text = string.Empty;
            CmbEstado.SelectedIndex = 0;
            CmbRemessaConforme.SelectedIndex = 0;
            TxtSomaImpostosPorCem.Text = string.Empty;
            TxtValorAduaneiro.Text = string.Empty;
            TxtPrecoTotalProd.Text = string.Empty;
            TxtICMS.Text = string.Empty;
            TxtPrecoICMS.Text = string.Empty;
            TxtTaxaPorCem.Text = string.Empty;
            TxtValorTaxa.Text = string.Empty;
            TxtTaxaPorCem.Text = string.Empty;
            TxtValorTaxa.Text = string.Empty;
            TxtSomaImpostos.Text = string.Empty;
            return true;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (VerificaCampoVazio() == true)
            {
                PrecoProduto = double.Parse(TxtPrecoProduto.Text);
                Frete = double.Parse(TxtFrete.Text);
                Estado = CmbEstado.Text;
                Aduaneiro = PrecoProduto + Frete;

                if ((Aduaneiro >= 250) || (CmbRemessaConforme.SelectedIndex == 2))
                {
                    PrecoTotal = (Aduaneiro + (Aduaneiro * 0.60));
                    PorcentagemImportacao = 60;
                    ValorImportacao = Aduaneiro * 0.60;
                }
                else
                {
                    PorcentagemImportacao = 0;
                    ValorImportacao = 0;
                }

                if (Estado == "Acre (AC)" || Estado == "Alagoas (AL)" || Estado == "Bahia (BA)" || Estado == "Paraná (PR)")
                {
                    // Código a ser executado para estados com 19%
                    PrecoTotal = Aduaneiro + (Aduaneiro * 0.19);
                    ICMSPorcentagem = 19;
                    ValorICMS = Aduaneiro * 0.19;
                }
                else if (Estado == "Amapá (AP)" || Estado == "Ceará (CE)" || Estado == "Distrito Federal (DF)" || Estado == "Minas Gerais (MG)" || Estado == "Paraíba (PB)" || Estado == "Pernambuco (PE)" || Estado == "Rio de Janeiro (RJ)" || Estado == "São Paulo (SP)")
                {

                    // Código a ser executado para estados com 18%
                    PrecoTotal = Aduaneiro + (Aduaneiro * 0.18);
                    ICMSPorcentagem = 18;
                    ValorICMS = Aduaneiro * 0.18;
                }
                else if (Estado == "Mato Grosso (MT)" || Estado == "Mato Grosso do Sul (MS)" || Estado == "Rio Grande do Sul (RS)" || Estado == "Santa Catarina (SC)")
                {
                    // Código a ser executado para estados com 17%
                    PrecoTotal = Aduaneiro + (Aduaneiro * 0.17);
                    ICMSPorcentagem = 17;
                    ValorICMS = Aduaneiro * 0.17;
                }
                else if (Estado == "Rondônia (RO)")
                {
                    // Código a ser executado para Rondônia com 17,5%
                    PrecoTotal = Aduaneiro + (Aduaneiro * 0.175);
                    ICMSPorcentagem = 17.5;
                    ValorICMS = Aduaneiro * 0.175;
                }
                else if (Estado == "Maranhão (MA)" || Estado == "Rio Grande do Norte (RN)" || Estado == "Tocantins (TO)" || Estado == "Amazonas (AM)" || Estado == "Roraima (RR)")
                {
                    // Código a ser executado para estados com 20%
                    PrecoTotal = Aduaneiro + (Aduaneiro * 0.20);
                    ICMSPorcentagem = 20;
                    ValorICMS = Aduaneiro * 0.20;
                }
                else if (Estado == "Piauí (PI)")
                {
                    // Código a ser executado para Piauí com 21%
                    PrecoTotal = Aduaneiro + (Aduaneiro * 0.21);
                    ICMSPorcentagem = 21;
                    ValorICMS = Aduaneiro * 0.21;
                }
                else
                {
                    // Código a ser executado para Sergipe com 22%
                    PrecoTotal = Aduaneiro + (Aduaneiro * 0.22);
                    ICMSPorcentagem = 22;
                    ValorICMS = Aduaneiro * 0.22;
                }

                TotalPorcem = ICMSPorcentagem + PorcentagemImportacao;
                TotalImposto = ValorICMS + ValorImportacao;
                PrecoTotal = TotalImposto + Aduaneiro;

                // Preços

                TxtPrecoTotalProd.Text = PrecoTotal.ToString("C");
                TxtValorAduaneiro.Text = Aduaneiro.ToString("C");
                TxtSomaImpostos.Text = TotalImposto.ToString("C");
                TxtValorTaxa.Text = ValorImportacao.ToString("C");
                TxtPrecoICMS.Text = ValorICMS.ToString("C");

                // Porcentagem

                TxtSomaImpostosPorCem.Text = TotalPorcem.ToString("F") +  "%";
                TxtTaxaPorCem.Text = PorcentagemImportacao.ToString("F") + "%";
                TxtICMS.Text = ICMSPorcentagem.ToString("F") + "%";








            }
            else
            {
                MessageBox.Show("Verifique os campos vazios!!", "AVISO");
            }
            

        }


        private void TxtPrecoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.SomenteNumero(sender, e);
        }

        private void TxtFrete_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.SomenteNumero(sender, e);
        }



        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

       
    }
}
