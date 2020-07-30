using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public int Scorul = 0;
    public Text highScore;
    public GameObject Score;
    // Start is called before the first frame update
    void Start()
    {
        highScore.text =PlayerPrefs.GetInt("HighScore", 0).ToString();
    }   

    // Update is called once per frame
    void Update()   
    {
        
       Scorul = Score.GetComponent<Score>().scoreValue;
        if (Scorul > PlayerPrefs.GetInt("HighScore", 0))
        PlayerPrefs.SetInt("HighScore", Scorul);


    }
}
