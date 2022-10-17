using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.Excel;
using DevExpress.DataAccess.Sql;
using Microsoft.Extensions.FileProviders;

namespace AspNetCoreDashboard {
    public static class DashboardUtils {
        public static DashboardConfigurator CreateDashboardConfigurator(IConfiguration configuration, IFileProvider fileProvider) {
            DashboardConfigurator configurator = new DashboardConfigurator();
            configurator.SetConnectionStringsProvider(new DashboardConnectionStringsProvider(configuration));

            DashboardFileStorage dashboardFileStorage = new DashboardFileStorage(fileProvider.GetFileInfo("Data/Dashboards").PhysicalPath);
            configurator.SetDashboardStorage(dashboardFileStorage);

            DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();

            return configurator;
        }
    }
}