using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
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
            string urlLink = "http://localhost:3000/notificacion-deuda-pdf?cuil=" + TbCuil.Text + "&idDeuda=" + TbDeuda.Text;

            if ((TbCuil.Text != "") || (TbNombre.Text != ""))
            {
                if (!ListaCaja.Items.Contains(TbCuil.Text))
                {
                    ListaCaja.Items.Add(TbCuil.Text);
                    ListaCajaEmail.Items.Add(TbEmail.Text);
                    ListaCajaNombre.Items.Add(TbNombre.Text);
                    ListaCajaPDF.Items.Add(urlLink);

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
            TbEmail.Text = string.Empty;
            TbDeuda.Text = string.Empty;
            TbCuil.Select();
        }


        private void ListaCaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaCaja.SelectedIndex >= 0)
            {
                int indexSeleccionado = ListaCaja.SelectedIndex;
                ListaCaja.SelectedIndex = indexSeleccionado;
                ListaCajaEmail.SelectedIndex = indexSeleccionado;
                ListaCajaNombre.SelectedIndex = indexSeleccionado;
                ListaCajaPDF.SelectedIndex = indexSeleccionado;

                TbCuil.Text = ListaCaja.Items[indexSeleccionado].ToString();
                TbNombre.Text = ListaCajaNombre.Items[indexSeleccionado].ToString();
                TbEmail.Text = ListaCajaEmail.Items[indexSeleccionado].ToString();


                string url = ListaCajaPDF.Items[indexSeleccionado].ToString();
                string baseUrl = "http://localhost:3000/notificacion-deuda-pdf?cuil=" + TbCuil.Text + "&idDeuda=";
                TbDeuda.Text = url.Replace(baseUrl, "");
            }
            else
            {
                Console.WriteLine("Ya no tenemos seleccionado nada.");
            }


        }

        private void ListaCajaEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaCajaEmail.SelectedIndex >= 0)
            {
                int indexSeleccionado = ListaCajaEmail.SelectedIndex;
                ListaCaja.SelectedIndex = indexSeleccionado;
                ListaCajaEmail.SelectedIndex = indexSeleccionado;
                ListaCajaNombre.SelectedIndex = indexSeleccionado;
                ListaCajaPDF.SelectedIndex = indexSeleccionado;

                TbCuil.Text = ListaCaja.Items[indexSeleccionado].ToString();
                TbNombre.Text = ListaCajaNombre.Items[indexSeleccionado].ToString();
                TbEmail.Text = ListaCajaEmail.Items[indexSeleccionado].ToString();
                string url = ListaCajaPDF.Items[indexSeleccionado].ToString();
                string baseUrl = "http://localhost:3000/notificacion-deuda-pdf?cuil=" + TbCuil.Text + "&idDeuda=";
                TbDeuda.Text = url.Replace(baseUrl, "");
            }
            else
            {
                Console.WriteLine("Ya no tenemos seleccionado nada.");
            }


        }

        private void ListaCajaNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaCajaNombre.SelectedIndex >= 0)
            {
                int indexSeleccionado = ListaCajaNombre.SelectedIndex;
                ListaCaja.SelectedIndex = indexSeleccionado;
                ListaCajaEmail.SelectedIndex = indexSeleccionado;
                ListaCajaNombre.SelectedIndex = indexSeleccionado;
                ListaCajaPDF.SelectedIndex = indexSeleccionado;

                TbCuil.Text = ListaCaja.Items[indexSeleccionado].ToString();
                TbNombre.Text = ListaCajaNombre.Items[indexSeleccionado].ToString();
                TbEmail.Text = ListaCajaEmail.Items[indexSeleccionado].ToString();
                string url = ListaCajaPDF.Items[indexSeleccionado].ToString();
                string baseUrl = "http://localhost:3000/notificacion-deuda-pdf?cuil=" + TbCuil.Text + "&idDeuda="; 
                TbDeuda.Text = url.Replace(baseUrl, "");

            }
            else
            {
                Console.WriteLine("Ya no tenemos seleccionado nada.");
            }


        }

        private void ListaCajaPDF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaCajaPDF.SelectedIndex >= 0)
            {
                int indexSeleccionado = ListaCajaPDF.SelectedIndex;
                ListaCaja.SelectedIndex = indexSeleccionado;
                ListaCajaEmail.SelectedIndex = indexSeleccionado;
                ListaCajaNombre.SelectedIndex = indexSeleccionado;
                ListaCajaPDF.SelectedIndex = indexSeleccionado;

                TbCuil.Text = ListaCaja.Items[indexSeleccionado].ToString();
                TbNombre.Text = ListaCajaNombre.Items[indexSeleccionado].ToString();
                TbEmail.Text = ListaCajaEmail.Items[indexSeleccionado].ToString();
                string url = ListaCajaPDF.Items[indexSeleccionado].ToString();
                string baseUrl = "http://localhost:3000/notificacion-deuda-pdf?cuil=" + TbCuil.Text + "&idDeuda=";
                TbDeuda.Text = url.Replace(baseUrl, "");

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
                string email = TbEmail.Text;
                string nombre = TbNombre.Text;
                string cuil = TbCuil.Text;
                string url = "http://localhost:3000/notificacion-deuda-pdf?cuil=" + TbCuil.Text + "&idDeuda=" + TbDeuda.Text;


                if (TbNombre.Text != string.Empty || TbCuil.Text != string.Empty || TbEmail.Text != string.Empty || TbDeuda.Text != string.Empty)
                {
                    ListaCajaEmail.Items[idItem] = TbEmail.Text;
                    ListaCajaNombre.Items[idItem] = TbNombre.Text;
                    ListaCaja.Items[idItem] = TbCuil.Text;
                    ListaCajaPDF.Items[idItem] = url;

                    MessageBox.Show(nombre + "se actualizo correctamente.");

                    TbCuil.Text = string.Empty;
                    TbEmail.Text = string.Empty;
                    TbNombre.Text = string.Empty;
                    TbDeuda.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("No podemos dejar un campo vacio.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un cuil válido.");
            }
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            if (ListaCaja.Items.Contains(TbCuil.Text) && TbCuil.Text != string.Empty)
            {
                int idItem = ListaCaja.Items.IndexOf(TbCuil.Text);

                ListaCaja.Items.RemoveAt(idItem);
                ListaCajaNombre.Items.RemoveAt(idItem);
                ListaCajaPDF.Items.RemoveAt(idItem);
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
                    ListaCajaNombre.SelectedIndex = idItem;
                    ListaCajaPDF.SelectedIndex = idItem;

                    TbCuil.Text = ListaCaja.Items[idItem].ToString();
                    TbNombre.Text = ListaCajaNombre.Items[idItem].ToString();
                    TbEmail.Text = ListaCajaEmail.Items[idItem].ToString();
                    string url = ListaCajaPDF.Items[idItem].ToString();
                    string baseUrl = "http://localhost:3000/notificacion-deuda-pdf?cuil=" + TbCuil.Text + "&idDeuda=";
                    TbDeuda.Text = url.Replace(baseUrl, "");


                    label6.Text = indices.Count.ToString();
                }
                else
                {
                    indices = BuscarEnListaParcial(ListaCajaNombre, TbBusca.Text);

                    if (indices.Count > 0)
                    {
                        int idItem = indices[0];
                        ListaCaja.SelectedIndex = idItem;
                        ListaCajaEmail.SelectedIndex = idItem;
                        ListaCajaNombre.SelectedIndex = idItem;
                        ListaCajaPDF.SelectedIndex = idItem;

                        TbCuil.Text = ListaCaja.Items[idItem].ToString();
                        TbNombre.Text = ListaCajaNombre.Items[idItem].ToString();
                        TbEmail.Text = ListaCajaEmail.Items[idItem].ToString();

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
                            ListaCajaNombre.SelectedIndex = idItem;
                            ListaCajaPDF.SelectedIndex = idItem;

                            TbCuil.Text = ListaCaja.Items[idItem].ToString();
                            TbNombre.Text = ListaCajaNombre.Items[idItem].ToString();
                            TbEmail.Text = ListaCajaEmail.Items[idItem].ToString();

                            label6.Text = indices.Count.ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se ha encontrado ningún resultado.");
                            label6.Text = "0";

                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese un Cuil o un Nombre");
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
                            string pdf = ListaCajaPDF.Items[i].ToString();
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
        /*
        private void BtnPdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
       
            openFileDialog1.Filter = "Archivos PDF (*.pdf)|*.pdf";
            
            openFileDialog1.DefaultExt = "pdf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog1.FileName;

                /// Aca deberia haber logica de subida a DRIVE o a donde sea 
                
                BtnPdf.Text = rutaArchivo;
                
                MessageBox.Show("Seleccionaste: " + rutaArchivo);
            }
        }
        */


        private void ImportarBoton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "Seleccionar archivo CSV";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Preguntar si desea agregar o reemplazar
                    DialogResult result = MessageBox.Show(
                        "¿Desea agregar los datos a la lista existente?\n\nSí = Agregar\nNo = Reemplazar\nCancelar = Salir",
                        "Importar CSV",
                        MessageBoxButtons.YesNoCancel);

                    if (result == DialogResult.Cancel)
                        return;

                    if (result == DialogResult.No)
                    {
                        // Limpiar todas las listas
                        ListaCaja.Items.Clear();
                        ListaCajaNombre.Items.Clear();
                        ListaCajaEmail.Items.Clear();
                        ListaCajaPDF.Items.Clear();
                    }

                    // Llamar al método de importación mejorado
                    ImportarCSVManual(filePath);
                }
            }
        }

        private void ImportarCSVManual(string filePath)
        {
            try
            {
                // Leer todas las líneas del archivo
                string[] lineas = File.ReadAllLines(filePath);

                if (lineas.Length == 0)
                {
                    MessageBox.Show("El archivo está vacío.");
                    return;
                }

                // La primera línea es el encabezado, la saltamos
                for (int i = 1; i < lineas.Length; i++)
                {
                    string linea = lineas[i];

                    // Ignorar líneas vacías
                    if (string.IsNullOrWhiteSpace(linea))
                        continue;

                    // Parsear la línea respetando comillas
                    List<string> campos = ParsearCSV(linea);

                    // Debe tener al menos 4 campos
                    if (campos.Count >= 4)
                    {
                        string cuil = campos[0].Trim();
                        string nombre = campos[1].Trim();
                        string email = campos[2].Trim();
                        string pdf = campos[3].Trim();

                        // Opcional: evitar CUIL vacío
                        if (!string.IsNullOrEmpty(cuil))
                        {
                            ListaCaja.Items.Add(cuil);
                            ListaCajaNombre.Items.Add(nombre);
                            ListaCajaEmail.Items.Add(email);
                            ListaCajaPDF.Items.Add(pdf);
                        }
                    }
                    else
                    {
                        // Si una línea no tiene suficientes campos, puedes ignorarla o mostrar advertencia
                        // MessageBox.Show($"Línea {i+1} ignorada por tener menos de 4 campos.");
                    }
                }

                MessageBox.Show("Importación completada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al importar el archivo: " + ex.Message);
            }
        }

        /// <summary>
        /// Parsea una línea de CSV respetando comillas dobles.
        /// </summary>
        private List<string> ParsearCSV(string linea)
        {
            List<string> campos = new List<string>();
            bool dentroDeComillas = false;
            int inicioCampo = 0;

            for (int i = 0; i < linea.Length; i++)
            {
                char c = linea[i];

                if (c == '"')
                {
                    // Alternar estado de comillas
                    dentroDeComillas = !dentroDeComillas;
                }
                else if (c == ',' && !dentroDeComillas)
                {
                    // Fin de campo
                    string campo = linea.Substring(inicioCampo, i - inicioCampo);
                    // Limpiar comillas dobles alrededor del campo si las hay
                    campo = LimpiarCampo(campo);
                    campos.Add(campo);
                    inicioCampo = i + 1;
                }
            }

            // Último campo
            string ultimoCampo = linea.Substring(inicioCampo);
            ultimoCampo = LimpiarCampo(ultimoCampo);
            campos.Add(ultimoCampo);

            return campos;
        }

        /// <summary>
        /// Elimina comillas dobles al inicio y final si existen, y reemplaza comillas dobles escapadas.
        /// </summary>
        private string LimpiarCampo(string campo)
        {
            campo = campo.Trim();
            if (campo.Length >= 2 && campo[0] == '"' && campo[campo.Length - 1] == '"')
            {
                campo = campo.Substring(1, campo.Length - 2);
                // Reemplazar comillas dobles dobles ("" -> ") si están escapadas así
                campo = campo.Replace("\"\"", "\"");
            }
            return campo;
        }

        private void SalirBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListaCajaPDF_DoubleClick(object sender, EventArgs e)
        {
            int indexSeleccionado = ListaCajaPDF.SelectedIndex;
            if (indexSeleccionado != ListBox.NoMatches)
            {
                string link = ListaCajaPDF.Items[indexSeleccionado].ToString();

                // Validar que sea un link válido
                if (Uri.IsWellFormedUriString(link, UriKind.Absolute))
                {
                    try
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = link,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo abrir el enlace: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("El texto seleccionado no es un enlace válido.");
                }
            }
        }

    }



}
