using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictinaryApp
{
    class Employees
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Employees(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
