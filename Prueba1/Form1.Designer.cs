namespace Prueba1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.txtRamo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.txtPond4 = new System.Windows.Forms.TextBox();
            this.txtPond3 = new System.Windows.Forms.TextBox();
            this.txtPond2 = new System.Windows.Forms.TextBox();
            this.txtPond1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNEx = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl70 = new System.Windows.Forms.Label();
            this.btnCalcularNotaNec = new System.Windows.Forms.Button();
            this.btnCalcPromedio = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvReprobados = new System.Windows.Forms.DataGridView();
            this.NombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromedioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaNecesaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAprobados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReprobados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAprobados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ramo";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(83, 47);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(175, 26);
            this.txtNombreAlumno.TabIndex = 2;
            // 
            // txtRamo
            // 
            this.txtRamo.Location = new System.Drawing.Point(338, 47);
            this.txtRamo.Name = "txtRamo";
            this.txtRamo.Size = new System.Drawing.Size(196, 26);
            this.txtRamo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ponderación";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ponderación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ponderación";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ponderación";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(83, 127);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 26);
            this.txtN1.TabIndex = 12;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(83, 180);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 26);
            this.txtN2.TabIndex = 13;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(83, 231);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(100, 26);
            this.txtN3.TabIndex = 14;
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(83, 283);
            this.txtN4.Name = "txtN4";
            this.txtN4.Size = new System.Drawing.Size(100, 26);
            this.txtN4.TabIndex = 15;
            // 
            // txtPond4
            // 
            this.txtPond4.Location = new System.Drawing.Point(367, 280);
            this.txtPond4.Name = "txtPond4";
            this.txtPond4.Size = new System.Drawing.Size(100, 26);
            this.txtPond4.TabIndex = 19;
            // 
            // txtPond3
            // 
            this.txtPond3.Location = new System.Drawing.Point(367, 228);
            this.txtPond3.Name = "txtPond3";
            this.txtPond3.Size = new System.Drawing.Size(100, 26);
            this.txtPond3.TabIndex = 18;
            // 
            // txtPond2
            // 
            this.txtPond2.Location = new System.Drawing.Point(367, 177);
            this.txtPond2.Name = "txtPond2";
            this.txtPond2.Size = new System.Drawing.Size(100, 26);
            this.txtPond2.TabIndex = 17;
            // 
            // txtPond1
            // 
            this.txtPond1.Location = new System.Drawing.Point(367, 124);
            this.txtPond1.Name = "txtPond1";
            this.txtPond1.Size = new System.Drawing.Size(100, 26);
            this.txtPond1.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Examen 30%";
            // 
            // txtNEx
            // 
            this.txtNEx.Location = new System.Drawing.Point(367, 390);
            this.txtNEx.Name = "txtNEx";
            this.txtNEx.Size = new System.Drawing.Size(100, 26);
            this.txtNEx.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Promedio 70%";
            // 
            // lbl70
            // 
            this.lbl70.AutoSize = true;
            this.lbl70.Location = new System.Drawing.Point(160, 396);
            this.lbl70.Name = "lbl70";
            this.lbl70.Size = new System.Drawing.Size(21, 20);
            this.lbl70.TabIndex = 23;
            this.lbl70.Text = "...";
            // 
            // btnCalcularNotaNec
            // 
            this.btnCalcularNotaNec.Location = new System.Drawing.Point(108, 341);
            this.btnCalcularNotaNec.Name = "btnCalcularNotaNec";
            this.btnCalcularNotaNec.Size = new System.Drawing.Size(75, 37);
            this.btnCalcularNotaNec.TabIndex = 24;
            this.btnCalcularNotaNec.Text = "Calcular";
            this.btnCalcularNotaNec.UseVisualStyleBackColor = true;
            this.btnCalcularNotaNec.Click += new System.EventHandler(this.btnCalcularNotaNec_Click);
            // 
            // btnCalcPromedio
            // 
            this.btnCalcPromedio.Location = new System.Drawing.Point(392, 460);
            this.btnCalcPromedio.Name = "btnCalcPromedio";
            this.btnCalcPromedio.Size = new System.Drawing.Size(75, 36);
            this.btnCalcPromedio.TabIndex = 25;
            this.btnCalcPromedio.Text = "Calcular";
            this.btnCalcPromedio.UseVisualStyleBackColor = true;
            this.btnCalcPromedio.Click += new System.EventHandler(this.btnCalcPromedio_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(606, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Alumnos aprobados";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(601, 349);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "Alumnos reprobados";
            // 
            // dgvReprobados
            // 
            this.dgvReprobados.AllowUserToAddRows = false;
            this.dgvReprobados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReprobados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreAlumno,
            this.NombreRamo,
            this.NotaExamen,
            this.PromedioFinal,
            this.NotaNecesaria});
            this.dgvReprobados.Location = new System.Drawing.Point(523, 396);
            this.dgvReprobados.Name = "dgvReprobados";
            this.dgvReprobados.RowHeadersWidth = 62;
            this.dgvReprobados.RowTemplate.Height = 28;
            this.dgvReprobados.Size = new System.Drawing.Size(799, 150);
            this.dgvReprobados.TabIndex = 29;
            // 
            // NombreAlumno
            // 
            this.NombreAlumno.HeaderText = "Nombre Alumno";
            this.NombreAlumno.MinimumWidth = 8;
            this.NombreAlumno.Name = "NombreAlumno";
            this.NombreAlumno.Width = 150;
            // 
            // NombreRamo
            // 
            this.NombreRamo.HeaderText = "Nombre Ramo";
            this.NombreRamo.MinimumWidth = 8;
            this.NombreRamo.Name = "NombreRamo";
            this.NombreRamo.Width = 150;
            // 
            // NotaExamen
            // 
            this.NotaExamen.HeaderText = "Nota Examen";
            this.NotaExamen.MinimumWidth = 8;
            this.NotaExamen.Name = "NotaExamen";
            this.NotaExamen.Width = 150;
            // 
            // PromedioFinal
            // 
            this.PromedioFinal.HeaderText = "Promedio Final";
            this.PromedioFinal.MinimumWidth = 8;
            this.PromedioFinal.Name = "PromedioFinal";
            this.PromedioFinal.Width = 150;
            // 
            // NotaNecesaria
            // 
            this.NotaNecesaria.HeaderText = "Nota Minima para aprobar";
            this.NotaNecesaria.MinimumWidth = 8;
            this.NotaNecesaria.Name = "NotaNecesaria";
            this.NotaNecesaria.Width = 150;
            // 
            // dgvAprobados
            // 
            this.dgvAprobados.AllowUserToAddRows = false;
            this.dgvAprobados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAprobados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvAprobados.Location = new System.Drawing.Point(523, 147);
            this.dgvAprobados.Name = "dgvAprobados";
            this.dgvAprobados.RowHeadersWidth = 62;
            this.dgvAprobados.RowTemplate.Height = 28;
            this.dgvAprobados.Size = new System.Drawing.Size(730, 150);
            this.dgvAprobados.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre Alumno";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre Ramo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nota Examen";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Promedio Final";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 862);
            this.Controls.Add(this.dgvAprobados);
            this.Controls.Add(this.dgvReprobados);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCalcPromedio);
            this.Controls.Add(this.btnCalcularNotaNec);
            this.Controls.Add(this.lbl70);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNEx);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPond4);
            this.Controls.Add(this.txtPond3);
            this.Controls.Add(this.txtPond2);
            this.Controls.Add(this.txtPond1);
            this.Controls.Add(this.txtN4);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRamo);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReprobados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAprobados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.TextBox txtRamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtN4;
        private System.Windows.Forms.TextBox txtPond4;
        private System.Windows.Forms.TextBox txtPond3;
        private System.Windows.Forms.TextBox txtPond2;
        private System.Windows.Forms.TextBox txtPond1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNEx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl70;
        private System.Windows.Forms.Button btnCalcularNotaNec;
        private System.Windows.Forms.Button btnCalcPromedio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvReprobados;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromedioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaNecesaria;
        private System.Windows.Forms.DataGridView dgvAprobados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

