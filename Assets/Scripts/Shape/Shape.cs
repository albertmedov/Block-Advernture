using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public GameObject SquareShapeImage;
    [HideInInspector] 
    public ShapeData CurrentShapeData;
    
    private List<GameObject> _currentShape = new List<GameObject>();
    void Start()
    {
        
    }

    public float GetXpositionForShapeSquare(ShapeData shapeData, int column, Vector2 moveDsitance)
    {
        float shiftonX = 0f;
        if (shapeData.columns > 1)
        {
            if (shapeData.columns % 2 != 0)
            {
                var middleSquareIndex = (shapeData.columns - 1) / 2;
                var multiplier = (shapeData.columns - 1) / 2;
                if (column < middleSquareIndex)
                {
                    shiftonX = moveDsitance.x * -1;
                    shiftonX *= multiplier;
                }
                else if (column > middleSquareIndex)
                {
                    shiftonX = moveDsitance.x * 1;
                    shiftonX *= multiplier;
                }
                else
                {
                    var middleSquareIndex2 = (shapeData.columns == 2) ? 1 : (shapeData.columns / 2);
                    var middleSquareIndex1 = (shapeData.columns == 2) ? 0 : shapeData.columns - 2;
                    var multiplier = shapeData.columns / 2;
                    if (column == middleSquareIndex1 || column == middleSquareIndex2)
                    {
                        if (column == middleSquareIndex2)
                            shiftonX = moveDsitance.x / 2;
                        if (column == middleSquareIndex1)
                            shiftonX = (moveDsitance.x / 2) * -1;
                    }

                    if (column < middleSquareIndex1 && column < middleSquareIndex2)
                    {
                        shiftonX = moveDsitance.x * -1;
                        shiftonX *= multiplier;
                    }
                    else if (column > middleSquareIndex1 && column > middleSquareIndex2)
                    {
                        shiftonX = moveDsitance.x * 1;
                        shiftonX *= multiplier;
                    }
                }
            }
        }
        return shiftonX;
    }
    
    
    private int GetNumberOfSquares(ShapeData shapeData)
    {
        int number = 0;

        foreach (var rowData in shapeData.board)
        {
            foreach (var active in rowData.column)
            {
                if (active)
                    number++;
            }
        }

        return number;
    }
    
}
