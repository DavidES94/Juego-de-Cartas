namespace JuegoCartas
{
    public partial class FrmJuego : Form
    {
        Jugador jugador1, jugador2;

        public FrmJuego()
        {
            InitializeComponent();
            jugador1 = new Jugador();
            jugador2 = new Jugador();
        }

        private void btnRepartir_Click(object sender, EventArgs e)
        {
            jugador1.Repartir();
            jugador1.Mostrar(lvJugador1);

            jugador2.Repartir();
            jugador2.Mostrar(lvJugador2);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Obtener la información de los jugadores
            string resultadoJugador1 = jugador1.ObtenerResultado();
            string resultadoJugador2 = jugador2.ObtenerResultado();

            // Crear y mostrar una ventana emergente con los resultados
            Form ventanaResultados = new Form();
            ventanaResultados.Text = "Resultados";
            ventanaResultados.Size = new Size(400, 300); // Tamaño de la ventana

            // Crear un TextBox dentro de la ventana emergente
            TextBox txtResultados = new TextBox();
            txtResultados.Multiline = true;
            txtResultados.ScrollBars = ScrollBars.Vertical;
            txtResultados.Dock = DockStyle.Fill;
            txtResultados.ReadOnly = true;

            // Mostrar los resultados en el TextBox
            txtResultados.Text = $"{resultadoJugador1}\n\n{resultadoJugador2}";

            // Determinar el ganador según el puntaje
            if (jugador1.Puntaje < jugador2.Puntaje)
            {
                txtResultados.AppendText("\nJugador 1 ha ganado!");
            }
            else if (jugador2.Puntaje < jugador1.Puntaje)
            {
                txtResultados.AppendText("\nJugador 2 ha ganado!");
            }
            else
            {
                txtResultados.AppendText("\nEs un empate.");
            }

            // Agregar el TextBox a la ventana emergente
            ventanaResultados.Controls.Add(txtResultados);

            // Mostrar la ventana emergente como un cuadro de diálogo
            ventanaResultados.ShowDialog();
        }
    }
}
