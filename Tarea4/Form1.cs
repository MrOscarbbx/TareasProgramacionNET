using System.Reflection;
using System.Drawing;
using System;
using System.Runtime.CompilerServices;
using System.Globalization;
namespace Tarea4;

public partial class Form1 : Form
{
    private Button btnBorrarUltimo;
    private Button btnBorrarActual;
    private Button btnBorrarTodo;
    private Button btnSigno;
    private Button btn7;
    private Button btn8;
    private Button btn9;
    private Button btnSuma;
    private Button btn4;
    private Button btn5;
    private Button btn6;
    private Button btnResta;
    private Button btn1;
    private Button btn2;
    private Button btn3;
    private Button btnMultiplicacion;
    private Button btn0;
    private Button btnPunto;
    private Button btnIgual;
    private Button btnDivision;
    private TextBox txtDisplay;
    private Label lblOperacion;
    private String operacion;
    private Double resultado;
    private Button btnPi;
    private Button btnLog;
    private Button btnSqrt;
    private Button btnCuadrado;
    private Button btnSinh;
    private Button btnSin;
    private Button btnDec;
    private Button btnPotencia;
    private Button btnCosh;
    private Button btnCos;
    private Button btnBin;
    private Button btnFraccion;
    private Button btnTanh;
    private Button btnTan;
    private Button btnHex;
    private Button btnLn;
    private Button btnExp;
    private Button btnMod;
    private Button btnOct;

    private MenuStrip menu;
    private ToolStripMenuItem catTipo;
    private ToolStripMenuItem miEstandar;
    private ToolStripMenuItem miCientifica;

    public Form1()
    {
        operacion="";
        resultado=0;
        txtDisplay=new TextBox();
        lblOperacion= new Label();

        btnBorrarUltimo= new Button();
        btnBorrarActual= new Button();
        btnBorrarTodo= new Button();

        btnSigno= new Button();
        btn7= new Button();
        btn8= new Button();
        btn9= new Button();
        btnSuma= new Button();
        btn4= new Button();
        btn5= new Button();
        btn6= new Button();
        btnResta= new Button();
        btn1= new Button();
        btn2= new Button();
        btn3= new Button();
        btnMultiplicacion= new Button();
        btn0= new Button();
        btnPunto= new Button();
        btnIgual= new Button();
        btnDivision= new Button();

        btnPi= new Button();
        btnLog= new Button();
        btnSqrt= new Button();
        btnCuadrado= new Button();
        btnSinh= new Button();
        btnSin= new Button();
        btnDec= new Button();
        btnPotencia= new Button();
        btnCosh= new Button();
        btnCos= new Button();
        btnBin= new Button();
        btnFraccion= new Button();
        btnTanh= new Button();
        btnTan= new Button();
        btnHex= new Button();
        btnLn= new Button();
        btnExp= new Button();
        btnMod= new Button();
        btnOct= new Button();

        menu= new MenuStrip();
        catTipo= new ToolStripMenuItem();
        miEstandar= new ToolStripMenuItem();
        miCientifica= new ToolStripMenuItem();

        

        InitializeComponent();
        inicializarComponentes();
    }

