using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//el punto IO es una libreria que permite abrir y leer bloc de notas

namespace interfas
{
    public partial class nivel1 : Form
    {
        int[,] matrizposiciones = new int[15, 22];
        int[] callesnivel1 = new int[6];
        int[] tipocarro = new int[5];

        bool win = false;
        int puntaje = 0;
        int segundosnivel1 = 180;
        int segundosjugados = 0;
        int personajex = 9;
        int personajey = 10;
        const int mario = 0;
        const int carroamarillo = 1;
        const int carroazul = 2;
        const int carroverde = 3;
        const int carrorojo = 4;
        const int carronegro = 5;
        const int calle = 6;
        const int sesped = 7;
        const int peach = 8;
        const int yoshi = 9;
        const int agente = 10;
        const int rayado = 11;
        const int semafororojo = 12;
        const int semaforoverde = 13;
        const int mario_yoshi = 14;
        const int mario_peach = 15;
        const int atropellado = 16;
        const int negro = 17;
        const int gano = 18;
        int limitex = 21;
        int iniciox = 1;

        bool tieneanciano = false;
        bool tienemascota = false;
        int caminaancianoderecha = 0;
        int caminamascotaderecha = 0;
        int caminaancianoizquierda = 0;
        int caminamascotaizquierda = 0;
        int caminaancianoarriba = 0;
        int caminamascotaarriba = 0;
        int caminaancianoabajo = 0;
        int caminamascotaabajo = 0;
        int valorencima = sesped;
        private int limitey = 11;
        private int inicioy = 1;
        Form1 _1;

        public nivel1(Form1 form)
        {
            InitializeComponent();
            _1 = form;
            this.KeyPreview = true;

            callesnivel1[0] = 2;
            callesnivel1[1] = 3;
            callesnivel1[2] = 4;
            callesnivel1[3] = 7;
            callesnivel1[4] = 8;
            callesnivel1[5] = 9;

            tipocarro[0] = carroamarillo;
            tipocarro[1] = carroazul;
            tipocarro[2] = carroverde;
            tipocarro[3] = carrorojo;
            tipocarro[4] = carronegro;
        }


