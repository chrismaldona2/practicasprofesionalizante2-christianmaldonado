using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;

namespace Front
{

    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
        }
        string url = "https://catfact.ninja/";
        public class Dato
        {
            public string fact { get; set; }
            public int lenght { get; set; }
        }
        private async void generarDatoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int limite;
                if (int.TryParse(limiteDato.Text, out limite))
                {
                    url = $"https://catfact.ninja/fact?max_length={limite}";
                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.GetAsync(url);

                        if (response.IsSuccessStatusCode)
                        {
                            string json = await response.Content.ReadAsStringAsync();
                            var dato = JsonSerializer.Deserialize<Dato>(json);
                            if (dato.fact == null)
                            {
                                MessageBox.Show("Muy pocos caracteres. Intente con 20 o más.", "Dato");
                            } else
                            {
                                MessageBox.Show(dato.fact, "Dato");
                            }
                            
                        }
                    }
                }
                else
                {
                    throw new Exception("Límite de caracteres inválido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listaRazasBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int limiteRazas;
                if (int.TryParse(limiteLista.Text, out limiteRazas) || limiteRazas >= 0)
                {
                    url = $"https://catfact.ninja/breeds?limit={limiteRazas}";
                    ListaRazas pantallaLista = new ListaRazas(url);
                    pantallaLista.ShowDialog();
                }
                else
                {
                    throw new Exception("Límite de razas invalido. Debe ser un número mayor o igual a 0.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
