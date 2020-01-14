using System;
using System.Collections.Generic;

namespace AdministrationWebApplication.Models.Shared
{
    public partial class HeaderDetailView
    {
        public int FileHeaderId { get; set; }
        public string RecordType { get; set; }
        public string FileType { get; set; }
        public string MessageRole { get; set; }
        public DateTime CreationTime { get; set; }
        public string FromRoleCode { get; set; }
        public string FromParticipantId { get; set; }
        public string ToRoleCode { get; set; }
        public string ToParticipantId { get; set; }
        public long SequenceNumber { get; set; }
        public string TestDataFlag { get; set; }
        public bool FileSent { get; set; }
        public string TransitType { get; set; }
    }
}
