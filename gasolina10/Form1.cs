namespace gasolina10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            int i;
            double precio = 293.6;
            double pmcarretera = 10.5;
            double pmciudad = 12.5;
            double galon = 3.78541;
            double paso = 0.1;
            double litro;
            double costoxkm;
            double kmxgalon;
            for (i = 0; i < 22; i++)
            {

                int n = gasolina.Rows.Add();
                gasolina.Rows[n].Cells[0].Value = i;

                for(pmciudad = 12.5; pmciudad > pmcarretera; pmciudad = pmciudad-paso)
                {
                    gasolina.Rows[n].Cells[1].Value = pmciudad;
                }
                kmxgalon = litro = 10 / galon;
                gasolina.Rows[n].Cells[2].Value = kmxgalon;
                costoxkm = precio / kmxgalon;
                gasolina.Rows[n].Cells[3].Value = costoxkm;
            }
        }
    }
}