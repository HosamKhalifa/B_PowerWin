using B_PowerWin.DB;
using B_PowerWin.GUI.CustomLookup;
using B_PowerWin.GUI.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B_PowerWin.HR.Forms
{
    public partial class EmployeeFrm : B_PowerWin.GUI.EditFormBase
    {
        public EmployeeFrm()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            dbContext = new AppDbContext();
            GridManager.SetupEditForm(employeeGV, new List<string>() {
                                      Employee.AccountBaseFields.ReferenceNum,
                                      Employee.AccountBaseFields.Name,
                                      Employee.AccountBaseFields.Suspended,
                                      Employee.AccountBaseFields.GroupId,
                                      Employee.EmployeeBaseFields.IdentityCard,
                                      Employee.EmployeeBaseFields.InsuranceNum,
                                      Employee.EmployeeBaseFields.BirthDate,
                                      Employee.EmployeeBaseFields.Gender,
                                      Employee.EmployeeBaseFields.MaritalState,
                                      Employee.EmployeeBaseFields.Religion,
                                      Employee.EmployeeBaseFields.StartDate,
                                      Employee.EmployeeBaseFields.EndDate,
                                      Employee.EmployeeBaseFields.CountryId,
                                      Employee.EmployeeBaseFields.CityId,
                                      Employee.EmployeeBaseFields.BankAccountNum,
                                      Employee.EmployeeBaseFields.BankId,
                                      Employee.EmployeeBaseFields.Email,
                                      Employee.EmployeeBaseFields.Address,
                                      Employee.EmployeeBaseFields.Mob
                                      });
            FormGridManager = new GridManager();
            FormGridManager.Attach(employeeGC);

            LookupManager.AccountGroup(dbContext, employeeGV, colGroupId, DB.BaseTypeEnum.Employee);
            LookupManager.Bank(dbContext, employeeGV, colBankId, LookupSuspendedWhereEnum.NonSuspended);
            LookupManager.CountryGrdLookup(dbContext, employeeGV, colCountryId);
            LookupManager.CitiesGrdLookup(dbContext, employeeGV, colCityId);
            employeeBindingSource.DataSource = dbContext.Employees.Local;
            RefreshData();

        }
        public override void RefreshData()
        {
            dbContext.Employees.Load();
            base.RefreshData();

        }
    }
}
