namespace Examen2;

public partial class Form1 : Form
{
    Label? lblMonedas;
    ComboBox? cmdMonedas;
    Label? lblMonto;
    TextBox? txtMonto;
    Button btnCalcular;
    Label? lblConversiones;
    Panel pnlResultados;
    TableLayoutPanel tlResultados;


    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        this.Size = new Size(350, 400);
        this.Text = "Coversor";
        this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.MaximizeBox = false;
        this.StartPosition = FormStartPosition.CenterScreen;

        //Etiqueta Monedas
        lblMonedas = new Label();
        lblMonedas.Text = "Monedas";
        lblMonedas.AutoSize = true;
        lblMonedas.Location = new Point(15, 10);

        //ComboBox Monedas
        cmdMonedas = new ComboBox();
        cmdMonedas.Size = new Size(180, 20);
        cmdMonedas.Items.Add("MXN - Peso mexicano");
        cmdMonedas.Items.Add("USD - Dólar estadounidense");
        cmdMonedas.Items.Add("CAD - Dólar canadiense");
        cmdMonedas.Items.Add("EUR - Euro");
        cmdMonedas.Items.Add("JPY - Yen japonés");
        cmdMonedas.Location = new Point(15, 30);

        //Etiqueta Monto
        lblMonto = new Label();
        lblMonto.Text = "Monto";
        lblMonto.AutoSize = true;
        lblMonto.Location = new Point(200, 10);

        //TextBox Monto
        txtMonto = new TextBox();
        txtMonto.Size = new Size(100, 20);
        txtMonto.Location = new Point(200, 30);

        //Boton Conversiones
        btnCalcular = new Button();
        btnCalcular.Text = "Calcular";
        btnCalcular.Location = new Point(200, 60);
        btnCalcular.Click += new EventHandler(btnCalcular_Conversion);

        //Etiqueta Conversiones
        lblConversiones = new Label();
        lblConversiones.Text = "Conversiones";
        lblConversiones.AutoSize = true;
        lblConversiones.Location = new Point(0, 0);

        //Panel Resultados
        pnlResultados = new Panel();
        pnlResultados.Location = new Point(10, 90);
        pnlResultados.Size = new Size(315, 260);
        pnlResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        //LayOut Resultados
        tlResultados = new TableLayoutPanel();
        tlResultados.ColumnCount = 2;
        tlResultados.RowCount = 6;
        tlResultados.AutoSize = true;
        tlResultados.Location = new Point(15, 15);


        this.Controls.Add(lblMonedas);
        this.Controls.Add(cmdMonedas);
        this.Controls.Add(lblMonto);
        this.Controls.Add(txtMonto);
        this.Controls.Add(btnCalcular);
        this.Controls.Add(pnlResultados);
        pnlResultados.Controls.Add(lblConversiones);
        pnlResultados.Controls.Add(tlResultados);
    }

    private void btnCalcular_Conversion(object? sender, EventArgs e)
    {
        Form2 opciones = new Form2();
    }
}