    private void inicializarComponentes(){
        this.Size=new Size(600,500);
        this.Text="Calculadora";
        btnBorrarUltimo.Size= new Size(60,60);
        btnBorrarActual.Size= new Size(60,60);
        btnBorrarTodo.Size= new Size(60,60);
        btnSigno.Size= new Size(60,60);
        btn7.Size= new Size(60,60);
        btn8.Size= new Size(60,60);
        btn9.Size= new Size(60,60);
        btnSuma.Size= new Size(60,60);
        btn4.Size= new Size(60,60);
        btn5.Size= new Size(60,60);
        btn6.Size= new Size(60,60);
        btnResta.Size= new Size(60,60);
        btn1.Size= new Size(60,60);
        btn2.Size= new Size(60,60);
        btn3.Size= new Size(60,60);
        btnMultiplicacion.Size= new Size(60,60);
        btn0.Size= new Size(60,60);
        btnPunto.Size= new Size(60,60);
        btnIgual.Size= new Size(60,60);
        btnDivision.Size= new Size(60,60);
        txtDisplay.Size=new Size(558,50);
        txtDisplay.Multiline=true;
        lblOperacion.AutoSize=true;
        txtDisplay.TextAlign=HorizontalAlignment.Right;

        btnPi.Size=new Size(60,60);
        btnLog.Size=new Size(60,60);
        btnSqrt.Size=new Size(60,60);
        btnCuadrado.Size=new Size(60,60);
        btnSinh.Size=new Size(60,60);
        btnSin.Size= new Size(60,60);
        btnDec.Size=new Size(60,60);
        btnPotencia.Size=new Size(60,60);
        btnCosh.Size=new Size(60,60);
        btnCos.Size=new Size(60,60);
        btnBin.Size=new Size(60,60);
        btnFraccion.Size=new Size(60,60);
        btnTanh.Size=new Size(60,60);
        btnTan.Size=new Size(60,60);
        btnHex.Size=new Size(60,60);
        btnLn.Size=new Size(60,60);
        btnExp.Size=new Size(60,60);
        btnMod.Size=new Size(60,60);
        btnOct.Size=new Size(60,60);

        //==============Nombres========================

        btnBorrarUltimo.Text="⌫";
        btnBorrarActual.Text="CE";
        btnBorrarTodo.Text="C";
        btnSigno.Text="±";
        btn7.Text="7";
        btn8.Text="8";
        btn9.Text="9";
        btnSuma.Text="+";
        btn4.Text="4";
        btn5.Text="5";
        btn6.Text="6";
        btnResta.Text="-";
        btn1.Text="1";
        btn2.Text="2";
        btn3.Text="3";
        btnMultiplicacion.Text="*";
        btn0.Text="0";
        btnPunto.Text=".";
        btnIgual.Text="=";
        btnDivision.Text="/";

        btnPi.Text="π";
        btnLog.Text="Log";
        btnSqrt.Text="Sqrt";
        btnCuadrado.Text="x^2";
        btnSinh.Text="Sinh";
        btnSin.Text="Sin";
        btnDec.Text="Dec";
        btnPotencia.Text="x^y";
        btnCosh.Text="Cosh";
        btnCos.Text="Cos";
        btnBin.Text="Bin";
        btnFraccion.Text="1/x";
        btnTanh.Text="Tanh";
        btnTan.Text="Tan";
        btnHex.Text="Hex";
        btnLn.Text="Ln x";
        btnExp.Text="Exp";
        btnMod.Text="Mod";
        btnOct.Text="Oct";


        catTipo.Text="Tipo";
        miEstandar.Text="Estandar";
        miCientifica.Text="Cientifica";

        //Posicion
        txtDisplay.Location= new Point(10,50);
        lblOperacion.Location= new Point(10,30);
        

        List<Button> lista= new List<Button>();

        lista.Add(btnBorrarUltimo);
        lista.Add(btnBorrarActual);
        lista.Add(btnBorrarTodo);
        lista.Add(btnSigno);
        lista.Add(btn7);
        lista.Add(btn8);
        lista.Add(btn9);
        lista.Add(btnSuma);
        lista.Add(btn4);
        lista.Add(btn5);
        lista.Add(btn6);
        lista.Add(btnResta);
        lista.Add(btn1);
        lista.Add(btn2);
        lista.Add(btn3);
        lista.Add(btnMultiplicacion);
        lista.Add(btn0);
        lista.Add(btnPunto);
        lista.Add(btnIgual);
        lista.Add(btnDivision);

        int x=10;
        int y=105;
        int cont=0;
        foreach (Button btn in lista)
        {
            if (cont==4)
            {
                x=10;
                y+=67;
                cont=0;
            }
            cont++;
            btn.Location= new Point(x,y);
            btn.Click+=new EventHandler(btn_click);
            this.Controls.Add(btn);
            x+=67;
        }

        List<Button> cientfica= new List<Button>();

        cientfica.Add(btnPi);
        cientfica.Add(btnLog);
        cientfica.Add(btnSqrt);
        cientfica.Add(btnCuadrado);
        cientfica.Add(btnSinh);
        cientfica.Add(btnSin);
        cientfica.Add(btnDec);
        cientfica.Add(btnPotencia);
        cientfica.Add(btnCosh);
        cientfica.Add(btnCos);
        cientfica.Add(btnBin);
        cientfica.Add(btnFraccion);
        cientfica.Add(btnTanh);
        cientfica.Add(btnTan);
        cientfica.Add(btnHex);
        cientfica.Add(btnLn);
        cientfica.Add(btnExp);
        cientfica.Add(btnMod);
        cientfica.Add(btnOct);


        x=307;
        y=105;
        cont=0;
        foreach (Button btn in cientfica)
        {
            if (cont==4)
            {
                x=307;
                y+=67;
                cont=0;
            }
            cont++;
            btn.Location= new Point(x,y);
            btn.Click+=new EventHandler(btn_click);
            this.Controls.Add(btn);
            x+=67;
        }
        //Eventos
        miEstandar.Click+=new EventHandler(menuEstandar_Click);
        miCientifica.Click+=new EventHandler(menuCientifica_Click);
        btnPi.Click+=new EventHandler(btnPi_Click);
        btnLog.Click+=new EventHandler(btnLog_Click);
        btnLn.Click+=new EventHandler(btnLn_Click);
        btnSin.Click+=new EventHandler(btnSin_Click);
        btnTan.Click+=new EventHandler(btnTan_Click);
        btnCos.Click+=new EventHandler(btnCos_Click);
        btnSinh.Click+=new EventHandler(btnSinh_Click);
        btnTanh.Click+=new EventHandler(btnTanh_Click);
        btnCosh.Click+=new EventHandler(btnCosh_Click);
        btnBin.Click+=new EventHandler(btnBin_Click);
        btnHex.Click+=new EventHandler(btnHex_Click);
        btnOct.Click+=new EventHandler(btnOct_Click);
        btnDec.Click+=new EventHandler(btnDec_Click);
        btnCuadrado.Click+=new EventHandler(btnCuadrado_Click);
        btnSqrt.Click+=new EventHandler(btnSqrt_Click);
        btnFraccion.Click+=new EventHandler(btnFraccion_Click);

        //Controles
        this.Controls.Add(txtDisplay);
        this.Controls.Add(lblOperacion);
        catTipo.DropDownItems.Add(miEstandar);
        catTipo.DropDownItems.Add(miCientifica);
        menu.Items.Add(catTipo);
        this.Controls.Add(menu);
        
        lblOperacion.BringToFront();
        

    }

