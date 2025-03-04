using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

/* Juan Manuel Badillo Flores 19100148
 * Hector Samuel Machado Aguilar 19100208*/

namespace ProyectoFinal
{

    //Clase Base para Nivel
    class Nivel
    {   
        //Atributos
        int _intNumero; //Numero Identificador del Nivel
        string _strCategoria; //Categoria del Nivel

        //Propiedades
        public int Numero
        {
            get { return _intNumero; }
            set { _intNumero = value; }
        }
        public string Categoria
        {
            get { return _strCategoria; }
            set { _strCategoria = value; }
        }

        //Constructores
        public Nivel()
        {
        }
        public Nivel(int n,string c)
        {
            _intNumero = n;
            _strCategoria = c;
        }

        //Metodos

        //Define el Texto de la Caja de Dialogo
        public void ImprimirCajaDeDialogo(string Dialogo, Label Pista, Panel CajaDeDialogo)
        {
            CajaDeDialogo.Visible = true; //Habilita la visibilidad de la caja de dialogo
            Pista.Text = Dialogo; //Define el texto a mostrar en la caja 
        }

        //Define el Diagrama UML Editable
        public void ImprimirUML(string t, string a1, string a2, string a3, string m1, string m2, Label T, TextBox A1,TextBox A2, TextBox A3, TextBox M1, TextBox M2)
        {
            T.Text = t; 
            A1.Text = a1;
            A2.Text = a2;
            A3.Text = a3;
            M1.Text = m1;
            M2.Text = m2;
        }

        //Prepara el Boton de tamaño A*L en la Posicion X,Y para interactuar con objeto "Nombre"
        public void PosicionarObjetoInteractuable(string Nombre, int X, int Y, int A, int L, Button ObjetoInteractuable)
        {
            ObjetoInteractuable.FlatAppearance.BorderSize = 0; //Borde del Boton, 1 para modo edicion, 0 para ocultar en uso final
            ObjetoInteractuable.Location = new Point(X, Y); //Posicion del Boton
            ObjetoInteractuable.Size = new Size(A, L); //Tamaño del Boton
            ObjetoInteractuable.Name = Nombre; //Nombre del Objeto
            ObjetoInteractuable.Text = ""; //Texto vacio para el boton
        }
    }

    //Clase para Niveles de Abstraccion, hereda de clase Nivel
    class NivelAbstraccion : Nivel
    {
        //Atributos
        string _strAtributo1;
        string _strAtributo2;
        string _strAtributo3;
        string _strMetodo1;
        string _strMetodo2;

        //Propiedades
        public string Atributo1
        {
            get { return _strAtributo1; }
            set { _strAtributo1 = value; }
        }
        public string Atributo2
        {
            get { return _strAtributo2; }
            set { _strAtributo2 = value; }
        }
        public string Atributo3
        {
            get { return _strAtributo3; }
            set { _strAtributo3 = value; }
        }
        public string Metodo1
        {
            get { return _strMetodo1; }
            set { _strMetodo1 = value; }
        }

        public string Metodo2
        {
            get { return _strMetodo2; }
            set { _strMetodo2 = value; }
        }

        //Constructores
        public NivelAbstraccion()
        {
        }
        public NivelAbstraccion(string a1, string a2, string a3, string m1, string m2)
        {
            _strAtributo1 = a1;
            _strAtributo2 = a2;
            _strAtributo3 = a3;
            _strMetodo1 = m1;
            _strMetodo2 = m2;
        }

        //Metodos

        //Define la respuesta esperada para el nivel
        public void DefinirUMLRespuesta(string a1, string a2, string a3, string m1, string m2) 
        { 
            Atributo1 = a1;
            Atributo2 = a2;
            Atributo3 = a3;
            Metodo1 = m1;
            Metodo2 = m2;
        }
    }
    
    //Clase para Niveles de Herencia, hereda de clase Nivel
    class NivelHerencia : Nivel
    {
        //Atributos
        string _strHerenciaTitulo1;
        string _strHerenciaTitulo2;
        string _strHerenciaTitulo3;
        string _strHerenciaTituloCorrecto;

        string _strHAtributo1P1;
        string _strHAtributo2P1;
        string _strHMetodo1P1;
        string _strHAtributo1P2;
        string _strHAtributo2P2;
        string _strHMetodo1P2;
        string _strHAtributo1P3;
        string _strHAtributo2P3;
        string _strHMetodo1P3;

