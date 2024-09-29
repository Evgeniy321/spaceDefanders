using UnityEngine;

public class BackGroundRepeat : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float paralaxMult=20f;
    private MeshRenderer mesh;
    private Material material;
    private Vector2 offset;

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        material = mesh.materials[0];
        offset = material.mainTextureOffset;
    }

    private void Update()
    {
        offset = player.localPosition / paralaxMult;
        material.mainTextureOffset = offset;
    }
}
