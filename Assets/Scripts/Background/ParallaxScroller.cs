using UnityEngine;

public class ParallaxScroller : MonoBehaviour
{
    [Range(-1f, 1f)]
    public float scrollSpeed = 0.5f;
    private float distance;
    private Material mat;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        distance += Time.deltaTime * scrollSpeed;
        mat.SetTextureOffset("_MainTex", Vector2.right * distance);
    }
}
