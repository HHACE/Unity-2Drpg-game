using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction_Box : MonoBehaviour
{
    public flags flag;
    public chatbubble_NPC kaguyaBubble;

    public GameObject GkaguyaBubble;

    public bool trigger = false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger && flag.Talking_flag == false)
        {

            if (Input.GetKeyDown(KeyCode.Z))
            {
                
                Dia_kaguya();
                GkaguyaBubble.SetActive(true);
                flag.Talking_flag = true;
            }
        }




    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        trigger = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        trigger = false;

    }


    void Dia_kaguya()
    {
        kaguyaBubble.lines2.Add("oh my my, how many year have it been?");
        kaguyaBubble.lines2.Add("that doesn't matter now does is");
        kaguyaBubble.lines2.Add("come for another fight today Mokou?");
        kaguyaBubble.lines2.Add("");
        kaguyaBubble.Talk_kaguya = true;
    }


}
