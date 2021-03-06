﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepoZ.Api.Git;

namespace RepoZ.Api.Common.Git
{
	public class DefaultRepositoryObserverFactory : IRepositoryObserverFactory
	{
		public IRepositoryObserver Create() => new DefaultRepositoryObserver();
	}
}
