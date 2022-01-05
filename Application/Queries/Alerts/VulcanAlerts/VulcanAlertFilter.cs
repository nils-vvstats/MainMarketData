using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Alerts.VulcanAlerts
{
    public class VulcanAlertFilter : IFilter
    {
        public bool Enabled { get; protected internal set; }
    }
}