        //Propiedades
        public string HerenciaTitulo1
        {
            get { return _strHerenciaTitulo1; }
            set { _strHerenciaTitulo1 = value; }
        }
        public string HerenciaTitulo2
        {
            get { return _strHerenciaTitulo2; }
            set { _strHerenciaTitulo2 = value; }
        }
        public string HerenciaTitulo3
        {
            get { return _strHerenciaTitulo3; }
            set { _strHerenciaTitulo3 = value; }
        }
        public string HerenciaTituloCorrecto
        {
            get { return _strHerenciaTituloCorrecto; }
            set { _strHerenciaTituloCorrecto = value; }
        }


        public string Atributo1P1
        {
            get { return _strHAtributo1P1; }
            set { _strHAtributo1P1 = value; }
        }
        public string Atributo2P1
        {
            get { return _strHAtributo2P1; }
            set { _strHAtributo2P1 = value; }
        }
        public string Metodo1P1
        {
            get { return _strHMetodo1P1; }
            set { _strHMetodo1P1 = value; }
        }
        public string Atributo1P2
        {
            get { return _strHAtributo1P2; }
            set { _strHAtributo1P2 = value; }
        }
        public string Atributo2P2
        {
            get { return _strHAtributo2P2; }
            set { _strHAtributo2P2 = value; }
        }
        public string Metodo1P2
        {
            get { return _strHMetodo1P2; }
            set { _strHMetodo1P2 = value; }
        }
        public string Atributo1P3
        {
            get { return _strHAtributo1P3; }
            set { _strHAtributo1P3 = value; }
        }
        public string Atributo2P3
        {
            get { return _strHAtributo2P3; }
            set { _strHAtributo2P3 = value; }
        }
        public string Metodo1P3
        {
            get { return _strHMetodo1P3; }
            set { _strHMetodo1P3 = value; }
        }

        //Metodos

        //Define el Diagrama UML de Herencia
        public void ImprimirUMLHerencia(string t1, string t2, string t3, string tc, ComboBox Titulo)
        {
            Titulo.Items.Add(t1);
            Titulo.Items.Add(t2);
            Titulo.Items.Add(t3);
            HerenciaTitulo1 = t1;
            HerenciaTitulo2 = t2;
            HerenciaTitulo3 = t3;
            HerenciaTituloCorrecto = tc;
        }

        //Define los Posibles Atributos y Metodos del Diagrama UML de Herencia
        public void DefinirUMLPosiblesHerencias(string a1p1, string a2p1, string m1p1, string a1p2, string a2p2, string m1p2, string a1p3, string a2p3, string m1p3)
        {
            Atributo1P1 = a1p1;
            Atributo2P1 = a2p1;
            Metodo1P1 = m1p1;
            Atributo1P2 = a1p2;
            Atributo2P2 = a2p2;
            Metodo1P2 = m1p2;
            Atributo1P3 = a1p3;
            Atributo2P3 = a2p3;
            Metodo1P3 = m1p3;
        }

        //Imprime en el diagrama los atributos y metodos correctos segun el titulo seleccionado
        public void ImprimirUMLHerencia(int opcion, TextBox Atributo1, TextBox Atributo2, TextBox Metodo1)
        {
            if (opcion == 1)
            {
                Atributo1.Text = Atributo1P1;
                Atributo2.Text = Atributo2P1;
                Metodo1.Text = Metodo1P1;
            }
            if (opcion == 2)
            {
                Atributo1.Text = Atributo1P2;
                Atributo2.Text = Atributo2P2;
                Metodo1.Text = Metodo1P2;
            }
            if (opcion == 3)
            {
                Atributo1.Text = Atributo1P3;
                Atributo2.Text = Atributo2P3;
                Metodo1.Text = Metodo1P3;
            }
        }
    }

    //Clase para Niveles de Polimorfimso, hereda de clase Nivel
    class NivelPolimorfismo : Nivel
    {
        //Atributos
        int _strMetodoPoli;
        int _strMetodoPoliCorrecto;

        //Propiedades
        public int MetodoPoli
        {
            get { return _strMetodoPoli; }
            set { _strMetodoPoli = value; }
        }      
        public int MetodoPoliCorrecto
        {
            get { return _strMetodoPoliCorrecto; }
            set { _strMetodoPoliCorrecto = value; }
        }

