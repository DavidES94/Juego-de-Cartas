namespace JuegoCartas
{
    partial class FrmJuego
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
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("", 26);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJuego));
            toolStrip1 = new ToolStrip();
            btnRepartir = new ToolStripButton();
            btnVerificar = new ToolStripButton();
            tcJugadores = new TabControl();
            tpJugador1 = new TabPage();
            lvJugador1 = new ListView();
            ilCartas = new ImageList(components);
            tpJugador2 = new TabPage();
            lvJugador2 = new ListView();
            toolStrip1.SuspendLayout();
            tcJugadores.SuspendLayout();
            tpJugador1.SuspendLayout();
            tpJugador2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnRepartir, btnVerificar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 135);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnRepartir
            // 
            btnRepartir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRepartir.Image = Properties.Resources.Repartir;
            btnRepartir.ImageScaling = ToolStripItemImageScaling.None;
            btnRepartir.ImageTransparentColor = Color.Magenta;
            btnRepartir.Name = "btnRepartir";
            btnRepartir.Size = new Size(132, 132);
            btnRepartir.Text = "toolStripButton1";
            btnRepartir.ToolTipText = "Repartir";
            btnRepartir.Click += btnRepartir_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVerificar.Image = Properties.Resources.Verificar;
            btnVerificar.ImageScaling = ToolStripItemImageScaling.None;
            btnVerificar.ImageTransparentColor = Color.Magenta;
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(132, 132);
            btnVerificar.Text = "toolStripButton1";
            btnVerificar.ToolTipText = "Verificar Grupos";
            btnVerificar.Click += btnVerificar_Click;
            // 
            // tcJugadores
            // 
            tcJugadores.Controls.Add(tpJugador1);
            tcJugadores.Controls.Add(tpJugador2);
            tcJugadores.Dock = DockStyle.Fill;
            tcJugadores.Location = new Point(0, 135);
            tcJugadores.Name = "tcJugadores";
            tcJugadores.SelectedIndex = 0;
            tcJugadores.Size = new Size(800, 315);
            tcJugadores.TabIndex = 1;
            // 
            // tpJugador1
            // 
            tpJugador1.BackColor = Color.GreenYellow;
            tpJugador1.Controls.Add(lvJugador1);
            tpJugador1.Location = new Point(4, 29);
            tpJugador1.Name = "tpJugador1";
            tpJugador1.Padding = new Padding(3);
            tpJugador1.Size = new Size(792, 282);
            tpJugador1.TabIndex = 0;
            tpJugador1.Text = "Martín Estrada Contreras";
            // 
            // lvJugador1
            // 
            lvJugador1.Dock = DockStyle.Fill;
            lvJugador1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lvJugador1.LargeImageList = ilCartas;
            lvJugador1.Location = new Point(3, 3);
            lvJugador1.Name = "lvJugador1";
            lvJugador1.Size = new Size(786, 276);
            lvJugador1.TabIndex = 0;
            lvJugador1.UseCompatibleStateImageBehavior = false;
            // 
            // ilCartas
            // 
            ilCartas.ColorDepth = ColorDepth.Depth32Bit;
            ilCartas.ImageStream = (ImageListStreamer)resources.GetObject("ilCartas.ImageStream");
            ilCartas.TransparentColor = Color.Transparent;
            ilCartas.Images.SetKeyName(0, "CARTA1.JPG");
            ilCartas.Images.SetKeyName(1, "CARTA2.JPG");
            ilCartas.Images.SetKeyName(2, "CARTA3.JPG");
            ilCartas.Images.SetKeyName(3, "CARTA4.JPG");
            ilCartas.Images.SetKeyName(4, "CARTA5.JPG");
            ilCartas.Images.SetKeyName(5, "CARTA6.JPG");
            ilCartas.Images.SetKeyName(6, "CARTA7.JPG");
            ilCartas.Images.SetKeyName(7, "CARTA8.JPG");
            ilCartas.Images.SetKeyName(8, "CARTA9.JPG");
            ilCartas.Images.SetKeyName(9, "CARTA10.JPG");
            ilCartas.Images.SetKeyName(10, "CARTA11.JPG");
            ilCartas.Images.SetKeyName(11, "CARTA12.JPG");
            ilCartas.Images.SetKeyName(12, "CARTA13.JPG");
            ilCartas.Images.SetKeyName(13, "CARTA14.JPG");
            ilCartas.Images.SetKeyName(14, "CARTA15.JPG");
            ilCartas.Images.SetKeyName(15, "CARTA16.JPG");
            ilCartas.Images.SetKeyName(16, "CARTA17.JPG");
            ilCartas.Images.SetKeyName(17, "CARTA18.JPG");
            ilCartas.Images.SetKeyName(18, "CARTA19.JPG");
            ilCartas.Images.SetKeyName(19, "CARTA20.JPG");
            ilCartas.Images.SetKeyName(20, "CARTA21.JPG");
            ilCartas.Images.SetKeyName(21, "CARTA22.JPG");
            ilCartas.Images.SetKeyName(22, "CARTA23.JPG");
            ilCartas.Images.SetKeyName(23, "CARTA24.JPG");
            ilCartas.Images.SetKeyName(24, "CARTA25.JPG");
            ilCartas.Images.SetKeyName(25, "CARTA26.JPG");
            ilCartas.Images.SetKeyName(26, "CARTA27.JPG");
            ilCartas.Images.SetKeyName(27, "CARTA28.JPG");
            ilCartas.Images.SetKeyName(28, "CARTA29.JPG");
            ilCartas.Images.SetKeyName(29, "CARTA30.JPG");
            ilCartas.Images.SetKeyName(30, "CARTA31.JPG");
            ilCartas.Images.SetKeyName(31, "CARTA32.JPG");
            ilCartas.Images.SetKeyName(32, "CARTA33.JPG");
            ilCartas.Images.SetKeyName(33, "CARTA34.JPG");
            ilCartas.Images.SetKeyName(34, "CARTA35.JPG");
            ilCartas.Images.SetKeyName(35, "CARTA36.JPG");
            ilCartas.Images.SetKeyName(36, "CARTA37.JPG");
            ilCartas.Images.SetKeyName(37, "CARTA38.JPG");
            ilCartas.Images.SetKeyName(38, "CARTA39.JPG");
            ilCartas.Images.SetKeyName(39, "CARTA40.JPG");
            ilCartas.Images.SetKeyName(40, "CARTA41.JPG");
            ilCartas.Images.SetKeyName(41, "CARTA42.JPG");
            ilCartas.Images.SetKeyName(42, "CARTA43.JPG");
            ilCartas.Images.SetKeyName(43, "CARTA44.JPG");
            ilCartas.Images.SetKeyName(44, "CARTA45.JPG");
            ilCartas.Images.SetKeyName(45, "CARTA46.JPG");
            ilCartas.Images.SetKeyName(46, "CARTA47.JPG");
            ilCartas.Images.SetKeyName(47, "CARTA48.JPG");
            ilCartas.Images.SetKeyName(48, "CARTA49.JPG");
            ilCartas.Images.SetKeyName(49, "Carta50.JPG");
            ilCartas.Images.SetKeyName(50, "CARTA51.JPG");
            ilCartas.Images.SetKeyName(51, "CARTA52.JPG");
            // 
            // tpJugador2
            // 
            tpJugador2.BackColor = Color.Green;
            tpJugador2.Controls.Add(lvJugador2);
            tpJugador2.Location = new Point(4, 29);
            tpJugador2.Name = "tpJugador2";
            tpJugador2.Padding = new Padding(3);
            tpJugador2.Size = new Size(792, 282);
            tpJugador2.TabIndex = 1;
            tpJugador2.Text = "Raúl Vidal";
            // 
            // lvJugador2
            // 
            lvJugador2.Dock = DockStyle.Fill;
            lvJugador2.LargeImageList = ilCartas;
            lvJugador2.Location = new Point(3, 3);
            lvJugador2.Name = "lvJugador2";
            lvJugador2.Size = new Size(786, 276);
            lvJugador2.TabIndex = 0;
            lvJugador2.UseCompatibleStateImageBehavior = false;
            // 
            // FrmJuego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tcJugadores);
            Controls.Add(toolStrip1);
            Name = "FrmJuego";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tcJugadores.ResumeLayout(false);
            tpJugador1.ResumeLayout(false);
            tpJugador2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnRepartir;
        private ToolStripButton btnVerificar;
        private TabControl tcJugadores;
        private TabPage tpJugador1;
        private TabPage tpJugador2;
        private ImageList ilCartas;
        private ListView lvJugador1;
        private ListView lvJugador2;
    }
}
