using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour {

    public static int ScoreValue = 0;
    public int ScoreForNetLevel;
    public Animator transitionAnim;


    Text score;

	void Start () {
        score = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
        score.text = "Score: " + ScoreValue;
        if(ScoreValue >= ScoreForNetLevel )
        {
            ScoreValue = 0;
            StartCoroutine(LoadScene());
            
            LifeScript.LifeValue = 3;
        }
      
	}

    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
