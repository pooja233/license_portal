using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LicensePortal_APPAPI.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public string PrdName { get; set; }
        public string PrdDesc { get; set; }
        public string ProductCode { get; set; }
        public string PrdVersion { get; set; }
    }
}
