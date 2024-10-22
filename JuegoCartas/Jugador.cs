using System.Text;

namespace JuegoCartas
{
    public class Jugador
    {
        private const int TOTAL_CARTAS = 10;
        private Carta[] cartas;
        private Random r = new Random();
        public int Puntaje { get; private set; }

        public Jugador()
        {
            Puntaje = 0;
        }

        // Este método reparte 10 cartas aleatorias a cada jugador utilizando la clase Random
        public void Repartir()
        {
            try
            {
                cartas = new Carta[TOTAL_CARTAS];
                for (int i = 0; i < TOTAL_CARTAS; i++)
                {
                    cartas[i] = new Carta(r); // Crea una nueva carta aleatoria para cada posición
                }
            }
            catch (Exception ex)
            {
                // Manejar el error, tal vez mostrar un mensaje en la interfaz de usuario.
                Console.WriteLine($"Error al repartir cartas: {ex.Message}");
            }
        }

        public void Mostrar(ListView lv)
        {
            lv.Items.Clear();
            if (cartas == null) return; // Evita un NullReferenceException si no se ha llamado a Repartir.

            foreach (Carta carta in cartas)
            {
                carta.mostrar(lv);
            }
        }

        // Este método calcula el resultado del jugador, contando las cartas repetidas y buscando
        public string ObtenerResultado()
        {
            Puntaje = 0;
            StringBuilder resultado = new StringBuilder();

            // Diccionarios para contar cartas y agrupar por pinta
            Dictionary<NombreCarta, int> contadorCartas = new Dictionary<NombreCarta, int>();
            Dictionary<Pinta, List<NombreCarta>> cartasPorPinta = new Dictionary<Pinta, List<NombreCarta>>();

            // Inicializar contadores de cartas y agrupar por pinta
            foreach (NombreCarta nombre in Enum.GetValues(typeof(NombreCarta)))
            {
                contadorCartas[nombre] = 0; // Inicializa contador de cada carta
            }
            foreach (Pinta pinta in Enum.GetValues(typeof(Pinta)))
            {
                cartasPorPinta[pinta] = new List<NombreCarta>(); // Inicializa lista de cartas por pinta
            }

            // Contar cartas y agrupar por pinta
            foreach (Carta carta in cartas)
            {
                NombreCarta nombre = carta.ObtenerNombre();
                Pinta pinta = carta.ObtenerPinta();
                contadorCartas[nombre]++;
                cartasPorPinta[pinta].Add(nombre);

                // Calcular puntaje
                Puntaje += ObtenerValorCarta(nombre);
            }

            // Mostrar las cartas repetidas
            resultado.AppendLine("Cartas repetidas:");
            foreach (var entry in contadorCartas)
            {
                if (entry.Value >= 2)
                {
                    resultado.AppendLine($"{entry.Value} cartas de valor {entry.Key}");
                }
            }

            // Verificar y mostrar escaleras por pinta
            resultado.AppendLine("\nEscaleras:");
            foreach (var entry in cartasPorPinta)
            {
                var cartasDePinta = entry.Value.OrderBy(c => (int)c).ToList();
                if (cartasDePinta.Count < 3) continue; // Evita la verificación de escaleras si no hay suficientes cartas

                int longitudEscalera = 1;
                NombreCarta inicioEscalera = cartasDePinta[0];

                for (int i = 1; i < cartasDePinta.Count; i++)
                {
                    if ((int)cartasDePinta[i] == (int)cartasDePinta[i - 1] + 1)
                    {
                        longitudEscalera++;
                    }
                    else
                    {
                        if (longitudEscalera >= 3)
                        {
                            resultado.AppendLine($"Escalera de {longitudEscalera} cartas de {inicioEscalera} a {cartasDePinta[i - 1]} en {entry.Key}");
                        }
                        longitudEscalera = 1;
                        inicioEscalera = cartasDePinta[i];
                    }
                }

                // Si la última secuencia también es una escalera
                if (longitudEscalera >= 3)
                {
                    resultado.AppendLine($"Escalera de {longitudEscalera} cartas de {inicioEscalera} a {cartasDePinta.Last()} en {entry.Key}");
                }
            }

            // Mostrar puntaje total
            resultado.AppendLine($"\nPuntaje total: {Puntaje}");

            return resultado.ToString();
        }

        private int ObtenerValorCarta(NombreCarta nombre) =>
    nombre switch
    {
        NombreCarta.AS or NombreCarta.JACK or NombreCarta.QUEEN or NombreCarta.KING => 10,
        _ => (int)nombre + 1
    };
    }
}
