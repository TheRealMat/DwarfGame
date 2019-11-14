using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    public List<Sprite> animWalk = new List<Sprite>{
    };
    public List<Sprite> animMine = new List<Sprite>{
    };



    public Sprite Walk(Sprite currentSprite)
    {
        if (animWalk.IndexOf(currentSprite) >= animWalk.Count - 1)
        {
            return animWalk[0];
        }
        else
        {
            return animWalk[animWalk.IndexOf(currentSprite) + 1];
        }
    }









}