using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    public SpriteRenderer[] tiles;
    public float speed;
    void Start()
    {
        
    }

    
    void Update()
    {
        for(int i=0;i<tiles.Length;i++)
        {
            tiles[i].transform.Translate(new Vector2(-1, 0 )* Time.deltaTime * speed);
        }
    }
}
