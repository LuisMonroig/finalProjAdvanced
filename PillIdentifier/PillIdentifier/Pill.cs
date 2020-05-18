using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Filename: Pill.cs
* Author: Ricardo J. Ramirez Santiago
* Description: describes the information of a pill
* History:
*           5/10/2020 - File created and class attributes defined. RRS
*           5/18/2020 - added properties for all attributes and added photo attribute. RRS
*/

namespace PillIdentifier
{
    public class Pill: IPill
    {
        private string imprint;
        private string color;
        private string shape;
        private string drugName;
        private string drugStrength;
        private string photo;
        private string creationTimestamp;

        public Pill(string imprint, string color, string shape, string drugName, string drugStrength, string photo, string creationTimestamp)
        {
            this.Imprint = imprint;
            this.Color = color;
            this.Shape = shape;
            this.DrugName = drugName;
            this.DrugStrength = drugStrength;
            this.Photo = photo;
            this.CreationTimestamp = creationTimestamp;
        }

        public string Imprint { get => imprint; set => imprint = value; }
        public string Color { get => color; set => color = value; }
        public string Shape { get => shape; set => shape = value; }
        public string DrugName { get => drugName; set => drugName = value; }
        public string DrugStrength { get => drugStrength; set => drugStrength = value; }
        public string Photo { get => photo; set => photo = value; }
        public string CreationTimestamp { get => creationTimestamp; set => creationTimestamp = value; }
    }
}
