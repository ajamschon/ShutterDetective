using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestUpdated01 : MonoBehaviour  {

    [SerializeField]
     bool showObjective = false;
    [SerializeField]
    Texture objective;
    [SerializeField]
    private int collision;

    void Start()
    {
        showObjective = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && showObjective == false && collision == 0)
        showObjective = true;
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            showObjective = false;
        collision = 1;
    }
    void OnGUI()
    {
        if (showObjective == true)
            GUI.DrawTexture(new Rect(Screen.width / 1.1f, Screen.height / 6.8f, 178, 178), objective);
    }

    void Update()
    {
        if (Input.GetButton("ShowQ")&& collision == 1)
        {
            showObjective = true;
        }
         if (Input.GetButtonUp("ShowQ") && collision == 1)
        {
            showObjective = false;
        }
    }
}