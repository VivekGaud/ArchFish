using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour {

    public int ScoreIncrease;
    public GameObject blood;


    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.right * 0.1f);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bullet")
        {
            ScoreScript.ScoreValue += ScoreIncrease;
            Instantiate(blood, transform.position, transform.rotation);

            Destroy(this.gameObject);

        }
        if (col.tag == "EnemyDestroy")
        {
            LifeScript.LifeValue -= 1;

            Destroy(this.gameObject);
            
        }

    }

}
