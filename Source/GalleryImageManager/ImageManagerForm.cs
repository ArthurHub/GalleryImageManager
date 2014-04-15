// "Therefore those skilled at the unorthodox
// are infinite as heaven and earth,
// inexhaustible as the great rivers.
// When they come to an end,
// they bagin again,
// like the days and months;
// they die and are reborn,
// like the four seasons."
// 
// - Sun Tsu,
// "The Art of War"

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GalleryImage.Manager.Properties;

namespace GalleryImage.Manager
{
    public partial class ImageManagerForm : Form
    {
        /// <summary>
        /// The images loaded to create single image
        /// </summary>
        private readonly List<Image> _images = new List<Image>();

        /// <summary>
        /// used to mark error UI components
        /// </summary>
        private readonly Color _errorColor = Color.FromArgb(0xFF, 0xBF, 0xB4);

        /// <summary>
        /// Ctor.
        /// </summary>
        public ImageManagerForm()
        {
            InitializeComponent();
            _imagesListView.SmallImageList = new ImageList();
            _imagesListView.SmallImageList.ImageSize = new Size(24, 24);

            Icon = Resources.Icons;

            UpdateControlsState();
        }

        /// <summary>
        /// Load files to create single image from.
        /// </summary>
        private void OnLoadFilesClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var imagePaths = GetImages();
            LoadImageFiles(imagePaths);
            ClearColors();
        }

        /// <summary>
        /// Load images
        /// </summary>
        /// <param name="imagePaths"></param>
        private void LoadImageFiles(string[] imagePaths)
        {
            if (imagePaths != null && imagePaths.Length > 0)
            {
                ClearEverything();

                foreach (var imagePath in imagePaths)
                {
                    var image = LoadImageFromFile(imagePath);
                    image.Tag = Path.GetFileNameWithoutExtension(imagePath);
                    _images.Add(image);
                }

                ShowImagesInListView(_images);
            }

            UpdateControlsState();
        }

