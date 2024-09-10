using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace ChordBook
{
    public partial class Chord : Label
    {
        public event Action<Chord, int> MovementRequested;

        public static string[] Keys => new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        private int Key { get; set; }
        private string Ending { get; set; }
        private bool Clicked { get; set; }

        private int shiftDistance;
        private DateTime clickTime;
        private bool longClick;

        public Chord(int key, string ending)
        {
            InitializeComponent();
            Load(key, ending);
        }

        public Chord(IContainer container)
        {
            container.Add(this);
            Load(0, "");
        }

        private void Load(int key, string ending)
        {
            InitializeComponent();
            Set(key, ending);
            Cursor = Cursors.SizeWE;
        }

        private void Set(int key, string ending)
        {
            Key = key;
            Ending = ending;
            Text = Keys[key] + ending;
        }

        private void Chord_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Clicked = true;
                shiftDistance = MousePosition.X - Location.X;
                clickTime = DateTime.Now;
            }
        }

        private void Chord_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Clicked = false;

                if (longClick)
                    longClick = false;
                else
                {
                    var editChordDialog = new EditChordDialog(Key, Ending, Set);
                    editChordDialog.ShowDialog();
                }
            }
        }

        private void Ticker_Tick(object sender, EventArgs e)
        {
            if (Clicked)
            {
                if (longClick)
                    MovementRequested?.Invoke(this, shiftDistance);
                else
                {
                    var timeDif = (DateTime.Now - clickTime).TotalSeconds;
                    if (timeDif >= 1/4f)
                        longClick = true;
                }
            }
        }
    }
}
