﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Models;

namespace DataAccess.Abstract
{
   public interface IAuthorDal:IEntityRepository<Author>
    {
    }
}
