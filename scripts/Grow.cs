using UnityEngine;
using System.Collections;

public class Grow : MonoBehaviour
{
    public Shader NewSurfaceShader;
  
    public Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
       
    
        NewSurfaceShader = Shader.Find("Custom/NewSurfaceShader");
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "cube")
        {
            rend.material.SetFloat("Extrusion Amount",1f);

            Destroy(col.gameObject);
        }
    }
}
