using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    class ContasModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Saldo { get; set; }

        public string FullName
        {
            get
            {
                return $"{ Id } - { Descricao }";
            }
        }
    }
}
