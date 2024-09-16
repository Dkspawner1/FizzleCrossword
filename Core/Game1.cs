using MonoGame.Extended.Screens;
using FizzleCrossword.DebugGUI;
using FizzleCrossword.DebugGUI.Attributes;
using FizzleCrossword.Managers;

namespace FizzleCrossword.Core;

public class Game1 : Game, IDebuggable
{
    private SceneManager sceneManager;
    private readonly ScreenManager screenManager;
    private SpriteBatch spriteBatch;
    private TransitionManager transitionManager;


    public Game1()
    {
        _ = new GraphicsDeviceManager(this)
        {
            PreferredBackBufferWidth = Data.Window.Width,
            PreferredBackBufferHeight = Data.Window.Height,
            SynchronizeWithVerticalRetrace = true,
        };
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        IsFixedTimeStep = true;

        Window.Title = Data.Window.Title;
        Window.AllowUserResizing = true;
        Window.AllowAltF4 = true;

        screenManager = new ScreenManager();
        Components.Add(screenManager);
    }

    protected override void Initialize()
    {
        transitionManager = new(this);
        transitionManager.TargetBackgroundColor = Color.DeepPink;

        sceneManager = new(this, screenManager);
        sceneManager.ChangeScene(SCENES.MENU);
        base.Initialize();
    }

    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);

    }

    protected override void Update(GameTime gameTime)
    {
        if (Data.Window.Exit)
            Exit();

        transitionManager.Update(gameTime);


        if (!transitionManager.IsTransitioning())
        {

        }

        base.Update(gameTime);
    }



    protected override void Draw(GameTime gameTime)
    {
        transitionManager.Draw(spriteBatch);

        if (!transitionManager.IsTransitioning())
        {

        }
        base.Draw(gameTime);
    }
    public void SetTransitionState(bool transitioning) => transitionManager.SetTransitionState(transitioning);
}
