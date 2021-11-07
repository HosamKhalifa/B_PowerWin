using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace B_PowerWin.DB
{
    public  class SeedDatabase
    {
        public static void SeedUsers(AppDbContext _db)
        {
            _db.SecPrincipalUsers.AddOrUpdate(new SecPrincipalUser() { UserKey = 1001, PrincipalId = "root", PrincipalName = "Application administrator", Pwd = Cryptography.Encrypt("OpenYourMind"), DefaultCompany = 1, EffectiveFrom = DateTime.Today.Date, EffectiveTo = DateTime.Today.AddYears(30) });
        }
        public static void SeedAccessType(AppDbContext context)
        {
            context.SecAccessTypes.AddOrUpdate(new SecAccessType() { AccessType = 2100,AccessTypeName  = "Query", AccessTypeDescription = "User can see all journal rows", AccessTypeType = SecAccessTypeTypeEnum.Journal, AllowRead = NoYesEnum.Yes, AllowCreate = NoYesEnum.No, AllowRemove = NoYesEnum.No, AllowApprove = NoYesEnum.No, AllowReject = NoYesEnum.No, AllowPost = NoYesEnum.No, AllowUnpost = NoYesEnum.No });
            context.SecAccessTypes.AddOrUpdate(new SecAccessType() { AccessType = 2110, AccessTypeName = "Create", AccessTypeDescription = "User can create new entry also update and delete entries created by him", AccessTypeType = SecAccessTypeTypeEnum.Journal, AllowRead = NoYesEnum.Yes, AllowCreate = NoYesEnum.Yes, AllowRemove = NoYesEnum.No, AllowApprove = NoYesEnum.No, AllowReject = NoYesEnum.No, AllowPost = NoYesEnum.No, AllowUnpost = NoYesEnum.No });
            context.SecAccessTypes.AddOrUpdate(new SecAccessType() { AccessType = 2120, AccessTypeName = "ApproveReject", AccessTypeDescription = "User can approve & reject entry for current journal", AccessTypeType = SecAccessTypeTypeEnum.Journal, AllowRead = NoYesEnum.Yes, AllowCreate = NoYesEnum.No, AllowRemove = NoYesEnum.No, AllowApprove = NoYesEnum.Yes, AllowReject = NoYesEnum.Yes, AllowPost = NoYesEnum.No, AllowUnpost = NoYesEnum.No });
            context.SecAccessTypes.AddOrUpdate(new SecAccessType() { AccessType = 2130, AccessTypeName = "Post", AccessTypeDescription = "User who can post ", AccessTypeType = SecAccessTypeTypeEnum.Journal, AllowRead = NoYesEnum.Yes, AllowCreate = NoYesEnum.No, AllowRemove = NoYesEnum.No, AllowApprove = NoYesEnum.No, AllowReject = NoYesEnum.No, AllowPost = NoYesEnum.Yes, AllowUnpost = NoYesEnum.No });
            context.SecAccessTypes.AddOrUpdate(new SecAccessType() { AccessType = 2135, AccessTypeName = "Unpost", AccessTypeDescription = "User can unpost posted document", AccessTypeType = SecAccessTypeTypeEnum.Journal, AllowRead = NoYesEnum.Yes, AllowCreate = NoYesEnum.No, AllowRemove = NoYesEnum.No, AllowApprove = NoYesEnum.No, AllowReject = NoYesEnum.No, AllowPost = NoYesEnum.No, AllowUnpost = NoYesEnum.Yes });
            context.SecAccessTypes.AddOrUpdate(new SecAccessType() { AccessType = 2140, AccessTypeName = "CreateApproveReject", AccessTypeDescription = "User can create ,approve and reject", AccessTypeType = SecAccessTypeTypeEnum.Journal, AllowRead = NoYesEnum.Yes, AllowCreate = NoYesEnum.Yes, AllowRemove = NoYesEnum.No, AllowApprove = NoYesEnum.Yes, AllowReject = NoYesEnum.Yes, AllowPost = NoYesEnum.No, AllowUnpost = NoYesEnum.No });
            context.SecAccessTypes.AddOrUpdate(new SecAccessType() { AccessType = 2142, AccessTypeName = "CreateRemoveApproveReject", AccessTypeDescription = "User can create ,delete,approve and reject", AccessTypeType = SecAccessTypeTypeEnum.Journal, AllowRead = NoYesEnum.Yes, AllowCreate = NoYesEnum.Yes, AllowRemove = NoYesEnum.Yes, AllowApprove = NoYesEnum.Yes, AllowReject = NoYesEnum.Yes, AllowPost = NoYesEnum.No, AllowUnpost = NoYesEnum.No });
            context.SecAccessTypes.AddOrUpdate(new SecAccessType() { AccessType = 2144, AccessTypeName = "ApproveRejectPost", AccessTypeDescription = "User can approve , reject,post ", AccessTypeType = SecAccessTypeTypeEnum.Journal, AllowRead = NoYesEnum.Yes, AllowCreate = NoYesEnum.No, AllowRemove = NoYesEnum.No, AllowApprove = NoYesEnum.Yes, AllowReject = NoYesEnum.Yes, AllowPost = NoYesEnum.Yes, AllowUnpost = NoYesEnum.No });
            context.SecAccessTypes.AddOrUpdate(new SecAccessType() { AccessType = 2150, AccessTypeName = "CreateApproveRejectPost", AccessTypeDescription = "Create approve, reject and post", AccessTypeType = SecAccessTypeTypeEnum.Journal, AllowRead = NoYesEnum.Yes, AllowCreate = NoYesEnum.Yes, AllowRemove = NoYesEnum.Yes, AllowApprove = NoYesEnum.Yes, AllowReject = NoYesEnum.Yes, AllowPost = NoYesEnum.Yes, AllowUnpost = NoYesEnum.No });
            context.SecAccessTypes.AddOrUpdate(new SecAccessType() { AccessType = 2155, AccessTypeName = "FullAccess", AccessTypeDescription = "Full access", AccessTypeType = SecAccessTypeTypeEnum.Journal, AllowRead = NoYesEnum.Yes, AllowCreate = NoYesEnum.Yes, AllowRemove = NoYesEnum.Yes, AllowApprove = NoYesEnum.Yes, AllowReject = NoYesEnum.Yes, AllowPost = NoYesEnum.Yes, AllowUnpost = NoYesEnum.Yes });

            context.SecAccessTypes.AddOrUpdate(new SecAccessType() { AccessType = 2200, AccessTypeName = "Query", AccessTypeDescription = "User will see object", AccessTypeType = SecAccessTypeTypeEnum.Master, AllowRead = NoYesEnum.Yes, AllowCreate = NoYesEnum.No, AllowRemove = NoYesEnum.No, AllowApprove = NoYesEnum.No, AllowReject = NoYesEnum.No, AllowPost = NoYesEnum.No, AllowUnpost = NoYesEnum.No });
            context.SecAccessTypes.AddOrUpdate(new SecAccessType() { AccessType = 2210, AccessTypeName = "Create", AccessTypeDescription = "Create object", AccessTypeType = SecAccessTypeTypeEnum.Master, AllowRead = NoYesEnum.Yes, AllowCreate = NoYesEnum.Yes, AllowRemove = NoYesEnum.Yes, AllowApprove = NoYesEnum.No, AllowReject = NoYesEnum.No, AllowPost = NoYesEnum.No, AllowUnpost = NoYesEnum.No });
            context.SecAccessTypes.AddOrUpdate(new SecAccessType() { AccessType = 2215, AccessTypeName = "ApproveReopen", AccessTypeDescription = "Approve reopen object", AccessTypeType = SecAccessTypeTypeEnum.Journal, AllowRead = NoYesEnum.Yes, AllowCreate = NoYesEnum.No, AllowRemove = NoYesEnum.No, AllowApprove = NoYesEnum.Yes, AllowReopen = NoYesEnum.Yes, AllowPost = NoYesEnum.No, AllowUnpost = NoYesEnum.No });
            context.SecAccessTypes.AddOrUpdate(new SecAccessType() { AccessType = 2217, AccessTypeName = "CreateApproveReopen", AccessTypeDescription = "Create approve reopen", AccessTypeType = SecAccessTypeTypeEnum.Master, AllowRead = NoYesEnum.Yes, AllowCreate = NoYesEnum.Yes, AllowRemove = NoYesEnum.Yes, AllowApprove = NoYesEnum.No,AllowReopen=NoYesEnum.Yes, AllowReject = NoYesEnum.No, AllowPost = NoYesEnum.No, AllowUnpost = NoYesEnum.No });

            context.SecAccessTypes.AddOrUpdate(new SecAccessType() { AccessType = 2430 , AccessTypeName = "ViewMenu", AccessTypeDescription = "View module menu", AccessTypeType = SecAccessTypeTypeEnum.Menu, AllowRead = NoYesEnum.Yes, AllowCreate = NoYesEnum.No, AllowRemove = NoYesEnum.No, AllowApprove = NoYesEnum.No, AllowReject = NoYesEnum.No, AllowPost = NoYesEnum.No, AllowUnpost = NoYesEnum.No });
            context.SecAccessTypes.AddOrUpdate(new SecAccessType() { AccessType = 2420, AccessTypeName = "OpenForm", AccessTypeDescription = "Open form", AccessTypeType = SecAccessTypeTypeEnum.SysDisplayForm, AllowRead = NoYesEnum.Yes, AllowCreate = NoYesEnum.No, AllowRemove = NoYesEnum.No, AllowApprove = NoYesEnum.No, AllowReject = NoYesEnum.No, AllowPost = NoYesEnum.No, AllowUnpost = NoYesEnum.No });
            context.SecAccessTypes.AddOrUpdate(new SecAccessType() { AccessType = 2410, AccessTypeName = "PrintReport", AccessTypeDescription = "Print report", AccessTypeType = SecAccessTypeTypeEnum.SysOutputReport, AllowRead = NoYesEnum.Yes, AllowCreate = NoYesEnum.No, AllowRemove = NoYesEnum.No, AllowApprove = NoYesEnum.No, AllowReject = NoYesEnum.No, AllowPost = NoYesEnum.No, AllowUnpost = NoYesEnum.No });
            context.SecAccessTypes.AddOrUpdate(new SecAccessType() { AccessType = 2400, AccessTypeName = "Run", AccessTypeDescription = "Run action ", AccessTypeType = SecAccessTypeTypeEnum.SysAction, AllowRead = NoYesEnum.Yes, AllowCreate = NoYesEnum.No, AllowRemove = NoYesEnum.No, AllowApprove = NoYesEnum.No, AllowReject = NoYesEnum.No, AllowPost = NoYesEnum.No, AllowUnpost = NoYesEnum.No });
            context.SaveChanges();

        }
        public static void SeedUILabels(AppDbContext context)
        {
            var objCntxt = ((IObjectContextAdapter)context).ObjectContext;
            var tables = Enum.GetValues(typeof(BaseTypeEnum));
            foreach (var item in tables)
            {
                context.BaseTypes.AddOrUpdate(new BaseType() {
                    BaseTypeId = (int)item,
                    BaseTypeName = Enum.GetName(typeof(BaseTypeEnum), item),
                    RecordTypeType = BaseTypeTypeEnum.GenericLine
                });
            }
            Assembly asm = Assembly.GetCallingAssembly();
            var types = asm
                            .GetTypes();
                          //  .Where(t => t.Namespace.StartsWith("B_PowerWin.DB"));

            foreach (var typ in types.Where(x => !string.IsNullOrEmpty(x.Namespace) &&
                                                 x.Namespace == "B_PowerWin.DB" &&
                                                 x.IsClass 
                                                 ))
            {
                var instance = Activator.CreateInstance(typ);
                //Call BuildMetaData
                MethodInfo buildMetaData = typ.GetMethod("BuildMetaData");
                if(buildMetaData != null)
                {
                    buildMetaData.Invoke(instance, new object[] { context });
                }
                //Get Class type enum
                
                MethodInfo theMethod = typ.GetMethod("GetBaseTypeEnum");
                if (theMethod == null) { continue; }
                var result = theMethod.Invoke(instance,new object[] { });
                if ((BaseTypeEnum)result == BaseTypeEnum.None) { continue; }
                var classType =  (BaseTypeEnum)result;
                    var baseTypeRecord = context.BaseTypes.Find((int)classType);
                    var fields = typ.GetProperties().Where(x => x.CanRead && x.CanWrite);
                    foreach (var f in fields)
                    {
                    try
                    {
                        var newLine = context.UILabels.Find($"{baseTypeRecord.BaseTypeName}.{f.Name}");
                        if(newLine != null) {continue; }//Existed 
                        var newUILbl = new UILabel()
                        {
                            BaseType = baseTypeRecord,
                            LabelId = $"{baseTypeRecord.BaseTypeName}.{f.Name}",
                            FieldName = f.Name,
                            Grid_Width = 30,
                            Grid_IsDisabled = false,
                            Grid_VisibleOrder = 0
                        };
                        context.UILabels.AddOrUpdate(newUILbl);
                        context.SaveChanges();
                        SeedUILabelLangTxt(context, newUILbl);

                    }
                    catch 
                    {
                        
                    }
                }
                
            }

           

        }

        public static void SeedUILabelLangTxt(AppDbContext context,UILabel _Label)
        {
            //Add Lang lines 
            var lblTypes = Enum.GetValues(typeof(UILabelType));
            foreach (var item in lblTypes)
            {
                var ar_lang = new UILabelLangTxt()
                {
                    LabelId = _Label.LabelId,
                    LabelType = (UILabelType)item,
                    LangId = "ar-EG",
                    Txt = _Label.FieldName

                };

                context.UILabelTxts.AddOrUpdate(ar_lang);
                context.SaveChanges();
                var en_lang = new UILabelLangTxt()
                {
                    LabelId = _Label.LabelId,
                    LabelType = (UILabelType)item,
                    LangId = "en-US",
                    Txt = _Label.FieldName

                };
                context.UILabelTxts.AddOrUpdate(en_lang);
                context.SaveChanges();
                ar_lang = null;
                en_lang = null;
            }
        }

        public static void SeedEnumTable(AppDbContext context)
        {
            string enumName = "";
            Assembly asm = Assembly.GetCallingAssembly();
            var types = asm
                            .GetTypes();
            foreach (var typ in types.Where(x => x.IsEnum && !string.IsNullOrEmpty(x.Namespace) && x.Namespace.StartsWith("B_PowerWin.DB") ))
            {
                enumName = typ.Name;
                foreach (var item in Enum.GetValues(typ))
                {
                    var valueName = Enum.GetName(typ, item);
                    var value = Enum.Parse(typ, valueName);
                   
                   
                    context.EnumTables.AddOrUpdate(new EnumTable() { SysName = enumName, ValueId = (int)value, ValueName = valueName });
                    context.SaveChanges();
                }
            }
        }
    }
}
