using UnityEngine;

public abstract class PlayerState : BaseState<PlayerStateManager.EPlayerState>
{
    protected PlayerContext Context;

    public PlayerState(PlayerContext context, PlayerStateManager.EPlayerState stateKey) : base(stateKey){

    }
}
