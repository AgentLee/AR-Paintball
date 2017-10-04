using UnityEngine;

public class MobileNetwork : Photon.PunBehaviour
{
    void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
    }
    
    // TODO-2.a: the same as 1.b
    //   and join a room

    // LOOK-1.b: creating a room on PC
    void Start()
    {
        // Make sure "Auto-Join Lobby" was checked at 
        //   Assets-> Photon Unity Networking-> PhotonServerSettings
        //   so the application will automatically connect to Lobby
        //   and call OnJoinedLobby()
        PhotonNetwork.ConnectUsingSettings("0.1");
    }

    public override void OnJoinedLobby()
    {
        //PhotonNetwork.CreateRoom(null);
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinedRoom()
    {
        GetComponent<MobileShooter>().Activate();
    }
}