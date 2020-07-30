using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnPos : MonoBehaviour
{
    public GameObject Broasca;
    public GameObject Frunza;
    public GameObject Moarte;
    public GameObject Frunza1;
    public GameObject Moarte1;
    public GameObject Frunza2;
    public GameObject Timer;
    private Vector3 position = new Vector3(-1.89f, 6.45f, (float)(-0.1));
    private int i;
    private float resetposition = -1.89f;
    private float position1 = -1.89f;
    private float position2 = 0;
    private float position3 = 1.89f;
    private float position4 = -2.1f;
    private float position5 = -0.75f;
    private float position6 = 0.6f;
    private float position7 = 1.95f;

    private int prevy = 1;
    private int prevy2 = 1;
    private int prevy3 = 1;
    private int prevy4 = 1;

    private float position8 = -2.14f;
    private float position9 = -1.08f;
    private float position10 = -0.02f;
    private float position11 = 1.04f;
    private float position12 = 2.1f;
    private Vector3 timerposition = new Vector3(0 , 6.45f, (float)(-0.1));
    private int y;
    private Vector3 altapozitie1 = new Vector3(0, 6.45f, (float)(-0.1));
    private Vector3 altapozitie2 = new Vector3(0, 6.45f, (float)(-0.1));
    private Vector3 altapozitie3 = new Vector3(0, 6.45f, (float)(-0.1));
    private Vector3 altapozitie4 = new Vector3(0, 6.45f, (float)(-0.1));
    private float jump = 1.79f;
    
    private float right = 1.83f;
    private float left = -1.94f;
    private float mid = 0;

    private float midd = - 0.77f;
    private float midd2 = 0.54f;
    private float rightt = 1.9f;
    private float leftt = - 2.12f;

    private float left1 = -2.1f;
    private float left2 = -1.1f;
    private float mid1 = -0.02f;
    private float right1 = 1.03f;
    private float right2 = 2.13f;

    private Rigidbody2D rb;
    private int ok = 0;
    void Start()
    {
        transform.GetComponent<Rigidbody2D>();
     }
    void Update()
    {
        Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pz.z = -1;
        position.x = resetposition;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ok++;
            y = Random.Range(1, 4);
            if ((ok + 4) % 50 == 0)
            {
                int k = Random.Range(1, 4);
                if (k == 1) { position.x = position1; altapozitie1.x = position2; altapozitie2.x = position3; }
                if (k == 2) { position.x = position2; altapozitie1.x = position1; altapozitie2.x = position3; }
                if (k == 3) { position.x = position3; altapozitie1.x = position2; altapozitie2.x = position1; }
                Instantiate(Frunza, position, Frunza.transform.rotation);
                Instantiate(Frunza, altapozitie1, Frunza.transform.rotation);
                Instantiate(Frunza, altapozitie2, Frunza.transform.rotation);
                
            }
            else
            {
                if (y == 1 )
                {
                    int x = Random.Range(1, 4);
                    if (x == 1) { position.x = position1; altapozitie1.x = position2; altapozitie2.x = position3; }
                    if (x == 2) { position.x = position2; altapozitie1.x = position1; altapozitie2.x = position3; }
                    if (x == 3) { position.x = position3; altapozitie1.x = position2; altapozitie2.x = position1; }
                    Instantiate(Frunza, position, Frunza.transform.rotation);
                    Instantiate(Moarte, altapozitie1, Moarte.transform.rotation);
                    Instantiate(Moarte, altapozitie2, Moarte.transform.rotation);



                }

                else if (y == 2)
                {
                    int x = Random.Range(1, 5);
                    if (x == 1) { position.x = position4; altapozitie1.x = position5; altapozitie2.x = position6; altapozitie3.x = position7; }
                    if (x == 2) { position.x = position5; altapozitie1.x = position4; altapozitie2.x = position6; altapozitie3.x = position7; }
                    if (x == 3) { position.x = position6; altapozitie1.x = position5; altapozitie2.x = position4; altapozitie3.x = position7; }
                    if (x == 4) { position.x = position7; altapozitie1.x = position5; altapozitie2.x = position6; altapozitie3.x = position4; }
                    Instantiate(Frunza1, position, Frunza.transform.rotation);
                    Instantiate(Frunza2, altapozitie1, Frunza2.transform.rotation);
                    int z = Random.Range(1, 4);
                    if (z == 1)
                        Instantiate(Frunza2, altapozitie2, Frunza2.transform.rotation);
                    else
                        Instantiate(Moarte1, altapozitie2, Moarte.transform.rotation);

                    if (z == 1 || z == 2)
                            Instantiate(Frunza2, altapozitie3, Frunza2.transform.rotation);
                    else
                        Instantiate(Moarte1, altapozitie3, Moarte.transform.rotation);
                }
                else if (y == 3)
                {
                    int x = Random.Range(1, 6);
                    if (x == 1) { position.x = position8; altapozitie1.x = position9; altapozitie2.x = position12; altapozitie3.x = position11; altapozitie4.x = position10; }
                    if (x == 2) { position.x = position9; altapozitie1.x = position8; altapozitie2.x = position10; altapozitie3.x = position11; altapozitie4.x = position12; }
                    if (x == 3) { position.x = position10; altapozitie1.x = position9; altapozitie2.x = position8; altapozitie3.x = position12; altapozitie4.x = position11; }
                    if (x == 4) { position.x = position11; altapozitie1.x = position10; altapozitie2.x = position9; altapozitie3.x = position8; altapozitie4.x = position12; }
                    if (x == 5) { position.x = position12; altapozitie1.x = position11; altapozitie2.x = position10; altapozitie3.x = position9; altapozitie4.x = position8; }
                    timerposition.x = position.x;
                    int p = Random.Range(1, 13);
                    if (p == 1)
                    {
                        Instantiate(Timer, timerposition, Timer.transform.rotation);

                    }
                    Instantiate(Frunza1, position, Frunza.transform.rotation);
                    Instantiate(Frunza2, altapozitie1, Frunza2.transform.rotation);
                    Instantiate(Frunza2, altapozitie2, Frunza2.transform.rotation);
                    Instantiate(Frunza2, altapozitie3, Frunza2.transform.rotation);
                    int z = Random.Range(1, 4);
                    if (z == 1)
                        Instantiate(Frunza2, altapozitie4, Frunza2.transform.rotation);
                    else
                        Instantiate(Frunza1, altapozitie4, Frunza1.transform.rotation);
                }
            }
            if (prevy4 == 1 )
            {
                if (pz.x <= -1)
                {
                    Broasca.transform.Translate(Vector3.up * jump);
                    Broasca.transform.position = new Vector3(left, Broasca.transform.position.y, Broasca.transform.position.z);
                }
                else if (pz.x > -1 && pz.x <= 0.9)
                {
                    Broasca.transform.Translate(Vector3.up * jump);
                    Broasca.transform.position = new Vector3(mid, Broasca.transform.position.y, Broasca.transform.position.z);
                }
                else if (pz.x > 0.9)
                {
                    Broasca.transform.Translate(Vector3.up * jump);
                    Broasca.transform.position = new Vector3(right, Broasca.transform.position.y, Broasca.transform.position.z);
                }
            }
            else if (prevy4 == 2)
            {
                if (pz.x <= -1.5)
                {
                    Broasca.transform.Translate(Vector3.up * jump);
                    Broasca.transform.position = new Vector3(leftt, Broasca.transform.position.y, Broasca.transform.position.z);
                }
                else if (pz.x > -1.5 && pz.x <= -0.1)
                {
                    Broasca.transform.Translate(Vector3.up * jump);
                    Broasca.transform.position = new Vector3(midd, Broasca.transform.position.y, Broasca.transform.position.z);
                }
                else if (pz.x > -0.1 && pz.x <= 1.2)
                {
                    Broasca.transform.Translate(Vector3.up * jump);
                    Broasca.transform.position = new Vector3(midd2, Broasca.transform.position.y, Broasca.transform.position.z);
                }
                else if (pz.x > 1.2)
                {
                    Broasca.transform.Translate(Vector3.up * jump);
                    Broasca.transform.position = new Vector3(rightt, Broasca.transform.position.y, Broasca.transform.position.z);
                }
            }
            else
            {
                if (pz.x <= -1.58)
                {
                    Broasca.transform.Translate(Vector3.up * jump);
                    Broasca.transform.position = new Vector3(left1, Broasca.transform.position.y, Broasca.transform.position.z);
                }
                else if (pz.x > -1.58 && pz.x <= -0.4)
                {
                    Broasca.transform.Translate(Vector3.up * jump);
                    Broasca.transform.position = new Vector3(left2, Broasca.transform.position.y, Broasca.transform.position.z);
                }
                else if (pz.x > -0.50 && pz.x <= 0.58)
                {
                    Broasca.transform.Translate(Vector3.up * jump);
                    Broasca.transform.position = new Vector3(mid1, Broasca.transform.position.y, Broasca.transform.position.z);
                }
                else if (pz.x > 0.58 && pz.x <= 1.58)
                {
                    Broasca.transform.Translate(Vector3.up * jump);
                    Broasca.transform.position = new Vector3(right1, Broasca.transform.position.y, Broasca.transform.position.z);
                }
                else if (pz.x > 1.58)
                {
                    Broasca.transform.Translate(Vector3.up * jump);
                    Broasca.transform.position = new Vector3(right2, Broasca.transform.position.y, Broasca.transform.position.z);
                }
            }
            position.y = position.y + (float)1.79;
            altapozitie1.y = altapozitie1.y + (float)1.79;
            altapozitie2.y = altapozitie2.y + (float)1.79;
            altapozitie3.y = altapozitie3.y + (float)1.79;
            altapozitie4.y = altapozitie4.y + (float)1.79;
            timerposition.y = timerposition.y + (float)1.79;
            prevy4 = prevy3;
            prevy3 = prevy2;
            prevy2 = prevy;
            prevy = y;
            if ((ok + 4) % 50 == 0) prevy = 1;
        }
        if (Broasca.activeSelf == false)
            gameObject.SetActive(false);
    }
}
