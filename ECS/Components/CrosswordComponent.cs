using System.Collections.Generic;
using System.Linq;

namespace FizzleCrossword.ECS.Components;

public class CrosswordComponent
{
    public SpriteFont font;
    public Dictionary<Vector2, LetterComponent> Grid { get; set; } = [];
    public List<WordComponent> Words { get; set; }
    public Vector2 GridSize { get; set; }
    public float CellSize { get; set; }
    public bool IsPuzzleCompleted() => Words.All(w => w.Letters.All(l => l.Correct));


}
