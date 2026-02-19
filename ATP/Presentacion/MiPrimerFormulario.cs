using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MiPrimerFormulario : Form
    {
        public MiPrimerFormulario()
        {
            InitializeComponent();
        }

        private void AniadirBoton_Click(object sender, EventArgs e)
        {
            if ((TbCuil.Text != "") || (TbNombre.Text != ""))
            {
                if (!ListaCaja.Items.Contains(TbCuil.Text))
                {
                    ListaCaja.Items.Add(TbCuil.Text);
                    ListaCajaEmail.Items.Add(TbEmail.Text);
                    ListaCajaNombre.Items.Add(TbNombre.Text);
                    ListaCajaPDF.Items.Add("https://drive.google.com/file/d/1-1K8RZpV3CE8CVRS0E5o6JwaT3W2btu2/view?usp=sharing");

                    MessageBox.Show("Datos guardados.");
                    Console.WriteLine("Index:" + ListaCajaEmail.Items.IndexOf(TbNombre.Text));
                }
                else
                {
                    MessageBox.Show("El cuil asignado ya existe.");
                }
            }
            else
            {
                MessageBox.Show("Los valores seleccionados son invalidos o estan vacios.");
            }


            TbCuil.Text = string.Empty;
            TbNombre.Text = string.Empty;
            TbCuil.Select();
        }


        private void ListaCaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaCaja.SelectedIndex >= 0)
            {
                int indexSeleccionado = ListaCaja.SelectedIndex;
                ListaCajaEmail.SelectedIndex = indexSeleccionado;
                TbCuil.Text = ListaCaja.Items[indexSeleccionado].ToString();
                TbNombre.Text = ListaCajaEmail.Items[indexSeleccionado].ToString();
            }
            else
            {
                Console.WriteLine("Ya no tenemos seleccionado nada.");
            }


        }



        private void ActualizarBoton_Click(object sender, EventArgs e)
        {
            if (ListaCaja.Items.Contains(TbCuil.Text))
            {
                int idItem = ListaCaja.Items.IndexOf(TbCuil.Text);

                if (TbNombre.Text != string.Empty)
                {
                    ListaCajaEmail.Items[idItem] = TbNombre.Text;

                    MessageBox.Show("Se han actualizado los datos de '" + TbCuil.Text + "'.");
                }
                else
                {
                    MessageBox.Show("No podemos dejar la descripcion vacia.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un codigo válido.");
            }
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            if (ListaCaja.Items.Contains(TbCuil.Text) && TbCuil.Text != string.Empty)
            {
                int idItem = ListaCaja.Items.IndexOf(TbCuil.Text);

                ListaCaja.Items.RemoveAt(idItem);
                ListaCajaEmail.Items.RemoveAt(idItem);

                MessageBox.Show("El elemento se borró correctamente.");
            }
            else
            {
                MessageBox.Show("Ingrese un codigo valido.");
            }
        }


        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            if (TbBusca.Text != string.Empty)
            {
                List<int> indices = BuscarEnListaParcial(ListaCaja, TbBusca.Text);

                if (indices.Count > 0)
                {
                    int idItem = indices[0];
                    ListaCaja.SelectedIndex = idItem;
                    ListaCajaEmail.SelectedIndex = idItem;

                    TbCuil.Text = ListaCaja.Items[idItem].ToString();
                    TbNombre.Text = ListaCajaEmail.Items[idItem].ToString();

                    label6.Text = indices.Count.ToString();
                }
                else
                {
                    indices = BuscarEnListaParcial(ListaCajaEmail, TbBusca.Text);

                    if (indices.Count > 0)
                    {
                        int idItem = indices[0];
                        ListaCaja.SelectedIndex = idItem;
                        ListaCajaEmail.SelectedIndex = idItem;

                        TbCuil.Text = ListaCaja.Items[idItem].ToString();
                        TbNombre.Text = ListaCajaEmail.Items[idItem].ToString();

                        label6.Text = indices.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado ningún resultado.");
                        label6.Text = "0";
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese un código o una descripción");
                label6.Text = "0";
            }
        }

        private List<int> BuscarEnListaParcial(ListBox lista, string texto)
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < lista.Items.Count; i++)
            {
                if (lista.Items[i].ToString().IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    indices.Add(i);
                }
            }
            return indices;
        }

        private void ReporteBoton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.Title = "Guardar lista como CSV";
                saveFileDialog.FileName = "lista.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Ruta del archivo seleccionada por el usuario
                    string rutaArchivo = saveFileDialog.FileName;

                    // Crear un StreamWriter para escribir en el archivo
                    using (StreamWriter escritor = new StreamWriter(rutaArchivo))
                    {
                        // Escribir la cabecera del archivo CSV
                        escritor.WriteLine("Cuil,Nombre,Email,PDF");

                        // Escribir los datos de las listas
                        for (int i = 0; i < ListaCaja.Items.Count; i++)
                        {
                            string cuil = ListaCaja.Items[i].ToString();
                            string nombre = ListaCajaNombre.Items[i].ToString();
                            string email = ListaCajaEmail.Items[i].ToString();
                            string pdf =ListaCajaPDF.Items[i].ToString();
                            escritor.WriteLine($"{cuil},{nombre},{email},{pdf}");
                        }
                    }

                    MessageBox.Show("Lista guardada como CSV.");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
