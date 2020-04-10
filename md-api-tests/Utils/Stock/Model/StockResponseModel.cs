using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace md_api_tests.Utils.Stock.Model
{
    public class StockResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMain { get; set; }
        public int StockType { get; set; }
        public int SubcontoId { get; set; }
    }
}
