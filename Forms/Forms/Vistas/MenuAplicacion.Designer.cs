
namespace Forms.Vistas
{
    partial class MenuAplicacion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesMatematicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioSumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioRestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioMultiplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioDivisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.operacionesMatematicasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioEstudianteToolStripMenuItem,
            this.formularioProfesorToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // formularioEstudianteToolStripMenuItem
            // 
            this.formularioEstudianteToolStripMenuItem.Name = "formularioEstudianteToolStripMenuItem";
            this.formularioEstudianteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.formularioEstudianteToolStripMenuItem.Text = "Formulario estudiante";
            this.formularioEstudianteToolStripMenuItem.Click += new System.EventHandler(this.formularioEstudianteToolStripMenuItem_Click);
            // 
            // formularioProfesorToolStripMenuItem
            // 
            this.formularioProfesorToolStripMenuItem.Name = "formularioProfesorToolStripMenuItem";
            this.formularioProfesorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.formularioProfesorToolStripMenuItem.Text = "Formulario profesor";
            // 
            // operacionesMatematicasToolStripMenuItem
            // 
            this.operacionesMatematicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioSumaToolStripMenuItem,
            this.formularioRestaToolStripMenuItem,
            this.formularioMultiplicacionToolStripMenuItem,
            this.formularioDivisionToolStripMenuItem});
            this.operacionesMatematicasToolStripMenuItem.Name = "operacionesMatematicasToolStripMenuItem";
            this.operacionesMatematicasToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.operacionesMatematicasToolStripMenuItem.Text = "Operaciones matematicas";
            // 
            // formularioSumaToolStripMenuItem
            // 
            this.formularioSumaToolStripMenuItem.Name = "formularioSumaToolStripMenuItem";
            this.formularioSumaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.formularioSumaToolStripMenuItem.Text = "formulario suma";
            this.formularioSumaToolStripMenuItem.Click += new System.EventHandler(this.formularioSumaToolStripMenuItem_Click);
            // 
            // formularioRestaToolStripMenuItem
            // 
            this.formularioRestaToolStripMenuItem.Name = "formularioRestaToolStripMenuItem";
            this.formularioRestaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.formularioRestaToolStripMenuItem.Text = "formulario resta";
            this.formularioRestaToolStripMenuItem.Click += new System.EventHandler(this.formularioRestaToolStripMenuItem_Click);
            // 
            // formularioMultiplicacionToolStripMenuItem
            // 
            this.formularioMultiplicacionToolStripMenuItem.Name = "formularioMultiplicacionToolStripMenuItem";
            this.formularioMultiplicacionToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.formularioMultiplicacionToolStripMenuItem.Text = "formulario multiplicacion";
            this.formularioMultiplicacionToolStripMenuItem.Click += new System.EventHandler(this.formularioMultiplicacionToolStripMenuItem_Click);
            // 
            // formularioDivisionToolStripMenuItem
            // 
            this.formularioDivisionToolStripMenuItem.Name = "formularioDivisionToolStripMenuItem";
            this.formularioDivisionToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.formularioDivisionToolStripMenuItem.Text = "formulario division";
            this.formularioDivisionToolStripMenuItem.Click += new System.EventHandler(this.formularioDivisionToolStripMenuItem_Click);
            // 
            // MenuAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuAplicacion";
            this.Text = "MenuAplicacion";
            this.Load += new System.EventHandler(this.MenuAplicacion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesMatematicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioSumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioRestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioMultiplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioDivisionToolStripMenuItem;
    }
}