namespace StopWatch
{
    partial class StopWatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.WatchLabel = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.pausebutton = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.formTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // WatchLabel
            // 
            this.WatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WatchLabel.Location = new System.Drawing.Point(12, 72);
            this.WatchLabel.Name = "WatchLabel";
            this.WatchLabel.Size = new System.Drawing.Size(776, 171);
            this.WatchLabel.TabIndex = 0;
            this.WatchLabel.Text = "00:00:00";
            this.WatchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.White;
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(21, 335);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(212, 84);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // pausebutton
            // 
            this.pausebutton.BackColor = System.Drawing.Color.White;
            this.pausebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pausebutton.Location = new System.Drawing.Point(291, 335);
            this.pausebutton.Name = "pausebutton";
            this.pausebutton.Size = new System.Drawing.Size(212, 84);
            this.pausebutton.TabIndex = 2;
            this.pausebutton.Text = "Pause";
            this.pausebutton.UseVisualStyleBackColor = false;
            this.pausebutton.Click += new System.EventHandler(this.pausebutton_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.BackColor = System.Drawing.Color.White;
            this.Resetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbutton.Location = new System.Drawing.Point(563, 335);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(212, 84);
            this.Resetbutton.TabIndex = 3;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = false;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // formTimer
            // 
            this.formTimer.Interval = 10;
            this.formTimer.Tick += new System.EventHandler(this.formtimer_Tick);
            // 
            // StopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.pausebutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.WatchLabel);
            this.Name = "StopWatch";
            this.Text = "StopWatch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WatchLabel;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button pausebutton;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.Timer formTimer;
    }
}

