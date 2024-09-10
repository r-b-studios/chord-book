using System;
using System.Windows.Forms;

namespace ChordBook
{
    public partial class Window : Form
    {
        private string Path { get; set; }

        public Window(string path)
        {
            InitializeComponent();
            Path = path;
        }

        private void Window_Resize(object sender, EventArgs e)
        {

        }
    }
}
