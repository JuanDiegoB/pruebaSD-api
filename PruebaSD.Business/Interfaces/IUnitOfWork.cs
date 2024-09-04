﻿using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSD.Business.Interfaces;

public interface IUnitOfWork
{
	Task<IDbContextTransaction> BeginTransactionAsync();

	Task SaveChangesAsync();
}
