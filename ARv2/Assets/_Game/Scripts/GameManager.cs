using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    private int turn = 0;
    [SerializeField]
    private Transform player1BulletSpawnPoint;
    [SerializeField]
    private Transform player2BulletSpawnPoint;
    [SerializeField]
    private GameObject player1Bullet;
    [SerializeField]
    private GameObject player2Bullet;

    public Slider player1Slider;
    public Slider player2Slider;

    public float player1Speed = 50;

    public float player2Speed = 50;


    // Use this for initialization
    void Start () {
        player1Slider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        player2Slider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void ValueChangeCheck()
    {
        player1Speed = player1Slider.value;
        player2Speed = player2Slider.value;

    }


    public void player1Attack()
    {
        if (turn % 2 == 0)
        {
            //Player1 attacks
            GameObject bullet = Instantiate(player1Bullet, player1BulletSpawnPoint.position, player1BulletSpawnPoint.rotation) as GameObject;
            bullet.GetComponent<Rigidbody>().AddRelativeForce(transform.forward * player1Speed);

            turn++;
        }
                
    }

    public void player2Attack()
    {
        if (turn % 2 != 0)
        {
            //Player2 attacks
            GameObject bullet = Instantiate(player2Bullet, player2BulletSpawnPoint.position, player2BulletSpawnPoint.rotation) as GameObject;
            bullet.GetComponent<Rigidbody>().AddRelativeForce(transform.forward * player2Speed);
            

            turn++;
        }
    }
}
