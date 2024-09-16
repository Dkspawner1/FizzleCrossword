namespace FizzleCrossword.ECS.Entities;


public class CrosswordPuzzle
{
    protected Entity entity;

    public CrosswordPuzzle(World world)
    {
        entity = world.CreateEntity();

    }




}
