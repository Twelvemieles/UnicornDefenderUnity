using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mananger : MonoBehaviour {
    public int A;
    public int B;
    public int damage;
    public int RangeLife;

    public int score;
    public Text ScoreText;
	// Use this for initialization
	void Start () {
        score = 0;
        UpdateScore();
        RangeLife = 5;
	}
	
    public void AddScore (int value)
    {
        score += value;
        UpdateScore();
    }
	// Update is called once per frame
	void Update () {
		
	}
    //cambiar el rango de la vida de los asteroides
    IEnumerator AsteroidRange()
    {

        while (true)
        {
            yield return new WaitForSeconds(10);
            A += RangeLife;
            B += RangeLife;

        }
    }

    void UpdateScore()
    {
        ScoreText.text = "" + score;
    }
}
