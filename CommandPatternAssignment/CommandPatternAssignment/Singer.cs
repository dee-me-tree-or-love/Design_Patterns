using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternAssignment
{
    public class Singer
    {
        public String note;
        private Listener audience;
        private Bitmap[] sprites;
        private bool isSinging; 

        public Singer(string _n, Listener _l, Bitmap silent, Bitmap singing)
        {
            this.note = _n;
            this.audience = _l;
            isSinging = false;
            this.sprites = new Bitmap[] { silent, singing };
        }
        
        /// <summary>
        /// Sets the singer to the singing state
        /// </summary>
        public void Sing()
        {
            // set the singing property to true
            this.isSinging = true;
            this.audience.RecordNote(this);
            // once the listeners have got the message, set to not singing
            this.isSinging = false;    
        }

        public Bitmap getPicture()
        {
            // this.isSinging ? 1 : 0 is an explicit boolean convert to int
            return this.sprites[this.isSinging ? 1 : 0];
        }
    }
}
