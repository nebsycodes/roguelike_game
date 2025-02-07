using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private BoardManager m_Board;
    private Vector2Int m_CellPosition;

    public void Spawn(BoardManager boardManager, Vector2Int cell)
    {
        m_Board = boardManager;
        m_CellPosition = cell;

        // Move to the correct position
        transform.position = m_Board.CellToWorld(cell);
    } // <- Closing brace added here
    private void Update()
{
   Vector2Int newCellTarget = m_CellPosition;
   bool hasMoved = false;

   if(Keyboard.current.upArrowKey.wasPressedThisFrame)
   {
       newCellTarget.y += 1;
       hasMoved = true;
   }
   else if(Keyboard.current.downArrowKey.wasPressedThisFrame)
   {
       newCellTarget.y -= 1;
       hasMoved = true;
   }
   else if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
   {
       newCellTarget.x += 1;
       hasMoved = true;
   }
   else if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
   {
       newCellTarget.x -= 1;
       hasMoved = true;
   }

   if(hasMoved)
   {
       //check if the new position is passable, then move there if it is.
   }
}
}
