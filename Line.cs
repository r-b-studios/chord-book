using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChordBook
{
    public partial class Line : UserControl
    {
        private List<Chord> Chords { get; } = new List<Chord>();

        public Line()
        {
            InitializeComponent();
            Chords.Add(chord1);
            chord1.MovementRequested += Chord_MovementRequested;
        }

        public void Chord_MovementRequested(Chord sender, int shiftDistance)
        {
            var x = Math.Max(Math.Min(MousePosition.X - shiftDistance, Width - 10 - sender.Width), 50);
            sender.Location = new Point(x, sender.Location.Y);
        }
    }
}
