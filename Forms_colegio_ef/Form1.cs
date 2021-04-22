using Forms_colegio_ef.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_colegio_ef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContextBD bd = new ContextBD();

            GridAlumnos.DataSource = bd.Alumnos.ToList();
            GridAlumnos.Columns[3].Visible = false;
            GridAlumnos.Columns[4].Visible = false;

            comboCurso.DataSource = bd.Cursos.ToList();
            comboCurso.DisplayMember = "Nombre";
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ContextBD bd = new ContextBD();

            Curso CS = (Curso)comboCurso.SelectedItem;
            List<Alumno> alumnoCursos = CS.Alumnos.ToList();

            GridAlumnos.DataSource = alumnoCursos;

            //---------------------------------------------------------------------------------------------


            textProfesor.Text = CS.Profesore.nombre;

           
        }

        private void Alumnos_Click(object sender, EventArgs e)
        {

        }
    }
}
