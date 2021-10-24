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

            foreach (var typ in types.Where(x => !string.IsNullOrEmpty(x.Namespace) && x.Namespace.StartsWith("B_PowerWin.DB")))
            {
                var instance = Activator.CreateInstance(typ);

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
