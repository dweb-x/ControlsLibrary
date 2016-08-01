using System;
using System.Windows.Forms;

namespace ControlsLib
{
    public partial class LED : UserControl
    {
        private bool state, clickable;
        private LedColor _ledColor;
        private ImageList _imgList;
        private int onImgIndex, offImgIndex; //index's of image pair

        public LED()
        {
            InitializeComponent();
            //defaults
            _ledColor = LedColor.RED;
            clickable = false;
            LoadImages();
            UpdateImageSet();
        }

        public event EventHandler<EventArgs> OnLedClick = delegate { };

        /// <summary>
        /// Change the LED state on/off
        /// </summary>
        public bool State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
                UpdateState();
            }
        }

        /// <summary>
        /// When true LED can toggle state when clicked.
        /// </summary>
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

        /// <summary>
        /// Get or set the LED color.
        /// </summary>
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
            }
        }

        /// <summary>
        /// When clickable is enabled the LED is toggled on click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (clickable)
            {
                Toggle();
                OnLedClick(this, EventArgs.Empty);
            }
                
        }

        /// <summary>
        /// Toggles the LED state.
        /// </summary>
        private void Toggle()
        {  
            state = !state;
            UpdateState();
        }

        /// <summary>
        /// Call after changing state to switch LED image.
        /// </summary>
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

        /// <summary>
        /// Call to update the LED image pair to the correct 
        /// color after changing _ledColor.
        /// </summary>
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
      
            UpdateState();
        }

       /// <summary>
       /// Loads images from resource file.
       /// </summary>
        private void LoadImages()
        {
            _imgList = new ImageList();
            try
            {
                _imgList.Images.Add(Properties.Resources.LED_AmberOff);
                _imgList.Images.Add(Properties.Resources.LED_AmberOn);
                _imgList.Images.Add(Properties.Resources.LED_BlueOff);
                _imgList.Images.Add(Properties.Resources.LED_BlueOn);
                _imgList.Images.Add(Properties.Resources.LED_ClearOff);
                _imgList.Images.Add(Properties.Resources.LED_ClearOn);
                _imgList.Images.Add(Properties.Resources.LED_GreenOff);
                _imgList.Images.Add(Properties.Resources.LED_GreenOn);
                _imgList.Images.Add(Properties.Resources.LED_RedOff);
                _imgList.Images.Add(Properties.Resources.LED_RedOn);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
    /// <summary>
    /// All available LED colors
    /// </summary>
    public enum LedColor
    {
        RED, GREEN, BLUE, AMBER, CLEAR
    }
}
