﻿using Android.App;
using Android.Content;
using Android.OS;
using Spectator.Android.Application.Activity.Common.Base;

namespace Spectator.Android.Application.Activity.Snapshots
{
	[Activity (Label = "@string/snapshot")]
	public class SnapshotActivity : BaseActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			if (savedInstanceState == null)
				SwitchToInfo ();
		}

		public static Intent NewIntent (int snapshotId)
		{
			return new Intent (App.Current, typeof(SnapshotActivity)).PutExtra ("id", snapshotId);
		}

		public void SwitchToWeb ()
		{
			SetContentFragment (new WebSnapshotFragment { Arguments = Intent.Extras });
		}

		public void SwitchToInfo ()
		{
			SetContentFragment (new ContentSnapshotFragment { Arguments = Intent.Extras });
		}
	}
}