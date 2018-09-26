using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BdeBInterfaceContracts.Models
{
    public interface IHasCreationDate
    {
        DateTime Creation { get; set; }
    }
}