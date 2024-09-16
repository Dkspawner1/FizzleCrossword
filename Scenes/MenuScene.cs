using FizzleCrossword.ECS.Entities;
using FizzleCrossword.ECS.Systems;
using FizzleCrossword.Managers;
using MonoGame.Extended;

namespace FizzleCrossword.Scenes;

public class MenuScene : SceneBase
{
    public MenuScene(Game1 game, SceneManager sceneManager) : base(game, sceneManager, [spriteBatch => new RenderSystem(spriteBatch), _ => new ButtonUpdateSystem()])
    {

    }
    public override void Initialize()
    {
    }
    public override void LoadContent()
    {
        base.LoadContent();
        var button0 = new Button(world, new(Game.Content.Load<Texture2D>("textures/btn0"), new Transform2(new Vector2(5, 100), 0f, new Vector2(0.2f, 0.2f)), () => { SceneManager.ChangeScene(SCENES.GAME); }));
        var button1 = new Button(world, new(Game.Content.Load<Texture2D>("textures/btn1"), new Transform2(new Vector2(5, 500), 0f, new Vector2(0.2f, 0.2f)), () => { SceneManager.ChangeScene(SCENES.GAME); }));
        var button2 = new Button(world, new(Game.Content.Load<Texture2D>("textures/btn2"), new Transform2(new Vector2(5, 800), 0f, new Vector2(0.2f, 0.2f)), () => { Game.Exit(); }));
    }
    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
    }
    public override void Draw(GameTime gameTime)
    {
        base.Draw(gameTime);
    }

    public override void DrawDebugInfo(SpriteBatch spriteBatch, SpriteFont spriteFont)
    {
        throw new System.NotImplementedException();
    }
}
