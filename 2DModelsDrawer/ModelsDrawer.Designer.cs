namespace _2DModelsDrawer
{
    partial class ModelsDrawer
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton startButton;
        private System.Windows.Forms.ToolStripButton stopButton;
        private System.Windows.Forms.ToolStripButton addPointButton;
        private System.Windows.Forms.ToolStripButton moveButton;
        private System.Windows.Forms.ToolStripButton rotateButton;
        private System.Windows.Forms.ToolStripButton clearButton;
        private System.Windows.Forms.ToolStripButton disableRotationButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton loadButton;
        private System.Windows.Forms.ToolStripTextBox xTextBox;
        private System.Windows.Forms.ToolStripTextBox yTextBox;
        private System.Windows.Forms.ToolStripTextBox angleTextBox;
        private System.Windows.Forms.ToolStripLabel xLabel;
        private System.Windows.Forms.ToolStripLabel yLabel;
        private System.Windows.Forms.ToolStripLabel angleLabel;
        private System.Windows.Forms.ToolStripSeparator separator1;
        private System.Windows.Forms.ToolStripSeparator separator2;
        private System.Windows.Forms.ToolStripSeparator separator3;
        private System.Windows.Forms.ToolStripSeparator separator4;
        private System.Windows.Forms.PictureBox drawingPictureBox;
        private System.Windows.Forms.CheckBox directionCheckBox;

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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.startButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.xLabel = new System.Windows.Forms.ToolStripLabel();
            this.xTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.yLabel = new System.Windows.Forms.ToolStripLabel();
            this.yTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.addPointButton = new System.Windows.Forms.ToolStripButton();
            this.moveButton = new System.Windows.Forms.ToolStripButton();
            this.separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.angleLabel = new System.Windows.Forms.ToolStripLabel();
            this.angleTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.rotateButton = new System.Windows.Forms.ToolStripButton();
            this.separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.clearButton = new System.Windows.Forms.ToolStripButton();
            this.disableRotationButton = new System.Windows.Forms.ToolStripButton();
            this.separator4 = new System.Windows.Forms.ToolStripSeparator();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.loadButton = new System.Windows.Forms.ToolStripButton();
            this.directionCheckBox = new System.Windows.Forms.CheckBox();
            this.drawingPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawingPictureBox)).BeginInit();
            this.SuspendLayout();

            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startButton,
            this.stopButton,
            this.separator1,
            this.xLabel,
            this.xTextBox,
            this.yLabel,
            this.yTextBox,
            this.addPointButton,
            this.moveButton,
            this.separator2,
            this.angleLabel,
            this.angleTextBox,
            this.rotateButton,
            this.separator3,
            this.clearButton,
            this.disableRotationButton,
            this.separator4,
            this.saveButton,
            this.loadButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";

            // 
            // startButton
            // 
            this.startButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 22);
            this.startButton.Text = "Start Mouse Drawing";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);

            // 
            // stopButton
            // 
            this.stopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(120, 22);
            this.stopButton.Text = "Stop Mouse Drawing";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);

            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(6, 25);

            // 
            // xLabel
            // 
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(20, 22);
            this.xLabel.Text = "ΔX";

            // 
            // xTextBox
            // 
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(50, 25);

            // 
            // yLabel
            // 
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(20, 22);
            this.yLabel.Text = "ΔY";

            // 
            // yTextBox
            // 
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(50, 25);

            // 
            // addPointButton
            // 
            this.addPointButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addPointButton.Name = "addPointButton";
            this.addPointButton.Size = new System.Drawing.Size(63, 22);
            this.addPointButton.Text = "Add Point";
            this.addPointButton.Click += new System.EventHandler(this.addPointButton_Click);

            // 
            // moveButton
            // 
            this.moveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(44, 22);
            this.moveButton.Text = "Move";
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);

            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(6, 25);

            // 
            // angleLabel
            // 
            this.angleLabel.Name = "angleLabel";
            this.angleLabel.Size = new System.Drawing.Size(39, 22);
            this.angleLabel.Text = "Angle";

            // 
            // angleTextBox
            // 
            this.angleTextBox.Name = "angleTextBox";
            this.angleTextBox.Size = new System.Drawing.Size(50, 25);

            // 
            // rotateButton
            // 
            this.rotateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(47, 22);
            this.rotateButton.Text = "Rotate";
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);

            // 
            // separator3
            // 
            this.separator3.Name = "separator3";
            this.separator3.Size = new System.Drawing.Size(6, 25);

            // 
            // clearButton
            // 
            this.clearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(38, 22);
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);

            // 
            // disableRotationButton
            // 
            this.disableRotationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.disableRotationButton.Name = "disableRotationButton";
            this.disableRotationButton.Size = new System.Drawing.Size(98, 22);
            this.disableRotationButton.Text = "Disable Rotation";
            this.disableRotationButton.Click += new System.EventHandler(this.disableRotationButton_Click);

            // 
            // separator4
            // 
            this.separator4.Name = "separator4";
            this.separator4.Size = new System.Drawing.Size(6, 25);

            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(35, 22);
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);

            // 
            // loadButton
            // 
            this.loadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(37, 22);
            this.loadButton.Text = "Load";
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);

            // 
            // directionCheckBox
            // 
            this.directionCheckBox.Location = new System.Drawing.Point(12, 28);
            this.directionCheckBox.Name = "directionCheckBox";
            this.directionCheckBox.Size = new System.Drawing.Size(150, 23);
            this.directionCheckBox.TabIndex = 1;
            this.directionCheckBox.Text = "Clockwise rotating";
            this.directionCheckBox.UseVisualStyleBackColor = true;

            // 
            // drawingPictureBox
            // 
            this.drawingPictureBox.Location = new System.Drawing.Point(12, 54);
            this.drawingPictureBox.Name = "drawingPictureBox";
            this.drawingPictureBox.Size = new System.Drawing.Size(776, 384);
            this.drawingPictureBox.TabIndex = 2;
            this.drawingPictureBox.TabStop = false;
            this.drawingPictureBox.BackColor = System.Drawing.Color.White;
            this.drawingPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingPictureBox_MouseClick);
            this.drawingPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingPictureBox_MouseDown);
            this.drawingPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingPictureBox_MouseMove);
            this.drawingPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingPictureBox_MouseUp);
            this.drawingPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPictureBox_Paint);

            // 
            // ModelsDrawer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.directionCheckBox);
            this.Controls.Add(this.drawingPictureBox);
            this.Controls.Add(this.toolStrip);
            this.Name = "ModelsDrawer";
            this.Text = "ModelsDrawer";
            ((System.ComponentModel.ISupportInitialize)(this.drawingPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}