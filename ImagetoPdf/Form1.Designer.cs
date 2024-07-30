namespace ImagetoPdf
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ManuallyPanel = new System.Windows.Forms.Panel();
            this.opacityValue = new System.Windows.Forms.TextBox();
            this.OpacityValueLable = new System.Windows.Forms.Label();
            this.logoImage = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.AddLogoBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.ManuallyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.32584F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.67416F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(594, 359);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(236, 326);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(355, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.radioButton1);
            this.flowLayoutPanel2.Controls.Add(this.ManuallyPanel);
            this.flowLayoutPanel2.Controls.Add(this.radioButton2);
            this.flowLayoutPanel2.Controls.Add(this.radioButton3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(227, 317);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(137, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Select Images Manually";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ManuallyPanel
            // 
            this.ManuallyPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ManuallyPanel.Controls.Add(this.AddLogoBox);
            this.ManuallyPanel.Controls.Add(this.opacityValue);
            this.ManuallyPanel.Controls.Add(this.OpacityValueLable);
            this.ManuallyPanel.Controls.Add(this.logoImage);
            this.ManuallyPanel.Controls.Add(this.clearButton);
            this.ManuallyPanel.Controls.Add(this.showButton);
            this.ManuallyPanel.Location = new System.Drawing.Point(3, 26);
            this.ManuallyPanel.Name = "ManuallyPanel";
            this.ManuallyPanel.Size = new System.Drawing.Size(214, 142);
            this.ManuallyPanel.TabIndex = 3;
            this.ManuallyPanel.Visible = false;
            // 
            // opacityValue
            // 
            this.opacityValue.Location = new System.Drawing.Point(94, 87);
            this.opacityValue.Name = "opacityValue";
            this.opacityValue.Size = new System.Drawing.Size(100, 20);
            this.opacityValue.TabIndex = 5;
            this.opacityValue.Text = "30";
            this.opacityValue.Visible = false;
            this.opacityValue.TextChanged += new System.EventHandler(this.opacityValue_TextChanged);
            // 
            // OpacityValueLable
            // 
            this.OpacityValueLable.AutoSize = true;
            this.OpacityValueLable.Location = new System.Drawing.Point(6, 90);
            this.OpacityValueLable.Name = "OpacityValueLable";
            this.OpacityValueLable.Size = new System.Drawing.Size(82, 13);
            this.OpacityValueLable.TabIndex = 4;
            this.OpacityValueLable.Text = "Opacity of Logo";
            this.OpacityValueLable.Visible = false;
            // 
            // logoImage
            // 
            this.logoImage.AutoSize = true;
            this.logoImage.Location = new System.Drawing.Point(3, 55);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(134, 23);
            this.logoImage.TabIndex = 3;
            this.logoImage.Text = "Select Image for logo";
            this.logoImage.UseVisualStyleBackColor = true;
            this.logoImage.Visible = false;
            this.logoImage.Click += new System.EventHandler(this.logoImage_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Location = new System.Drawing.Point(6, 113);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Convert To PDF";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // showButton
            // 
            this.showButton.AutoSize = true;
            this.showButton.Location = new System.Drawing.Point(3, 3);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(182, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Select Images to convert it into Pdf";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 174);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Select Single Folder";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 197);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(126, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Select Multiple Folder";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Select a picture file";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AddLogoBox
            // 
            this.AddLogoBox.AutoSize = true;
            this.AddLogoBox.Location = new System.Drawing.Point(6, 32);
            this.AddLogoBox.Name = "AddLogoBox";
            this.AddLogoBox.Size = new System.Drawing.Size(72, 17);
            this.AddLogoBox.TabIndex = 1;
            this.AddLogoBox.Text = "Add Logo";
            this.AddLogoBox.UseVisualStyleBackColor = true;
            this.AddLogoBox.CheckedChanged += new System.EventHandler(this.AddLogoBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 359);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ManuallyPanel.ResumeLayout(false);
            this.ManuallyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel ManuallyPanel;
        private System.Windows.Forms.Label OpacityValueLable;
        private System.Windows.Forms.Button logoImage;
        private System.Windows.Forms.TextBox opacityValue;
        private System.Windows.Forms.CheckBox AddLogoBox;
    }
}

