using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour
{

    //public static SceneChanger instance = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
    */

    public void ChangeScene()
    {

        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Demo")
        {
            SceneManager.LoadScene("Play");
        }
        if (scene.name == "Play")
        {
            SceneManager.LoadScene("Demo");
        }
    }

}
