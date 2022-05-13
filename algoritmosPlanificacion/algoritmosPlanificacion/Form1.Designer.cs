namespace algoritmosPlanificacion
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.btnDesencolar = new System.Windows.Forms.Button();
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.txtPrioridad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnAgregarNuevoNodo = new System.Windows.Forms.Button();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.listBoxLista = new System.Windows.Forms.ListBox();
            this.btnAgregarTareaLista = new System.Windows.Forms.Button();
            this.lstIdTarea = new System.Windows.Forms.ListBox();
            this.lstPrioridadTarea = new System.Windows.Forms.ListBox();
            this.lstTamanioTarea = new System.Windows.Forms.ListBox();
            this.lblTituloFCFS = new System.Windows.Forms.Label();
            this.lblTituloPrioridad = new System.Windows.Forms.Label();
            this.lblTituloSRT = new System.Windows.Forms.Label();
            this.lblTituloRR = new System.Windows.Forms.Label();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelDiagramas = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listaTareasCopiadas = new System.Windows.Forms.ListBox();
            this.txtNumeroTareas = new System.Windows.Forms.TextBox();
            this.lblNumTareas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            this.panelDiagramas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(139, 47);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(81, 20);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // btnEncolar
            // 
            this.btnEncolar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEncolar.Location = new System.Drawing.Point(139, 159);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(82, 29);
            this.btnEncolar.TabIndex = 3;
            this.btnEncolar.Text = "Agregar";
            this.btnEncolar.UseVisualStyleBackColor = false;
            this.btnEncolar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDesencolar
            // 
            this.btnDesencolar.Location = new System.Drawing.Point(37, 21);
            this.btnDesencolar.Name = "btnDesencolar";
            this.btnDesencolar.Size = new System.Drawing.Size(124, 25);
            this.btnDesencolar.TabIndex = 4;
            this.btnDesencolar.Text = "desencolar";
            this.btnDesencolar.UseVisualStyleBackColor = true;
            this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
            // 
            // txtTamanio
            // 
            this.txtTamanio.Location = new System.Drawing.Point(139, 86);
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(82, 20);
            this.txtTamanio.TabIndex = 5;
            // 
            // txtPrioridad
            // 
            this.txtPrioridad.Location = new System.Drawing.Point(139, 133);
            this.txtPrioridad.Name = "txtPrioridad";
            this.txtPrioridad.Size = new System.Drawing.Size(82, 20);
            this.txtPrioridad.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tamaño";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prioridad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tamaño";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Prioridad";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnIniciar.Location = new System.Drawing.Point(139, 213);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(82, 47);
            this.btnIniciar.TabIndex = 12;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnAgregarNuevoNodo
            // 
            this.btnAgregarNuevoNodo.Location = new System.Drawing.Point(244, 21);
            this.btnAgregarNuevoNodo.Name = "btnAgregarNuevoNodo";
            this.btnAgregarNuevoNodo.Size = new System.Drawing.Size(99, 23);
            this.btnAgregarNuevoNodo.TabIndex = 13;
            this.btnAgregarNuevoNodo.Text = "Apilar";
            this.btnAgregarNuevoNodo.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoNodo.Click += new System.EventHandler(this.btnAgregarNuevoNodo_Click);
            // 
            // btnDesapilar
            // 
            this.btnDesapilar.Location = new System.Drawing.Point(372, 22);
            this.btnDesapilar.Name = "btnDesapilar";
            this.btnDesapilar.Size = new System.Drawing.Size(90, 23);
            this.btnDesapilar.TabIndex = 15;
            this.btnDesapilar.Text = "Desapilar";
            this.btnDesapilar.UseVisualStyleBackColor = true;
            this.btnDesapilar.Click += new System.EventHandler(this.btnDesapilar_Click);
            // 
            // listBoxLista
            // 
            this.listBoxLista.FormattingEnabled = true;
            this.listBoxLista.Location = new System.Drawing.Point(718, 16);
            this.listBoxLista.Name = "listBoxLista";
            this.listBoxLista.Size = new System.Drawing.Size(87, 30);
            this.listBoxLista.TabIndex = 18;
            // 
            // btnAgregarTareaLista
            // 
            this.btnAgregarTareaLista.Location = new System.Drawing.Point(877, 20);
            this.btnAgregarTareaLista.Name = "btnAgregarTareaLista";
            this.btnAgregarTareaLista.Size = new System.Drawing.Size(102, 27);
            this.btnAgregarTareaLista.TabIndex = 19;
            this.btnAgregarTareaLista.Text = "Agregar";
            this.btnAgregarTareaLista.UseVisualStyleBackColor = true;
            this.btnAgregarTareaLista.Click += new System.EventHandler(this.btnAgregarTareaLista_Click);
            // 
            // lstIdTarea
            // 
            this.lstIdTarea.FormattingEnabled = true;
            this.lstIdTarea.Location = new System.Drawing.Point(3, 31);
            this.lstIdTarea.Name = "lstIdTarea";
            this.lstIdTarea.Size = new System.Drawing.Size(28, 225);
            this.lstIdTarea.TabIndex = 20;
            // 
            // lstPrioridadTarea
            // 
            this.lstPrioridadTarea.FormattingEnabled = true;
            this.lstPrioridadTarea.Location = new System.Drawing.Point(76, 31);
            this.lstPrioridadTarea.Name = "lstPrioridadTarea";
            this.lstPrioridadTarea.Size = new System.Drawing.Size(33, 225);
            this.lstPrioridadTarea.TabIndex = 21;
            // 
            // lstTamanioTarea
            // 
            this.lstTamanioTarea.FormattingEnabled = true;
            this.lstTamanioTarea.Location = new System.Drawing.Point(37, 31);
            this.lstTamanioTarea.Name = "lstTamanioTarea";
            this.lstTamanioTarea.Size = new System.Drawing.Size(33, 225);
            this.lstTamanioTarea.TabIndex = 22;
            // 
            // lblTituloFCFS
            // 
            this.lblTituloFCFS.AutoSize = true;
            this.lblTituloFCFS.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFCFS.Location = new System.Drawing.Point(268, 21);
            this.lblTituloFCFS.Name = "lblTituloFCFS";
            this.lblTituloFCFS.Size = new System.Drawing.Size(200, 23);
            this.lblTituloFCFS.TabIndex = 23;
            this.lblTituloFCFS.Text = "PLANIFICACIÓN FCFS";
            this.lblTituloFCFS.Click += new System.EventHandler(this.lblTituloFCFS_Click);
            // 
            // lblTituloPrioridad
            // 
            this.lblTituloPrioridad.AutoSize = true;
            this.lblTituloPrioridad.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrioridad.Location = new System.Drawing.Point(239, 268);
            this.lblTituloPrioridad.Name = "lblTituloPrioridad";
            this.lblTituloPrioridad.Size = new System.Drawing.Size(292, 23);
            this.lblTituloPrioridad.TabIndex = 24;
            this.lblTituloPrioridad.Text = "PLANIFICACIÓN POR PRIORIDAD";
            // 
            // lblTituloSRT
            // 
            this.lblTituloSRT.AutoSize = true;
            this.lblTituloSRT.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSRT.Location = new System.Drawing.Point(278, 104);
            this.lblTituloSRT.Name = "lblTituloSRT";
            this.lblTituloSRT.Size = new System.Drawing.Size(190, 23);
            this.lblTituloSRT.TabIndex = 25;
            this.lblTituloSRT.Text = "PLANIFICACIÓN SRT";
            // 
            // lblTituloRR
            // 
            this.lblTituloRR.AutoSize = true;
            this.lblTituloRR.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRR.Location = new System.Drawing.Point(278, 184);
            this.lblTituloRR.Name = "lblTituloRR";
            this.lblTituloRR.Size = new System.Drawing.Size(178, 23);
            this.lblTituloRR.TabIndex = 26;
            this.lblTituloRR.Text = "PLANIFICACIÓN RR";
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelLateral.Controls.Add(this.panel1);
            this.panelLateral.Controls.Add(this.txtNumeroTareas);
            this.panelLateral.Controls.Add(this.lblNumTareas);
            this.panelLateral.Controls.Add(this.listBox1);
            this.panelLateral.Controls.Add(this.label4);
            this.panelLateral.Controls.Add(this.label5);
            this.panelLateral.Controls.Add(this.label6);
            this.panelLateral.Controls.Add(this.lstIdTarea);
            this.panelLateral.Controls.Add(this.lstTamanioTarea);
            this.panelLateral.Controls.Add(this.lstPrioridadTarea);
            this.panelLateral.Controls.Add(this.txtId);
            this.panelLateral.Controls.Add(this.label1);
            this.panelLateral.Controls.Add(this.label2);
            this.panelLateral.Controls.Add(this.btnIniciar);
            this.panelLateral.Controls.Add(this.txtTamanio);
            this.panelLateral.Controls.Add(this.txtPrioridad);
            this.panelLateral.Controls.Add(this.btnEncolar);
            this.panelLateral.Controls.Add(this.label3);
            this.panelLateral.Location = new System.Drawing.Point(11, 8);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(239, 369);
            this.panelLateral.TabIndex = 27;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 362);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 4);
            this.listBox1.TabIndex = 32;
            // 
            // panelDiagramas
            // 
            this.panelDiagramas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelDiagramas.Controls.Add(this.pictureBox4);
            this.panelDiagramas.Controls.Add(this.pictureBox3);
            this.panelDiagramas.Controls.Add(this.pictureBox2);
            this.panelDiagramas.Controls.Add(this.pictureBox1);
            this.panelDiagramas.Controls.Add(this.lblTituloFCFS);
            this.panelDiagramas.Controls.Add(this.lblTituloRR);
            this.panelDiagramas.Controls.Add(this.lblTituloPrioridad);
            this.panelDiagramas.Controls.Add(this.lblTituloSRT);
            this.panelDiagramas.Location = new System.Drawing.Point(255, 11);
            this.panelDiagramas.Name = "panelDiagramas";
            this.panelDiagramas.Size = new System.Drawing.Size(780, 366);
            this.panelDiagramas.TabIndex = 28;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(19, 294);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(752, 40);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(19, 210);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(752, 40);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(19, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(752, 40);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(19, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(752, 36);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listaTareasCopiadas
            // 
            this.listaTareasCopiadas.FormattingEnabled = true;
            this.listaTareasCopiadas.Location = new System.Drawing.Point(516, 16);
            this.listaTareasCopiadas.Name = "listaTareasCopiadas";
            this.listaTareasCopiadas.Size = new System.Drawing.Size(80, 30);
            this.listaTareasCopiadas.TabIndex = 28;
            // 
            // txtNumeroTareas
            // 
            this.txtNumeroTareas.Location = new System.Drawing.Point(3, 297);
            this.txtNumeroTareas.Name = "txtNumeroTareas";
            this.txtNumeroTareas.Size = new System.Drawing.Size(106, 20);
            this.txtNumeroTareas.TabIndex = 29;
            // 
            // lblNumTareas
            // 
            this.lblNumTareas.AutoSize = true;
            this.lblNumTareas.Location = new System.Drawing.Point(4, 278);
            this.lblNumTareas.Name = "lblNumTareas";
            this.lblNumTareas.Size = new System.Drawing.Size(76, 13);
            this.lblNumTareas.TabIndex = 29;
            this.lblNumTareas.Text = "Número tareas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.listaTareasCopiadas);
            this.panel1.Controls.Add(this.btnAgregarTareaLista);
            this.panel1.Controls.Add(this.btnDesapilar);
            this.panel1.Controls.Add(this.btnAgregarNuevoNodo);
            this.panel1.Controls.Add(this.btnDesencolar);
            this.panel1.Controls.Add(this.listBoxLista);
            this.panel1.Location = new System.Drawing.Point(6, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 19);
            this.panel1.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 390);
            this.Controls.Add(this.panelDiagramas);
            this.Controls.Add(this.panelLateral);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.panelDiagramas.ResumeLayout(false);
            this.panelDiagramas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.Button btnDesencolar;
        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.TextBox txtPrioridad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnAgregarNuevoNodo;
        private System.Windows.Forms.Button btnDesapilar;
        private System.Windows.Forms.ListBox listBoxLista;
        private System.Windows.Forms.Button btnAgregarTareaLista;
        private System.Windows.Forms.ListBox lstIdTarea;
        private System.Windows.Forms.ListBox lstPrioridadTarea;
        private System.Windows.Forms.ListBox lstTamanioTarea;
        private System.Windows.Forms.Label lblTituloFCFS;
        private System.Windows.Forms.Label lblTituloPrioridad;
        private System.Windows.Forms.Label lblTituloSRT;
        private System.Windows.Forms.Label lblTituloRR;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelDiagramas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listaTareasCopiadas;
        private System.Windows.Forms.TextBox txtNumeroTareas;
        private System.Windows.Forms.Label lblNumTareas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

