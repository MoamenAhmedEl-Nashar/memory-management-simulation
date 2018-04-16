using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoryAllocation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Hole> arrayOfHoles=new List<Hole>();
        List<Process> arrayOfProcesses = new List<Process>();
        //insert holes
        private void button1_Click(object sender, EventArgs e)
        {
            
            Hole inputHole=new Hole();
            inputHole.startingAddress = int.Parse(holeStartingAdressText.Text);
            inputHole.size = int.Parse(holeSizeText.Text);
            arrayOfHoles.Add(inputHole);
            //drawing the inserted hole
            Label holeLabel = new Label();
            holeLabel.Location = new Point(0,inputHole.startingAddress);
            holeLabel.Width = 200;
            holeLabel.Height = inputHole.size;
            holeLabel.BackColor = Color.LightBlue;
            panel.Controls.Add(holeLabel);
            # region concatenate the array of holes
            //concatenate the array of holes
            if (arrayOfHoles.Count() > 1)
            {
                for (int i = 0; i < arrayOfHoles.Count(); i++)
                {
                    for (int j = 0; j < arrayOfHoles.Count()-1; j++)
                    {
                        if (arrayOfHoles[i].size - arrayOfHoles[i].startingAddress == arrayOfHoles[j].startingAddress)
                        {
                            Hole newHole = new Hole();
                            newHole.startingAddress = arrayOfHoles[i].startingAddress;
                            newHole.size = arrayOfHoles[i].size + arrayOfHoles[j].size;
                            arrayOfHoles.Remove(arrayOfHoles[i]);
                            arrayOfHoles.Remove(arrayOfHoles[j]);
                            arrayOfHoles.Add(newHole);
                        }
                    }
                }
            }
                
            //////////--------------------------/////////////

            #endregion
        }
        //insert processes with 3 options
        private void button2_Click(object sender, EventArgs e)
        {
            
            Process inputProcess = new Process();
            inputProcess.id = int.Parse(processIDText.Text);
            inputProcess.size = int.Parse(processSizeText.Text);
            if(radioButtonFirstFit.Checked==true)
            {
                bool flag = false;
                foreach(Hole hole in arrayOfHoles)
                {
                    if(inputProcess.size<=hole.size)
                    {
                        flag = true;
                        //process handling
                        inputProcess.startingAddress = hole.startingAddress;
                        arrayOfProcesses.Add(inputProcess);
                        
                        //drawing process as a button
                        Button processButton = new Button();
                        processButton.Location = new Point(0,hole.startingAddress);
                        processButton.Width =200;
                        processButton.Height =inputProcess.size;
                        processButton.Text = "process " + inputProcess.id.ToString();
                        processButton.BackColor = Color.Khaki;
                        processButton.Click += new EventHandler(processButton_Click);
                        
                        panel.Controls.Add(processButton);
                        processButton.BringToFront();

                        //hole handling
                        hole.size -= inputProcess.size;
                        hole.startingAddress += inputProcess.size;
                        if (hole.size == 0) arrayOfHoles.Remove(hole);
                        break;
                    }
                }
                if (!flag) MessageBox.Show("process must wait");
            }
            else if(radioButtonBestFit.Checked==true)
            {
                bool flag = false;
                arrayOfHoles = arrayOfHoles.OrderBy(o => o.size).ToList();
                foreach (Hole hole in arrayOfHoles)
                {

                    if (inputProcess.size <= hole.size)
                    {
                        flag = true;
                        //process handling
                        inputProcess.startingAddress = hole.startingAddress;
                        arrayOfProcesses.Add(inputProcess);

                        //drawing process as a button
                        Button processButton = new Button();
                        processButton.Location = new Point(0, hole.startingAddress);
                        processButton.Width = 200;
                        processButton.Height = inputProcess.size;
                        processButton.Text = "process " + inputProcess.id.ToString();
                        processButton.BackColor = Color.Khaki;
                        processButton.Click += new EventHandler(processButton_Click);

                        panel.Controls.Add(processButton);
                        processButton.BringToFront();

                        //hole handling
                        hole.size -= inputProcess.size;
                        hole.startingAddress += inputProcess.size;
                        if (hole.size == 0) arrayOfHoles.Remove(hole);
                        break;
                    }
                }
                if (!flag) MessageBox.Show("process must wait");
            }
            else if(radioButtonWorstFit.Checked==true)
            {
                bool flag = false;
                arrayOfHoles = arrayOfHoles.OrderByDescending(o => o.size).ToList();
                foreach (Hole hole in arrayOfHoles)
                {

                    if (inputProcess.size <= hole.size)
                    {
                        flag = true;
                        //process handling
                        inputProcess.startingAddress = hole.startingAddress;
                        arrayOfProcesses.Add(inputProcess);

                        //drawing process as a button
                        Button processButton = new Button();
                        processButton.Location = new Point(0, hole.startingAddress);
                        processButton.Width = 200;
                        processButton.Height = inputProcess.size;
                        processButton.Text = "process " + inputProcess.id.ToString();
                        processButton.BackColor = Color.Khaki;
                        processButton.Click += new EventHandler(processButton_Click);

                        panel.Controls.Add(processButton);
                        processButton.BringToFront();

                        //hole handling
                        hole.size -= inputProcess.size;
                        hole.startingAddress += inputProcess.size;
                        if (hole.size == 0) arrayOfHoles.Remove(hole);
                        break;
                    }
                }
                if (!flag) MessageBox.Show("process must wait");
            }
            
        }
        //deallocation
        private void processButton_Click(object sender, EventArgs e)
        {
            Button processButton = sender as Button;
            processButton.Visible = false;
            
            int id = int.Parse((processButton.Text).Substring(8));
            Process wantedProcess = new Process();
            foreach(Process p in arrayOfProcesses)
            {
                if (p.id == id)
                    wantedProcess = p;
            }
            //hole handling when deallocation
            Hole replacedHole = new Hole();
            replacedHole.startingAddress = wantedProcess.startingAddress;
            replacedHole.size =wantedProcess.size;
            arrayOfHoles.Add(replacedHole);

# region concatenate the array of holes
            //concatenate the array of holes
            if (arrayOfHoles.Count()>2)
            for(int i=0;i<arrayOfHoles.Count();i++)
            {
                for(int j = 0; j < arrayOfHoles.Count()-1; j++)
                {
                    if( arrayOfHoles[i].size-arrayOfHoles[i].startingAddress == arrayOfHoles[j].startingAddress)
                    {
                        Hole newHole = new Hole();
                        newHole.startingAddress = arrayOfHoles[i].startingAddress;
                        newHole.size = arrayOfHoles[i].size + arrayOfHoles[j].size;
                        arrayOfHoles.Remove(arrayOfHoles[i]);
                        arrayOfHoles.Remove(arrayOfHoles[j]);
                        arrayOfHoles.Add(newHole);
                    }
                }
            }
            //////////--------------------------/////////////

            #endregion
            arrayOfProcesses.Remove(wantedProcess);
        }
        //reset button
        private void button3_Click(object sender, EventArgs e)
        {
            arrayOfHoles.Clear();
            arrayOfProcesses.Clear();
            panel.Controls.Clear();
        }
        
        

    }
}

class Hole
{
   public int startingAddress;
   public int size;
}
class Process
{
    public int id;
    public int startingAddress;
    public int size;
}