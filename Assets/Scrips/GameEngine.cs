using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;


public class GameEngine : MonoBehaviour
{
    [SerializeField]
    private int tileCount;
    
    private bt_cell[,] bt_cells;


    [SerializeField]
    private GameObject cellPref;

    void Start()
    {
        generateMap();

        ////Создание танка игрока

        //GameObject playerTank = Instantiate(TankA1Pref);
        //Player = playerTank;
        //direction = 1;
        ////playerTank.transform.position = new Vector3(52, 0, 10);
        //PlacingObject(playerTank, 20, 20);

    }

    private void generateMap()
    {
        bt_cells = new bt_cell[tileCount, tileCount];

        for (int i = 0; i < tileCount - 1; i++)
        {
            for (int j = 0; j < tileCount - 1; j++)
            {
                int CellTypeRnd = UnityEngine.Random.Range(1, 100);


                GameObject newCell = Instantiate(cellPref);

                newCell.transform.position = new Vector3(i, 0, j);
               
                bt_cell temp = newCell.GetComponent<bt_cell>();

                if (CellTypeRnd < 15)
                {
                    temp.type = bt_cell.cellType.WATER;
                }
                else
                {
                    temp.type = bt_cell.cellType.GROUND;
                    if (CellTypeRnd < 45)
                    {
                        temp.isTree = true;
                    }
                }

                temp.coord = new Vector2Int(i, j);

                temp.drowCell();

                bt_cells[i, j] = temp;

            }
        }
    }


    //[SerializeField]
    //private int tileCount;
    //[SerializeField]
    //private GameObject tilePref;
    //[SerializeField]
    //private GameObject TankA1Pref;
    //[SerializeField]
    //private GameObject SnariadPref;

    //private TileImp[,] tilesCell;

    //private GameObject Player;
    //int CurentCellX;
    //int CurentCellY;
    //int direction;

    //public float blockControl;

    //void Start()
    //{
    //    tilesCell = new TileImp[tileCount, tileCount];

    //    for (int i = 0; i < tileCount - 1; i++)
    //    {
    //        for (int j = 0; j < tileCount - 1; j++)
    //        {

    //            GameObject newtile = Instantiate(tilePref);

    //            newtile.transform.position = new Vector3(i, 0, j);

    //            TileImp temp = newtile.GetComponent<TileImp>();

    //            tilesCell[i, j] = temp;

    //        }
    //    }

    //    //Создание танка игрока

    //    GameObject playerTank = Instantiate(TankA1Pref);
    //    Player = playerTank;
    //    direction = 1;
    //    //playerTank.transform.position = new Vector3(52, 0, 10);
    //    PlacingObject(playerTank, 20, 20);

    //}


    //void PlacingObject(GameObject obj, int cellCordX, int cellCordY)
    //{

    //    for (int i = 0; i < tileCount - 1; i++)
    //    {
    //        for (int j = 0; j < tileCount - 1; j++)
    //        {

    //            if (tilesCell[i, j].currentObj == obj)
    //            {
    //                tilesCell[i, j].currentObj = null;
    //            }

    //        }

    //    }

    //    int maxCellX = tileCount - 7-1;
    //    int maxCellY = tileCount - 7-1;

    //    cellCordX = Math.Min(cellCordX, maxCellX);
    //    cellCordY = Math.Min(cellCordY, maxCellY);

    //    CurentCellX = cellCordX;
    //    CurentCellY = cellCordY;

    //    for (int i = cellCordX; i < cellCordX + 7; i++)
    //    {
    //        for (int j = cellCordY; j < cellCordY + 7; j++)
    //        {
    //            tilesCell[i, j].currentObj = obj;
    //        }
    //    }

    //    obj.transform.position = tilesCell[cellCordX, cellCordY].gameObject.transform.position;

    //}
    //private void Shoot()
    //{
    //    GameObject snariad = Instantiate(SnariadPref);
    //    snariad.transform.position = Player.transform.position;

    //    Vector3 snariadDir = Vector3.zero;
    //    if (direction == 1)
    //    {
    //        snariadDir = new Vector3(0, 0, 1);
    //    }
    //    if (direction == 2)
    //    {
    //        snariadDir = new Vector3(0, 0, -1);
    //    }
    //    if (direction == 3)
    //    {
    //        snariadDir = new Vector3(-1, 0, 0);
    //    }
    //    if (direction == 4)
    //    {
    //        snariadDir = new Vector3(1, 0, 0);
    //    }

    //    snariad.GetComponent<SnariadImpl>().dir = snariadDir;
    //}


    //private void Update()
    //{




    //    if (blockControl > 0)
    //    {
    //        blockControl = blockControl - Time.deltaTime;
    //        return;
    //    }

    //    if (Input.GetKey(KeyCode.UpArrow))
    //    {
    //        PlacingObject(Player, CurentCellX, CurentCellY+1);
    //        blockControl = 0.05f;
    //        direction = 1;
    //    }
    //    if (Input.GetKey(KeyCode.DownArrow))
    //    {
    //        PlacingObject(Player, CurentCellX, CurentCellY - 1);
    //        blockControl = 0.05f;
    //        direction = 2;
    //    }
    //    if (Input.GetKey(KeyCode.LeftArrow))
    //    {
    //        PlacingObject(Player, CurentCellX-1, CurentCellY);
    //        blockControl = 0.05f;
    //        direction = 3;
    //    }
    //    if (Input.GetKey(KeyCode.RightArrow))
    //    {
    //        PlacingObject(Player, CurentCellX+1, CurentCellY);
    //        blockControl = 0.05f;
    //        direction = 4;
    //    }

    //    if (Input.GetKey(KeyCode.Space))
    //    {
    //        Shoot();
    //    }
    //}

}
