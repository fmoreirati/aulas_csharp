namespace _04_Formularios;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(220, 250);
        this.Text = "Form1";

        // btnMensagem = new Button()
        // {
        //     Name = "btnMensagem",
        //     Text = "Mensagem de Texto",
        //     Location = new System.Drawing.Point(10, 10),
        // };

        // lblMensagem = new Label()
        // {
        //     Name = "lblMendagem",
        //     Text = "xxxxx",
        //     Location = new System.Drawing.Point(10, 40),
        //     Size = new System.Drawing.Size(100, 20),
        //     BorderStyle = BorderStyle.Fixed3D
        // };

        txtValores = new TextBox()
        {
            //Name = "",
            Text = "",
            Location = new System.Drawing.Point(10, 10),
            Size = new System.Drawing.Size(200, 20),
            BorderStyle = BorderStyle.Fixed3D,
            TextAlign = HorizontalAlignment.Right,
        };

        btnSoma = new Button()
        {
            //Name = "btnSoma",
            Text = "(+) Soma",
            Location = new System.Drawing.Point(100, 50),
            Size = new System.Drawing.Size(110, 25),
        };

        btnSubtracao = new Button()
        {
            //Name = "btnSoma",
            Text = "(-) Subtração",
            Location = new System.Drawing.Point(100, 80),
            Size = new System.Drawing.Size(110, 25),
        };

        btnDivisao = new Button()
        {
            //Name = "btnSoma",
            Text = "(/) Divisão",
            Location = new System.Drawing.Point(100, 110),
            Size = new System.Drawing.Size(110, 25),
        };

        btnMultiplicacao = new Button()
        {
            //Name = "btnSoma",
            Text = "(X) Multiplicação",
            Location = new System.Drawing.Point(100, 140),
            Size = new System.Drawing.Size(110, 25),
        };

        btnIgual = new Button()
        {
            //Name = "btnSoma",
            Text = "(=) Resultado",
            Location = new System.Drawing.Point(100, 170),
            Size = new System.Drawing.Size(110, 25),
        };

        //this.Controls.Add(btnMensagem);
        //this.Controls.Add(lblMensagem);
        this.Controls.Add(txtValores);
        this.Controls.Add(btnSoma);
        this.Controls.Add(btnSubtracao);
        this.Controls.Add(btnDivisao);
        this.Controls.Add(btnMultiplicacao);
        this.Controls.Add(btnIgual);

        var distH = 10;
        var distV = 50;
        var espaco = 30;

        for (var index = 0; index <= 11; index++)
        {
            var btnTecla = new Button()
            {
                Name = "btnTecla" + index,
                //Text = index.ToString(),
                Location = new System.Drawing.Point(distH, distV),
                Size = new System.Drawing.Size(25, 25),
            };

            btnTecla.Text = index == 10 ? "CE"
                : index == 11 ? "."
                : index.ToString();

            btnTeclas[index] = btnTecla;

            this.Controls.Add(btnTecla);

            if (index % 3 == 0)
            {
                distV += espaco;
                distH = 10;
            }
            else
            {
                distH += espaco;
            }
        }
    }

    private Button btnMensagem;
    private Label lblResultado;
    private Label lblMensagem;
    private Button btnLimpar;

    private TextBox txtValores;
    private Button btnSoma;
    private Button btnSubtracao;
    private Button btnDivisao;
    private Button btnMultiplicacao;
    private Button btnIgual;

    public Button[] btnTeclas = new Button[15];

    #endregion
}
