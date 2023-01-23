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
            
            {'À', "A"},
            {'Á', "B"},
            {'Â', "V"},
            {'Ã', "G"},
            {'Ä', "D"},
            {'Å', "E"},
            {'¨', "E" },
            {'Æ', "ZH"},
            {'Ç', "Z" },
            {'È', "I"},
            {'É', "I"},
            {'Ê', "K"},
            {'Ë', "L"},
            {'Ì', "M"},
            {'Í', "N"},
            {'Î', "O"},
            {'Ï', "P"},
            {'Ð', "R"},
            {'Ñ', "S"},
            {'Ò', "T"},
            {'Ó', "U"},
            {'Ô', "F"},
            {'Õ', "H"},
            {'Ö', "C"},
            {'×', "CH"},
            {'Ø', "SH"},
            {'Ù', "SH"},
            {'Ú', "IE"},
            {'Û', "Y"},
            {'Ü', ""},
            {'Ý', "E"},
            {'Þ', "IU"},
            {'ß', "YA"},
            {'à', "a"},
            {'á', "b"},
            {'â', "v"},
            {'ã', "g"},
            {'ä', "d"},
            {'å', "e"},
            {'¸', "e"},
            {'æ', "zh"},
            {'ç', "z"},
            {'è', "i"},
            {'é', "i"},
            {'ê', "k"},
            {'ë', "l"},
            {'ì', "m"},
            {'í', "n"},
            {'î', "o"},
            {'ï', "p"},
            {'ð', "r"},
            {'ñ', "s"},
            {'ò', "t"},
            {'ó', "u"},
            {'ô', "f"},
            {'õ', "h"},
            {'ö', "c"},
            {'÷', "ch"},
            {'ø', "sh"},
            {'ù', "sh"},
            {'ú', "ie"},
            {'û', "y"},
            {'ü', ""},
            {'ý', "e"},
            {'þ', "iu"},
            {'ÿ', "ya" }
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

