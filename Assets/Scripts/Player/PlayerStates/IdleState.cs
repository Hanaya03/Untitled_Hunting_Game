using UnityEngine;

public class IdleState : PlayerState
{
    public IdleState(PlayerContext context, PlayerStateManager.EPlayerState estate) : base(context, estate){
        PlayerContext Context = context;
    }

    public override void EnterState()
    {
        Debug.Log("Entering idle state!");
    }

    public override void ExitState()
    {
        Debug.Log("Exiting idle state!");
    }

    public override void UpdateState()
    {
        Debug.Log("Updating idle state!");
    }

    public override PlayerStateManager.EPlayerState GetNextState()
    {
        return StateKey;
    }

    public override void OnTriggerEnter(Collider other){}
    public override void OnTriggerStay(Collider other){}
    public override void OnTriggerExit(Collider other){}
}
