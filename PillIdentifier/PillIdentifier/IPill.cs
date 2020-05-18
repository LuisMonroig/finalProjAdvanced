using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
* Filename: IPill.cs
* Author: Ricardo J. Ramirez Santiago
* Description: interface class for a pill
* History:
*           5/10/2020 - File created and interface defined. RRS
*           5/17/2020 - Added properties to the interface. RRS
*           5/18/2020 - Added Photo property. RRS
*/

namespace PillIdentifier
{
    public interface IPill
    {
        string Imprint { get; set; }
        string Color { get; set; }
        string Shape { get; set; }
        string DrugName { get; set; }
        string DrugStrength { get; set; }
        string CreationTimestamp { get; set; }
        string Photo { get; set; }
    }
}
