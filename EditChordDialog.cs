using System.Windows.Forms;
using System;

namespace ChordBook
{
    public partial class EditChordDialog : Form
    {
        private Action<int, string> OnClose { get; }
        private int Key { get; set; }
        public string Ending { get; set; }

        public EditChordDialog(int key, string ending, Action<int, string> onClose)
        {
            InitializeComponent();

            OnClose = onClose;
            Key = key;
            Ending = ending;

            changeKeyLabel.Text = "Key: " + Chord.Keys[key];
            endingBox.Text = ending;
        }

        private void EditChordDialog_Closed(object sender, FormClosedEventArgs e)
        {
            OnClose(Key, endingBox.Text);
        }

        private void ChangeKeyButton_Click(object sender, EventArgs e)
        {
            if (Key < Chord.Keys.Length - 1) Key++;
            else Key = 0;

            changeKeyLabel.Text = "Key: " + Chord.Keys[Key];
        }
    }
}
