using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter : MonoBehaviour
{
    [SerializeField] private Transform leftPosition;
    [SerializeField] private Transform rightPosition;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private bool isLeft;
    public bool IsLeft
    {
        get { return isLeft; }
    }

    [SerializeField] private bool isCutted;
    public bool IsCutted
    {
        get { return isCutted; }
        set { isCutted = value; }
    }
    void Start()
    {
      //  isCutted = true;
    }

    public void OnClickRightButton()
    {
     //   isCutted = false;
        isLeft = false;
        spriteRenderer.flipX = true;
        transform.position = rightPosition.position;
    }

    public void OnClickLeftButton()
    {
     //   isCutted = false;
        isLeft = true;
        spriteRenderer.flipX = false;
        transform.position = leftPosition.position;
    }

   
}
