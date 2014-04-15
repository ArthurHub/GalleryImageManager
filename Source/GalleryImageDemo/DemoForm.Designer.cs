namespace GalleryImage.Demo
{
    partial class DemoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoForm));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Item 1", 1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Item 2", 2);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Item 3", 3);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Item 4", 0);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Item 5", 4);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Item 6", 5);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Item 7", 6);
            this._galleryImageControl = new GalleryImage.Common.GalleryImageControl();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._partsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._sizeModesComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._devilGalleryImageControl = new GalleryImage.Common.GalleryImageControl();
            this._loveGalleryImageControl = new GalleryImage.Common.GalleryImageControl();
            this._imageList = new System.Windows.Forms.ImageList(this.components);
            this._listView = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _galleryImageControl
            // 
            this._galleryImageControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._galleryImageControl.ImagePart = null;
            this._galleryImageControl.Location = new System.Drawing.Point(12, 91);
            this._galleryImageControl.Name = "_galleryImageControl";
            this._galleryImageControl.Size = new System.Drawing.Size(170, 73);
            this._galleryImageControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this._galleryImageControl.TabIndex = 0;
            this._galleryImageControl.Text = "galleryImageControl1";
            // 
            // _pictureBox
            // 
            this._pictureBox.Image = global::GalleryImage.Demo.Properties.Resources.Emoticons;
            this._pictureBox.Location = new System.Drawing.Point(12, 25);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(192, 38);
            this._pictureBox.TabIndex = 1;
            this._pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Emoticons galley image:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gallery image part:";
            // 
            // _partsComboBox
            // 
            this._partsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._partsComboBox.FormattingEnabled = true;
            this._partsComboBox.Location = new System.Drawing.Point(12, 192);
            this._partsComboBox.Name = "_partsComboBox";
            this._partsComboBox.Size = new System.Drawing.Size(170, 21);
            this._partsComboBox.TabIndex = 3;
            this._partsComboBox.SelectedIndexChanged += new System.EventHandler(this.OnPartsComboBoxSelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Part:";
            // 
            // _sizeModesComboBox
            // 
            this._sizeModesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._sizeModesComboBox.FormattingEnabled = true;
            this._sizeModesComboBox.Location = new System.Drawing.Point(12, 241);
            this._sizeModesComboBox.Name = "_sizeModesComboBox";
            this._sizeModesComboBox.Size = new System.Drawing.Size(170, 21);
            this._sizeModesComboBox.TabIndex = 5;
            this._sizeModesComboBox.SelectedIndexChanged += new System.EventHandler(this.OnSizeModesComboBoxSelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Size mode:";
            // 
            // _devilGalleryImageControl
            // 
            this._devilGalleryImageControl.ImagePart = null;
            this._devilGalleryImageControl.Location = new System.Drawing.Point(188, 195);
            this._devilGalleryImageControl.Name = "_devilGalleryImageControl";
            this._devilGalleryImageControl.Size = new System.Drawing.Size(16, 16);
            this._devilGalleryImageControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this._devilGalleryImageControl.TabIndex = 6;
            this._devilGalleryImageControl.Text = "galleryImageControl2";
            // 
            // _loveGalleryImageControl
            // 
            this._loveGalleryImageControl.ImagePart = null;
            this._loveGalleryImageControl.Location = new System.Drawing.Point(188, 243);
            this._loveGalleryImageControl.Name = "_loveGalleryImageControl";
            this._loveGalleryImageControl.Size = new System.Drawing.Size(16, 16);
            this._loveGalleryImageControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this._loveGalleryImageControl.TabIndex = 6;
            this._loveGalleryImageControl.Text = "galleryImageControl2";
            // 
            // _imageList
            // 
            this._imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imageList.ImageStream")));
            this._imageList.TransparentColor = System.Drawing.Color.Transparent;
            this._imageList.Images.SetKeyName(0, "avi$$mpg$$mkv$$flv$$mp4$$mpeg$$divx.png");
            this._imageList.Images.SetKeyName(1, "bmp$$gif$$jpg$$png$$jpeg$$tiff.png");
            this._imageList.Images.SetKeyName(2, "chm.png");
            this._imageList.Images.SetKeyName(3, "default.png");
            this._imageList.Images.SetKeyName(4, "dll.png");
            this._imageList.Images.SetKeyName(5, "doc$$docx$$docm.png");
            this._imageList.Images.SetKeyName(6, "exe.png");
            this._imageList.Images.SetKeyName(7, "htm$$html.png");
            this._imageList.Images.SetKeyName(8, "mp3$$ogg$$wma.png");
            this._imageList.Images.SetKeyName(9, "pdf.png");
            this._imageList.Images.SetKeyName(10, "ppt$$pptx$$pptm.png");
            this._imageList.Images.SetKeyName(11, "pst$$ost.png");
            this._imageList.Images.SetKeyName(12, "txt$$log$$text.png");
            this._imageList.Images.SetKeyName(13, "xls$$xlsx$$xlsm.png");
            this._imageList.Images.SetKeyName(14, "xml$$xsd.png");
            this._imageList.Images.SetKeyName(15, "zip$$rar$$ace$$7zip.png");
            // 
            // _listView
            // 
            this._listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
            this._listView.Location = new System.Drawing.Point(282, 25);
            this._listView.Name = "_listView";
            this._listView.Size = new System.Drawing.Size(178, 74);
            this._listView.SmallImageList = this._imageList;
            this._listView.TabIndex = 8;
            this._listView.UseCompatibleStateImageBehavior = false;
            this._listView.View = System.Windows.Forms.View.List;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Image list use in List View:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.ImageIndex = 11;
            this.label6.ImageList = this._imageList;
            this.label6.Location = new System.Drawing.Point(282, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "       Using Image list on label";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 9;
            this.button1.ImageList = this._imageList;
            this.button1.Location = new System.Drawing.Point(282, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Button";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.ImageIndex = 13;
            this.checkBox1.ImageList = this._imageList;
            this.checkBox1.Location = new System.Drawing.Point(287, 134);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Check box      ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 333);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._listView);
            this.Controls.Add(this._loveGalleryImageControl);
            this.Controls.Add(this._devilGalleryImageControl);
            this.Controls.Add(this._sizeModesComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._partsComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._pictureBox);
            this.Controls.Add(this._galleryImageControl);
            this.Name = "DemoForm";
            this.Text = "Gallery Image Demo";
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.GalleryImageControl _galleryImageControl;
        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _partsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _sizeModesComboBox;
        private System.Windows.Forms.Label label4;
        private Common.GalleryImageControl _devilGalleryImageControl;
        private Common.GalleryImageControl _loveGalleryImageControl;
        private System.Windows.Forms.ImageList _imageList;
        private System.Windows.Forms.ListView _listView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}