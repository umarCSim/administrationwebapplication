using System;
using System.Collections.Generic;

namespace AdministrationWebApplication.Models.Shared
{
    public partial class FileProcessingDetailView
    {
        public int HistoryId { get; set; }
        public int? FileHeaderId { get; set; }
        public string Filename { get; set; }
        public string Package { get; set; }
        public DateTime ProcessStarted { get; set; }
        public DateTime? ProcessEnded { get; set; }
        public bool ProcessSuccess { get; set; }
        public bool? HeaderValidationBypassed { get; set; }
        public bool? FooterValidationBypassed { get; set; }
        public string CodeType { get; set; }
        public string Meaning { get; set; }
        public string ResponseData { get; set; }
        public string AppropriateAction { get; set; }
        public DateTime? ResponseSentDate { get; set; }
    }
}
