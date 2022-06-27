using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Ruby : Item
{
    public Texture2D ruby_tex;

    public Ruby()
    {
        ruby_tex = (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/ruby.png", typeof(Texture2D));
        item_image = Sprite.Create(ruby_tex, new Rect(0, 0, ruby_tex.height, ruby_tex.width), new Vector2(0.5f, 0.5f), 100.0f);
    }
}
