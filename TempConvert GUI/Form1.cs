using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace TempConvert_GUI
{
    public partial class Form1 : Form
    {
        private bool isFahrenheitToCelsius = true;
        private bool isUpdating = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxFahrenheit_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;
            PerformConversion("F");
        }

        private void textBoxCelsius_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            // Always perform conversion when Celsius field changes, regardless of mode
            PerformConversion("Celsius");
        }

        private void PerformConversion(string source)
        {
            isUpdating = true;
            try
            {
                // Check which field was changed and perform appropriate conversion
                string fahInput = textBoxFahrenheit.Text.Replace("°F", "").Trim();
                string celInput = textBoxCelsius.Text.Replace("°C", "").Trim();


                if (source == "F")
                {
                    // Convert F → C
                    if (double.TryParse(fahInput, out double fahrenheit))
                    {
                        double celsius = (fahrenheit - 32) * 5 / 9;
                        textBoxCelsius.Text = celsius.ToString("F2") + "°C";
                    }
                    else
                    {
                        textBoxCelsius.Clear();
                    }
                }
                else if (source == "C")
                {
                    // Convert C → F
                    if (double.TryParse(celInput, out double celsius))
                    {
                        double fahrenheit = (celsius * 9 / 5) + 32;
                        textBoxFahrenheit.Text = fahrenheit.ToString("F2") + "°F";
                    }
                    else
                    {
                        textBoxFahrenheit.Clear();
                    }
                }
            }
            finally
            {
                isUpdating = false;
            }
        }


        private void buttonToggle_Click(object sender, EventArgs e)
        {
            isFahrenheitToCelsius = !isFahrenheitToCelsius;

            // Swap labels and reset textboxes
            if (isFahrenheitToCelsius)
            {
                TempInFah.Text = "Enter Temperature in F:";
                labelCelsius.Text = "Temperature in °C:";
                buttonToggle.Text = "Switch to C → F";
            }
            else
            {
                TempInFah.Text = "Enter Temperature in C:";
                labelCelsius.Text = "Temperature in °F:";
                buttonToggle.Text = "Switch to F → C";
            }

            textBoxFahrenheit.Clear();
            textBoxCelsius.Clear();
            textBoxFahrenheit.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxFahrenheit.Focus();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxFahrenheit.Clear();
            textBoxCelsius.Clear();
            textBoxFahrenheit.Focus();
        }
    }
}
