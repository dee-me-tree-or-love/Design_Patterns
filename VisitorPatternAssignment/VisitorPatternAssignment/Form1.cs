using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisitorPatternAssignment
{
    public partial class Form1 : Form
    {
        private Map map;
        private Visitor vis;

        /// <summary>
        /// Craetes a visitor based on radiobuttons
        /// </summary>
        /// <returns></returns>
        private Visitor createVisitor()
        {
            if (this.rdbtnAdventerType.Checked)
            {
                return new Adventurer();
            }
            else
            {
                return new Explorer();
            }
        }

        /// <summary>
        /// when the button is pressed - try to go to the next room
        /// </summary>
        private void nextStep()
        {
            if(this.map != null && this.vis != null)
            {
                //try
                //{
                    bool res = this.map.goToNextRoom(Convert.ToInt32((this.cmbxNextRoom.SelectedItem)));
                if (res)
                {
                    this.map.currentRoom.accept(vis);
                    this.tbImpression.Text = vis.impression;
                }
                //}
                //catch
                //{
                //    MessageBox.Show("Invalid room");
                //}
                
            }
        }

        /// <summary>
        /// log the current state of the adventure to the listbox
        /// </summary>
        private void logState()
        {
            string connectedRooms = "";
            this.cmbxNextRoom.Items.Clear();
            foreach (Room r in this.map.currentRoom.neighourRooms)
            {
                connectedRooms += r.Key + ",";
                this.cmbxNextRoom.Items.Add(r.Key);
            }
            this.cmbxNextRoom.SelectedIndex = 0;
            this.lbAdventureStatus.Items.Insert(0, "-------------");
            this.lbAdventureStatus.Items.Insert(0, "> " + connectedRooms);
            this.lbAdventureStatus.Items.Insert(0, "Next Rooms: ");
            this.lbAdventureStatus.Items.Insert(0, "> " + this.vis.nrSteps);
            this.lbAdventureStatus.Items.Insert(0, "Number of Steps: ");
            this.lbAdventureStatus.Items.Insert(0, "> " + this.vis.impression);
            this.lbAdventureStatus.Items.Insert(0, "Impression: ");
            this.lbAdventureStatus.Items.Insert(0, "> " + this.vis.buff);
            this.lbAdventureStatus.Items.Insert(0, "Buff: ");
            this.lbAdventureStatus.Items.Insert(0, "Visitor in the room: " + map.currentRoom.Key);
            this.lbAdventureStatus.Items.Insert(0, ">> " + DateTime.Now);
        }

        public Form1()
        {
            InitializeComponent();

            object[] complChoices = new object[] { COMPLEXITY.EASY, COMPLEXITY.NORMAL };
            this.cmbxComplexity.Items.AddRange(complChoices);
            this.cmbxComplexity.SelectedIndex = 0; // the first item 

        }

        private void btnStartAdventure_Click(object sender, EventArgs e)
        {
            this.lbAdventureStatus.Items.Clear();
            this.vis = this.createVisitor();
            this.map = new Map((COMPLEXITY)(this.cmbxComplexity.SelectedItem));
            this.map.currentRoom.accept(vis);
            this.tbImpression.Text = vis.impression;
            RoomF lroom = (RoomF) this.map.getLastRoom();
            lroom.gameFinished += this.recordFinish;
            this.logState();
        }

        private void recordFinish(int nrSteps)
        {
            MessageBox.Show("You have reached the end in "+ nrSteps + " steps", "Hoorah");
        }

        private void btnNextRoom_Click(object sender, EventArgs e)
        {
            this.nextStep();
            this.logState();
        }
    }
}
