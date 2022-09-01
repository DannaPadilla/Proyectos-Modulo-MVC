using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Models
{
    internal abstract class Entity
    {
        public string Id { get; protected set; }
    }
}
