using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walktest : MonoBehaviour
{
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        Vector2 goal = new Vector2(20, -56); // 56 is because of the offset of the sprite
        Vector2 intermediateGoal;



        TickSystem.OnTick += delegate (object sender, TickSystem.OnTickEventArgs e)
        {
            // are we at our goal?
            if (transform.position.x == goal.x)
            {

            }
            // if we're not at our goal
            else
            {
                // if goal is not on the same level as us
                if (goal.y != transform.position.y)
                {
                    // set intermediate goal to be door of current level
                    intermediateGoal = new Vector2(0, transform.position.y);
                }
                // if goal is on same level as us
                else
                {
                    intermediateGoal = goal;
                }
                WalkTo(intermediateGoal.x);
                // if we're at the door teleport to correct floor
                if (transform.position.x == intermediateGoal.x)
                {
                    transform.position = new Vector2(transform.position.x, goal.y);
                }
            }

        };
    }


    private void WalkTo(float locationX)
    {
        // walk to 0
        if (transform.position.x != locationX)
        {
            // walk right to 0
            if (transform.position.x < locationX)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = GameObject.Find("GameManager").GetComponent<AnimationHandler>().Minek(gameObject.GetComponent<SpriteRenderer>().sprite);
                transform.position = new Vector2(transform.position.x + 1, transform.position.y);
            }
            // walk left to 0
            if (transform.position.x > locationX)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = GameObject.Find("GameManager").GetComponent<AnimationHandler>().Minek(gameObject.GetComponent<SpriteRenderer>().sprite);
                transform.position = new Vector2(transform.position.x - 1, transform.position.y);
            }
        }
    }
}










//private void Mine()
//{
//    if (transform.position.x == 0)
//    {
//        gameObject.GetComponent<SpriteRenderer>().sprite = GameObject.Find("GameManager").GetComponent<AnimationHandler>().Mine(gameObject.GetComponent<SpriteRenderer>().sprite);

//    }
//}
//private void InteractDoor()
//{
//    sprite.sortingLayerName = "DoorEnterLayer";
//    transform.position = new Vector2(transform.position.x + 1, transform.position.y);
//}
