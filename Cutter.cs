using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter : MonoBehaviour
{
    [SerializeField] private Transform leftPosition;
    [SerializeField] private Transform rightPosition;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private bool isLeft;
    [SerializeField] private bool isCutted;

    void Start()
    {
        isCutted = true;
    }

    public void OnClickRightButton()
    {
        isCutted = false;
        isLeft = false;
        spriteRenderer.flipX = true;
        transform.position = rightPosition.position;
    }

    public void OnClickLeftButton()
    {
        isCutted = false;
        isLeft = true;
        spriteRenderer.flipX = false;
        transform.position = leftPosition.position;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Пенечек");
        if (isCutted == false)
        {
            if ((collision.gameObject.tag == "left" && isLeft) || (collision.gameObject.tag == "right" && !isLeft))
            {
                Debug.LogError("You lose");
                //Destroy(gameObject);
            }

            Destroy(collision.gameObject);
            isCutted = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isCutted = true;
    }
}
