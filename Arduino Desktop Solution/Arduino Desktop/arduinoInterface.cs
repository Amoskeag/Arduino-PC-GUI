using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
//using CRC8_Class;

namespace Arduino_Desktop
{
    public partial class arduinoInterface : Form
    {
        public configForm cForm;      // needs to be declared public
        private arduinoInterface.STATE_INFO state_info;


        public arduinoInterface(SerialPort SP)
        {
            InitializeComponent();

            activePort = SP;    //Set the port info!

            //Best practice is to declare it yourself. this is why it wasnt working initially.
            activePort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.activePort_DataReceived);

            //Show the port data 
            string state = "Closed";

            if (activePort.IsOpen)
            {
                state = "Open";


            }

            lblPortData.Text = activePort.PortName;
            lblBaudRate.Text = activePort.BaudRate.ToString();
            lblDataBits.Text = activePort.DataBits.ToString();
            lblHandShake.Text = activePort.Handshake.ToString();
            lblParity.Text = activePort.Parity.ToString();
            lblStopBits.Text = activePort.StopBits.ToString();
            lblState.Text = state;

            stopTestBtn.Enabled = false;
            testBtn.Enabled = true;

        }

        //Basic States for Packet Processing.
        private enum STATE
        {
            GET_HEADER,         //At Header.
            FIND_LEN,           //get length for data collection.
            COLLECTING_DATA     //collect the data for processing.
        }

        private struct STATE_INFO
        {
            public STATE state;         //hold the state of process
            public byte[] recvPacket;   //hold the byte Array
            public int _expecting;      //the expected number for the data
            public int nextByte;        //the next index.
        }

        private void stopTestBtn_Click(object sender, EventArgs e)
        {
            //Stop the testing loop.
            stopTestBtn.Enabled = false;
            testBtn.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(activePort.IsOpen)
            {
                activePort.Close();
            }

            this.Close();
            //Application.Exit();
        }

        //Open the configForm to communicate to Arduino.
        private void comPortSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open the Configuration Form 
            configForm cF = new configForm();

            //we are changing the port settings, shut down if not shutdown.
            if (activePort.IsOpen)
            {
                activePort.Close();
            }
            //close current window.
            this.Close();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            //Run the test, till the end. After test is done, let the user use
            //the controls other than the stop button.

            //Check if there is an active connection.

            //if not "MessageBox.Show("The serial port must be opened before data can be written.");" No device connected.
            //return.
            testBtn.Enabled = false;
            stopTestBtn.Enabled = true;


        }

        private void activePort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //DATA IN! AUTOBOTS PROCESS IT!
            /*
            rTxtBoxRecieve.Invoke(new EventHandler(delegate
            {
                string dataReceived = activePort.ReadExisting();
                
                rTxtBoxRecieve.AppendText(dataReceived);
            }));
             */
            // processPacket();

            ///this only works with standard settings.
            ///
            rTxtBoxRecieve.Invoke(new EventHandler(delegate
            {
                rTxtBoxRecieve.AppendText(ProcessPacket());
            }));


        }

        //this is used to process the data received.
        private string ProcessPacket()
        {
            string dataRead = "";
            //while we have data to read from the port.
            while (activePort.BytesToRead > 0)
            {
                //if the first byte is a 0x01 this is the header set the state to the beginning
                byte num = (byte)activePort.ReadByte();
                if (num == (byte)1)
                {
                    //header
                    //header = num.ToString();
                    rTxtBoxRecieve.AppendText("HEADER: " + num + "\n");
                    state_info.state = STATE.GET_HEADER;
                }

                //Switch case that reads the current state from a struct with relevant information.
                switch (state_info.state)
                {
                    case STATE.GET_HEADER:
                        if (num == (byte)1)
                        {
                            //header
                            state_info.state = STATE.FIND_LEN;
                        }
                        break;

                    case STATE.FIND_LEN:
                        /*
                        recvPacket = new byte[num];
                        _state = COLLECT_DATA;
                        _expecting = num - 2;
                        */
                        state_info.recvPacket = new byte[num];
                        state_info.state = STATE.COLLECTING_DATA;
                        state_info._expecting = num - 2;
                        state_info.recvPacket[0] = (byte)1;
                        state_info.recvPacket[1] = num;
                        state_info.nextByte = 2;
                        //lengthOfData = state_info._expecting.ToString();

                        break;

                    case STATE.COLLECTING_DATA:
                        //get the data out of the packet from byteArr[2] to byteArr[x] where x is the last byte of the data.
                        state_info.recvPacket[state_info.nextByte] = num;
                        --state_info._expecting;
                        ++state_info.nextByte;
                        if (state_info._expecting <= 0)
                        {
                            dataRead = ReadPacket(state_info.recvPacket);
                            state_info.state = STATE.GET_HEADER;
                            break;
                        }
                        break;

                }

            }
            return dataRead;
        }

        //creates the data packet everything is cast as a byte so I dont need to worry about messing with other data types.
        //after looking online Im not sure why ref is needed
        private void CreatePacket(string message, ref byte[] packet, ref int packetLen)
        {
            byte num = (byte)(message.Length + 3); //make room for header, length, and crc.
            packetLen = (int)num;
            packet = new byte[(int)num];
            Encoding.ASCII.GetBytes(message, 0, message.Length, packet, 2);
            packet[0] = (byte)1;    //header
            packet[1] = num;        //length
            CRC_Class crcClass = new CRC_Class(packet);
            packet[packet.Length - 1] = (byte)crcClass.crcCalc();  //crc

            rTxtBoxSent.AppendText("SENT CRC: " + packet[packet.Length - 1]);

        }

        /*put the packet data into the rtextbox.
        private string ReadPacket(byte[] packet)
        {
            CRC_Class crcClass = new CRC_Class(packet);
            byte check = (byte)crcClass.crcCalc();  //crc

            if (check != (byte)0)
            {
                //good data.
                MessageBox.Show("Transmission Error!");
            }

            packet[packet.Length - 1] = (byte)0;
            rTxtBoxRecieve.AppendText("MESSAGE: " + Encoding.ASCII.GetString(packet, 2, packet.Length - 2));
            rTxtBoxRecieve.AppendText("\nCRC CHECK: " + check);
            rTxtBoxRecieve.AppendText("\nLENGTH OF DATA: " + (packet.Length - 1));
            //I have some work to do this return is really not nessesary and I broke my code a lot
            //this is really patchy work on my part D:
            return "";
        }*/


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //about information
            MessageBox.Show("Arduino Desktop\n\nVersion 1.0\n\nProgrammer: Arthur W. Aznive Jr.", "About");
        }
    }
}
