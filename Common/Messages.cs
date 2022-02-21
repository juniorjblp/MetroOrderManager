using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Messages
    {
        public static Dictionary<int, string> SisMessages = new Dictionary<int, string>()
        {
            { 0, "Versão: 0.0.1" }
        };

        public static Dictionary<int, string> ScreenMessages = new Dictionary<int, string>()
        {
            { 0, "Dashboard" },
            { 1, "Clientes" },
            { 2, "Produtos" },
            { 3, "Vendas" }
        };
    }
}
