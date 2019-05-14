using System;

namespace Experimento
{
    internal class MySqlConnection
    {
        private string connectionstring;

        public MySqlConnection(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}