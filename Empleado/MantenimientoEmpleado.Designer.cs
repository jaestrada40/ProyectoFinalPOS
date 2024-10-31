namespace ProyectoFinalPOS
{
    partial class MantenimientoEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxEmpleado = new TextBox();
            buttonBuscar = new Button();
            btnAgregar = new PictureBox();
            label1 = new Label();
            flowEmpleados = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)btnAgregar).BeginInit();
            SuspendLayout();
            // 
            // textBoxEmpleado
            // 
            textBoxEmpleado.Location = new Point(60, 58);
            textBoxEmpleado.Name = "textBoxEmpleado";
            textBoxEmpleado.PlaceholderText = "Ingrese el Nombre del Empleado";
            textBoxEmpleado.Size = new Size(337, 27);
            textBoxEmpleado.TabIndex = 0;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(436, 53);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(180, 36);
            buttonBuscar.TabIndex = 1;
            buttonBuscar.Text = "Buscar Empleado";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(734, 35);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 61);
            btnAgregar.TabIndex = 2;
            btnAgregar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(824, 53);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 3;
            label1.Text = "Agregar Empleado";
            label1.Click += label1_Click;
            // 
            // flowEmpleados
            // 
            flowEmpleados.Location = new Point(61, 132);
            flowEmpleados.Name = "flowEmpleados";
            flowEmpleados.Size = new Size(1005, 480);
            flowEmpleados.TabIndex = 4;
            // 
            // MantenimientoEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 643);
            Controls.Add(flowEmpleados);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxEmpleado);
            Name = "MantenimientoEmpleado";
            Text = "Mantenimiento de Empleados";
            ((System.ComponentModel.ISupportInitialize)btnAgregar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmpleado;
        private Button buttonBuscar;
        private PictureBox btnAgregar;
        private Label label1;
        private FlowLayoutPanel flowEmpleados;
    }
}