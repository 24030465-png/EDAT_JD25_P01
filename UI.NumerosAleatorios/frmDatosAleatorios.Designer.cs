namespace UI.NumerosAleatorios
{
    partial class frmDatosAleatorios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            datos = new Label();
            Nombre = new Label();
            fecha = new Label();
            Masculino = new RadioButton();
            Femenino = new RadioButton();
            Grupo = new Label();
            Sueldo = new Label();
            Seguro = new CheckBox();
            NombreTxt = new TextBox();
            FechaNacimiento = new DateTimePicker();
            SueldoTxt = new TextBox();
            Grupotxt = new TextBox();
            NumeroTxt = new TextBox();
            Numero = new Label();
            btnMostrarMensaje = new Button();
            SuspendLayout();
            // 
            // datos
            // 
            datos.AutoSize = true;
            datos.Location = new Point(12, 9);
            datos.Name = "datos";
            datos.Size = new Size(147, 20);
            datos.TabIndex = 1;
            datos.Text = "Datos Del Empleado";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(54, 77);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 3;
            Nombre.Text = "Nombre";
            // 
            // fecha
            // 
            fecha.AutoSize = true;
            fecha.Location = new Point(54, 114);
            fecha.Name = "fecha";
            fecha.Size = new Size(151, 20);
            fecha.TabIndex = 4;
            fecha.Text = "Fecha De Nacimiento";
            // 
            // Masculino
            // 
            Masculino.AutoSize = true;
            Masculino.Location = new Point(88, 147);
            Masculino.Name = "Masculino";
            Masculino.Size = new Size(97, 24);
            Masculino.TabIndex = 5;
            Masculino.TabStop = true;
            Masculino.Text = "Masculino";
            Masculino.UseVisualStyleBackColor = true;
            // 
            // Femenino
            // 
            Femenino.AutoSize = true;
            Femenino.Location = new Point(88, 177);
            Femenino.Name = "Femenino";
            Femenino.Size = new Size(95, 24);
            Femenino.TabIndex = 6;
            Femenino.TabStop = true;
            Femenino.Text = "Femenino";
            Femenino.UseVisualStyleBackColor = true;
            // 
            // Grupo
            // 
            Grupo.AutoSize = true;
            Grupo.Location = new Point(54, 204);
            Grupo.Name = "Grupo";
            Grupo.Size = new Size(50, 20);
            Grupo.TabIndex = 7;
            Grupo.Text = "Grupo";
            // 
            // Sueldo
            // 
            Sueldo.AutoSize = true;
            Sueldo.Location = new Point(54, 235);
            Sueldo.Name = "Sueldo";
            Sueldo.Size = new Size(55, 20);
            Sueldo.TabIndex = 8;
            Sueldo.Text = "Sueldo";
            // 
            // Seguro
            // 
            Seguro.AutoSize = true;
            Seguro.Location = new Point(88, 268);
            Seguro.Name = "Seguro";
            Seguro.Size = new Size(132, 24);
            Seguro.TabIndex = 9;
            Seguro.Text = "Seguro Medico";
            Seguro.UseVisualStyleBackColor = true;
            // 
            // NombreTxt
            // 
            NombreTxt.Location = new Point(123, 74);
            NombreTxt.Name = "NombreTxt";
            NombreTxt.Size = new Size(222, 27);
            NombreTxt.TabIndex = 11;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.Location = new Point(211, 114);
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Size = new Size(275, 27);
            FechaNacimiento.TabIndex = 12;
            // 
            // SueldoTxt
            // 
            SueldoTxt.Location = new Point(123, 238);
            SueldoTxt.Name = "SueldoTxt";
            SueldoTxt.Size = new Size(135, 27);
            SueldoTxt.TabIndex = 14;
            // 
            // Grupotxt
            // 
            Grupotxt.Location = new Point(123, 205);
            Grupotxt.Name = "Grupotxt";
            Grupotxt.Size = new Size(125, 27);
            Grupotxt.TabIndex = 15;
            // 
            // NumeroTxt
            // 
            NumeroTxt.Location = new Point(123, 42);
            NumeroTxt.Name = "NumeroTxt";
            NumeroTxt.Size = new Size(125, 27);
            NumeroTxt.TabIndex = 10;
            // 
            // Numero
            // 
            Numero.AutoSize = true;
            Numero.Location = new Point(54, 42);
            Numero.Name = "Numero";
            Numero.Size = new Size(63, 20);
            Numero.TabIndex = 2;
            Numero.Text = "Numero";
            // 
            // btnMostrarMensaje
            // 
            btnMostrarMensaje.Location = new Point(54, 365);
            btnMostrarMensaje.Name = "btnMostrarMensaje";
            btnMostrarMensaje.Size = new Size(180, 29);
            btnMostrarMensaje.TabIndex = 16;
            btnMostrarMensaje.Text = "Generar Datos";
            btnMostrarMensaje.UseVisualStyleBackColor = true;
            btnMostrarMensaje.Click += btnMostrarMensaje_Click_1;
            // 
            // frmDatosAleatorios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrarMensaje);
            Controls.Add(Grupotxt);
            Controls.Add(SueldoTxt);
            Controls.Add(FechaNacimiento);
            Controls.Add(NombreTxt);
            Controls.Add(NumeroTxt);
            Controls.Add(Seguro);
            Controls.Add(Sueldo);
            Controls.Add(Grupo);
            Controls.Add(Femenino);
            Controls.Add(Masculino);
            Controls.Add(fecha);
            Controls.Add(Nombre);
            Controls.Add(Numero);
            Controls.Add(datos);
            Name = "frmDatosAleatorios";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label datos;
        private Label Nombre;
        private Label fecha;
        private RadioButton Masculino;
        private RadioButton Femenino;
        private Label Grupo;
        private Label Sueldo;
        private CheckBox Seguro;
        private TextBox NombreTxt;
        private DateTimePicker FechaNacimiento;
        private TextBox SueldoTxt;
        private TextBox Grupotxt;
        private TextBox NumeroTxt;
        private Label Numero;
        private Button btnMostrarMensaje;
    }
}
