using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SimpleProjectCRUD.Database
{
    public class MenuPrice
    {
        public int MenuPriceId { get; set; }

        public int MenuId { get; set; }

        public int Price { get; set; }
    }
}
