using System.Text.RegularExpressions;
using System;
using System.Drawing;
namespace Tarea3;

public partial class Form1 : Form
{
    //ComboBox de Figuras y Calculos
    Label? lblFigura;
    ComboBox? cmbFiguras;
    Label? lblCalculo;
    ComboBox? cmbCalculo;

    //Lados Necesarios Para los calculos
    Label? lblLado1;
    TextBox? txtLado1;

    Label? lblLado2;
    TextBox? txtLado2;

    Label? lblLado3;
    TextBox? txtLado3;

    Label? lblLado4;
    TextBox? txtLado4;


    //Botones y resultados
    Button? btnCalcular;
    Label? lblResultado;
    TextBox? txtResultado;

    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
    }
    
    private void InicializarComponentes()
    {
        this.Size = new Size(300,350);

        //Etiqueta "Figura"
        lblFigura = new Label();
        lblFigura.Text = "Figura";
        lblFigura.AutoSize = true;
        lblFigura.Location = new Point(10, 10);

        //Combobox Figuras
        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Cuadrado");
        cmbFiguras.Items.Add("Rectangulo");
        cmbFiguras.Items.Add("Paralelogramo");
        cmbFiguras.Items.Add("Rombo");
        cmbFiguras.Items.Add("Cometa");
        cmbFiguras.Items.Add("Trapecio");
        cmbFiguras.Items.Add("Circulo");
        cmbFiguras.Items.Add("Triangulo");
        cmbFiguras.Location = new Point(10, 40);
        cmbFiguras.SelectedValueChanged += new EventHandler(cmbFiguras_ValueChanged);

        //Etiqueta "Cálculo"
        lblCalculo = new Label();
        lblCalculo.Text = "Cálculo";
        lblCalculo.AutoSize = true;
        lblCalculo.Location = new Point(150, 10);

        //Combobox Cálculos
        cmbCalculo = new ComboBox();
        cmbCalculo.Items.Add("Périmetro");
        cmbCalculo.Items.Add("Área");
        cmbCalculo.Location = new Point(150, 40);
        cmbCalculo.SelectedValueChanged += new EventHandler(cmbCalculo_ValueChanged);

//=========================================================================================

        //Etiqueta "Lado 1"
        lblLado1 = new Label();
        lblLado1.AutoSize = true;
        lblLado1.Location = new Point(10, 80);
        lblLado1.Visible=false;

        //TextBox Lado1
        txtLado1 = new TextBox();
        txtLado1.Size = new Size(100, 20);
        txtLado1.Location = new Point(60, 75);
        txtLado1.Visible=false;

        //Etiqueta "Lado 2"
        lblLado2 = new Label();
        lblLado2.AutoSize = true;
        lblLado2.Location = new Point(10, 120);
        lblLado2.Visible=false;

        //TextBox Lado2
        txtLado2 = new TextBox();
        txtLado2.Size = new Size(100, 20);
        txtLado2.Location = new Point(60, 115);
        txtLado2.Visible=false;

        //Etiqueta "Lado3"
        lblLado3 = new Label();
        lblLado3.AutoSize = true;
        lblLado3.Location = new Point(10, 160);
        lblLado3.Visible=false;

        //TextBox Lado3
        txtLado3 = new TextBox();
        txtLado3.Size = new Size(100, 20);
        txtLado3.Location = new Point(60, 155);
        txtLado3.Visible=false;

        //Etiqueta "Lado4"
        lblLado4 = new Label();
        lblLado4.AutoSize = true;
        lblLado4.Location = new Point(10, 200);
        lblLado4.Visible=false;

        //TextBox Lado4
        txtLado4 = new TextBox();
        txtLado4.Size = new Size(100, 20);
        txtLado4.Location = new Point(60, 195);
        txtLado4.Visible=false;


//===================================================================
        //Boton Calcular
        btnCalcular = new Button();
        btnCalcular.Text = "Calcular";
        btnCalcular.AutoSize = true;
        btnCalcular.Location = new Point(170, 200);
        btnCalcular.Click+= new EventHandler(btnCalcular_Click);

        //Etiqueta "Resultado"
        lblResultado = new Label();
        lblResultado.Text = "Resultado";
        lblResultado.AutoSize = true;
        lblResultado.Location = new Point(10, 280);

        //TextBox Resultado
        txtResultado = new TextBox();
        txtResultado.Size = new Size(100, 20);
        txtResultado.Location = new Point(70, 275);

        this.Controls.Add(lblFigura);
        this.Controls.Add(cmbFiguras);
        this.Controls.Add(lblCalculo);
        this.Controls.Add(cmbCalculo);

        this.Controls.Add(lblLado1);
        this.Controls.Add(txtLado1);
        this.Controls.Add(lblLado2);
        this.Controls.Add(txtLado2);
        this.Controls.Add(lblLado3);
        this.Controls.Add(txtLado3);
        this.Controls.Add(lblLado4);
        this.Controls.Add(txtLado4);

        this.Controls.Add(btnCalcular);
        this.Controls.Add(lblResultado);
        this.Controls.Add(txtResultado);
    }
