using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Front.Inicio;

namespace Front
{
    public partial class ListaRazas : Form
    {
        public class Gato
        {
            public string breed { get; set; }
            public string country { get; set; }
            public string origin { get; set; }
            public string coat { get; set; }
            public string pattern { get; set; }
        }
        public class ApiResponde
        {
            public List<Gato> data { get; set; }
        }
        private string url;
        public ListaRazas(string Url)
        {
            InitializeComponent();
            url = Url;
        }

        private async void ListaRazas_Load(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        ApiResponde apiResponse = JsonSerializer.Deserialize<ApiResponde> (json);
                        razasDataGridView.DataSource = apiResponse.data;
                        razasDataGridView.Columns["breed"].HeaderText = "Raza";
                        razasDataGridView.Columns["country"].HeaderText = "País";
                        razasDataGridView.Columns["origin"].HeaderText = "Origen";
                        razasDataGridView.Columns["coat"].HeaderText = "Pelaje";
                        razasDataGridView.Columns["pattern"].HeaderText = "Patrón de pelaje";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
