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
        cmdMonedas.DropDownStyle = ComboBoxStyle.DropDownList;

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
        tlResultados.Location = new Point(25, 25);


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
        if (txtMonto.Text != "" && cmdMonedas.Text != "")
        {
            Form2 opciones = new Form2(cmdMonedas.Text);
            if (opciones.ShowDialog() == DialogResult.OK)
            {
                tlResultados.Controls.Clear();
                foreach (String item in opciones.chkList.CheckedItems)
                {
                    Label etiqueta = new Label();
                    etiqueta.Text = item;
                    tlResultados.Controls.Add(etiqueta);

                    TextBox conversion = new TextBox();
                    if (calcularConversion(cmdMonedas.Text, item) >= 0)
                    {
                        switch (item)
                        {
                            case "MXN - Peso mexicano":
                                conversion.Text = "$ ";
                                break;
                            case "USD - Dólar estadounidense":
                                conversion.Text = "$ ";
                                break;
                            case "CAD - Dólar canadiense":
                                conversion.Text = "$ ";
                                break;
                            case "EUR - Euro":
                                conversion.Text = "€ ";
                                break;
                            case "JPY - Yen japonés":
                                conversion.Text = "¥ ";
                                break;
                        }
                        conversion.Text += calcularConversion(cmdMonedas.Text, item).ToString();
                    }
                    tlResultados.Controls.Add(conversion);

                }
            }
        }
    }
    private double calcularConversion(String moneda, String conv)
    {
        Double d = 0.0;
        if (moneda != "" && conv != null && txtMonto.Text != "" && Double.TryParse(txtMonto.Text, out d))
        {
            switch (moneda)
            {
                case "MXN - Peso mexicano":
                    {
                        switch (conv)
                        {
                            case "MXN - Peso mexicano": return Double.Parse(txtMonto.Text) * 1;
                            case "USD - Dólar estadounidense": return Double.Parse(txtMonto.Text) * .05;
                            case "CAD - Dólar canadiense": return Double.Parse(txtMonto.Text) * .06;
                            case "EUR - Euro": return Double.Parse(txtMonto.Text) * .04;
                            case "JPY - Yen japonés": return Double.Parse(txtMonto.Text) * 5.32;
                            default: return -1;
                        }
                    }
                case "USD - Dólar estadounidense":
                    {
                        switch (conv)
                        {
                            case "MXN - Peso mexicano": return Double.Parse(txtMonto.Text) * 21.23;
                            case "USD - Dólar estadounidense": return Double.Parse(txtMonto.Text) * 1;
                            case "CAD - Dólar canadiense": return Double.Parse(txtMonto.Text) * 1.28;
                            case "EUR - Euro": return Double.Parse(txtMonto.Text) * .89;
                            case "JPY - Yen japonés": return Double.Parse(txtMonto.Text) * 113.05;
                            default: return -1;
                        }
                    }
                case "CAD - Dólar canadiense":
                    {
                        switch (conv)
                        {
                            case "MXN - Peso mexicano": return Double.Parse(txtMonto.Text) * 16.55;
                            case "USD - Dólar estadounidense": return Double.Parse(txtMonto.Text) * .78;
                            case "CAD - Dólar canadiense": return Double.Parse(txtMonto.Text) * 1;
                            case "EUR - Euro": return Double.Parse(txtMonto.Text) * .69;
                            case "JPY - Yen japonés": return Double.Parse(txtMonto.Text) * 88.12;
                            default: return -1;
                        }
                    }
                case "EUR - Euro":
                    {
                        switch (conv)
                        {
                            case "MXN - Peso mexicano": return Double.Parse(txtMonto.Text) * 23.96;
                            case "USD - Dólar estadounidense": return Double.Parse(txtMonto.Text) * 1.13;
                            case "CAD - Dólar canadiense": return Double.Parse(txtMonto.Text) * 1.45;
                            case "EUR - Euro": return Double.Parse(txtMonto.Text) * 1;
                            case "JPY - Yen japonés": return Double.Parse(txtMonto.Text) * 127.56;
                            default: return -1;
                        }
                    }
                case "JPY - Yen japonés":
                    {
                        switch (conv)
                        {
                            case "MXN - Peso mexicano": return Double.Parse(txtMonto.Text) * .1878;
                            case "USD - Dólar estadounidense": return Double.Parse(txtMonto.Text) * .0088;
                            case "CAD - Dólar canadiense": return Double.Parse(txtMonto.Text) * .0113;
                            case "EUR - Euro": return Double.Parse(txtMonto.Text) * .0113;
                            case "JPY - Yen japonés": return Double.Parse(txtMonto.Text) * 1;
                            default: return -1;
                        }
                    }
                default: return -1;
            }
        }
        return -1;
    }
}
