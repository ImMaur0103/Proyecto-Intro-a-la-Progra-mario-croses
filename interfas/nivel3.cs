using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace interfas
{
    public partial class nivel3 : Form
    {
        int[,] matrizposiciones = new int[20, 35];
        int[] callesnivel3 = new int[12];
        int[] tipocarro = new int[5];
        int[] semaforoy = new int[12];
        int[] semaforox = new int[12];

        bool win = false;
        bool semaforoon = true;
        bool superpwer = false;
        int contador = 0;
        int debajoagente;
        int poderes = 3;
        int puntaje = 0;
        int segundosnivel1 = 120;
        int segundosjugados = 0;
        int personajex = 13;
        int personajey = 19;
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
        const int gano = 17;
        int limitex = 35;
        int iniciox = 0;

        bool tienepeach = false;
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
        private int limitey = 19;
        private int inicioy = 0;
        Form1 formprincipal;

        public nivel3(Form1 _1)
        {
            formprincipal = _1;
            InitializeComponent();
            this.KeyPreview = true;
            callesnivel3[0] = 2;
            callesnivel3[1] = 3;
            callesnivel3[2] = 4;
            callesnivel3[3] = 5;
            callesnivel3[4] = 8;
            callesnivel3[5] = 9;
            callesnivel3[6] = 10;
            callesnivel3[7] = 11;
            callesnivel3[8] = 14;
            callesnivel3[9] = 15;
            callesnivel3[10] = 16;
            callesnivel3[11] = 17;

            tipocarro[0] = carroamarillo;
            tipocarro[1] = carroazul;
            tipocarro[2] = carroverde;
            tipocarro[3] = carrorojo;
            tipocarro[4] = carronegro;

            semaforoy[0] = 2;
            semaforoy[1] = 3;
            semaforoy[2] = 4;
            semaforoy[3] = 5;
            semaforoy[4] = 8;
            semaforoy[5] = 9;
            semaforoy[6] = 10;
            semaforoy[7] = 11;
            semaforoy[8] = 14;
            semaforoy[9] = 15;
            semaforoy[10] = 16;
            semaforoy[11] = 17;

            semaforox[0] = 25;
            semaforox[1] = 25;
            semaforox[2] = 25;
            semaforox[3] = 25;
            semaforox[4] = 10;
            semaforox[5] = 10;
            semaforox[6] = 10;
            semaforox[7] = 10;
            semaforox[8] = 25;
            semaforox[9] = 25;
            semaforox[10] = 25;
            semaforox[11] = 25;
        }

        public void movercarro(Carro carro)
        {
            int siguiente = 0;
            switch (carro.tipocarro)
            {
                case carroazul:
                    {
                        if (carro.posx <= limitex - 1)
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
                            else if (carro.posx == limitex - 2)
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
                                if ((tienepeach == true) || (tienemascota == true))
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
                                if ((tienepeach == true) || (tienemascota == true))
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
                        if (carro.posy > personajey)
                        {
                            siguiente = matrizposiciones[carro.posy - 1, carro.posx];
                            if (siguiente == calle)
                            {
                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[calle];
                                carro.posy--;
                                matrizposiciones[carro.posy, carro.posx] = carro.tipocarro;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[carro.tipocarro];
                                semovio = true;
                                semovio = Movimientocarrorojo(carro);
                            }
                            else if ((valorencima == calle) && ((siguiente == mario) || (siguiente == mario_peach) || (siguiente == mario_yoshi)))
                            {
                                matrizposiciones[carro.posy, carro.posx] = calle;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[calle];
                                carro.posy--;
                                matrizposiciones[carro.posy, carro.posx] = atropellado;
                                Dgv_tablero[carro.posx, carro.posy].Value = imageList2.Images[atropellado];
                                if ((tienepeach == true) || (tienemascota == true))
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
                                if ((tienepeach == true) || (tienemascota == true))
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
                        if (carro.posx <= limitex - 1)
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
                            else if (carro.posx == limitex - 2)
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
                            else if (siguiente == mario_yoshi || siguiente == mario_peach)
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
                        if (carro.posx <= limitex - 1)
                        {
                            siguiente = matrizposiciones[carro.posy, carro.posx + 1];
                            if (carro.posx == limitex - 2)
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
                if (carro.posx == limitex - 2)
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
                    if ((tienepeach == true) || (tienemascota == true))
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
                if (carro.posx == limitex - 2)
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
                    if ((tienepeach == true) || (tienemascota == true))
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

        private void nivel3_Load(object sender, EventArgs e)
        {
            MessageBox.Show("EN HORA BUENA, Ahora posees tres agentes de tránsito que podras usar con la tecla 'R' para parar el tránsito 6 seg");
            MessageBox.Show("Buena suerte");
            StreamReader sr = new StreamReader("Nivel3.txt");
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
            timer3.Enabled = true;
            timer4.Enabled = true;
        }
        private void nivel3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(win)
            {
                StreamReader s1 = new StreamReader("puntaje.txt");
                string line = "";
                string[] label = new string[3];
                int contador = 0;
                line = s1.ReadLine();
                string[] split = line.Split(';');
                for (int b = 0; b <= 2; b++)
                {
                    label[contador] = split[b];
                    contador++;
                }
                s1.Close();
                string Name1 = label[0];
                string apodo = label[1];
                int puntaje_total = puntaje + int.Parse(label[2]);
                llenartop10 top10 = new llenartop10();
                top10.llenar(Name1, apodo, puntaje_total);
                top10 obj = new top10(formprincipal);
                obj.Visible = true;
            }
            if (win == false)
            {
                StreamReader s1 = new StreamReader("puntaje.txt");
                string line = "";
                string[] label = new string[10];
                int contador = 0;
                line = s1.ReadLine();
                string[] split = line.Split(';');
                for (int b = 0; b <= 2; b++)
                {
                    label[contador] = split[b];
                    contador++;
                }
                s1.Close();
                string Name1 = label[0];
                string apodo = label[1];
                int puntaje_total = puntaje + int.Parse(label[2]);
                llenartop10 top10 = new llenartop10();
                top10.llenar(Name1, apodo, puntaje_total);
                top10 obj = new top10(formprincipal);
                obj.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int next = rand.Next(0, 12);

            int filacarro = callesnivel3[next];
            next = rand.Next(0, 5);

            int valorcarro = tipocarro[next];
            matrizposiciones[filacarro, 0] = valorcarro;
            Dgv_tablero[0, filacarro].Value = imageList2.Images[valorcarro];
            Carro carro = new Carro();
            for (int i = 19; i >= 0; i--)
            {
                for (int j = 34; j >= 0; j--)
                {
                    if ((matrizposiciones[i, j] == carroamarillo) || (matrizposiciones[i, j] == carroazul) || (matrizposiciones[i, j] == carronegro) || (matrizposiciones[i, j] == carrorojo) || (matrizposiciones[i, j] == carroverde))
                    {
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
                timer3.Enabled = false;
                timer4.Enabled = false;
                tiempo.retornar();
                if (puntaje > 120)
                {
                    if (personajex <= limitex-1 && personajex >= 0 && personajey <= limitey-1 && personajey >= 0)
                    {
                        Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[gano];
                    }
                    MessageBox.Show("You Win");
                    win = true;
                    this.Close();
                }
                else if (puntaje <= 120)
                {
                    if (personajex <= limitex && personajex >= 0 && personajey <= limitey && personajey >= 0)
                    {
                        Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[atropellado];
                    }
                    MessageBox.Show("Game Over");
                    this.Close();
                }
            }
            else if (true)
            {
                int contador = 0;
                for (int i = 2; i < 6; i++)
                {
                    for (int j = 0; j < 30; j++)
                    {
                        if ((matrizposiciones[i, j] != yoshi && matrizposiciones[i, j] != peach) && (matrizposiciones[i, j] != mario_peach && matrizposiciones[i, j] != mario_yoshi))
                        {
                            contador++;
                        }
                    }
                }
                for (int i = 8; i < 12; i++)
                {
                    for (int j = 0; j < 30; j++)
                    {
                        if ((matrizposiciones[i, j] != yoshi && matrizposiciones[i, j] != peach) && (matrizposiciones[i, j] != mario_peach && matrizposiciones[i, j] != mario_yoshi))
                        {
                            contador++;
                        }
                    }
                }
                for (int i = 14; i < 18 ; i++)
                {
                    for (int j = 0; j < 30; j++)
                    {
                        if ((matrizposiciones[i, j] != yoshi && matrizposiciones[i, j] != peach) && (matrizposiciones[i, j] != mario_peach && matrizposiciones[i, j] != mario_yoshi))
                        {
                            contador++;
                        }
                    }
                }
                if (contador == 420)
                {
                    timer2.Enabled = false;
                    timer1.Enabled = false;
                    timer3.Enabled = false;
                    timer4.Enabled = false;
                    tiempo.retornar();
                    if (puntaje > 120)
                    {
                        if (personajex <= limitex - 1 && personajex >= 0 && personajey <= limitey - 1 && personajey >= 0)
                        {
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[gano];
                        }
                        MessageBox.Show("You Win");
                        win = true;
                        this.Close();
                    }
                    else if (puntaje <= 120)
                    {
                        if (personajex <= limitex && personajex >= 0 && personajey <= limitey && personajey >= 0)
                        {
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[atropellado];
                        }
                        MessageBox.Show("Game Over");
                        this.Close();
                    }
                }
            }
            segundosjugados++;
            tiempo.retornar();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (semaforoon)
            {
                semaforoon = false;

                matrizposiciones[semaforoy[0], semaforox[0]] = semafororojo;
                matrizposiciones[semaforoy[1], semaforox[1]] = semafororojo;
                matrizposiciones[semaforoy[2], semaforox[2]] = semafororojo;
                matrizposiciones[semaforoy[3], semaforox[3]] = semafororojo;
                matrizposiciones[semaforoy[4], semaforox[4]] = semafororojo;
                matrizposiciones[semaforoy[5], semaforox[5]] = semafororojo;
                matrizposiciones[semaforoy[6], semaforox[6]] = semafororojo;
                matrizposiciones[semaforoy[7], semaforox[7]] = semafororojo;
                matrizposiciones[semaforoy[8], semaforox[8]] = semafororojo;
                matrizposiciones[semaforoy[9], semaforox[9]] = semafororojo;
                matrizposiciones[semaforoy[10], semaforox[10]] = semafororojo;
                matrizposiciones[semaforoy[11], semaforox[11]] = semafororojo;

                Dgv_tablero.Rows[semaforoy[0]].Cells[semaforox[0]].Value = imageList2.Images[semafororojo];
                Dgv_tablero.Rows[semaforoy[1]].Cells[semaforox[1]].Value = imageList2.Images[semafororojo];
                Dgv_tablero.Rows[semaforoy[2]].Cells[semaforox[2]].Value = imageList2.Images[semafororojo];
                Dgv_tablero.Rows[semaforoy[3]].Cells[semaforox[3]].Value = imageList2.Images[semafororojo];
                Dgv_tablero.Rows[semaforoy[4]].Cells[semaforox[4]].Value = imageList2.Images[semafororojo];
                Dgv_tablero.Rows[semaforoy[5]].Cells[semaforox[5]].Value = imageList2.Images[semafororojo];
                Dgv_tablero.Rows[semaforoy[6]].Cells[semaforox[6]].Value = imageList2.Images[semafororojo];
                Dgv_tablero.Rows[semaforoy[7]].Cells[semaforox[7]].Value = imageList2.Images[semafororojo];
                Dgv_tablero.Rows[semaforoy[8]].Cells[semaforox[8]].Value = imageList2.Images[semafororojo];
                Dgv_tablero.Rows[semaforoy[9]].Cells[semaforox[9]].Value = imageList2.Images[semafororojo];
                Dgv_tablero.Rows[semaforoy[10]].Cells[semaforox[10]].Value = imageList2.Images[semafororojo];
                Dgv_tablero.Rows[semaforoy[11]].Cells[semaforox[11]].Value = imageList2.Images[semafororojo];
            }
            else if (semaforoon == false)
            {
                semaforoon = true;

                matrizposiciones[semaforoy[0], semaforox[0]] = semaforoverde;
                matrizposiciones[semaforoy[1], semaforox[1]] = semaforoverde;
                matrizposiciones[semaforoy[2], semaforox[2]] = semaforoverde;
                matrizposiciones[semaforoy[3], semaforox[3]] = semaforoverde;
                matrizposiciones[semaforoy[4], semaforox[4]] = semaforoverde;
                matrizposiciones[semaforoy[5], semaforox[5]] = semaforoverde;
                matrizposiciones[semaforoy[6], semaforox[6]] = semaforoverde;
                matrizposiciones[semaforoy[7], semaforox[7]] = semaforoverde;
                matrizposiciones[semaforoy[8], semaforox[8]] = semaforoverde;
                matrizposiciones[semaforoy[9], semaforox[9]] = semaforoverde;
                matrizposiciones[semaforoy[10], semaforox[10]] = semaforoverde;
                matrizposiciones[semaforoy[11], semaforox[11]] = semaforoverde;

                Dgv_tablero.Rows[semaforoy[0]].Cells[semaforox[0]].Value = imageList2.Images[semaforoverde];
                Dgv_tablero.Rows[semaforoy[1]].Cells[semaforox[1]].Value = imageList2.Images[semaforoverde];
                Dgv_tablero.Rows[semaforoy[2]].Cells[semaforox[2]].Value = imageList2.Images[semaforoverde];
                Dgv_tablero.Rows[semaforoy[3]].Cells[semaforox[3]].Value = imageList2.Images[semaforoverde];
                Dgv_tablero.Rows[semaforoy[4]].Cells[semaforox[4]].Value = imageList2.Images[semaforoverde];
                Dgv_tablero.Rows[semaforoy[5]].Cells[semaforox[5]].Value = imageList2.Images[semaforoverde];
                Dgv_tablero.Rows[semaforoy[6]].Cells[semaforox[6]].Value = imageList2.Images[semaforoverde];
                Dgv_tablero.Rows[semaforoy[7]].Cells[semaforox[7]].Value = imageList2.Images[semaforoverde];
                Dgv_tablero.Rows[semaforoy[8]].Cells[semaforox[8]].Value = imageList2.Images[semaforoverde];
                Dgv_tablero.Rows[semaforoy[9]].Cells[semaforox[9]].Value = imageList2.Images[semaforoverde];
                Dgv_tablero.Rows[semaforoy[10]].Cells[semaforox[10]].Value = imageList2.Images[semaforoverde];
                Dgv_tablero.Rows[semaforoy[11]].Cells[semaforox[11]].Value = imageList2.Images[semaforoverde];
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (superpwer)
            {
                timer1.Enabled = false;
                debajoagente = matrizposiciones[9, 17];
                Dgv_tablero.Rows[9].Cells[17].Value = imageList2.Images[agente];
                contador++;
                if (contador == 2)
                {
                    Dgv_tablero.Rows[9].Cells[17].Value = imageList2.Images[debajoagente];
                    contador = 0;
                    superpwer = false;
                    timer1.Enabled = true;
                    timer4.Enabled = false;
                }
            }
        }

        private void nivel3_KeyUp(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled == true || timer4.Enabled == true)
            {
                if (e.KeyCode == Keys.D)
                {
                    if (((tienepeach == true) && (caminaancianoderecha == 2)) || ((tienemascota == true) && (caminamascotaderecha == 1)) || ((tienemascota == false) && (tienepeach == false)))
                    {
                        if (personajex < (limitex - 1))
                        {
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[valorencima];
                            matrizposiciones[personajey, personajex] = valorencima;

                            personajex++;
                            valorencima = matrizposiciones[personajey, personajex];

                            if (tienemascota == true)
                            {
                                matrizposiciones[personajey, personajex] = mario_yoshi;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_yoshi];
                            }
                            else if (tienepeach == true)
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
                    else //Si no se han presionado las 2 veces cuando tiene yoshi o las tres veces cuando tiene Peach:
                    {
                        if (tienepeach) //Si tiene Peach el contador caminaancianoderecha aumenta en 1 hasta llegar a 2 ( puede tomar estos valores: 0, 1, 2)
                        {
                            caminaancianoderecha++;
                            //Se incluyen todos los contadores para que se presione la flecha derecha 3 veces SEGUIDAS
                        }
                        else if (tienemascota) //Si tiene Peach el contador caminamascotaderecha aumenta en 1 hasta llegar a 1 ( puede tomar estos valores: 0, 1)
                        {
                            caminamascotaderecha++;
                            //Se incluyen todos los contadores para que se presione la flecha derecha 2 veces SEGUIDAS
                        }
                    }

                }
                else if (e.KeyCode == Keys.A)

                {
                    if (((tienepeach == true) && (caminaancianoizquierda == 2)) || ((tienemascota == true) && (caminamascotaizquierda == 1)) || ((tienemascota == false) && (tienepeach == false)))
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
                            else if (tienepeach == true)
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
                        if (tienepeach)
                        {
                            caminaancianoderecha = 0;
                            caminamascotaderecha = 0;
                            caminaancianoizquierda++;
                            caminamascotaizquierda = 0;
                            caminaancianoarriba = 0;
                            caminamascotaarriba = 0;
                            caminaancianoabajo = 0;
                            caminamascotaabajo = 0;
                        }
                        else if (tienemascota)
                        {
                            caminamascotaderecha = 0;
                            caminaancianoderecha = 0;
                            caminaancianoizquierda = 0;
                            caminamascotaizquierda++;
                            caminaancianoarriba = 0;
                            caminamascotaarriba = 0;
                            caminaancianoabajo = 0;
                            caminamascotaabajo = 0;
                        }
                    }

                }
                else if (e.KeyCode == Keys.S)
                {
                    if (((tienepeach == true) && (caminaancianoabajo == 2)) || ((tienemascota == true) && (caminamascotaabajo == 1)) || ((tienemascota == false) && (tienepeach == false)))
                    {
                        if (personajey < limitey - 1)
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


                            personajey++;
                            valorencima = matrizposiciones[personajey, personajex];

                            if (tienemascota == true)
                            {
                                matrizposiciones[personajey, personajex] = mario_yoshi;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_yoshi];
                            }
                            else if (tienepeach == true)
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
                        if (tienepeach)
                        {
                            caminaancianoderecha = 0;
                            caminamascotaderecha = 0;
                            caminaancianoizquierda = 0;
                            caminamascotaizquierda = 0;
                            caminaancianoarriba = 0;
                            caminamascotaarriba = 0;
                            caminaancianoabajo++;
                            caminamascotaabajo = 0;
                        }
                        else if (tienemascota)
                        {
                            caminamascotaderecha = 0;
                            caminaancianoderecha = 0;
                            caminaancianoizquierda = 0;
                            caminamascotaizquierda = 0;
                            caminaancianoarriba = 0;
                            caminamascotaarriba = 0;
                            caminaancianoabajo = 0;
                            caminamascotaabajo++;
                        }
                    }

                }
                else if (e.KeyCode == Keys.W)
                {
                    if (((tienepeach == true) && (caminaancianoarriba == 2)) || ((tienemascota == true) && (caminamascotaarriba == 1)) || ((tienemascota == false) && (tienepeach == false)))
                    {
                        if (personajey > inicioy)
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

                            personajey--;
                            valorencima = matrizposiciones[personajey, personajex];

                            if (tienemascota == true)
                            {
                                matrizposiciones[personajey, personajex] = mario_yoshi;
                                Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_yoshi];
                            }
                            else if (tienepeach == true)
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
                        if (tienepeach)
                        {
                            caminaancianoderecha = 0;
                            caminamascotaderecha = 0;
                            caminaancianoizquierda = 0;
                            caminamascotaizquierda = 0;
                            caminaancianoarriba++;
                            caminamascotaarriba = 0;
                            caminaancianoabajo = 0;
                            caminamascotaabajo = 0;
                        }
                        else if (tienemascota)
                        {
                            caminamascotaderecha = 0;
                            caminaancianoderecha = 0;
                            caminaancianoizquierda = 0;
                            caminamascotaizquierda = 0;
                            caminaancianoarriba = 0;
                            caminamascotaarriba++;
                            caminaancianoabajo = 0;
                            caminamascotaabajo = 0;
                        }
                    }

                }
                else if (e.KeyCode == Keys.E)
                {
                    if ((personajex > 0) && (tienemascota == false) && (tienepeach == false))
                    {
                        if (matrizposiciones[personajey, personajex - 1] == yoshi)
                        {
                            tienemascota = true;
                            matrizposiciones[personajey, personajex - 1] = calle;
                            Dgv_tablero.Rows[personajey].Cells[personajex - 1].Value = imageList2.Images[calle];
                            matrizposiciones[personajey, personajex] = mario_yoshi;
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_yoshi];

                        }
                        else if (matrizposiciones[personajey, personajex - 1] == peach)
                        {
                            tienepeach = true;
                            matrizposiciones[personajey, personajex - 1] = calle;
                            Dgv_tablero.Rows[personajey].Cells[personajex - 1].Value = imageList2.Images[calle];
                            matrizposiciones[personajey, personajex] = mario_peach;
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_peach];

                        }
                    }
                    if (personajex < limitex - 1 && (tienemascota == false) && (tienepeach == false))
                    {
                        if (matrizposiciones[personajey, personajex + 1] == yoshi)
                        {
                            tienemascota = true;
                            matrizposiciones[personajey, personajex + 1] = calle;
                            Dgv_tablero.Rows[personajey].Cells[personajex + 1].Value = imageList2.Images[calle];
                            matrizposiciones[personajey, personajex] = mario_yoshi;
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_yoshi];

                        }
                        else if (matrizposiciones[personajey, personajex + 1] == peach)
                        {
                            tienepeach = true;
                            matrizposiciones[personajey, personajex + 1] = calle;
                            Dgv_tablero.Rows[personajey].Cells[personajex + 1].Value = imageList2.Images[calle];
                            matrizposiciones[personajey, personajex] = mario_peach;
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_peach];

                        }
                    }
                    if ((personajey > 0) && (tienemascota == false) && (tienepeach == false))
                    {
                        if (matrizposiciones[personajey - 1, personajex] == yoshi)
                        {
                            tienemascota = true;
                            matrizposiciones[personajey - 1, personajex] = calle;
                            Dgv_tablero.Rows[personajey - 1].Cells[personajex].Value = imageList2.Images[calle];
                            matrizposiciones[personajey, personajex] = mario_yoshi;
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_yoshi];

                        }
                        else if (matrizposiciones[personajey - 1, personajex] == peach)
                        {
                            tienepeach = true;
                            matrizposiciones[personajey - 1, personajex] = calle;
                            Dgv_tablero.Rows[personajey - 1].Cells[personajex].Value = imageList2.Images[calle];
                            matrizposiciones[personajey, personajex] = mario_peach;
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_peach];

                        }
                    }
                    if (personajey < limitey - 1 && (tienemascota == false) && (tienepeach == false))
                    {
                        if (matrizposiciones[personajey + 1, personajex] == yoshi)
                        {
                            tienemascota = true;
                            matrizposiciones[personajey + 1, personajex] = calle;
                            Dgv_tablero.Rows[personajey + 1].Cells[personajex].Value = imageList2.Images[calle];
                            matrizposiciones[personajey, personajex] = mario_yoshi;
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_yoshi];
                        }
                        else if (matrizposiciones[personajey + 1, personajex] == peach)
                        {
                            tienepeach = true;
                            matrizposiciones[personajey + 1, personajex] = calle;
                            Dgv_tablero.Rows[personajey + 1].Cells[personajex].Value = imageList2.Images[calle];
                            matrizposiciones[personajey, personajex] = mario_peach;
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario_peach];

                        }
                    }

                }
                else if (e.KeyCode == Keys.Q)
                {
                    if (valorencima == calle)
                    {
                        if (tienepeach == true)
                        {
                            valorencima = peach;
                            tienepeach = false;
                            matrizposiciones[personajey, personajex] = mario;
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario];
                        }
                        else if (tienemascota == true)
                        {
                            valorencima = yoshi;
                            tienemascota = false;
                            matrizposiciones[personajey, personajex] = mario;
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario];
                        }
                    }
                    else if (valorencima == sesped)
                    {
                        puntaje += 10;
                        label1.Text = "Puntaje: " + puntaje.ToString();
                        matrizposiciones[personajey, personajex] = mario;
                        Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario];
                        if (tienepeach == true)
                        {
                            valorencima = peach;
                            tienepeach = false;
                            matrizposiciones[personajey, personajex] = mario;
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario];
                        }
                        else if (tienemascota == true)
                        {
                            valorencima = yoshi;
                            tienemascota = false;
                            matrizposiciones[personajey, personajex] = mario;
                            Dgv_tablero.Rows[personajey].Cells[personajex].Value = imageList2.Images[mario];
                        }

                    }

                }
            }
        }
        private void nivel3_KeyDown(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled == true)
            {
                if (e.KeyCode == Keys.R)
                {
                    if (poderes > 0)
                    {
                        poderes--;
                        timer4.Enabled = true;
                        superpwer = true;
                    }
                }
            }

        }
    }
}
