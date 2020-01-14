using AdministrationWebApplication.Data;

namespace AdministrationWebApplication.Services.DataServices
{
    public class DataService_FileProcessingDetails : DataService
    {
        public DBContext_FileProcessingDetail _context { get; private set; }

        public DataService_FileProcessingDetails(DBContext_FileProcessingDetail context) : base(context)
        {
            _context = context;
        }
    }
}
