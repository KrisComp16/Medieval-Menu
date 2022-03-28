using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonNoise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudio()
    {
        FindObjectOfType<AudioManager>().Play("Play Sound");
    }
}