        public void movercarro(Carro carro)
        {
            int siguiente = 0;
            switch (carro.tipocarro)
            {
                case carroazul: 
                    {
                        if (carro.posx < limitex)
                        {
                            siguiente = matrizposiciones[carro.posy, carro.posx + 1];
                            if (siguiente == mario)
                            {
                                //se restan los puntos (la funcion regresa negativos)
                                puntaje += carro.choque(false);
                                label1.Text = "Puntaje: " + puntaje.ToString();
                                Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[atropellado];
                                matrizposiciones[personajey, personajex] = atropellado;
                                if (carro.posx < limitex - 2)
                                {
                                    siguiente = matrizposiciones[carro.posy, carro.posx + 2];
                                    if (siguiente == calle)
                                    {
                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                        matrizposiciones[carro.posy, carro.posx] = calle;
                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 2].Value = imageList2.Images[carro.tipocarro];
                                        matrizposiciones[carro.posy, carro.posx + 2] = carro.tipocarro;
                                    }
                                    else if (siguiente == semaforoverde)
                                    {

                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                        matrizposiciones[carro.posy, carro.posx] = calle;
                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 2].Value = imageList2.Images[semaforoverde];
                                        matrizposiciones[carro.posy, carro.posx + 2] = semaforoverde;
                                    }
                                }

                            }
                            else if (carro.posx == 20)
                            {
                                Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                matrizposiciones[carro.posy, carro.posx] = calle;
                            }
                            else if (siguiente == calle)
                            {
                                Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 1].Value = imageList2.Images[carro.tipocarro];
                                matrizposiciones[carro.posy, carro.posx + 1] = carro.tipocarro;
                            }
                            else if (siguiente == semaforoverde)
                            {
                                siguiente = matrizposiciones[carro.posy, carro.posx + 2];
                                if(siguiente == calle)
                                {
                                    Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                    matrizposiciones[carro.posy, carro.posx] = calle;
                                    Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 2].Value = imageList2.Images[carro.tipocarro];
                                    matrizposiciones[carro.posy, carro.posx + 2] = carro.tipocarro;
                                }
                            }
                            else if (siguiente == atropellado)
                            {
                                puntaje += carro.choque(false);
                                label1.Text = "Puntaje: " + puntaje.ToString();
                                Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[atropellado];
                                matrizposiciones[personajey, personajex] = atropellado;
                                if (carro.posx < limitex - 2)
                                {
                                    siguiente = matrizposiciones[carro.posy, carro.posx + 2];
                                    if (siguiente == calle)
                                    {
                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                        matrizposiciones[carro.posy, carro.posx] = calle;
                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 2].Value = imageList2.Images[carro.tipocarro];
                                        matrizposiciones[carro.posy, carro.posx + 2] = carro.tipocarro;
                                    }
                                    else if (siguiente == semaforoverde)
                                    {

                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                        matrizposiciones[carro.posy, carro.posx] = calle;
                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 1].Value = imageList2.Images[semaforoverde];
                                        matrizposiciones[carro.posy, carro.posx + 1] = semaforoverde;
                                    }
                                }
                            }
                        }
                    }
                    break;
                case carronegro: 
                    {
                        bool semovio = false;
                        // el carro busca subir para alcanzar al jugador
                        ///como el personaje esta arriba significa que no hay validar los limites de Y
                        if (carro.posy > personajey)
                        {
                            siguiente = matrizposiciones[carro.posy - 1, carro.posx];
                            if (siguiente == calle)
                            {
                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[calle];
                                //carro subio en Y
                                carro.posy--;
                                matrizposiciones[carro.posy, carro.posx] = carro.tipocarro;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[carro.tipocarro];
                                semovio = true;
                                //se mueve para arriba ahora probara moverse para la derecha
                                Movercarroderechacarronegro(carro);
                            }
                            else if ((valorencima == calle) && ((siguiente == mario) || (siguiente == mario_peach) || (siguiente == mario_yoshi)))
                            {
                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[calle];
                                carro.posy--;
                                matrizposiciones[carro.posy, carro.posx] = atropellado;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[atropellado];
                                if ((tieneanciano == true) || (tienemascota == true))
                                {
                                    puntaje += carro.choque(true);
                                    label1.Text = "Puntaje: " + puntaje.ToString();
                                }
                                else
                                {
                                    puntaje += carro.choque(false);
                                    label1.Text = "Puntaje: " + puntaje.ToString();
                                }
                                semovio = true;
                            }
                            else
                            semovio = false;
                        }
                        //busca bajar para alcanzar al jugador
                        else if (carro.posy < personajey)
                        {
                            siguiente = matrizposiciones[carro.posy + 1, carro.posx];
                            if (siguiente == calle)
                            {

                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[calle];
                                carro.posy++;
                                matrizposiciones[carro.posy, carro.posx] = carro.tipocarro;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[carro.tipocarro];
                                //se mueve para abajo
                                semovio = true;
                                Movercarroderechacarronegro(carro);

                            }
                            else if ((valorencima == calle) && ((siguiente == mario) || (siguiente == mario_peach) || (siguiente == mario_yoshi)))
                            {
                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[calle];
                                carro.posy++;
                                matrizposiciones[carro.posy, carro.posx] = atropellado;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[atropellado];
                                semovio = true;
                                if ((tieneanciano == true) || (tienemascota == true))
                                {
                                    puntaje += carro.choque(true);
                                    label1.Text = "Puntaje: " + puntaje.ToString();
                                }
                                else
                                {
                                    puntaje += carro.choque(false);
                                    label1.Text = "Puntaje: " + puntaje.ToString();
                                }
                            }
                            else
                            {
                                semovio = false;
                            }
                        }
                        //le queda tratar mover a la derecha
                        if (semovio == false)
                        {
                            semovio = Movercarroderechacarronegro(carro);
                        }
                        if (semovio == false)
                        {

                            siguiente = matrizposiciones[carro.posy - 1, carro.posx];
                            if (siguiente == calle)
                            {
                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[calle];
                                //carro subio en Y
                                carro.posy--;
                                matrizposiciones[carro.posy, carro.posx] = carro.tipocarro;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[carro.tipocarro];
                                semovio = true;
                                Movercarroderechacarronegro(carro);
                            }
                            else
                            {
                                siguiente = matrizposiciones[carro.posy + 1, carro.posx];
                                if (siguiente == calle)
                                {
                                    matrizposiciones[carro.posy, carro.posx] = calle;
                                    Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[calle];
                                    //carro bajo en Y
                                    carro.posy++;
                                    matrizposiciones[carro.posy, carro.posx] = carro.tipocarro;
                                    Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[carro.tipocarro];
                                    semovio = true;
                                    Movercarroderechacarronegro(carro);
                                }
                            }
                        }

                    }
                    break;
                case carrorojo: 
                    {
                        bool semovio = false;
                        // el carro busca subir para alcanzar al jugador
                        ///como el personaje esta arriba significa que no hay validar los limites de Y
                        if (carro.posy > personajey)
                        {
                            siguiente = matrizposiciones[carro.posy - 1, carro.posx];
                            if (siguiente == calle)
                            {
                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[calle];
                                //carro subio en Y
                                carro.posy--;
                                matrizposiciones[carro.posy, carro.posx] = carro.tipocarro;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[carro.tipocarro];
                                semovio = true;
                                //se mueve para arriba ahora probara moverse para la derecha
                                semovio = Movimientocarrorojo(carro);
                            }
                            else if ((valorencima == calle) && ((siguiente == mario) || (siguiente == mario_peach) || (siguiente == mario_yoshi)))
                            {
                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[calle];
                                carro.posy--;
                                matrizposiciones[carro.posy, carro.posx] = atropellado;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[atropellado];
                                if ((tieneanciano == true) || (tienemascota == true))
                                {
                                    puntaje += carro.choque(true);
                                    label1.Text = "Puntaje: " + puntaje.ToString();
                                }
                                else
                                {
                                    puntaje += carro.choque(false);
                                    label1.Text = "Puntaje: " + puntaje.ToString();
                                }
                                semovio = true;
                            }
                            else
                                semovio = false;
                        }
                        //busca bajar para alcanzar al jugador
                        else if (carro.posy < personajey)
                        {
                            siguiente = matrizposiciones[carro.posy + 1, carro.posx];
                            if (siguiente == calle)
                            {

                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[calle];
                                carro.posy++;
                                matrizposiciones[carro.posy, carro.posx] = carro.tipocarro;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[carro.tipocarro];
                                //se mueve para abajo
                                semovio = true;
                                Movimientocarrorojo(carro);

                            }
                            else if ((valorencima == calle) && ((siguiente == mario) || (siguiente == mario_peach) || (siguiente == mario_yoshi)))
                            {
                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[calle];
                                carro.posy++;
                                matrizposiciones[carro.posy, carro.posx] = atropellado;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[atropellado];
                                semovio = true;
                                if ((tieneanciano == true) || (tienemascota == true))
                                {
                                    puntaje += carro.choque(true);
                                    label1.Text = "Puntaje: " + puntaje.ToString();
                                }
                                else
                                {
                                    puntaje += carro.choque(false);
                                    label1.Text = "Puntaje: " + puntaje.ToString();
                                }
                            }
                            else
                            {
                                semovio = false;
                            }
                        }
                        //le queda tratar mover a la derecha

                        if (semovio == false)
                        {
                            semovio = Movimientocarrorojo(carro);
                        }
                        if (semovio == false)
                        {

                            siguiente = matrizposiciones[carro.posy - 1, carro.posx];
                            if (siguiente == calle)
                            {
                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[calle];
                                //carro subio en Y
                                carro.posy--;
                                matrizposiciones[carro.posy, carro.posx] = carro.tipocarro;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[carro.tipocarro];
                                semovio = true;
                                semovio = Movimientocarrorojo(carro);
                            }
                            else
                            {
                                siguiente = matrizposiciones[carro.posy + 1, carro.posx];
                                if (siguiente == calle)
                                {
                                    matrizposiciones[carro.posy, carro.posx] = calle;
                                    Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[calle];
                                    //carro bajo en Y
                                    carro.posy++;
                                    matrizposiciones[carro.posy, carro.posx] = carro.tipocarro;
                                    Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[carro.tipocarro];
                                    semovio = true;
                                    semovio = Movimientocarrorojo(carro);
                                }
                            }
                        }

                    }
                    break;
                case carroamarillo: 
                    {
                        if (carro.posx < limitex)
                        {

                            siguiente = matrizposiciones[carro.posy, carro.posx + 1];

                            if (siguiente == mario)
                            {
                                puntaje += carro.choque(false);
                                label1.Text = "Puntaje: " + puntaje.ToString();
                                Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[atropellado];
                                matrizposiciones[personajey, personajex] = atropellado;
                                if (carro.posx < limitex - 2)
                                {
                                    siguiente = matrizposiciones[carro.posy, carro.posx + 2];
                                    if (siguiente == calle)
                                    {
                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                        matrizposiciones[carro.posy, carro.posx] = calle;
                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 2].Value = imageList2.Images[carro.tipocarro];
                                        matrizposiciones[carro.posy, carro.posx + 2] = carro.tipocarro;
                                    }
                                    else if (siguiente == semaforoverde)
                                    {

                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                        matrizposiciones[carro.posy, carro.posx] = calle;
                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 1].Value = imageList2.Images[semaforoverde];
                                        matrizposiciones[carro.posy, carro.posx + 1] = semaforoverde;
                                    }
                                }
                            }
                            else if (carro.posx == 20)
                            {
                                Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                matrizposiciones[carro.posy, carro.posx] = calle;
                            }
                            else if (siguiente == calle)
                            {

                                Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 1].Value = imageList2.Images[carro.tipocarro];
                                matrizposiciones[carro.posy, carro.posx + 1] = carro.tipocarro;
                            }
                            else if (siguiente == semaforoverde)
                            {
                                siguiente = matrizposiciones[carro.posy, carro.posx + 2];
                                if (siguiente == calle)
                                {
                                    Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                    matrizposiciones[carro.posy, carro.posx] = calle;
                                    Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 2].Value = imageList2.Images[carro.tipocarro];
                                    matrizposiciones[carro.posy, carro.posx + 2] = carro.tipocarro;
                                }
                            }
                            else if (siguiente == atropellado)
                            {
                                //se restan los puntos (la funcion regresa negativos)
                                puntaje += carro.choque(false);
                                label1.Text = "Puntaje: " + puntaje.ToString();
                                Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[atropellado];
                                matrizposiciones[personajey, personajex] = atropellado;
                                if (carro.posx < limitex - 2)
                                {
                                    siguiente = matrizposiciones[carro.posy, carro.posx + 2];
                                    if (siguiente == calle)
                                    {
                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                        matrizposiciones[carro.posy, carro.posx] = calle;
                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 2].Value = imageList2.Images[carro.tipocarro];
                                        matrizposiciones[carro.posy, carro.posx + 2] = carro.tipocarro;
                                    }
                                    else if (siguiente == semaforoverde)
                                    {

                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                        matrizposiciones[carro.posy, carro.posx] = calle;
                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 1].Value = imageList2.Images[semaforoverde];
                                        matrizposiciones[carro.posy, carro.posx + 1] = semaforoverde;
                                    }
                                }
                            }
                            else if (siguiente == mario_yoshi || siguiente  == mario_peach)
                            {
                                puntaje += carro.choque(true);
                                label1.Text = "Puntaje: " + puntaje.ToString();
                                Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[atropellado];
                                matrizposiciones[personajey, personajex] = atropellado;
                                if (carro.posx < limitex - 2)
                                {
                                    siguiente = matrizposiciones[carro.posy, carro.posx + 2];
                                    if (siguiente == calle)
                                    {
                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                        matrizposiciones[carro.posy, carro.posx] = calle;
                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 2].Value = imageList2.Images[carro.tipocarro];
                                        matrizposiciones[carro.posy, carro.posx + 2] = carro.tipocarro;
                                    }
                                    else if (siguiente == semaforoverde)
                                    {

                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                        matrizposiciones[carro.posy, carro.posx] = calle;
                                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 1].Value = imageList2.Images[semaforoverde];
                                        matrizposiciones[carro.posy, carro.posx + 1] = semaforoverde;
                                    }
                                }
                            }
                        }
                    }
                    break;
                case carroverde: 
                    {
                        if (carro.posx < limitex)
                        {
                            siguiente = matrizposiciones[carro.posy, carro.posx + 1];
                            if (carro.posx == 20)
                            {
                                Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                matrizposiciones[carro.posy, carro.posx] = calle;
                            }
                            else if (siguiente == calle)
                            {

                                Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 1].Value = imageList2.Images[carro.tipocarro];
                                matrizposiciones[carro.posy, carro.posx + 1] = carro.tipocarro;
                            }
                            else if (siguiente == semaforoverde)
                            {
                                siguiente = matrizposiciones[carro.posy, carro.posx + 2];
                                if (siguiente == calle)
                                {
                                    Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                                    matrizposiciones[carro.posy, carro.posx] = calle;
                                    Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 2].Value = imageList2.Images[carro.tipocarro];
                                    matrizposiciones[carro.posy, carro.posx + 2] = carro.tipocarro;
                                }
                            }
                        }
                    }
                    break;
            }
        }
        private bool Movercarroderechacarronegro(Carro carro) 
        {
            int siguiente = 0;
            bool semovio = false;
            if (carro.posx < limitex)
            {
                siguiente = matrizposiciones[carro.posy, carro.posx + 1];

                if (carro.posx == 20)
                {
                    Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                    matrizposiciones[carro.posy, carro.posx] = calle;
                }
                else if (siguiente == calle)
                {
                    matrizposiciones[carro.posy, carro.posx] = calle;
                    Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[calle];
                    carro.posx++;
                    matrizposiciones[carro.posy, carro.posx] = carro.tipocarro;
                    Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[carro.tipocarro];
                    semovio = true;
                }
                else if (siguiente == semaforoverde)
                {
                    siguiente = matrizposiciones[carro.posy, carro.posx + 2];
                    if (siguiente == calle)
                    {
                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                        matrizposiciones[carro.posy, carro.posx] = calle;
                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 2].Value = imageList2.Images[carro.tipocarro];
                        matrizposiciones[carro.posy, carro.posx + 2] = carro.tipocarro;
                        semovio = true;
                    }
                    else
                    {
                        semovio = false;
                    }
                }
                else if (siguiente == semafororojo)
                {
                    Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                    matrizposiciones[carro.posy, carro.posx] = calle;
                    Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 2].Value = imageList2.Images[carro.tipocarro];
                    matrizposiciones[carro.posy, carro.posx + 2] = carro.tipocarro;
                    semovio = true;
                }
                else if (((siguiente == mario) || (siguiente == mario_peach) || (siguiente == mario_yoshi)))
                {
                    matrizposiciones[carro.posy, carro.posx] = calle;
                    Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[calle];
                    carro.posx++;
                    matrizposiciones[carro.posy, carro.posx] = atropellado;
                    Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[atropellado];
                    semovio = true;
                    {
                        siguiente = matrizposiciones[carro.posy, carro.posx + 1];
                        if (siguiente == calle)
                        {
                            Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 1].Value = imageList2.Images[carro.tipocarro];
                            matrizposiciones[carro.posy, carro.posx + 1] = carro.tipocarro;
                        }
                        else if (siguiente == semaforoverde)
                        {
                            Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 2].Value = imageList2.Images[carro.tipocarro];
                            matrizposiciones[carro.posy, carro.posx + 2] = carro.tipocarro;
                        }
                    }
                    if ((tieneanciano == true) || (tienemascota == true))
                    {
                        puntaje += carro.choque(true);
                        label1.Text = "Puntaje: " + puntaje.ToString();
                    }
                    else
                    {
                        puntaje += carro.choque(false);
                        label1.Text = "Puntaje: " + puntaje.ToString();
                    }
                }
            }
            return semovio;
        }
        private bool Movimientocarrorojo(Carro carro) 
        {
            int siguiente = 0;
            bool semovio = false;
            if (carro.posx < limitex)
            {
                siguiente = matrizposiciones[carro.posy, carro.posx + 1];
                if (carro.posx == 20)
                {
                    Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                    matrizposiciones[carro.posy, carro.posx] = calle;
                }
                else if (siguiente == semafororojo)
                {
                    Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[carro.tipocarro];
                    matrizposiciones[carro.posy, carro.posx] = carro.tipocarro;
                    semovio = true;
                }
                else if (siguiente == semaforoverde)
                {
                    siguiente = matrizposiciones[carro.posy, carro.posx + 2];
                    if (siguiente == calle)
                    {
                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx].Value = imageList2.Images[calle];
                        matrizposiciones[carro.posy, carro.posx] = calle;
                        Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 2].Value = imageList2.Images[carro.tipocarro];
                        matrizposiciones[carro.posy, carro.posx + 2] = carro.tipocarro;
                        semovio = true;
                    }
                    else
                    {
                        semovio = false;
                    }
                }
                else if (siguiente == calle)
                {
                    matrizposiciones[carro.posy, carro.posx] = calle;
                    Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[calle];
                    carro.posx++;
                    matrizposiciones[carro.posy, carro.posx] = carro.tipocarro;
                    Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[carro.tipocarro];
                    semovio = true;
                }
                else if (((siguiente == mario) || (siguiente == mario_peach) || (siguiente == mario_yoshi)))
                {
                    matrizposiciones[carro.posy, carro.posx] = calle;
                    Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[calle];
                    carro.posx++;
                    matrizposiciones[carro.posy, carro.posx] = atropellado;
                    Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[atropellado];
                    if (carro.posx < limitex - 2)
                    {
                        siguiente = matrizposiciones[carro.posy, carro.posx + 1];
                        if (siguiente == calle)
                        {
                            Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 1].Value = imageList2.Images[carro.tipocarro];
                            matrizposiciones[carro.posy, carro.posx + 1] = carro.tipocarro;
                        }
                        else if (siguiente == semaforoverde)
                        {
                            Dgv_tablero.Rows[carro.posy].Cells[carro.posx + 2].Value = imageList2.Images[carro.tipocarro];
                            matrizposiciones[carro.posy, carro.posx + 2] = carro.tipocarro;
                        }
                    }
                    semovio = true;
                    if ((tieneanciano == true) || (tienemascota == true))
                    {
                        puntaje += carro.choque(true);
                        label1.Text = "Puntaje: " + puntaje.ToString();
                    }
                    else
                    {
                        puntaje += carro.choque(false);
                        label1.Text = "Puntaje: " + puntaje.ToString();
                    }
                }
            }
            return semovio;
        }


        private void nivel1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Nivel1.txt"); 
            int fila = 0; 
            int columnas = 0; 
            while (sr.EndOfStream == false) 
            {
                string line = sr.ReadLine();
                string[] split = line.Split(',');
                Dgv_tablero.Rows.Add();
                columnas = split.Count();

                for (int columna = 0; columna < split.Count(); columna++) 
                {
                    int numero = int.Parse(split[columna]); 
                    Dgv_tablero[columna, fila].Value = imageList2.Images[numero]; 
                    matrizposiciones[fila, columna] = numero; 
                }
                fila++; 
            }
            for (int i = 0; i < columnas; i++)
            {
                
                Dgv_tablero.Columns[i].Width = 40;
            }
            for (int i = 0; i < fila; i++)
            {
                
                Dgv_tablero.Rows[i].Height = 40;
            }
            sr.Close(); 
            timer1.Enabled = true;
            timer2.Enabled = true;
        }
        private void nivel1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (win)
            {
                StreamReader s1 = new StreamReader("puntaje.txt");
                string line = "";
                string[] label = new string[3];
                int contador = 0;
                while (s1.EndOfStream == false)
                {
                    line = s1.ReadLine();
                    string[] split = line.Split(';');

                    for (int b = 0; b <= 1; b++)
                    {
                        label[contador] = split[b];
                        contador++;
                    }
                }
                s1.Close();
                string Name1 = label[0];
                string apodo = label[1];
                string puntaje1 = puntaje.ToString();
                StreamWriter sr1 = new StreamWriter("puntaje.txt");                
                sr1.WriteLine(Name1 + ";" + apodo + ";" + puntaje1);
                sr1.Close();
            }
            if (win == false)
            {
                llenartop10 top10 = new llenartop10();
                StreamReader s1 = new StreamReader("puntaje.txt");
                string line = "";
                string[] label = new string[3];
                int contador = 0;
                line = s1.ReadLine();
                string[] split = line.Split(';');
                for (int b = 0; b <= 1; b++)
                {
                    label[contador] = split[b];
                    contador++;
                }
                s1.Close();
                string Name1 = label[0];
                string apodo = label[1];
                top10.llenar(Name1, apodo, puntaje);
                top10 obj = new top10(_1);
                obj.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int next = rand.Next(0, 6);

            int filacarro = callesnivel1[next];
            next = rand.Next(0, 5);

            int valorcarro = tipocarro[next];
            matrizposiciones[filacarro, 0] = valorcarro;
            Dgv_tablero[0, filacarro].Value = imageList2.Images[valorcarro];
            for (int i = 11; i >= 0; i--)
            {
                for (int j = 21; j >= 0; j--)
                {
                    if ((matrizposiciones[i, j] == carroamarillo) || (matrizposiciones[i, j] == carroazul) || (matrizposiciones[i, j] == carronegro) || (matrizposiciones[i, j] == carrorojo) || (matrizposiciones[i, j] == carroverde))
                    {
                        Carro carro = new Carro();
                        carro.posx = j;
                        carro.posy = i;
                        carro.tipocarro = matrizposiciones[i, j];
                        movercarro(carro);
                    }
                }
            }

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            tiempo tiempo = new tiempo(segundosnivel1, segundosjugados, lbltiempo.Text);
            lbltiempo.Text = tiempo.retornar();
            if (segundosjugados >= segundosnivel1)
            {
                timer2.Enabled = false;
                timer1.Enabled = false;
                tiempo.retornar();
                if (puntaje > 30)
                {
                    if (personajex <= limitex && personajex >= 0 && personajey <= limitey && personajey >= 0)
                    {
                        Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[gano];
                    }
                    MessageBox.Show("You Win");
                    siguiente_nivel obj = new siguiente_nivel(_1);
                    obj.Visible = true;
                    win = true;
                    this.Close();
                }
                else if (puntaje <= 30)
                {
                    MessageBox.Show("Game Over");
                    if (personajex <= limitex && personajex >= 0 && personajey <= limitey && personajey >= 0)
                    {
                        Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[atropellado];
                    }
                    this.Close();
                }
            }
            else if (true)
            {
                int contador = 0;
                for(int i = 2; i < 5;i++)
                {
                    for(int j = 0; j < 22; j++)
                    {
                        if ((matrizposiciones[i,j] != yoshi && matrizposiciones[i,j] != peach) && (matrizposiciones[i,j] != mario_peach && matrizposiciones[i, j] != mario_yoshi))
                        {
                            contador++;
                        }
                    }
                }
                for (int i = 7; i < 10; i++)
                {
                    for (int j = 0; j < 22; j++)
                    {
                        if ((matrizposiciones[i, j] != yoshi && matrizposiciones[i, j] != peach) && (matrizposiciones[i, j] != mario_peach && matrizposiciones[i, j] != mario_yoshi))
                        {
                            contador++;
                        }
                    }
                }
                if(contador == 132)
                {
                    timer2.Enabled = false;
                    timer1.Enabled = false;
                    tiempo.retornar();
                    if (puntaje > 30)
                    {
                        if (personajex <= limitex && personajex >= 0 && personajey <= limitey && personajey >= 0)
                        {
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[gano];
                        }
                        MessageBox.Show("You Win");
                        siguiente_nivel obj = new siguiente_nivel(_1);
                        obj.Visible = true;
                        win = true;
                        this.Close();
                    }
                    else if (puntaje <= 30)
                    {
                        MessageBox.Show("Game Over");
                        if (personajex <= limitex && personajex >= 0 && personajey <= limitey && personajey >= 0)
                        {
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[atropellado];
                        }
                        this.Close();
                    }
                }
            }
            segundosjugados++;
            tiempo.retornar();
        }

        private void nivel1_KeyUp(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled == true) //Validación para que solo funcione mientras el timer esté funcionando
            {
                if (e.KeyCode == Keys.D)
                {
                    if (((tieneanciano == true) && (caminaancianoderecha == 2)) || ((tienemascota == true) && (caminamascotaderecha == 1)) || ((tienemascota == false) && (tieneanciano == false)))
                    {
                        if (personajex < (limitex - 1))
                        {
                            caminaancianoderecha = 0;
                            caminamascotaderecha = 0;
                            caminaancianoizquierda = 0;
                            caminamascotaizquierda = 0;
                            caminaancianoarriba = 0;
                            caminamascotaarriba = 0;
                            caminaancianoabajo = 0;
                            caminamascotaabajo = 0;

                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[valorencima];
                            matrizposiciones[personajey, personajex] = valorencima;
                            personajex++;
                            valorencima = matrizposiciones[personajey, personajex];

                            if (tienemascota == true)
                            {
                                matrizposiciones[personajey, personajex] = mario_yoshi;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_yoshi];
                            }
                            else if (tieneanciano == true)
                            {
                                //Si se cumple el movimiento y tiene Peach la imagen de personaje que se imprime es en la que lo acompaña un Peach
                                //Se imprime en la nueva posición x del personaje, se muestra en el datagrid y se guarda en la matriz
                                matrizposiciones[personajey, personajex] = mario_peach;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_peach];
                            }
                            else
                            {
                                //Se imprime el personaje en la nueva posición x, se muestra en el datagrid y se guarda en la matriz
                                matrizposiciones[personajey, personajex] = mario;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario];
                            }
                        }
                    }
                    else //Si no se han presionado las 2 veces cuando tiene yoshi o las tres veces cuando tiene Peach:
                    {
                        if (tieneanciano) //Si tiene Peach el contador caminaancianoderecha aumenta en 1 hasta llegar a 2 ( puede tomar estos valores: 0, 1, 2)
                        {
                            caminaancianoderecha++;
                        }
                        else if (tienemascota) //Si tiene Peach el contador caminamascotaderecha aumenta en 1 hasta llegar a 1 ( puede tomar estos valores: 0, 1)
                        {
                            caminamascotaderecha++;
                        }
                    }
                }
                else if (e.KeyCode == Keys.A)
                {
                    if (((tieneanciano == true) && (caminaancianoizquierda == 2)) || ((tienemascota == true) && (caminamascotaizquierda == 1)) || ((tienemascota == false) && (tieneanciano == false)))
                    {
                        if (personajex > iniciox)
                        {
                            caminaancianoderecha = 0;
                            caminamascotaderecha = 0;
                            caminaancianoizquierda = 0;
                            caminamascotaizquierda = 0;
                            caminaancianoarriba = 0;
                            caminamascotaarriba = 0;
                            caminaancianoabajo = 0;
                            caminamascotaabajo = 0;

                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[valorencima];
                            matrizposiciones[personajey, personajex] = valorencima;
                            personajex--;
                            valorencima = matrizposiciones[personajey, personajex];

                            if (tienemascota == true)
                            {
                                matrizposiciones[personajey, personajex] = mario_yoshi;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_yoshi];
                            }
                            else if (tieneanciano == true)
                            {
                                matrizposiciones[personajey, personajex] = mario_peach;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_peach];
                            }
                            else
                            {
                                matrizposiciones[personajey, personajex] = mario;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario];
                            }
                        }
                    }
                    else
                    {
                        if (tieneanciano)//Si tiene Peach el contador caminaancianoizquierda aumenta en 1 hasta llegar a 2 (puede tomar estos valores: 0, 1, 2)
                        {
                            caminaancianoderecha = 0;
                            caminamascotaderecha = 0;
                            caminaancianoizquierda++;
                            caminamascotaizquierda = 0;
                            caminaancianoarriba = 0;
                            caminamascotaarriba = 0;
                            caminaancianoabajo = 0;
                            caminamascotaabajo = 0;
                            //Se incluyen todos los contadores para que se presione la flecha izquierda 3 veces SEGUIDAS
                        }
                        else if (tienemascota)//Si tiene Peach el contador caminamascotaizquierda aumenta en 1 hasta llegar a 1 (puede tomar estos valores: 0, 1)
                        {
                            caminamascotaderecha = 0;
                            caminaancianoderecha = 0;
                            caminaancianoizquierda = 0;
                            caminamascotaizquierda++;
                            caminaancianoarriba = 0;
                            caminamascotaarriba = 0;
                            caminaancianoabajo = 0;
                            caminamascotaabajo = 0;
                            //Se incluyen todos los contadores para que se presione la flecha izquierda 2 veces SEGUIDAS
                        }
                    }

                }
                else if (e.KeyCode == Keys.S)
                {
                    if (((tieneanciano == true) && (caminaancianoabajo == 2)) || ((tienemascota == true) && (caminamascotaabajo == 1)) || ((tienemascota == false) && (tieneanciano == false)))
                    //Validación para que cuado tenga Peach tenga que presionarse la flecha derecha 3 veces, cuando tenga yoshi 2, y cuando esté solo, solo 1
                    {
                        //limite -1 ya que el cero cuenta
                        if (personajey < limitey - 1)
                        {
                            //Se inician las variables en cero cada vez que se cumple el movimiento
                            caminaancianoderecha = 0;
                            caminamascotaderecha = 0;
                            caminaancianoizquierda = 0;
                            caminamascotaizquierda = 0;
                            caminaancianoarriba = 0;
                            caminamascotaarriba = 0;
                            caminaancianoabajo = 0;
                            caminamascotaabajo = 0;

                            //En la posición en la que estaba el personaje se imprime y se guarda en la matríz lo que había antes, que queda guardado en valorencima
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[valorencima];
                            matrizposiciones[personajey, personajex] = valorencima;

                            //La posición en y del personaje aumenta en 1 y valor encima guarda "que había" en la nueva posición
                            personajey++;
                            valorencima = matrizposiciones[personajey, personajex];

                            if (tienemascota == true)
                            {
                                //Si se cumple el movimiento y tiene yoshi la imagen de personaje que se imprime es en la que el personaje tiene un perro
                                //Se imprime en la nueva posición x del personaje, se muestra en el datagrid y se guarda en la matriz
                                matrizposiciones[personajey, personajex] = mario_yoshi;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_yoshi];
                            }
                            else if (tieneanciano == true)
                            {
                                //Si se cumple el movimiento y tiene Peach la imagen de personaje que se imprime es en la que lo acompaña un Peach
                                //Se imprime en la nueva posición x del personaje, se muestra en el datagrid y se guarda en la matriz
                                matrizposiciones[personajey, personajex] = mario_peach;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_peach];
                            }
                            else
                            {
                                //Se imprime el personaje en la nueva posición x, se muestra en el datagrid y se guarda en la matriz
                                matrizposiciones[personajey, personajex] = mario;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario];
                            }
                        }
                    }
                    else
                    {
                        if (tieneanciano)//Si tiene Peach el contador caminaancianoizquierda aumenta en 1 hasta llegar a 2 (puede tomar estos valores: 0, 1, 2)
                        {
                            caminaancianoderecha = 0;
                            caminamascotaderecha = 0;
                            caminaancianoizquierda = 0;
                            caminamascotaizquierda = 0;
                            caminaancianoarriba = 0;
                            caminamascotaarriba = 0;
                            caminaancianoabajo++;
                            caminamascotaabajo = 0;
                            //Se incluyen todos los contadores para que se presione la flecha abajo 3 veces SEGUIDAS
                        }
                        else if (tienemascota)//Si tiene Peach el contador caminamascotaizquierda aumenta en 1 hasta llegar a 1 (puede tomar estos valores: 0, 1)
                        {
                            caminamascotaderecha = 0;
                            caminaancianoderecha = 0;
                            caminaancianoizquierda = 0;
                            caminamascotaizquierda = 0;
                            caminaancianoarriba = 0;
                            caminamascotaarriba = 0;
                            caminaancianoabajo = 0;
                            caminamascotaabajo++;
                            //Se incluyen todos los contadores para que se presione la flecha abajo 3 veces SEGUIDAS
                        }
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    if (((tieneanciano == true) && (caminaancianoarriba == 2)) || ((tienemascota == true) && (caminamascotaarriba == 1)) || ((tienemascota == false) && (tieneanciano == false)))
                    //Validación para que cuado tenga Peach tenga que presionarse la flecha derecha 3 veces, cuando tenga yoshi 2, y cuando esté solo, solo 1
                    {
                        //Validación para que el personaje no salga de los límetes de la matriz
                        if (personajey > inicioy)
                        {//Se inician las variables en cero cada vez que se cumple el movimiento
                            caminaancianoderecha = 0;
                            caminamascotaderecha = 0;
                            caminaancianoizquierda = 0;
                            caminamascotaizquierda = 0;
                            caminaancianoarriba = 0;
                            caminamascotaarriba = 0;
                            caminaancianoabajo = 0;
                            caminamascotaabajo = 0;

                            //En la posición en la que estaba el personaje se imprime y se guarda en la matríz lo que había antes, que queda guardado en valorencima
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[valorencima];
                            matrizposiciones[personajey, personajex] = valorencima;

                            //La posición en y del personaje disminuye en 1 y valor encima guarda "que había" en la nueva posición
                            personajey--;
                            valorencima = matrizposiciones[personajey, personajex];

                            if (tienemascota == true)
                            {
                                //Si se cumple el movimiento y tiene yoshi la imagen de personaje que se imprime es en la que el personaje tiene un perro
                                //Se imprime en la nueva posición x del personaje, se muestra en el datagrid y se guarda en la matriz
                                matrizposiciones[personajey, personajex] = mario_yoshi;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_yoshi];
                            }
                            else if (tieneanciano == true)
                            {
                                //Si se cumple el movimiento y tiene Peach la imagen de personaje que se imprime es en la que lo acompaña un Peach
                                //Se imprime en la nueva posición x del personaje, se muestra en el datagrid y se guarda en la matriz
                                matrizposiciones[personajey, personajex] = mario_peach;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_peach];
                            }
                            else
                            {
                                //Se imprime el personaje en la nueva posición x, se muestra en el datagrid y se guarda en la matriz
                                matrizposiciones[personajey, personajex] = mario;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario];
                            }
                        }
                    }
                    else
                    {
                        if (tieneanciano)//Si tiene Peach el contador caminaancianoarriba aumenta en 1 hasta llegar a 2 (puede tomar estos valores: 0, 1, 2)
                        {
                            caminaancianoderecha = 0;
                            caminamascotaderecha = 0;
                            caminaancianoizquierda = 0;
                            caminamascotaizquierda = 0;
                            caminaancianoarriba++;
                            caminamascotaarriba = 0;
                            caminaancianoabajo = 0;
                            caminamascotaabajo = 0;
                            //Se incluyen todos los contadores para que se presione la flecha arriba 3 veces SEGUIDAS
                        }
                        else if (tienemascota)//Si tiene Peach el contador caminamascotaarriba aumenta en 1 hasta llegar a 1 (puede tomar estos valores: 0, 1)
                        {
                            caminamascotaderecha = 0;
                            caminaancianoderecha = 0;
                            caminaancianoizquierda = 0;
                            caminamascotaizquierda = 0;
                            caminaancianoarriba = 0;
                            caminamascotaarriba++;
                            caminaancianoabajo = 0;
                            caminamascotaabajo = 0;
                            //Se incluyen todos los contadores para que se presione la flecha izquierda 2 veces SEGUIDAS
                        }
                    }
                }
                else if (e.KeyCode == Keys.E)
                {
                    //orden para validar si tiene una yoshi o Peach a un lado: izquierda, derecha, arriba, abajo
                    //Sobre el
                    if ((personajex > 0) && (tienemascota == false) && (tieneanciano == false) && ((matrizposiciones[personajey, personajex + 1] == calle) || (matrizposiciones[personajey, personajex - 1] == calle))) 
                    {
                        if (valorencima == yoshi)//Si a la izquierda del personaje se encuentra una yoshi la toma
                        {
                            tienemascota = true; //Se vuelve true la variable tiene yoshi, que afecta la cantidad de veces que debe presionar las flechas
                            matrizposiciones[personajey, personajex] = mario_yoshi;//En la posicion del personaje se guarda en la matriz 14, que es el número de la imagen del personaje con yoshi
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_yoshi];//Se muestra en el datagrid, la imagen del mario con yoshi en la posición del jugador
                            valorencima = calle; 
                        }
                        else if (valorencima == peach)
                        {
                            tieneanciano = true; //Se vuelve true la variable tiene yoshi, que afecta la cantidad de veces que debe presionar las flechas
                            matrizposiciones[personajey, personajex] = mario_peach; //En la posicion del personaje se guarda en la matriz 15, que es el número de la imagen del personaje con Peach
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_peach]; //Se muestra en el datagrid, la imagen del mario con Peach en la posición del jugador
                            valorencima = calle;
                        }
                    }
                    //IZQUIERDA
                    if ((personajex > 0) && (tienemascota == false) && (tieneanciano == false))//valida que no tenga una yoshi o Peach antes
                    {
                        if (matrizposiciones[personajey, personajex - 1] == yoshi)//Si a la izquierda del personaje se encuentra una yoshi la toma
                        {
                            tienemascota = true; //Se vuelve true la variable tiene yoshi, que afecta la cantidad de veces que debe presionar las flechas
                            matrizposiciones[personajey, personajex - 1] = calle; //Se guarda calle en la posición izquierda del personaje, donde estaba la yoshi (En la matriz) 
                            Dgv_tablero.Rows[personajey].Cells[personajex - 1].Value = imageList2.Images[calle]; //Se imprime calle en la posicion a la izquierda del personaje en el datagrid
                            matrizposiciones[personajey, personajex] = mario_yoshi;//En la posicion del personaje se guarda en la matriz 14, que es el número de la imagen del personaje con yoshi
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_yoshi];//Se muestra en el datagrid, la imagen del mario con yoshi en la posición del jugador

                        }
                        else if (matrizposiciones[personajey, personajex - 1] == peach)
                        {
                            tieneanciano = true; //Se vuelve true la variable tiene yoshi, que afecta la cantidad de veces que debe presionar las flechas
                            matrizposiciones[personajey, personajex - 1] = calle; //Se guarda calle en la posición izquierda del personaje,  donde estaba el Peach (En la matriz) 
                            Dgv_tablero.Rows[personajey].Cells[personajex - 1].Value = imageList2.Images[calle]; //Se imprime calle en la posicion a la izquierda del personaje en el datagrid
                            matrizposiciones[personajey, personajex] = mario_peach; //En la posicion del personaje se guarda en la matriz 15, que es el número de la imagen del personaje con Peach
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_peach]; //Se muestra en el datagrid, la imagen del mario con Peach en la posición del jugador

                        }
                    }
                    //DERECHA
                    if (personajex < limitex - 1 && (tienemascota == false) && (tieneanciano == false))//valida que no tenga una yoshi o Peach antes
                    {
                        if (matrizposiciones[personajey, personajex + 1] == yoshi)//Si no hay nada a la izquierda, pero a la derecha del personaje se encuentra una yoshi la toma
                        {
                            tienemascota = true; //Se vuelve true la variable tiene yoshi
                            matrizposiciones[personajey, personajex + 1] = calle; //Se guarda calle en la posición a la derecha del personaje,  donde estaba la yoshi (En la matriz) 
                            Dgv_tablero.Rows[personajey].Cells[personajex + 1].Value = imageList2.Images[calle]; //Se imprime calle en la posicion a la derechca del personaje en el datagrid
                            matrizposiciones[personajey, personajex] = mario_yoshi;//En la posicion del personaje se guarda en la matriz 14, que es el número de la imagen del personaje con yoshi
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_yoshi];//Se muestra en el datagrid, la imagen del mario con yoshi en la posición del jugador

                        }
                        else if (matrizposiciones[personajey, personajex + 1] == peach)//Si no hay nada a la izquierda, pero a la derecha del personaje se encuentra un Peach, lo toma
                        {
                            tieneanciano = true;
                            matrizposiciones[personajey, personajex + 1] = calle; //Se guarda calle en la posición a la derecha del personaje,  donde estaba el Peach (En la matriz) 
                            Dgv_tablero.Rows[personajey].Cells[personajex + 1].Value = imageList2.Images[calle]; //Se imprime calle en la posicion a la derechca del personaje en el datagrid
                            matrizposiciones[personajey, personajex] = mario_peach;//En la posicion del personaje se guarda en la matriz 15, que es el número de la imagen del personaje con Peach
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_peach];//Se muestra en el datagrid, la imagen del mario con Peach en la posición del jugador

                        }
                    }
                    //ARRIBA
                    if ((personajey > 0) && (tienemascota == false) && (tieneanciano == false))//valida que no tenga una yoshi o Peach antes
                    {
                        if (matrizposiciones[personajey - 1, personajex] == yoshi)//Si no hay nada a la izquierda, ni derechca, pero arriba del personaje se encuentra una yoshi, la toma
                        {
                            tienemascota = true;
                            matrizposiciones[personajey - 1, personajex] = calle;//Se guarda calle en la posición arriba del personaje,  donde estaba la yoshi (En la matriz)
                            Dgv_tablero.Rows[personajey - 1].Cells[personajex].Value = imageList2.Images[calle];//Se imprime calle en la posicion arriba del personaje en el datagrid
                            matrizposiciones[personajey, personajex] = mario_yoshi;//En la posicion del personaje se guarda en la matriz 14, que es el número de la imagen del personaje con yoshi
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_yoshi];//Se muestra en el datagrid, la imagen del mario con yoshi en la posición del jugador

                        }
                        else if (matrizposiciones[personajey - 1, personajex] == peach)//Si no hay nada a la izquierda, ni derechca, pero arriba del personaje se encuentra un Peach, lo toma
                        {
                            tieneanciano = true;
                            matrizposiciones[personajey - 1, personajex] = calle;//Se guarda calle en la posición arriba del personaje,  donde estaba el Peach (En la matriz)
                            Dgv_tablero.Rows[personajey - 1].Cells[personajex].Value = imageList2.Images[calle];//Se imprime calle en la posicion arriba del personaje en el datagrid
                            matrizposiciones[personajey, personajex] = mario_peach;//En la posicion del personaje se guarda en la matriz 15, que es el número de la imagen del personaje con Peach
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_peach];//Se muestra en el datagrid, la imagen del mario con Peach en la posición del jugador

                        }
                    }
                    //ABAJO
                    if (personajey < limitey - 1 && (tienemascota == false) && (tieneanciano == false))//valida que no tenga una yoshi o Peach antes
                    {
                        if (matrizposiciones[personajey + 1, personajex] == yoshi)//Si no hay nada a la izquierda, ni derechca, ni arriba, pero abajo del personaje se encuentra una yoshi, la toma
                        {
                            tienemascota = true;
                            matrizposiciones[personajey + 1, personajex] = calle;//Se guarda calle en la posición abajo del personaje,  donde estaba la yoshi (En la matriz)
                            Dgv_tablero.Rows[personajey + 1].Cells[personajex].Value = imageList2.Images[calle]; //Se imprime calle en la posicion abajo del personaje en el datagrid
                            matrizposiciones[personajey, personajex] = mario_yoshi; //En la posicion del personaje se guarda en la matriz 14, que es el número de la imagen del personaje con yoshi
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_yoshi];//Se muestra en el datagrid, la imagen del mario con yoshi en la posición del jugador

                        }
                        else if (matrizposiciones[personajey + 1, personajex] == peach)//Si no hay nada a la izquierda, ni derechca, ni arriba, pero abajo del personaje se encuentra una yoshi, la toma
                        {
                            tieneanciano = true;
                            matrizposiciones[personajey + 1, personajex] = calle;//Se guarda calle en la posición abajo del personaje,  donde estaba el Peach (En la matriz)
                            Dgv_tablero.Rows[personajey + 1].Cells[personajex].Value = imageList2.Images[calle];//Se imprime calle en la posicion abajo del personaje en el datagrid
                            matrizposiciones[personajey, personajex] = mario_peach;//En la posicion del personaje se guarda en la matriz 15, que es el número de la imagen del personaje con Peach
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_peach];//Se muestra en el datagrid, la imagen del mario con Peach en la posición del jugador

                        }
                    }

                }
                else if (e.KeyCode == Keys.Q)
                {
                    if (valorencima == calle) //Si en valorencima quedó guardado 6 (calle)
                    {
                        if (tieneanciano == true)//Valida que esté transportando un Peach
                        {
                            valorencima = peach; //El Peach se puede soltar en la calle
                            tieneanciano = false;
                            matrizposiciones[personajey, personajex] = mario; //La imagen del personaje vuelve a ser la primcipal (en la matriz)
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario]; //La imagen que se muestra en el datagrid vuelve a ser la mario
                        }
                        else if (tienemascota == true)//Valida que esté transportando una yoshi
                        {
                            valorencima = yoshi; //El Peach se puede soltar en la calle
                            tienemascota = false;
                            matrizposiciones[personajey, personajex] = mario; //La imagen del personaje vuelve a ser la primcipal (en la matriz)
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario]; //La imagen que se muestra en el datagrid vuelve a ser la mario
                        }
                    }
                    else if (valorencima == sesped) //Si en valorencima quedó guardado 7 (calle)
                    {
                        puntaje += 10;
                        label1.Text = "Puntaje: " + puntaje.ToString();
                        matrizposiciones[personajey, personajex] = mario;
                        Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario];
                        if (tieneanciano == true)//Valida que esté transportando un Peach
                        {
                            valorencima = peach; //El Peach se puede soltar en la calle
                            tieneanciano = false;
                            matrizposiciones[personajey, personajex] = mario; //La imagen del personaje vuelve a ser la primcipal (en la matriz)
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario]; //La imagen que se muestra en el datagrid vuelve a ser la mario
                        }
                        else if (tienemascota == true)//Valida que esté transportando una yoshi
                        {
                            valorencima = yoshi; //El Peach se puede soltar en la calle
                            tienemascota = false;
                            matrizposiciones[personajey, personajex] = mario; //La imagen del personaje vuelve a ser la primcipal (en la matriz)
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario]; //La imagen que se muestra en el datagrid vuelve a ser la mario
                        }

                    }
                }
            }
        }

        private void Dgv_tablero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
