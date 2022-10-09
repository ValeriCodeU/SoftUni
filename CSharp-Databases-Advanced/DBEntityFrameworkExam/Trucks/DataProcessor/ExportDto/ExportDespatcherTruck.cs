﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Trucks.DataProcessor.ExportDto
{
    [XmlType("Truck")]

    public class ExportDespatcherTruck
    {
        [XmlElement("RegistrationNumber")]

        public string RegistrationNumber { get; set; }

        [XmlElement("Make")]

        public string Make { get; set; }
    }
}
