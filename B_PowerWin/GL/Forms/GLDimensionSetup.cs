using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_PowerWin.GL.Forms
{
    public partial class GLDimensionSetup : GUI.EditFormBase
    {
        public GLDimensionSetup()
        {
            InitializeComponent();
            InitData();
        }

        public override void RefreshData()
        {
            dbContext = new AppDbContext();
            dbContext.BusinessUnits.Load();
            dbContext.Sites.Load();
            dbContext.Departments.Load();
            dbContext.Equipments.Load();
            dbContext.Projects.Load();
            dbContext.Purposes.Load();

            businessUnitBS.DataSource = dbContext.BusinessUnits.Local;
            siteBS.DataSource = dbContext.Sites.Local;
            departmentBS.DataSource = dbContext.Departments.Local;
            equipmentBS.DataSource = dbContext.Equipments.Local;
            projectBS.DataSource = dbContext.Equipments.Local;
            purposeBS.DataSource = dbContext.Purposes.Local;

            businessUnitBS.ResetBindings(true);
            siteBS.ResetBindings(true);
            departmentBS.ResetBindings(true);
            equipmentBS.ResetBindings(true);
            projectBS.ResetBindings(true);
            purposeBS.ResetBindings(true);




            base.RefreshData();
        }
        private void InitData()
        {
           
            FormGridManager = new GUI.Grid.GridManager();
            
            FormGridManager.Attach(businessUnitGC,siteGC,departmentGC,equipmentGC,projectGC,purposeGC);
            businessUnitGC.DataSource = businessUnitBS;
            siteGC.DataSource = siteBS;
            departmentGC.DataSource = departmentBS;
            equipmentGC.DataSource = equipmentBS;
            projectGC.DataSource = projectBS;
            purposeGC.DataSource = purposeBS;

            RefreshData();

        }



    }
}
