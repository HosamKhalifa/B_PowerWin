using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_PowerWin.DB;
using B_PowerWin.DB.Query;
namespace B_PowerWin.GL.UXC
{
    public static class GLDimLists
    {
        private static IEnumerable<MainAccount> mainAccountList;
        private static IEnumerable<BusinessUnit> businessUnitList;
        private static IEnumerable<Site> siteList;
        private static IEnumerable<Department> departmentList;
        private static IEnumerable<Equipment> equipmentList;
        private static IEnumerable<Project> projectList;
        private static IEnumerable<Purpose> purposeList;
        private static IEnumerable<Bank> bankList;
        private static IEnumerable<Cash> cashList;
        private static IEnumerable<Customer> custList;
        private static IEnumerable<Vendor> vendList;
        private static IEnumerable<Employee> empList;
        private static IEnumerable<Pos> pOSList;

        public static void PopulateListFromDB(DB.BaseTypeEnum _tableName)
        {
            using (var db = new AppDbContext())
            {
                switch (_tableName)
                {
                   
                    case BaseTypeEnum.MainAccount:
                        GLDimLists.mainAccountList = db.MainAccounts.AsEnumerable();
                        break;
                    case BaseTypeEnum.Customer:
                        GLDimLists.custList = db.Customers.AsEnumerable();
                        break;
                    case BaseTypeEnum.Vendor:
                        GLDimLists.vendList = db.Vendors.AsEnumerable();
                        break;
                    case BaseTypeEnum.Bank:
                        GLDimLists.bankList = db.Banks.AsEnumerable();
                        break;
                    case BaseTypeEnum.Employee:
                        GLDimLists.empList = db.Employees.AsEnumerable();
                        break;
                    case BaseTypeEnum.Pos:
                        GLDimLists.pOSList = db.Pos.AsEnumerable();
                        break;
                    case BaseTypeEnum.Cash:
                        GLDimLists.cashList = db.Cashes.AsEnumerable();
                        break;
                    case BaseTypeEnum.Purpose:
                        GLDimLists.purposeList = db.Purposes.AsEnumerable();
                        break;
                    case BaseTypeEnum.Project:
                        GLDimLists.projectList = db.Projects.AsEnumerable();
                        break;
                    case BaseTypeEnum.Equipment:
                        GLDimLists.equipmentList = db.Equipments.AsEnumerable();
                        break;
                    case BaseTypeEnum.Department:
                        GLDimLists.departmentList = db.Departments.AsEnumerable();
                        break;
                    case BaseTypeEnum.Site:
                        GLDimLists.siteList = db.Sites.AsEnumerable();
                        break;
                    case BaseTypeEnum.BusinessUnit:
                        GLDimLists.businessUnitList = db.BusinessUnits.AsEnumerable();
                        break;
                    default:
                        break;
                }
            }
        }
        public static IEnumerable<MainAccount> GetMainAccountList(bool _refreshFromDB=false)
        {
            if (GLDimLists.mainAccountList != null && !_refreshFromDB)
            {
                return GLDimLists.mainAccountList;
            }
            else
            {
                 GLDimLists.PopulateListFromDB(BaseTypeEnum.MainAccount);
                return GLDimLists.mainAccountList;
            }
           
        }
        public static IEnumerable<BusinessUnit> GetBusinessUnitList(bool _refreshFromDB = false)
        {
            if (GLDimLists.businessUnitList != null && !_refreshFromDB)
            {
                return GLDimLists.businessUnitList;
            }
            else
            {
                GLDimLists.PopulateListFromDB(BaseTypeEnum.BusinessUnit);
                return GLDimLists.businessUnitList;
            }

        }
        public static IEnumerable<Site> GetSiteList(bool _refreshFromDB = false)
        {
            if (GLDimLists.siteList != null && !_refreshFromDB)
            {
                return GLDimLists.siteList;
            }
            else
            {
                GLDimLists.PopulateListFromDB(BaseTypeEnum.Site);
                return GLDimLists.siteList;
            }

        }
        public static IEnumerable<Department> GetDepartmentList(bool _refreshFromDB = false)
        {
            if (GLDimLists.departmentList != null && !_refreshFromDB)
            {
                return GLDimLists.departmentList;
            }
            else
            {
                GLDimLists.PopulateListFromDB(BaseTypeEnum.Department);
                return GLDimLists.departmentList;
            }

        }
        public static IEnumerable<Equipment> GetEquipmentList(bool _refreshFromDB = false)
        {
            if (GLDimLists.equipmentList != null && !_refreshFromDB)
            {
                return GLDimLists.equipmentList;
            }
            else
            {
                GLDimLists.PopulateListFromDB(BaseTypeEnum.Equipment);
                return GLDimLists.equipmentList;
            }

        }
        public static IEnumerable<Project> GetProjectList(bool _refreshFromDB = false)
        {
            if (GLDimLists.projectList != null && !_refreshFromDB)
            {
                return GLDimLists.projectList;
            }
            else
            {
                GLDimLists.PopulateListFromDB(BaseTypeEnum.Project);
                return GLDimLists.projectList;
            }

        }
        public static IEnumerable<Purpose> GetPurposeList(bool _refreshFromDB = false)
        {
            if (GLDimLists.purposeList != null && !_refreshFromDB)
            {
                return GLDimLists.purposeList;
            }
            else
            {
                GLDimLists.PopulateListFromDB(BaseTypeEnum.Purpose);
                return GLDimLists.purposeList;
            }

        }
        public static IEnumerable<Bank> GetBankList(bool _refreshFromDB = false)
        {
            if (GLDimLists.bankList != null && !_refreshFromDB)
            {
                return GLDimLists.bankList;
            }
            else
            {
                GLDimLists.PopulateListFromDB(BaseTypeEnum.Bank);
                return GLDimLists.bankList;
            }

        }
        public static IEnumerable<Cash> GetCashList(bool _refreshFromDB = false)
        {
            if (GLDimLists.cashList != null && !_refreshFromDB)
            {
                return GLDimLists.cashList;
            }
            else
            {
                GLDimLists.PopulateListFromDB(BaseTypeEnum.Cash);
                return GLDimLists.cashList;
            }

        }
        public static IEnumerable<Customer> GetCustomerList(bool _refreshFromDB = false)
        {
            if (GLDimLists.custList != null && !_refreshFromDB)
            {
                return GLDimLists.custList;
            }
            else
            {
                GLDimLists.PopulateListFromDB(BaseTypeEnum.Customer);
                return GLDimLists.custList;
            }

        }
        public static IEnumerable<Vendor> GetVendorList(bool _refreshFromDB = false)
        {
            if (GLDimLists.vendList != null && !_refreshFromDB)
            {
                return GLDimLists.vendList;
            }
            else
            {
                GLDimLists.PopulateListFromDB(BaseTypeEnum.Vendor);
                return GLDimLists.vendList;
            }

        }
        public static IEnumerable<Employee> GetEmployeeList(bool _refreshFromDB = false)
        {
            if (GLDimLists.empList != null && !_refreshFromDB)
            {
                return GLDimLists.empList;
            }
            else
            {
                GLDimLists.PopulateListFromDB(BaseTypeEnum.Employee);
                return GLDimLists.empList;
            }

        }
        public static IEnumerable<Pos> GetPosList(bool _refreshFromDB = false)
        {
            if (GLDimLists.pOSList != null && !_refreshFromDB)
            {
                return GLDimLists.pOSList;
            }
            else
            {
                GLDimLists.PopulateListFromDB(BaseTypeEnum.Pos);
                return GLDimLists.pOSList;
            }

        }
    }
}