        /// <summary>
        /// Create single image from all the images loaded.
        /// </summary>
        private void OnCreateSingleImageClick(object sender, EventArgs e)
        {
            ClearColors();

            var name = _nameComboBox.Text.Trim();
            if( _images.Count > 0 && name != string.Empty )
            {
                if(!ValidateGroups(_images))
                    return;

                Image galleryImage;
                Dictionary<string, Rectangle> positions;
                CreateSingleImage(_images, out galleryImage, out positions);

                string positionsStr;
                string defaultPosition;
                CreatePositionsCodeString(positions, out positionsStr, out defaultPosition);

                _singleImagePictureBox.Image = galleryImage;
                
                name = char.ToUpper(name[0]) + name.Substring(1);

                string properties = Environment.NewLine;
                if( _createPropertiesCheckBox.Checked )
                {
                    foreach(var image in _images)
                    {
                        foreach(var imgName in ( (string)image.Tag ).Split(new[] {"$$"}, StringSplitOptions.RemoveEmptyEntries))
                        {
                            properties += string.Format(Resources.PropertyCodeSnippet, imgName, GetPropertyValidName(imgName)) + Environment.NewLine + Environment.NewLine;
                        }
                    }
                }
                properties += Environment.NewLine;

                _galleryClassCodeTextBox.Text = string.Format(Resources.ClassTemplate, name, properties.Trim(), positionsStr.Trim(), defaultPosition);

                Clipboard.SetText(_galleryClassCodeTextBox.Text);
            }
            else
            {
                if( _images.Count < 1 )
                {
                    _imagesListView.BackColor = _errorColor;
                    MessageBox.Show(this, "No images are given to create galley image from.\r\nPlease use 'Load Images' link.", "Invalid Arguments", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _nameComboBox.BackColor = _errorColor;
                    MessageBox.Show(this, "No galley class name given.\r\nPlease use the text box to set the name.", "Invalid Arguments", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            UpdateControlsState();
        }

        /// <summary>
        /// Check if the collection of images has correct sizes.
        /// </summary>
        private bool ValidateGroups(IEnumerable<Image> images)
        {
            int maxHeight;
            var groupImages = GroupImages(images, out maxHeight);
            if( groupImages.Count > 1 )
            {
                for(int i = 1; i < groupImages.Count; i++)
                {
                    if (groupImages[i - 1][0].Height % groupImages[i][0].Height > 0)
                    {
                        var result = MessageBox.Show("The size of the images doesn't match.\r\nIt is best if the size of all images is the same or is multiplication of one another.\r\n\r\nDo you want to create gallery image anyway?", "Images size mismatch", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if( result == DialogResult.No )
                        {
                            _imagesListView.BackColor = _errorColor;
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Create single image from the given images with the given size per image.
        /// </summary>
        private static void CreateSingleImage(IEnumerable<Image> images, out Image galleryImage, out Dictionary<string, Rectangle> positions)
        {
            positions = new Dictionary<string, Rectangle>();
            var outputImage = new Bitmap(2000, 2000, PixelFormat.Format32bppArgb);

            int maxHeight;
            var groupImages = GroupImages(images, out maxHeight);

            int leftMost = 1;
            using (var g = Graphics.FromImage(outputImage))
            {
                foreach (var groupImage in groupImages)
                {
                    int top = 1;
                    int left = leftMost;
                    foreach (var image in groupImage)
                    {
                        g.DrawImage(image, new Rectangle(left, top, image.Width, image.Height));
                        positions.Add((string)image.Tag, new Rectangle(left, top, image.Width, image.Height));

                        leftMost = Math.Max(leftMost, left + image.Width + 1);

                        top += image.Height + 1;
                        if (top >= maxHeight)
                        {
                            top = 1;
                            left = leftMost;
                        }
                    }
                }
            }

            galleryImage = new Bitmap(leftMost, maxHeight);
            using (var g = Graphics.FromImage(galleryImage))
            {
                g.DrawImage(outputImage, new Rectangle(0, 0, galleryImage.Width, galleryImage.Height), 0, 0, galleryImage.Width, galleryImage.Height, GraphicsUnit.Pixel);
            }
        }

        /// <summary>
        /// Group the given images by height.
        /// </summary>
        /// <param name="images">the images to group</param>
        /// <param name="maxHeight">the max image height</param>
        /// <returns>grouped images</returns>
        private static List<List<Image>> GroupImages(IEnumerable<Image> images, out int maxHeight)
        {
            var groups = new List<List<Image>>();
            foreach (var image in images)
            {
                List<Image> iGroup = null;
                foreach (var pGroup in groups)
                {
                    if (pGroup[0].Height == image.Height)
                        iGroup = pGroup;
                }

                if (iGroup == null)
                {
                    iGroup = new List<Image>();
                    groups.Add(iGroup);
                }

                iGroup.Add(image);
            }

            groups.Sort((list1, list2) => list2[0].Height.CompareTo(list1[0].Height));

            maxHeight = groups[0][0].Height + 1;
            if (groups.Count == 1)
            {
                int num = (int)Math.Sqrt(groups[0].Count);
                num = num > 1 ? num : 1;
                while (groups[0].Count % num != 0)
                    num--;

                maxHeight = maxHeight * num + 1;
            }

            return groups;
        }

        /// <summary>
        /// 
        /// </summary>
        private static void CreatePositionsCodeString(Dictionary<string, Rectangle> positions, out string positionsStr, out string defaultPosition)
        {
            defaultPosition = null;
            var posBuilder = new StringBuilder();
            foreach (var position in positions)
            {
                foreach (var name in position.Key.Split(new[] { "$$" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    posBuilder.AppendLine(string.Format("_offsets[\"{0}\"] = new Rectangle({1},{2},{3},{4});", name, position.Value.Left, position.Value.Top, position.Value.Width, position.Value.Height));

                    if (defaultPosition == null || name.Equals("default", StringComparison.InvariantCultureIgnoreCase))
                        defaultPosition = string.Format("new Rectangle({0},{1},{2},{3})", position.Value.Left, position.Value.Top, position.Value.Width, position.Value.Height);
                }
            }
            positionsStr = posBuilder.ToString();
        }

        /// <summary>
        /// Load the single image.
        /// </summary>
        private void OnLoadGalleryImageClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;
                dialog.CheckFileExists = true;
                dialog.SupportMultiDottedExtensions = true;
                dialog.DefaultExt = ".png;.gif;.bmp";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _images.Clear();
                    _imagesListView.Items.Clear();

                    _singleImagePictureBox.Image = LoadImageFromFile(dialog.FileName);
                    _singleImagePictureBox.BackColor = SystemColors.Control;
                }
            }
            
            ClearColors();

            UpdateControlsState();
        }

        /// <summary>
        /// Split single image into images by locations.
        /// </summary>
        private void OnSplitSingleImageClick(object sender, EventArgs e)
        {
            ClearColors();
            if (_singleImagePictureBox.Image != null && !string.IsNullOrEmpty(_galleryClassCodeTextBox.Text.Trim()))
            {
                _images.Clear();

                Match lastMatch = null;
                try
                {
                    var dic = new Dictionary<Rectangle, Image>();
                    var matches = Regex.Matches(_galleryClassCodeTextBox.Text, @"_offsets\W*\[\W*\""(.*?)\""\W*\]\W*=\W*new\W+Rectangle\W*\(\W*(\d+)\W*,\W*(\d+)\W*,\W*(\d+)\W*,\W*(\d+)\W*\)");
                    foreach(Match match in matches)
                    {
                        lastMatch = match;
                        var name = match.Groups[1].Value;
                        var rect = new Rectangle(int.Parse(match.Groups[2].Value), int.Parse(match.Groups[3].Value), int.Parse(match.Groups[4].Value), int.Parse(match.Groups[5].Value));

                        if (dic.ContainsKey(rect))
                        {
                            dic[rect].Tag = dic[rect].Tag + "$$" + name;
                        }
                        else
                        {
                            var image = new Bitmap(rect.Width, rect.Height);
                            image.Tag = name;

                            using (var g = Graphics.FromImage(image))
                            {
                                g.DrawImage(_singleImagePictureBox.Image, new Rectangle(0, 0, image.Width, image.Height), rect, GraphicsUnit.Pixel);
                            }

                            dic[rect] = image;
                            _images.Add(image);
                        }
                    }

                    if( dic.Count < 1 )
                    {
                        _galleryClassCodeTextBox.BackColor = _errorColor;
                        _copyCodeLink.BackColor = _pasteCodeLink.BackColor = _errorColor;
                        MessageBox.Show("Invalid gallery class code is given for split locations.\r\nNo locations data was found.\r\n\r\nThe code need to contain locations data in the form:\r\n_offsets[\"name\"] = new Rectangle(48,32,16,16);", "Invalid Arguments", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    ShowImagesInListView(_images);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(string.Format("Error parsing gallery class code:\r\n{0}\r\n\r\n{1}", lastMatch != null ? lastMatch.Value : "NULL", ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if( _singleImagePictureBox.Image == null )
                {
                    _singleImagePictureBox.BackColor = _errorColor;
                    MessageBox.Show("No gallery image is given to split.\r\nPlease use 'Load Galley Image' link.", "Invalid Arguments", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    _galleryClassCodeTextBox.BackColor = _errorColor;
                    _copyCodeLink.BackColor = _pasteCodeLink.BackColor = _errorColor;
                    MessageBox.Show("No gallery class code is given for split locations.\r\nPlease paste the galley class code into code textbox.\r\n\r\nThe code need to contain locations data in the form:\r\n_offsets[\"name\"] = new Rectangle(48,32,16,16);", "Invalid Arguments", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            UpdateControlsState();
        }

        /// <summary>
        /// Save all the images into a folder.
        /// </summary>
        private void OnSaveImagesLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_images.Count > 0)
            {
                using (var dialog = new SaveFileDialog())
                {
                    dialog.FileName = "stub.ignore";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        var directoryName = Path.GetDirectoryName(dialog.FileName);
                        if (directoryName != null)
                        {
                            foreach (var image in _images)
                            {

                                image.Save(Path.Combine(directoryName, image.Tag + ".png"));
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Copy to clipboard the text in the code snippet text box.
        /// </summary>
        private void OnCopyCodeClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(_galleryClassCodeTextBox.Text);
        }

        /// <summary>
        /// Paste code to the code textbox.
        /// </summary>
        private void OnPasteCodeClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _galleryClassCodeTextBox.Text = Clipboard.GetText();
        }

        /// <summary>
        /// Save the single image to file.
        /// </summary>
        private void OnSaveGalleryImageClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_singleImagePictureBox.Image != null && _nameComboBox.Text.Length > 0)
            {
                using (var dialog = new SaveFileDialog())
                {
                    dialog.FileName = char.ToUpper(_nameComboBox.Text[0]) + _nameComboBox.Text.Substring(1) + ".png";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        _singleImagePictureBox.Image.Save(dialog.FileName);
                    }
                }
            }
        }

        /// <summary>
        /// On name change adjust the properties by the name.
        /// </summary>
        private void OnNameSelectedIndexChanged(object sender, EventArgs e)
        {
            var name = _nameComboBox.Text.Trim();
            switch (name)
            {
                case "extensions":
                    _createPropertiesCheckBox.Checked = false;
                    break;
            }
        }

        /// <summary>
        /// Get the image to create single image from.
        /// </summary>
        /// <returns>collection of images path or null</returns>
        private static string[] GetImages()
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;
                dialog.SupportMultiDottedExtensions = true;
                dialog.DefaultExt = ".png;.gif;.bmp";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.FileNames;
                }
                return null;
            }
        }

        /// <summary>
        /// Load image from file.
        /// </summary>
        /// <param name="file">the file path to load</param>
        /// <returns>loaded image</returns>
        private static Image LoadImageFromFile(string file)
        {
            var memoryStream = new MemoryStream();
            using(var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                int bytes;
                var buffer = new byte[1024];
                while( ( bytes = fileStream.Read(buffer, 0, buffer.Length) ) > 0 )
                    memoryStream.Write(buffer, 0, bytes);
            }
            Image image = Image.FromStream(memoryStream);
            return image;
        }

        /// <summary>
        /// On clear request clear everything.
        /// </summary>
        private void OnClearLabelClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearEverything();
        }

        /// <summary>
        /// Clear all data to start from scratch.
        /// </summary>
        private void ClearEverything()
        {
            _singleImagePictureBox.Image = null;

            _images.Clear();
            _imagesListView.Items.Clear();
            _galleryClassCodeTextBox.Text = string.Empty;
            
            ClearColors();

            UpdateControlsState();
        }

        /// <summary>
        /// Show the given images in list view.
        /// </summary>
        /// <param name="images">the images to show</param>
        private void ShowImagesInListView(List<Image> images)
        {
            images.Sort((left, right) => ((string)left.Tag).CompareTo(right.Tag));

            _imagesListView.Items.Clear();
            _imagesListView.SmallImageList.Images.Clear();

            foreach (var image in images)
            {
                _imagesListView.SmallImageList.Images.Add(image);

                var title = string.Format("{0} ({1} x {2})", image.Tag, image.Width, image.Height);
                var listViewItem = new ListViewItem(title, _imagesListView.SmallImageList.Images.Count - 1);
                listViewItem.Tag = image;
                _imagesListView.Items.Add(listViewItem);
            }
        }

        /// <summary>
        /// Get name that is valid to be property name
        /// </summary>
        /// <param name="name">the name to fix</param>
        /// <returns>fixed name</returns>
        private static string GetPropertyValidName(string name)
        {
            var propName = name.Trim(' ', '\r', '\n', '-', '_', '.');

            var idx = propName.IndexOfAny(new[] { ' ', '-', '_', '.' });
            while (idx >= 0)
            {
                propName = propName.Remove(idx, 1);
                propName = propName.Insert(idx, char.ToUpper(propName[idx]).ToString());
                propName = propName.Remove(idx + 1, 1);
                idx = propName.IndexOfAny(new[] { ' ', '-', '_', '.' });
            }

            propName = char.ToUpper(propName[0]) + propName.Substring(1);
            if (!char.IsLetter(propName[0]))
            {
                propName = "Img" + propName;
            }

            bool sawDigit = false;
            for (int i = 0; i < propName.Length; i++)
            {
                if (char.IsDigit(propName[i]))
                {
                    sawDigit = true;
                }
                else if (sawDigit && char.IsLetter(propName[i]))
                {
                    propName = propName.Insert(i, char.ToUpper(propName[i]).ToString());
                    propName = propName.Remove(i + 1, 1);
                    sawDigit = false;
                }
            }

            return propName;
        }

        /// <summary>
        /// Handle select all for a text box.
        /// </summary>
        private void OnTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        /// <summary>
        /// On delete key remove the selected images from the list.
        /// </summary>
        private void OnImagesListKeyUp(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Delete )
            {
                var selected = new List<ListViewItem>();
                foreach(var item in _imagesListView.SelectedItems)
                    selected.Add((ListViewItem)item);
                foreach(var item in selected)
                {
                    _images.Remove((Image)item.Tag);
                    _imagesListView.Items.Remove(item);
                }
            }
        }

        /// <summary>
        /// Support drag and drop of images
        /// </summary>
        private void OnDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var loc = PointToClient(new Point(e.X, e.Y));

                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (_singleImagePictureBox.Left < loc.X && loc.X < _singleImagePictureBox.Right &&
                    _singleImagePictureBox.Top < loc.Y && loc.Y < _singleImagePictureBox.Bottom &&
                    files.Length == 1)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else if (_imagesListView.Left < loc.X && loc.X < _imagesListView.Right &&
                         _imagesListView.Top < loc.Y && loc.Y < _imagesListView.Bottom &&
                         files.Length > 1)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        /// <summary>
        /// Handle drop of image files to load in the manager.
        /// </summary>
        private void OnDragDrop(object sender, DragEventArgs e)
        {
            var loc = PointToClient(new Point(e.X, e.Y));
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (_singleImagePictureBox.Left < loc.X && loc.X < _singleImagePictureBox.Right &&
                _singleImagePictureBox.Top < loc.Y && loc.Y < _singleImagePictureBox.Bottom &&
                files.Length == 1)
            {
                ClearEverything();

                _singleImagePictureBox.Image = LoadImageFromFile(files[0]);
            }
            else if (_imagesListView.Left < loc.X && loc.X < _imagesListView.Right &&
                     _imagesListView.Top < loc.Y && loc.Y < _imagesListView.Bottom &&
                     files.Length > 1)
            {
                LoadImageFiles(files);
            }
        }

        /// <summary>
        /// Removes the red color from the background.
        /// </summary>
        private void OnLocationsTextChanged(object sender, EventArgs e)
        {
            _galleryClassCodeTextBox.BackColor = Color.White;
            _copyCodeLink.BackColor = _pasteCodeLink.BackColor = Color.White;
        }

        /// <summary>
        /// Clear background color used to identify errors.
        /// </summary>
        private void ClearColors()
        {
            _imagesListView.BackColor = Color.White;
            _nameComboBox.BackColor = Color.White;
            _singleImagePictureBox.BackColor = Color.White;
            _galleryClassCodeTextBox.BackColor = Color.White;
            _copyCodeLink.BackColor = Color.White;
            _pasteCodeLink.BackColor = Color.White;
        }

        /// <summary>
        /// Update the enable state of controls depending if their functionality is available.
        /// </summary>
        private void UpdateControlsState()
        {
            _saveGalleryImageLink.Enabled = _singleImagePictureBox.Image != null;
            _saveImagesLink.Enabled = _imagesListView.Items.Count > 0;
            _copyCodeLink.Enabled = !string.IsNullOrEmpty(_galleryClassCodeTextBox.Text.Trim());
        }
    }
}
