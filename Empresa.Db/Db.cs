using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Db
{
    public static class Db
    {
        public static string Conexao
        {
            get
            {
                return @"Data Source=DESKTOP-D4UQO05;Initial Catalog=Empresa;Integrated Security=True";
            }
        }
    }
}
