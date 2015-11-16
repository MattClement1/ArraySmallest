/*
* Created by: Matthew Clement
* Created on: 16-Nov-2015
* Created for: Unit #5-03
* This program outputs the smallest value in an array of random numbers
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraySmallest
{
    public partial class frmArraySmallest : Form
    {
        public int SmallestNumber(int[] array)
        {
            //This function finds the smallest value in the array
            int smallestNumber = array[0];

            foreach (int arrayValue in array)
            {
                if (arrayValue < smallestNumber)
                {
                    smallestNumber = arrayValue;
                }
            }

            return smallestNumber;
        }

        public frmArraySmallest()
        {
            InitializeComponent();
        }

        private void btnClickHere_Click(object sender, EventArgs e)
        {
            //Local Variables
            int[] numArray = new int[15];
            Random rndNum = new Random();
            int smallestNum;

            //Generate array values
            for (int numCounter = 0; numCounter < 15; numCounter++)
            {
                int number = rndNum.Next(1, 20 + 1);
                numArray[numCounter] = number;
            }

            //Call function
            smallestNum = SmallestNumber(numArray);

            //Output
            MessageBox.Show("The smallest number is: " + smallestNum);
        }
    }
}
