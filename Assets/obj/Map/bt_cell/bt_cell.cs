using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bt_cell : MonoBehaviour
{

    public Vector2Int coord;
    public GameObject currentObj;
    public cellType type;
    public bool isTree;

    [SerializeField]
    private GameObject gfx_Ground;
    [SerializeField]
    private GameObject gfx_Water;
    [SerializeField]
    private GameObject gfx_tree;

    public void drowCell()
    {
        if (type == cellType.GROUND)
        {
            gfx_Water.SetActive(false);
        }
        else if (type == cellType.WATER)
        {
            gfx_Ground.SetActive(false);
        }

        gfx_tree.SetActive(isTree);
        if (isTree)
        {
            gfx_tree.transform.Rotate(new Vector3(0, Random.Range(0, 360), 0));


        }
    }

    public enum cellType
    {
        GROUND,
        WATER
    }

}
