using M2M4.Controller;
using M2M4.Model;
using M2M4.Model;

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
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                cursos.carregarModel(ofd.FileName);
            }
            
            
        }
    }
}