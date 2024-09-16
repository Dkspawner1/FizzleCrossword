using FizzleCrossword.ECS.Components;
using FizzleCrossword.Scenes;
using MonoGame.Extended.ECS.Systems;
using MonoGame.Extended.Graphics;

namespace FizzleCrossword.ECS.Systems;

public class RenderSystem : EntityDrawSystem
{
    private readonly SpriteBatch spriteBatch;
    private ComponentMapper<ButtonComponent> buttonMapper;
    public RenderSystem(SpriteBatch spriteBatch) : base(Aspect.All(typeof(ButtonComponent))) => this.spriteBatch = spriteBatch;
    public override void Initialize(IComponentMapperService mapperService)
    {
        buttonMapper = mapperService.GetMapper<ButtonComponent>();
    }
    public override void Draw(GameTime gameTime)
    {

        spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp);
        foreach (var entity in ActiveEntities)
        {
            var button = buttonMapper.Get(entity);
            var transform = button.Transform;
            var sprite = button.Sprite;
            sprite.Draw(spriteBatch, transform.Position, transform.Rotation, transform.Scale);

        }
        spriteBatch.End();

    }
}
