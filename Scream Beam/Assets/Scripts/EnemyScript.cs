using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    public float moveAmount = 0.2f;
    [SerializeField]
    private Rigidbody2D Enemy;

    public bool canMove = true;
    private float timer;
    public float timerResetTime = 2;
	// Use this for initialization
	void Start () {
        timer = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (moveAmount > 0)
        {
            if (timer + timerResetTime >= Time.time)
            {
                return;
            }
            timer = Time.time + timerResetTime;

            StartCoroutine("MoveTheEnemy()");
        }
    }

    void MoveEnemy()
    {
        Enemy.AddForce(Vector3.down * moveAmount, ForceMode2D.Impulse);
        canMove = false;
        if(timer + timerResetTime >= Time.time)
            return;
        timer = Time.time + timerResetTime;
    }

    private IEnumerator MoveTheEnemy()
    {
        canMove = false;
        Enemy.AddForce(Vector3.down * moveAmount, ForceMode2D.Impulse);
        yield return new WaitForSeconds(timerResetTime);
        canMove = true;
    }
}
