using System;
using System.Windows.Forms;
using System.Drawing;

namespace ControlsLib
{
    public partial class BarGraphH : UserControl
    {
        private const float NUM_LEDS = 6f;

        public BarGraphH()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            led1.Clickable = false;
            led2.Clickable = false;
            led3.Clickable = false;
            led4.Clickable = false;
            led5.Clickable = false;
            led6.Clickable = false;
        }

        /// <summary>
        /// Accepts value in range 0 -> 1.0
        /// </summary>
        public float Value
        {
            set
            {
                UpdateGraph(value);
            }
        }

        /// <summary>
        /// Sets the LEDs on/off according to value
        /// </summary>
        /// <param name="value">Keep in the range 0 -> 1.0</param>
        private void UpdateGraph(float value)
        {
            if (value > 1f)
                value = 1f;
            else if (value < 0)
                value = 0;
            //set the LEDs        
            led1.State = (value > 0);
            led2.State = (value > (float)(1/NUM_LEDS));
            led3.State = (value > (float)(2/NUM_LEDS));
            led4.State = (value > (float)(3/NUM_LEDS));
            led5.State = (value > (float)(4/NUM_LEDS));
            led6.State = (value > (float)(5/NUM_LEDS));
        }
    }
}
