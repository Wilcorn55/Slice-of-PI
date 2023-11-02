using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropPuzzle : MonoBehaviour
{
    //Variables
    public GameObject SelectedPiece;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Puzzle"))
            {
                if (!hit.transform.GetComponent<PuzzlePieces>().InRightPosition)
                {
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<PuzzlePieces>().Selected = true;
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {            
            SelectedPiece.GetComponent<PuzzlePieces>().Selected = false;
            SelectedPiece = null;
        }

        if (SelectedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
    }
}
