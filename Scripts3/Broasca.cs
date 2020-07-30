using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Broasca : MonoBehaviour
{
    // Start is called before the first frame update
  //  private float jump = 1.79f;
  //  private float right = 1.6f;
  //  private float left = -1.78f;
  // private float mid = 0;
  private float position;
    public GameObject TimesUp;
    public GameObject Retry;
    public GameObject HighScore;
    public GameObject ReclamaButton;
    public GameObject Particles;
    public AudioClip jumpsound;
    private AudioSource PlayerAudio;
    private Rigidbody2D rb;
    GameObject TimpScript; 
    void Start()
    {
        transform.GetComponent<Rigidbody2D>();
        PlayerAudio = GetComponent<AudioSource>();
        Retry.SetActive(false);
        TimesUp.SetActive(false);
        HighScore.SetActive(false);
        ReclamaButton.SetActive(false);
        TimpScript = GameObject.FindGameObjectWithTag("timer");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            PlayerAudio.PlayOneShot(jumpsound, 0.5f);
        }
    }
        
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeadZone")
        {
            // Destroy(gameObject);
            collision.gameObject.transform.tag = "Finish";
            gameObject.SetActive(false);
            TimesUp.SetActive(true);
            Retry.SetActive(true);
            HighScore.SetActive(true);
            if (ReclamaButton != null)
            ReclamaButton.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "timp")
        {
            TimpScript.GetComponent<TimerScript>().timeLeft += TimpScript.GetComponent<TimerScript>().TimerAdd * 4;
            Destroy(collision.gameObject);
        }
    }

}
