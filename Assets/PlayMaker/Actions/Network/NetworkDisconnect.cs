﻿// (c) Copyright HutongGames, LLC 2010-2012. All rights reserved.

#if !(UNITY_FLASH || UNITY_NACL)

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Network)]
	[Tooltip("Disconnect from the server.")]
	public class NetworkDisconnect : FsmStateAction
	{

		public override void OnEnter()
		{
			Network.Disconnect();

			Finish();
		}
	}
}

#endif