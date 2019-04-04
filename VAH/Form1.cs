using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;

namespace VAH
{
    public partial class Form1 : Form
    {
        private List<float[]> points = new List<float[]>();
        private string comPortName = "COM1";
        private string comPortSpeed = "128000";
        private string xScaleValue = "кВ/дел.";
        private string yScaleValue = "A/дел.";
        private string backgroundColor = "Black";
        private string lineColor = "Red";

        public Form1()
        {
            InitializeComponent();

            AnT.InitializeContexts();
            // инициализация Glut 
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            Gl.glClearColor(0, 0, 0, 1); // отчитка окна 
            //Gl.glViewport(0, 0, AnT.Width, AnT.Height); // установка порта вывода в соответствии с размерами элемента anT 
            //Gl.glViewport(-10f, 10f, 20f, 20f);

            // настройка проекции 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            //Glu.gluOrtho2D(0.0, (float)AnT.Width, (float)AnT.Height, 0);
            Glu.gluOrtho2D(-5f, 5f, -0.0005f, 0.0005f);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();


       
        }

        void log(string s)
        {
            resistorValues.Items.Add(s);
            resistorValues.SelectedIndex = resistorValues.Items.Count - 1;
            resistorValues.SelectedIndex = -1;
        //    while (resistorValues.Items.Count > 20)
        //      resistorValues.Items.RemoveAt(0);
        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glVertex2d(x0, y0);
            Gl.glVertex2d(x1, y1);
            Gl.glEnd();
        }

        private void incomingData(string data)
        {
            //log(data); //вывод 4-х приходящих значений в лог
            List<string> ar = data.Split(':').ToList();
            if (ar.Count != 4)
                return;

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT); // очищаем буфер цвета 
            Gl.glLoadIdentity(); // очищаем текущую матрицу 

            Gl.glColor3f(1f, 1f, 1f);
            //drawLine(-1, 0, 1, 0);
            for (int i = -100; i < 100; i++)
            {
                float color = ((i % 10) == 0) ? 0.5f : 0.1f;
                if (0 == i)
                    color = 1f;
                Gl.glColor3f(color, color, color);
                drawLine((float)i / 10, -1, (float)i / 10, 1);
                drawLine(-10, (float)i / 100000, 10, (float)i / 100000);
            }

            //LOG(OCR2A);LOG(":");LOG(analogRead(0));LOG(":");LOG(analogRead(1));LOG(":");LOGLN(analogRead(2));

            float aref = 5, r1 = 10000;            
            float a0 = (float)Int16.Parse(ar[1]) * aref / 1024;
            float a1 = (float)Int16.Parse(ar[2]) * aref / 1024;
            float a2 = (float)Int16.Parse(ar[3]) * aref / 1024;
            float uD = a1 - a0;
            float iD = (a0 - a2) / r1;
            log("U = " + uD + "      " + " I = " + iD);

            float[] point = {uD, iD};
            points.Add(point);

            float[] prevArr = null;
            foreach (float[] curArr in points)
            {
                if (null != prevArr)
                {
                    Gl.glColor3f(1f, 0f, 0f);
                    Gl.glBegin(Gl.GL_LINE_STRIP);
                    Gl.glVertex2d(prevArr[0], prevArr[1]);
                    Gl.glVertex2d(curArr[0], curArr[1]);
                    Gl.glEnd();
                }                
                prevArr = curArr;
            }
            
            Gl.glFlush();
            AnT.Invalidate();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Action<string> idata = incomingData;
            while(serialPort1.BytesToRead > 0)
                BeginInvoke(idata, serialPort1.ReadLine());
        }

        private void comPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            this.comPortName = box.SelectedItem.ToString();

        }

        private void comPortSpeedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            this.comPortSpeed = box.SelectedItem.ToString();
        }

        private void xScaleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            this.xScaleValue = box.SelectedItem.ToString();
        }

        private void yScaleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            this.yScaleValue = box.SelectedItem.ToString();
        }

        private void lineColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            this.backgroundColor = box.SelectedItem.ToString();
        }

        private void buttonGroup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void actionButton_Click(object sender, EventArgs e)
     
        {
            serialPort1.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comPortComboBox.SelectedIndex = 5;
            comPortSpeedComboBox.SelectedIndex = 1;
            xScaleComboBox.SelectedIndex = 0;
            yScaleComboBox.SelectedIndex = 1;
            lineColorComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

     
    }
}
