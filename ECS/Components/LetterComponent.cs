namespace FizzleCrossword.ECS.Components;

public record struct LetterComponent(char letter, Vector2 position)
{
    public readonly char Letter { get; } = letter;
    public char Guess { get; set; } = ' ';
    public bool Correct => Guess.Equals(Letter);
    public Vector2 Position { get; init; } = position;

}
