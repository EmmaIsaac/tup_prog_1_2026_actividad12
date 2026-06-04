namespace ActividadBusquedaSecuencial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] vector = new int[100];
        int contador = 0;

        int BusquedaSecuencial(int buscado)
        {
            int idx = 0, idxBuscado = -1;
            while (idxBuscado == -1 && idx < contador)
            {
                if (vector[idx] == buscado)
                {
                    idxBuscado = idx;
                }
                idx++;
            }
            return idxBuscado;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormDatos fDatos = new FormDatos();
            if (fDatos.ShowDialog() == DialogResult.OK)
            {
                int valor = Convert.ToInt32(fDatos.tbValor.Text);

                #region Registrar
                vector[contador] = valor;
                contador++;
                #endregion
            }
            fDatos.Dispose();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FormDatos fDatos = new FormDatos();
            if (fDatos.ShowDialog() == DialogResult.OK)
            {
                int valor = Convert.ToInt32(fDatos.tbValor.Text);
                int idx = BusquedaSecuencial(valor);

                string resultado = $"No encontrado: {valor}";
                if (idx != -1)
                {
                    resultado = $"Encontrado {valor} en posicion {idx}";
                }
                FormSalida fSalida = new FormSalida();
                fSalida.lsbResultados.Items.Add(resultado);
                fSalida.ShowDialog();
            }
        }
    }
}
