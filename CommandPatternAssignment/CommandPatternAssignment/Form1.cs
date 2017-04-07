using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandPatternAssignment
{
    public interface Listener
    {
        void RecordNote(Singer _s);

        Singer[] RespecializeTrio();

        void AddNewline();
    }

    public partial class Form1 : Form, Listener
    {
        private Singer[] trio;
        private Dictionary<Singer, PictureBox> trioBinding;
        private PlayBackRecordCommand PlayBackRecord = new PlayBackRecordCommand();

        public Form1()
        {
            InitializeComponent();
            this.tmrSingerInvalidator.Start();
            // initialize the dictionary
            trioBinding = new Dictionary<Singer, PictureBox>();
            // populate the trio
            trio = new Singer[] { new Singer("Do", this, Properties.Resources.silent1,Properties.Resources.singing1),
                new Singer("Re",this,Properties.Resources.silent2, Properties.Resources.singing2),
                new Singer("Mi", this,Properties.Resources.silent3,Properties.Resources.singing3) };
            // looks like a really weird way to do that
            trioBinding.Add(trio[0], this.pbFirstSinger);
            trioBinding.Add(trio[1], this.pbSecondSInger);
            trioBinding.Add(trio[2], this.pbThirdSinger);
        }

        /// <summary>
        /// Adds to history "recording" iff the checkbox is checked
        /// </summary>
        /// <param name="c"></param>
        private void addToHistory(ICommand c)
        {
            if (this.PlayBackRecord != null && this.cbRecordSong.Checked)
            {
                this.PlayBackRecord.AddCommand(c);
            }
        }

        /// <summary>
        /// Change trio's notes
        /// </summary>
        public Singer[] RespecializeTrio()
        {
            string[] notes = new string[] { "Do", "Re", "Mi", "Fa", "Sol", "La", "Si" };
            foreach (Singer s in this.trio)
            {
                s.note = notes[(new Random((int)DateTime.Now.Ticks & 0x0000FFFF).Next(0, 567)) % notes.Length];
                System.Threading.Thread.Sleep(30);
            }
            this.tbSongText.AppendText("\r\n----TRIO HAS NEW NOTES NOW----");
            return this.trio;
        }

        public void AddNewline()
        {
            this.tbSongText.AppendText("\r\n");
        }

        /// <summary>
        /// Adds a note to the 'lyrics'
        /// </summary>
        /// <param name="_s"></param>
        public void RecordNote(Singer _s)
        {
            this.tbSongText.AppendText("--" + _s.note.ToUpper());
            PictureBox spriteHolder = null;
            // try to get the value
            if (this.trioBinding.TryGetValue(_s, out spriteHolder))
            {
                spriteHolder.BackgroundImage = _s.getPicture();
            }
        }

        /// <summary>
        /// Used to issue the command to sing with the singer of trio index as a parameter
        /// Cathces an exception inside if such occurs
        /// </summary>
        /// <param name="singerOfTrioIndex"></param>
        private void issueSingingCommand(int singerOfTrioIndex)
        {
            try
            {
                ICommand com = new SingCommand(this.trio[singerOfTrioIndex]);
                this.addToHistory(com);
                com.execute();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        private void btnSingA_Click(object sender, EventArgs e)
        {
            // now the buttons can just give indexes
            issueSingingCommand(0);
        }

        private void btnSingB_Click(object sender, EventArgs e)
        {
            issueSingingCommand(1);
        }

        private void btnSingC_Click(object sender, EventArgs e)
        {
            issueSingingCommand(2);
        }
        // however, it is not very nice to have the hardcoded indexes either


        // a thing that invalidates the singer sprites - not very nice, but still works
        private void tmrSingerInvalidator_Tick(object sender, EventArgs e)
        {
            this.pbFirstSinger.BackgroundImage = Properties.Resources.silent1;
            this.pbSecondSInger.BackgroundImage = Properties.Resources.silent2;
            this.pbThirdSinger.BackgroundImage = Properties.Resources.silent3;
        }

        /// <summary>
        /// Plays back the actions that have happened, when the checkbox was checked
        /// If the trio has changed meanwhile the sounds will be different, but the sequence of calls will be the same
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayRecordedSong_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbSongText.AppendText("\r\n-----RECORD PLAYBACK-----");
                this.PlayBackRecord.execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ICommand c = new ChangeTrioCommand(this);
            c.execute();
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            // clears the recorded song
            this.PlayBackRecord.ClearCollection();
        }
    }
}
