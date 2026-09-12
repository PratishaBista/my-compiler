namespace Gneiss.Helpers

{
    enum SyntaxKind
    {
        EndOfFileToken,
        NumberToken,
        NumberExpression,
        BinaryExpression,

        WhitespaceToken,
        PlusToken,
        MinusToken,
        StarToken,
        SlashToken,
        OpenParenthesisToken,
        CloseParenthesisToken,

        BadToken


    }
}