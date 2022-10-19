using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using System;
using System.Collections.Generic;

namespace AspNetCoreDashboard.Code {
    public class CustomDashboardStateService : IDashboardStateService {
        public DashboardState GetState(string dashboardId, System.Xml.Linq.XDocument dashboard) {
            DashboardState dashboardState = new DashboardState();

            DashboardParameterState parameterState = new DashboardParameterState("OrderID", "10253", typeof(int));

            DashboardItemState gridFilterState = new DashboardItemState("gridDashboardItem1");
            gridFilterState.MasterFilterValues.Add(new object[] { 10253, "Hanari Carnes" });

            dashboardState.Parameters.Add(parameterState);
            dashboardState.Items.Add(gridFilterState);

            return dashboardState;
        }
    }
}