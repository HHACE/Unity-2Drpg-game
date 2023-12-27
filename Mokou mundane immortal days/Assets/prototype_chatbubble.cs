using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class prototype_chatbubble : MonoBehaviour
{
    //public SpriteRenderer Bubble;
    public TextMeshPro textMesh;

    //public GameObject hostbubble;

    //public string[] lines;

    //public flags flag;


    public List<string> lines = new List<string>();

    public int lineIndex = 0;

    // Start is called before the first frame update
    void Start()
    {


        IndexReset();
        Dia_prototype();

    }

    // Update is called once per frame
    void Update()
    {


        textMesh.SetText(lines[lineIndex]);
        textMesh.ForceMeshUpdate();
        if (Input.GetKeyDown(KeyCode.Z))
        {
            lineIndex += 1;
            if (lineIndex >= lines.Count)
            {
                //hostbubble.SetActive(false);
                //flag.Talking_flag = false;
                lines.Clear();
                IndexReset();
                this.gameObject.SetActive(false);
                SceneManager.LoadScene("startScreen");
            }
        }

    }



    void IndexReset()
    {
        lineIndex = 0;
    }






    // Dialog
    void Dia_prototype()
    {
        lines.Add("So, as the day moved forward");
        lines.Add("Fujiwara no Mokou and Kaguya Houraisan");
        lines.Add("continued fighting each other");
        lines.Add("and like all the battles they fought");
        lines.Add("they can't end one or another");
        lines.Add("from hatred revenge to meaning less fun");
        lines.Add("they continue to fight for internity");
        lines.Add("Because they are Immortal");
    }

}
