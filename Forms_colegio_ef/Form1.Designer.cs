
namespace Forms_colegio_ef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GridAlumnos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Alumnos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textProfesor = new System.Windows.Forms.TextBox();
            this.comboCurso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // GridAlumnos
            // 
            this.GridAlumnos.BackgroundColor = System.Drawing.Color.White;
            this.GridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAlumnos.Location = new System.Drawing.Point(363, 119);
            this.GridAlumnos.Name = "GridAlumnos";
            this.GridAlumnos.RowHeadersWidth = 51;
            this.GridAlumnos.RowTemplate.Height = 24;
            this.GridAlumnos.Size = new System.Drawing.Size(448, 255);
            this.GridAlumnos.TabIndex = 0;
            this.GridAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Curso : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profesor(a) : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Alumnos
            // 
            this.Alumnos.AutoSize = true;
            this.Alumnos.Location = new System.Drawing.Point(422, 74);
            this.Alumnos.Name = "Alumnos";
            this.Alumnos.Size = new System.Drawing.Size(99, 17);
            this.Alumnos.TabIndex = 3;
            this.Alumnos.Text = "Alumnos(as) : ";
            this.Alumnos.Click += new System.EventHandler(this.Alumnos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 5;
            // 
            // textProfesor
            // 
            this.textProfesor.Location = new System.Drawing.Point(188, 340);
            this.textProfesor.Name = "textProfesor";
            this.textProfesor.ReadOnly = true;
            this.textProfesor.Size = new System.Drawing.Size(121, 22);
            this.textProfesor.TabIndex = 6;
            // 
            // comboCurso
            // 
            this.comboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCurso.FormattingEnabled = true;
            this.comboCurso.Location = new System.Drawing.Point(188, 119);
            this.comboCurso.Name = "comboCurso";
            this.comboCurso.Size = new System.Drawing.Size(121, 24);
            this.comboCurso.TabIndex = 7;
            this.comboCurso.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(839, 504);
            this.Controls.Add(this.comboCurso);
            this.Controls.Add(this.textProfesor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Alumnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridAlumnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Alumnos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textProfesor;
        private System.Windows.Forms.ComboBox comboCurso;
    }
}

