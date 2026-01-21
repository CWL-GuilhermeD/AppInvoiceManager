using InvoiceDataAccess.Configuration;
using Microsoft.EntityFrameworkCore;
namespace Service
{
    public class ServiceSpent(Conn conn)
    {
        private readonly Conn _conn = conn;

        public async Task SaveSpentAsync(SpentModel spent)
        {
            _conn.SpentsModel.Add(spent);
            await _conn.SaveChangesAsync();
        }

        public async Task CloseSpentAsync()
        {
            await _conn.SpentsModel.Where(s => s.InitialParcel <= s.FinalParcel).ExecuteUpdateAsync(su => su.SetProperty(b => b.InitialParcel, b => b.InitialParcel +1));
            await _conn.SpentsModel.Where(s => s.InitialParcel > s.FinalParcel).ExecuteUpdateAsync(su => su.SetProperty(b => b.Status, "PAGO"));
        }

        public async Task<List<SpentModel>> GetAllSpentsAsync()
        {
            return await _conn.SpentsModel.
                Where(s => s.Status == "ATIVO").
                AsNoTracking().
                ToListAsync();
        }

        public async Task DisableShopAsync(int id)
        {
            await _conn.SpentsModel.
                Where(s => s.Id == id).
                ExecuteUpdateAsync(s => s.SetProperty(b => b.Status, "DELETADO"));
        }

        public async Task<List<SpentModel>> FindPayerAsync(string payerName, string status)
        {
            return await _conn.SpentsModel.
                Where(s => s.NameClient.Contains(payerName) && s.Status == status).
                AsNoTracking().
                ToListAsync();
        }

        public async Task<List<SpentModel>> FindPayerAllAsync(string payerName)
        {
            return await _conn.SpentsModel.
                Where(s => s.NameClient.Contains(payerName)).
                AsNoTracking().
                ToListAsync();
        }

        public async Task RecoveryPayerAsync(int id, string status)
        {
            await _conn.SpentsModel.Where(p => p.Id == id).ExecuteUpdateAsync(pn => pn.SetProperty(s => s.Status, status));
        }

        public async Task<SpentModel?> FindPayerByIdAsync(int id)
        {
            return await _conn.SpentsModel.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdatePayerByID(int id, string shopName, double value, int initialParcel, int finalParcel, string Name)
        {
            await _conn.SpentsModel.Where(s => s.Id == id).ExecuteUpdateAsync(sn => sn.
            SetProperty(sp => sp.SpentName, shopName).
            SetProperty(sp => sp.SpentValue, value).
            SetProperty(sp => sp.InitialParcel, initialParcel).
            SetProperty(sp => sp.FinalParcel, finalParcel).
            SetProperty(sp => sp.NameClient, Name)
            );
        }

        public async Task<double?> SumTotalInvoice()
        {
            return await _conn.SpentsModel.Where(s => s.Status == "ATIVO").SumAsync(sm => sm.SpentValue);
        }

        public async Task<double?> SumTotalByName(string name)
        {
            return await _conn.SpentsModel.Where(s => s.NameClient.Contains(name.ToUpper()) && s.Status.Contains("ATIVO")).SumAsync(sm => sm.SpentValue);
        }
    }
}
