using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageValues
{
    public partial class Form1 : Form
    {
        double sum = 0;
        double counter = 0;
        double averageNum = 0;
        double addCounter = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            counter = Convert.ToDouble(inputTextbox.Text);
           
            

            if( counter == 0)
            {
                averageNum = sum / addCounter;
                outputLabel.Text = $"The average of all numbers entered is {averageNum}";
               
            }
            else
            {
                addCounter++;
                sum = sum + counter;
                outputLabel.Text = $"{counter} was added to the sum";
            }
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addCounter = 0;
            sum = 0;
            averageNum = 0;
            counter = 0;
            outputLabel.Text = "";
            inputTextbox.Text = "";
        }
    }
}
