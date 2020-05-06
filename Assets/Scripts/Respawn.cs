﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject Burbuja;
    public Vector3 actualCoordinate;
    // Start is called before the first frame update
    void Start()
    {
        for (int column = 0; burbuja < 12; ++burbuja)
        {
            Instantiate(Burbuja);
            actualCoordinate = Burbuja.transform.position;
            actualCoordinate.x = actualCoordinate.x++;
            Burbuja.transform.position = actualCoordinate;
            _ = Instantiate(Burbuja, new Vector3(actualCoordinate * 2.0F, 0, 0), Quaternion.identity);

        }

        //Initializes the bubble
        private void intializeBubbles()
        {
            for (int column = 0; column < BubbleColumns; column++)
            {
                for (int row = 0; row BubbleRows; row++)
               {
            MyMaterial material = MyMaterial.GetRanddomMaterial();//get a random color
                                                                  //create a new bubble
            var go = (GameObject)Instantiate(BubbleParameter, new Vector3((float)column * BubbleParameter.transforrm.localScale.x, (float)row * BubbleParameter.transform.localScale.y, 0f), Quaternion.idientity);
            go.tag = material.ColorName;
            BubblesArray[column, row] = new Bubble(go, material);
            go.name = column.ToString() + “-” +row.ToString();

            var renderer = go.transform.renderer;
            render.material = material;//set color 
               }
            }
        }



          //shooter position
          if(Input.GetButtonDown(“shooter1”)
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
         if(!AreBubbleSelected)
            {
	           if (selectedBubble != null)
            {
	     SelectedBubbles = new List<Bubble>();
         MarkBubbles(selectedBubbles, colum, row, selectedBubble.GameObject.tag);
         if (selectedBubbles.count <minBubblesToRemove)
         {
	       foreach(Bubble el in SelectedBubbles)
		   el.gameObject.transform.renderer.material = el.origianBubbleMaterial;
	       return;
         }
          AreBubblesSelected = true;
           }
       }





//choosing the same colors
else if (AreBubblesSelected)
{
	if (SelectedBubbles.Contains(selectedBubble) && SelectedBubbles.Count >= minBubblesToRemove)
	{
		score+= SelectedBubbles.Count;
foreach (Bubble el in SelectedBubbles)
{
int column2 = int.Parse(selectBubbleGO.name.Split(‘-’)[0]);
int row2 = int.Parse(selectBubbleGO.name.Split(‘-’)[1]);

//dissapearance
GameObject explosion = Instantiate(Explosion, BubllesArray[column2, row2].GameObject.transform.position, BubblesArray[column2, row2].GameObject.transform.rotation) as GameObject;
Destroy(explosion, 1f);
if (settingsManager.Sound) Camera.audio.Play();
Destroy(BubllesArray[column2, row2].GameObject);
BubblesArray[column2, row2] = null;
}
ReallocateBubbles();
	}
}
else
{
foreach (Bubble el in SelectedBubbles)
{
		el.GameObject.renderer.material = el. OriginalBubbleMaterial;
}
}
AreBubblesSelected = false;
}//

    }

    // Update is called once per frame
    void Update()
    {

    }
}
