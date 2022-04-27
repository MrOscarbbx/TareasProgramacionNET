namespace Examen2;

public partial class Form2 : Form
{
    public CheckedListBox chkList;
    Button btnAceptar;
    Button btnCanelar;

    public Form2()
    {
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

        chkList = new CheckedListBox();
        chkList.Size = new Size(250, 150);
        chkList.Items.Add("MXN - Peso mexicano");
        chkList.Items.Add("USD - Dólar estadounidense");
        chkList.Items.Add("CAD - Dólar canadiense");
        chkList.Items.Add("EUR - Euro");
        chkList.Items.Add("JPY - Yen japonés");
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
