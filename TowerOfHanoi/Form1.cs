using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerOfHanoi
{
    public partial class Form1 : Form
    {
        private ListBox PickedUpStack;
        public Form1()
        {
            InitializeComponent();
            this.Stack1.Items.Add(1);
            this.Stack1.Items.Add(2);
            this.Stack1.Items.Add(3);
            this.Stack1.Items.Add(4);
            this.Stack1.Items.Add(5);
            this.Stack1.Items.Add(6);
            this.Stack1.Items.Add(7);
        }

        private void ClickAction(object sender, EventArgs e)
        {

            Button clickedButton = (Button)sender;
            switch (clickedButton.Text)
            {
                case "Pick up":
                    this.PickUp(clickedButton);
                    break;
                case "Place down":
                    this.PlaceDown(clickedButton);
                    break;
            }
        }

        private void PickUp(Button clickedButton)
        {
            switch (clickedButton.Name)
            {
                case "1":
                    this.PickedUpStack = this.Stack1;
                    break;
                case "2":
                    this.PickedUpStack = this.Stack2;
                    break;
                case "3":
                    this.PickedUpStack = this.Stack3;
                    break;
            }
            if (this.PickedUpStack.Items.Count > 0)
            {
                this.button1.Text = "Place down";
                this.button2.Text = "Place down";
                this.button3.Text = "Place down";
            }
            
        }

        private void PlaceDown(Button clickedButton)
        {
            ListBox PlacedDownStack = null;
            switch (clickedButton.Name)
            {
                
                case "1":
                    PlacedDownStack = this.Stack1;
                    break;
                case "2":
                    PlacedDownStack = this.Stack2;
                    break;
                case "3":
                    PlacedDownStack = this.Stack3;
                    break;
            }
            if (PlacedDownStack.Items.Count > 0)
            {
                if (
                       Int32.Parse(this.PickedUpStack.Items[0].ToString()) <= Int32.Parse(PlacedDownStack.Items[0].ToString()) ||
                       PlacedDownStack.Items.Count == 0
                   )
                {
                    PlacedDownStack.Items.Insert(0, Int32.Parse(this.PickedUpStack.Items[0].ToString()));
                    this.PickedUpStack.Items.RemoveAt(0);
                    this.button1.Text = "Pick up";
                    this.button2.Text = "Pick up";
                    this.button3.Text = "Pick up";
                }
            }
            else
            {
                PlacedDownStack.Items.Insert(0, Int32.Parse(this.PickedUpStack.Items[0].ToString()));
                this.PickedUpStack.Items.RemoveAt(0);
                this.button1.Text = "Pick up";
                this.button2.Text = "Pick up";
                this.button3.Text = "Pick up";
            }
        }
    }
}
