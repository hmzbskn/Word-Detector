using System.IO;

namespace Word_Detector
{
    public partial class Form1 : Form
    {
        string[,] kelimeler;
        int wordsNumber = 0;
        Words[] knownWords;
        int knownWordsNumber = 0;
        Words[] unknownWords;
        int unknownWordsNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public void showNewWord()
        {
            if (wordsNumber > kelimeler.GetLength(0) - 1)
            {
                MessageBox.Show("Kelimeler tükendi");
                btn_idontknow.Enabled = false;
                btn_iknow.Enabled = false;
                btn_questionmark.Enabled = false;
            }
            else
            {
                lbl_english.Text = kelimeler[wordsNumber, 0];
            }

            //sytem out of range e düþtü
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //okuma yapýlacak
            string fullpath = @"C:\Users\REÞAT\source\repos\Word Detector\Word Detector\words.txt";
            string[] _words = File.ReadAllLines(fullpath);

            kelimeler = new string[_words.Length, 2];

            knownWords = new Words[kelimeler.GetLength(0)];
            unknownWords = new Words[kelimeler.GetLength(0)];



            for (int i = 0; i < _words.Length; i++)
            {
                string[] gecici = new string[2];
                if (gecici[0] == "")
                {

                }
                else
                {
                    gecici = _words[i].Split('+');
                    kelimeler[i, 0] = gecici[0].Trim();
                    kelimeler[i, 1] = gecici[1].Trim();
                }
            }

            lbl_english.Text = kelimeler[0, 0];
        }

        private void btn_questionmark_Click(object sender, EventArgs e)
        {
            lbl_turkish.Text = kelimeler[wordsNumber, 1];
        }

        private void btn_iknow_Click(object sender, EventArgs e)
        {
            Words _knownword = new Words();
            _knownword.wordTurkish = kelimeler[wordsNumber, 1];
            _knownword.wordEnglish = kelimeler[wordsNumber, 0];
            //tryparse da yapabiliriz
            _knownword.wordDisplayCount = 1;
            _knownword.wordCorrectCount = 1;
            //rationun oranýný verdik
            _knownword.oranBulma();

            //bu kelimeyle iþimizin bittiðini gösterir
            kelimeler[wordsNumber, 0] = "";
            kelimeler[wordsNumber, 1] = "";

            lbl_turkish.Text = "Meaning";
            knownWords[knownWordsNumber] = _knownword;
            knownWordsNumber++;

            wordsNumber++;
            showNewWord();
        }

        private void btn_idontknow_Click(object sender, EventArgs e)
        {
            Words _unknownword = new Words();
            _unknownword.wordTurkish = kelimeler[wordsNumber, 1];
            _unknownword.wordEnglish = kelimeler[wordsNumber, 0];
            _unknownword.wordDisplayCount = 1;
            _unknownword.wordCorrectCount = 0;
            //ratio atamasý yapýldý
            _unknownword.oranBulma();

            //bu kelimeyle iþimizin bittiðini gösterir
            kelimeler[wordsNumber, 0] = "";
            kelimeler[wordsNumber, 1] = "";

            lbl_turkish.Text = "Meaning";
            unknownWords[unknownWordsNumber] = _unknownword;
            unknownWordsNumber++;

            wordsNumber++;
            showNewWord();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            btn_close.Enabled = false;
            btn_idontknow.Enabled = false;
            btn_iknow.Enabled = false;
            btn_questionmark.Enabled = false;
            string fullpath = @"C:\Users\REÞAT\source\repos\Word Detector\Word Detector\knownWords.txt";

            string[] _knownword = new string[knownWordsNumber];
            if (knownWordsNumber > 0)
            {
                for (int i = 0; i < knownWordsNumber; i++)
                {
                    _knownword[i] = knownWords[i].wordEnglish + " + " + knownWords[i].wordTurkish 
                        + " + " + knownWords[i].wordDisplayCount + " + " + knownWords[i].wordCorrectCount 
                        + " + " + knownWords[i].wordRatio;

                }
            }
            File.AppendAllLines(fullpath, _knownword);



            string uknownfullpath = @"C:\Users\REÞAT\source\repos\Word Detector\Word Detector\unknownWords.txt";
            string[] _unknownwords = new string[unknownWordsNumber];
            if(unknownWordsNumber > 0)
            {
                for (int i = 0; i < unknownWordsNumber; i++)
                {
                    _unknownwords[i] = unknownWords[i].wordEnglish + " + " + unknownWords[i].wordTurkish
                        + " + " + unknownWords[i].wordDisplayCount + " + " + unknownWords[i].wordCorrectCount
                        + " + " + unknownWords[i].wordRatio;
                }
            }
            File.AppendAllLines(uknownfullpath, _unknownwords);




            string wordfullpath = @"C:\Users\REÞAT\source\repos\Word Detector\Word Detector\words.txt";
            string[] geciciwords = new string[kelimeler.GetLength(0) - wordsNumber];

            for (int i = 0 ; i < geciciwords.Length; i++)
            {
                if (kelimeler[i + wordsNumber, 0] == "")
                {
                    continue;
                }
                else
                {
                    geciciwords[i] = kelimeler[i + wordsNumber, 0] + " + " + kelimeler[i + wordsNumber, 1];
                }
            }

            File.WriteAllLines(wordfullpath, geciciwords);
        }

        private void btn_quiz_Click(object sender, EventArgs e)
        {
            //new quiz sayfasý
        }
    }
}
