using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteCvp.Application.Framework
{
    public class SelectResult<T> : BaseResult

    {
        public IEnumerable<T> Rows { get; set; } = new List<T>();
    }
}
