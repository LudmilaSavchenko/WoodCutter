using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerate : MonoBehaviour
{
    [SerializeField] private GameObject[] treePrefabs; // класс для префабов пеньков
    [SerializeField] private GameObject treePrefabStumpDefault; // пенек без ветвей
    [SerializeField] private int treeLenght=10; //длинна дерева\ количество пеньков 
    private int defaultStumpCount; //сколько обычных пеньков было от прошлой ветки
    [SerializeField] private int defaultStumpQuantity=2; //Сколько обычных пеньков должно быть между ветками

    [SerializeField] public List<SpawnTree> ins = new List<SpawnTree>();

    private GameObject tempTree;

    #region Singleton
    public static TreeGenerate Instance { get; private set; }
    #endregion
    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        do
        {
            CreateStump();
        } while (ins.Count < treeLenght);       
    }

    void FixedUpdate()
    {
        if (ins.Count < treeLenght)
        {
            CreateStump();
        }
    }
    private void CreateStump()
    {
        if (defaultStumpCount < defaultStumpQuantity)
        {
            tempTree = (GameObject)Instantiate(treePrefabStumpDefault, transform);
            defaultStumpCount++;
        }
        else
        {
            tempTree = (GameObject)Instantiate(treePrefabs[Random.Range(0, treePrefabs.Length)], transform);
            defaultStumpCount = 0;
        }

        SpawnTree tree = new SpawnTree();
        tree.instantiated = tempTree;
        ins.Add(tree);
        tempTree.transform.name = tempTree.transform.name + ins.Count;
    }

    public void DestroyFirstStump()
    {
        Destroy(ins[0].instantiated);
        ins.Remove(ins[0]);
    }
    
}

public class SpawnTree
{
    public GameObject instantiated;
}
