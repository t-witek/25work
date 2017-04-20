namespace _25work
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.workTimePicker = new System.Windows.Forms.DateTimePicker();
            this.breakTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numOfCycles = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // workTimePicker
            // 
            resources.ApplyResources(this.workTimePicker, "workTimePicker");
            this.workTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.workTimePicker.Name = "workTimePicker";
            this.workTimePicker.ShowUpDown = true;
            this.workTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 25, 0, 0);
            // 
            // breakTimePicker
            // 
            resources.ApplyResources(this.breakTimePicker, "breakTimePicker");
            this.breakTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.breakTimePicker.Name = "breakTimePicker";
            this.breakTimePicker.ShowUpDown = true;
            this.breakTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 5, 0, 0);
            // 
            // numOfCycles
            // 
            resources.ApplyResources(this.numOfCycles, "numOfCycles");
            this.numOfCycles.Name = "numOfCycles";
            // 
            // resetButton
            // 
            resources.ApplyResources(this.resetButton, "resetButton");
            this.resetButton.Name = "resetButton";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // timeLabel
            // 
            resources.ApplyResources(this.timeLabel, "timeLabel");
            this.timeLabel.Name = "timeLabel";
            // 
            // infoLabel
            // 
            resources.ApplyResources(this.infoLabel, "infoLabel");
            this.infoLabel.Name = "infoLabel";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.numOfCycles);
            this.Controls.Add(this.breakTimePicker);
            this.Controls.Add(this.workTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker workTimePicker;
        private System.Windows.Forms.DateTimePicker breakTimePicker;
        private System.Windows.Forms.Label numOfCycles;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Timer timer1;
    }
}

