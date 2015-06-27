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

        //This is the 2 letter code
        public string Code2 { get; set; }

        public string Name { get; set; }
    }
}