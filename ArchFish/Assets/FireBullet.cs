using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour {
    public GameObject BulletPrefab;
    public int BulletSpeed;
    public float FireRate = 0;
    float timeToFire = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (FireRate == 0)
        {
            if (Input.GetMouseButtonUp(0))
            {
                Fire();
            }
        }
        else
        {
            if(Input.GetMouseButton(0) && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / FireRate;
                Fire();
            }
        }

    }
    void Fire()
    {
        var BulletDir = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;
        GameObject bullet = (GameObject)Instantiate(BulletPrefab, transform.position, Quaternion.identity);
        Destroy(bullet, 4f);
        bullet.GetComponent<Rigidbody2D>().AddForce(BulletDir * BulletSpeed);
    }

}