    private void btnPi_Click(object? sender, EventArgs e){
        txtDisplay.Text="3.14159265";
    }
    private void btnLog_Click(object? sender, EventArgs e){
        lblOperacion.Text=$"Log({txtDisplay.Text}) =";
        txtDisplay.Text=Math.Log(Double.Parse(txtDisplay.Text)).ToString();
    }
    private void btnLn_Click(object? sender, EventArgs e){
        lblOperacion.Text=$"Ln({txtDisplay.Text}) =";
        txtDisplay.Text=Math.Log10(Double.Parse(txtDisplay.Text)).ToString();
    }
    private void btnSqrt_Click(object? sender, EventArgs e){
        lblOperacion.Text=$"Sqrt({txtDisplay.Text}) =";
        txtDisplay.Text=Math.Sqrt(Double.Parse(txtDisplay.Text)).ToString();
    }
    private void btnCuadrado_Click(object? sender, EventArgs e){
        lblOperacion.Text=$"Cuadrado({txtDisplay.Text}) =";
        txtDisplay.Text=Math.Pow(Double.Parse(txtDisplay.Text),2).ToString();
    }
    private void btnFraccion_Click(object? sender, EventArgs e){
        lblOperacion.Text=$"1/({txtDisplay.Text}) =";
        if (!(txtDisplay.Text=="0")) txtDisplay.Text=(1/Double.Parse(txtDisplay.Text)).ToString();
    }


    private void btnSin_Click(object? sender, EventArgs e){
        lblOperacion.Text=$"Sin({txtDisplay.Text}) =";
        txtDisplay.Text=Math.Sin(Double.Parse(txtDisplay.Text)).ToString();
    }
    private void btnTan_Click(object? sender, EventArgs e){
        lblOperacion.Text=$"Tan({txtDisplay.Text}) =";
        txtDisplay.Text=Math.Tan(Double.Parse(txtDisplay.Text)).ToString();
    }
    private void btnCos_Click(object? sender, EventArgs e){
        lblOperacion.Text=$"Cos({txtDisplay.Text}) =";
        txtDisplay.Text=Math.Cos(Double.Parse(txtDisplay.Text)).ToString();
    }
    private void btnSinh_Click(object? sender, EventArgs e){
        lblOperacion.Text=$"Sinh({txtDisplay.Text}) =";
        txtDisplay.Text=Math.Sinh(Double.Parse(txtDisplay.Text)).ToString();
    }
    private void btnTanh_Click(object? sender, EventArgs e){
        lblOperacion.Text=$"Tanh({txtDisplay.Text}) =";
        txtDisplay.Text=Math.Tanh(Double.Parse(txtDisplay.Text)).ToString();
    }
    private void btnCosh_Click(object? sender, EventArgs e){
        lblOperacion.Text=$"Cosh({txtDisplay.Text}) =";
        txtDisplay.Text=Math.Cosh(Double.Parse(txtDisplay.Text)).ToString();
    }

