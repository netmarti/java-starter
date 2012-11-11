namespace JavaStarter
{
    partial class main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.btn_run = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_javaPath = new System.Windows.Forms.TextBox();
            this.txt_argumentos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_salida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(813, 473);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 6;
            this.btn_run.Text = "&Run!";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path Java";
            // 
            // txt_javaPath
            // 
            this.txt_javaPath.Location = new System.Drawing.Point(73, 6);
            this.txt_javaPath.Name = "txt_javaPath";
            this.txt_javaPath.Size = new System.Drawing.Size(815, 20);
            this.txt_javaPath.TabIndex = 1;
            this.txt_javaPath.Text = "C:\\Program Files (x86)\\Java\\jre6\\bin\\java.exe";
            // 
            // txt_argumentos
            // 
            this.txt_argumentos.Location = new System.Drawing.Point(73, 32);
            this.txt_argumentos.Multiline = true;
            this.txt_argumentos.Name = "txt_argumentos";
            this.txt_argumentos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_argumentos.Size = new System.Drawing.Size(815, 125);
            this.txt_argumentos.TabIndex = 3;
            this.txt_argumentos.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Argumentos";
            // 
            // txt_salida
            // 
            this.txt_salida.Location = new System.Drawing.Point(73, 163);
            this.txt_salida.Multiline = true;
            this.txt_salida.Name = "txt_salida";
            this.txt_salida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_salida.Size = new System.Drawing.Size(815, 304);
            this.txt_salida.TabIndex = 5;
            this.txt_salida.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salida";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_salida);
            this.Controls.Add(this.txt_argumentos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_javaPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_run);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JavaLunch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_javaPath;
        private System.Windows.Forms.TextBox txt_argumentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_salida;
        private System.Windows.Forms.Label label3;
    }
}

