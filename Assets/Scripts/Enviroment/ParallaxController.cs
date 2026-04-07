using UnityEngine;

public class ParallaxController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float parallax;
    Material mat;

    Transform cam;
    Vector3 initialPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mat = this.GetComponent<SpriteRenderer>().material;
        cam = Camera.main.transform;
        initialPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(cam.position.x, initialPos.y, initialPos.z);
        mat.mainTextureOffset = new Vector2(cam.position.x * parallax, 0);
    }
}
