using System.Text;
using System.Windows.Forms;

namespace trasliterator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            EnText.Text = "";

            Translate(RuText.Text);
        }

        private void Translate(string ruText)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach(char c in ruText)
            {
                try
                {
                    stringBuilder.Append(simvols[c]); 
                } 
                catch 
                {
                    stringBuilder.Append(c);
                }
            }

            EnText.Text = stringBuilder.ToString();
        }

        Dictionary<char, string> simvols = new Dictionary<char, string>()
        {
            
            {'�', "A"},
            {'�', "B"},
            {'�', "V"},
            {'�', "G"},
            {'�', "D"},
            {'�', "E"},
            {'�', "E" },
            {'�', "ZH"},
            {'�', "Z" },
            {'�', "I"},
            {'�', "I"},
            {'�', "K"},
            {'�', "L"},
            {'�', "M"},
            {'�', "N"},
            {'�', "O"},
            {'�', "P"},
            {'�', "R"},
            {'�', "S"},
            {'�', "T"},
            {'�', "U"},
            {'�', "F"},
            {'�', "H"},
            {'�', "C"},
            {'�', "CH"},
            {'�', "SH"},
            {'�', "SH"},
            {'�', "IE"},
            {'�', "Y"},
            {'�', ""},
            {'�', "E"},
            {'�', "IU"},
            {'�', "YA"},
            {'�', "a"},
            {'�', "b"},
            {'�', "v"},
            {'�', "g"},
            {'�', "d"},
            {'�', "e"},
            {'�', "e"},
            {'�', "zh"},
            {'�', "z"},
            {'�', "i"},
            {'�', "i"},
            {'�', "k"},
            {'�', "l"},
            {'�', "m"},
            {'�', "n"},
            {'�', "o"},
            {'�', "p"},
            {'�', "r"},
            {'�', "s"},
            {'�', "t"},
            {'�', "u"},
            {'�', "f"},
            {'�', "h"},
            {'�', "c"},
            {'�', "ch"},
            {'�', "sh"},
            {'�', "sh"},
            {'�', "ie"},
            {'�', "y"},
            {'�', ""},
            {'�', "e"},
            {'�', "iu"},
            {'�', "ya" }
        };

        private void RuText_DoubleClick(object sender, EventArgs e)
        {
            RuText.Text = "";
            EnText.Text = "";
        }

        private void EnText_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(EnText.Text);
        }

        private void EnText_Click(object sender, EventArgs e)
        {
            EnText.Text = "";

            Translate(RuText.Text);
        }
    }
}

