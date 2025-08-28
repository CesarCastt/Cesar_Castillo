using Prueba1.Helpers;
using Prueba1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Asociamos el evento Load manualmente
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasDataGrids();
        }

        private void ConfigurarColumnasDataGrids()
        {
            // --- Aprobados ---
            dgvAprobados.Columns.Clear();

            dgvAprobados.Columns.Add("NombreAlumno", "Nombre Alumno");
            dgvAprobados.Columns.Add("NombreRamo", "Ramo");
            dgvAprobados.Columns.Add("Nota1", "Nota 1");
            dgvAprobados.Columns.Add("Nota2", "Nota 2");
            dgvAprobados.Columns.Add("Nota3", "Nota 3");
            dgvAprobados.Columns.Add("Nota4", "Nota 4");
            dgvAprobados.Columns.Add("Pond1", "Pond 1");
            dgvAprobados.Columns.Add("Pond2", "Pond 2");
            dgvAprobados.Columns.Add("Pond3", "Pond 3");
            dgvAprobados.Columns.Add("Pond4", "Pond 4");
            dgvAprobados.Columns.Add("NotaEx", "Nota Examen");
            dgvAprobados.Columns.Add("PromFinal", "Prom. Final");

            // --- Reprobados ---
            dgvReprobados.Columns.Clear();

            dgvReprobados.Columns.Add("NombreAlumno", "Nombre Alumno");
            dgvReprobados.Columns.Add("NombreRamo", "Ramo");
            dgvReprobados.Columns.Add("Nota1", "Nota 1");
            dgvReprobados.Columns.Add("Nota2", "Nota 2");
            dgvReprobados.Columns.Add("Nota3", "Nota 3");
            dgvReprobados.Columns.Add("Nota4", "Nota 4");
            dgvReprobados.Columns.Add("Pond1", "Pond 1");
            dgvReprobados.Columns.Add("Pond2", "Pond 2");
            dgvReprobados.Columns.Add("Pond3", "Pond 3");
            dgvReprobados.Columns.Add("Pond4", "Pond 4");
            dgvReprobados.Columns.Add("NotaEx", "Nota Examen");
            dgvReprobados.Columns.Add("PromFinal", "Prom. Final");
            dgvReprobados.Columns.Add("NotaNecesaria", "Nota Necesaria");
        }

        private void btnCalcularNotaNec_Click(object sender, EventArgs e)
        {
            // Validar nombres
            if (!Validators.ValidateName(txtNombreAlumno.Text))
            {
                MessageBox.Show("Debe ingresar un nombre válido del alumno.");
                txtNombreAlumno.Focus();
                return;
            }

            if (!Validators.ValidateName(txtRamo.Text))
            {
                MessageBox.Show("Debe ingresar un nombre válido del ramo.");
                txtRamo.Focus();
                return;
            }

            // Validar notas
            if (!Validators.ValidateGrade(txtN1.Text, out float n1) ||
                !Validators.ValidateGrade(txtN2.Text, out float n2) ||
                !Validators.ValidateGrade(txtN3.Text, out float n3) ||
                !Validators.ValidateGrade(txtN4.Text, out float n4))
            {
                MessageBox.Show("Ingrese notas válidas entre 1.0 y 7.0 para las 4 calificaciones.");
                return;
            }

            // Validar ponderaciones
            if (!Validators.ValidateWeight(txtPond1.Text, out int p1) ||
                !Validators.ValidateWeight(txtPond2.Text, out int p2) ||
                !Validators.ValidateWeight(txtPond3.Text, out int p3) ||
                !Validators.ValidateWeight(txtPond4.Text, out int p4))
            {
                MessageBox.Show("Ingrese ponderaciones válidas entre 10 y 50 para cada calificación.");
                return;
            }

            // Validar suma ponderaciones
            if (!Validators.ValidateTotalWeight(p1, p2, p3, p4))
            {
                MessageBox.Show("La suma de las ponderaciones debe ser exactamente 100%.");
                return;
            }

            // Calcular promedio ponderado de notas (70%)
            float promedioNotas = Calculos.CalcularPromedioNotas(n1, n2, n3, n4, p1, p2, p3, p4);

            // Mostrar promedio 70% en el label
            lbl70.Text = promedioNotas.ToString("F1");

            // Calcular nota necesaria en examen para aprobar
            float notaNecesaria = Calculos.CalcularNotaNecesaria(promedioNotas);

            MessageBox.Show($"La nota necesaria en el examen para aprobar es: {notaNecesaria:F1}");
        }

        private void btnCalcPromedio_Click(object sender, EventArgs e)
        {
            // Validar nombres
            if (!Validators.ValidateName(txtNombreAlumno.Text))
            {
                MessageBox.Show("Debe ingresar un nombre válido del alumno.");
                txtNombreAlumno.Focus();
                return;
            }

            if (!Validators.ValidateName(txtRamo.Text))
            {
                MessageBox.Show("Debe ingresar un nombre válido del ramo.");
                txtRamo.Focus();
                return;
            }

            // Validar notas
            if (!Validators.ValidateGrade(txtN1.Text, out float n1) ||
                !Validators.ValidateGrade(txtN2.Text, out float n2) ||
                !Validators.ValidateGrade(txtN3.Text, out float n3) ||
                !Validators.ValidateGrade(txtN4.Text, out float n4) ||
                !Validators.ValidateGrade(txtNEx.Text, out float nEx))
            {
                MessageBox.Show("Ingrese notas válidas entre 1.0 y 7.0.");
                return;
            }

            // Validar ponderaciones
            if (!Validators.ValidateWeight(txtPond1.Text, out int p1) ||
                !Validators.ValidateWeight(txtPond2.Text, out int p2) ||
                !Validators.ValidateWeight(txtPond3.Text, out int p3) ||
                !Validators.ValidateWeight(txtPond4.Text, out int p4))
            {
                MessageBox.Show("Ingrese ponderaciones válidas entre 10 y 50.");
                return;
            }

            // Validar suma de ponderaciones
            if (!Validators.ValidateTotalWeight(p1, p2, p3, p4))
            {
                MessageBox.Show("La suma de las ponderaciones debe ser exactamente 100%.");
                return;
            }

            // Calcular promedio parcial (70%)
            float promedioNotas = Calculos.CalcularPromedioNotas(n1, n2, n3, n4, p1, p2, p3, p4);
            lbl70.Text = promedioNotas.ToString("F1");

            // Calcular promedio final
            float promedioFinal = Calculos.CalcularPromedioFinal(promedioNotas, nEx);

            if (promedioFinal >= 4.0f)
            {
                var registro = new Registro
                {
                    NombreAlumno = txtNombreAlumno.Text,
                    NombreRamo = txtRamo.Text,
                    Nota1 = n1,
                    Nota2 = n2,
                    Nota3 = n3,
                    Nota4 = n4,
                    Ponderacion1 = p1,
                    Ponderacion2 = p2,
                    Ponderacion3 = p3,
                    Ponderacion4 = p4,
                    NotaExamen = nEx,
                    PromedioFinal = promedioFinal
                };

                dgvAprobados.Rows.Add(
                    registro.NombreAlumno, registro.NombreRamo,
                    registro.Nota1.ToString("F1"), registro.Nota2.ToString("F1"), registro.Nota3.ToString("F1"), registro.Nota4.ToString("F1"),
                    registro.Ponderacion1, registro.Ponderacion2, registro.Ponderacion3, registro.Ponderacion4,
                    registro.NotaExamen.ToString("F1"), registro.PromedioFinal.ToString("F1")
                );
            }
            else
            {
                float notaNecesaria = Calculos.CalcularNotaNecesaria(promedioNotas);

                var registroRep = new RegistroRep
                {
                    NombreAlumno = txtNombreAlumno.Text,
                    NombreRamo = txtRamo.Text,
                    Nota1 = n1,
                    Nota2 = n2,
                    Nota3 = n3,
                    Nota4 = n4,
                    Ponderacion1 = p1,
                    Ponderacion2 = p2,
                    Ponderacion3 = p3,
                    Ponderacion4 = p4,
                    NotaExamen = nEx,
                    PromedioFinal = promedioFinal,
                    NotaNecesariaParaAprobar = notaNecesaria
                };

                dgvReprobados.Rows.Add(
                    registroRep.NombreAlumno, registroRep.NombreRamo,
                    registroRep.Nota1.ToString("F1"), registroRep.Nota2.ToString("F1"), registroRep.Nota3.ToString("F1"), registroRep.Nota4.ToString("F1"),
                    registroRep.Ponderacion1, registroRep.Ponderacion2, registroRep.Ponderacion3, registroRep.Ponderacion4,
                    registroRep.NotaExamen.ToString("F1"), registroRep.PromedioFinal.ToString("F1"),
                    registroRep.NotaNecesariaParaAprobar.ToString("F1")
                );
            }

            MessageBox.Show($"Promedio final: {promedioFinal:F1}");
        }
    }
}