    private void btnBin_Click(object? sender, EventArgs e){
        if (!txtDisplay.Text.Contains("."))
        {
            lblOperacion.Text=$"Bin({txtDisplay.Text}) =";
            txtDisplay.Text=Convert.ToString(Int32.Parse(txtDisplay.Text),2);
        }
    }
    private void btnHex_Click(object? sender, EventArgs e){
        if (!txtDisplay.Text.Contains(".")){
        lblOperacion.Text=$"Hex({txtDisplay.Text}) =";
        txtDisplay.Text=Convert.ToString(Int32.Parse(txtDisplay.Text),16);
        }
    }
    private void btnOct_Click(object? sender, EventArgs e){
        if (!txtDisplay.Text.Contains(".")){
        lblOperacion.Text=$"Oct({txtDisplay.Text}) =";
        txtDisplay.Text=Convert.ToString(Int32.Parse(txtDisplay.Text),8);
        }
    }
    private void btnDec_Click(object? sender, EventArgs e){
        if (!txtDisplay.Text.Contains(".")){
        lblOperacion.Text=$"Dec({txtDisplay.Text}) =";
        txtDisplay.Text=Convert.ToString(Int32.Parse(txtDisplay.Text),10);
        }
    }




    private void menuEstandar_Click(object? sender, EventArgs e){
        this.Size=new Size(300,500);
        txtDisplay.Size= new Size(260,50);
    }
    private void menuCientifica_Click(object? sender, EventArgs e){
        this.Size=new Size(600,500);
        txtDisplay.Size= new Size(558,50);
    }

    private void btn_click(object? sender,EventArgs e){
        if (sender!=null)
        {
            Button btn= (Button) sender;
            switch (btn.Text)
            {
                case "⌫":
                    if (txtDisplay.Text.Length>0)
                    {
                        txtDisplay.Text=txtDisplay.Text.Remove(txtDisplay.Text.Length-1,1);
                    }
                    if (txtDisplay.Text=="")
                    {
                        txtDisplay.Text="0";
                    }
                    break;
                case "CE":
                    txtDisplay.Text="0";
                    break;                
                case "C":
                    txtDisplay.Text="0";
                    lblOperacion.Text="";
                    break;
               case "=":
                    boton_igual();
                    break;
                case "±":
                    txtDisplay.Text=(Double.Parse(txtDisplay.Text)*-1).ToString();
                    break;
                case "0":case "1":case "2":case "3":case "4":case "5":case "6":case "7":case "8":case "9":case ".":
                    boton_numero(btn.Text);
                    break;
                case "+":case "-":case "*":case "/":case "x^y":case "Mod":case "Exp":
                    boton_operador(btn.Text);
                    break;
                default:
                    break;
            }
            
        }
    }
    private void boton_igual(){
        lblOperacion.Text+=" "+txtDisplay.Text+" =";
        switch (operacion)
        {
            case "+":
                txtDisplay.Text=(resultado+Double.Parse(txtDisplay.Text)).ToString();
                break;
            case "-":
                txtDisplay.Text=(resultado-Double.Parse(txtDisplay.Text)).ToString();
                break;
            case "*":
                txtDisplay.Text=(resultado*Double.Parse(txtDisplay.Text)).ToString();
                break;
            case "/":
                txtDisplay.Text=(resultado/Double.Parse(txtDisplay.Text)).ToString();
                break;
            case "%":
                txtDisplay.Text=(resultado%Double.Parse(txtDisplay.Text)).ToString();
                break;
            case "^":
                txtDisplay.Text=(Math.Pow(resultado,Double.Parse(txtDisplay.Text))).ToString();
                break;  
            case ".e +":
                txtDisplay.Text=((Math.Pow(10,Double.Parse(txtDisplay.Text)))*resultado).ToString();
                break;  
            default:
                break;
        }
        
    }

    private void boton_numero(string valor){
        if (txtDisplay.Text=="0")
        {
            txtDisplay.Text="";
        }
        if (valor==".")
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text+=valor;
            }
        }
        else
        {
            txtDisplay.Text+=valor;
        }
    }
    private void boton_operador(string operador){
        operacion=operador;
        if (operacion=="x^y")
        {
            operacion="^";
        }
        if (operacion=="Mod")
        {
            operacion="%";
        }
        if (operacion=="Exp")
        {
            operacion=".e +";
        }
        resultado=Double.Parse(txtDisplay.Text);
        lblOperacion.Text=txtDisplay.Text+" "+operacion;
        txtDisplay.Text="0";
    }
}
