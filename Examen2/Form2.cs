namespace Examen2;

public partial class Form2 : Form
{
    public CheckedListBox chkList;
    Button btnAceptar;
    Button btnCanelar;
    String Moneda;

    public Form2(string moneda)
    {
        Moneda = moneda;
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        this.Size = new Size(300, 250);
        this.Text = "Monedas";
        this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.MaximizeBox = false;
        this.StartPosition = FormStartPosition.CenterScreen;

        List<string> lista = new List<string>();

        lista.Add("MXN - Peso mexicano");
        lista.Add("USD - Dólar estadounidense");
        lista.Add("CAD - Dólar canadiense");
        lista.Add("EUR - Euro");
        lista.Add("JPY - Yen japonés");


        chkList = new CheckedListBox();
        chkList.Size = new Size(250, 150);
        foreach (var item in lista)
        {
            if (item != Moneda)
            {
                chkList.Items.Add(item);
            }
        }
        chkList.Location = new Point(15, 15);

        btnAceptar = new Button();
        btnAceptar.Text = "Aceptar";
        btnAceptar.Location = new Point(191, 170);
        btnAceptar.Click += new EventHandler(btnAceptar_Click);

        btnCanelar = new Button();
        btnCanelar.Text = "Cancelar";
        btnCanelar.Location = new Point(15, 170);
        btnCanelar.Click += new EventHandler(btnCancelar_Click);


        this.Controls.Add(chkList);
        this.Controls.Add(btnAceptar);
        this.Controls.Add(btnCanelar);

    }

    private void btnCancelar_Click(object? sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void btnAceptar_Click(object? sender, EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
        this.Close();
    }
}
