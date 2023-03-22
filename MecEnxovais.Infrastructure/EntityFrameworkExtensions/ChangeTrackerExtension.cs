using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;

namespace MecEnxovais.Infrastructure.EntityFrameworkExtensions;
public static class ChangeTrackerExtension
{
    public static void SetAuditProperties(this ChangeTracker changeTracker)
    {
        changeTracker.DetectChanges();

        foreach (var item in changeTracker.Entries().Where(e => e.State == EntityState.Deleted))
        {
            item.State = EntityState.Modified;
            item.CurrentValues["Deleted"] = true;
        }
    }
}
