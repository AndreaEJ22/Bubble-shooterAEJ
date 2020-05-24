using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject RedBubble;
    //Initializes the bubble
    private void start()
    {
        CreateBubblesUpdate(7);
    }
    // Update is called once per frame
    void CreateBubblesUpdate(int Bubblenum)
    {
        //clones
        for (int i=0; i < Bubblenum; i++)
        {
           GameObject RedBubbleclone = Instantiate(RedBubble);
        }
    }
}
