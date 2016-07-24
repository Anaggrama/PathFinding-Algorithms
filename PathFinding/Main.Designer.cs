namespace WindowsFormsApplication1
{
    partial class Main
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
            this.Pantalla = new System.Windows.Forms.PictureBox();
            this.cmdSimplePath = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdClearPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtIteraciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuOptions = new System.Windows.Forms.MenuItem();
            this.mnuDTempPath = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Pantalla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.Location = new System.Drawing.Point(-2, 1);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(401, 301);
            this.Pantalla.TabIndex = 0;
            this.Pantalla.TabStop = false;
            this.Pantalla.Click += new System.EventHandler(this.Pantalla_Click);
            this.Pantalla.Paint += new System.Windows.Forms.PaintEventHandler(this.Pantalla_Paint);
            this.Pantalla.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pantalla_MouseMove);
            // 
            // cmdSimplePath
            // 
            this.cmdSimplePath.Location = new System.Drawing.Point(407, 4);
            this.cmdSimplePath.Name = "cmdSimplePath";
            this.cmdSimplePath.Size = new System.Drawing.Size(143, 28);
            this.cmdSimplePath.TabIndex = 1;
            this.cmdSimplePath.Text = "Simple PathFinding";
            this.cmdSimplePath.UseVisualStyleBackColor = true;
            this.cmdSimplePath.Click += new System.EventHandler(this.cmdSimplePath_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(407, 184);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(136, 23);
            this.cmdClear.TabIndex = 2;
            this.cmdClear.Text = "Clear Screen";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdClearPath
            // 
            this.cmdClearPath.Location = new System.Drawing.Point(407, 204);
            this.cmdClearPath.Name = "cmdClearPath";
            this.cmdClearPath.Size = new System.Drawing.Size(135, 21);
            this.cmdClearPath.TabIndex = 3;
            this.cmdClearPath.Text = "Clear Path";
            this.cmdClearPath.UseVisualStyleBackColor = true;
            this.cmdClearPath.Click += new System.EventHandler(this.cmdClearPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTiempo);
            this.groupBox1.Controls.Add(this.txtIteraciones);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(407, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(74, 41);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(56, 20);
            this.txtTiempo.TabIndex = 3;
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.Location = new System.Drawing.Point(74, 12);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.Size = new System.Drawing.Size(56, 20);
            this.txtIteraciones.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iterations:";
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuOptions});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.Text = "File";
            // 
            // mnuOptions
            // 
            this.mnuOptions.Index = 1;
            this.mnuOptions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuDTempPath});
            this.mnuOptions.Text = "Options";
            // 
            // mnuDTempPath
            // 
            this.mnuDTempPath.Index = 0;
            this.mnuDTempPath.Text = "Draw Temporary Path";
            this.mnuDTempPath.Click += new System.EventHandler(this.mnuDTempPath_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 310);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdClearPath);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdSimplePath);
            this.Controls.Add(this.Pantalla);
            this.Menu = this.MainMenu;
            this.Name = "Main";
            this.Text = "PathFinding";
            ((System.ComponentModel.ISupportInitialize)(this.Pantalla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pantalla;
        private System.Windows.Forms.Button cmdSimplePath;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdClearPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtIteraciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuOptions;
        private System.Windows.Forms.MenuItem mnuDTempPath;
    }
}

