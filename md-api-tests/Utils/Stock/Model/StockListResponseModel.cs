using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace md_api_tests.Utils.Stock.Model
{
    public class StockListResponseModel
    {
        public List<StockResponseModel> ResourceList { get; set; }
        public List<object> _links { get; set; }
        public List<object> _embedded { get; set; }
    }
}
