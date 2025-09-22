using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using System;
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
    public partial class frmNomina : Form
    {
        private FileSystemWatcher watcher;
        double horasRegulares=0;
        double horasExtras=0;
        double horasDobles=0;
        string ajustesJson= AppContext.BaseDirectory + "ajustes.json";
        int extra = 0;
        List<string> columnas;
        public frmNomina()
        {
            InitializeComponent();
            ConfigurarWatcher();
            columnas = new List<string>
            { 
                "EE",
                "Nombre",
                "Apellido",
                "Rg. Hrs",
                "OT. Hrs.",
                "D Hrs."
            };

            if (File.Exists(ajustesJson))
            {
                cargarAjustes();
            }
            else
            {
                ajustesGeneral();
                MessageBox.Show("No existe una configuracion previa \nPuede crear una en Ajustes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ajustesGeneral()
        {
            var ajustesValores = new
            {
                horasRegulares = 0,
                horasExtras = 0,
                horasDobles = 0
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
        }

        private void cargarAjustes()
        {
            try
            {
                string json = File.ReadAllText(ajustesJson);
                JObject obj = JObject.Parse(json);

                horasRegulares = double.Parse(obj["horasRegulares"].ToString());
                horasExtras = double.Parse(obj["horasExtras"].ToString());
                horasDobles = double.Parse(obj["horasDobles"].ToString());
            }
            catch (Exception ex) 
            {
                ajustesGeneral();
                MessageBox.Show("Algo terrible ha sucedido\nLos datos se han corrompido o modificado de manera\n incorrecta se generaran de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void importarExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdExcel.ShowDialog() == DialogResult.OK)
            {
                string archivo = ofdExcel.FileName;
                //MessageBox.Show("Archivo seleccionado: " + archivo);
                CargarExcel(archivo);

            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            ttsHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void CargarExcel(string path)
        {
            DataTable dt = new DataTable();
            ExcelPackage.License.SetNonCommercialPersonal("Jose Luis Mota Espeleta");

            using (var package = new ExcelPackage(new System.IO.FileInfo(path)))
            {
                if (package.Workbook.Worksheets.Count == 0)
                {
                    MessageBox.Show("El archivo de Excel no contiene hojas de trabajo.");
                    return; //En caso que no haya hojas
                }

                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                // Leer los encabezados de columna
                foreach (var col in columnas)
                {
                    dt.Columns.Add(col);
                }

                // Leer las filas de datos
                int rowCount = 0;
                for (int i = 3; i < worksheet.Dimension.End.Row; i++)
                {
                    if (worksheet.Cells[i, 1].Text == "")
                        break;
                    else
                        rowCount = rowCount + 1;
                }
                rowCount = rowCount + 3;
                for (int i = 3; i < rowCount; i++)
                        {
                            DataRow row = dt.NewRow();
                            for (int j = 1; j < dt.Columns.Count + 1; j++)
                            {
                                if (worksheet.Cells[i, j].Text == "")
                                    break;
                                row[j - 1] = worksheet.Cells[i, j].Text;
                                if (j == 2)
                                {
                                    string[] partes = SepararNombre(worksheet.Cells[i, j].Text);
                                    row[1] = partes[1];
                                    row[2] = partes[0];
                                    j++;
                                }
                            }
                            dt.Rows.Add(row);
                        }


            }

            // Mostrar los datos en el DataGridView
            dgvInformacion.Rows.Add(dt.Rows.Count);
            
           for (int i=0;i<dt.Rows.Count;i++)
           {
                for(int j = 0; j < 6; j++)
                {
                  dgvInformacion.Rows[i+extra].Cells[j].Value = dt.Rows[i][j].ToString();
                }

           }
           extra = dgvInformacion.RowCount;
        }

        private string [] SepararNombre(string nombreCompleto)
        { 
            
            string[] partes = nombreCompleto.Split(',');
            if (partes.Length >= 2)
            {
                string apellido = partes[0];
                string nombre = partes[1]; 
                partes[1] = nombre.Trim();               
            }
            return partes;
        }

        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjustes frm = new frmAjustes();
            frm.Show();
        }

        private void dgvInformacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            for(int i=0; i < dgvInformacion.RowCount; i++)
            {
                dgvInformacion.Rows[i].Cells[6].Value = double.Parse(dgvInformacion.Rows[i].Cells[3].Value.ToString()) * horasRegulares;
                dgvInformacion.Rows[i].Cells[7].Value = double.Parse(dgvInformacion.Rows[i].Cells[4].Value.ToString()) * horasExtras;
                dgvInformacion.Rows[i].Cells[8].Value = double.Parse(dgvInformacion.Rows[i].Cells[5].Value.ToString()) * horasDobles;
                dgvInformacion.Rows[i].Cells[9].Value = double.Parse(dgvInformacion.Rows[i].Cells[6].Value.ToString()) + double.Parse(dgvInformacion.Rows[i].Cells[7].Value.ToString()) + double.Parse(dgvInformacion.Rows[i].Cells[8].Value.ToString());
            }
        }

        private void ConfigurarWatcher()
        {
            watcher = new FileSystemWatcher();
            // carpeta donde está tu exe
            watcher.Path = AppContext.BaseDirectory;
            // el archivo que quieres vigilar
            watcher.Filter = "ajustes.json";
            // detectar cambios en escritura
            watcher.NotifyFilter = NotifyFilters.LastWrite;

            watcher.Changed += Watcher_Changed;

            watcher.EnableRaisingEvents = true;
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            // Como el evento viene de otro hilo, usamos Invoke
            this.Invoke(new Action(() =>
            {
                cargarAjustes();
            }));
        }

    }
}