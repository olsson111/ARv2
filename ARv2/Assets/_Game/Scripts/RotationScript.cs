using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {

    float y;



    private void Start()
    {
        y = Random.Range(-50, 50);
        transform.rotation = Quaternion.Euler(0, y, 0);
    }






    public void RotateRight()
    {

        y += Time.deltaTime * 200;
        transform.rotation = Quaternion.Euler(0, y, 0);

    }

    public void RotateLeft()
    {

        y += Time.deltaTime * -200;
        transform.rotation = Quaternion.Euler(0, y, 0);

    }
}
