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
using GalleryImage.Common;
using GalleryImage.Demo.Properties;

namespace GalleryImage.Demo
{
    /// <summary>
    /// Handle image gallery for 'Emoticons' images.<br/>
    /// Allow to get image gallery part (a single image in the gallery) by property or by string key.
    /// </summary>
    public static class EmoticonsImages
    {
        #region Fields and Consts

        /// <summary>
        /// mapping between extension and the image rectangle in the gallery image.
        /// </summary>
        private static readonly Dictionary<string, Rectangle> _offsets = new Dictionary<string, Rectangle>(StringComparer.InvariantCultureIgnoreCase);

        #endregion


        /// <summary>
        /// Get the gallery image that holds all the images.
        /// </summary>
        public static Image GalleryImage
        {
            get { return CachedResources.Emoticons; }
        }

        /// <summary>
        /// Get all the keys of the image parts.
        /// </summary>
        public static IEnumerable<string> ImagePartsKeys
        {
            get { return _offsets.Keys; }
        }
        /// <summary>
        /// Get gallery image part for 'emoticon_alert' image.
        /// </summary>
        public static GalleryImagePart EmoticonAlert
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_alert")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_angry' image.
        /// </summary>
        public static GalleryImagePart EmoticonAngry
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_angry")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_blush' image.
        /// </summary>
        public static GalleryImagePart EmoticonBlush
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_blush")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_check' image.
        /// </summary>
        public static GalleryImagePart EmoticonCheck
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_check")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_confused' image.
        /// </summary>
        public static GalleryImagePart EmoticonConfused
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_confused")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_cool' image.
        /// </summary>
        public static GalleryImagePart EmoticonCool
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_cool")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_cry' image.
        /// </summary>
        public static GalleryImagePart EmoticonCry
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_cry")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_devil' image.
        /// </summary>
        public static GalleryImagePart EmoticonDevil
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_devil")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_grin' image.
        /// </summary>
        public static GalleryImagePart EmoticonGrin
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_grin")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_happy' image.
        /// </summary>
        public static GalleryImagePart EmoticonHappy
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_happy")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_info' image.
        /// </summary>
        public static GalleryImagePart EmoticonInfo
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_info")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_laugh' image.
        /// </summary>
        public static GalleryImagePart EmoticonLaugh
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_laugh")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_love' image.
        /// </summary>
        public static GalleryImagePart EmoticonLove
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_love")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_minus' image.
        /// </summary>
        public static GalleryImagePart EmoticonMinus
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_minus")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_mischief' image.
        /// </summary>
        public static GalleryImagePart EmoticonMischief
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_mischief")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_plain' image.
        /// </summary>
        public static GalleryImagePart EmoticonPlain
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_plain")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_plus' image.
        /// </summary>
        public static GalleryImagePart EmoticonPlus
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_plus")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_sad' image.
        /// </summary>
        public static GalleryImagePart EmoticonSad
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_sad")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_shocked' image.
        /// </summary>
        public static GalleryImagePart EmoticonShocked
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_shocked")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_silly' image.
        /// </summary>
        public static GalleryImagePart EmoticonSilly
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_silly")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_wink' image.
        /// </summary>
        public static GalleryImagePart EmoticonWink
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_wink")); }
        }

        /// <summary>
        /// Get gallery image part for 'emoticon_x' image.
        /// </summary>
        public static GalleryImagePart EmoticonX
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("emoticon_x")); }
        }
        /// <summary>
        /// Get gallery image part by the given key.
        /// </summary>
        /// <param name="key">the key to get image part by</param>
        /// <returns>image part, never null</returns>
        public static GalleryImagePart GetImagePart(string key)
        {
            return new GalleryImagePart(GalleryImage, GetOffset(key));
        }

        /// <summary>
        /// Get rectangle offset for image by the requested key.<br/>
        /// </summary>
        /// <param name="key">the key to get the image offset for</param>
        /// <returns>image rectangle offset, default if failed to find</returns>
        public static Rectangle GetOffset(string key)
        {
            InitOffsets();

            if (!String.IsNullOrEmpty(key))
            {
                Rectangle value;
                if (_offsets.TryGetValue(key, out value))
                {
                    return value;
                }
            }

            return new Rectangle(1, 1, 16, 16);
        }


        #region Private methods

        /// <summary>
        /// Init the mapping between Emoticons and the image rectangle offset in the image gallery.
        /// </summary>
        private static void InitOffsets()
        {
            if (_offsets.Count == 0)
            {
                _offsets["emoticon_alert"] = new Rectangle(1, 1, 16, 16);
                _offsets["emoticon_angry"] = new Rectangle(1, 18, 16, 16);
                _offsets["emoticon_blush"] = new Rectangle(18, 1, 16, 16);
                _offsets["emoticon_check"] = new Rectangle(18, 18, 16, 16);
                _offsets["emoticon_confused"] = new Rectangle(35, 1, 16, 16);
                _offsets["emoticon_cool"] = new Rectangle(35, 18, 16, 16);
                _offsets["emoticon_cry"] = new Rectangle(52, 1, 16, 16);
                _offsets["emoticon_devil"] = new Rectangle(52, 18, 16, 16);
                _offsets["emoticon_grin"] = new Rectangle(69, 1, 16, 16);
                _offsets["emoticon_happy"] = new Rectangle(69, 18, 16, 16);
                _offsets["emoticon_info"] = new Rectangle(86, 1, 16, 16);
                _offsets["emoticon_laugh"] = new Rectangle(86, 18, 16, 16);
                _offsets["emoticon_love"] = new Rectangle(103, 1, 16, 16);
                _offsets["emoticon_minus"] = new Rectangle(103, 18, 16, 16);
                _offsets["emoticon_mischief"] = new Rectangle(120, 1, 16, 16);
                _offsets["emoticon_plain"] = new Rectangle(120, 18, 16, 16);
                _offsets["emoticon_plus"] = new Rectangle(137, 1, 16, 16);
                _offsets["emoticon_sad"] = new Rectangle(137, 18, 16, 16);
                _offsets["emoticon_shocked"] = new Rectangle(154, 1, 16, 16);
                _offsets["emoticon_silly"] = new Rectangle(154, 18, 16, 16);
                _offsets["emoticon_wink"] = new Rectangle(171, 1, 16, 16);
                _offsets["emoticon_x"] = new Rectangle(171, 18, 16, 16);
            }
        }

        #endregion
    }
}