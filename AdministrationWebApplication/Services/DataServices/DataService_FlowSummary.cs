using AdministrationWebApplication.Data;
using System.Collections.Generic;
using AdministrationWebApplication.Models.Shared;
using System.Threading.Tasks;
using System.Linq;

namespace AdministrationWebApplication.Services.DataServices
{
    public class DataService_FlowSummary : DataService
    {
        public DBContext_FlowSummary _context { get; private set; }
        public IList<string> HeaderFields { get; private set; }

        public DataService_FlowSummary(DBContext_FlowSummary context) : base(context) 
        {
            _context = context;

            HeaderFields = new List<string>() 
            {
                "HeaderId",
                "Sequence #",
                "Created Date",
                "Processed Date",
                "Message Type",
                "Message Role",
                "From Role Code",
                "From Participant Id",
                "To Role Code",
                "To Participant Id",
                "Actions"
            };
        }

        public async Task<IList<FlowSummaryView>> GetSummaryData(string transitType)
        {
            IList<FlowSummaryView> summaryData = await GetDataAsync<FlowSummaryView>();
            return summaryData.Where(
                d => d.TransitType.Equals(transitType, System.StringComparison.InvariantCultureIgnoreCase)
                ).ToList();
        }
    }
}
