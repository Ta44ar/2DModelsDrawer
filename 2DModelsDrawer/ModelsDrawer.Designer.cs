namespace _2DModelsDrawer
{
    partial class ModelsDrawer
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Button addPointButton;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.PictureBox drawingPictureBox;
        private System.Windows.Forms.Panel controlPanel;

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
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.addPointButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.drawingPictureBox = new System.Windows.Forms.PictureBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.drawingPictureBox)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();

            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(10, 10);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);

            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(90, 10);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);

            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(10, 40);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(75, 23);
            this.xTextBox.TabIndex = 2;
            this.xTextBox.PlaceholderText = "ΔX";

            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(90, 40);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(75, 23);
            this.yTextBox.TabIndex = 3;
            this.yTextBox.PlaceholderText = "ΔY";

            // 
            // addPointButton
            // 
            this.addPointButton.Location = new System.Drawing.Point(170, 40);
            this.addPointButton.Name = "addPointButton";
            this.addPointButton.Size = new System.Drawing.Size(75, 23);
            this.addPointButton.TabIndex = 4;
            this.addPointButton.Text = "Add Point";
            this.addPointButton.UseVisualStyleBackColor = true;
            this.addPointButton.Click += new System.EventHandler(this.addPointButton_Click);

            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(170, 10);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(75, 23);
            this.moveButton.TabIndex = 5;
            this.moveButton.Text = "Move";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);

            // 
            // drawingPictureBox
            // 
            this.drawingPictureBox.Location = new System.Drawing.Point(12, 100);
            this.drawingPictureBox.Name = "drawingPictureBox";
            this.drawingPictureBox.Size = new System.Drawing.Size(776, 338);
            this.drawingPictureBox.TabIndex = 6;
            this.drawingPictureBox.TabStop = false;
            this.drawingPictureBox.BackColor = System.Drawing.Color.White;
            this.drawingPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingPictureBox_MouseClick);
            this.drawingPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingPictureBox_MouseDown);
            this.drawingPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingPictureBox_MouseMove);
            this.drawingPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingPictureBox_MouseUp);
            this.drawingPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPictureBox_Paint);

            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.startButton);
            this.controlPanel.Controls.Add(this.stopButton);
            this.controlPanel.Controls.Add(this.xTextBox);
            this.controlPanel.Controls.Add(this.yTextBox);
            this.controlPanel.Controls.Add(this.addPointButton);
            this.controlPanel.Controls.Add(this.moveButton);
            this.controlPanel.Location = new System.Drawing.Point(12, 12);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(260, 80);
            this.controlPanel.TabIndex = 7;

            // 
            // ModelsDrawer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.drawingPictureBox);
            this.Name = "ModelsDrawer";
            this.Text = "ModelsDrawer";
            ((System.ComponentModel.ISupportInitialize)(this.drawingPictureBox)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}