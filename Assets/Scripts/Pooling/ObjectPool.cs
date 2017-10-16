using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool {

	private Queue<Poolable> pool = new Queue<Poolable>();

	private Poolable prefab;

	public ObjectPool(Poolable prefab) {
		this.prefab = prefab;
	}

	public Poolable GetObject() {
		Poolable obj;
		if (pool.Count == 0) {
			obj = GameObject.Instantiate<Poolable> (prefab);
			obj.name = prefab.name;
		} else {
			obj = pool.Dequeue ();
			obj.OnUnpool ();
		}
		return obj;
	}

	public bool PoolObject(Poolable obj) {
		if (obj.name != prefab.name) {
			return false;
		}
		pool.Enqueue (obj);
		obj.OnPool ();
		return true;
	}
}
