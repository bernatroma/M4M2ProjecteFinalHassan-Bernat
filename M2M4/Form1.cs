using M2M4.Controller;

namespace M2M4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadXML_Click(object sender, EventArgs e){
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files (*.xml)|*.xml";
            ofd.ShowDialog();
            Console.WriteLine(ofd.FileName);
            CursosImport ci = new CursosImport(ofd.FileName);
        }
    }
}