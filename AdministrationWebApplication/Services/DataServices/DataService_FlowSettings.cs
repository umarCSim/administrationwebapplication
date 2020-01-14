using AdministrationWebApplication.Data;

namespace AdministrationWebApplication.Services.DataServices
{
    
    public class DataService_FlowSettings : DataService
    {
        public DBContext_FlowSettings _context { get; private set; }

        public DataService_FlowSettings(DBContext_FlowSettings context) : base (context)
        {
            _context = context;
        }
    }
}
