using System;
using System.Collections.Generic;

namespace AdministrationWebApplication.Models.Shared
{
    public partial class FlowSummaryView
    {
        public int HistoryId { get; set; }
        public int? FileHeaderId { get; set; }
        public long? SequenceNumber { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? ProcessEnded { get; set; }
        public string FileType { get; set; }
        public string MessageRole { get; set; }
        public string FromRoleCode { get; set; }
        public string FromParticipantId { get; set; }
        public string ToRoleCode { get; set; }
        public string ToParticipantId { get; set; }
        public bool ProcessSuccess { get; set; }
        public string TransitType { get; set; }
    }
}
