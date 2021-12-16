using DevExpress.Web.Bootstrap;
using System;
using B_PowerWeb;

namespace B_PowerWeb {
    public partial class Default : System.Web.UI.Page {

        protected void CardViewControl_CustomCallback(object sender, DevExpress.Web.ASPxCardViewCustomCallbackEventArgs e) {
            int newPageSize = Int32.Parse(e.Parameters);
            CardViewControl.SettingsPager.ItemsPerPage = newPageSize;
            CardViewControl.DataBind();
        }

        protected void BootstrapScheduler1_Init(object sender, EventArgs e) {
            var scheduler = (BootstrapScheduler)sender;
            scheduler.Storage.Appointments.Labels.Clear();
            foreach(SchedulerLabel label in SchedulerLabelsHelper.GetItems())
                scheduler.Storage.Appointments.Labels.Add(label.Id, label.Name, label.BackgroundCssClass, label.TextCssClass);
        }
    }
}