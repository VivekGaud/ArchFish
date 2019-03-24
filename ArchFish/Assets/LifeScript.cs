using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeScript : MonoBehaviour {
    public string NameOfLevel;
    public static int LifeValue = 3;
    public Animator transitionAnim;

    Text life;
    void Start () {
       life = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
       life.text = "Life: " + LifeValue;
        if(LifeValue == 0)
        {
            
            StartCoroutine(loadScene());
            ScoreScript.ScoreValue = 0;


        }
    }
    IEnumerator loadScene()
    {
        
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(NameOfLevel);
        LifeValue = 3;
        
    }
}
