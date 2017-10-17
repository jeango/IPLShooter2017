using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poolable : MonoBehaviour {

	private bool isPooled;

	private void SetPooled(bool mode) {
		gameObject.SetActive (!mode);
		isPooled = mode;
	}

	public bool TryPool() {
		if (isPooled) {
			Debug.LogWarning ("Multiple attempts to pool the same object");
			return false;
		}
		SetPooled (ObjectPoolsManager.Instance.TryPoolObject (gameObject));
		return isPooled;
	}

	public GameObject GetInstance() {
		GameObject obj = ObjectPoolsManager.Instance.GetObject (gameObject);
		obj.GetComponent<Poolable> ().SetPooled (false);
		return obj;
	}

}
