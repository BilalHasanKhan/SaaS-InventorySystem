﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Inventory.Common.Models;

namespace OpenQbit.Inventory.BLL.BusinessService.Contr
{
    public interface IDistributerManager
    {
        bool RecordDistributer(Distributer distributer);
    }
}
