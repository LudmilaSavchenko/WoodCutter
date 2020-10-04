using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCut : MonoBehaviour
{
    [SerializeField] private int cutterTime=3;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CutTree());
    }

    // Update is called once per frame

    IEnumerator CutTree()
    {
        do
        {
            yield return new WaitForSeconds(cutterTime);

            yield return new WaitForFixedUpdate();

            TreeGenerate.Instance.DestroyFirstStump();
        } while (true);
    }
}
