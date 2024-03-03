using Photon.Pun;
using UnityEngine;

public class RoomPlayer : MonoBehaviour
{
    PhotonView pv;
    public GameObject networkGo;
    private void Awake()
    {
        pv = GetComponent<PhotonView>();
        networkGo.SetActive(!pv.IsMine);
    }
}
