namespace probarControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //tableLayoutPanel1.Scroll += new ScrollEventHandler(tableLayoutPanel1_Scroll);
            tableLayoutPanel1.Scroll += new ScrollEventHandler(tableLayoutPanel1_Scroll);

        }
        private void tableLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            // Obtener la posici�n actual
            int verticalScrollPosition = tableLayoutPanel1.VerticalScroll.Value;

            // Actualizar la etiqueta que muestra la posici�n
            label2.Text = $"Posici�: ({verticalScrollPosition})";
        }
    }
}