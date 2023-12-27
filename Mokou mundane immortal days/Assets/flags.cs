using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flags : MonoBehaviour
{
    public bool Menu_flag = false;
    public bool Talking_flag = false;
    public bool Option_flag = false;

    public GameObject MokouBubble;


    // Start is called before the first frame update
    void Start()
    {

        talkState();
        MokouBubble.SetActive(true);
        Menu_flag = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void talkState() {
        Talking_flag = true;

    }
}
