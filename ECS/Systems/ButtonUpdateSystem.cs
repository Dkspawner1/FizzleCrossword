using FizzleCrossword.ECS.Components;
using MonoGame.Extended.ECS.Systems;

namespace FizzleCrossword.ECS.Systems;
public class ButtonUpdateSystem : EntityUpdateSystem
{
    private ComponentMapper<ButtonComponent> buttonMapper;
    private MouseState ms, oldMs;
    private Rectangle mouseRect;
    public ButtonUpdateSystem() : base(Aspect.All(typeof(ButtonComponent)))
    {

    }
    public override void Initialize(IComponentMapperService mapperService)
    {
        buttonMapper = mapperService.GetMapper<ButtonComponent>();
    }

    public override void Update(GameTime gameTime)
    {
        oldMs = ms;
        ms = Mouse.GetState();
        mouseRect = new Rectangle(ms.X, ms.Y, 1, 1);

        foreach (var entity in ActiveEntities)
        {
            var button = buttonMapper.Get(entity);
            var onClick = button.OnClickAction;

            if (mouseRect.Intersects((Rectangle)button.Sprite.GetBoundingRectangle(button.Transform)))
            {
                button.Sprite.Color = Color.Gray;
                if (oldMs.LeftButton == ButtonState.Pressed && ms.LeftButton == ButtonState.Released)
                    onClick?.Invoke();
            }
            else button.Sprite.Color = Color.White;
        }
    }
}