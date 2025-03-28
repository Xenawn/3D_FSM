using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerInputs playerInput { get; private set; } // PlyaerActions 데이터 담아놓기 
    public PlayerInputs.PlayerActions playerActions { get; private set; }

    private void Awake()
    {
        playerInput = new PlayerInputs();
        playerActions = playerInput.Player;
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }
}
