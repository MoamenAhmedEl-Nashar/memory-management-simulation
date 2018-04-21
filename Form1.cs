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

        // holes and process lists
        List<Hole> arrayOfHoles=new List<Hole>();
        List<Process> arrayOfProcesses = new List<Process>();

        //insert holes
        private void button1_Click(object sender, EventArgs e)
        {
            Hole inputHole=new Hole();
            inputHole.startingAddress = (int)holeStartingAdressText.Value;
            inputHole.size = (int)holeSizeText.Value;
            if (inputHole.size == 0) {MessageBox.Show("Hole Size is Required"); return;}
            //make sure that the input-hole isn't existing already
            if(arrayOfHoles.Count != 0)
            {
                foreach(Hole P in arrayOfHoles)
                {
                    if ((inputHole.startingAddress + inputHole.size) <= (P.startingAddress + P.size)
                        && (inputHole.startingAddress>=P.startingAddress))
                    { MessageBox.Show("Hole is already existing"); return; }
                }
            }
            arrayOfHoles.Add(inputHole);

            //drawing the inserted hole
            Label holeLabel = new Label();
            holeLabel.Location = new Point(0,inputHole.startingAddress);
            holeLabel.Width = 200;
            holeLabel.Height = inputHole.size;
            holeLabel.BackColor = Color.LightBlue;
            holeLabel.MouseHover += new EventHandler(holeLabel_Hover);
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
            inputProcess.id = (int)processIDText.Value;
            inputProcess.size = (int)processSizeText.Value;
            if (inputProcess.size == 0) { MessageBox.Show("Process Size is Required"); return; }
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
                        processButton.Text = "Process " + inputProcess.id.ToString();
                        processButton.BackColor = Color.Khaki;
                        processButton.Click += new EventHandler(processButton_Click);
                        processButton.MouseHover += new EventHandler(processButton_Hover);
                        panel.Controls.Add(processButton);
                        processButton.BringToFront();

                        //hole handling
                        hole.size -= inputProcess.size;
                        hole.startingAddress += inputProcess.size+1;
                        if (hole.size == 0) { arrayOfHoles.Remove(hole); }
                        break;
                    }
                }
                if (!flag) MessageBox.Show("Process must wait");
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
                        processButton.Text = "Process " + inputProcess.id.ToString();
                        processButton.BackColor = Color.Khaki;
                        processButton.Click += new EventHandler(processButton_Click);
                        processButton.MouseHover += new EventHandler(processButton_Hover);
                        panel.Controls.Add(processButton);
                        processButton.BringToFront();

                        //hole handling
                        hole.size -= inputProcess.size;
                        hole.startingAddress += inputProcess.size+1;
                        if (hole.size == 0) arrayOfHoles.Remove(hole);
                        break;
                    }
                }
                if (!flag) MessageBox.Show("Process must wait");
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
                        processButton.Text = "Process " + inputProcess.id.ToString();
                        processButton.BackColor = Color.Khaki;
                        processButton.Click += new EventHandler(processButton_Click);
                        processButton.MouseHover += new EventHandler(processButton_Hover);
                        panel.Controls.Add(processButton);
                        processButton.BringToFront();

                        //hole handling
                        hole.size -= inputProcess.size;
                        hole.startingAddress += inputProcess.size+1;
                        if (hole.size == 0) arrayOfHoles.Remove(hole);
                        break;
                    }
                }
                if (!flag) MessageBox.Show("Process must wait");
            }

             // show message where no method is choosen
            else
            {
                MessageBox.Show("Please Choose a method of allocation");
            }
            
        }


        // Show process details when hovered
        private void processButton_Hover(object sender, EventArgs e)
        {
            Button processButton = sender as Button;
           
            ToolTip tip1 = new ToolTip();

            // find process
            int id = int.Parse((processButton.Text).Substring(8));
            Process wantedProcess = new Process();
            foreach (Process p in arrayOfProcesses)
            {
                if (p.id == id)
                    wantedProcess = p;
            }

            // process info
           string info = "Name: "+processButton.Text+"\nStarting Address: "
               +wantedProcess.startingAddress.ToString()+"\nEnd Address: "+
               (wantedProcess.startingAddress+wantedProcess.size).ToString()+
               "\nSize: "+wantedProcess.size.ToString()+"\nClick to deallocate.";

           tip1.SetToolTip(processButton, info);
        }


        // Show hole details when hovered
        private void holeLabel_Hover(object sender, EventArgs e)
        {
            Label holeLabel = sender as Label;

            ToolTip tip1 = new ToolTip();

            // find hole based on starting address
            int starting = holeLabel.Location.Y;
            Hole wantedHole = new Hole();
            foreach (Hole p in arrayOfHoles)
            {
                if (p.startingAddress == starting)
                    wantedHole = p;
            }

            // hole info
            string info = "Starting Address: " + wantedHole.startingAddress.ToString() +
                "\nEnd Address: " + (wantedHole.startingAddress + wantedHole.size).ToString() +
                "\nSize: " + wantedHole.size.ToString();

            tip1.SetToolTip(holeLabel, info);
        }

        //deallocation
        private void processButton_Click(object sender, EventArgs e)
        {
            Button processButton = sender as Button;
            //processButton.Visible = false;

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
            panel.Controls.Remove(processButton);
        }


        //reset button
        private void button3_Click(object sender, EventArgs e)
        {
            arrayOfHoles.Clear();
            arrayOfProcesses.Clear();
            panel.Controls.Clear();
        }
        
        //compact all holes into one and shift processes after it
        private void compact_Click(object sender, EventArgs e)
        {

            if (arrayOfHoles.Count != 0)
            {
                //compact holes
                arrayOfHoles = arrayOfHoles.OrderBy(arr => arr.startingAddress).ToList();
                Hole allinone = new Hole();
                allinone.startingAddress = arrayOfHoles[0].startingAddress;
                allinone.size = 0;
                foreach (Hole P in arrayOfHoles)
                {
                    allinone.size += P.size;
                }
                arrayOfHoles.Clear();
                arrayOfHoles.Add(allinone);

                if (arrayOfProcesses.Count != 0)
                {
                    //shift processes 
                    arrayOfProcesses = arrayOfProcesses.OrderBy(arr => arr.startingAddress).ToList();
                    arrayOfProcesses[0].startingAddress = allinone.startingAddress + allinone.size + 1;
                    for (int i = 1; i < arrayOfProcesses.Count; i++)
                    {
                        arrayOfProcesses[i].startingAddress =
                            arrayOfProcesses[i - 1].startingAddress + arrayOfProcesses[i - 1].size + 1;
                    }
                }

                //draw new hole and processes

                panel.Controls.Clear();
                //draw hole
                Label holeLabel = new Label();
                holeLabel.Location = new Point(0, allinone.startingAddress);
                holeLabel.Width = 200;
                holeLabel.Height = allinone.size;
                holeLabel.BackColor = Color.LightBlue;
                holeLabel.MouseHover += new EventHandler(holeLabel_Hover);
                panel.Controls.Add(holeLabel);
                //draw processes
                foreach (Process x in arrayOfProcesses)
                {
                    //drawing process as a button
                    Button processButton = new Button();
                    processButton.Location = new Point(0, x.startingAddress);
                    processButton.Width = 200;
                    processButton.Height = x.size;
                    processButton.Text = "Process " + x.id.ToString();
                    processButton.BackColor = Color.Khaki;
                    processButton.Click += new EventHandler(processButton_Click);
                    processButton.MouseHover += new EventHandler(processButton_Hover);
                    panel.Controls.Add(processButton);
                    processButton.BringToFront();
                }
            }

            else { MessageBox.Show("No Holes avaliable"); }

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