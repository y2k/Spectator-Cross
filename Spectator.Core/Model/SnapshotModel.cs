﻿using System;
using Spectator.Core.Model.Database;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Spectator.Core.Model
{
	public class SnapshotModel
	{
		public SnapshotModel (int id)
		{
			//
		}

		public Task Reload()
		{
			throw new NotImplementedException ();
		}

		public Task<Snapshot> Get ()
		{
			throw new NotImplementedException ();
		}

		public Task<IEnumerable<Attachment>> GetAttachments ()
		{
			throw new NotImplementedException ();
		}
	}
}