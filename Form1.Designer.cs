
namespace Sierpinski_triangle
{
    partial class form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.image = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.playStopButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.drawnTextLabel = new System.Windows.Forms.Label();
            this.loopCheck = new System.Windows.Forms.CheckBox();
            this.stopAtLabel = new System.Windows.Forms.Label();
            this.stopAtInput = new System.Windows.Forms.NumericUpDown();
            this.timerIntervalInput = new System.Windows.Forms.NumericUpDown();
            this.timerIntervalLabel = new System.Windows.Forms.Label();
            this.triangleColotLabel = new System.Windows.Forms.Label();
            this.triangleColor = new System.Windows.Forms.ColorDialog();
            this.backgroundColor = new System.Windows.Forms.ColorDialog();
            this.triangleColorButton = new System.Windows.Forms.Label();
            this.backgroundColorButton = new System.Windows.Forms.Label();
            this.backgroundColorLabel = new System.Windows.Forms.Label();
            this.drawnLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopAtInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerIntervalInput)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.White;
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Location = new System.Drawing.Point(460, 52);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(500, 500);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(460, 571);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(118, 69);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // playStopButton
            // 
            this.playStopButton.Location = new System.Drawing.Point(659, 571);
            this.playStopButton.Name = "playStopButton";
            this.playStopButton.Size = new System.Drawing.Size(118, 69);
            this.playStopButton.TabIndex = 2;
            this.playStopButton.Text = "STOP";
            this.playStopButton.UseVisualStyleBackColor = true;
            this.playStopButton.Visible = false;
            this.playStopButton.Click += new System.EventHandler(this.playStopButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(842, 571);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(118, 69);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Visible = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // drawnTextLabel
            // 
            this.drawnTextLabel.Location = new System.Drawing.Point(460, 9);
            this.drawnTextLabel.Name = "drawnTextLabel";
            this.drawnTextLabel.Size = new System.Drawing.Size(204, 40);
            this.drawnTextLabel.TabIndex = 4;
            this.drawnTextLabel.Text = "Triangles drawn: ";
            this.drawnTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loopCheck
            // 
            this.loopCheck.AutoSize = true;
            this.loopCheck.Location = new System.Drawing.Point(37, 127);
            this.loopCheck.Name = "loopCheck";
            this.loopCheck.Size = new System.Drawing.Size(95, 37);
            this.loopCheck.TabIndex = 5;
            this.loopCheck.Text = "Loop";
            this.loopCheck.UseVisualStyleBackColor = true;
            // 
            // stopAtLabel
            // 
            this.stopAtLabel.Location = new System.Drawing.Point(37, 180);
            this.stopAtLabel.Name = "stopAtLabel";
            this.stopAtLabel.Size = new System.Drawing.Size(256, 57);
            this.stopAtLabel.TabIndex = 6;
            this.stopAtLabel.Text = "Stop drawing at (px): ";
            this.stopAtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stopAtInput
            // 
            this.stopAtInput.Location = new System.Drawing.Point(299, 191);
            this.stopAtInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stopAtInput.Name = "stopAtInput";
            this.stopAtInput.Size = new System.Drawing.Size(111, 39);
            this.stopAtInput.TabIndex = 7;
            this.stopAtInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stopAtInput.ValueChanged += new System.EventHandler(this.stopAtInput_ValueChanged);
            // 
            // timerIntervalInput
            // 
            this.timerIntervalInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.timerIntervalInput.Location = new System.Drawing.Point(299, 264);
            this.timerIntervalInput.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.timerIntervalInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timerIntervalInput.Name = "timerIntervalInput";
            this.timerIntervalInput.Size = new System.Drawing.Size(111, 39);
            this.timerIntervalInput.TabIndex = 9;
            this.timerIntervalInput.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.timerIntervalInput.ValueChanged += new System.EventHandler(this.timerIntervalInput_ValueChanged);
            // 
            // timerIntervalLabel
            // 
            this.timerIntervalLabel.Location = new System.Drawing.Point(37, 258);
            this.timerIntervalLabel.Name = "timerIntervalLabel";
            this.timerIntervalLabel.Size = new System.Drawing.Size(256, 45);
            this.timerIntervalLabel.TabIndex = 8;
            this.timerIntervalLabel.Text = "Draw new every (ms): ";
            this.timerIntervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // triangleColotLabel
            // 
            this.triangleColotLabel.AutoSize = true;
            this.triangleColotLabel.Location = new System.Drawing.Point(37, 340);
            this.triangleColotLabel.Name = "triangleColotLabel";
            this.triangleColotLabel.Size = new System.Drawing.Size(178, 33);
            this.triangleColotLabel.TabIndex = 10;
            this.triangleColotLabel.Text = "Triangle color:";
            // 
            // triangleColor
            // 
            this.triangleColor.Color = System.Drawing.Color.Red;
            // 
            // backgroundColor
            // 
            this.backgroundColor.Color = System.Drawing.Color.White;
            // 
            // triangleColorButton
            // 
            this.triangleColorButton.BackColor = System.Drawing.Color.Red;
            this.triangleColorButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.triangleColorButton.Location = new System.Drawing.Point(299, 337);
            this.triangleColorButton.Name = "triangleColorButton";
            this.triangleColorButton.Size = new System.Drawing.Size(111, 36);
            this.triangleColorButton.TabIndex = 11;
            this.triangleColorButton.Click += new System.EventHandler(this.triangleColorButton_Click);
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.BackColor = System.Drawing.Color.White;
            this.backgroundColorButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundColorButton.Location = new System.Drawing.Point(299, 402);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(111, 36);
            this.backgroundColorButton.TabIndex = 13;
            this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // backgroundColorLabel
            // 
            this.backgroundColorLabel.AutoSize = true;
            this.backgroundColorLabel.Location = new System.Drawing.Point(37, 405);
            this.backgroundColorLabel.Name = "backgroundColorLabel";
            this.backgroundColorLabel.Size = new System.Drawing.Size(222, 33);
            this.backgroundColorLabel.TabIndex = 12;
            this.backgroundColorLabel.Text = "Background color:";
            // 
            // drawnLabel
            // 
            this.drawnLabel.Location = new System.Drawing.Point(659, 9);
            this.drawnLabel.Name = "drawnLabel";
            this.drawnLabel.Size = new System.Drawing.Size(193, 40);
            this.drawnLabel.TabIndex = 14;
            this.drawnLabel.Text = "0";
            this.drawnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 653);
            this.Controls.Add(this.drawnLabel);
            this.Controls.Add(this.backgroundColorButton);
            this.Controls.Add(this.backgroundColorLabel);
            this.Controls.Add(this.triangleColorButton);
            this.Controls.Add(this.triangleColotLabel);
            this.Controls.Add(this.timerIntervalInput);
            this.Controls.Add(this.timerIntervalLabel);
            this.Controls.Add(this.stopAtInput);
            this.Controls.Add(this.stopAtLabel);
            this.Controls.Add(this.loopCheck);
            this.Controls.Add(this.drawnTextLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.playStopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.image);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copy/Paste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopAtInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerIntervalInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button playStopButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label drawnTextLabel;
        private System.Windows.Forms.CheckBox loopCheck;
        private System.Windows.Forms.Label stopAtLabel;
        private System.Windows.Forms.NumericUpDown stopAtInput;
        private System.Windows.Forms.NumericUpDown timerIntervalInput;
        private System.Windows.Forms.Label timerIntervalLabel;
        private System.Windows.Forms.Label triangleColotLabel;
        private System.Windows.Forms.ColorDialog triangleColor;
        private System.Windows.Forms.ColorDialog backgroundColor;
        private System.Windows.Forms.Label triangleColorButton;
        private System.Windows.Forms.Label backgroundColorButton;
        private System.Windows.Forms.Label backgroundColorLabel;
        private System.Windows.Forms.Label drawnLabel;
        private System.Windows.Forms.Timer timer;
    }
}

