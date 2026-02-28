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

namespace repaso
{
    public partial class Form1 : Form
    {
        List<empleado> empleadoslist = new List<empleado>();
        List<Asistencia>asistencias=new List<Asistencia>();
        List<Reporte>reportes=new List<Reporte>();
        public Form1()
        {
            InitializeComponent();

        }
        private void LeerAsistencia()
        {
            string fileName = "Asistencia.txt";


            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)

            {
                Asistencia asistencia=new Asistencia();
                asistencia.NoEmpleado=Convert.ToInt16(reader.ReadLine());
                asistencia.Horastrabajadas= Convert.ToInt16(reader.ReadLine());
                asistencia.Mes= Convert.ToInt16(reader.ReadLine());
                asistencias.Add(asistencia);
            }

            reader.Close();
            showAsistencia();

        }

        private void LeerEmpleado()
        {

            string fileName = "Dataempleados.txt";


            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)

            {
                empleado leerempleado = new empleado();
                leerempleado.Numeroempleado = Convert.ToInt16(reader.ReadLine());
                leerempleado.Nombre = reader.ReadLine();
                leerempleado.Apellido = reader.ReadLine();
                leerempleado.Sueldoxhora = Convert.ToDecimal(reader.ReadLine());

                empleadoslist.Add(leerempleado);
            }

            reader.Close();
            mostrar();

        }
        private void mostrar()
        {
            dataGridViewEmpleados.DataSource = null;
            dataGridViewEmpleados.DataSource = empleadoslist;
        }
        private void showAsistencia()
        {
            dataGridViewAsistencia.DataSource = null;
            dataGridViewAsistencia.DataSource = asistencias;

        }

        private void showReporte()
        {
            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = reportes;
        }

        private void GuardarEmpleado()
        {
            FileStream stream = new FileStream("Dataempleados.txt", FileMode.Create, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            foreach (var item in empleadoslist)
            {
                writer.WriteLine(item.Numeroempleado);
                writer.WriteLine(item.Nombre);
                writer.WriteLine(item.Apellido);
                writer.WriteLine(item.Sueldoxhora);
            }

            writer.Close();
            mostrar();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LeerEmpleado();
            LeerAsistencia();
            mostrar();
            numericEmpleado.Value = empleadoslist.Count + 1;

        }

        private void buttonEmpleado_Click(object sender, EventArgs e)
        {
            //p
            empleado nuevoempleado = new empleado();
            nuevoempleado.Numeroempleado = Convert.ToInt16(numericEmpleado.Value);
            nuevoempleado.Nombre = textBoxNombre.Text;
            nuevoempleado.Apellido = textBoxApellido.Text;
            nuevoempleado.Sueldoxhora = numericSueldo.Value;

            empleadoslist.Add(nuevoempleado);
            GuardarEmpleado();
            mostrar();
            //w
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {

            foreach (var empleado in empleadoslist)
            {
                foreach (var asistencia in asistencias)
                {
                    if (empleado.Numeroempleado == asistencia.NoEmpleado)
                    {
                        Reporte reporte = new Reporte();
                        reporte.Nombre = empleado.Nombre;
                        reporte.Apellido = empleado.Apellido;
                        reporte.SueldoMes = empleado.Sueldoxhora * asistencia.Horastrabajadas;
                        reporte.Mes = asistencia.Mes;
                        reportes.Add(reporte);
                    }
                }
            }
            showReporte();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Asistencia asistencia = new Asistencia();
            asistencia.NoEmpleado = Convert.ToInt16(numericEmpleadoAsistencia.Value);
            asistencia.Horastrabajadas = Convert.ToInt16(numericHorasTrabajadasAsistencia.Value);
            asistencia.Mes = Convert.ToInt16(numericMesAsistencia.Value);
            asistencias.Add(asistencia);
            GuardarAsistencia();
            showAsistencia();
            


        }

        private void GuardarAsistencia()
        {
            FileStream stream = new FileStream("Asistencia.txt", FileMode.Create, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            foreach (var item in asistencias)
            {
                writer.WriteLine(item.NoEmpleado);
                writer.WriteLine(item.Horastrabajadas);
                writer.WriteLine(item.Mes);

            }

            writer.Close();
            showAsistencia();

        }
    }
}
