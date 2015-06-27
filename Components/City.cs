using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Christoc.Modules.DNNDAL2.Components
{

    [TableName("city")]
    //setup the primary key for table
    [PrimaryKey("ID", AutoIncrement = false)]

    //configure caching using PetaPoco
    //[Cacheable("Items", CacheItemPriority.Default, 20)]

    //scope the objects to the ModuleId of a module on a page (or copy of a module on a page)
    [Scope("ModuleId")]
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string District { get; set; }
        public int Population { get; set; }
    }
}