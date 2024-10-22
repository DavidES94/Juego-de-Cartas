namespace JuegoCartas
{
    public class Carta
    {
        private int indice;

        public Carta(Random r)
        {
            indice = r.Next(52) + 1;
        }

        public Pinta ObtenerPinta()
        {
            if (indice <= 13)
            {
                return Pinta.TREBOL;
            }
            else if (indice <= 26)
            {
                return Pinta.PICA;
            }
            else if (indice <= 39)
            {
                return Pinta.CORAZON;
            }
            else
            {
                return Pinta.DIAMANTE;
            }
        }

        public NombreCarta ObtenerNombre()
        {
            int residuo = indice % 13;
            if (residuo == 0)
            {
                residuo = 13;
            }
            return (NombreCarta)Enum.GetValues(typeof(NombreCarta)).GetValue(residuo - 1);
        }

        public void mostrar(ListView lv)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.ImageIndex = indice - 1;
            lv.Items.Add(lvi);
        }
    }
}
