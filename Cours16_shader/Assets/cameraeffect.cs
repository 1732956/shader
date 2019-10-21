using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class cameraeffect : MonoBehaviour {
    private Material mat;
	// Use this for initialization
	void Awake () {
        mat = new Material(Shader.Find("Hidden/NewImageEffectShader"));
	}

    private void OnRenderImage(RenderTexture source, RenderTexture destination) {
        Graphics.Blit(source, destination,mat);

    }

	// Update is called once per frame
	void Update () {
		
	}
}
