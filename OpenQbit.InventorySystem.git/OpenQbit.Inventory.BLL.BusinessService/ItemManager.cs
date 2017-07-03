﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Inventory.Common.Models;
using OpenQbit.Inventory.Common.Utils.Logs;
using OpenQbit.Inventory.DAL.DataAccess.Contr;
using OpenQbit.Inventory.BLL.BusinessService.Contr;
using Microsoft.Practices.Unity;

namespace OpenQbit.Inventory.BLL.BusinessService
{
    public class ItemManager : IItemManager
    {
        private IRepository _repository;

        private ILogger _log;

        [InjectionConstructor]
        public ItemManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }

        [Dependency]
        public IRepository Repository
        {
            get { return _repository; }
            set { _repository = value; }
        }

        [Dependency]
        public ILogger logger
        {
            get { return _log; }
            set { _log = value; }
        }

        [InjectionMethod]
        public void SetRepository(IRepository repository)
        {
            _repository = repository;
        }

        public bool RecordItem(Item item)
        {
            _log.LogError("");
            return _repository.Create<Item>(item);
        }
    }
}