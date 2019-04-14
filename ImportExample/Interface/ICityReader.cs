using System;
using System.Collections.Generic;
using System.Text;

namespace ImportExample.Interface
{
    public interface ICityReader
    {
        List<CityItem> Read();
    }
}
