using System;
using System.Windows.Forms;
using System.Media;

/* Juan Manuel Badillo Flores 19100148
 * Hector Samuel Machado Aguilar 19100208*/

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        //Instancia clases de Niveles
        Nivel miNivel = new Nivel();
        NivelAbstraccion miNivelAbstraccion = new NivelAbstraccion();
        NivelHerencia miNivelHerencia = new NivelHerencia();
        NivelEncapsulamiento miNivelEncapsulamiento = new NivelEncapsulamiento();
        NivelPolimorfismo miNivelPolimorfismo = new NivelPolimorfismo();

        ////Instancia clase Personaje
        Personaje miPersonaje = new Personaje();

        //Instancia clase Puntuacion
        Puntuacion misPuntos = new Puntuacion();

        public Form1()
        {
            InitializeComponent();
            miNivel.Numero = 0; //Nivel que se ejecuta al iniciar
            CargarPantalla();
            misPuntos.Puntos = 0;
        }

        //Mostrar Nivel en Pantalla
        private void CargarPantalla()
        {
            pnlUML.Visible = false;
            pnlCajaDeDialogo.Visible = false;
            pnlHerencia.Visible = false;

            //Valida el Numero de Nivel y lo crea en pantalla
            if (miNivel.Numero <= 0)
            {
                miNivel.Categoria = "Menu";
                pb_TitleScreen.Image = ProyectoFinal.Properties.Resources.Screen_Title;
                ReproducirAudio("MenuMusic");

            }//Menu de Inicio
            if (miNivel.Numero == 1)
            {
                //Define la categoria del Nivel y oculta elementos de otras categorias
                miNivel.Categoria = "Abstraccion";
                ReproducirAudio("Level");
                //Muestra Imagen de Fondo para el Nivel
                this.BackgroundImage = ProyectoFinal.Properties.Resources.Screen_Level1;
                //Posiciona la HitBox del objeto editable
                miNivel.PosicionarObjetoInteractuable("Puente", 296, 360, 415, 50, btn_ObjetoInteractuable);
                //Imprime en pantalla la caja de dialogo
                miNivel.ImprimirCajaDeDialogo("En POO todo funciona entorno a Objetos. Selecciona el"+"\n"+"objeto puente y agrega sus atributos Tamaño y Material" + "\n" +"en las primeras dos lineas...", lblPista, pnlCajaDeDialogo);
                //Prepara el UML editable mostrado al usuario
                miNivel.ImprimirUML("Puente", "", "", "", "", "", lblUMLTitulo, txtUMLAtributo1, txtUMLAtributo2, txtUMLAtributo3, txtUMLMetodo1, txtUMLMetodo2);
                //Define la respuesta esperada para el nivel
                miNivelAbstraccion.DefinirUMLRespuesta("Tamaño", "Material", "", "", "");
                //Posiciona y carga personajes del juagador y enemigo
                miPersonaje.AjustarPersonaje(240, 289, playerCharacter);
                miPersonaje.AnimarPersonaje("Jugador", "Estatico", playerCharacter);
                miPersonaje.AjustarPersonaje(564, 295, enemyCharacter);
                miPersonaje.AnimarPersonaje("Enemigo", "Azul", enemyCharacter);
            }//Abstraccion 1 Lv1
            if (miNivel.Numero == 2)
            {
                //Define la categoria del Nivel  y oculta elementos de otras categorias
                miNivel.Categoria = "Abstraccion";
                //ReproducirAudio("Level");
                //Muestra Imagen de Fondo para el Nivel
                this.BackgroundImage = ProyectoFinal.Properties.Resources.Screen_Level2;
                //Posiciona la HitBox del objeto editable
                miNivel.PosicionarObjetoInteractuable("Puerta", 825, 330, 70, 100, btn_ObjetoInteractuable);
                //Imprime en pantalla la caja de dialogo
                miNivel.ImprimirCajaDeDialogo("Los objetos tambien necesitan METODOS, agrega un metodo" + "\n" + "para abrir la puerta en la segunda seccion del diagrama." + "\n" + "Escribelo como verbo y con parentesis. PEj: Hacer()...", lblPista, pnlCajaDeDialogo);
                //Prepara el UML editable mostrado al usuario
                miNivel.ImprimirUML("Puerta", "Tamaño", "Material", "", "", "", lblUMLTitulo, txtUMLAtributo1, txtUMLAtributo2, txtUMLAtributo3, txtUMLMetodo1, txtUMLMetodo2);
                //Define la respuesta esperada para el nivel
                miNivelAbstraccion.DefinirUMLRespuesta("Tamaño", "Material", "", "Abrir()", "");
                //Posiciona y carga personajes del juagador y enemigo
                miPersonaje.AjustarPersonaje(240, 349, playerCharacter);
                miPersonaje.AnimarPersonaje("Jugador", "Estatico", playerCharacter);
                miPersonaje.AjustarPersonaje(564, 355, enemyCharacter);
                miPersonaje.AnimarPersonaje("Enemigo", "Morado", enemyCharacter);
            }//Abstraccion 2 Lv2
            if (miNivel.Numero == 3)
            {
                //Define la categoria del Nivel  y oculta elementos de otras categorias
                miNivel.Categoria = "Abstraccion";
                //ReproducirAudio("Level");
                //Muestra Imagen de Fondo para el Nivel
                this.BackgroundImage = ProyectoFinal.Properties.Resources.Screen_Level3;
                //Posiciona la HitBox del objeto editable
                miNivel.PosicionarObjetoInteractuable("Reloj", 475, 310, 50, 120, btn_ObjetoInteractuable);
                //Imprime en pantalla la caja de dialogo
                miNivel.ImprimirCajaDeDialogo("Completa el Reloj, necesita atributos para su hora"+"\n"+"y minuto, ademas de un metodo para contar...", lblPista, pnlCajaDeDialogo);
                //Prepara el UML editable mostrado al usuario
                miNivel.ImprimirUML("Reloj", "", "", "", "", "", lblUMLTitulo, txtUMLAtributo1, txtUMLAtributo2, txtUMLAtributo3, txtUMLMetodo1, txtUMLMetodo2);
                //Define la respuesta esperada para el nivel
                miNivelAbstraccion.DefinirUMLRespuesta("Hora", "Minuto", "", "Contar()", "");
                //Posiciona y carga personajes del juagador y enemigo
                miPersonaje.AjustarPersonaje(240, 349, playerCharacter);
                miPersonaje.AnimarPersonaje("Jugador", "Estatico", playerCharacter);
                miPersonaje.AjustarPersonaje(564, 355, enemyCharacter);
                miPersonaje.AnimarPersonaje("Enemigo", "Rojo", enemyCharacter);
            }//Abstraccion 3 Lv3
            if (miNivel.Numero == 4)
            {
                //Define la categoria del Nivel
                miNivel.Categoria = "Herencia";
                //ReproducirAudio("Level");
                //Muestra Imagen de Fondo para el Nivel
                this.BackgroundImage = ProyectoFinal.Properties.Resources.Screen_Level4;
                //Posiciona la HitBox del objeto editable
                miNivel.PosicionarObjetoInteractuable("Carreta", 555, 365, 120, 59, btn_ObjetoInteractuable);
                //Imprime en pantalla la caja de dialogo
                miNivel.ImprimirCajaDeDialogo("La Herencia ayuda a tomar propiedades de otras clases de"+"\n"+ "objetos con los cuales se pueden agrupar. Haz que la" + "\n" + "carreta herede de la clase correcta...", lblPista, pnlCajaDeDialogo);
                //Prepara el UML editable mostrado al usuario
                miNivel.ImprimirUML("Carreta", "Carga", "", "", "", "", lblUMLTitulo, txtUMLAtributo1, txtUMLAtributo2, txtUMLAtributo3, txtUMLMetodo1, txtUMLMetodo2);
                //Define las respuestas posibles y la correcta para el nivel
                miNivelHerencia.ImprimirUMLHerencia("Persona", "Vehiculo", "Alimento","Vehiculo", cmbHerenciaUMLTitulo);
                miNivelHerencia.DefinirUMLPosiblesHerencias("Nombre", "Edad", "Caminar()", "Llantas", "Tamaño", "Avanzar()", "Color", "Sabor", "Consumir()");
                //Posiciona y carga personajes del juagador y enemigo
                miPersonaje.AjustarPersonaje(240, 289, playerCharacter);
                miPersonaje.AnimarPersonaje("Jugador", "Estatico", playerCharacter);
                miPersonaje.AjustarPersonaje(824, 355, enemyCharacter);
                miPersonaje.AnimarPersonaje("Enemigo", "Azul", enemyCharacter);
            }//Herencia 1 Lv4
            if (miNivel.Numero == 5)
            {
                //Define la categoria del Nivel
                miNivel.Categoria = "Herencia";
                //ReproducirAudio("Level");
                //Muestra Imagen de Fondo para el Nivel
                this.BackgroundImage = ProyectoFinal.Properties.Resources.Screen_Level5;
                //Posiciona la HitBox del objeto editable
                
                miNivel.PosicionarObjetoInteractuable("Candil", 475, 120, 50, 200, btn_ObjetoInteractuable);
                //Imprime en pantalla la caja de dialogo
                miNivel.ImprimirCajaDeDialogo("Haz que el Candil herede la clase correcta...", lblPista, pnlCajaDeDialogo);
                //Prepara el UML editable mostrado al usuario
                miNivel.ImprimirUML("Candil", "Velas", "Cadena", "", "", "", lblUMLTitulo, txtUMLAtributo1, txtUMLAtributo2, txtUMLAtributo3, txtUMLMetodo1, txtUMLMetodo2);
                //Define las respuestas posibles y la correcta para el nivel
                miNivelHerencia.ImprimirUMLHerencia("Vehiculo", "Contenedor", "Lampara", "Lampara", cmbHerenciaUMLTitulo);
                miNivelHerencia.DefinirUMLPosiblesHerencias("LLantas", "Tamaño", "Avanzar()", "Peso", "Capacidad", "Llenar()", "Estilo", "Iluminacion", "Encender()");
                //Posiciona y carga personajes del juagador y enemigo
                miPersonaje.AjustarPersonaje(240, 349, playerCharacter);
                miPersonaje.AnimarPersonaje("Jugador", "Estatico", playerCharacter);
                miPersonaje.AjustarPersonaje(824, 355, enemyCharacter);
                miPersonaje.AnimarPersonaje("Enemigo", "Aqua", enemyCharacter);
            }//Herencia 2 Lv5 
            if (miNivel.Numero == 6)
            {
                //Define la categoria del Nivel
                miNivel.Categoria = "Encapsulamiento";
                //ReproducirAudio("Level");
                //Muestra Imagen de Fondo para el Nivel
                this.BackgroundImage = ProyectoFinal.Properties.Resources.Screen_Level6;
                //Posiciona la HitBox del objeto editable
                miNivel.PosicionarObjetoInteractuable("Cofre", 510, 320, 50, 50, btn_ObjetoInteractuable);
                //Imprime en pantalla la caja de dialogo
                miNivel.ImprimirCajaDeDialogo("El Encapsulamiento permite definir la accesibilidad de los"+"\n"+ "atributos. Publico(+) es visible al exterior y privado(-)" + "\n" + "es solo internamente. Encapsula los atributos del Cofre...", lblPista, pnlCajaDeDialogo);
                //Prepara el UML editable mostrado al usuario
                miNivel.ImprimirUML("Cofre", "Capacidad", "Candado", "Contenido", "Abrir()", "", lblUMLTitulo, txtUMLAtributo1, txtUMLAtributo2, txtUMLAtributo3, txtUMLMetodo1, txtUMLMetodo2);
                //Define las respuestas para el nivel
                miNivelEncapsulamiento.DefinirCapsulas("Publico", "Publico", "Privado");
                //Posiciona y carga personajes del juagador y enemigo
                miPersonaje.AjustarPersonaje(240, 349, playerCharacter);
                miPersonaje.AnimarPersonaje("Jugador", "Estatico", playerCharacter);
                miPersonaje.AjustarPersonaje(824, 355, enemyCharacter);
                miPersonaje.AnimarPersonaje("Enemigo", "Verde", enemyCharacter);
            }//Encapsulamiento 1 Lv6
            if (miNivel.Numero == 7)
            {
                //Define la categoria del Nivel
                miNivel.Categoria = "Polimorfismo";
                //ReproducirAudio("Level");
                //Muestra Imagen de Fondo para el Nivel
                this.BackgroundImage = ProyectoFinal.Properties.Resources.Screen_Level7;
                //Posiciona la HitBox del objeto editable
                miNivel.PosicionarObjetoInteractuable("Cofre", 510, 320, 50, 50, btn_ObjetoInteractuable);
                //Imprime en pantalla la caja de dialogo
                miNivel.ImprimirCajaDeDialogo("El Polimorfismo permite redifinir metodos con un mismo"+"\n"+ "nombre, con una diferente funcion. En el Caldero" + "\n" + "selecciona el metodo para llenarlo con pociones magicas...", lblPista, pnlCajaDeDialogo);
                //Prepara el UML editable mostrado al usuario
                miNivel.ImprimirUML("Caldero", "Capacidad", "Material", "", "Llenar(Agua)", "Llenar(Pocion)", lblUMLTitulo, txtUMLAtributo1, txtUMLAtributo2, txtUMLAtributo3, txtUMLMetodo1, txtUMLMetodo2);
                //Define la respuesta esperada para el nivel
                miNivelPolimorfismo.DefinirMetodoPoliCorrecto(2);
                //Posiciona y carga personajes del juagador y enemigo
                miPersonaje.AjustarPersonaje(240, 349, playerCharacter);
                miPersonaje.AnimarPersonaje("Jugador", "Estatico", playerCharacter);
                miPersonaje.AjustarPersonaje(564, 295, enemyCharacter);
                miPersonaje.AnimarPersonaje("Enemigo", "Morado", enemyCharacter);
            }//Polimorfimso 1 Lv7
            if (miNivel.Numero == 8)
            {
                //Define la categoria del Nivel
                miNivel.Categoria = "Final";
                ReproducirAudio("Boss");
                //Muestra Imagen de Fondo para el Nivel
                this.BackgroundImage = ProyectoFinal.Properties.Resources.Screen_LevelFinal;
                //Posiciona la HitBox del objeto editable
                miNivel.PosicionarObjetoInteractuable("Llave", 670, 350, 50, 80, btn_ObjetoInteractuable);
                //Imprime en pantalla la caja de dialogo
                miNivel.ImprimirCajaDeDialogo("Agrega atributos para posicion, dueño y clave, haz privado"+"\n"+"dueño y clave, hereda la clase correcta y usa el metodo" + "\n" + "para cerrar la Programazmorra de los Bugs para SIEMPRE...", lblPista, pnlCajaDeDialogo);
                //Prepara el UML editable mostrado al usuario
                miNivel.ImprimirUML("Llave Oro", "", "", "", "Cerrar()", "Cerrar(Tiempo)", lblUMLTitulo, txtUMLAtributo1, txtUMLAtributo2, txtUMLAtributo3, txtUMLMetodo1, txtUMLMetodo2);
                
                //Define la respuesta esperada para el nivel
                miNivelAbstraccion.DefinirUMLRespuesta("Posicion", "Dueño", "Clave", "Cerrar()", "Cerrar(Tiempo)");
                
                miNivelHerencia.ImprimirUMLHerencia("Persona", "Llave", "Alimento", "Llave", cmbHerenciaUMLTitulo);
                miNivelHerencia.DefinirUMLPosiblesHerencias("Nombre", "Edad", "Caminar()", "Tamaño", "Forma", "", "Color", "Sabor", "Consumir()");

                miNivelEncapsulamiento.DefinirCapsulas("Publico", "Privado", "Privado");

                miNivelPolimorfismo.DefinirMetodoPoliCorrecto(2);
                //Posiciona y carga personajes del juagador y enemigo
                miPersonaje.AjustarPersonaje(140, 349, playerCharacter);
                miPersonaje.AnimarPersonaje("Jugador", "Estatico", playerCharacter);
                enemyCharacter.Visible = false;
            }//Todos los Temas Lv8
            if (miNivel.Numero >= 9)
            {
                miNivel.Categoria = "Menu";
                pb_TitleScreen.Image = ProyectoFinal.Properties.Resources.Screen_End;
                ReproducirAudio("MenuMusicReprise");

            }//Menu de Inicio

            //Valida la Categoria del Nivel para habilitar los controles necesarios
            if (miNivel.Categoria == "Abstraccion")
            {
                txtUMLAtributo1.Enabled = true;
                txtUMLAtributo2.Enabled = true;
                txtUMLAtributo3.Enabled = true;
                txtUMLMetodo1.Enabled = true;
                txtUMLMetodo2.Enabled = true;

                btnHerencia.Visible = false;
                cbCapsulaA1.Visible = false;
                cbCapsulaA2.Visible = false;
                cbCapsulaA3.Visible = false;
                rbMetodoPoli1.Visible = false;
                rbMetodoPoli2.Visible = false;

                btn_Comenzar.Visible = false;
                pb_TitleScreen.Visible = false;
                btnLeaderboard.Visible = false;
            }
            if (miNivel.Categoria == "Herencia")
            {
                btnHerencia.Visible = true;

                txtUMLAtributo1.Enabled = false;
                txtUMLAtributo2.Enabled = false;
                txtUMLAtributo3.Enabled = false;
                txtUMLMetodo1.Enabled = false;
                txtUMLMetodo2.Enabled = false;
                cbCapsulaA1.Visible = false;
                cbCapsulaA2.Visible = false;
                cbCapsulaA3.Visible = false;
                rbMetodoPoli1.Visible = false;
                rbMetodoPoli2.Visible = false;

                btn_Comenzar.Visible = false;
                pb_TitleScreen.Visible = false;
                btnLeaderboard.Visible = false;
            }
            if (miNivel.Categoria == "Encapsulamiento")
            {
                cbCapsulaA1.Visible = true;
                cbCapsulaA2.Visible = true;
                cbCapsulaA3.Visible = true;

                txtUMLAtributo1.Enabled = false;
                txtUMLAtributo2.Enabled = false;
                txtUMLAtributo3.Enabled = false;
                txtUMLMetodo1.Enabled = false;
                txtUMLMetodo2.Enabled = false;
                btnHerencia.Visible = false;
                rbMetodoPoli1.Visible = false;
                rbMetodoPoli2.Visible = false;

                btn_Comenzar.Visible = false;
                pb_TitleScreen.Visible = false;
                btnLeaderboard.Visible = false;
            }
            if (miNivel.Categoria == "Polimorfismo")
            {
                rbMetodoPoli1.Visible = true;
                rbMetodoPoli2.Visible = true;

                txtUMLAtributo1.Enabled = false;
                txtUMLAtributo2.Enabled = false;
                txtUMLAtributo3.Enabled = false;
                txtUMLMetodo1.Enabled = false;
                txtUMLMetodo2.Enabled = false;
                btnHerencia.Visible = false;
                cbCapsulaA1.Visible = false;
                cbCapsulaA2.Visible = false;
                cbCapsulaA3.Visible = false;

                btn_Comenzar.Visible = false;
                pb_TitleScreen.Visible = false;
                btnLeaderboard.Visible = false;
            }
            if (miNivel.Categoria == "Menu")
            {
                btn_Comenzar.Visible = true;
                pb_TitleScreen.Visible = true;
                btnLeaderboard.Visible = true;

                pnlUML.Visible = false;
                btn_ObjetoInteractuable.Visible = false;
                playerCharacter.Visible = false;
                enemyCharacter.Visible = false;
                btnCargar.Visible = false;
                
            }
            if (miNivel.Categoria == "Final")
            {
                txtUMLAtributo1.Enabled = true;
                txtUMLAtributo2.Enabled = true;
                txtUMLAtributo3.Enabled = true;
                btnHerencia.Visible = true;
                cbCapsulaA1.Visible = true;
                cbCapsulaA2.Visible = true;
                cbCapsulaA3.Visible = true;
                rbMetodoPoli1.Visible = true;
                rbMetodoPoli2.Visible = true;

                txtUMLMetodo1.Enabled = false;
                txtUMLMetodo2.Enabled = false;
                btn_Comenzar.Visible = false;
                pb_TitleScreen.Visible = false;
                btnLeaderboard.Visible = false;
            }
        }

        // Reproduce efecto de sonido/Musica
        private void ReproducirAudio(string Audio) // Reproduce efecto de sonido/Musica
        {
            if (Audio == "MenuMusic")
            {
                SoundPlayer audio = new SoundPlayer(ProyectoFinal.Properties.Resources.conjure_the_wicked);
                audio.Play();
            }
            if (Audio == "TExito")
            {
                SoundPlayer seffect = new SoundPlayer(ProyectoFinal.Properties.Resources.success);
                seffect.Play();
            }
            if (Audio == "TMagia")
            {
                SoundPlayer seffect = new SoundPlayer(ProyectoFinal.Properties.Resources.interact);
                seffect.Play();
            }
            if (Audio == "Level")
            {
                SoundPlayer audio = new SoundPlayer(ProyectoFinal.Properties.Resources.scarlet_pain);
                audio.PlayLooping();
            }
            if (Audio == "Boss")
            {
                SoundPlayer audio = new SoundPlayer(ProyectoFinal.Properties.Resources.the_last_bow);
                audio.Play();
            }
            if (Audio == "MenuMusicReprise")
            {
                SoundPlayer audio = new SoundPlayer(ProyectoFinal.Properties.Resources.conjure_the_wicked_reprise);
                audio.Play();
            }
        }

        //Abrir Diagrama UML de Objeto
        private void btn_ObjetoInteractuable_Click_1(object sender, EventArgs e)
        {
            //Muestra animacion del Personaje del Jugador
            miPersonaje.AnimarPersonaje("Jugador", "Magia", playerCharacter);
            ReproducirAudio("Magia");

            //Habilita el Diagrama UML Editable
            pnlUML.Visible = true;
        }

        //Solucionar el Ejercicio
        private void btnSolucionar_Click(object sender, EventArgs e)
        {
            //Muestra animacion del Personaje del Jugador
            miPersonaje.AnimarPersonaje("Jugador", "Magia", playerCharacter);
            ReproducirAudio("Magia");

            //Valida la Catergoria del Nivel para metodo de resolucion
            if (miNivel.Categoria == "Abstraccion")
            {
                //Valida la respuesta del jugador
                try
                {
                    if (txtUMLAtributo1.Text == miNivelAbstraccion.Atributo1 && txtUMLAtributo2.Text == miNivelAbstraccion.Atributo2 && txtUMLAtributo3.Text == miNivelAbstraccion.Atributo3 && txtUMLMetodo1.Text == miNivelAbstraccion.Metodo1 && txtUMLMetodo2.Text == miNivelAbstraccion.Metodo2)
                    {
                        miNivel.ImprimirCajaDeDialogo("Bien Hecho!", lblPista, pnlCajaDeDialogo); //Escribe mensaje de victoria
                        miPersonaje.AnimarPersonaje("Enemigo", "Muerto", enemyCharacter); //Cambia el personaje enemigo a Animacion de Muerte
                        miNivel.Numero = miNivel.Numero + 1; //Aumenta el numero de nivel
                        btnSolucionar.Visible = false; //Oculta el boton Solucionar
                        btnCargar.BackgroundImage = ProyectoFinal.Properties.Resources.GUI_NextButton; //Cambia la Imagen del Boton de Carga a Continuar
                        ReproducirAudio("Exito");
                        misPuntos.Puntos = misPuntos.Puntos + 150;
                    }
                    else
                    {
                        miNivel.ImprimirCajaDeDialogo("Algo esta mal. Vuelve a Intentar!", lblPista, pnlCajaDeDialogo); //Escribe mensaje de fallo
                        misPuntos.Puntos = misPuntos.Puntos - 50;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha Ocurrido un Error!", "Error");
                }

            }
            //Valida la Catergoria del Nivel para metodo de resolucion
            if (miNivel.Categoria == "Herencia")
            {
                //Valida la respuesta del jugador
                if (cmbHerenciaUMLTitulo.Text == miNivelHerencia.HerenciaTituloCorrecto)
                {
                    miNivel.ImprimirCajaDeDialogo("Bien Hecho!", lblPista, pnlCajaDeDialogo); //Escribe mensaje de victoria
                    miPersonaje.AnimarPersonaje("Enemigo", "Muerto", enemyCharacter); //Cambia el personaje enemigo a Animacion de Muerte
                    miNivel.Numero = miNivel.Numero + 1; //Aumenta el numero de nivel
                    btnSolucionar.Visible = false; //Oculta el boton Solucionar
                    btnCargar.BackgroundImage = ProyectoFinal.Properties.Resources.GUI_NextButton; //Cambia la Imagen del Boton de Carga a Continuar
                    ReproducirAudio("Exito");
                    misPuntos.Puntos = misPuntos.Puntos + 150;
                }
                else
                {
                    miNivel.ImprimirCajaDeDialogo("Algo esta mal. Vuelve a Intentar!", lblPista, pnlCajaDeDialogo); //Escribe mensaje de fallo
                    misPuntos.Puntos = misPuntos.Puntos - 50;
                }
            }
            //Valida la Catergoria del Nivel para metodo de resolucion
            if (miNivel.Categoria == "Encapsulamiento")
            {
                if (miNivelEncapsulamiento.Capsula1 == miNivelEncapsulamiento.CapsulaCorrecta1 && miNivelEncapsulamiento.Capsula2 == miNivelEncapsulamiento.CapsulaCorrecta2 && miNivelEncapsulamiento.Capsula3 == miNivelEncapsulamiento.CapsulaCorrecta3)
                {
                    miNivel.ImprimirCajaDeDialogo("Bien Hecho!", lblPista, pnlCajaDeDialogo); //Escribe mensaje de victoria
                    miPersonaje.AnimarPersonaje("Enemigo", "Muerto", enemyCharacter); //Cambia el personaje enemigo a Animacion de Muerte
                    miNivel.Numero = miNivel.Numero + 1; //Aumenta el numero de nivel
                    btnSolucionar.Visible = false; //Oculta el boton Solucionar
                    btnCargar.BackgroundImage = ProyectoFinal.Properties.Resources.GUI_NextButton; //Cambia la Imagen del Boton de Carga a Continuar
                    ReproducirAudio("Exito");
                    misPuntos.Puntos = misPuntos.Puntos + 150;
                }
                else
                {
                    miNivel.ImprimirCajaDeDialogo("Algo esta mal. Vuelve a Intentar!", lblPista, pnlCajaDeDialogo); //Escribe mensaje de fallo
                    misPuntos.Puntos = misPuntos.Puntos - 50;
                }
            }
            //Valida la Catergoria del Nivel para metodo de resolucion
            if (miNivel.Categoria == "Polimorfismo")
            {
                if (miNivelPolimorfismo.MetodoPoli == miNivelPolimorfismo.MetodoPoliCorrecto)
                {
                    miNivel.ImprimirCajaDeDialogo("Bien Hecho!", lblPista, pnlCajaDeDialogo); //Escribe mensaje de victoria
                    miPersonaje.AnimarPersonaje("Enemigo", "Muerto", enemyCharacter); //Cambia el personaje enemigo a Animacion de Muerte
                    miNivel.Numero = miNivel.Numero + 1; //Aumenta el numero de nivel
                    btnSolucionar.Visible = false; //Oculta el boton Solucionar
                    btnCargar.BackgroundImage = ProyectoFinal.Properties.Resources.GUI_NextButton; //Cambia la Imagen del Boton de Carga a Continuar
                    ReproducirAudio("Exito");
                    misPuntos.Puntos = misPuntos.Puntos + 150;
                }
                else
                {
                    miNivel.ImprimirCajaDeDialogo("Algo esta mal. Vuelve a Intentar!", lblPista, pnlCajaDeDialogo); //Escribe mensaje de fallo
                    misPuntos.Puntos = misPuntos.Puntos - 50;
                }
            }
            if (miNivel.Categoria == "Final")
            {
                if (txtUMLAtributo1.Text == miNivelAbstraccion.Atributo1 && txtUMLAtributo2.Text == miNivelAbstraccion.Atributo2 && txtUMLAtributo3.Text == miNivelAbstraccion.Atributo3 && txtUMLMetodo1.Text == miNivelAbstraccion.Metodo1 && txtUMLMetodo2.Text == miNivelAbstraccion.Metodo2)
                {
                    if (cmbHerenciaUMLTitulo.Text == miNivelHerencia.HerenciaTituloCorrecto)
                    {
                        if (miNivelEncapsulamiento.Capsula1 == miNivelEncapsulamiento.CapsulaCorrecta1 && miNivelEncapsulamiento.Capsula2 == miNivelEncapsulamiento.CapsulaCorrecta2 && miNivelEncapsulamiento.Capsula3 == miNivelEncapsulamiento.CapsulaCorrecta3)
                        {
                            if (miNivelPolimorfismo.MetodoPoli == miNivelPolimorfismo.MetodoPoliCorrecto)
                            {
                                miNivel.ImprimirCajaDeDialogo("Excelente. Buen trabajo!", lblPista, pnlCajaDeDialogo); //Escribe mensaje de victoria
                                miNivel.Numero = miNivel.Numero + 1; //Aumenta el numero de nivel
                                btnSolucionar.Visible = false; //Oculta el boton Solucionar
                                btnCargar.BackgroundImage = ProyectoFinal.Properties.Resources.GUI_NextButton; //Cambia la Imagen del Boton de Carga a Continuar
                                ReproducirAudio("Exito");
                                misPuntos.Puntos = misPuntos.Puntos + 300;
                            }
                            else
                            {
                                miNivel.ImprimirCajaDeDialogo("Algo esta mal, revisa y vuelve a Intentar", lblPista, pnlCajaDeDialogo); //Escribe mensaje de fallo
                                misPuntos.Puntos = misPuntos.Puntos - 70;
                            }
                        }
                        else
                        {
                            miNivel.ImprimirCajaDeDialogo("Algo esta mal, revisa y vuelve a Intentar", lblPista, pnlCajaDeDialogo); //Escribe mensaje de fallo
                            misPuntos.Puntos = misPuntos.Puntos - 70;
                        }
                    }
                    else
                    {
                        miNivel.ImprimirCajaDeDialogo("Algo esta mal, revisa y vuelve a Intentar", lblPista, pnlCajaDeDialogo); //Escribe mensaje de fallo
                        misPuntos.Puntos = misPuntos.Puntos - 70;
                    }
                }
                else
                {
                    miNivel.ImprimirCajaDeDialogo("Algo esta mal, revisa y vuelve a Intentar", lblPista, pnlCajaDeDialogo); //Escribe mensaje de fallo
                    misPuntos.Puntos = misPuntos.Puntos - 70;
                }
            }
        }

        //Cargar el siguiente nivel/ Recargar el Nivel Actual
        private void btnCargar_Click(object sender, EventArgs e)
        {
            cmbHerenciaUMLTitulo.Items.Clear();
            txtHerenciaAtributo1.Text = "";
            txtHerenciaAtributo2.Text = "";
            txtHerenciaAtributo3.Text = "";
            txtHerenciaMetodo1.Text = "";
            txtHerenciaMetodo2.Text = "";
            CargarPantalla(); //Llama el Metodo CargarPantalla() para mostrar el nivel en pantalla
            btnSolucionar.Visible = true; //Habilita el boton solucionar
            
            btnCargar.BackgroundImage = ProyectoFinal.Properties.Resources.GUI_RetryButton; //Cambia la Imagen del Boton de Carga a Reintentar
        
        }

        //Cargar el primer nivel desde la pantalla de Inicio
        private void btn_Comenzar_Click(object sender, EventArgs e)
        {
            pnlUML.Visible = true;
            btn_ObjetoInteractuable.Visible = true;
            playerCharacter.Visible = true;
            enemyCharacter.Visible = true;
            btnCargar.Visible = true;
            miNivel.Numero = 1; //Nivel que se ejecuta al iniciar
            SoundPlayer audio = new SoundPlayer(ProyectoFinal.Properties.Resources.conjure_the_wicked);
            audio.Stop();
            misPuntos.Puntos = 0;
            CargarPantalla();
        }

        //Mostrar Panel de Herencia
        private void btnHerencia_Click(object sender, EventArgs e)
        {
            //Muestra animacion del Personaje del Jugador
            miPersonaje.AnimarPersonaje("Jugador", "Magia", playerCharacter);

            //Mostrar Panel de Herencia
            pnlHerencia.Visible = true;
        }

        //Imprime en el diagrama de Herencia los atributos y metodos correctos segun el titulo seleccionado
        private void cmbHerenciaUMLTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHerenciaUMLTitulo.Text == miNivelHerencia.HerenciaTitulo1)
            {
                miNivelHerencia.ImprimirUMLHerencia(1, txtHerenciaAtributo1, txtHerenciaAtributo2, txtHerenciaMetodo1);
            }
            if (cmbHerenciaUMLTitulo.Text == miNivelHerencia.HerenciaTitulo2)
            {
                miNivelHerencia.ImprimirUMLHerencia(2, txtHerenciaAtributo1, txtHerenciaAtributo2, txtHerenciaMetodo1);
            }
            if (cmbHerenciaUMLTitulo.Text == miNivelHerencia.HerenciaTitulo3)
            {
                miNivelHerencia.ImprimirUMLHerencia(3, txtHerenciaAtributo1, txtHerenciaAtributo2, txtHerenciaMetodo1);
            }
        }

        //Capturan Respuestas de Encapsulamiento
        private void cbCapsulaA1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCapsulaA1.Checked)
            {
                cbCapsulaA1.Image = ProyectoFinal.Properties.Resources.GUI_Public;
                miNivelEncapsulamiento.Capsula1 = "Publico";
            }
            else
            {
                cbCapsulaA1.Image = ProyectoFinal.Properties.Resources.GUI_Private;
                miNivelEncapsulamiento.Capsula1 = "Privado";
            }
        }
        private void cbCapsulaA2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCapsulaA2.Checked)
            {
                cbCapsulaA2.Image = ProyectoFinal.Properties.Resources.GUI_Public;
                miNivelEncapsulamiento.Capsula2 = "Publico";
            }
            else
            {
                cbCapsulaA2.Image = ProyectoFinal.Properties.Resources.GUI_Private;
                miNivelEncapsulamiento.Capsula2 = "Privado";
            }
        }
        private void cbCapsulaA3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCapsulaA3.Checked)
            {
                cbCapsulaA3.Image = ProyectoFinal.Properties.Resources.GUI_Public;
                miNivelEncapsulamiento.Capsula3 = "Publico";
            }
            else
            {
                cbCapsulaA3.Image = ProyectoFinal.Properties.Resources.GUI_Private;
                miNivelEncapsulamiento.Capsula3 = "Privado";
            }
        }

        //Capturan Respuestas de Polimorfimso
        private void rbMetodoPoli1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMetodoPoli1.Checked)
            {
                miNivelPolimorfismo.MetodoPoli = 1;
            }
        }
        private void rbMetodoPoli2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMetodoPoli2.Checked)
            {
                miNivelPolimorfismo.MetodoPoli = 2;
            }
        }

        //Muestra la Pantalla de Puntos
        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            int miId = misPuntos.GenerarID();
            Form form3 = new Form3(misPuntos.Puntos, miId);
            form3.Show();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void playerCharacter_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void pnlUML_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}