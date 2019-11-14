using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walktest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TickSystem.OnTick += delegate (object sender, TickSystem.OnTickEventArgs e)
        {
            if (transform.position.x != 0)
            {
                WalkTo(0);
            }
            if (transform.position.x == 0)
            {
                Mine();
            }


        };
    }

    private void WalkTo(int locationX)
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
    private void Mine()
    {
        if (transform.position.x == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = GameObject.Find("GameManager").GetComponent<AnimationHandler>().Mine(gameObject.GetComponent<SpriteRenderer>().sprite);

        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            transform.position = new Vector2(transform.position.x + 1, transform.position.y);
        }

    }
}
