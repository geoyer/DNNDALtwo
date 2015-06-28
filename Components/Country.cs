using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Required for Table Identification;
using DotNetNuke.ComponentModel.DataAnnotations;


namespace Christoc.Modules.DNNDAL2.Components
{

    [TableName("country")]
    //setup the primary key for table
    [PrimaryKey("Code", AutoIncrement = false)]
    
    //configure caching using PetaPoco
    //[Cacheable("Items", CacheItemPriority.Default, 20)]
    
    //scope the objects to the ModuleId of a module on a page (or copy of a module on a page)
    [Scope("ModuleId")]

    public class Country
    {
        public string Code { get; set; }
        public string Code2 { get; set; } //This is the 2 letter code

        public string Name { get; set; }
        public string Continent { get; set; }
        public string Region { get; set; }
        public decimal SurfaceArea { get; set; }
        public short? IndepYear { get; set; }
        public int Population { get; set; }
        public decimal? LifeExpectancy { get; set; }
        public decimal? GNP { get; set; }
        public decimal? GNPOld { get; set; }
        public string LocalName { get; set; }
        public string GovernmentForm { get; set; }
        public string HeadOfState { get; set; }
        public int? Capital { get; set; }
    }
}