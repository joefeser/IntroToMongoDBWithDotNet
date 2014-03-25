using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindscape.LightSpeed;

namespace Commerce.Data {

    public partial class CommerceModelUnitOfWork {

        static LightSpeedContext<CommerceModelUnitOfWork> context;
        static object lockObject = new object();

        public static CommerceModelUnitOfWork UnitOfWork() {

            if (context == null) {
                lock (lockObject) {
                    if (context == null) {
                        context = new LightSpeedContext<CommerceModelUnitOfWork>();
                        context.CascadeDeletes = false;
                        context.ConnectionString = ConfigurationManager.AppSettings["sqlConnection"];
                        context.DataProvider = DataProvider.SqlServer2012;
                        context.IdentityMethod = IdentityMethod.IdentityColumn;
                        context.UpdateBatchSize = 20;
                        //context.QuoteIdentifiers = true;
                        //context.Logger = null;
                        //context.Logger = new MindscapeLogger();
                        //context.VerboseLogging = true;
                    }
                }
            }

            return context.CreateUnitOfWork();
        }
    }

    //public class MindscapeLogger : Mindscape.LightSpeed.Logging.ILogger {

    //    static Logger logger = LogManager.GetCurrentClassLogger();

    //    public void LogDebug(object text) {
    //        logger.Debug(text);
    //    }

    //    public void LogSql(object sql) {
    //        logger.Info(sql.ToString());
    //    }

    //}
}
