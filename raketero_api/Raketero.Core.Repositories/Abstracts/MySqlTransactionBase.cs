using Management.Core;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raketero.Core.Repositories
{
    public class MySqlTransactionBase : TransactionBase
    {
        MySqlTransaction _MySqlTransaction;

        public MySqlTransactionBase(MySqlTransaction transaction)
        {
            _MySqlTransaction = transaction;
        }

        protected override void Commit()
        {
            _MySqlTransaction.Commit();
            _MySqlTransaction.Connection.Close();
        }

        protected override void Rollback()
        {
            _MySqlTransaction.Rollback();
            _MySqlTransaction.Connection.Close();
        }

        protected override void Dispose()
        {
            _MySqlTransaction.Dispose();
            _MySqlTransaction = null;
        }
    }
}
