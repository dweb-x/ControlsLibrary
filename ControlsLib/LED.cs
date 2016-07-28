using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsLib
{
    public partial class LED : UserControl
    {
        private bool state;
        private bool clickable;
        private LedColor _ledColor;
        private ImageList _imgList;
        private int onImgIndex, offImgIndex; //index of images

        public LED()
        {
            InitializeComponent();
            //defaults
            clickable = true;
            _ledColor = LedColor.BLUE;
            LoadImages();
            UpdateImageSet();
            UpdateState();
        }

        public bool State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
                UpdateImageSet();
                UpdateState();
            }
        }

        public bool Clickable
        {
            get
            {
                return clickable;
            }

            set
            {
                clickable = value;
            }
        }

        public LedColor LedColor
        {
            get
            {
                return _ledColor;
            }

            set
            {
                _ledColor = value;
                UpdateImageSet();
                UpdateState();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (clickable)
                Toggle();
        }

        private void Toggle()
        {  
            state = !state;
            UpdateState();
        }

        private void UpdateState()
        {
            if (state)
            {
                pictureBox1.Image = _imgList.Images[onImgIndex];
            }
            else
            {
                pictureBox1.Image = _imgList.Images[offImgIndex];
            }
        }

        private void UpdateImageSet()
        {
            switch (_ledColor)
            {
                case LedColor.AMBER:
                    onImgIndex = 1;
                    offImgIndex = 0;
                    break;
                case LedColor.BLUE:
                    onImgIndex = 3;
                    offImgIndex = 2;
                    break;
                case LedColor.CLEAR:
                    onImgIndex = 5;
                    offImgIndex = 4;
                    break;
                case LedColor.GREEN:
                    onImgIndex = 7;
                    offImgIndex = 6;
                    break;
                case LedColor.RED:
                    onImgIndex = 9;
                    offImgIndex = 8;
                    break;
            }
        }

        //fix this ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ todo
        private void LoadImages()
        {
            _imgList = new ImageList();
            try
            {
                _imgList.Images.Add(Image.FromFile(@"c:\users\dave\documents\visual studio 2015\Projects\ControlsLib\ControlsLib\Resources\LED_AmberOff.png"));
                _imgList.Images.Add(Image.FromFile(@"c:\users\dave\documents\visual studio 2015\Projects\ControlsLib\ControlsLib\Resources\LED_AmberOn.png"));
                _imgList.Images.Add(Image.FromFile(@"c:\users\dave\documents\visual studio 2015\Projects\ControlsLib\ControlsLib\Resources\LED_BlueOff.png"));
                _imgList.Images.Add(Image.FromFile(@"c:\users\dave\documents\visual studio 2015\Projects\ControlsLib\ControlsLib\Resources\LED_BlueOn.png"));
                _imgList.Images.Add(Image.FromFile(@"c:\users\dave\documents\visual studio 2015\Projects\ControlsLib\ControlsLib\Resources\LED_ClearOff.png"));
                _imgList.Images.Add(Image.FromFile(@"c:\users\dave\documents\visual studio 2015\Projects\ControlsLib\ControlsLib\Resources\LED_ClearOn.png"));
                _imgList.Images.Add(Image.FromFile(@"c:\users\dave\documents\visual studio 2015\Projects\ControlsLib\ControlsLib\Resources\LED_GreenOff.png"));
                _imgList.Images.Add(Image.FromFile(@"c:\users\dave\documents\visual studio 2015\Projects\ControlsLib\ControlsLib\Resources\LED_GreenOn.png"));
                _imgList.Images.Add(Image.FromFile(@"c:\users\dave\documents\visual studio 2015\Projects\ControlsLib\ControlsLib\Resources\LED_RedOff.png"));
                _imgList.Images.Add(Image.FromFile(@"c:\users\dave\documents\visual studio 2015\Projects\ControlsLib\ControlsLib\Resources\LED_RedOn.png"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }

    public enum LedColor
    {
        RED, GREEN, BLUE, AMBER, CLEAR
    }
}
