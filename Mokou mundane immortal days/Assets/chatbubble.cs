using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class chatbubble : MonoBehaviour
{
    //public SpriteRenderer Bubble;
    public TextMeshPro textMesh;

    //public GameObject hostbubble;

    //public string[] lines;

    public flags flag;


    public List<string> lines = new List<string>();

    public int lineIndex = 0;

    // Start is called before the first frame update
    void Start()
    {


        IndexReset();
        Dia_begin();
      
    }

    // Update is called once per frame
    void Update()
    {


        textMesh.SetText(lines[lineIndex]);
        textMesh.ForceMeshUpdate();
        if (Input.GetKeyDown(KeyCode.Z))
        {
            lineIndex += 1;
            if (lineIndex >= lines.Count) { 
                //hostbubble.SetActive(false);
                flag.Talking_flag = false;
                lines.Clear();
                IndexReset();
                this.gameObject.SetActive(false);
            }
        }

    }



    void IndexReset() {
        lineIndex = 0;
    }






    // Dialog
    void Dia_begin() {
        lines.Add("...");
        lines.Add("Another day, another chore");
        lines.Add("I wonder what new today...");

    }






}
