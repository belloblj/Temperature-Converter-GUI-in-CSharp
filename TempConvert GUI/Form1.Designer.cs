using System.Windows.Forms;
using System.Windows.Forms;

namespace TempConvert_GUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.TempInFah = new System.Windows.Forms.Label();
            this.textBoxFahrenheit = new System.Windows.Forms.TextBox();
            this.labelCelsius = new System.Windows.Forms.Label();
            this.textBoxCelsius = new System.Windows.Forms.TextBox();
            this.buttonToggle = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelLiveUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TempInFah
            // 
            this.TempInFah.AutoSize = true;
            this.TempInFah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempInFah.Location = new System.Drawing.Point(50, 50);
            this.TempInFah.Name = "TempInFah";
            this.TempInFah.Size = new System.Drawing.Size(200, 20);
            this.TempInFah.TabIndex = 0;
            this.TempInFah.Text = "Enter Temperature in F:";
            // 
            // textBoxFahrenheit
            // 
            this.textBoxFahrenheit.Location = new System.Drawing.Point(260, 48);
            this.textBoxFahrenheit.Name = "textBoxFahrenheit";
            this.textBoxFahrenheit.Size = new System.Drawing.Size(150, 20);
            this.textBoxFahrenheit.TabIndex = 1;
            this.textBoxFahrenheit.TextChanged += new System.EventHandler(this.textBoxFahrenheit_TextChanged);
            // 
            // labelCelsius
            // 
            this.labelCelsius.AutoSize = true;
            this.labelCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCelsius.Location = new System.Drawing.Point(50, 120);
            this.labelCelsius.Name = "labelCelsius";
            this.labelCelsius.Size = new System.Drawing.Size(200, 20);
            this.labelCelsius.TabIndex = 3;
            this.labelCelsius.Text = "Temperature in °C:";
            // 
            // textBoxCelsius
            // 
            this.textBoxCelsius.Location = new System.Drawing.Point(260, 118);
            this.textBoxCelsius.Name = "textBoxCelsius";
            this.textBoxCelsius.Size = new System.Drawing.Size(150, 20);
            this.textBoxCelsius.TabIndex = 4;
            this.textBoxCelsius.TextChanged += new System.EventHandler(this.textBoxCelsius_TextChanged);
            // 
            // buttonToggle
            // 
            this.buttonToggle.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToggle.ForeColor = System.Drawing.Color.White;
            this.buttonToggle.Location = new System.Drawing.Point(150, 180);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Size = new System.Drawing.Size(200, 40);
            this.buttonToggle.TabIndex = 5;
            this.buttonToggle.Text = "Switch to C → F";
            this.buttonToggle.UseVisualStyleBackColor = false;
            this.buttonToggle.Click += new System.EventHandler(this.buttonToggle_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.IndianRed;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(150, 230);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(200, 40);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelLiveUpdate
            // 
            this.labelLiveUpdate.AutoSize = true;
            this.labelLiveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLiveUpdate.ForeColor = System.Drawing.Color.Gray;
            this.labelLiveUpdate.Location = new System.Drawing.Point(50, 150);
            this.labelLiveUpdate.Name = "labelLiveUpdate";
            this.labelLiveUpdate.Size = new System.Drawing.Size(220, 15);
            this.labelLiveUpdate.TabIndex = 7;
            this.labelLiveUpdate.Text = "(Updates automatically as you type)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 320);
            this.Controls.Add(this.labelLiveUpdate);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonToggle);
            this.Controls.Add(this.textBoxCelsius);
            this.Controls.Add(this.labelCelsius);
            this.Controls.Add(this.textBoxFahrenheit);
            this.Controls.Add(this.TempInFah);
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label TempInFah;
        private TextBox textBoxFahrenheit;
        private Label labelCelsius;
        private TextBox textBoxCelsius;
        private Button buttonToggle;
        private Button buttonReset;
        private Label labelLiveUpdate;
    }
}
