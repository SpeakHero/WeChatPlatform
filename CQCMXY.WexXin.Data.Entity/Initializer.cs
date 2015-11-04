using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQCMXY.WeiXin.Data.Entity
{
    public class Initializer : CreateDatabaseIfNotExists<Db>
    {
        protected override void Seed(Db context)
        {
            context.Database.ExecuteSqlCommand("CREATE UNIQUE INDEX AppTokenInfoId ON AppInterfaceInfo (AppTokenInfoId)");
            context.Database.ExecuteSqlCommand("CREATE UNIQUE INDEX AppTitle ON AppTokenInfo (AppTitle)");
            context.Database.ExecuteSqlCommand("CREATE UNIQUE INDEX appID ON AppTokenInfo (appID)");
            context.Database.ExecuteSqlCommand("CREATE UNIQUE INDEX appsecret ON AppTokenInfo (appsecret)");
        }
    }
}
