﻿using UnityEngine;
using System.Collections;
using Algorithms;
/*
public static class paintCamera
{
	static Vector2 lastUV;
	static Texture2D canvas = new Texture2D(200,200,TextureFormat.RGB24,false);

	public static void DrawOnLine(Vector3 start, Vector3 end)
	{
<<<<<<< HEAD
		cam = GetComponent<Camera>();
		canvas = new Texture2D(2000,2000, TextureFormat.ARGB32, false);
=======
		int layerMask = 1 << 11;
		RaycastHit hit;
		if(!Physics.Raycast(new Ray(start, end-start), out hit, 20f, layerMask))
			return;

		if(!Draw(hit))
			return;
>>>>>>> New_Master
	}

	public static void DrawAtMouse(Camera cam)
	{
<<<<<<< HEAD
        if (!Input.GetKey(KeyCode.Mouse0))
            hold = false;

        RaycastHit hit;
=======
		if (!Input.GetKey(KeyCode.Mouse0))
			return;

		RaycastHit hit;
>>>>>>> New_Master
		if (!Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit))
			return;

		if (!Draw(hit))
			return; 
	}

	static bool Draw(RaycastHit hit)
	{
		Renderer rend = hit.transform.GetComponent<Renderer>();
		MeshCollider meshCollider = hit.collider as MeshCollider;
		rend.sharedMaterial.mainTexture = canvas;
		if (rend == null || rend.sharedMaterial == null || rend.sharedMaterial.mainTexture == null || meshCollider == null)
			return false;
		
		Texture2D tex = rend.material.mainTexture as Texture2D;
		Vector2 pixelUV = hit.textureCoord;
        print(pixelUV);
		pixelUV.x *= tex.width;
		pixelUV.y *= tex.height;
<<<<<<< HEAD

		if(hold)
			Bresenham.Line(pixelUV, lastUV, TexturePlot, tex);

        if (Input.GetKeyUp(KeyCode.C))
        {
            Bresenham.Ellipse(pixelUV, 300, 600, TexturePlot, tex);
            Bresenham.Circle(pixelUV, 300, TexturePlot, tex);
        }

        tex.Apply();
=======
		tex.SetPixel((int)pixelUV.x, (int)pixelUV.y, Color.black);
		Bresenham.Line(pixelUV,lastUV,LinePlot,tex);
		tex.Apply();
>>>>>>> New_Master
		lastUV = pixelUV;
		return true;
	}

<<<<<<< HEAD
	bool TexturePlot(int x, int y, Texture2D tex)
=======
	static bool LinePlot(int x, int y)
>>>>>>> New_Master
	{
        tex.SetPixel(x, y, color);
        return true;
	}

    bool GrayScaleTexturePlot(int x, int y, Texture2D tex, float alpha)
    {
        tex.SetPixel(x, y, new Color(alpha, alpha, alpha));
        return true;
    }
}
*/