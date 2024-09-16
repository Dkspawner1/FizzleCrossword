using System;
using System.Runtime.InteropServices;
using MonoGame.Extended;
using MonoGame.Extended.Graphics;

namespace FizzleCrossword.ECS.Components;
public class ButtonComponent(Texture2D texture, Transform2 transform, [Optional] Action onClickAction)
{
    public Sprite Sprite = new(texture);
    public Transform2 Transform = transform;
    public Action OnClickAction => onClickAction;

}