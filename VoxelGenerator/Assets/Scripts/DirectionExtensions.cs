using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DirectionExtensions
{
    public static Vector3Int GetVector(this Direction direction)
    {
        return Vector3Int.RoundToInt(GetTheVector(direction));
    }

    public static Vector3 GetTheVector(Direction direction)
    {
        switch (direction)
        {
            case Direction.up:
                return Vector3.up;
            case Direction.down:
                return Vector3.down;
            case Direction.right:
                return Vector3.right;
            case Direction.left:
                return Vector3.left;
            case Direction.foreward:
                return Vector3.forward;
            case Direction.backwards:
                return Vector3.back;
            default:
                throw new Exception("Invalid input direction");
        }
    }
}
