﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using OpenQbit.Inventory.Service.WebApi.Models.Api;
using OpenQbit.Inventory.BLL.BusinessService.Contr;
using OpenQbit.Inventory.Common.Ioc;
using OpenQbit.Inventory.Common.Models;

namespace OpenQbit.Inventory.Service.WebApi.Controllers.Api
{
    public class ApiDamageController : ApiController
    {
        public ApiDamage Get(int ID)
        {
            IDamageManager damageManager = UnityResolver.Resolve<IDamageManager>();
            Damage damageModel = damageManager.FindDamageByID(ID);
            ApiDamage damage = new ApiDamage
            {
                ID = damageModel.ID,
                Description = damageModel.Description,
                Qty = damageModel.Qty,
                BatchID = damageModel.BatchID,
                CustomerID = damageModel.CustomerID
            };

            return damage;
        }

        
        public List<ApiDamage> GetList()
        {

            IDamageManager damageManager = UnityResolver.Resolve<IDamageManager>();
            List<ApiDamage> damageList = new List<ApiDamage>();
            List<Damage> damageModelList = damageManager.getAllDamages();

            foreach(Damage damageModel in damageModelList)
            {
                ApiDamage damage = new ApiDamage
                {
                    ID = damageModel.ID,
                    Description = damageModel.Description,
                    Qty = damageModel.Qty,
                    BatchID = damageModel.BatchID,
                    CustomerID = damageModel.CustomerID
                };

                damageList.Add(damage);
            }
            
            return damageList;
        }

        public bool Create(ApiDamage apiDamage)
        {
            IDamageManager damageManager = UnityResolver.Resolve<IDamageManager>();
            Damage damage = new Damage
            {
                ID = apiDamage.ID,
                Description = apiDamage.Description,
                Qty = apiDamage.Qty,
                BatchID = apiDamage.BatchID,
                CustomerID = apiDamage.CustomerID
            };

            return damageManager.RecoredDamage(damage);
        }

        public bool Delete(ApiDamage apiDamage)
        {
            IDamageManager damageManager = UnityResolver.Resolve<IDamageManager>();
            Damage damage = new Damage
            {
                ID = apiDamage.ID,
                Description = apiDamage.Description,
                Qty = apiDamage.Qty,
                BatchID = apiDamage.BatchID,
                CustomerID = apiDamage.CustomerID
            };

            return damageManager.DeleteDamage(damage);
        }

        public bool Update(ApiDamage apiDamage)
        {
            IDamageManager damageManager = UnityResolver.Resolve<IDamageManager>();
            Damage damage = new Damage
            {
                ID = apiDamage.ID,
                Description = apiDamage.Description,
                Qty = apiDamage.Qty,
                BatchID = apiDamage.BatchID,
                CustomerID = apiDamage.CustomerID
            };

            return damageManager.UpdateDamage(damage);

        }
    }
}