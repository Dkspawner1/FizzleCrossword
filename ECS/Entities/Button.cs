
using FizzleCrossword.ECS.Components;

namespace FizzleCrossword.ECS.Entities;
public class Button
{
    protected Entity entity;
    public Button(World world, ButtonComponent buttonComponent)
    {
        entity = world.CreateEntity();
        entity.Attach(buttonComponent);
    }

}