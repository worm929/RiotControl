﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using Npgsql;

using LibOfLegends;

namespace RiotControl
{
	class RegionHandler
	{
		RegionProfile RegionProfile;
		NpgsqlConnection Database;
		RPCService RPC;

		public RegionHandler(RegionProfile regionProfile, NpgsqlConnection database)
		{
			RegionProfile = regionProfile;
			Database = database;
		}

		void Run()
		{
		}
	}
}
