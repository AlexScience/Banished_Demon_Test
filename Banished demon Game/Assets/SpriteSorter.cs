using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSorter : MonoBehaviour
{
    public float offset = 0;
    public bool isStatic = false;

    private int sortingOrderBase = 0;
    private Renderer renderer;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }
    private void LateUpdate()
    {
        renderer.sortingOrder = (int)(sortingOrderBase - transform.position.y + offset);

        if (isStatic)
        {
            Destroy(this);
        }
    }
}
