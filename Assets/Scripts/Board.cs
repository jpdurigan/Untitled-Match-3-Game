using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Board : MonoBehaviour
{
    public static Board Instance { get; private set; }

    public Row[] rows;

    public Tile[,] Tiles { get; private set; }

    public int Width => Tiles.GetLength(dimension:0);
    public int Height => Tiles.GetLength(1);

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Tiles = new Tile[Width, Height];

        for (var y = 0; y < Height; y++)
        {
            for (var x = 0; x < Width; x++)
            {
                Tiles[x, y] = rows[y].tiles[x];
            }
        }

        
    }
}