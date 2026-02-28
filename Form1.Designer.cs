namespace repaso
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonEmpleado = new System.Windows.Forms.Button();
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.numericSueldo = new System.Windows.Forms.NumericUpDown();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.numericEmpleado = new System.Windows.Forms.NumericUpDown();
            this.labelSueldo = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelNumEmpleado = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewAsistencia = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonReporte = new System.Windows.Forms.Button();
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericEmpleadoAsistencia = new System.Windows.Forms.NumericUpDown();
            this.numericHorasTrabajadasAsistencia = new System.Windows.Forms.NumericUpDown();
            this.numericMesAsistencia = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSueldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEmpleado)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistencia)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEmpleadoAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHorasTrabajadasAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMesAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(997, 494);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonEmpleado);
            this.tabPage1.Controls.Add(this.dataGridViewEmpleados);
            this.tabPage1.Controls.Add(this.numericSueldo);
            this.tabPage1.Controls.Add(this.textBoxApellido);
            this.tabPage1.Controls.Add(this.textBoxNombre);
            this.tabPage1.Controls.Add(this.numericEmpleado);
            this.tabPage1.Controls.Add(this.labelSueldo);
            this.tabPage1.Controls.Add(this.labelApellido);
            this.tabPage1.Controls.Add(this.labelNombre);
            this.tabPage1.Controls.Add(this.labelNumEmpleado);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(989, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empleados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonEmpleado
            // 
            this.buttonEmpleado.Location = new System.Drawing.Point(406, 354);
            this.buttonEmpleado.Name = "buttonEmpleado";
            this.buttonEmpleado.Size = new System.Drawing.Size(175, 64);
            this.buttonEmpleado.TabIndex = 9;
            this.buttonEmpleado.Text = "Ingresar empleado";
            this.buttonEmpleado.UseVisualStyleBackColor = true;
            this.buttonEmpleado.Click += new System.EventHandler(this.buttonEmpleado_Click);
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(481, 44);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.RowHeadersWidth = 51;
            this.dataGridViewEmpleados.RowTemplate.Height = 24;
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(502, 261);
            this.dataGridViewEmpleados.TabIndex = 8;
            this.dataGridViewEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numericSueldo
            // 
            this.numericSueldo.DecimalPlaces = 2;
            this.numericSueldo.Location = new System.Drawing.Point(259, 283);
            this.numericSueldo.Name = "numericSueldo";
            this.numericSueldo.Size = new System.Drawing.Size(189, 22);
            this.numericSueldo.TabIndex = 7;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(259, 208);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(189, 22);
            this.textBoxApellido.TabIndex = 6;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(259, 135);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(189, 22);
            this.textBoxNombre.TabIndex = 5;
            // 
            // numericEmpleado
            // 
            this.numericEmpleado.Location = new System.Drawing.Point(259, 53);
            this.numericEmpleado.Name = "numericEmpleado";
            this.numericEmpleado.Size = new System.Drawing.Size(189, 22);
            this.numericEmpleado.TabIndex = 4;
            // 
            // labelSueldo
            // 
            this.labelSueldo.AutoSize = true;
            this.labelSueldo.Location = new System.Drawing.Point(42, 285);
            this.labelSueldo.Name = "labelSueldo";
            this.labelSueldo.Size = new System.Drawing.Size(95, 16);
            this.labelSueldo.TabIndex = 3;
            this.labelSueldo.Text = "Sueldo x  Hora";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(41, 211);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(122, 16);
            this.labelApellido.TabIndex = 2;
            this.labelApellido.Text = "Apellido empleado";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(41, 138);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(121, 16);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre empleado";
            // 
            // labelNumEmpleado
            // 
            this.labelNumEmpleado.AutoSize = true;
            this.labelNumEmpleado.Location = new System.Drawing.Point(41, 53);
            this.labelNumEmpleado.Name = "labelNumEmpleado";
            this.labelNumEmpleado.Size = new System.Drawing.Size(139, 16);
            this.labelNumEmpleado.TabIndex = 0;
            this.labelNumEmpleado.Text = "Numero de empleado";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericMesAsistencia);
            this.tabPage2.Controls.Add(this.numericHorasTrabajadasAsistencia);
            this.tabPage2.Controls.Add(this.numericEmpleadoAsistencia);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridViewAsistencia);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(989, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asistencia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "ASISTENCIA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewAsistencia
            // 
            this.dataGridViewAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsistencia.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewAsistencia.Name = "dataGridViewAsistencia";
            this.dataGridViewAsistencia.RowHeadersWidth = 51;
            this.dataGridViewAsistencia.RowTemplate.Height = 24;
            this.dataGridViewAsistencia.Size = new System.Drawing.Size(494, 324);
            this.dataGridViewAsistencia.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonReporte);
            this.tabPage3.Controls.Add(this.dataGridViewReporte);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(989, 465);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reporte";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonReporte
            // 
            this.buttonReporte.Location = new System.Drawing.Point(375, 385);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(192, 49);
            this.buttonReporte.TabIndex = 1;
            this.buttonReporte.Text = "Generar reporte";
            this.buttonReporte.UseVisualStyleBackColor = true;
            this.buttonReporte.Click += new System.EventHandler(this.buttonReporte_Click);
            // 
            // dataGridViewReporte
            // 
            this.dataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporte.Location = new System.Drawing.Point(21, 26);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.RowHeadersWidth = 51;
            this.dataGridViewReporte.RowTemplate.Height = 24;
            this.dataGridViewReporte.Size = new System.Drawing.Size(905, 315);
            this.dataGridViewReporte.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "No empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horas trabajadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mes";
            // 
            // numericEmpleadoAsistencia
            // 
            this.numericEmpleadoAsistencia.Location = new System.Drawing.Point(786, 35);
            this.numericEmpleadoAsistencia.Name = "numericEmpleadoAsistencia";
            this.numericEmpleadoAsistencia.Size = new System.Drawing.Size(146, 22);
            this.numericEmpleadoAsistencia.TabIndex = 5;
            // 
            // numericHorasTrabajadasAsistencia
            // 
            this.numericHorasTrabajadasAsistencia.Location = new System.Drawing.Point(786, 130);
            this.numericHorasTrabajadasAsistencia.Name = "numericHorasTrabajadasAsistencia";
            this.numericHorasTrabajadasAsistencia.Size = new System.Drawing.Size(146, 22);
            this.numericHorasTrabajadasAsistencia.TabIndex = 6;
            // 
            // numericMesAsistencia
            // 
            this.numericMesAsistencia.Location = new System.Drawing.Point(772, 273);
            this.numericMesAsistencia.Name = "numericMesAsistencia";
            this.numericMesAsistencia.Size = new System.Drawing.Size(146, 22);
            this.numericMesAsistencia.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 518);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSueldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEmpleado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistencia)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEmpleadoAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHorasTrabajadasAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMesAsistencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelSueldo;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelNumEmpleado;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.NumericUpDown numericSueldo;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.NumericUpDown numericEmpleado;
        private System.Windows.Forms.Button buttonEmpleado;
        private System.Windows.Forms.Button buttonReporte;
        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.DataGridView dataGridViewAsistencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericMesAsistencia;
        private System.Windows.Forms.NumericUpDown numericHorasTrabajadasAsistencia;
        private System.Windows.Forms.NumericUpDown numericEmpleadoAsistencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

