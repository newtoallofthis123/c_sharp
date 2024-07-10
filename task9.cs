using System.Windows.Forms;
using System.Drawing;
namespace first
{
    public class MyForm : Form
    {
        public MyForm()
        {
            InitComponents();
        }

        public void InitComponents()
        {
            ColorDialog colorDialog = new();
            if (colorDialog.ShowDialog() == DialogResult.OK)

            {
                this.BackColor = colorDialog.Color;
            }
        }

        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.Run(new MyForm());
        }
    }
}
