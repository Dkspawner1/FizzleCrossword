using System;
using FizzleCrossword.ECS.Systems;
using FizzleCrossword.Managers;
using FizzleCrossword.DebugGUI.Attributes;
using MonoGame.Extended.ECS.Systems;
using Microsoft.Xna.Framework.Content;
using MonoGame.Extended.Graphics;

namespace FizzleCrossword.Scenes;
public class GameScene : SceneBase
{
    [DebugVariable]
    Vector2 test;

    public GameScene(Game1 game, SceneManager sceneManager)
       : base(game, sceneManager, [spriteBatch => new RenderSystem(spriteBatch),])
    {
    }
    public override void Initialize()
    {
        base.Initialize();
    }
    public override void LoadContent()
    {
        base.LoadContent();
    }
    protected override void UpdateScene(GameTime gameTime)
    {
        // Add game-specific update logic here
        // This will only be called after the fade-in transition is complete
    }

    protected override void DrawScene(GameTime gameTime)
    {

    }


    public override void DrawDebugInfo(SpriteBatch spriteBatch, SpriteFont spriteFont)
    {
        // Implement your debug drawing logic here
        // For example:
        spriteBatch.DrawString(spriteFont, $"Test Vector: {test}", new Vector2(10, 10), Color.White);
        spriteBatch.DrawString(spriteFont, $"Test Vector: {test}", new Vector2(10, 10), Color.White);
        spriteBatch.DrawString(spriteFont, $"Test Vector: {test}", new Vector2(10, 10), Color.White);
        spriteBatch.DrawString(spriteFont, $"Test Vector: {test}", new Vector2(10, 10), Color.White);
        spriteBatch.DrawString(spriteFont, $"Test Vector: {test}", new Vector2(10, 10), Color.White);
        spriteBatch.DrawString(spriteFont, $"Test Vector: {test}", new Vector2(10, 10), Color.White);
        spriteBatch.DrawString(spriteFont, $"Test Vector: {test}", new Vector2(10, 10), Color.White);
        spriteBatch.DrawString(spriteFont, $"Test Vector: {test}", new Vector2(10, 10), Color.White);
        spriteBatch.DrawString(spriteFont, $"Test Vector: {test}", new Vector2(10, 10), Color.White);
        spriteBatch.DrawString(spriteFont, $"Test Vector: {test}", new Vector2(10, 10), Color.White);
        spriteBatch.DrawString(spriteFont, $"Test Vector: {test}", new Vector2(10, 10), Color.White);

    }

}
