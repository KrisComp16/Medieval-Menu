using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButton : MonoBehaviour
{

    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        Button.GetComponent<Button>().Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
