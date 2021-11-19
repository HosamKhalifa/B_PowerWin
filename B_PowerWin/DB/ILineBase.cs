using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    interface ILineBase
    {
        BaseTypeEnum GetBaseTypeEnum();
        void BuildMetaData(AppDbContext _db);

        bool IsBusinessObject();
        Exception GetLineExceptionDetails(AppDbContext _db, LineBaseCRUDEnum _CRUDType);
        bool ValidateLine(AppDbContext _db, LineBaseCRUDEnum _CRUDType);
        void OnCreate(AppDbContext _db);
        void OnUpdate(AppDbContext _db, DbEntityEntry _entryStatus);
        void OnDelete(AppDbContext _db);

    }
}
