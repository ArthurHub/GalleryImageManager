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
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using GalleryImage.Demo.Properties;

namespace GalleryImage.Demo
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();

            Icon = Resources.Icons;

            _devilGalleryImageControl.ImagePart = EmoticonsImages.EmoticonDevil;
            _loveGalleryImageControl.ImagePart = EmoticonsImages.EmoticonLove;

            foreach(var key in EmoticonsImages.ImagePartsKeys)
                _partsComboBox.Items.Add(key);
            if(_partsComboBox.Items.Count > 0)
                _partsComboBox.SelectedIndex = 0;

            foreach(var value in Enum.GetValues(typeof(PictureBoxSizeMode)))
                _sizeModesComboBox.Items.Add(value);
            _sizeModesComboBox.SelectedItem = PictureBoxSizeMode.CenterImage;


        }

        /// <summary>
        /// Change the image part shown by requested key.
        /// </summary>
        private void OnPartsComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            _galleryImageControl.ImagePart = EmoticonsImages.GetImagePart((string)_partsComboBox.SelectedItem);
        }

        /// <summary>
        /// Change the size mode of the 
        /// </summary>
        private void OnSizeModesComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            _galleryImageControl.SizeMode = (PictureBoxSizeMode)_sizeModesComboBox.SelectedItem;
        }
    }
}
