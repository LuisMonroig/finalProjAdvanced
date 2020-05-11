using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillIdentifier
{
    class Pill: IPill
    {
        private string imprint;
        private string color;
        private string shape;
        private string drugName;
        private string drugStrength;
        private DateTime creationTime;

        public Pill(string imprint, string color, string shape, string drugName, string drugStrength, DateTime creationTime)
        {
            this.imprint = imprint;
            this.color = color;
            this.shape = shape;
            this.drugName = drugName;
            this.drugStrength = drugStrength;
            this.creationTime = creationTime;
        }
    }
}
