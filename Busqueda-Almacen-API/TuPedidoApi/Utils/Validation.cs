using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuPedidoApi.Utils
{
    public class Validation
    {
        public bool ValidateDataCount(int count)
        {
            var restrictedValue = 0;
            var IsValid = count> restrictedValue;
            return IsValid;
        }

        public bool IsNotNull(Object parameterFromDatabase)
        {
            var IsValid = parameterFromDatabase != null;
            return IsValid;
        }
    }
}
