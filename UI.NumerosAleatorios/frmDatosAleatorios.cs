namespace UI.NumerosAleatorios
{
    public partial class frmDatosAleatorios : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        List<String> nombresm = new List<String>() { "Carlos", "David", "Sergio", "Sebastian", "Victor", "Martin", "Bucth", "John", "Rick" };
        List<String> nombresf = new List<String>() { "Carla", "Daniela", "Marcela", "Amy", "Sofia", "Cosmi", "Alejandra", "Paola", "Zara" };
        List<String> apellidos = new List<string>() { "Alvarado", "Rambo", "Ortiz", "Cañibano", "Garcia", "Gonzales", "Bravo", "Wick" };
        public frmDatosAleatorios()
        {
            InitializeComponent();
        }
        String nombre, sexo;
        public void generacioneEmpleado()
        {
            Random random = new Random();
            int numero = random.Next(1000, 9999);
            int sex = random.Next(1, 3);
            int index, inde, range;

            if (sex == 1)
            {
                index = random.Next(nombresm.Count);
                inde = random.Next(apellidos.Count);
                nombre = nombresm[index] + " " + apellidos[inde];
                sexo = "masculino";
            }
            else if (sex == 2)
            {
                index = random.Next(nombresf.Count);
                inde = random.Next(apellidos.Count);
                nombre = nombresf[index] + " " + apellidos[inde];
                sexo = "femenino";
            }
            DateTime fechai = new DateTime(1960, 1, 1);
            range = (DateTime.Today - fechai).Days;
            DateTime fecha = fechai.AddDays(random.Next(range));
            int grupo = random.Next(1, 9);
            double min = 10000.00;
            double max = 30000.00;
            double rg= min+(max-min)*random.NextDouble();
            double sueldo = Math.Round(rg,2);
            bool seguro = random.Next(0, 2) == 0 ? false : true;
            Empleado e = new Empleado(numero, nombre, sex, fecha, grupo, sueldo, seguro);
            empleados.Add(e);

        }

        private void btnMostrarMensaje_Click_1(object sender, EventArgs e)
        {
            this.generacioneEmpleado();
            empleados.ForEach(e =>
            {
                NumeroTxt.Text = e.getNumero().ToString();
                NombreTxt.Text = e.getNombre();
                FechaNacimiento.Value = e.getFecha();
                if (e.getSexo() == 1)
                {
                    Masculino.Checked = true;
                }
                else if (e.getSexo() == 2)
                {
                    Femenino.Checked = true;
                }
                Grupotxt.Text = e.getGrupo().ToString();
                SueldoTxt.Text = e.getSueldo().ToString();
                Seguro.Checked = e.getSeguro();

            });
        }
    }
}