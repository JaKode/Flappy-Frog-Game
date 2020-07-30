using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackg : MonoBehaviour
{
    public GameObject Background;
    private float pozitiestart = -5.12f;
    private float addpozitie = 15.00f;
    private int contor = 0;
    private Vector3 pozitienoua = new Vector3((float)-0.15, (float)-5.15, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            if (contor % 6 == 0)
            {
                pozitiestart = pozitiestart + addpozitie;
                pozitienoua.y = pozitiestart;
                Instantiate(Background, pozitienoua, Background.transform.rotation);
            }
            contor++;
        }

    }
}
