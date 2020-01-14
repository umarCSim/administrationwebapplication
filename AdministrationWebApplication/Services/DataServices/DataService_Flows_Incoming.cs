using AdministrationWebApplication.Data;

namespace AdministrationWebApplication.Services.DataServices
{
    public class DataService_Flows_Incoming : DataService
    {
        public DBContext_Flows_Incoming _context { get; private set; }

        public DataService_Flows_Incoming(DBContext_Flows_Incoming context) : base(context)
        {
            _context = context;
        }
    }
}
