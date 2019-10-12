namespace RegistroAsistenciasDetalle.UI.Registros
{
    partial class rAsistencias
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
            this.components = new System.ComponentModel.Container();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EstudiantesDataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarAsistenciaButton = new System.Windows.Forms.Button();
            this.AgregarEstudianteButton = new System.Windows.Forms.Button();
            this.PresenteCheckBox = new System.Windows.Forms.CheckBox();
            this.EstudianteComboBox = new System.Windows.Forms.ComboBox();
            this.AsignaturaComboBox = new System.Windows.Forms.ComboBox();
            this.AgregarAsignaturaButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(496, 11);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(148, 22);
            this.FechaDateTimePicker.TabIndex = 24;
            // 
            // IDNumericUpDown
            // 
            this.IDNumericUpDown.Location = new System.Drawing.Point(69, 10);
            this.IDNumericUpDown.Name = "IDNumericUpDown";
            this.IDNumericUpDown.ReadOnly = true;
            this.IDNumericUpDown.Size = new System.Drawing.Size(199, 22);
            this.IDNumericUpDown.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label9.Location = new System.Drawing.Point(414, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 27);
            this.label9.TabIndex = 22;
            this.label9.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackColor = System.Drawing.Color.Transparent;
            this.BuscarButton.Image = global::RegistroAsistenciasDetalle.Properties.Resources._56060734_buscar_botón_cuadrado_blanco;
            this.BuscarButton.Location = new System.Drawing.Point(288, 10);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(69, 57);
            this.BuscarButton.TabIndex = 25;
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.UseVisualStyleBackColor = false;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "Asignatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 27);
            this.label3.TabIndex = 27;
            this.label3.Text = "Estudiante";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.CantidadTextBox);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.EstudiantesDataGridView);
            this.groupBox.Controls.Add(this.AgregarAsistenciaButton);
            this.groupBox.Controls.Add(this.AgregarEstudianteButton);
            this.groupBox.Controls.Add(this.PresenteCheckBox);
            this.groupBox.Controls.Add(this.EstudianteComboBox);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Location = new System.Drawing.Point(12, 140);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(632, 405);
            this.groupBox.TabIndex = 28;
            this.groupBox.TabStop = false;
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(117, 368);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(175, 22);
            this.CantidadTextBox.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(6, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 27);
            this.label4.TabIndex = 35;
            this.label4.Text = "Cantidad";
            // 
            // EstudiantesDataGridView
            // 
            this.EstudiantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiantesDataGridView.Location = new System.Drawing.Point(11, 89);
            this.EstudiantesDataGridView.Name = "EstudiantesDataGridView";
            this.EstudiantesDataGridView.RowHeadersWidth = 51;
            this.EstudiantesDataGridView.RowTemplate.Height = 24;
            this.EstudiantesDataGridView.Size = new System.Drawing.Size(615, 258);
            this.EstudiantesDataGridView.TabIndex = 34;
            // 
            // AgregarAsistenciaButton
            // 
            this.AgregarAsistenciaButton.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarAsistenciaButton.Image = global::RegistroAsistenciasDetalle.Properties.Resources.vector_plus_icon;
            this.AgregarAsistenciaButton.Location = new System.Drawing.Point(586, 46);
            this.AgregarAsistenciaButton.Name = "AgregarAsistenciaButton";
            this.AgregarAsistenciaButton.Size = new System.Drawing.Size(40, 28);
            this.AgregarAsistenciaButton.TabIndex = 33;
            this.AgregarAsistenciaButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarAsistenciaButton.UseVisualStyleBackColor = true;
            this.AgregarAsistenciaButton.Click += new System.EventHandler(this.AgregarAsistenciaButton_Click);
            // 
            // AgregarEstudianteButton
            // 
            this.AgregarEstudianteButton.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarEstudianteButton.Image = global::RegistroAsistenciasDetalle.Properties.Resources.vector_plus_icon;
            this.AgregarEstudianteButton.Location = new System.Drawing.Point(360, 46);
            this.AgregarEstudianteButton.Name = "AgregarEstudianteButton";
            this.AgregarEstudianteButton.Size = new System.Drawing.Size(40, 28);
            this.AgregarEstudianteButton.TabIndex = 32;
            this.AgregarEstudianteButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarEstudianteButton.UseVisualStyleBackColor = true;
            this.AgregarEstudianteButton.Click += new System.EventHandler(this.AgregarEstudianteButton_Click);
            // 
            // PresenteCheckBox
            // 
            this.PresenteCheckBox.AutoSize = true;
            this.PresenteCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresenteCheckBox.Location = new System.Drawing.Point(468, 46);
            this.PresenteCheckBox.Name = "PresenteCheckBox";
            this.PresenteCheckBox.Size = new System.Drawing.Size(112, 31);
            this.PresenteCheckBox.TabIndex = 31;
            this.PresenteCheckBox.Text = "Presente";
            this.PresenteCheckBox.UseVisualStyleBackColor = true;
            // 
            // EstudianteComboBox
            // 
            this.EstudianteComboBox.FormattingEnabled = true;
            this.EstudianteComboBox.Location = new System.Drawing.Point(11, 48);
            this.EstudianteComboBox.Name = "EstudianteComboBox";
            this.EstudianteComboBox.Size = new System.Drawing.Size(334, 24);
            this.EstudianteComboBox.TabIndex = 30;
            // 
            // AsignaturaComboBox
            // 
            this.AsignaturaComboBox.FormattingEnabled = true;
            this.AsignaturaComboBox.Location = new System.Drawing.Point(156, 79);
            this.AsignaturaComboBox.Name = "AsignaturaComboBox";
            this.AsignaturaComboBox.Size = new System.Drawing.Size(434, 24);
            this.AsignaturaComboBox.TabIndex = 29;
            // 
            // AgregarAsignaturaButton
            // 
            this.AgregarAsignaturaButton.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarAsignaturaButton.Image = global::RegistroAsistenciasDetalle.Properties.Resources.vector_plus_icon;
            this.AgregarAsignaturaButton.Location = new System.Drawing.Point(604, 78);
            this.AgregarAsignaturaButton.Name = "AgregarAsignaturaButton";
            this.AgregarAsignaturaButton.Size = new System.Drawing.Size(40, 28);
            this.AgregarAsignaturaButton.TabIndex = 34;
            this.AgregarAsignaturaButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarAsignaturaButton.UseVisualStyleBackColor = true;
            this.AgregarAsignaturaButton.Click += new System.EventHandler(this.AgregarAsignaturaButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::RegistroAsistenciasDetalle.Properties.Resources.depositphotos_112775736_stock_photo_save_floppy_disk_icon_white;
            this.GuardarButton.Location = new System.Drawing.Point(278, 561);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(104, 72);
            this.GuardarButton.TabIndex = 37;
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::RegistroAsistenciasDetalle.Properties.Resources.Delete_Button;
            this.EliminarButton.Location = new System.Drawing.Point(540, 561);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(104, 72);
            this.EliminarButton.TabIndex = 36;
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::RegistroAsistenciasDetalle.Properties.Resources.depositphotos_85627942_stock_illustration_silver_rounded_new_button;
            this.NuevoButton.Location = new System.Drawing.Point(12, 561);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(104, 72);
            this.NuevoButton.TabIndex = 35;
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroAsistenciasDetalle.Properties.Resources.and_stick_wallpaper_gris_y_blanco_D_NQ_NP_966277_MLM28445781777_102018_F;
            this.ClientSize = new System.Drawing.Size(660, 658);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.AgregarAsignaturaButton);
            this.Controls.Add(this.AsignaturaComboBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.IDNumericUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "rAsistencias";
            this.Text = "Registro de asistencias";
            this.Load += new System.EventHandler(this.RAsistencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.NumericUpDown IDNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView EstudiantesDataGridView;
        private System.Windows.Forms.Button AgregarAsistenciaButton;
        private System.Windows.Forms.Button AgregarEstudianteButton;
        private System.Windows.Forms.CheckBox PresenteCheckBox;
        private System.Windows.Forms.ComboBox EstudianteComboBox;
        private System.Windows.Forms.ComboBox AsignaturaComboBox;
        private System.Windows.Forms.Button AgregarAsignaturaButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}