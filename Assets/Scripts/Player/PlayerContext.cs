using UnityEngine;

public class PlayerContext
{
    private Rigidbody _playerRB;

    public PlayerContext(Rigidbody playerRB){
        _playerRB = playerRB;
    }

    public Rigidbody playerRB => _playerRB;

}
