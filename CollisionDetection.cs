﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] private Cutter cutter;

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("OnTriggerStay2D");
      //  if (cutter.IsCutted == false)
      //  {
         //   if ((collision.gameObject.tag == "left" && cutter.IsLeft) || (collision.gameObject.tag == "right" && !cutter.IsLeft))
            if (collision.gameObject.tag == "left" || collision.gameObject.tag == "right")
            {
                Debug.LogError("You lose");
                Time.timeScale = 0;
                //Destroy(gameObject);
            }

          
          //  Destroy(collision.gameObject);
          //  cutter.IsCutted = true;
      //  }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
      //  Debug.Log("OnTriggerExit2D");
      //  cutter.IsCutted = true;
    }
}