//===========================================================================
    private void btnCalcular_Click(object sender, EventArgs e){
        string calculo= cmbCalculo.SelectedIndex.ToString();
        
        int lado1 = 0;
        int lado2 = 0;
        int lado3 = 0;
        int lado4 = 0;

        if(txtLado1.Text!=""||txtLado2.Text!=""||txtLado3.Text!=""||txtLado4.Text!=""){
            if (cmbFiguras.SelectedItem != null && cmbCalculo.SelectedItem != null)
            {
                //Perimetros
                if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
                {
                    lado1=Convert.ToInt32(txtLado1.Text);
                    txtResultado.Text=(lado1*4).ToString();
                }
                if (cmbFiguras.SelectedItem.ToString() == "Rombo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
                {
                    lado1=Convert.ToInt32(txtLado1.Text);
                    txtResultado.Text=(lado1*4).ToString();
                }
                if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
                {
                    lado1=Convert.ToInt32(txtLado1.Text);
                    lado2=Convert.ToInt32(txtLado2.Text);
                    txtResultado.Text=((lado1+lado2)*2).ToString();
                }
                if (cmbFiguras.SelectedItem.ToString() == "Paralelogramo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
                {
                    lado1=Convert.ToInt32(txtLado1.Text);
                    lado2=Convert.ToInt32(txtLado2.Text);
                    txtResultado.Text=((lado1+lado2)*2).ToString();
                }
                if (cmbFiguras.SelectedItem.ToString() == "Cometa" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
                {
                    lado1=Convert.ToInt32(txtLado1.Text);
                    lado2=Convert.ToInt32(txtLado2.Text);
                    txtResultado.Text=((lado1+lado2)*2).ToString();
                }
                if (cmbFiguras.SelectedItem.ToString() == "Circulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
                {
                    lado1=Convert.ToInt32(txtLado1.Text);
                    txtResultado.Text=(((lado1)*2)*Math.PI).ToString();
                }
                if (cmbFiguras.SelectedItem.ToString() == "Trapecio" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
                {
                    lado1=Convert.ToInt32(txtLado1.Text);
                    lado2=Convert.ToInt32(txtLado2.Text);
                    lado3=Convert.ToInt32(txtLado3.Text);
                    lado4=Convert.ToInt32(txtLado4.Text);
                    txtResultado.Text=(lado1+lado2+lado3+lado4).ToString();
                }
                if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
                {
                    lado1=Convert.ToInt32(txtLado1.Text);
                    lado2=Convert.ToInt32(txtLado2.Text);
                    lado3=Convert.ToInt32(txtLado3.Text);
                    txtResultado.Text=(lado1+lado2+lado3).ToString();
                }
                //Areas====================================================
                if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
                {
                    lado1=Convert.ToInt32(txtLado1.Text);
                    lado2=Convert.ToInt32(txtLado2.Text);
                    txtResultado.Text=(lado1*lado2).ToString();
                }
                if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
                {
                    lado1=Convert.ToInt32(txtLado1.Text);
                    lado2=Convert.ToInt32(txtLado2.Text);
                    txtResultado.Text=((lado1*lado2)/2).ToString();
                }
                if (cmbFiguras.SelectedItem.ToString() == "Paralelogramo" && cmbCalculo.SelectedItem.ToString() == "Área")
                {
                    lado1=Convert.ToInt32(txtLado1.Text);
                    lado2=Convert.ToInt32(txtLado2.Text);
                    txtResultado.Text=(lado1*lado2).ToString();
                }
                if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Área")
                {
                    lado1=Convert.ToInt32(txtLado1.Text);
                    txtResultado.Text=(lado1*lado1).ToString();
                }
                if (cmbFiguras.SelectedItem.ToString() == "Rombo" && cmbCalculo.SelectedItem.ToString() == "Área")
                {
                    lado1=Convert.ToInt32(txtLado1.Text);
                    lado2=Convert.ToInt32(txtLado2.Text);
                    txtResultado.Text=((lado1*lado2)/2).ToString();
                }
                if (cmbFiguras.SelectedItem.ToString() == "Cometa" && cmbCalculo.SelectedItem.ToString() == "Área")
                {
                    lado1=Convert.ToInt32(txtLado1.Text);
                    lado2=Convert.ToInt32(txtLado2.Text);
                    txtResultado.Text=((lado1*lado2)/2).ToString();
                }
                if (cmbFiguras.SelectedItem.ToString() == "Trapecio" && cmbCalculo.SelectedItem.ToString() == "Área")
                {
                    lado1=Convert.ToInt32(txtLado1.Text);
                    lado2=Convert.ToInt32(txtLado2.Text);
                    lado3=Convert.ToInt32(txtLado3.Text);
                    txtResultado.Text=(((lado1+lado2)*lado3)/2).ToString();
                }
                if (cmbFiguras.SelectedItem.ToString() == "Circulo" && cmbCalculo.SelectedItem.ToString() == "Área")
                {
                    lado1=Convert.ToInt32(txtLado1.Text);
                    txtResultado.Text=((lado1*lado1)*Math.PI).ToString();
                }

            }

        }
    }
    
    private void cmbFiguras_ValueChanged(object sender, EventArgs e)
    {
        if (cmbFiguras.SelectedItem != null && cmbCalculo.SelectedItem != null)
        {
            limpiarVentana();
            //Perimetros
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblLado1.Text = "Lado";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rombo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblLado1.Text = "Lado";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblLado1.Text = "Altura";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Text = "Base";
                lblLado2.Visible = true;
                txtLado2.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Paralelogramo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblLado1.Text = "Lado A";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Text = "Base";
                lblLado2.Visible = true;
                txtLado2.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Cometa" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblLado1.Text = "Lado A";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Text = "Lado B";
                lblLado2.Visible = true;
                txtLado2.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Circulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblLado1.Text = "Radio";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Trapecio" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Visible = true;
                txtLado2.Visible = true;
                lblLado3.Visible = true;
                txtLado3.Visible = true;
                lblLado4.Visible = true;
                txtLado4.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Visible = true;
                txtLado2.Visible = true;
                lblLado3.Visible = true;
                txtLado3.Visible = true;
            }
            //Areas
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblLado1.Text = "Altura";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Text = "Base";
                lblLado2.Visible = true;
                txtLado2.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblLado1.Text = "Altura";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Text = "Base";
                lblLado2.Visible = true;
                txtLado2.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Paralelogramo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblLado1.Text = "Altura";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Text = "Base";
                lblLado2.Visible = true;
                txtLado2.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblLado1.Text = "Lado";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rombo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblLado1.Text = "Digl. D";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Text = "Digl. d";
                lblLado2.Visible = true;
                txtLado2.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Cometa" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblLado1.Text = "Digl. D";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Text = "Digl. d";
                lblLado2.Visible = true;
                txtLado2.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Trapecio" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblLado1.Text = "Base B";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Text = "Base b";
                lblLado2.Visible = true;
                txtLado2.Visible = true;
                lblLado3.Text = "Altura";
                lblLado3.Visible = true;
                txtLado3.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Circulo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblLado1.Text = "Radio";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
            }

        }

    }

    private void cmbCalculo_ValueChanged(object sender, EventArgs e)
    {
        if (cmbFiguras.SelectedItem != null && cmbCalculo.SelectedItem != null)
        {
            limpiarVentana();
            //Perimetros
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblLado1.Text = "Lado";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rombo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblLado1.Text = "Lado";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblLado1.Text = "Altura";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Text = "Base";
                lblLado2.Visible = true;
                txtLado2.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Paralelogramo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblLado1.Text = "Lado A";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Text = "Base";
                lblLado2.Visible = true;
                txtLado2.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Cometa" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblLado1.Text = "Lado A";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Text = "Lado B";
                lblLado2.Visible = true;
                txtLado2.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Circulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblLado1.Text = "Radio";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Trapecio" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Visible = true;
                txtLado2.Visible = true;
                lblLado3.Visible = true;
                txtLado3.Visible = true;
                lblLado4.Visible = true;
                txtLado4.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Visible = true;
                txtLado2.Visible = true;
                lblLado3.Visible = true;
                txtLado3.Visible = true;
            }
            //Areas==================================================================================================
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblLado1.Text = "Altura";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Text = "Base";
                lblLado2.Visible = true;
                txtLado2.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblLado1.Text = "Altura";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Text = "Base";
                lblLado2.Visible = true;
                txtLado2.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Paralelogramo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblLado1.Text = "Altura";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Text = "Base";
                lblLado2.Visible = true;
                txtLado2.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblLado1.Text = "Lado";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rombo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblLado1.Text = "Digl. D";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Text = "Digl. d";
                lblLado2.Visible = true;
                txtLado2.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Cometa" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblLado1.Text = "Digl. D";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Text = "Digl. d";
                lblLado2.Visible = true;
                txtLado2.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Trapecio" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblLado1.Text = "Base B";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Text = "Base b";
                lblLado2.Visible = true;
                txtLado2.Visible = true;
                lblLado3.Text = "Altura";
                lblLado3.Visible = true;
                txtLado3.Visible = true;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Circulo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblLado1.Text = "Radio";
                lblLado1.Visible = true;
                txtLado1.Visible = true;
            }
        }
    }

    private void limpiarVentana()
    {
        lblLado1.Text = "Lado 1";
        lblLado2.Text = "Lado 2";
        lblLado3.Text = "Lado 3";
        lblLado4.Text = "Lado 4";
        txtLado1.Text = "";
        txtLado2.Text = "";
        txtLado3.Text = "";
        txtLado4.Text = "";
        lblLado1.Visible = false;
        txtLado1.Visible = false;
        lblLado2.Visible = false;
        txtLado2.Visible = false;
        lblLado3.Visible = false;
        txtLado3.Visible = false;
        lblLado4.Visible = false;
        txtLado4.Visible = false;
    }
}
