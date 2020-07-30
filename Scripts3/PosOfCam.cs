using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class PosOfCam : MonoBehaviour
{
    public Transform target;
    public GameObject Broasca;
    private float smoothspeed = 0.125f;
    private float position;
    public AudioSource PlayerAudio;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position.y;
        PlayerAudio = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    public Vector3 offset = new Vector3(0, 3, 0);

    void LateUpdate()
    {
        if (Broasca.activeSelf != false)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
            transform.position = new Vector3(transform.position.x, smothedPosition.y, transform.position.z);
        }
        else
        {
            PlayerAudio.Pause();
        }
        }
}
