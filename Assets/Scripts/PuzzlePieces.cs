using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePieces : MonoBehaviour
{
    //Variables
    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;

    // Start is called before the first frame update
    void Start()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(150f, 450f), Random.Range(150f, -90f));
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, RightPosition) < 0.5f)
        {
            if (!Selected)
            {
                transform.position = RightPosition;
                InRightPosition = true;
            }
        }
    }
}
