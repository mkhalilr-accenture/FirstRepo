using System;

namespace OrderService.Entity
{
    public class CaptureMediaItem
    {
        /// <summary>
        /// Gets or sets the captured media item identifier.
        /// </summary>
        /// <value>
        /// The captured media item identifier.
        /// </value>
        public string CapturedMediaItemId { get; set; }

        /// <summary>
        /// Gets or sets the image type.
        /// </summary>
        /// <value>
        /// The image type.
        /// </value>
        public string ImageType { get; set; }

        public string OriginalMediaItemAddress { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the voyage identifier.
        /// </summary>        
        /// <value>
        /// The voyage identifier.
        /// </value>
        public string VoyageId { get; set; }

        /// <summary>
        /// Gets or sets the captured date.
        /// </summary>
        /// <value>
        /// The captured date.
        /// </value>
        public DateTime CapturedDate { get; set; }

        /// <summary>
        /// Gets or sets the face count.
        /// </summary>
        /// <value>
        /// The face count.
        /// </value>
        public int FaceCount { get; set; }

        /// <summary>
        /// Gets or sets the uploaded by guest identifier.
        /// </summary>
        /// <value>
        /// The uploaded by guest identifier.
        /// </value>
        public string UploadedByGuestId { get; set; }

        /// <summary>
        /// Gets or sets the capture category identifier.
        /// </summary>
        /// <value>
        /// The capture category identifier.
        /// </value>
        public string CaptureCategoryId { get; set; }

        /// <summary>
        /// Gets or sets the capture type identifier.
        /// </summary>
        /// <value>
        /// The capture type identifier.
        /// </value>
        public string CaptureTypeId { get; set; }

        /// <summary>
        /// Gets or sets the capture location identifier.
        /// </summary>
        /// <value>
        /// The capture location identifier.
        /// </value>
        public string CaptureLocationId { get; set; }

        /// <summary>
        /// Gets or sets the session id.
        /// </summary>
        /// <value>
        /// The session id.
        /// </value>
        public string SessionId { get; set; }

        public string ImageTypeId { get; set; }

        /// <summary>
        /// Gets or sets the added date.
        /// </summary>
        /// <value>
        /// The added date.
        /// </value>
        public DateTime? AddedDate { get; set; }

        /// <summary>
        /// Gets or sets the processed media item address.
        /// </summary>
        /// <value>
        /// The processed media item address.
        /// </value>
        public string ProcessedMediaItemAddress { get; set; }

        /// <summary>
        /// Gets or sets the low resolution media item address.
        /// </summary>
        /// <value>
        /// The low resolution media item address.
        /// </value>
        public string LowResolutionMediaItemAddress { get; set; }

        /// <summary>
        /// Gets or sets the portrait flag
        /// </summary>
        /// <value>
        /// The portrait flag
        /// </value>
        public bool IsPortrait { get; set; }

        /// <summary>
        /// Gets or sets the uploaded by crew member identifier.
        /// </summary>
        /// <value>
        /// The uploaded by crew member identifier.
        /// </value>
        public string UploadedByCrewmemberId { get; set; }

        /// <summary>
        /// Gets or sets the aspect ratio.
        /// </summary>
        /// <value>
        /// The aspect ratio.
        /// </value>
        public string AspectRatio { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [is favorite].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [is favorite]; otherwise, <c>false</c>.
        /// </value>
        public bool IsFavorite { get; set; }

        /// <summary>
        /// Gets or sets the orientation.
        /// </summary>
        /// <value>
        /// The orientation.
        /// </value>
        public string Orientation { get; set; }

        /// <summary>
        /// Gets or sets the voyage identifier.
        /// </summary>        
        /// <value>
        /// The voyage identifier.
        /// </value>
        public string VoyageNumber { get; set; }

    }
}
