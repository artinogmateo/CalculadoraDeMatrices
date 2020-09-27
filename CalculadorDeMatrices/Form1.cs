using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadorDeMatrices
{
    public partial class Form1 : Form
    {
        //Se crean Array de textbox de dos dimenciones para las Matrices A,B y la matriz de resultado
        private TextBox[,] matrizA;
        private TextBox[,] matrizB;
        private TextBox[,] matrizResultado;

       //Almacenar filas y columnas
        int fila1, columna1;
        int fila2, columna2;

        public Form1()
        {
            InitializeComponent();
        }

        #region Crear Matrices
        private void btMatrizACrear_Click(object sender, EventArgs e)
        {
            //Se limpia en caso de matriz anterior 
            groupBoxMatrizA.Controls.Clear();
            // Se comprueva que los valores no sean 0
            if ((int)numericUpDown1.Value != 0)
            {
                fila1 = (int)numericUpDown1.Value;
            }
            else
            {
                MessageBox.Show("El valor de las filas no es valido", "Error en matriz A");
            }

            if ((int)numericUpDown2.Value != 0)
            {
                columna1 = (int)numericUpDown2.Value;
            }
            else
            {
                MessageBox.Show("El valor de las Columnas no es valido", "Error en matriz A");
            }

            //Creo el objeto Con los valores para el array del textbox
            matrizA = new TextBox[fila1, columna1];

            // Tamaño de cada textbox calculado con el ancho del groupbox y la cantidad de columnas.
            int tamañoMatriz = groupBoxMatrizA.Width / columna1-10;

            //Se recorren todos los elementos de las dos dimenciones con x,y.
            for (int x = 0; x < matrizA.GetLength(0); x++)
            {
                for (int y = 0; y < matrizA.GetLength(1); y++)
                {
                    //instancio la matizA, asigno valores y.
                    matrizA[x, y] = new TextBox();
                    matrizA[x, y].Text = "0";
                    //Ubicacion de la Matriz de textbox en relacion al groupBox.
                    matrizA[x, y].Top = (x * matrizA[x, y].Height) + 20;
                    matrizA[x, y].Left = y * tamañoMatriz + 6;
                    matrizA[x, y].Width = tamañoMatriz;
                    //Se dibuja en el groupbox.
                    groupBoxMatrizA.Controls.Add(matrizA[x, y]);
                }
            }

        }

        private void btMatrizBCrear_Click(object sender, EventArgs e)
        {
            groupBoxMatrizB.Controls.Clear();

            if ((int)numericUpDown4.Value != 0)
            {
                fila2 = (int)numericUpDown4.Value;
            }
            else
            {
                MessageBox.Show("El valor de las filas no es valido", "Error en matriz B");
            }

            if ((int)numericUpDown3.Value != 0)
            {
                columna2 = (int)numericUpDown3.Value;
            }
            else
            {
                MessageBox.Show("El valor de las Columnas no es valido", "Error en matriz B");
            }
            matrizB = new TextBox[fila2, columna2];
            int tamañoMatriz = groupBoxMatrizB.Width / columna2 - 10;

            for (int x = 0; x < matrizB.GetLength(0); x++)
            {
                for (int y = 0; y < matrizB.GetLength(1); y++)
                {
                    matrizB[x, y] = new TextBox();
                    matrizB[x, y].Text = "0";
                    matrizB[x, y].Top = (x * matrizB[x, y].Height) + 20;
                    matrizB[x, y].Left = y * tamañoMatriz + 6;
                    matrizB[x, y].Width = tamañoMatriz;
                    groupBoxMatrizB.Controls.Add(matrizB[x, y]);
                }
            }
        }
        #endregion
        
        
        #region Limpiar Matrices
        private void btLimpiarMatrizA_Click(object sender, EventArgs e)
        {
            groupBoxMatrizA.Controls.Clear();
        }
        private void btLimpiarMatrizB_Click(object sender, EventArgs e)
        {
            groupBoxMatrizB.Controls.Clear();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            groupBoxMatrizResultado.Controls.Clear();
        }
        #endregion

        
        #region Operaciones de las matrices


        #region Suma
        private void brSumaMatrices_Click(object sender, EventArgs e)
        {
            //Se comprueba que se crearon los array
            if (matrizA == null || matrizB == null)
            {
                MessageBox.Show("Debe Cargarse las dos matrices", "Error");
                return;
            }
            //Se crean las array temporales que tiene los valores ya cargados por el usario
            double[,] temporalMatrizA = new double[matrizA.GetLength(0), matrizA.GetLength(1)];
            double[,] temporalMatrizB = new double[matrizB.GetLength(0), matrizB.GetLength(1)];

            //Se comprueba que el orden de las matrices A y B sean iguales.
            if (temporalMatrizA.GetLength(0) != temporalMatrizB.GetLength(0) || temporalMatrizA.GetLength(1) != temporalMatrizB.GetLength(1))
            {
                MessageBox.Show("No se puede sumar dos matrices de diferente orden!", "Error Suma de las matrices");
                return;
            }
            //Recorro los elemntos las dimenciones de la matriz.
            for (int x = 0; x < matrizA.GetLength(0); x++)
            {
                for (int y = 0; y < matrizA.GetLength(1); y++)
                {
                    //Paso los valore de la matrizA a la temporal
                    temporalMatrizA[x, y] = Convert.ToDouble(matrizA[x, y].Text);
                }
            }
            for (int x = 0; x < matrizB.GetLength(0); x++)
            {
                for (int y = 0; y < matrizB.GetLength(1); y++)
                {
                    //Paso los valore de la matrizB a la temporal
                    temporalMatrizB[x, y] = Convert.ToDouble(matrizB[x, y].Text);
                }
            }

            //Operacion de suma.
            double[,] temporalMatrizResultante = new double[temporalMatrizA.GetLongLength(0), temporalMatrizB.GetLength(1)];
            for (int x = 0; x < temporalMatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < temporalMatrizResultante.GetLength(1); y++)
                {
                    temporalMatrizResultante[x, y] = temporalMatrizA[x, y] += temporalMatrizB[x, y];
                }
            }
            //Creo la matriz resultado

            matrizResultado = new TextBox[temporalMatrizResultante.GetLength(0), temporalMatrizResultante.GetLength(1)];
            //tamaño del control
            int tamañoMatriz = groupBoxMatrizResultado.Width / matrizResultado.GetLength(1) - 10;
            groupBoxMatrizResultado.Controls.Clear();
            

            //Recorro toda la matriz
            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    //Asigno los valores a la array
                    matrizResultado[x, y] = new TextBox();
                    matrizResultado[x, y].Text = temporalMatrizResultante[x, y].ToString();
                    matrizResultado[x, y].Top = (x * matrizResultado[x, y].Height) + 20;
                    matrizResultado[x, y].Left = y * tamañoMatriz + 6;
                    matrizResultado[x, y].Width = tamañoMatriz;
                    groupBoxMatrizResultado.Controls.Add(matrizResultado[x, y]);
                }
            }
        }
        #endregion

        #region Resta
        private void btRestaMatrices_Click(object sender, EventArgs e)
        {
            // Se comprueba
            if (matrizA == null || matrizB == null)
            {
                MessageBox.Show("Debe Cargarse las dos matrices", "Error");
                return;
            }
            double[,] temporalMatrizA = new double[matrizA.GetLength(0), matrizA.GetLength(1)];
            double[,] temporalMatrizB = new double[matrizB.GetLength(0), matrizB.GetLength(1)];

            if (temporalMatrizA.GetLength(0) != temporalMatrizB.GetLength(0) || temporalMatrizA.GetLength(1) != temporalMatrizB.GetLength(1))
            {
                MessageBox.Show("Solo pueden restarse matrices del mismo orden !", "Error Resta de matrices");
                return;
            }
            //Creo las matrices temporales
            for (int x = 0; x < matrizA.GetLength(0); x++)
            {
                for (int y = 0; y < matrizA.GetLength(1); y++)
                {
                    temporalMatrizA[x, y] = Convert.ToDouble(matrizA[x, y].Text);
                }
            }
            for (int x = 0; x < matrizB.GetLength(0); x++)
            {
                for (int y = 0; y < matrizB.GetLength(1); y++)
                {                    
                    temporalMatrizB[x, y] = Convert.ToDouble(matrizB[x, y].Text);
                }
            }

            //Calculo de resta
            double[,] temporalMatrizResultante = new double[temporalMatrizA.GetLongLength(0), temporalMatrizA.GetLength(1)];
            for (int x = 0; x < temporalMatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < temporalMatrizResultante.GetLength(1); y++)
                {
                    temporalMatrizResultante[x, y] = temporalMatrizA[x, y] -= temporalMatrizB[x, y];
                }
            }
            //Creo la matriz resultado
            matrizResultado = new TextBox[temporalMatrizResultante.GetLength(0), temporalMatrizResultante.GetLength(1)];

            int tamañoMatriz = groupBoxMatrizResultado.Width / matrizResultado.GetLength(1) - 10;
            groupBoxMatrizResultado.Controls.Clear();

            //Recorro y asigno los valores a la array
            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    matrizResultado[x, y] = new TextBox();
                    matrizResultado[x, y].Text = temporalMatrizResultante[x, y].ToString();
                    matrizResultado[x, y].Top = (x * matrizResultado[x, y].Height) + 20;
                    matrizResultado[x, y].Left = y * tamañoMatriz + 6;
                    matrizResultado[x, y].Width = tamañoMatriz;
                    groupBoxMatrizResultado.Controls.Add(matrizResultado[x, y]);
                }
            }
        }

        
        #endregion

        #region Multiplicacion
        private void btMultiMatrices_Click(object sender, EventArgs e)
        {
            //Compruebo que se ayan creado las matrices
            if (matrizA == null || matrizB == null)
            {
                MessageBox.Show("Debe Cargarse las dos matrices", "Error");
                return;
            }
            //creo matrices temporales
            double[,] temporalMatrizA = new double[matrizA.GetLength(0), matrizA.GetLength(1)];
            double[,] temporalMatrizB = new double[matrizB.GetLength(0), matrizB.GetLength(1)];

            //Compruevo que las matrizA tenga el mismo numero de filas que la matrizB.
            if (temporalMatrizA.GetLength(1) != temporalMatrizB.GetLength(0))
            {
                MessageBox.Show("Solo es posible multiplicar matrices donde el numero de columnas sean iguales a las filas de otras", "Error Multiplicacion de matrices");
                return;
            }
            //Recorro las matrices
            for (int x = 0; x < matrizA.GetLength(0); x++)
            {
                for (int y = 0; y < matrizA.GetLength(1); y++)
                {
                   //asigno Valore a matriz temporal A
                    temporalMatrizA[x, y] = Convert.ToDouble(matrizA[x, y].Text);
                }
            }
            for (int x = 0; x < matrizB.GetLength(0); x++)
            {
                for (int y = 0; y < matrizB.GetLength(1); y++)
                {
                    //asigno Valore a matriz temporal B
                    temporalMatrizB[x, y] = Convert.ToDouble(matrizB[x, y].Text);
                }
            }
            //Declaro matriz matriz temporal resultado
            double[,] temporalMatrizResultante = new double[temporalMatrizA.GetLength(0), temporalMatrizB.GetLength(1)];
            //Recorro todos los elementos
            for (int x = 0; x < temporalMatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < temporalMatrizResultante.GetLength(1); y++)
                {
                    for (int n = 0; n < temporalMatrizB.GetLength(0); n++)
                    {
                       // string i = "" + temporalMatrizA[x, n];
                        temporalMatrizResultante[x, y] += temporalMatrizA[x, n] * temporalMatrizB[n, y];
                    }
                }
            }
            //Creo la matriz resultado
            matrizResultado = new TextBox[temporalMatrizResultante.GetLength(0), temporalMatrizResultante.GetLength(1)];
            //Tamaño del control
            int tamañoMatriz = groupBoxMatrizResultado.Width / matrizResultado.GetLength(1) - 10;
            groupBoxMatrizResultado.Controls.Clear();

            //Recorro y asigno los valores a la array
            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    matrizResultado[x, y] = new TextBox();
                    matrizResultado[x, y].Text = temporalMatrizResultante[x, y].ToString();
                    matrizResultado[x, y].Top = (x * matrizResultado[x, y].Height) + 20;
                    matrizResultado[x, y].Left = y * tamañoMatriz + 6;
                    matrizResultado[x, y].Width = tamañoMatriz;
                    groupBoxMatrizResultado.Controls.Add(matrizResultado[x, y]);
                }
            }
        }
        #endregion
        
        #region transpuesta      
        private void btTranspuesta_Click(object sender, EventArgs e)
        {
            ////Compruebo que existe la matriz resultado
            //if (matrizResultado == null)
            //{
            //    MessageBox.Show("Matriz nula !", "Error - Matriz");
            //    return;
            //}
            ////Creo matriz temporal de resultado
            //double[,] temporalResultado = new double[matrizResultado.GetLength(0), matrizResultado.GetLength(1)];
            ////Recorro la matriz
            //for (int x = 0; x < matrizResultado.GetLength(0); x++)
            //{
            //    for (int y = 0; y < matrizResultado.GetLength(1); y++)
            //    {         
            //        temporalResultado[x, y] = Convert.ToDouble(matrizResultado[x, y].Text);
            //    }
            //}
            ////Creo la matriz Transpuesta Donde la dimenciones esta al reves de la matrizResultado.
            //double[,] matrizTranspuesta = new double[temporalResultado.GetLength(1), temporalResultado.GetLength(0)];
            ////Recorro la Matriz y le asigno los valores de Y a X ,y X a Y.
            //for (int x = 0; x < matrizTranspuesta.GetLength(0); x++)
            //{
            //    for (int y = 0; y < matrizTranspuesta.GetLength(1); y++)
            //    {
            //        matrizTranspuesta[x, y] += temporalResultado[y, x];
            //    }
            //}
            ////Creo Matris temporal resultado
            //double[,] temporalMatrizResultado = matrizTranspuesta;
            ////Tamaño del control
            //int tamañoMatriz = groupBoxMatrizResultado.Width / matrizResultado.GetLength(0) - 25;

            ////Creo la matriz resultado
            //matrizResultado = new TextBox[temporalMatrizResultado.GetLength(0), temporalMatrizResultado.GetLength(1)];
            //groupBoxMatrizResultado.Controls.Clear();

            ////Recorro y asigno los valores a la array
            //for (int x = 0; x < matrizResultado.GetLength(0); x++)
            //{
            //    for (int y = 0; y < matrizResultado.GetLength(1); y++)
            //    {
            //        matrizResultado[x, y] = new TextBox();
            //        matrizResultado[x, y].Text = temporalMatrizResultado[x, y].ToString();
            //        matrizResultado[x, y].Top = (x * matrizResultado[x, y].Height) + 20;
            //        matrizResultado[x, y].Left = y * tamañoMatriz + 6;
            //        matrizResultado[x, y].Width = tamañoMatriz;
            //        groupBoxMatrizResultado.Controls.Add(matrizResultado[x, y]);
            //    }
            //}
        }
        #endregion

        #region Escalar
        private void btEscalar_Click(object sender, EventArgs e)
        {
            //Compruebo que se ayan creado las matrices
            if (matrizA == null)
            {
                MessageBox.Show("Debe Cargarse la matriz A", "Error");
                return;
            }
            //creo matrices temporales
            double[,] temporalMatrizA = new double[matrizA.GetLength(0), matrizA.GetLength(1)];
            
            
            //Recorro las matrices
            for (int x = 0; x < matrizA.GetLength(0); x++)
            {
                for (int y = 0; y < matrizA.GetLength(1); y++)
                {
                    //asigno Valores a matriz temporal A
                    temporalMatrizA[x, y] = Convert.ToDouble(matrizA[x, y].Text);
                }
            }
                        
            //Declaro matriz temporal resultado
            double[,] temporalMatrizResultante = new double[matrizA.GetLength(0), matrizA.GetLength(1)];
            //Recorro todos los elementos
            for (int x = 0; x < temporalMatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < temporalMatrizResultante.GetLength(1); y++)
                {

                 temporalMatrizResultante[x, y] += temporalMatrizA[x, y] * Convert.ToDouble(txtEscalar.Text);
                    
                }
            }
            //Creo la matriz resultado
            matrizResultado = new TextBox[temporalMatrizResultante.GetLength(0), temporalMatrizResultante.GetLength(1)];
            //Tamaño del control
            int tamañoMatriz = groupBoxMatrizResultado.Width / matrizResultado.GetLength(1) - 10;
            groupBoxMatrizResultado.Controls.Clear();

            //Recorro y asigno los valores a la array
            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    matrizResultado[x, y] = new TextBox();
                    matrizResultado[x, y].Text = temporalMatrizResultante[x, y].ToString();
                    matrizResultado[x, y].Top = (x * matrizResultado[x, y].Height) + 20;
                    matrizResultado[x, y].Left = y * tamañoMatriz + 6;
                    matrizResultado[x, y].Width = tamañoMatriz;
                    groupBoxMatrizResultado.Controls.Add(matrizResultado[x, y]);
                }
            }
        }


    }
        #endregion

        #endregion


    }

