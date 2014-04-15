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
    /// Handle image gallery for 'Extensions' images.<br/>
    /// Allow to get image gallery part (a single image in the gallery) by property or by string key.
    /// </summary>
    public static class ExtensionsImages
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
            get { return CachedResources.Extensions; }
        }

        /// <summary>
        /// Get all the keys of the image parts.
        /// </summary>
        public static IEnumerable<string> ImagePartsKeys
        {
            get { return _offsets.Keys; }
        }
        /// <summary>
        /// Get gallery image part for 'avi' image.
        /// </summary>
        public static GalleryImagePart Avi
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("avi")); }
        }

        /// <summary>
        /// Get gallery image part for 'mpg' image.
        /// </summary>
        public static GalleryImagePart Mpg
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("mpg")); }
        }

        /// <summary>
        /// Get gallery image part for 'mkv' image.
        /// </summary>
        public static GalleryImagePart Mkv
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("mkv")); }
        }

        /// <summary>
        /// Get gallery image part for 'flv' image.
        /// </summary>
        public static GalleryImagePart Flv
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("flv")); }
        }

        /// <summary>
        /// Get gallery image part for 'mp4' image.
        /// </summary>
        public static GalleryImagePart Mp4
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("mp4")); }
        }

        /// <summary>
        /// Get gallery image part for 'mpeg' image.
        /// </summary>
        public static GalleryImagePart Mpeg
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("mpeg")); }
        }

        /// <summary>
        /// Get gallery image part for 'divx' image.
        /// </summary>
        public static GalleryImagePart Divx
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("divx")); }
        }

        /// <summary>
        /// Get gallery image part for 'bmp' image.
        /// </summary>
        public static GalleryImagePart Bmp
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("bmp")); }
        }

        /// <summary>
        /// Get gallery image part for 'gif' image.
        /// </summary>
        public static GalleryImagePart Gif
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("gif")); }
        }

        /// <summary>
        /// Get gallery image part for 'jpg' image.
        /// </summary>
        public static GalleryImagePart Jpg
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("jpg")); }
        }

        /// <summary>
        /// Get gallery image part for 'png' image.
        /// </summary>
        public static GalleryImagePart Png
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("png")); }
        }

        /// <summary>
        /// Get gallery image part for 'jpeg' image.
        /// </summary>
        public static GalleryImagePart Jpeg
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("jpeg")); }
        }

        /// <summary>
        /// Get gallery image part for 'tiff' image.
        /// </summary>
        public static GalleryImagePart Tiff
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("tiff")); }
        }

        /// <summary>
        /// Get gallery image part for 'chm' image.
        /// </summary>
        public static GalleryImagePart Chm
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("chm")); }
        }

        /// <summary>
        /// Get gallery image part for 'default' image.
        /// </summary>
        public static GalleryImagePart Default
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("default")); }
        }

        /// <summary>
        /// Get gallery image part for 'dll' image.
        /// </summary>
        public static GalleryImagePart Dll
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("dll")); }
        }

        /// <summary>
        /// Get gallery image part for 'doc' image.
        /// </summary>
        public static GalleryImagePart Doc
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("doc")); }
        }

        /// <summary>
        /// Get gallery image part for 'docx' image.
        /// </summary>
        public static GalleryImagePart Docx
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("docx")); }
        }

        /// <summary>
        /// Get gallery image part for 'docm' image.
        /// </summary>
        public static GalleryImagePart Docm
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("docm")); }
        }

        /// <summary>
        /// Get gallery image part for 'exe' image.
        /// </summary>
        public static GalleryImagePart Exe
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("exe")); }
        }

        /// <summary>
        /// Get gallery image part for 'htm' image.
        /// </summary>
        public static GalleryImagePart Htm
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("htm")); }
        }

        /// <summary>
        /// Get gallery image part for 'html' image.
        /// </summary>
        public static GalleryImagePart Html
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("html")); }
        }

        /// <summary>
        /// Get gallery image part for 'mp3' image.
        /// </summary>
        public static GalleryImagePart Mp3
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("mp3")); }
        }

        /// <summary>
        /// Get gallery image part for 'ogg' image.
        /// </summary>
        public static GalleryImagePart Ogg
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("ogg")); }
        }

        /// <summary>
        /// Get gallery image part for 'wma' image.
        /// </summary>
        public static GalleryImagePart Wma
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("wma")); }
        }

        /// <summary>
        /// Get gallery image part for 'pdf' image.
        /// </summary>
        public static GalleryImagePart Pdf
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("pdf")); }
        }

        /// <summary>
        /// Get gallery image part for 'ppt' image.
        /// </summary>
        public static GalleryImagePart Ppt
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("ppt")); }
        }

        /// <summary>
        /// Get gallery image part for 'pptx' image.
        /// </summary>
        public static GalleryImagePart Pptx
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("pptx")); }
        }

        /// <summary>
        /// Get gallery image part for 'pptm' image.
        /// </summary>
        public static GalleryImagePart Pptm
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("pptm")); }
        }

        /// <summary>
        /// Get gallery image part for 'pst' image.
        /// </summary>
        public static GalleryImagePart Pst
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("pst")); }
        }

        /// <summary>
        /// Get gallery image part for 'ost' image.
        /// </summary>
        public static GalleryImagePart Ost
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("ost")); }
        }

        /// <summary>
        /// Get gallery image part for 'txt' image.
        /// </summary>
        public static GalleryImagePart Txt
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("txt")); }
        }

        /// <summary>
        /// Get gallery image part for 'log' image.
        /// </summary>
        public static GalleryImagePart Log
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("log")); }
        }

        /// <summary>
        /// Get gallery image part for 'text' image.
        /// </summary>
        public static GalleryImagePart Text
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("text")); }
        }

        /// <summary>
        /// Get gallery image part for 'xls' image.
        /// </summary>
        public static GalleryImagePart Xls
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("xls")); }
        }

        /// <summary>
        /// Get gallery image part for 'xlsx' image.
        /// </summary>
        public static GalleryImagePart Xlsx
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("xlsx")); }
        }

        /// <summary>
        /// Get gallery image part for 'xlsm' image.
        /// </summary>
        public static GalleryImagePart Xlsm
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("xlsm")); }
        }

        /// <summary>
        /// Get gallery image part for 'xml' image.
        /// </summary>
        public static GalleryImagePart Xml
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("xml")); }
        }

        /// <summary>
        /// Get gallery image part for 'xsd' image.
        /// </summary>
        public static GalleryImagePart Xsd
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("xsd")); }
        }

        /// <summary>
        /// Get gallery image part for 'zip' image.
        /// </summary>
        public static GalleryImagePart Zip
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("zip")); }
        }

        /// <summary>
        /// Get gallery image part for 'rar' image.
        /// </summary>
        public static GalleryImagePart Rar
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("rar")); }
        }

        /// <summary>
        /// Get gallery image part for 'ace' image.
        /// </summary>
        public static GalleryImagePart Ace
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("ace")); }
        }

        /// <summary>
        /// Get gallery image part for '7zip' image.
        /// </summary>
        public static GalleryImagePart Img7Zip
        {
            get { return new GalleryImagePart(GalleryImage, GetOffset("7zip")); }
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

            return new Rectangle(1, 52, 16, 16);
        }


        #region Private methods

        /// <summary>
        /// Init the mapping between Extensions and the image rectangle offset in the image gallery.
        /// </summary>
        private static void InitOffsets()
        {
            if (_offsets.Count == 0)
            {
                _offsets["avi"] = new Rectangle(1, 1, 16, 16);
                _offsets["mpg"] = new Rectangle(1, 1, 16, 16);
                _offsets["mkv"] = new Rectangle(1, 1, 16, 16);
                _offsets["flv"] = new Rectangle(1, 1, 16, 16);
                _offsets["mp4"] = new Rectangle(1, 1, 16, 16);
                _offsets["mpeg"] = new Rectangle(1, 1, 16, 16);
                _offsets["divx"] = new Rectangle(1, 1, 16, 16);
                _offsets["bmp"] = new Rectangle(1, 18, 16, 16);
                _offsets["gif"] = new Rectangle(1, 18, 16, 16);
                _offsets["jpg"] = new Rectangle(1, 18, 16, 16);
                _offsets["png"] = new Rectangle(1, 18, 16, 16);
                _offsets["jpeg"] = new Rectangle(1, 18, 16, 16);
                _offsets["tiff"] = new Rectangle(1, 18, 16, 16);
                _offsets["chm"] = new Rectangle(1, 35, 16, 16);
                _offsets["default"] = new Rectangle(1, 52, 16, 16);
                _offsets["dll"] = new Rectangle(18, 1, 16, 16);
                _offsets["doc"] = new Rectangle(18, 18, 16, 16);
                _offsets["docx"] = new Rectangle(18, 18, 16, 16);
                _offsets["docm"] = new Rectangle(18, 18, 16, 16);
                _offsets["exe"] = new Rectangle(18, 35, 16, 16);
                _offsets["htm"] = new Rectangle(18, 52, 16, 16);
                _offsets["html"] = new Rectangle(18, 52, 16, 16);
                _offsets["mp3"] = new Rectangle(35, 1, 16, 16);
                _offsets["ogg"] = new Rectangle(35, 1, 16, 16);
                _offsets["wma"] = new Rectangle(35, 1, 16, 16);
                _offsets["pdf"] = new Rectangle(35, 18, 16, 16);
                _offsets["ppt"] = new Rectangle(35, 35, 16, 16);
                _offsets["pptx"] = new Rectangle(35, 35, 16, 16);
                _offsets["pptm"] = new Rectangle(35, 35, 16, 16);
                _offsets["pst"] = new Rectangle(35, 52, 16, 16);
                _offsets["ost"] = new Rectangle(35, 52, 16, 16);
                _offsets["txt"] = new Rectangle(52, 1, 16, 16);
                _offsets["log"] = new Rectangle(52, 1, 16, 16);
                _offsets["text"] = new Rectangle(52, 1, 16, 16);
                _offsets["xls"] = new Rectangle(52, 18, 16, 16);
                _offsets["xlsx"] = new Rectangle(52, 18, 16, 16);
                _offsets["xlsm"] = new Rectangle(52, 18, 16, 16);
                _offsets["xml"] = new Rectangle(52, 35, 16, 16);
                _offsets["xsd"] = new Rectangle(52, 35, 16, 16);
                _offsets["zip"] = new Rectangle(52, 52, 16, 16);
                _offsets["rar"] = new Rectangle(52, 52, 16, 16);
                _offsets["ace"] = new Rectangle(52, 52, 16, 16);
                _offsets["7zip"] = new Rectangle(52, 52, 16, 16);
            }
        }

        #endregion
    }
}