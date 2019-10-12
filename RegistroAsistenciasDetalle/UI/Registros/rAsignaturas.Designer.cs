namespace RegistroAsistenciasDetalle.UI.Registros
{
    partial class rAsignaturas
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
            this.IDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AsignaturaTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IDNumericUpDown
            // 
            this.IDNumericUpDown.Location = new System.Drawing.Point(63, 12);
            this.IDNumericUpDown.Name = "IDNumericUpDown";
            this.IDNumericUpDown.ReadOnly = true;
            this.IDNumericUpDown.Size = new System.Drawing.Size(360, 22);
            this.IDNumericUpDown.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 27);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 31;
            this.label2.Text = "Asignatura";
            // 
            // AsignaturaTextBox
            // 
            this.AsignaturaTextBox.Location = new System.Drawing.Point(131, 45);
            this.AsignaturaTextBox.Name = "AsignaturaTextBox";
            this.AsignaturaTextBox.Size = new System.Drawing.Size(292, 22);
            this.AsignaturaTextBox.TabIndex = 37;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::RegistroAsistenciasDetalle.Properties.Resources.depositphotos_112775736_stock_photo_save_floppy_disk_icon_white;
            this.GuardarButton.Location = new System.Drawing.Point(208, 132);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(104, 72);
            this.GuardarButton.TabIndex = 40;
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::RegistroAsistenciasDetalle.Properties.Resources.Delete_Button;
            this.EliminarButton.Location = new System.Drawing.Point(394, 132);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(104, 72);
            this.EliminarButton.TabIndex = 39;
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::RegistroAsistenciasDetalle.Properties.Resources.depositphotos_85627942_stock_illustration_silver_rounded_new_button;
            this.NuevoButton.Location = new System.Drawing.Point(17, 132);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(104, 72);
            this.NuevoButton.TabIndex = 38;
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackColor = System.Drawing.Color.Transparent;
            this.BuscarButton.Image = global::RegistroAsistenciasDetalle.Properties.Resources._56060734_buscar_botón_cuadrado_blanco;
            this.BuscarButton.Location = new System.Drawing.Point(429, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(69, 57);
            this.BuscarButton.TabIndex = 30;
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.UseVisualStyleBackColor = false;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroAsistenciasDetalle.Properties.Resources.and_stick_wallpaper_gris_y_blanco_D_NQ_NP_966277_MLM28445781777_102018_F;
            this.ClientSize = new System.Drawing.Size(523, 219);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.AsignaturaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.IDNumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "rAsignaturas";
            this.Text = "Registro de asignaturas";
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.NumericUpDown IDNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AsignaturaTextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}