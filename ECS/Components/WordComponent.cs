using System.Collections.Generic;
using System.Linq;

namespace FizzleCrossword.ECS.Components;

public record struct WordComponent(string word, Vector2 position, Orientation Orientation, int number)
{
    public List<string> Clues { get; init; } = [];
    public List<LetterComponent> Letters { get; set; } = [];
    public bool IsWordCompleted => Letters.All(l => l.Correct);
}
