using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;      //required for SerialPort Class

namespace Arduino_Desktop
{
    public partial class configForm : Form
    {
        // class constant definitions
        public const int BIT_RATE_LENGTH = 8;

        // declare instance variables
        private string[] portNames;   //stores names of equipped COM ports 

        //this is the serialPort object, it will have the configuration i need, and will be passed 
        //to the main form of the application, set to defaults unless changed.
        SerialPort _serialPort = new System.IO.Ports.SerialPort("COM1");

        public configForm()
        {
            InitializeComponent();

            // initialize all of the ComboBoxes shown in GUI
            loadComPortComboBox();
            loadBitRateComboBox();
            loadDataBitComboBox();
            loadStopBitsComboBox();
            loadParityComboBox();
            loadHandshakeComboBox();
        }
        private void loadComPortComboBox()
        {
            // local variable declarations
            int length;

            /* GetPortNames() is a public static method on the SerialPort
             * class so can invoke directly from the SerialPort class. This will
             * produce an array of detected COM ports on this machine (e.g.
             * COM1, COM2, etc
             */
            this.portNames = SerialPort.GetPortNames();

            /* Now initialize the declared comboBox control in the Form with
             * the array of COM port names detected above
             */
            foreach (string name in portNames)
            {
                comboBox1.Items.Add(name);
            }

            // sort the COM port names stored in the comboBox control
            comboBox1.Sorted = true;

            /* lastly, initialize the comboBox displayed text to the first
             * COM port contained in the control. If empty display an empty string.
             */
            length = portNames.Length;
            if (length > 0)
            {
                comboBox1.Text = portNames[length - 1];
            }
            else
            {
                comboBox1.Text = "";    // empty string
            }

        }   // end loadComPortComboBox()

        private void loadBitRateComboBox()
        {
            // local variable declarations
            int i;

            /* Initialize BitRateComboBox GUI control
             */
            for (i = 0; i < BIT_RATE_LENGTH; i++)
            {
                switch (i)
                {
                    case 0:
                        comboBox2.Items.Add(1200);
                        break;
                    case 1:
                        comboBox2.Items.Add(2400);
                        break;
                    case 2:
                        comboBox2.Items.Add(4800);
                        break;
                    case 3:
                        comboBox2.Items.Add(9600);
                        break;
                    case 4:
                        comboBox2.Items.Add(14400);
                        break;
                    case 5:
                        comboBox2.Items.Add(28800);
                        break;
                    case 6:
                        comboBox2.Items.Add(33300);
                        break;
                    case 7:
                        comboBox2.Items.Add(56000);
                        break;
                    default:
                        // can't get here
                        break; ;

                }   // end switch statement

            }   // end of for loop


            // initialize to default.
            comboBox2.Text = "9600";

        }

        private void loadDataBitComboBox()
        {
            // local variable declarations

            /* Initialize DataBitComboBox GUI control
             */
            comboBox3.Items.Add(7);
            comboBox3.Items.Add(8);

            // initialize the text field of the data bit combo box
            comboBox3.Text = "8";

        }

        private void loadStopBitsComboBox()
        {
            // local variable declarations

            /* Initialize StopBitsComboBox GUI control
             */
            comboBox4.Items.Add(1);
            comboBox4.Items.Add(1.5);
            comboBox4.Items.Add(2);

            // initialize the text field of the stop bits combo box
            comboBox4.Text = "1";

        }

        private void loadParityComboBox()
        {
            // local variable declarations

            /* Initialize ParityComboBox GUI control
             */
            comboBox5.Items.Add("NONE");
            comboBox5.Items.Add("ODD");
            comboBox5.Items.Add("EVEN");
            comboBox5.Items.Add("MARK");
            comboBox5.Items.Add("SPACE");

            // initialize the text field of the parity combo box
            comboBox5.Text = "NONE";

        }

        private void loadHandshakeComboBox()
        {
            // local variable declarations

            /* Initialize HandshakeComboBox GUI control
             */
            comboBox6.Items.Add("RTS");
            comboBox6.Items.Add("XonXoff");
            comboBox6.Items.Add("NONE");

            // initialize the text field of the handshake combo box
            comboBox6.Text = "NONE";

        }

        private void configureComPort()
        {
            // configure serial port to selected COM port
            _serialPort.PortName = comboBox1.Text;
        }
        private void configureBitRate()
        {
            // configure serial baud rate
            _serialPort.BaudRate = Int32.Parse(comboBox2.Text);
        }

        private void configureDataBits()
        {
            // configure serial port to 7 or 8 data bits
            _serialPort.DataBits = Int32.Parse(comboBox3.Text);
        }
        private void configureStopBits()
        {
            // configure serial port to 1, 1.5 or 2 stop bits
            if (comboBox4.Text.Equals("1"))
                _serialPort.StopBits = System.IO.Ports.StopBits.One;
            else if (comboBox4.Text.Equals("1.5")) // 1.5 doesn't configure
                _serialPort.StopBits = System.IO.Ports.StopBits.One;
            else if (comboBox4.Text.Equals("2"))
                _serialPort.StopBits = System.IO.Ports.StopBits.Two;
            else
                _serialPort.StopBits = System.IO.Ports.StopBits.One;
        }

        private void configureParity()
        {
            // configure parity to none, odd, even, mark or space
            if (comboBox5.Text.Equals("NONE"))
                _serialPort.Parity = System.IO.Ports.Parity.None;
            else if (comboBox5.Text.Equals("ODD"))
                _serialPort.Parity = System.IO.Ports.Parity.Odd;
            else if (comboBox5.Text.Equals("EVEN"))
                _serialPort.Parity = System.IO.Ports.Parity.Even;
            else if (comboBox5.Text.Equals("MARK"))
                _serialPort.Parity = System.IO.Ports.Parity.Mark;
            else if (comboBox5.Text.Equals("SPACE"))
                _serialPort.Parity = System.IO.Ports.Parity.Space;
            else
                _serialPort.Parity = System.IO.Ports.Parity.None;
        }

        private void configureHandshaking()
        {
            // configure handshaking to RTS, XonXoff or None
            if (comboBox5.Text.Equals("RTS"))
                _serialPort.Handshake = System.IO.Ports.Handshake.RequestToSend;
            else if (comboBox5.Text.Equals("XonXoff"))
                _serialPort.Handshake = System.IO.Ports.Handshake.XOnXOff;
            else if (comboBox5.Text.Equals("NONE"))
                _serialPort.Handshake = System.IO.Ports.Handshake.None;
            else
                _serialPort.Handshake = System.IO.Ports.Handshake.None;
        }

        private void configPortBttn_Click(object sender, EventArgs e)
        {
            //close the serialport1 COM port before configuring if open
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }

            configureComPort();
            configureBitRate();
            configureDataBits();
            configureStopBits();
            configureParity();
            configureHandshaking();

            // enable the serialport1 COM port
            try
            {
                _serialPort.Open();
            }
            catch (Exception ex)
            {
                //in case the port cannot be opened.
                MessageBox.Show(ex.ToString());
            }

            /*arduinoInterface aI = new arduinoInterface(_serialPort);
            aI.cForm = this;
            aI.ShowDialog();*/
        }
    }
}

