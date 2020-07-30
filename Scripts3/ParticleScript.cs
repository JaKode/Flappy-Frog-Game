using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.Rendering;

public class ParticleScript : MonoBehaviour
{
    public ParticleSystem particleLauncher;
    public GameObject frog;
    private int ok = 0;
    // Start is called before the first frame update
    void Start()
    {
        particleLauncher.Stop(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (frog.activeSelf == false && ok == 0)
        { particleLauncher.Stop(false);
            particleLauncher.Play(true);
            ok = 1;
        }    
    }
}
