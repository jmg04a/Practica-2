using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina
{
    public partial class frmAjustes : Form
    {
        public frmAjustes()
        {
            InitializeComponent();
            string ajustesJson = AppContext.BaseDirectory + "ajustes.json";
            if (File.Exists(ajustesJson))
            {
                try
                {
                    string json = File.ReadAllText(ajustesJson);
                    JObject obj = JObject.Parse(json);

                    tbHorasRegulares.Text = obj["horasRegulares"].ToString();
                    tbHorasExtra.Text = obj["horasExtras"].ToString();
                    tbHorasDobles.Text = obj["horasDobles"].ToString();

                }
                catch(Exception ex) 
                {
                    MessageBox.Show("No existe una configuracion previa", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            try
            {
                var ajustesValores = new
                {
                    horasRegulares = double.Parse(tbHorasRegulares.Text),
                    horasExtras = double.Parse(tbHorasExtra.Text),
                    horasDobles = double.Parse(tbHorasDobles.Text)
                };
                var caractetisticas = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    DateFormatHandling = DateFormatHandling.IsoDateFormat,
                    NullValueHandling = NullValueHandling.Ignore,
                };

                string json = JsonConvert.SerializeObject(ajustesValores, caractetisticas);

                try
                {
                    File.WriteAllText(AppContext.BaseDirectory + "ajustes.json", json);
                    MessageBox.Show("Se ha guardado corectamente", "Tarea existosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo terrible ha sucedido", "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Solo se aceptan numeros \nIntente con algo como \n 20, 3.14 o 30","Valores inesperados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
