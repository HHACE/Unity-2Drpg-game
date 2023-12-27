using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chatbubble_NPC : MonoBehaviour
{
    public TextMeshPro textMesh;

    public GameObject Pick_option;
    public GameObject alert;
    public GameObject alert_rando;

    public GameObject rando;

    public flags flag;

    public Sprite OYes;
    public Sprite ONo;

    public bool tempOption=true;

    public bool Talk_kaguya = false;

    public List<string> lines2 = new List<string>();

    public int lineIndex = 0;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Talk_kaguya)
        {
            alert.SetActive(false);

            if (flag.Option_flag)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow) && tempOption == true || Input.GetKeyDown(KeyCode.RightArrow) && tempOption == true)
                {
                    tempOption = false;
                    Pick_option.GetComponent<SpriteRenderer>().sprite = ONo;
                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow) && tempOption == false || Input.GetKeyDown(KeyCode.RightArrow) && tempOption == false)
                {
                    tempOption = true;
                    Pick_option.GetComponent<SpriteRenderer>().sprite = OYes;
                }
            }

            textMesh.SetText(lines2[lineIndex]);
            textMesh.ForceMeshUpdate();
            if (Input.GetKeyDown(KeyCode.Z))
            {
                lineIndex += 1;

                if (lineIndex == 3)
                {

                    flag.Option_flag = true;
                    Pick_option.SetActive(true);

                }
                else if (lineIndex == 4)
                {
                    flag.Option_flag = false;
                    Pick_option.SetActive(false);
                    if (tempOption)
                    {
                        Dia_kaguya_Yes();
                    }
                    else
                    {
                        Dia_kaguya_No();
                    }
                }
                else
                {
                    flag.Option_flag = false;
                    Pick_option.SetActive(false);
                }


                if (lineIndex >= lines2.Count)
                {
                    flag.Talking_flag = false;
                    lineIndex = 0;
                    lines2.Clear();
                    this.gameObject.SetActive(false);
                    Talk_kaguya = false;
                    alert.SetActive(true);
                    if (tempOption)
                    {
                        SceneManager.LoadScene("prototype");
                    }
                }
            }

        }
        else {
            alert_rando.SetActive(false);

            if (flag.Option_flag)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow) && tempOption == true || Input.GetKeyDown(KeyCode.RightArrow) && tempOption == true)
                {
                    tempOption = false;
                    Pick_option.GetComponent<SpriteRenderer>().sprite = ONo;
                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow) && tempOption == false || Input.GetKeyDown(KeyCode.RightArrow) && tempOption == false)
                {
                    tempOption = true;
                    Pick_option.GetComponent<SpriteRenderer>().sprite = OYes;
                }
            }

            textMesh.SetText(lines2[lineIndex]);
            textMesh.ForceMeshUpdate();
            if (Input.GetKeyDown(KeyCode.Z))
            {
                lineIndex += 1;

                if (lineIndex == 2)
                {

                    flag.Option_flag = true;
                    Pick_option.SetActive(true);

                }
                else if (lineIndex == 3)
                {
                    flag.Option_flag = false;
                    Pick_option.SetActive(false);
                    if (tempOption)
                    {
                        Dia_lost_yes();
                    }
                    else
                    {
                        Dia_lost_no();
                    }
                }
                else
                {
                    flag.Option_flag = false;
                    Pick_option.SetActive(false);
                }


                if (lineIndex >= lines2.Count)
                {
                    flag.Talking_flag = false;
                    lineIndex = 0;
                    lines2.Clear();
                    this.gameObject.SetActive(false);
                    Talk_kaguya = false;
                    alert.SetActive(true);
                    if (tempOption)
                    {
                        Destroy(rando);
                    }
                }
            }

        }

    }



    void IndexReset()
    {
        lineIndex = 0;
    }


    void temp()
    {

        this.gameObject.SetActive(false);

    }



    // Dialog
    void Dia_kaguya()
    {
        lines2.Add("oh my my, how many year have it been?");
        lines2.Add("that doesn't matter now does is");
        lines2.Add("come for another fight today mokou?");

    }

    void Dia_kaguya_Yes()
    {
        lines2.Add("then let start, shall we");

    }
    void Dia_kaguya_No()
    {
        lines2.Add("Well, come back when you want");
        lines2.Add("We have all the time in the world");
    }

    void Dia_lost()
    {
        lines2.Add("oh dear oh me, i am lost!");
        lines2.Add("can you please help me mistress");
    }

    void Dia_lost_yes()
    {
        lines2.Add("Thank you so much!");
        lines2.Add("here take this, it not much but it help");
        lines2.Add("*give a bottle of Sake");

    }

    void Dia_lost_no()
    {
        lines2.Add("aw man");


    }

}
