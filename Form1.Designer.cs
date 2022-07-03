namespace ListasI
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rButComboBox = new System.Windows.Forms.RadioButton();
            this.rButCheckListBox = new System.Windows.Forms.RadioButton();
            this.rButListBox = new System.Windows.Forms.RadioButton();
            this.txtBoxEntrada = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFondo1 = new System.Windows.Forms.Label();
            this.lblFondo2 = new System.Windows.Forms.Label();
            this.lblElementos = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblListBox = new System.Windows.Forms.Label();
            this.lblComboBox = new System.Windows.Forms.Label();
            this.lblCheckedListBox = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxSeleccion = new System.Windows.Forms.TextBox();
            this.lstBoxSeleccion = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(670, 65);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 30);
            this.btnBorrar.TabIndex = 0;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(557, 65);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(100, 30);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rButComboBox);
            this.groupBox1.Controls.Add(this.rButCheckListBox);
            this.groupBox1.Controls.Add(this.rButListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de componente";
            // 
            // rButComboBox
            // 
            this.rButComboBox.AutoSize = true;
            this.rButComboBox.Location = new System.Drawing.Point(158, 33);
            this.rButComboBox.Name = "rButComboBox";
            this.rButComboBox.Size = new System.Drawing.Size(95, 20);
            this.rButComboBox.TabIndex = 2;
            this.rButComboBox.Text = "ComboBox";
            this.rButComboBox.UseVisualStyleBackColor = true;
            // 
            // rButCheckListBox
            // 
            this.rButCheckListBox.AutoSize = true;
            this.rButCheckListBox.Location = new System.Drawing.Point(319, 33);
            this.rButCheckListBox.Name = "rButCheckListBox";
            this.rButCheckListBox.Size = new System.Drawing.Size(125, 20);
            this.rButCheckListBox.TabIndex = 1;
            this.rButCheckListBox.Text = "CheckedListBox";
            this.rButCheckListBox.UseVisualStyleBackColor = true;
            // 
            // rButListBox
            // 
            this.rButListBox.AutoSize = true;
            this.rButListBox.Checked = true;
            this.rButListBox.Location = new System.Drawing.Point(6, 33);
            this.rButListBox.Name = "rButListBox";
            this.rButListBox.Size = new System.Drawing.Size(71, 20);
            this.rButListBox.TabIndex = 0;
            this.rButListBox.TabStop = true;
            this.rButListBox.Text = "ListBox";
            this.rButListBox.UseVisualStyleBackColor = true;
            // 
            // txtBoxEntrada
            // 
            this.txtBoxEntrada.Location = new System.Drawing.Point(624, 26);
            this.txtBoxEntrada.Name = "txtBoxEntrada";
            this.txtBoxEntrada.Size = new System.Drawing.Size(146, 22);
            this.txtBoxEntrada.TabIndex = 3;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 117);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(220, 196);
            this.listBox.TabIndex = 4;
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(279, 118);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(220, 24);
            this.comboBox.TabIndex = 7;
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(550, 116);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(220, 191);
            this.checkedListBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Elemento";
            // 
            // lblFondo1
            // 
            this.lblFondo1.BackColor = System.Drawing.SystemColors.Info;
            this.lblFondo1.Location = new System.Drawing.Point(12, 326);
            this.lblFondo1.Name = "lblFondo1";
            this.lblFondo1.Size = new System.Drawing.Size(758, 30);
            this.lblFondo1.TabIndex = 11;
            // 
            // lblFondo2
            // 
            this.lblFondo2.BackColor = System.Drawing.SystemColors.Info;
            this.lblFondo2.Location = new System.Drawing.Point(12, 369);
            this.lblFondo2.Name = "lblFondo2";
            this.lblFondo2.Size = new System.Drawing.Size(758, 175);
            this.lblFondo2.TabIndex = 12;
            // 
            // lblElementos
            // 
            this.lblElementos.AutoSize = true;
            this.lblElementos.Location = new System.Drawing.Point(18, 333);
            this.lblElementos.Name = "lblElementos";
            this.lblElementos.Size = new System.Drawing.Size(71, 16);
            this.lblElementos.TabIndex = 13;
            this.lblElementos.Text = "Elementos";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(21, 444);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(194, 23);
            this.btnMostrar.TabIndex = 14;
            this.btnMostrar.Text = "Mostrar Seleccionado/s";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblListBox
            // 
            this.lblListBox.AutoSize = true;
            this.lblListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.lblListBox.Location = new System.Drawing.Point(209, 333);
            this.lblListBox.Name = "lblListBox";
            this.lblListBox.Size = new System.Drawing.Size(0, 16);
            this.lblListBox.TabIndex = 15;
            // 
            // lblComboBox
            // 
            this.lblComboBox.AutoSize = true;
            this.lblComboBox.Location = new System.Drawing.Point(471, 333);
            this.lblComboBox.Name = "lblComboBox";
            this.lblComboBox.Size = new System.Drawing.Size(0, 16);
            this.lblComboBox.TabIndex = 16;
            // 
            // lblCheckedListBox
            // 
            this.lblCheckedListBox.AutoSize = true;
            this.lblCheckedListBox.Location = new System.Drawing.Point(747, 332);
            this.lblCheckedListBox.Name = "lblCheckedListBox";
            this.lblCheckedListBox.Size = new System.Drawing.Size(0, 16);
            this.lblCheckedListBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Selección única";
            // 
            // txtBoxSeleccion
            // 
            this.txtBoxSeleccion.Location = new System.Drawing.Point(279, 444);
            this.txtBoxSeleccion.Name = "txtBoxSeleccion";
            this.txtBoxSeleccion.Size = new System.Drawing.Size(220, 22);
            this.txtBoxSeleccion.TabIndex = 19;
            // 
            // lstBoxSeleccion
            // 
            this.lstBoxSeleccion.FormattingEnabled = true;
            this.lstBoxSeleccion.ItemHeight = 16;
            this.lstBoxSeleccion.Location = new System.Drawing.Point(550, 441);
            this.lstBoxSeleccion.Name = "lstBoxSeleccion";
            this.lstBoxSeleccion.Size = new System.Drawing.Size(211, 100);
            this.lstBoxSeleccion.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Multiselección";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstBoxSeleccion);
            this.Controls.Add(this.txtBoxSeleccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCheckedListBox);
            this.Controls.Add(this.lblComboBox);
            this.Controls.Add(this.lblListBox);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblElementos);
            this.Controls.Add(this.lblFondo2);
            this.Controls.Add(this.lblFondo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.txtBoxEntrada);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnBorrar);
            this.Name = "Form1";
            this.Text = "Trabajando con Listas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rButComboBox;
        private System.Windows.Forms.RadioButton rButCheckListBox;
        private System.Windows.Forms.RadioButton rButListBox;
        private System.Windows.Forms.TextBox txtBoxEntrada;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFondo1;
        private System.Windows.Forms.Label lblFondo2;
        private System.Windows.Forms.Label lblElementos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblListBox;
        private System.Windows.Forms.Label lblComboBox;
        private System.Windows.Forms.Label lblCheckedListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxSeleccion;
        private System.Windows.Forms.ListBox lstBoxSeleccion;
        private System.Windows.Forms.Label label6;
    }
}

