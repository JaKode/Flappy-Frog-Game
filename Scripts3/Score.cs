using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public int scoreValue = 0;
    Text score;
    public GameObject Frog;
    // Start is calledbefore the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        score.text = "" + scoreValue;
        if (Input.GetKeyDown(KeyCode.Mouse0) && Frog.activeSelf != false ) 
            scoreValue++;
    }
}
