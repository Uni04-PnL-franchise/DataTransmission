﻿using DataTransmission.Data;
using DataTransmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*BrandDAO brandDAO = new BrandDAO();
            brandDAO.ReadBrand();*/

            StoreDAO storeDAO = new StoreDAO();
            storeDAO.ReadStore();
        }
    }
}
