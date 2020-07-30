using System.Collections;
using System.Collections.Generic;
//using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StageScript : MonoBehaviour
{
    public int StageNumber = 0;
    Text Stage;
    // Start is called before the first frame update
    void Start()
    {
        Stage = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
            Stage.text = "Stage: " + StageNumber;
        


    } 
}
