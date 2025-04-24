using UnityEngine;
using UnityEngine.InputSystem;
using System;
using System.Collections.Generic;
public class PlayerManager : MonoBehaviour
{
    [SerializeField] private List<Player> players = new List<Player>();
    private int counter;
    [SerializeField] private CameraFollow camerafollow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SecActivePlayer(counter);
    }
    private void OnEnable()
    {
        InputReader.changePlayer += ChangePlayer;
        InputReader.changeAtras += ChangeBack;
    }
    private void OnDisable()
    {
        InputReader.changePlayer -= ChangePlayer;
        InputReader.changeAtras -= ChangeBack;
    }
    private void ChangePlayer()
    {
        players[counter].Activo = false;
        counter++;
        if (counter >= players.Count)
        {
            counter = 0;
        }
        SecActivePlayer(counter);
    }
    private void ChangeBack()
    {
        players[counter].Activo = false;
        counter--;
        if (counter >= players.Count)
        {
            counter = 0;
        }
        SecActivePlayer(counter);
    }
    private void SecActivePlayer(int count)
    {
        players[count].Activo = true;
        camerafollow.SetChange(players[count].transform);
    }
}
