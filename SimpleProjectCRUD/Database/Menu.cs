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
    public class Menu
    {
        public int MenuId { get; set; }
        public string MenuCode { get; set; }
        public string MenuName { get; set; }
    }
}
