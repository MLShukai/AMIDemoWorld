
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class HeadTracker : UdonSharpBehaviour
{
    private RenderTexture _renderTexture;
    [SerializeField]
    private Camera _camera;
    [SerializeField]
    private Material _screenMaterial;
    [SerializeField]
    private string[] _targetPlayerDisplayNameList;

    private VRCPlayerApi _targetPlayer;

    private void Start()
    {
        _camera.enabled = true;
        _renderTexture = new RenderTexture(1280, 720, 0, RenderTextureFormat.ARGB32);
        _camera.targetTexture = _renderTexture;
        _screenMaterial.SetTexture("_MainTex", _renderTexture);

        TrySetTargetPlayer(Networking.LocalPlayer);
    }

    private void Update()
    {
        var headPosition = _targetPlayer.GetBonePosition(HumanBodyBones.Head);
        var headRotation = _targetPlayer.GetBoneRotation(HumanBodyBones.Head);
        this.transform.position = headPosition;
        this.transform.rotation = headRotation;
    }

    public override void OnPlayerJoined(VRCPlayerApi player)
    {
        TrySetTargetPlayer(player);
    }

    private void TrySetTargetPlayer(VRCPlayerApi player)
    {
        foreach (var targetPlayerDisplayName in _targetPlayerDisplayNameList)
        {
            if (player.displayName == targetPlayerDisplayName)
            {
                _targetPlayer = player;
                break;
            }
        }
    }
}
