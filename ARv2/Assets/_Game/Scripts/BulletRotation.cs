using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRotation : MonoBehaviour {

    public float y;
	
	// Update is called once per frame
	void Update () {
        y += Time.deltaTime * 1000;
        transform.rotation = Quaternion.Euler(0, y, 0);
    }
}