        //Metodos

        public void DefinirMetodoPoliCorrecto(int Poli)
        {
            MetodoPoliCorrecto = Poli;
        }

    }

    //Clase para Niveles de Encapsulamiento, hereda de clase Nivel
    class NivelEncapsulamiento : Nivel
    {
        //Atributos
        string _strCapsula1;
        string _strCapsula2;
        string _strCapsula3;
        string _strCapsulaCorrecta1;
        string _strCapsulaCorrecta2;
        string _strCapsulaCorrecta3;

        //Propiedades
        public string Capsula1
        {
            get { return _strCapsula1; }
            set { _strCapsula1 = value; }
        }
        public string Capsula2
        {
            get { return _strCapsula2; }
            set { _strCapsula2 = value; }
        }
        public string Capsula3
        {
            get { return _strCapsula3; }
            set { _strCapsula3 = value; }
        }
        public string CapsulaCorrecta1
        {
            get { return _strCapsulaCorrecta1; }
            set { _strCapsulaCorrecta1 = value; }
        }
        public string CapsulaCorrecta2
        {
            get { return _strCapsulaCorrecta2; }
            set { _strCapsulaCorrecta2 = value; }
        }
        public string CapsulaCorrecta3
        {
            get { return _strCapsulaCorrecta3; }
            set { _strCapsulaCorrecta3 = value; }
        }

        //Constructoes
        public NivelEncapsulamiento()
        {
            Capsula1 = "Privado";
            Capsula2 = "Privado";
            Capsula3 = "Privado";
        }

        //Metodos

        public void DefinirCapsulas(string C1, string C2, string C3)
        {
            CapsulaCorrecta1 = C1;
            CapsulaCorrecta2 = C2;
            CapsulaCorrecta3 = C3;
        }

    }


    //Clase para controlar Personajes
    class Personaje
    {
        //Atributos
        string _strTipo;

        //Propiedades
        public string Tipo
        {
            get { return _strTipo; }
            set { _strTipo = value; }
        }

        //Constructores
        public Personaje()
        {
        }
        public Personaje(string t)
        {
            _strTipo = t;
        }

        //Metodos

        //Ajusta la Posicion del Personaje
        public void AjustarPersonaje(int X, int Y, PictureBox Personaje)
        {
            Personaje.Location = new Point(X, Y); //Posicion del Personaje
        }

        //Cambia la imagen o animacion del Personaje
        public void AnimarPersonaje(string Tipo, string Sprite, PictureBox Personaje)
        {
            //Valida el tipo de personaje
            if (Tipo == "Jugador")
            {
                //Valida la imagen seleccionada
                if (Sprite == "Magia")
                {
                    Personaje.Image = ProyectoFinal.Properties.Resources.sprite_DuckCastNoLoop;
                }
                if (Sprite == "Estatico")
                {
                    Personaje.Image = ProyectoFinal.Properties.Resources.sprite_Duck;
                }
            }
            //Valida el tipo de personaje
            if (Tipo == "Enemigo")
            {
                //Valida la imagen seleccionada
                if (Sprite == "Azul")
                {
                    Personaje.Image = ProyectoFinal.Properties.Resources.sprite_BugBlue;
                }
                if (Sprite == "Morado")
                {
                    Personaje.Image = ProyectoFinal.Properties.Resources.sprite_BugPurple;
                }
                if (Sprite == "Rojo")
                {
                    Personaje.Image = ProyectoFinal.Properties.Resources.sprite_BugRed;
                }
                if (Sprite == "Verde")
                {
                    Personaje.Image = ProyectoFinal.Properties.Resources.sprite_BugGreen;
                }
                if (Sprite == "Aqua")
                {
                    Personaje.Image = ProyectoFinal.Properties.Resources.sprite_BugTeal;
                }
                if (Sprite == "Muerto")
                {
                    Personaje.Image = ProyectoFinal.Properties.Resources.sprite_BugFixed;
                }
            }
        }
    }

    //Clase para controlar Puntuacion
    class Puntuacion
    {
        int _intPuntos;

        public int Puntos
        {
            get { return _intPuntos; }
            set { _intPuntos = value; }
        }

        public int GenerarID()
        {
            Random r = new Random();
            int id = r.Next(1, 1001); //Genera ID
            return id;
        }
    }
}