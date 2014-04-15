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

using System.Drawing;

namespace GalleryImage.Common
{
    /// <summary>
    /// Single image inside a gallery image represented by single large image and the offset of the single image in it.<br/>
    /// </summary>
    public sealed class GalleryImagePart
    {
        /// <summary>
        /// the underline image
        /// </summary>
        private readonly Image _image;

        /// <summary>
        /// the offset of the image
        /// </summary>
        private readonly Rectangle _offset;

        /// <summary>
        /// Init.
        /// </summary>
        /// <param name="image">the underline image</param>
        public GalleryImagePart(Image image)
        {
            _image = image;
            _offset = new Rectangle(0, 0, image.Width, image.Height);
        }

        /// <summary>
        /// Init.
        /// </summary>
        /// <param name="image">the underline image</param>
        /// <param name="offset">the offset of the image</param>
        public GalleryImagePart(Image image, Rectangle offset)
        {
            _image = image;
            _offset = offset;
        }

        /// <summary>
        /// Init.
        /// </summary>
        /// <param name="image">the underline image</param>
        /// <param name="location">the location offset of the image</param>
        /// <param name="size">the size offset of the image</param>
        public GalleryImagePart(Image image, Point location, Size size)
        {
            _image = image;
            _offset = new Rectangle(location, size);
        }

        /// <summary>
        /// the underline image
        /// </summary>
        public Image Image
        {
            get { return _image; }
        }

        /// <summary>
        /// the offset of the image
        /// </summary>
        public Rectangle Offset
        {
            get { return _offset; }
        }

        /// <summary>
        /// the offset of the image
        /// </summary>
        public Point Location
        {
            get { return _offset.Location; }
        }

        /// <summary>
        /// the offset of the image
        /// </summary>
        public Size Size
        {
            get { return _offset.Size; }
        }

        public override string ToString()
        {
            return string.Format("Offset: {0}", _offset);
        }
    }
}