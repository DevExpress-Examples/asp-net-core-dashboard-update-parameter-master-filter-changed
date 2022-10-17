var dashboardControl;
function onBeforeRender(sender) {
    dashboardControl = sender;
    var viewerApiExtension = dashboardControl.findExtension('viewerApi');
    if (viewerApiExtension)
        viewerApiExtension.on('itemMasterFilterStateChanged', onItemMasterFilterStateChanged);
}
function onItemMasterFilterStateChanged(e) {
    if (e.itemName == "gridDashboardItem1") {
        var dashboardParameterDialogExtension = dashboardControl.findExtension('dashboardParameterDialog');
        var parameters = dashboardParameterDialogExtension.getParameters();
        var parameter1 = parameters.getParameterByName("OrderID");
        parameter1.setValue(e.values[0][0]);
    }
}