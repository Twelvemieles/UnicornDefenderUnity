using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mananger : MonoBehaviour {
    public int A;
    public int B;
    public int damage;
    public int RangeLife;
    public Text restartText;
    private bool gameRestart;
    public Text gameOverText;
    private bool gameOver;
    public int score;
    public Text ScoreText;
   
    

    // Use this for initialization
    void Start() {
        gameOver = false;
        gameOverText.gameObject.SetActive(false);
        gameRestart = false;
        restartText.gameObject.SetActive(false);
        score = 0;
        UpdateScore();
        RangeLife = 5;
        AsteroidRange();
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScore();
    }
    // Update is called once per frame
    void Update() {

    }
    //cambiar el rango de la vida de los asteroides
    IEnumerator AsteroidRange()
    {

        while (true)
        {
            yield return new WaitForSeconds(6);
            A += RangeLife;
            B += RangeLife;

        }
    }

    void UpdateScore()
    {
        ScoreText.text = "" + score;
    }

    public void GameOver()
    {
    gameOverText.gameObject.SetActive(true);
        gameOver = true;
    }
}
