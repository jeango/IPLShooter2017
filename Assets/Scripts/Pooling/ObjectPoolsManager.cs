using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolsManager : Singleton<ObjectPoolsManager> {

	private Dictionary<string, ObjectPool> pools = new Dictionary<string, ObjectPool> ();

	private ObjectPool GetPool(Poolable obj) {
		ObjectPool pool;
		if (!pools.TryGetValue (obj.name, out pool)) {
			pool = new ObjectPool (obj);
			pools.Add (obj.name, pool);
		}
		return pool;
	}

	public Poolable GetObject(Poolable obj) {
		return GetPool (obj).GetObject ();
	}

	public bool PoolObject(GameObject obj) {
		Poolable poolable = obj.GetComponent<Poolable> ();
		if (poolable)
			return GetPool (poolable).PoolObject (poolable);
		return false;
	}

}
