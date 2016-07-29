using System;
using System.Windows.Forms;

namespace ControlsLib
{
    public partial class BarGraphH : UserControl
    {
        private float _value;
        private const UInt16 NUM_LEDS = 6;

        public BarGraphH()
        {
            InitializeComponent();
        }

        public float Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
            }
        }

        private void UpdateGraph(float value)
        {
            //keep in the range 0 -> 1.0
            if (value > 1f)
                value = 1f;
            else if (value < 0)
                value = 0;
            //set the LEDs


        }
    }
}
