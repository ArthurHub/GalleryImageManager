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
using System.Drawing;
using System.Windows.Forms;

namespace GalleryImage.Common
{
    /// <summary>
    /// Replaces <see cref="PictureBox"/> to use with <see cref="GalleryImagePart"/>.
    /// </summary>
    public class GalleryImageControl : Control
    {
        #region Fields and Consts

        /// <summary>
        /// the image part to show in the control.
        /// </summary>
        private GalleryImagePart _imagePart;

        /// <summary>
        /// One of the <see cref="PictureBoxSizeMode"/> values. The default is <see cref="PictureBoxSizeMode.Normal"/>.
        /// </summary>
        private PictureBoxSizeMode _sizeMode = PictureBoxSizeMode.Normal;

        #endregion


        /// <summary>
        /// Get\Set the image part to show in the control.
        /// </summary>
        public GalleryImagePart ImagePart
        {
            get { return _imagePart; }
            set
            {
                _imagePart = value;
                if(_imagePart != null)
                    Invalidate();
            }
        }

        /// <summary>
        /// One of the <see cref="PictureBoxSizeMode"/> values. The default is <see cref="PictureBoxSizeMode.Normal"/>.
        /// </summary>
        public PictureBoxSizeMode SizeMode
        {
            get { return _sizeMode; }
            set
            {
                if( _sizeMode != value )
                {
                    _sizeMode = value;
                    Invalidate();
                }
            }
        }

        /// <summary>
        /// Paint the image part in the control.
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            if( _imagePart != null )
            {
                switch( _sizeMode )
                {
                    case PictureBoxSizeMode.Normal:
                    case PictureBoxSizeMode.AutoSize:
                    {
                        e.Graphics.DrawImage(_imagePart.Image, 0, 0, _imagePart.Offset, GraphicsUnit.Pixel);
                        break;
                    }
                    case PictureBoxSizeMode.CenterImage:
                    {
                        e.Graphics.DrawImage(_imagePart.Image, (Width - _imagePart.Size.Width) / 2, (Height - _imagePart.Size.Height) / 2, _imagePart.Offset, GraphicsUnit.Pixel);
                        break;
                    }
                    case PictureBoxSizeMode.StretchImage:
                    {
                        var wOffset = ClientRectangle.Width > _imagePart.Offset.Width ? 0.5f : 0;
                        var hOffset = ClientRectangle.Height > _imagePart.Offset.Height ? 0.5f : 0;
                        var srcRect = new RectangleF(_imagePart.Offset.Left - wOffset, _imagePart.Offset.Top - hOffset, _imagePart.Offset.Width, _imagePart.Offset.Height);
                        e.Graphics.DrawImage(_imagePart.Image, ClientRectangle, srcRect, GraphicsUnit.Pixel);
                        break;
                    }
                    case PictureBoxSizeMode.Zoom:
                    {
                        var ratio = Math.Min(Width/(float)_imagePart.Size.Width, Height/(float)_imagePart.Size.Height);
                        var offset = ratio > 1 ? 0.5f : 0;
                        var destRect = new RectangleF(0, 0, _imagePart.Offset.Width * ratio, _imagePart.Offset.Height * ratio);
                        var srcRect = new RectangleF(_imagePart.Offset.Left - offset, _imagePart.Offset.Top - offset, _imagePart.Offset.Width + offset, _imagePart.Offset.Height + offset);
                        e.Graphics.DrawImage(_imagePart.Image, destRect, srcRect, GraphicsUnit.Pixel);
                        break;
                    }
                }
            }
        }
    }
}
