using System.Data;
namespace _04_Formularios;

public partial class Form1 : Form
{
    private string valorAtual = "0";
    private bool limparValor = false;

    public Form1()
    {
        InitializeComponent();

        btnTeclas[0].Click += btntecla0_Click;
        btnTeclas[1].Click += btntecla1_Click;
        btnTeclas[2].Click += btntecla2_Click;
        btnTeclas[3].Click += btntecla3_Click;
        btnTeclas[4].Click += btntecla4_Click;
        btnTeclas[5].Click += btntecla5_Click;
        btnTeclas[6].Click += btntecla6_Click;
        btnTeclas[7].Click += btntecla7_Click;
        btnTeclas[8].Click += btntecla8_Click;
        btnTeclas[9].Click += btntecla9_Click;
        btnTeclas[10].Click += btntecla10_Click;
        btnTeclas[11].Click += btntecla11_Click;
        btnSoma.Click += btnSoma_Click;
        btnSubtracao.Click += btnSubtracao_Click;
        btnMultiplicacao.Click += btnMultiplicacao_Click;
        btnDivisao.Click += btnDivisao_Click;
        btnIgual.Click += btnIgual_Click;
    }

    private void btntecla0_Click(object sender, EventArgs e)
    {
        txtValores.Text += "0";
    }

    private void btntecla1_Click(object sender, EventArgs e)
    {
        txtValores.Text += "1";
    }

    private void btntecla2_Click(object sender, EventArgs e)
    {
        txtValores.Text += "2";
    }

    private void btntecla3_Click(object sender, EventArgs e)
    {
        txtValores.Text += "3";
    }

    private void btntecla4_Click(object sender, EventArgs e)
    {
        txtValores.Text += "4";
    }

    private void btntecla5_Click(object sender, EventArgs e)
    {
        txtValores.Text += "5";
    }

    private void btntecla6_Click(object sender, EventArgs e)
    {
        txtValores.Text += "6";
    }

    private void btntecla7_Click(object sender, EventArgs e)
    {
        txtValores.Text += "7";
    }

    private void btntecla8_Click(object sender, EventArgs e)
    {
        txtValores.Text += "8";
    }

    private void btntecla9_Click(object sender, EventArgs e)
    {
        txtValores.Text += "9";
    }
    private void btntecla10_Click(object sender, EventArgs e)
    {
        txtValores.Text = "";
        valorAtual = "0";
    }

    private void btntecla11_Click(object sender, EventArgs e)
    {
        if (!txtValores.Text.Contains(".") && !txtValores.Text.Contains(","))
        {
            txtValores.Text += ".";
        }
    }

    private void btnSoma_Click(object sender, EventArgs e)
    {
        txtValores.Text += "+";
    }

    private void btnSubtracao_Click(object sender, EventArgs e)
    {
        txtValores.Text += "-";
    }

    private void btnMultiplicacao_Click(object sender, EventArgs e)
    {
        txtValores.Text += "*";
    }

    private void btnDivisao_Click(object sender, EventArgs e)
    {
        txtValores.Text += "/";
    }

    private void btnIgual_Click(object sender, EventArgs e)
    {
        var valortxt = txtValores.Text;
        var expCalculo = valortxt.Replace(",", ".");
        var x = new DataTable();

        var valores = x.Compute(expCalculo, "");
        txtValores.Text = valores.ToString();
    }
}
