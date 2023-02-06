namespace WinFormsApp1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public class data { 
            public string uno { get; set; }
            public string dos    { get; set; }
            public string tres { get; set; }
            public string cuatro { get; set; }
            public string cinco { get; set; }
        }
        public Form1()
        {
            InitializeComponent();

            List<data> lista = new List<data>();
            int index = 0;
            lista.Add(new data()
            {
                uno = index++.ToString(),
                dos = index++.ToString(),
                tres = index++.ToString(),
                cuatro = index++.ToString(),
                cinco = index++.ToString()

            });

            lista.Add(new data()
            {
                uno = index++.ToString(),
                dos = index++.ToString(),
                tres = index++.ToString(),
                cuatro = index++.ToString(),
                cinco = index++.ToString()

            });

            lista.Add(new data()
            {
                uno = index++.ToString(),
                dos = index++.ToString(),
                tres = index++.ToString(),
                cuatro = index++.ToString(),
                cinco = index++.ToString()

            });

            lista.Add(new data()
            {
                uno = index++.ToString(),
                dos = index++.ToString(),
                tres = index++.ToString(),
                cuatro = index++.ToString(),
                cinco = index++.ToString()

            });

            metroGrid1.DataSource = lista;
            metroGrid1.Refresh();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}