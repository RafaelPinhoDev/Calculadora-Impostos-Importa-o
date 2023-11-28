using System;

public class Funcoes
{
    public bool VerificaCampoVazio()
    {
        if (string.IsNullOrWhiteSpace(TxtPrecoProduto.Text))

        {
            TxtPrecoProduto.Focus();
            return false;
        }
        else if (string.IsNullOrWhiteSpace(TxtFrete.Text))
        {

            TxtFrete.Text = "0";
            return false;
        }
        else
        {
            return true;
        }


    }

    public bool LimparCampos()
    {
        TxtFrete.Text = string.Empty;
        TxtPrecoProduto.Text = string.Empty;
        CmbEstado.SelectedIndex = 0;
        CmbRemessaConforme.SelectedIndex = 0;
        TxtSomaImpostos.Text = string.Empty;
        TxtValorAduaneiro.Text = string.Empty;
        TxtPrecoTotalProd.Text = string.Empty;
        return true;
    }
}
