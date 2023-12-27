using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rando_Interaction_Box : MonoBehaviour
{
    public flags flag;
    public chatbubble_NPC randoBubble;

    public GameObject GrandoBubble;

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

                Dia_rando();
                GrandoBubble.SetActive(true);
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


    void Dia_rando()
    {
        randoBubble.lines2.Add("oh dear oh me, i am lost!");
        randoBubble.lines2.Add("can you please help me mistress?");
        randoBubble.lines2.Add("");
    }

}
