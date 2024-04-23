using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;

namespace CodeFirts_EF.data
{
    public class ReadExampleInterceptor :DbCommandInterceptor
    {
        

        public override InterceptionResult<DbDataReader> ReaderExecuting(
            DbCommand command ,
            CommandEventData eventData,
            InterceptionResult<DbDataReader> result)
        {
            Console.WriteLine("=====   HERE STARS   ========");
            return base.ReaderExecuting(command , eventData, result);
        }

        public override DbDataReader ReaderExecuted(DbCommand command, CommandExecutedEventData eventData, DbDataReader result)
        {
            Console.WriteLine("=====   ENDS FINISH  ========");
            Console.WriteLine("111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111");
            return base.ReaderExecuted(command, eventData, result);
        }
    }
}
