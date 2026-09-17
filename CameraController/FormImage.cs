using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGMTcs;

namespace CameraController
{
    public partial class FormImage : Form
    {
        static FormImage m_instance;
        

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public FormImage()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormImage_Load(object sender, EventArgs e)
        {
            txt_imagePath.Text = TGMTregistry.GetInstance().ReadString("txt_imagePath");

            
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public static FormImage GetInstance()
        {
            if (m_instance == null)
                m_instance = new FormImage();
            return m_instance;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
		public void OnFormSelected(bool selected)
        {
            if (selected)
            {

            }
            else
            {
                
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void Predict()
        {
            //if (Program.detector == null)
            //    return;
            //if (!File.Exists(txt_imagePath.Text))
            //    return;

            //listView1.Items.Clear();
            //circle1.Visible = true;
            //workerPredict.RunWorkerAsync();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void txt_imagePath_TextChanged(object sender, EventArgs e)
        {
            if (!File.Exists(txt_imagePath.Text))
                return;

            pictureBox1.Image = TGMTimage.LoadBitmapWithoutLock(txt_imagePath.Text);
            TGMTregistry.GetInstance().SaveValue("txt_imagePath", txt_imagePath.Text);
            Predict();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_predict_Click(object sender, EventArgs e)
        {
            Predict();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void workerPredict_DoWork(object sender, DoWorkEventArgs e)
        {
            //Predicted result = Program.detector.Detect(txt_imagePath.Text);
            //e.Result = result;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void workerPredict_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            //Predicted predicted = (Predicted)e.Result;

            //if (predicted.boxes.Count == 0 && predicted.error != "")
            //{
            //    if(predicted.error != null)
            //    {

            //        if(predicted.error.Contains("-201"))
            //        {
            //            FormMain.GetInstance().PrintError("Wrong size of model");
            //        }
            //        else
            //        {
            //            MessageBox.Show(predicted.error);
            //        }
            //    }
                
            //    circle1.Visible = false;
            //    return;
            //}

            //for(int i=0; i<predicted.boxes.Count; i++)
            //{
            //    Box box = predicted.boxes[i];

            //    if(Program.selectClass && !Program.classSelecteds.Contains(box.classID))
            //        continue;

            //    ListViewItem item = new ListViewItem((i + 1).ToString());
            //    item.SubItems.Add(box.classID.ToString());
            //    item.SubItems.Add(box.className);
            //    item.SubItems.Add($"{box.rect.Width}x{box.rect.Height}");
            //    item.SubItems.Add(box.score.ToString());

            //    listView1.Items.Add(item);
            //}
            //FormMain.GetInstance().PrintMessage( "Num objects: " + predicted.boxes.Count.ToString() + " (" + predicted.elapsedMilisecond.ToString() + "ms)");

            //if(predicted.bitmap != null)
            //{
            //    Util.DrawObject(predicted.bitmap, predicted.boxes);
            //    pictureBox1.Image = predicted.bitmap;
            //}

            //circle1.Visible = false;
        }

        
    }
}
