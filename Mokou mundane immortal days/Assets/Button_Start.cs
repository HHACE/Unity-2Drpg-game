using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Start : MonoBehaviour
{
    public GameObject canvas;
    public GameObject player;

    public GameObject sleep;
    public GameObject bed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGameScene()
    {
        player.SetActive(true);
        sleep.SetActive(false);
        bed.SetActive(true);
        Destroy(canvas);
       

    }

}
