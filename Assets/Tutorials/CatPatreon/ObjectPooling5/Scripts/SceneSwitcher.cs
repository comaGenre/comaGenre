using UnityEngine;

public class SceneSwitcher : MonoBehaviour {
	
	public void SwitchScene () {
		int nextLevel = (Application.loadedLevel + 1) % Application.levelCount;
		Application.LoadLevel(nextLevel);
	}
}