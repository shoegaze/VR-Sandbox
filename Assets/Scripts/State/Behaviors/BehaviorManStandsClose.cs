﻿using UnityEngine;

namespace State.Behaviors {
	public class BehaviorManStandsClose : StateBehavior {
		public override GameState State => GameState.ManStandsClose;
		
		public override void OnBeforeTransition(GameState from) {
			Debug.Log($"before -> {from}");
		}
		
		public override void OnAfterTransition(GameState from) {
			Debug.Log($"after -> {from}");
		}
		
		public override void OnUpdate(GameController game) {
			Debug.Log($"update: {State}");
		}
	}
}
