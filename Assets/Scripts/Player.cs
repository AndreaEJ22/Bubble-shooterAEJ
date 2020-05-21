using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string shooter1;
    private object physics;
    private object hit;

    // Start is called before the first frame update
    void Start()
    {
        //shooter position
        if (Input.GetButtonDown(shooter1))
          {
            Ray ray1 = Camera.main.screenPointToRay(Input.mousePosition);
            if (physics.Raycast(ray1, out hit, Mathf.Infinity))
            {
                GameObject selectBubbleGO = hit.transform.gameObject;
                int column = int.Parse(selectBubbleGO.name.Split(‘-’)[0]);
                int row = int.Parse(selectBubbleGO.name.Split(‘-’)[1]);

                Bubble selectedBubble = BubblesArray[column, row];
            }
        }



        //expecting user to tap a bubble
        if (!AreBubbleSelected)
        {
            if (selectedBubble != null)
            {
                SelectedBubbles = new List<Bubble>();
                MarkBubbles(selectedBubbles, colum, row, selectedBubble.GameObject.tag);
                if (selectedBubbles.count < minBubblesToRemove)
                {
                    foreach (Bubble el in SelectedBubbles)
                        el.gameObject.transform.renderer.material = el.origianBubbleMaterial;
                    return;
                }
                AreBubblesSelected = true;
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
