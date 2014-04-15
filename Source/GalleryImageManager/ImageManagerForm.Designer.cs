namespace GalleryImage.Manager
{
    partial class ImageManagerForm
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
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._createSingleImageButton = new System.Windows.Forms.Button();
            this._singleImagePictureBox = new System.Windows.Forms.PictureBox();
            this._imagesListView = new System.Windows.Forms.ListView();
            this._splitSingleImageButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._saveGalleryImageLink = new System.Windows.Forms.LinkLabel();
            this._saveImagesLink = new System.Windows.Forms.LinkLabel();
            this._loadImagesLink = new System.Windows.Forms.LinkLabel();
            this._loadGalleryImageLink = new System.Windows.Forms.LinkLabel();
            this._nameComboBox = new System.Windows.Forms.ComboBox();
            this._createPropertiesCheckBox = new System.Windows.Forms.CheckBox();
            this._copyCodeLink = new System.Windows.Forms.LinkLabel();
            this._galleryClassCodeTextBox = new System.Windows.Forms.TextBox();
            this._pasteCodeLink = new System.Windows.Forms.LinkLabel();
            this._clearLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this._singleImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _toolTip
            // 
            this._toolTip.AutomaticDelay = 100;
            // 
            // _createSingleImageButton
            // 
            this._createSingleImageButton.Location = new System.Drawing.Point(12, 9);
            this._createSingleImageButton.Name = "_createSingleImageButton";
            this._createSingleImageButton.Size = new System.Drawing.Size(85, 44);
            this._createSingleImageButton.TabIndex = 3;
            this._createSingleImageButton.Text = "Create Galley Image";
            this._createSingleImageButton.UseVisualStyleBackColor = true;
            this._createSingleImageButton.Click += new System.EventHandler(this.OnCreateSingleImageClick);
            // 
            // _singleImagePictureBox
            // 
            this._singleImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._singleImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._singleImagePictureBox.Location = new System.Drawing.Point(322, 9);
            this._singleImagePictureBox.Name = "_singleImagePictureBox";
            this._singleImagePictureBox.Size = new System.Drawing.Size(389, 178);
            this._singleImagePictureBox.TabIndex = 7;
            this._singleImagePictureBox.TabStop = false;
            // 
            // _imagesListView
            // 
            this._imagesListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._imagesListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._imagesListView.Location = new System.Drawing.Point(12, 193);
            this._imagesListView.Name = "_imagesListView";
            this._imagesListView.Size = new System.Drawing.Size(304, 443);
            this._imagesListView.TabIndex = 9;
            this._imagesListView.UseCompatibleStateImageBehavior = false;
            this._imagesListView.View = System.Windows.Forms.View.List;
            this._imagesListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnImagesListKeyUp);
            // 
            // _splitSingleImageButton
            // 
            this._splitSingleImageButton.Location = new System.Drawing.Point(111, 9);
            this._splitSingleImageButton.Name = "_splitSingleImageButton";
            this._splitSingleImageButton.Size = new System.Drawing.Size(85, 44);
            this._splitSingleImageButton.TabIndex = 3;
            this._splitSingleImageButton.Text = "Split Galley Image";
            this._splitSingleImageButton.UseVisualStyleBackColor = true;
            this._splitSingleImageButton.Click += new System.EventHandler(this.OnSplitSingleImageClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Galley Class Name:";
            // 
            // _saveGalleryImageLink
            // 
            this._saveGalleryImageLink.AutoSize = true;
            this._saveGalleryImageLink.Location = new System.Drawing.Point(217, 50);
            this._saveGalleryImageLink.Name = "_saveGalleryImageLink";
            this._saveGalleryImageLink.Size = new System.Drawing.Size(99, 13);
            this._saveGalleryImageLink.TabIndex = 13;
            this._saveGalleryImageLink.TabStop = true;
            this._saveGalleryImageLink.Text = "Save Gallery Image";
            this._saveGalleryImageLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnSaveGalleryImageClick);
            // 
            // _saveImagesLink
            // 
            this._saveImagesLink.AutoSize = true;
            this._saveImagesLink.Location = new System.Drawing.Point(119, 174);
            this._saveImagesLink.Name = "_saveImagesLink";
            this._saveImagesLink.Size = new System.Drawing.Size(69, 13);
            this._saveImagesLink.TabIndex = 15;
            this._saveImagesLink.TabStop = true;
            this._saveImagesLink.Text = "Save Images";
            this._saveImagesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnSaveImagesLinkClicked);
            // 
            // _loadImagesLink
            // 
            this._loadImagesLink.AutoSize = true;
            this._loadImagesLink.Location = new System.Drawing.Point(12, 174);
            this._loadImagesLink.Name = "_loadImagesLink";
            this._loadImagesLink.Size = new System.Drawing.Size(68, 13);
            this._loadImagesLink.TabIndex = 15;
            this._loadImagesLink.TabStop = true;
            this._loadImagesLink.Text = "Load Images";
            this._loadImagesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLoadFilesClick);
            // 
            // _loadGalleryImageLink
            // 
            this._loadGalleryImageLink.AutoSize = true;
            this._loadGalleryImageLink.Location = new System.Drawing.Point(218, 9);
            this._loadGalleryImageLink.Name = "_loadGalleryImageLink";
            this._loadGalleryImageLink.Size = new System.Drawing.Size(98, 13);
            this._loadGalleryImageLink.TabIndex = 13;
            this._loadGalleryImageLink.TabStop = true;
            this._loadGalleryImageLink.Text = "Load Gallery Image";
            this._loadGalleryImageLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLoadGalleryImageClick);
            // 
            // _nameComboBox
            // 
            this._nameComboBox.FormattingEnabled = true;
            this._nameComboBox.Items.AddRange(new object[] {
            "Extensions",
            "Emoticons"});
            this._nameComboBox.Location = new System.Drawing.Point(15, 93);
            this._nameComboBox.Name = "_nameComboBox";
            this._nameComboBox.Size = new System.Drawing.Size(181, 21);
            this._nameComboBox.TabIndex = 16;
            this._nameComboBox.SelectedIndexChanged += new System.EventHandler(this.OnNameSelectedIndexChanged);
            // 
            // _createPropertiesCheckBox
            // 
            this._createPropertiesCheckBox.AutoSize = true;
            this._createPropertiesCheckBox.Checked = true;
            this._createPropertiesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._createPropertiesCheckBox.Location = new System.Drawing.Point(17, 122);
            this._createPropertiesCheckBox.Name = "_createPropertiesCheckBox";
            this._createPropertiesCheckBox.Size = new System.Drawing.Size(106, 17);
            this._createPropertiesCheckBox.TabIndex = 17;
            this._createPropertiesCheckBox.Text = "Create properties";
            this._createPropertiesCheckBox.UseVisualStyleBackColor = true;
            // 
            // _copyCodeLink
            // 
            this._copyCodeLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._copyCodeLink.AutoSize = true;
            this._copyCodeLink.BackColor = System.Drawing.Color.White;
            this._copyCodeLink.Location = new System.Drawing.Point(629, 200);
            this._copyCodeLink.Name = "_copyCodeLink";
            this._copyCodeLink.Size = new System.Drawing.Size(59, 13);
            this._copyCodeLink.TabIndex = 19;
            this._copyCodeLink.TabStop = true;
            this._copyCodeLink.Text = "Copy Code";
            this._copyCodeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnCopyCodeClicked);
            // 
            // _galleryClassCodeTextBox
            // 
            this._galleryClassCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._galleryClassCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._galleryClassCodeTextBox.Location = new System.Drawing.Point(322, 193);
            this._galleryClassCodeTextBox.Multiline = true;
            this._galleryClassCodeTextBox.Name = "_galleryClassCodeTextBox";
            this._galleryClassCodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._galleryClassCodeTextBox.Size = new System.Drawing.Size(389, 443);
            this._galleryClassCodeTextBox.TabIndex = 18;
            this._galleryClassCodeTextBox.TextChanged += new System.EventHandler(this.OnLocationsTextChanged);
            this._galleryClassCodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTextBoxKeyDown);
            // 
            // _pasteCodeLink
            // 
            this._pasteCodeLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._pasteCodeLink.AutoSize = true;
            this._pasteCodeLink.BackColor = System.Drawing.Color.White;
            this._pasteCodeLink.Location = new System.Drawing.Point(627, 222);
            this._pasteCodeLink.Name = "_pasteCodeLink";
            this._pasteCodeLink.Size = new System.Drawing.Size(62, 13);
            this._pasteCodeLink.TabIndex = 19;
            this._pasteCodeLink.TabStop = true;
            this._pasteCodeLink.Text = "Paste Code";
            this._pasteCodeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPasteCodeClicked);
            // 
            // _clearLabel
            // 
            this._clearLabel.AutoSize = true;
            this._clearLabel.Location = new System.Drawing.Point(285, 174);
            this._clearLabel.Name = "_clearLabel";
            this._clearLabel.Size = new System.Drawing.Size(31, 13);
            this._clearLabel.TabIndex = 15;
            this._clearLabel.TabStop = true;
            this._clearLabel.Text = "Clear";
            this._clearLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnClearLabelClicked);
            // 
            // ImageManagerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 642);
            this.Controls.Add(this._pasteCodeLink);
            this.Controls.Add(this._copyCodeLink);
            this.Controls.Add(this._galleryClassCodeTextBox);
            this.Controls.Add(this._createPropertiesCheckBox);
            this.Controls.Add(this._nameComboBox);
            this.Controls.Add(this._loadImagesLink);
            this.Controls.Add(this._clearLabel);
            this.Controls.Add(this._saveImagesLink);
            this.Controls.Add(this._loadGalleryImageLink);
            this.Controls.Add(this._saveGalleryImageLink);
            this.Controls.Add(this._imagesListView);
            this.Controls.Add(this._singleImagePictureBox);
            this.Controls.Add(this._splitSingleImageButton);
            this.Controls.Add(this._createSingleImageButton);
            this.Controls.Add(this.label3);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "ImageManagerForm";
            this.Text = "Galley Image Manager";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            ((System.ComponentModel.ISupportInitialize)(this._singleImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip _toolTip;
        private System.Windows.Forms.Button _createSingleImageButton;
        private System.Windows.Forms.PictureBox _singleImagePictureBox;
        private System.Windows.Forms.ListView _imagesListView;
        private System.Windows.Forms.Button _splitSingleImageButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel _saveGalleryImageLink;
        private System.Windows.Forms.LinkLabel _saveImagesLink;
        private System.Windows.Forms.LinkLabel _loadImagesLink;
        private System.Windows.Forms.LinkLabel _loadGalleryImageLink;
        private System.Windows.Forms.ComboBox _nameComboBox;
        private System.Windows.Forms.CheckBox _createPropertiesCheckBox;
        private System.Windows.Forms.LinkLabel _copyCodeLink;
        private System.Windows.Forms.TextBox _galleryClassCodeTextBox;
        private System.Windows.Forms.LinkLabel _pasteCodeLink;
        private System.Windows.Forms.LinkLabel _clearLabel;
    }
}