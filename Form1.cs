using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class cCalculator : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_Pressed = false;
        
        
        public cCalculator()
        {
            InitializeComponent();
            calcDisplay.Text = "";
            
        }

        private void cCalculator_Load(object sender, EventArgs e)
        {

        }

        private void calcExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool mouseDown;
        public Point lastLocation;
        private void mousePressed(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1) mouseDown = true;
            lastLocation = e.Location;
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point
                ((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void calcMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        
        private void num1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void calcDisplay_TextChanged(object sender, EventArgs e)
        {
           
           

        }

        private void numClear_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            calcProjector.Text = "";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            calcDisplay.Text = calcDisplay.Text+btn.Text;
            calcProjector.Text = calcProjector.Text + btn.Text;

        }

        private void numAddition_Click(object sender, EventArgs e)
        {
            
  

        }

        private void calcProjector_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void numEqual_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == string.Empty)
            {
                MessageBox.Show("Please enter values");
            }
            else
            {
                Button btn = (Button)sender;
                calcProjector.Text = calcProjector.Text + " " + btn.Text + " ";

                if (operation == "+") calcDisplay.Text = (value + Double.Parse(calcDisplay.Text)).ToString();

                if (operation == "-") calcDisplay.Text = (value - Double.Parse(calcDisplay.Text)).ToString();

                if (operation == "X") calcDisplay.Text = (value * Double.Parse(calcDisplay.Text)).ToString();

                if (operation == "/") calcDisplay.Text = (value / Double.Parse(calcDisplay.Text)).ToString();
            }
            
                    
            
            operation_Pressed = false;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            if(calcDisplay.Text == string.Empty)
            {
                MessageBox.Show("Please enter values");
            }
            else
            {
                Button btn = (Button)sender;
                operation = btn.Text;
                calcProjector.Text = calcProjector.Text + " " + btn.Text + " ";

                value = Double.Parse(calcDisplay.Text);
                operation_Pressed = true;
                if (operation_Pressed)
                {
                    calcDisplay.Clear();
                }
            }
           
        }
    }
}
