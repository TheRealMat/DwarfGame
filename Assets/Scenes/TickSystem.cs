using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TickSystem : MonoBehaviour
{
    private int tick;
    private float tickTimer;
    const float TICK_TIMER_MAX = 0.2f;
    public class OnTickEventArgs : EventArgs
    {
        public int tick;
    }
    public static event EventHandler<OnTickEventArgs> OnTick;

    private void wake()
    {
        tick = 0;
    }
    private void Update()
    {
        tickTimer += Time.deltaTime;
        if (tickTimer >= TICK_TIMER_MAX)
        {
            tickTimer -= TICK_TIMER_MAX;
            tick++;
            if (OnTick != null) OnTick(this, new OnTickEventArgs {tick = tick});
        }
    }
}
