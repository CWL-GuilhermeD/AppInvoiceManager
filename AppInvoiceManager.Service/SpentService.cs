using InvoiceDataAccess.Configuration;
using System.Data.Common;

namespace AppInvoiceManager.Service
{
    public class SpentService
    {
        private readonly DBConnection _context;

        public SpentService(DBConnection context)
        {
            _context = context;
        }

    }
}
