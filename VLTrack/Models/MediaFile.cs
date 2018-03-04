using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    /// <summary>
    /// MediaFile class manipulates the media files uploaded to the system
    /// whether owned by the customers or the administrators.
    /// It contains 2 types: Images and Documents
    /// </summary>
    public class MediaFile
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string MediaFileTitle { get; set; }
        public string MediaFileDesc { get; set; }
        //MediaFileType specifies whether the file is .JPG, .PNG, .PDF, or .DOCX
        public string MediaFileType { get; set; }
        public string MediaFilePath { get; set; }
        public double MediaFileWidth { get; set; }
        public double MediaFileHeight { get; set; }
        //Media File Size will be in Kbs
        public double MediaFileSize { get; set; }
        public DateTime MediaFileCreationDate { get; set; }
    }
}