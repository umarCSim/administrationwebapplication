using System;
using System.Collections.Generic;

namespace AdministrationWebApplication.Models.Shared
{
    public partial class FooterDetailView
    {
        public int FileFooterId { get; set; }
        public int FkFileHeaderId { get; set; }
        public string RecordType { get; set; }
        public int RecordCount { get; set; }
        public int Checksum { get; set; }
    }
}
